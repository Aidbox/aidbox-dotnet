namespace Aidbox.FHIR.Search;

public class SlotSearchParameters : DomainResourceSearchParameters
{
    public string? AppointmentType { get; set; }
    public string? Identifier { get; set; }
    public string? Schedule { get; set; }
    public string? ServiceCategory { get; set; }
    public string? ServiceType { get; set; }
    public string? Specialty { get; set; }
    public string? Start { get; set; }
    public string? Status { get; set; }
}