namespace Aidbox.FHIR.Search;

public class MedicationAdministrationSearchParameters : DomainResourceSearchParameters
{
    public string? Code { get; set; }
    public string? Context { get; set; }
    public string? Device { get; set; }
    public string? EffectiveTime { get; set; }
    public string? Identifier { get; set; }
    public string? Medication { get; set; }
    public string? Patient { get; set; }
    public string? Performer { get; set; }
    public string? ReasonGiven { get; set; }
    public string? ReasonNotGiven { get; set; }
    public string? Request { get; set; }
    public string? ResearchStudy { get; set; }
    public string? Status { get; set; }
    public string? Subject { get; set; }
}