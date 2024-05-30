namespace Aidbox.FHIR.Search;

public class DocumentReferenceSearchParameters : DomainResourceSearchParameters
{
    public string? Authenticator { get; set; }
    public string? Author { get; set; }
    public string? Category { get; set; }
    public string? Contenttype { get; set; }
    public string? Custodian { get; set; }
    public string? Date { get; set; }
    public string? Description { get; set; }
    public string? Encounter { get; set; }
    public string? Event { get; set; }
    public string? Facility { get; set; }
    public string? Format { get; set; }
    public string? Id { get; set; }
    public string? Identifier { get; set; }
    public string? Language { get; set; }
    public string? Location { get; set; }
    public string? Patient { get; set; }
    public string? Period { get; set; }
    public string? Related { get; set; }
    public string? Relatesto { get; set; }
    public string? Relation { get; set; }
    public string? Relationship { get; set; }
    public string? ResearchStudy { get; set; }
    public string? SecurityLabel { get; set; }
    public string? Setting { get; set; }
    public string? Status { get; set; }
    public string? Subject { get; set; }
    public string? Type { get; set; }
}