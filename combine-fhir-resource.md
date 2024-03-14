### FHIR Elements

```C#
HumanName name = new() { Given = ["John"], Family = "Doe" };

Coding coding = new()
{
    System = "http://terminology.hl7.org/CodeSystem/v2-0203",
    Code = "SS",
    Display = "Social Security Number"
};

Identifier identifier = new()
{
    Use = "official",
    Type = new CodeableConcept() { Coding = [coding] },
    System = "urn:oid:2.16.840.1.113883.4.1",
    Value = "123-45-6789"
};
```

### Serialization

```C#
using Utils;

var patient = new Patient()
{
    Gender = "male",
    Name = [name],
    Identifier = [identifier]
}

JsonSerializer.Serialize(patient, Config.JsonSerializerOptions)
```

#### Output:

```JSON
{
  "name": [{ "family": "Doe", "given": ["John"] }],
  "identifier": [
    {
      "use": "official",
      "type": {
        "coding": [
          {
            "system": "http://terminology.hl7.org/CodeSystem/v2-0203",
            "code": "SS",
            "display": "Social Security Number"
          }
        ]
      },
      "system": "urn:oid:2.16.840.1.113883.4.1",
      "value": "123-45-6789"
    }
  ],
  "gender": "male"
}
```

### Deserialization

```C#
using Utils;

var patient = JsonSerializer.Deserialize<Patient>(JSONPatientString, Config.JsonSerializerOptions);
```

#### Output

```
Aidbox.FHIR.Resource.Patient // or serialization exception
```
