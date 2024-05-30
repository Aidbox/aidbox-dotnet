namespace Aidbox.FHIR.Search;

public class MedicationStatementSearchParameters : DomainResourceSearchParameters
{
    public string? Category { get; set; }
    public string? Code { get; set; }
    public string? Context { get; set; }
    public string? Effective { get; set; }
    public string? Identifier { get; set; }
    public string? Medication { get; set; }
    public string? PartOf { get; set; }
    public string? Patient { get; set; }
    public string? ResearchStudy { get; set; }
    public string? Source { get; set; }
    public string? Status { get; set; }
    public string? Subject { get; set; }
}