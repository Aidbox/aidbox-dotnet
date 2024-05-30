namespace Aidbox.FHIR.Search;

public class AllergyIntoleranceSearchParameters : DomainResourceSearchParameters
{
    public string? Asserter { get; set; }
    public string? Category { get; set; }
    public string? ClinicalStatus { get; set; }
    public string? Code { get; set; }
    public string? Criticality { get; set; }
    public string? Date { get; set; }
    public string? Identifier { get; set; }
    public string? LastDate { get; set; }
    public string? Manifestation { get; set; }
    public string? Onset { get; set; }
    public string? Patient { get; set; }
    public string? Recorder { get; set; }
    public string? Route { get; set; }
    public string? Severity { get; set; }
    public string? Type { get; set; }
    public string? VerificationStatus { get; set; }
}