namespace Aidbox.FHIR.Search;

public class RiskAssessmentSearchParameters : DomainResourceSearchParameters
{
    public string? Condition { get; set; }
    public string? Date { get; set; }
    public string? Encounter { get; set; }
    public string? Identifier { get; set; }
    public string? Method { get; set; }
    public string? Patient { get; set; }
    public string? Performer { get; set; }
    public string? Probability { get; set; }
    public string? ResearchStudy { get; set; }
    public string? Risk { get; set; }
    public string? Subject { get; set; }
}