namespace Aidbox.FHIR.Search;

public class ScheduleSearchParameters : DomainResourceSearchParameters
{
    public string? Active { get; set; }
    public string? Actor { get; set; }
    public string? Date { get; set; }
    public string? Identifier { get; set; }
    public string? ServiceCategory { get; set; }
    public string? ServiceType { get; set; }
    public string? Specialty { get; set; }
}