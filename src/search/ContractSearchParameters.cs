namespace Aidbox.FHIR.Search;

public class ContractSearchParameters : DomainResourceSearchParameters
{
    public string? Authority { get; set; }
    public string? Domain { get; set; }
    public string? Identifier { get; set; }
    public string? Instantiates { get; set; }
    public string? Issued { get; set; }
    public string? Patient { get; set; }
    public string? Signer { get; set; }
    public string? Status { get; set; }
    public string? Subject { get; set; }
    public string? Url { get; set; }
}