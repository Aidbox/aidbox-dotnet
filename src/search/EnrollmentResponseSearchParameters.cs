namespace Aidbox.FHIR.Search;

public class EnrollmentResponseSearchParameters : DomainResourceSearchParameters
{
    public string? Identifier { get; set; }
    public string? Request { get; set; }
    public string? Status { get; set; }
}