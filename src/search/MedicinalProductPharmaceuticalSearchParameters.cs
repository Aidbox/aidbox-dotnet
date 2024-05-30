namespace Aidbox.FHIR.Search;

public class MedicinalProductPharmaceuticalSearchParameters : DomainResourceSearchParameters
{
    public string? Identifier { get; set; }
    public string? Route { get; set; }
    public string? TargetSpecies { get; set; }
}