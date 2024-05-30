namespace Aidbox.FHIR.Search;

public class AccountSearchParameters : DomainResourceSearchParameters
{
    public string? Identifier { get; set; }
    public string? Name { get; set; }
    public string? Owner { get; set; }
    public string? Patient { get; set; }
    public string? Period { get; set; }
    public string? Status { get; set; }
    public string? Subject { get; set; }
    public string? Type { get; set; }
}