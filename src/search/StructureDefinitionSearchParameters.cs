namespace Aidbox.FHIR.Search;

public class StructureDefinitionSearchParameters : DomainResourceSearchParameters
{
    public string? Abstract { get; set; }
    public string? Base { get; set; }
    public string? BasePath { get; set; }
    public string? Context { get; set; }
    public string? ContextQuantity { get; set; }
    public string? ContextType { get; set; }
    public string? ContextTypeQuantity { get; set; }
    public string? ContextTypeValue { get; set; }
    public string? Date { get; set; }
    public string? Derivation { get; set; }
    public string? Description { get; set; }
    public string? Experimental { get; set; }
    public string? ExtContext { get; set; }
    public string? Identifier { get; set; }
    public string? Jurisdiction { get; set; }
    public string? Keyword { get; set; }
    public string? Kind { get; set; }
    public string? Name { get; set; }
    public string? Path { get; set; }
    public string? Publisher { get; set; }
    public string? Status { get; set; }
    public string? Title { get; set; }
    public string? Type { get; set; }
    public string? Url { get; set; }
    public string? Valueset { get; set; }
    public string? Version { get; set; }
}