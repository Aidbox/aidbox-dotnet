namespace Aidbox.FHIR.Search;

public class MeasureReportSearchParameters : DomainResourceSearchParameters
{
    public string? Date { get; set; }
    public string? EvaluatedResource { get; set; }
    public string? Identifier { get; set; }
    public string? Measure { get; set; }
    public string? Patient { get; set; }
    public string? Period { get; set; }
    public string? Reporter { get; set; }
    public string? Status { get; set; }
    public string? Subject { get; set; }
}