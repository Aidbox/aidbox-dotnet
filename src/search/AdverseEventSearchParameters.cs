namespace Aidbox.FHIR.Search;

public class AdverseEventSearchParameters : DomainResourceSearchParameters
{
    public string? Actuality { get; set; }
    public string? Category { get; set; }
    public string? Date { get; set; }
    public string? Event { get; set; }
    public string? Location { get; set; }
    public string? Recorder { get; set; }
    public string? Resultingcondition { get; set; }
    public string? Seriousness { get; set; }
    public string? Severity { get; set; }
    public string? Study { get; set; }
    public string? Subject { get; set; }
    public string? Substance { get; set; }
}