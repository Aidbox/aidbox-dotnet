namespace Aidbox.FHIR.Search;

public class MedicationRequestSearchParameters : DomainResourceSearchParameters
{
    public string? Authoredon { get; set; }
    public string? Category { get; set; }
    public string? Code { get; set; }
    public string? Date { get; set; }
    public string? Encounter { get; set; }
    public string? Identifier { get; set; }
    public string? IntendedDispenser { get; set; }
    public string? IntendedPerformer { get; set; }
    public string? IntendedPerformertype { get; set; }
    public string? Intent { get; set; }
    public string? Medication { get; set; }
    public string? Patient { get; set; }
    public string? Priority { get; set; }
    public string? Requester { get; set; }
    public string? Status { get; set; }
    public string? Subject { get; set; }
}