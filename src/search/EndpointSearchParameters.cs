namespace Aidbox.FHIR.Search;

public class EndpointSearchParameters : DomainResourceSearchParameters
{
    public string? ConnectionType { get; set; }
    public string? Identifier { get; set; }
    public string? Name { get; set; }
    public string? Organization { get; set; }
    public string? PayloadType { get; set; }
    public string? Status { get; set; }
}