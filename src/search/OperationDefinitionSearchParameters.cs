namespace Aidbox.FHIR.Search;

public class OperationDefinitionSearchParameters : DomainResourceSearchParameters
{
    public string? Base { get; set; }
    public string? Code { get; set; }
    public string? Context { get; set; }
    public string? ContextQuantity { get; set; }
    public string? ContextType { get; set; }
    public string? ContextTypeQuantity { get; set; }
    public string? ContextTypeValue { get; set; }
    public string? Date { get; set; }
    public string? Description { get; set; }
    public string? InputProfile { get; set; }
    public string? Instance { get; set; }
    public string? Jurisdiction { get; set; }
    public string? Kind { get; set; }
    public string? Name { get; set; }
    public string? OutputProfile { get; set; }
    public string? Publisher { get; set; }
    public string? Status { get; set; }
    public string? System { get; set; }
    public string? Title { get; set; }
    public string? Type { get; set; }
    public string? Url { get; set; }
    public string? Version { get; set; }
}