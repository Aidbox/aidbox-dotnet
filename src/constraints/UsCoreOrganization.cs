using Aidbox.FHIR.Base;
using Aidbox.FHIR.Utils;

namespace Aidbox.FHIR.Constraint;

public class UsCoreOrganization : DomainResource
{
    public new Meta Meta { get; } = new() { Profile = ["http://hl7.org/fhir/us/core/StructureDefinition/us-core-organization"] };
    public Base.Address[]? Address { get; set; }
    public required string Name { get; set; }
    public Base.CodeableConcept[]? Type { get; set; }
    public string[]? Alias { get; set; }
    public required bool Active { get; set; }
    public Base.Identifier[]? Identifier { get; set; }
    public Base.ContactPoint[]? Telecom { get; set; }
    public Base.ResourceReference? PartOf { get; set; }
    public Base.ResourceReference[]? Endpoint { get; set; }
    public Organization_Contact[]? Contact { get; set; }

    public class Organization_Contact : BackboneElement
    {
        public Base.HumanName? Name { get; set; }
        public Base.Address? Address { get; set; }
        public Base.CodeableConcept? Purpose { get; set; }
        public Base.ContactPoint[]? Telecom { get; set; }
    }
}