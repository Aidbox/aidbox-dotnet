# Aidbox .NET SDK Roadmap

All implementation examples provided here are not final solutions yet.

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

Make it possible to add extensions

```c#
var patient = new Patient();
var mothersName = new Extension("http://hl7.org/fhir/StructureDefinition/patient-mothersMaidenName", "Doe");

patient.Extension.Add(patient);
```

#### List / circular structure / recursive structure

https://github.com/Aidbox/aidbox-dotnet/blob/main/src/resource/Patient.cs#L18

#### Reference [re-design Reference class] (aidbox format)

```
Problem: we don't want to concat string every time "Patient" + "/" + "<uuid>"

FHIR: { reference: "Patient/<uuid>" }
AIDBOX: { resourceType: Patient, id: <uuid> }

patient.managingOrganization = new Reference<Organization>() { id:<uuid> }


JsonParse(patient) => { "name": [], "managingOrganization": { "reference": "Organization/<uuid>" } } 
```

#### First class extensions (aidbox format)

Problem: is hard to reach the exact extension in array with nested extensions

```json
{
  "resourceType" : "Patient",
  "id" : "child-example",
  "meta" : {
    "profile" : [🔗 "http://hl7.org/fhir/us/core/StructureDefinition/us-core-patient|7.0.0"]
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
          "url" : "ombCategory",
          "valueCoding" : {
            "system" : "urn:oid:2.16.840.1.113883.6.238",
            "code" : "2028-9",
            "display" : "Latinos"
          }
        },
        {
          "url" : "text",
          "valueString" : "Asian"
        }
      ],
      "url" : "http://hl7.org/fhir/us/core/StructureDefinition/us-core-race"
    },
    {
      "extension" : [
        {
          "url" : "ombCategory",
          "valueCoding" : {
            "system" : "urn:oid:2.16.840.1.113883.6.238",
            "code" : "2186-5",
            "display" : "Not Hispanic or Latino"
          }
        },
        {
          "url" : "text",
          "valueString" : "Not Hispanic or Latino"
        }
      ],
      "url" : "http://hl7.org/fhir/us/core/StructureDefinition/us-core-ethnicity"
    },
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

```
GET /fhir/Patient/1


reference = Patient/id
reference = { id: 1, resourceType: Patient }

patient.deseaced = { }
```


race = patiane.extension.find(item => item.url == "http://hl7.org/fhir/us/core/StructureDefinition/us-core-race")

```c#
var patient = new Patient();
var mothersName = new Extension("http://hl7.org/fhir/StructureDefinition/patient-mothersMaidenName", "Doe");

patient.Extension.Add(patient);
```


ExtensionRace()
race

patient.race = [{ ombCategory: "Asian" }]
patient.ethnicity = []


#### Typed Search Params

One of the possible solutions

```c#
var params = new PatientSearchParams {
  Active = true,
  Given = "John Doe",
  GeneralPractitioner = "",
  Count = 10,
  Page = 2,
};
var results = client.Search(params).Count(10).Page(2)

```

```c#
var results = Patient.Search("name", "Doe")
var results = Patient.Search("general-practitioner ", <id>)
```

#### Profiles

- patterns
  { "code" {:pattern {"coding" [{"system" "http://loinc.org", "code" "29549-3", "display" "Medication administered Narrative"}]}}}

  ```c#
  class CodeableConcept1(CodeableConcept){
    readonly coding: [ new Conding295493() { System = "http://loinc.org", Code = "29549-3" } ]
  }

  class ObservationHeight(){
    readonly code: new CodeableConcept();
  }

  var obseration = new ObservationHeight {
    
  }
  ```


- bindings  (resource code type suggestion from CodeSystem)
  patient.gender = male | female

### Client methods

#### PATCH method

```c#
var (result, error) = await aidbox.Patch<Patient>(newData);
```



#### Search / List 

```c#
var params = new PatientSearchParams() {
  Given = "John Doe"
};
var results = await aidbox.Search<Patient[]>(params)
```



#### Enhanced search API

Chaining of params, pagination, sorting (like in TypeScript SDK)

```c#
var search = aidbox.Search<Patient>(params)
  .Where(...)
  .SortBy(...);
```



#### Request exceptions

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



#### Conditional create / update

https://docs.aidbox.app/api-1/api/crud-1/patch#merge-patch


#### Response as Bundle type

https://docs.aidbox.app/api-1/transaction



### Model Validation

#### Exceptions during runtime based on type-system [c# serialize/parse out of box]

*Example TBD* 

#### Constraint on properties / cross-properties [transformation to validation functions]

*Example TBD* 

#### Slicing (min/max; order; pattern; open/close) [transformation to validation functions]

*Example TBD* 

#### Value-set / reference to specific version of the resource [fhir-server]

*Example TBD* 

#### Custom operations

https://docs.aidbox.app/app-development/aidbox-sdk/aidbox-apps

### Delivery

- configuration server serves python model layer (type system)
- cli is getting access to zen-project / configuration project
- we have access to fhir-schema and generate SDK manually

#### Come up with a solution for publishing the SDK in NuGet repository. 
It might not be so trivial, considering there are numerous FHIR profiles and each client would need its own set.

