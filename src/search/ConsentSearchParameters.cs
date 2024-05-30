namespace Aidbox.FHIR.Search;

public class ConsentSearchParameters : DomainResourceSearchParameters
{
    public string? Action { get; set; }
    public string? Actor { get; set; }
    public string? Category { get; set; }
    public string? Consentor { get; set; }
    public string? Data { get; set; }
    public string? Date { get; set; }
    public string? Identifier { get; set; }
    public string? Organization { get; set; }
    public string? Patient { get; set; }
    public string? Period { get; set; }
    public string? Purpose { get; set; }
    public string? ResearchStudy { get; set; }
    public string? Scope { get; set; }
    public string? SecurityLabel { get; set; }
    public string? SourceReference { get; set; }
    public string? Status { get; set; }
}