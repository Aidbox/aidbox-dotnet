namespace Aidbox.FHIR.Search;

public class TaskSearchParameters : DomainResourceSearchParameters
{
    public string? AuthoredOn { get; set; }
    public string? BasedOn { get; set; }
    public string? BusinessStatus { get; set; }
    public string? Code { get; set; }
    public string? Encounter { get; set; }
    public string? Focus { get; set; }
    public string? GroupIdentifier { get; set; }
    public string? Identifier { get; set; }
    public string? Intent { get; set; }
    public string? Modified { get; set; }
    public string? Owner { get; set; }
    public string? PartOf { get; set; }
    public string? Patient { get; set; }
    public string? Performer { get; set; }
    public string? Period { get; set; }
    public string? Priority { get; set; }
    public string? Requester { get; set; }
    public string? ResearchStudy { get; set; }
    public string? Status { get; set; }
    public string? Subject { get; set; }
}