namespace Aidbox.FHIR.Search;

public class SupplyDeliverySearchParameters : DomainResourceSearchParameters
{
    public string? Identifier { get; set; }
    public string? Patient { get; set; }
    public string? Receiver { get; set; }
    public string? ResearchStudy { get; set; }
    public string? Status { get; set; }
    public string? Supplier { get; set; }
}