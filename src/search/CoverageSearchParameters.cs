namespace Aidbox.FHIR.Search;

public class CoverageSearchParameters : DomainResourceSearchParameters
{
    public string? Beneficiary { get; set; }
    public string? ClassType { get; set; }
    public string? ClassValue { get; set; }
    public string? Dependent { get; set; }
    public string? Identifier { get; set; }
    public string? Patient { get; set; }
    public string? Payor { get; set; }
    public string? PolicyHolder { get; set; }
    public string? Status { get; set; }
    public string? Subscriber { get; set; }
    public string? Type { get; set; }
}