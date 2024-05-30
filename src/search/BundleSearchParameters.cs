namespace Aidbox.FHIR.Search;

public class BundleSearchParameters : ResourceSearchParameters
{
    public string? Composition { get; set; }
    public string? Identifier { get; set; }
    public string? Message { get; set; }
    public string? Timestamp { get; set; }
    public string? Type { get; set; }
}