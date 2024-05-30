namespace Aidbox.FHIR.Search;

public class ImmunizationEvaluationSearchParameters : DomainResourceSearchParameters
{
    public string? Date { get; set; }
    public string? DoseStatus { get; set; }
    public string? Identifier { get; set; }
    public string? ImmunizationEvent { get; set; }
    public string? Patient { get; set; }
    public string? Status { get; set; }
    public string? TargetDisease { get; set; }
}