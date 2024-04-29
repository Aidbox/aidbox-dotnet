# Aidbox .NET SDK Roadmap

## DONE

✅ [Mappings from FHIR resources to C# classes](https://github.com/Aidbox/aidbox-dotnet/tree/e199a43f0a8728f32b15d65e8ec8ecafa604d5ad/src/resource)

✅ [Typed Search Params](https://github.com/Aidbox/aidbox-dotnet/issues/7)

✅ [GetInfo](https://github.com/Aidbox/aidbox-dotnet/blob/e199a43f0a8728f32b15d65e8ec8ecafa604d5ad/src/api/Client.cs#L47-L61)

✅ [Read Resource by Id](https://github.com/Aidbox/aidbox-dotnet/blob/e199a43f0a8728f32b15d65e8ec8ecafa604d5ad/src/api/Client.cs#L63-L89)

✅ [Create Resource](https://github.com/Aidbox/aidbox-dotnet/blob/e199a43f0a8728f32b15d65e8ec8ecafa604d5ad/src/api/Client.cs#L130-L158)

✅ [Delete Resource](https://github.com/Aidbox/aidbox-dotnet/blob/e199a43f0a8728f32b15d65e8ec8ecafa604d5ad/src/api/Client.cs#L160-L191)

✅ [Update Resource](https://github.com/Aidbox/aidbox-dotnet/blob/e199a43f0a8728f32b15d65e8ec8ecafa604d5ad/src/api/Client.cs#L193-L226)

✅ [Search / List Resource](https://github.com/Aidbox/aidbox-dotnet/issues/1) 

#### 

## TODO

### FHIR to C# Mappings


#### [Storing FHIR primitives as corresponding datatypes in C#](https://github.com/Aidbox/aidbox-dotnet/issues/2)
Use appropriate field types for storing fhir dates, date times (and other types) 

```c#
var patient = new Patient();
// instead of string
patient.BirtDate = "2000-01-01";
// use Date type
patient.BirthDate = new DateOnly(2000, 1, 1);
```



#### FHIR "primitive" datatypes

```c#
var fhirBool = new FhirBoolean(true);
var fhirString = new FhirString("sample string");
var fhirDate = new FhirDate("2024-01-01");
...
```



#### [Polymorphic fields](https://github.com/Aidbox/aidbox-dotnet/issues/6)

Instead of using one of the fields like here

```c#
var patient = new Patient();
patient.DeceasedBoolean = true;
// or
patient.DeceasedDateTime = new DateOnly("2024-01-01") 
```

Use polymorphic field

```c#
var patient = new Patient();
patient.Deceased = new FhirBoolean(true);
// or
patient.Deceased = new FhirDateTime("2024-01-01T100:00:00") 
```



#### [Constrain possible values for codes](https://github.com/Aidbox/aidbox-dotnet/issues/5)

Value sets as enums
```c#
enum AdministrativeGender 
{
  Male,
  Female,
  Other,
  Unknown
}

var patient = new Patient();
patient.Gender = AdministrativeGender.Unknown;
```

Or value sets as union types

```c#
public abstract record AdministrativeGender
{   
    private AdministrativeGender(){ }
    public record Male(): AdministrativeGender;
    public record Female() : AdministrativeGender;
    public record Other() : AdministrativeGender;
    public record Unknown() : AdministrativeGender;
}

var patient = new Patient();
patient.Gender = AdministrativeGender.Unknown();
```



#### FHIR extensions

Make it possible to add extensions.

```c#
var patient = new Patient();
var mothersName = new Extension("http://hl7.org/fhir/StructureDefinition/patient-mothersMaidenName", "Doe");

patient.Extension.Add(patient);
```



#### List / circular structure / recursive structure

There are fields with the same name as resources in FHIR. It is not allowed to have the same property name as a class name. Come up with a workaround.



#### Reference [re-design Reference class] (aidbox format)

Problem: we don't want to concat string every time "Patient" + "/" + "<uuid>"

```c#
// FHIR: { reference: "Patient/<uuid>" }
// AIDBOX: { resourceType: Patient, id: <uuid> }

patient.managingOrganization = new Reference<Organization>() { id:<uuid> }

JsonParse(patient) => { "name": [], "managingOrganization": { "reference": "Organization/<uuid>" } } 
```



#### First-Class extensions (aka aidbox format)

It is hard to reach the exact extension in array with nested extensions.  Implement a convenient way of extractting data from extension.

Given example of patient data:

```json
{
  "resourceType" : "Patient",
  "id" : "child-example",
  "meta" : {
    "profile" : ["http://hl7.org/fhir/us/core/StructureDefinition/us-core-patient|7.0.0"]
  },
  "extension" : [
    {
      "extension" : [
        {
          "url" : "ombCategory",
          "valueCoding" : {
            "system" : "urn:oid:2.16.840.1.113883.6.238",
            "code" : "2028-9",
            "display" : "Asian"
          }
        },
        {
          "url" : "text",
          "valueString" : "Asian"
        }
      ],
      "url" : "http://hl7.org/fhir/us/core/StructureDefinition/us-core-race"
    },
    ...
    {
      "url" : "http://hl7.org/fhir/us/core/StructureDefinition/us-core-birthsex",
      "valueCode" : "M"
    },
    {
      "url" : "http://hl7.org/fhir/us/core/StructureDefinition/us-core-sex",
      "valueCode" : "248153007"
    }
  ]
}
```



Instead of extracting patient extension data like in the next example:

```c#
var raceExtension = patient.extension.FirstOrDefault(e => e["url"].ToString() == "http://hl7.org/fhir/us/core/StructureDefinition/us-core-race");

var raceText = raceExtension.extension.FirstOrDefault(e => e["url"].ToString() == "text")["valueString"];
```

We would like to provide a more convenient way:

```c#
var raceName = patient.Race.Text;
```



### Profiles

#### Implement FHIR Profiles Patterns

```json
{
  "code": {
    "pattern": {
      "coding": [
        {
          "system": "http://loinc.org",
          "code": "29549-3",
          "display": "Medication administered Narrative"
        }
      ]
    }
  }
}
```



```c#
class CodeableConcept1 : CodeableConcept {
  readonly coding: [new Conding295493() { System = "http://loinc.org", Code = "29549-3"}]
}
```



#### Bindings  (resource code type suggestion from CodeSystem)

`patient.gender = male | female`



### Client methods

#### PATCH method

Link to aidbox doc: https://docs.aidbox.app/api-1/api/crud-1/patch#merge-patch

```c#
var (result, error) = await aidbox.Patch<Patient>(newData);
```



#### Batch/Transaction Operation

Link to aidbox doc: https://docs.aidbox.app/api-1/transaction



#### [Enhanced search API](https://github.com/Aidbox/aidbox-dotnet/issues/8)

Chaining of params, pagination, sorting (like in TypeScript SDK)

```c#
var search = aidbox.Search<Patient>(params)
  .Where(...)
  .SortBy(...);
```



#### Request exceptions

Handle HTTP exceptions with appropriate C# classes.

OperationOutcome example in Aidbox:

```yaml
resourceType: OperationOutcome
text:
  status: generated
  div: Invalid resource
issue:

  - severity: fatal
    code: invalid
    expression:
      - Appointment.participant
        diagnostics: ':participant is required'
  - severity: fatal
    code: invalid
    expression:
      - Appointment.status
        diagnostics: ':status is required'
```



### Model Validation

#### Exceptions during runtime based on type-system [c# serialize/parse out of box]

*Example TBD* 

#### Constraint on properties / cross-properties [transformation to validation functions]

*Example TBD* 

#### Slicing (min/max; order; pattern; open/close) [transformation to validation functions]

*Example TBD* 

#### Value-set / reference to a specific version of the resource [fhir-server]

*Example TBD* 

#### Custom operations

https://docs.aidbox.app/app-development/aidbox-sdk/aidbox-apps

### Delivery

#### [Come up with a solution for publishing the SDK in NuGet repository.](https://github.com/Aidbox/aidbox-dotnet/issues/9) 
It might not be so trivial, considering there are numerous FHIR profiles and each client would need its own set.

