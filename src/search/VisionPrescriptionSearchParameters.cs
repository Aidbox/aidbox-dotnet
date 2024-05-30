namespace Aidbox.FHIR.Search;

public class VisionPrescriptionSearchParameters : DomainResourceSearchParameters
{
    public string? Datewritten { get; set; }
    public string? Encounter { get; set; }
    public string? Identifier { get; set; }
    public string? Patient { get; set; }
    public string? Prescriber { get; set; }
    public string? Status { get; set; }
}