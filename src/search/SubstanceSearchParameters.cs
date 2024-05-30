namespace Aidbox.FHIR.Search;

public class SubstanceSearchParameters : DomainResourceSearchParameters
{
    public string? Category { get; set; }
    public string? Code { get; set; }
    public string? ContainerIdentifier { get; set; }
    public string? Expiry { get; set; }
    public string? Identifier { get; set; }
    public string? Quantity { get; set; }
    public string? Status { get; set; }
    public string? SubstanceReference { get; set; }
}