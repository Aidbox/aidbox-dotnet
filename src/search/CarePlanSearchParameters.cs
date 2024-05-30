namespace Aidbox.FHIR.Search;

public class CarePlanSearchParameters : DomainResourceSearchParameters
{
    public string? ActivityCode { get; set; }
    public string? ActivityDate { get; set; }
    public string? ActivityReference { get; set; }
    public string? BasedOn { get; set; }
    public string? CareTeam { get; set; }
    public string? Category { get; set; }
    public string? Condition { get; set; }
    public string? Date { get; set; }
    public string? Encounter { get; set; }
    public string? Goal { get; set; }
    public string? Identifier { get; set; }
    public string? InstantiatesCanonical { get; set; }
    public string? InstantiatesUri { get; set; }
    public string? Intent { get; set; }
    public string? PartOf { get; set; }
    public string? Patient { get; set; }
    public string? Performer { get; set; }
    public string? Replaces { get; set; }
    public string? Status { get; set; }
    public string? Subject { get; set; }
    public string? WorkflowBarrierCode { get; set; }
    public string? WorkflowBarrierRef { get; set; }
    public string? WorkflowProtectiveFactorCode { get; set; }
    public string? WorkflowProtectiveFactorRef { get; set; }
}