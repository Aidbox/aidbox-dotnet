namespace Aidbox.FHIR.Search;

public class EvidenceSearchParameters : DomainResourceSearchParameters
{
    public string? ComposedOf { get; set; }
    public string? Context { get; set; }
    public string? ContextQuantity { get; set; }
    public string? ContextType { get; set; }
    public string? ContextTypeQuantity { get; set; }
    public string? ContextTypeValue { get; set; }
    public string? Date { get; set; }
    public string? DependsOn { get; set; }
    public string? DerivedFrom { get; set; }
    public string? Description { get; set; }
    public string? Effective { get; set; }
    public string? Identifier { get; set; }
    public string? Jurisdiction { get; set; }
    public string? Name { get; set; }
    public string? Predecessor { get; set; }
    public string? Publisher { get; set; }
    public string? Status { get; set; }
    public string? Successor { get; set; }
    public string? Title { get; set; }
    public string? Topic { get; set; }
    public string? Url { get; set; }
    public string? Version { get; set; }
}