namespace Aidbox.FHIR.Search;

public class NutritionOrderSearchParameters : DomainResourceSearchParameters
{
    public string? Additive { get; set; }
    public string? Datetime { get; set; }
    public string? Encounter { get; set; }
    public string? Formula { get; set; }
    public string? Identifier { get; set; }
    public string? InstantiatesCanonical { get; set; }
    public string? InstantiatesUri { get; set; }
    public string? Oraldiet { get; set; }
    public string? Patient { get; set; }
    public string? Provider { get; set; }
    public string? Status { get; set; }
    public string? Supplement { get; set; }
}