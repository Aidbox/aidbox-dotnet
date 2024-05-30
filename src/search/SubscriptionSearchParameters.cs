namespace Aidbox.FHIR.Search;

public class SubscriptionSearchParameters : DomainResourceSearchParameters
{
    public string? Contact { get; set; }
    public string? Criteria { get; set; }
    public string? Payload { get; set; }
    public string? Status { get; set; }
    public string? Type { get; set; }
    public string? Url { get; set; }
}