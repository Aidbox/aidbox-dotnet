namespace Aidbox.FHIR.Search;

public class GuidanceResponseSearchParameters : DomainResourceSearchParameters
{
    public string? Identifier { get; set; }
    public string? Patient { get; set; }
    public string? Request { get; set; }
    public string? Subject { get; set; }
}