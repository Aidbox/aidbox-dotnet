namespace Aidbox.FHIR.Search;

public class NamingSystemSearchParameters : DomainResourceSearchParameters
{
    public string? Contact { get; set; }
    public string? Context { get; set; }
    public string? ContextQuantity { get; set; }
    public string? ContextType { get; set; }
    public string? ContextTypeQuantity { get; set; }
    public string? ContextTypeValue { get; set; }
    public string? Date { get; set; }
    public string? Description { get; set; }
    public string? IdType { get; set; }
    public string? Jurisdiction { get; set; }
    public string? Kind { get; set; }
    public string? Name { get; set; }
    public string? Period { get; set; }
    public string? Publisher { get; set; }
    public string? Responsible { get; set; }
    public string? Status { get; set; }
    public string? Telecom { get; set; }
    public string? Type { get; set; }
    public string? Value { get; set; }
}