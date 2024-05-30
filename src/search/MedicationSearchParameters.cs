namespace Aidbox.FHIR.Search;

public class MedicationSearchParameters : DomainResourceSearchParameters
{
    public string? Code { get; set; }
    public string? ExpirationDate { get; set; }
    public string? Form { get; set; }
    public string? Identifier { get; set; }
    public string? Ingredient { get; set; }
    public string? IngredientCode { get; set; }
    public string? LotNumber { get; set; }
    public string? Manufacturer { get; set; }
    public string? Status { get; set; }
}