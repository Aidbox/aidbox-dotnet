## adibox-dotnet

### Installation

1. Clone the Repository: Use git clone to clone the library's repository to your local machine.

```sh
git@github.com:Aidbox/aidbox-dotnet.git
```

2. Build the Library: Navigate to the cloned repository's directory and use the .NET CLI to build the project.

```sh
cd aidbox-dotnet
dotnet build
```

3. Reference the Library in Your Project: After building the library, you can reference the resulting DLL in your project directly.

```sh
dotnet add reference ../path/to/library/library.csproj
```

### Usage

#### Auth

```c#
using Aidbox.FHIR.Base;
using Aidbox.FHIR.Resource;
using Aidbox.FHIR.Constraint;
using API;

Auth authorization = new()
{
    Method = AuthMethods.BASIC,
    Credentials = new() { Username = "basic", Password = "secret" }
};

Client client = new("https://name.aidbox.app", authorization);
```

#### Models

```c#
HumanName name = new() { Given = ["Gena"], Family = "Razmakhnin" };
Coding coding = new() {
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

var patient = new McodeCancerPatient()
{
    Gender = "male",
    Name = [name],
    Identifier = [identifier]
}
```

#### REST

```c#
await client.Create(new McodeCancerPatient()
    {
        Gender = "male",
        Name = [name],
        Identifier = [identifier]
    }
);

var (patient, error) = await client.Read<McodeCancerPatient>("patient-1")
```

### Demo project

#### How to run
```sh
dotnet run --project examples/AidboxClient
```