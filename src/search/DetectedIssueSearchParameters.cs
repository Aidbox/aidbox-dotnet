namespace Aidbox.FHIR.Search;

public class DetectedIssueSearchParameters : DomainResourceSearchParameters
{
    public string? Author { get; set; }
    public string? Code { get; set; }
    public string? Identified { get; set; }
    public string? Identifier { get; set; }
    public string? Implicated { get; set; }
    public string? Patient { get; set; }
}