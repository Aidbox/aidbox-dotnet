using Aidbox.FHIR.Base;
using Aidbox.FHIR.Utils;

namespace Aidbox.FHIR.Resource;

public class EnrollmentResponse : DomainResource, IResource
{
    public string? Status { get; set; }
    public string? Created { get; set; }
    public string? Outcome { get; set; }
    public Base.ResourceReference? Request { get; set; }
    public Base.Identifier[]? Identifier { get; set; }
    public string? Disposition { get; set; }
    public Base.ResourceReference? Organization { get; set; }
    public Base.ResourceReference? RequestProvider { get; set; }
}