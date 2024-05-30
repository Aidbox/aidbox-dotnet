namespace Aidbox.FHIR.Search;

public class EpisodeOfCareSearchParameters : DomainResourceSearchParameters
{
    public string? CareManager { get; set; }
    public string? Condition { get; set; }
    public string? Date { get; set; }
    public string? Identifier { get; set; }
    public string? IncomingReferral { get; set; }
    public string? Organization { get; set; }
    public string? Patient { get; set; }
    public string? Status { get; set; }
    public string? Type { get; set; }
}