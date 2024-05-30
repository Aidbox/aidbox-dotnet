namespace Aidbox.FHIR.Search;

public class LinkageSearchParameters : DomainResourceSearchParameters
{
    public string? Author { get; set; }
    public string? Item { get; set; }
    public string? Source { get; set; }
}