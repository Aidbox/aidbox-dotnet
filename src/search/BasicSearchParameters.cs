namespace Aidbox.FHIR.Search;

public class BasicSearchParameters : DomainResourceSearchParameters
{
    public string? Author { get; set; }
    public string? Code { get; set; }
    public string? Created { get; set; }
    public string? Identifier { get; set; }
    public string? Patient { get; set; }
    public string? Subject { get; set; }
}