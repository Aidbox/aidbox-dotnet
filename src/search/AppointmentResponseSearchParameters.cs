namespace Aidbox.FHIR.Search;

public class AppointmentResponseSearchParameters : DomainResourceSearchParameters
{
    public string? Actor { get; set; }
    public string? Appointment { get; set; }
    public string? Identifier { get; set; }
    public string? Location { get; set; }
    public string? PartStatus { get; set; }
    public string? Patient { get; set; }
    public string? Practitioner { get; set; }
}