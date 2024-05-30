using Aidbox.FHIR.Base;
using Aidbox.FHIR.Utils;

namespace Aidbox.FHIR.Resource;

public class BodyStructure : DomainResource, IResource
{
    public Base.Attachment[]? Image { get; set; }
    public bool? Active { get; set; }
    public required Base.ResourceReference Patient { get; set; }
    public Base.CodeableConcept? Location { get; set; }
    public Base.Identifier[]? Identifier { get; set; }
    public Base.CodeableConcept? Morphology { get; set; }
    public string? Description { get; set; }
    public Base.CodeableConcept[]? LocationQualifier { get; set; }
}