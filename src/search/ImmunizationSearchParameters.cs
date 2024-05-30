namespace Aidbox.FHIR.Search;

public class ImmunizationSearchParameters : DomainResourceSearchParameters
{
    public string? Date { get; set; }
    public string? Identifier { get; set; }
    public string? Location { get; set; }
    public string? LotNumber { get; set; }
    public string? Manufacturer { get; set; }
    public string? Patient { get; set; }
    public string? Performer { get; set; }
    public string? Reaction { get; set; }
    public string? ReactionDate { get; set; }
    public string? ReasonCode { get; set; }
    public string? ReasonReference { get; set; }
    public string? ResearchStudy { get; set; }
    public string? Series { get; set; }
    public string? Status { get; set; }
    public string? StatusReason { get; set; }
    public string? TargetDisease { get; set; }
    public string? VaccineCode { get; set; }
}