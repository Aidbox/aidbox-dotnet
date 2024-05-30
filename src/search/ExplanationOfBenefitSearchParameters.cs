namespace Aidbox.FHIR.Search;

public class ExplanationOfBenefitSearchParameters : DomainResourceSearchParameters
{
    public string? CareTeam { get; set; }
    public string? Claim { get; set; }
    public string? Coverage { get; set; }
    public string? Created { get; set; }
    public string? DetailUdi { get; set; }
    public string? Disposition { get; set; }
    public string? Encounter { get; set; }
    public string? Enterer { get; set; }
    public string? Facility { get; set; }
    public string? Identifier { get; set; }
    public string? ItemUdi { get; set; }
    public string? Patient { get; set; }
    public string? Payee { get; set; }
    public string? ProcedureUdi { get; set; }
    public string? Provider { get; set; }
    public string? Status { get; set; }
    public string? SubdetailUdi { get; set; }
}