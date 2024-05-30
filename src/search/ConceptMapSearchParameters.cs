namespace Aidbox.FHIR.Search;

public class ConceptMapSearchParameters : DomainResourceSearchParameters
{
    public string? Context { get; set; }
    public string? ContextQuantity { get; set; }
    public string? ContextType { get; set; }
    public string? ContextTypeQuantity { get; set; }
    public string? ContextTypeValue { get; set; }
    public string? Date { get; set; }
    public string? Dependson { get; set; }
    public string? Description { get; set; }
    public string? Identifier { get; set; }
    public string? Jurisdiction { get; set; }
    public string? Name { get; set; }
    public string? Other { get; set; }
    public string? Product { get; set; }
    public string? Publisher { get; set; }
    public string? Source { get; set; }
    public string? SourceCode { get; set; }
    public string? SourceSystem { get; set; }
    public string? SourceUri { get; set; }
    public string? Status { get; set; }
    public string? Target { get; set; }
    public string? TargetCode { get; set; }
    public string? TargetSystem { get; set; }
    public string? TargetUri { get; set; }
    public string? Title { get; set; }
    public string? Url { get; set; }
    public string? Version { get; set; }
}