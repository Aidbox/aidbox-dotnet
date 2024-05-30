using Aidbox.FHIR.Base;
using Aidbox.FHIR.Utils;

namespace Aidbox.FHIR.Constraint;

public class ProvenanceRelevantHistory : DomainResource
{
    public new Meta Meta { get; } = new() { Profile = ["http://hl7.org/fhir/StructureDefinition/provenance-relevant-history"] };
    public Base.Signature[]? Signature { get; set; }
    public string? OccurredDateTime { get; set; }
    public required string Recorded { get; set; }
    public required Provenance_Agent[] Agent { get; set; }
    public string[]? Policy { get; set; }
    public Base.CodeableConcept[]? Reason { get; set; }
    public required Base.CodeableConcept Activity { get; set; }
    public required Base.ResourceReference[] Target { get; set; }
    public Base.ResourceReference? Location { get; set; }
    public Provenance_Entity[]? Entity { get; set; }

    public class Provenance_Agent : BackboneElement
    {
        public required Base.ResourceReference Who { get; set; }
        public Base.CodeableConcept[]? Role { get; set; }
        public Base.CodeableConcept? Type { get; set; }
        public Base.ResourceReference? OnBehalfOf { get; set; }
    }

    public class Provenance_Entity_Agent : BackboneElement
    {
        public required Base.ResourceReference Who { get; set; }
        public Base.CodeableConcept[]? Role { get; set; }
        public Base.CodeableConcept? Type { get; set; }
        public Base.ResourceReference? OnBehalfOf { get; set; }
    }

    public class Provenance_Entity : BackboneElement
    {
        public required string Role { get; set; }
        public required Base.ResourceReference What { get; set; }
        public Provenance_Entity_Agent[]? Agent { get; set; }
    }
}