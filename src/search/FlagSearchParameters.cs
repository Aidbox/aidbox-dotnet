namespace Aidbox.FHIR.Search;

public class FlagSearchParameters : DomainResourceSearchParameters
{
    public string? Author { get; set; }
    public string? Date { get; set; }
    public string? Encounter { get; set; }
    public string? Identifier { get; set; }
    public string? Patient { get; set; }
    public string? Subject { get; set; }
}