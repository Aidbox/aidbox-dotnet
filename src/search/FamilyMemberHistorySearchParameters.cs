namespace Aidbox.FHIR.Search;

public class FamilyMemberHistorySearchParameters : DomainResourceSearchParameters
{
    public string? Code { get; set; }
    public string? Date { get; set; }
    public string? Identifier { get; set; }
    public string? InstantiatesCanonical { get; set; }
    public string? InstantiatesUri { get; set; }
    public string? Patient { get; set; }
    public string? Relationship { get; set; }
    public string? ResearchStudy { get; set; }
    public string? Sex { get; set; }
    public string? Status { get; set; }
}