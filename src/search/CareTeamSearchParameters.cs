namespace Aidbox.FHIR.Search;

public class CareTeamSearchParameters : DomainResourceSearchParameters
{
    public string? Category { get; set; }
    public string? Date { get; set; }
    public string? Encounter { get; set; }
    public string? Identifier { get; set; }
    public string? Participant { get; set; }
    public string? Patient { get; set; }
    public string? Status { get; set; }
    public string? Subject { get; set; }
}