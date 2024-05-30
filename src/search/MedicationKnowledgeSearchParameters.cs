namespace Aidbox.FHIR.Search;

public class MedicationKnowledgeSearchParameters : DomainResourceSearchParameters
{
    public string? Classification { get; set; }
    public string? ClassificationType { get; set; }
    public string? Code { get; set; }
    public string? Doseform { get; set; }
    public string? Ingredient { get; set; }
    public string? IngredientCode { get; set; }
    public string? Manufacturer { get; set; }
    public string? MonitoringProgramName { get; set; }
    public string? MonitoringProgramType { get; set; }
    public string? Monograph { get; set; }
    public string? MonographType { get; set; }
    public string? SourceCost { get; set; }
    public string? Status { get; set; }
}