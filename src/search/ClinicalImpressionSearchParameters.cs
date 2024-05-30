namespace Aidbox.FHIR.Search;

public class ClinicalImpressionSearchParameters : DomainResourceSearchParameters
{
    public string? Assessor { get; set; }
    public string? Date { get; set; }
    public string? Encounter { get; set; }
    public string? FindingCode { get; set; }
    public string? FindingRef { get; set; }
    public string? Identifier { get; set; }
    public string? Investigation { get; set; }
    public string? Patient { get; set; }
    public string? Previous { get; set; }
    public string? Problem { get; set; }
    public string? Status { get; set; }
    public string? Subject { get; set; }
    public string? SupportingInfo { get; set; }
}