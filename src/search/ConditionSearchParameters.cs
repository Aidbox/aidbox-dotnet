namespace Aidbox.FHIR.Search;

public class ConditionSearchParameters : DomainResourceSearchParameters
{
    public string? AbatementAge { get; set; }
    public string? AbatementDate { get; set; }
    public string? AbatementString { get; set; }
    public string? Asserter { get; set; }
    public string? BodySite { get; set; }
    public string? Category { get; set; }
    public string? ClinicalStatus { get; set; }
    public string? Code { get; set; }
    public string? Encounter { get; set; }
    public string? Evidence { get; set; }
    public string? EvidenceDetail { get; set; }
    public string? Identifier { get; set; }
    public string? OnsetAge { get; set; }
    public string? OnsetDate { get; set; }
    public string? OnsetInfo { get; set; }
    public string? Patient { get; set; }
    public string? RecordedDate { get; set; }
    public string? Severity { get; set; }
    public string? Stage { get; set; }
    public string? Subject { get; set; }
    public string? VerificationStatus { get; set; }
}