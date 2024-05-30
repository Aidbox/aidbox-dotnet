namespace Aidbox.FHIR.Search;

public class InvoiceSearchParameters : DomainResourceSearchParameters
{
    public string? Account { get; set; }
    public string? Date { get; set; }
    public string? Identifier { get; set; }
    public string? Issuer { get; set; }
    public string? Participant { get; set; }
    public string? ParticipantRole { get; set; }
    public string? Patient { get; set; }
    public string? Recipient { get; set; }
    public string? Status { get; set; }
    public string? Subject { get; set; }
    public string? Totalgross { get; set; }
    public string? Totalnet { get; set; }
    public string? Type { get; set; }
}