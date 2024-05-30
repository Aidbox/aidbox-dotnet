namespace Aidbox.FHIR.Search;

public class SupplyRequestSearchParameters : DomainResourceSearchParameters
{
    public string? Category { get; set; }
    public string? Date { get; set; }
    public string? Identifier { get; set; }
    public string? Requester { get; set; }
    public string? Status { get; set; }
    public string? Subject { get; set; }
    public string? Supplier { get; set; }
}