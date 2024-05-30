namespace Aidbox.FHIR.Search;

public class CapabilityStatementSearchParameters : DomainResourceSearchParameters
{
    public string? Context { get; set; }
    public string? ContextQuantity { get; set; }
    public string? ContextType { get; set; }
    public string? ContextTypeQuantity { get; set; }
    public string? ContextTypeValue { get; set; }
    public string? Date { get; set; }
    public string? Description { get; set; }
    public string? Fhirversion { get; set; }
    public string? Format { get; set; }
    public string? Guide { get; set; }
    public string? Jurisdiction { get; set; }
    public string? Mode { get; set; }
    public string? Name { get; set; }
    public string? Publisher { get; set; }
    public string? Resource { get; set; }
    public string? ResourceProfile { get; set; }
    public string? SecurityService { get; set; }
    public string? Software { get; set; }
    public string? Status { get; set; }
    public string? SupportedProfile { get; set; }
    public string? Title { get; set; }
    public string? Url { get; set; }
    public string? Version { get; set; }
}