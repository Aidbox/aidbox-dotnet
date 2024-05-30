namespace Aidbox.FHIR.Search;

public class CompositionSearchParameters : DomainResourceSearchParameters
{
    public string? Attester { get; set; }
    public string? Author { get; set; }
    public string? Category { get; set; }
    public string? Confidentiality { get; set; }
    public string? Context { get; set; }
    public string? Date { get; set; }
    public string? Encounter { get; set; }
    public string? Entry { get; set; }
    public string? Identifier { get; set; }
    public string? Patient { get; set; }
    public string? Period { get; set; }
    public string? RelatedId { get; set; }
    public string? RelatedRef { get; set; }
    public string? ResearchStudy { get; set; }
    public string? Section { get; set; }
    public string? Status { get; set; }
    public string? Subject { get; set; }
    public string? Title { get; set; }
    public string? Type { get; set; }
}