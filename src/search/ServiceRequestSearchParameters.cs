namespace Aidbox.FHIR.Search;

public class ServiceRequestSearchParameters : DomainResourceSearchParameters
{
    public string? Authored { get; set; }
    public string? BasedOn { get; set; }
    public string? BodySite { get; set; }
    public string? Category { get; set; }
    public string? Code { get; set; }
    public string? Encounter { get; set; }
    public string? Identifier { get; set; }
    public string? InstantiatesCanonical { get; set; }
    public string? InstantiatesUri { get; set; }
    public string? Intent { get; set; }
    public string? Occurrence { get; set; }
    public string? Patient { get; set; }
    public string? Performer { get; set; }
    public string? PerformerType { get; set; }
    public string? Priority { get; set; }
    public string? Replaces { get; set; }
    public string? Requester { get; set; }
    public string? Requisition { get; set; }
    public string? ResearchStudy { get; set; }
    public string? Specimen { get; set; }
    public string? Status { get; set; }
    public string? Subject { get; set; }
}