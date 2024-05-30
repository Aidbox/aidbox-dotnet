namespace Aidbox.FHIR.Search;

public class ProcedureSearchParameters : DomainResourceSearchParameters
{
    public string? BasedOn { get; set; }
    public string? Category { get; set; }
    public string? Code { get; set; }
    public string? Date { get; set; }
    public string? Encounter { get; set; }
    public string? Identifier { get; set; }
    public string? InstantiatesCanonical { get; set; }
    public string? InstantiatesUri { get; set; }
    public string? Location { get; set; }
    public string? PartOf { get; set; }
    public string? Patient { get; set; }
    public string? Performer { get; set; }
    public string? ReasonCode { get; set; }
    public string? ReasonReference { get; set; }
    public string? ResearchStudy { get; set; }
    public string? Status { get; set; }
    public string? Subject { get; set; }
}