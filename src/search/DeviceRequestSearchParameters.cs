namespace Aidbox.FHIR.Search;

public class DeviceRequestSearchParameters : DomainResourceSearchParameters
{
    public string? AuthoredOn { get; set; }
    public string? BasedOn { get; set; }
    public string? Code { get; set; }
    public string? Device { get; set; }
    public string? Encounter { get; set; }
    public string? EventDate { get; set; }
    public string? GroupIdentifier { get; set; }
    public string? Identifier { get; set; }
    public string? InstantiatesCanonical { get; set; }
    public string? InstantiatesUri { get; set; }
    public string? Insurance { get; set; }
    public string? Intent { get; set; }
    public string? Patient { get; set; }
    public string? Performer { get; set; }
    public string? PriorRequest { get; set; }
    public string? Requester { get; set; }
    public string? Status { get; set; }
    public string? Subject { get; set; }
}