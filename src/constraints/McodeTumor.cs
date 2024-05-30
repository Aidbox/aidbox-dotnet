using Aidbox.FHIR.Base;
using Aidbox.FHIR.Utils;

namespace Aidbox.FHIR.Constraint;

public class McodeTumor : DomainResource
{
    public new Meta Meta { get; } = new() { Profile = ["http://hl7.org/fhir/us/mcode/StructureDefinition/mcode-tumor"] };
    public Base.Attachment[]? Image { get; set; }
    public bool? Active { get; set; }
    public required Base.ResourceReference Patient { get; set; }
    public required Base.CodeableConcept Location { get; set; }
    public required Base.Identifier[] Identifier { get; set; }
    public Base.CodeableConcept? Morphology { get; set; }
    public string? Description { get; set; }
    public Base.CodeableConcept[]? LocationQualifier { get; set; }
}