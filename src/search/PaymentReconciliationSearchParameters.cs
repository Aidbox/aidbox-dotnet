namespace Aidbox.FHIR.Search;

public class PaymentReconciliationSearchParameters : DomainResourceSearchParameters
{
    public string? Created { get; set; }
    public string? Disposition { get; set; }
    public string? Identifier { get; set; }
    public string? Outcome { get; set; }
    public string? PaymentIssuer { get; set; }
    public string? Request { get; set; }
    public string? Requestor { get; set; }
    public string? Status { get; set; }
}