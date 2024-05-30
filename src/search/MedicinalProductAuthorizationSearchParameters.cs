namespace Aidbox.FHIR.Search;

public class MedicinalProductAuthorizationSearchParameters : DomainResourceSearchParameters
{
    public string? Country { get; set; }
    public string? Holder { get; set; }
    public string? Identifier { get; set; }
    public string? Status { get; set; }
    public string? Subject { get; set; }
}