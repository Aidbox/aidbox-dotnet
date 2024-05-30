namespace Aidbox.FHIR.Search;

public class PaymentNoticeSearchParameters : DomainResourceSearchParameters
{
    public string? Created { get; set; }
    public string? Identifier { get; set; }
    public string? PaymentStatus { get; set; }
    public string? Provider { get; set; }
    public string? Request { get; set; }
    public string? Response { get; set; }
    public string? Status { get; set; }
}