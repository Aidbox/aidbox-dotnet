namespace Aidbox.FHIR.Search;

public class HealthcareServiceSearchParameters : DomainResourceSearchParameters
{
    public string? Active { get; set; }
    public string? Characteristic { get; set; }
    public string? CoverageArea { get; set; }
    public string? Endpoint { get; set; }
    public string? Identifier { get; set; }
    public string? Location { get; set; }
    public string? Name { get; set; }
    public string? Organization { get; set; }
    public string? Program { get; set; }
    public string? ServiceCategory { get; set; }
    public string? ServiceType { get; set; }
    public string? Specialty { get; set; }
}