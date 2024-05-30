namespace Aidbox.FHIR.Search;

public class ResearchSubjectSearchParameters : DomainResourceSearchParameters
{
    public string? Date { get; set; }
    public string? Identifier { get; set; }
    public string? Individual { get; set; }
    public string? Patient { get; set; }
    public string? Status { get; set; }
    public string? Study { get; set; }
}