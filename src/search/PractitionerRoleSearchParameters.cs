namespace Aidbox.FHIR.Search;

public class PractitionerRoleSearchParameters : DomainResourceSearchParameters
{
    public string? Active { get; set; }
    public string? Date { get; set; }
    public string? Email { get; set; }
    public string? Endpoint { get; set; }
    public string? Identifier { get; set; }
    public string? Location { get; set; }
    public string? Organization { get; set; }
    public string? Phone { get; set; }
    public string? Practitioner { get; set; }
    public string? Role { get; set; }
    public string? Service { get; set; }
    public string? Specialty { get; set; }
    public string? Telecom { get; set; }
}