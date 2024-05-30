using Aidbox.FHIR.Base;
using Aidbox.FHIR.Utils;

namespace Aidbox.FHIR.Constraint;

public class McodeRadiotherapyVolume : DomainResource
{
    public new Meta Meta { get; } = new() { Profile = ["http://hl7.org/fhir/us/mcode/StructureDefinition/mcode-radiotherapy-volume"] };
    public Base.Attachment[]? Image { get; set; }
    public bool? Active { get; set; }
    public required Base.ResourceReference Patient { get; set; }
    public Base.CodeableConcept? Location { get; set; }
    public Base.Identifier[]? Identifier { get; set; }
    public Base.CodeableConcept? Morphology { get; set; }
    public string? Description { get; set; }
    public Base.CodeableConcept[]? LocationQualifier { get; set; }
}