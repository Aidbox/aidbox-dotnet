namespace Aidbox.FHIR.Search;

public class RequestGroupSearchParameters : DomainResourceSearchParameters
{
    public string? Author { get; set; }
    public string? Authored { get; set; }
    public string? Code { get; set; }
    public string? Encounter { get; set; }
    public string? GroupIdentifier { get; set; }
    public string? Identifier { get; set; }
    public string? InstantiatesCanonical { get; set; }
    public string? InstantiatesUri { get; set; }
    public string? Intent { get; set; }
    public string? Participant { get; set; }
    public string? Patient { get; set; }
    public string? Priority { get; set; }
    public string? Status { get; set; }
    public string? Subject { get; set; }
}