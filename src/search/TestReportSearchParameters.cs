namespace Aidbox.FHIR.Search;

public class TestReportSearchParameters : DomainResourceSearchParameters
{
    public string? Identifier { get; set; }
    public string? Issued { get; set; }
    public string? Participant { get; set; }
    public string? Result { get; set; }
    public string? Tester { get; set; }
    public string? Testscript { get; set; }
}