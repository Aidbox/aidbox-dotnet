namespace Aidbox.FHIR.Search;

public class EncounterSearchParameters : DomainResourceSearchParameters
{
    public string? Account { get; set; }
    public string? Appointment { get; set; }
    public string? BasedOn { get; set; }
    public string? Class { get; set; }
    public string? Date { get; set; }
    public string? Diagnosis { get; set; }
    public string? EpisodeOfCare { get; set; }
    public string? Id { get; set; }
    public string? Identifier { get; set; }
    public string? Length { get; set; }
    public string? Location { get; set; }
    public string? LocationPeriod { get; set; }
    public string? PartOf { get; set; }
    public string? Participant { get; set; }
    public string? ParticipantType { get; set; }
    public string? Patient { get; set; }
    public string? Practitioner { get; set; }
    public string? ReasonCode { get; set; }
    public string? ReasonReference { get; set; }
    public string? ResearchStudy { get; set; }
    public string? ServiceProvider { get; set; }
    public string? SpecialArrangement { get; set; }
    public string? Status { get; set; }
    public string? Subject { get; set; }
    public string? Type { get; set; }
}