namespace Aidbox.FHIR.Search;

public class CoverageEligibilityRequestSearchParameters : DomainResourceSearchParameters
{
    public string? Created { get; set; }
    public string? Enterer { get; set; }
    public string? Facility { get; set; }
    public string? Identifier { get; set; }
    public string? Patient { get; set; }
    public string? Provider { get; set; }
    public string? Status { get; set; }
}