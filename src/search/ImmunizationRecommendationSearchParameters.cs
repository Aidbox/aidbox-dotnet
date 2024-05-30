namespace Aidbox.FHIR.Search;

public class ImmunizationRecommendationSearchParameters : DomainResourceSearchParameters
{
    public string? Date { get; set; }
    public string? Identifier { get; set; }
    public string? Information { get; set; }
    public string? Patient { get; set; }
    public string? Status { get; set; }
    public string? Support { get; set; }
    public string? TargetDisease { get; set; }
    public string? VaccineType { get; set; }
}