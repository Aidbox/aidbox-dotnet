using Aidbox.FHIR.Base;
using Utils;

namespace Aidbox.FHIR.Resource;

public class Basic : DomainResource, IResource
{
	public Base.Identifier[]? Identifier { get; set; }
	public required Base.CodeableConcept Code { get; set; }
	public Base.ResourceReference? Subject { get; set; }
	public string? Created { get; set; }
	public Base.ResourceReference? Author { get; set; }
}