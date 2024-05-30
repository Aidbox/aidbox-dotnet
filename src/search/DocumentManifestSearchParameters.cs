namespace Aidbox.FHIR.Search;

public class DocumentManifestSearchParameters : DomainResourceSearchParameters
{
    public string? Author { get; set; }
    public string? Created { get; set; }
    public string? Description { get; set; }
    public string? Identifier { get; set; }
    public string? Item { get; set; }
    public string? Patient { get; set; }
    public string? Recipient { get; set; }
    public string? RelatedId { get; set; }
    public string? RelatedRef { get; set; }
    public string? Source { get; set; }
    public string? Status { get; set; }
    public string? Subject { get; set; }
    public string? Type { get; set; }
}