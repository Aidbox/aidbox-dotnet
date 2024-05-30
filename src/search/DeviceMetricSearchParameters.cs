namespace Aidbox.FHIR.Search;

public class DeviceMetricSearchParameters : DomainResourceSearchParameters
{
    public string? Category { get; set; }
    public string? Identifier { get; set; }
    public string? Parent { get; set; }
    public string? Source { get; set; }
    public string? Type { get; set; }
}