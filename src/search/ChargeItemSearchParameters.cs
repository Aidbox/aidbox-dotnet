namespace Aidbox.FHIR.Search;

public class ChargeItemSearchParameters : DomainResourceSearchParameters
{
    public string? Account { get; set; }
    public string? Code { get; set; }
    public string? Context { get; set; }
    public string? EnteredDate { get; set; }
    public string? Enterer { get; set; }
    public string? FactorOverride { get; set; }
    public string? Identifier { get; set; }
    public string? Occurrence { get; set; }
    public string? Patient { get; set; }
    public string? PerformerActor { get; set; }
    public string? PerformerFunction { get; set; }
    public string? PerformingOrganization { get; set; }
    public string? PriceOverride { get; set; }
    public string? Quantity { get; set; }
    public string? RequestingOrganization { get; set; }
    public string? Service { get; set; }
    public string? Subject { get; set; }
}