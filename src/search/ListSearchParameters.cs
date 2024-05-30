namespace Aidbox.FHIR.Search;

public class ListSearchParameters : DomainResourceSearchParameters
{
    public string? Code { get; set; }
    public string? Date { get; set; }
    public string? EmptyReason { get; set; }
    public string? Encounter { get; set; }
    public string? Identifier { get; set; }
    public string? Item { get; set; }
    public string? Notes { get; set; }
    public string? Patient { get; set; }
    public string? Source { get; set; }
    public string? Status { get; set; }
    public string? Subject { get; set; }
    public string? Title { get; set; }
}