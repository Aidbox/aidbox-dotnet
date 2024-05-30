namespace Aidbox.FHIR.Search;

public class CommunicationSearchParameters : DomainResourceSearchParameters
{
    public string? BasedOn { get; set; }
    public string? Category { get; set; }
    public string? Encounter { get; set; }
    public string? Identifier { get; set; }
    public string? InstantiatesCanonical { get; set; }
    public string? InstantiatesUri { get; set; }
    public string? Medium { get; set; }
    public string? PartOf { get; set; }
    public string? Patient { get; set; }
    public string? Received { get; set; }
    public string? Recipient { get; set; }
    public string? Sender { get; set; }
    public string? Sent { get; set; }
    public string? Status { get; set; }
    public string? Subject { get; set; }
}