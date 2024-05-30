namespace Aidbox.FHIR.Search;

public class ClaimResponseSearchParameters : DomainResourceSearchParameters
{
    public string? Created { get; set; }
    public string? Disposition { get; set; }
    public string? Identifier { get; set; }
    public string? Insurer { get; set; }
    public string? Outcome { get; set; }
    public string? Patient { get; set; }
    public string? PaymentDate { get; set; }
    public string? Request { get; set; }
    public string? Requestor { get; set; }
    public string? Status { get; set; }
    public string? Use { get; set; }
}