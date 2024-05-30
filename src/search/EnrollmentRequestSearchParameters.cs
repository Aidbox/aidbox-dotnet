namespace Aidbox.FHIR.Search;

public class EnrollmentRequestSearchParameters : DomainResourceSearchParameters
{
    public string? Identifier { get; set; }
    public string? Patient { get; set; }
    public string? Status { get; set; }
    public string? Subject { get; set; }
}