namespace Aidbox.FHIR.Search;

public class ImagingStudySearchParameters : DomainResourceSearchParameters
{
    public string? Basedon { get; set; }
    public string? Bodysite { get; set; }
    public string? DicomClass { get; set; }
    public string? Encounter { get; set; }
    public string? Endpoint { get; set; }
    public string? Identifier { get; set; }
    public string? Instance { get; set; }
    public string? Interpreter { get; set; }
    public string? Modality { get; set; }
    public string? Patient { get; set; }
    public string? Performer { get; set; }
    public string? Reason { get; set; }
    public string? Referrer { get; set; }
    public string? Series { get; set; }
    public string? Started { get; set; }
    public string? Status { get; set; }
    public string? Subject { get; set; }
}