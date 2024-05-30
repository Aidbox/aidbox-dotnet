using Aidbox.FHIR.Base;
using Aidbox.FHIR.Utils;

namespace Aidbox.FHIR.Resource;

public class Basic : DomainResource, IResource
{
    public required Base.CodeableConcept Code { get; set; }
    public Base.ResourceReference? Author { get; set; }
    public string? Created { get; set; }
    public Base.ResourceReference? Subject { get; set; }
    public Base.Identifier[]? Identifier { get; set; }
}