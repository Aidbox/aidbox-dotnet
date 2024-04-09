# Aidbox .NET SDK Roadmap

All implementation examples provided here are not final solutions yet.

### FHIR to C# Mappings


#### Storing FHIR primitives as corresponding datatypes in C#
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



#### Polymorphic fields

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



#### Constrain possible values for codes

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

*Example TBD* 

#### Reference [re-design Reference class] (aidbox format)

*Example TBD* 

#### First class extensions (aidbox format)

*Example TBD* 

#### Typed Search Params

One of the possible solutions

```c#
var params = new PatientSearchParams() {
  Given = "John Doe"
};
var results = client.Search(params)
```

#### Profiles

- patterns
  *Example TBD* 
- bindings  (resource code type suggestion from CodeSystem)
  *Example TBD* 

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

*Example TBD* 



#### Conditional create / update

*Example TBD* 



#### Custom operations

*Example TBD* 



#### Response as Bundle type

*Example TBD* 



### Model Validation

#### Exceptions during runtime based on type-system [pydantic out of box]

*Example TBD* 

#### Constraint on properties / cross-properties [transformation to validation functions]

*Example TBD* 

#### Slicing (min/max; order; pattern; open/close) [transformation to validation functions]

*Example TBD* 

#### Value-set / reference to specific version of the resource [fhir-server]

*Example TBD* 



### Delivery

- configuration server serves python model layer (type system)
- cli is getting access to zen-project / configuration project
- we have access to fhir-schema and generate SDK manually

#### Come up with a solution for publishing the SDK in NuGet repository. 
It might not be so trivial, considering there are numerous FHIR profiles and each client would need its own set.

