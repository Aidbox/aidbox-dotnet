using Aidbox.FHIR.Base;
using Utils;

namespace Aidbox.FHIR.Resource;

public class EnrollmentResponse : DomainResource, IResource
{
	public Base.Identifier[]? Identifier { get; set; }
	public string? Status { get; set; }
	public Base.ResourceReference? Request { get; set; }
	public string? Outcome { get; set; }
	public string? Disposition { get; set; }
	public string? Created { get; set; }
	public Base.ResourceReference? Organization { get; set; }
	public Base.ResourceReference? RequestProvider { get; set; }
}