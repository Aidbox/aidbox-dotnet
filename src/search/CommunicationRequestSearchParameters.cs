namespace Aidbox.FHIR.Search;

public class CommunicationRequestSearchParameters : DomainResourceSearchParameters
{
    public string? Authored { get; set; }
    public string? BasedOn { get; set; }
    public string? Category { get; set; }
    public string? Encounter { get; set; }
    public string? GroupIdentifier { get; set; }
    public string? Identifier { get; set; }
    public string? Medium { get; set; }
    public string? Occurrence { get; set; }
    public string? Patient { get; set; }
    public string? Priority { get; set; }
    public string? Recipient { get; set; }
    public string? Replaces { get; set; }
    public string? Requester { get; set; }
    public string? Sender { get; set; }
    public string? Status { get; set; }
    public string? Subject { get; set; }
    public string? WorkflowBarrierCode { get; set; }
    public string? WorkflowBarrierRef { get; set; }
    public string? WorkflowProtectiveFactorCode { get; set; }
    public string? WorkflowProtectiveFactorRef { get; set; }
}