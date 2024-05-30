namespace Aidbox.FHIR.Search;

public class DiagnosticReportSearchParameters : DomainResourceSearchParameters
{
    public string? AssessedCondition { get; set; }
    public string? BasedOn { get; set; }
    public string? Category { get; set; }
    public string? Code { get; set; }
    public string? Conclusion { get; set; }
    public string? Date { get; set; }
    public string? Encounter { get; set; }
    public string? Identifier { get; set; }
    public string? Issued { get; set; }
    public string? Media { get; set; }
    public string? Patient { get; set; }
    public string? Performer { get; set; }
    public string? ResearchStudy { get; set; }
    public string? Result { get; set; }
    public string? ResultsInterpreter { get; set; }
    public string? Specimen { get; set; }
    public string? Status { get; set; }
    public string? Subject { get; set; }
}