namespace Aidbox.FHIR.Search;

public class ProvenanceSearchParameters : DomainResourceSearchParameters
{
    public string? Agent { get; set; }
    public string? AgentRole { get; set; }
    public string? AgentType { get; set; }
    public string? Entity { get; set; }
    public string? Location { get; set; }
    public string? Patient { get; set; }
    public string? Recorded { get; set; }
    public string? SignatureType { get; set; }
    public string? Target { get; set; }
    public string? When { get; set; }
}