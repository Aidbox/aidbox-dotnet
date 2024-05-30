namespace Aidbox.FHIR.Search;

public class QuestionnaireResponseSearchParameters : DomainResourceSearchParameters
{
    public string? Author { get; set; }
    public string? Authored { get; set; }
    public string? BasedOn { get; set; }
    public string? Encounter { get; set; }
    public string? Identifier { get; set; }
    public string? PartOf { get; set; }
    public string? Patient { get; set; }
    public string? Questionnaire { get; set; }
    public string? ResearchStudy { get; set; }
    public string? Source { get; set; }
    public string? Status { get; set; }
    public string? Subject { get; set; }
}