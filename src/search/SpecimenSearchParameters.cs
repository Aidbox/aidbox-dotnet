namespace Aidbox.FHIR.Search;

public class SpecimenSearchParameters : DomainResourceSearchParameters
{
    public string? Accession { get; set; }
    public string? Bodysite { get; set; }
    public string? Collected { get; set; }
    public string? Collector { get; set; }
    public string? Container { get; set; }
    public string? ContainerId { get; set; }
    public string? Identifier { get; set; }
    public string? Parent { get; set; }
    public string? Patient { get; set; }
    public string? Status { get; set; }
    public string? Subject { get; set; }
    public string? Type { get; set; }
}