namespace Aidbox.FHIR.Search;

public class ResearchStudySearchParameters : DomainResourceSearchParameters
{
    public string? Category { get; set; }
    public string? Date { get; set; }
    public string? Focus { get; set; }
    public string? Identifier { get; set; }
    public string? Keyword { get; set; }
    public string? Location { get; set; }
    public string? Partof { get; set; }
    public string? Principalinvestigator { get; set; }
    public string? Protocol { get; set; }
    public string? Site { get; set; }
    public string? Sponsor { get; set; }
    public string? Status { get; set; }
    public string? Title { get; set; }
}