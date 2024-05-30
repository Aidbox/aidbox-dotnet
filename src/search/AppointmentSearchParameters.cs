namespace Aidbox.FHIR.Search;

public class AppointmentSearchParameters : DomainResourceSearchParameters
{
    public string? Actor { get; set; }
    public string? AppointmentType { get; set; }
    public string? BasedOn { get; set; }
    public string? Date { get; set; }
    public string? Identifier { get; set; }
    public string? Location { get; set; }
    public string? PartStatus { get; set; }
    public string? Patient { get; set; }
    public string? Practitioner { get; set; }
    public string? ReasonCode { get; set; }
    public string? ReasonReference { get; set; }
    public string? ServiceCategory { get; set; }
    public string? ServiceType { get; set; }
    public string? Slot { get; set; }
    public string? Specialty { get; set; }
    public string? Status { get; set; }
    public string? SupportingInfo { get; set; }
}