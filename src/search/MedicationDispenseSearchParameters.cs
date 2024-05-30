namespace Aidbox.FHIR.Search;

public class MedicationDispenseSearchParameters : DomainResourceSearchParameters
{
    public string? Code { get; set; }
    public string? Context { get; set; }
    public string? Destination { get; set; }
    public string? Identifier { get; set; }
    public string? Medication { get; set; }
    public string? Patient { get; set; }
    public string? Performer { get; set; }
    public string? Prescription { get; set; }
    public string? Receiver { get; set; }
    public string? ResearchStudy { get; set; }
    public string? Responsibleparty { get; set; }
    public string? Status { get; set; }
    public string? Subject { get; set; }
    public string? Type { get; set; }
    public string? Whenhandedover { get; set; }
    public string? Whenprepared { get; set; }
}