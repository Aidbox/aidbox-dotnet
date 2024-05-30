namespace Aidbox.FHIR.Search;

public class MessageHeaderSearchParameters : DomainResourceSearchParameters
{
    public string? Author { get; set; }
    public string? Code { get; set; }
    public string? Destination { get; set; }
    public string? DestinationUri { get; set; }
    public string? Enterer { get; set; }
    public string? Event { get; set; }
    public string? Focus { get; set; }
    public string? Receiver { get; set; }
    public string? ResponseId { get; set; }
    public string? Responsible { get; set; }
    public string? Sender { get; set; }
    public string? Source { get; set; }
    public string? SourceUri { get; set; }
    public string? Target { get; set; }
}