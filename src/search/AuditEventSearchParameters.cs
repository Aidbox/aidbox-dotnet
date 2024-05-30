namespace Aidbox.FHIR.Search;

public class AuditEventSearchParameters : DomainResourceSearchParameters
{
    public string? Action { get; set; }
    public string? Address { get; set; }
    public string? Agent { get; set; }
    public string? AgentName { get; set; }
    public string? AgentRole { get; set; }
    public string? Altid { get; set; }
    public string? Date { get; set; }
    public string? Entity { get; set; }
    public string? EntityName { get; set; }
    public string? EntityRole { get; set; }
    public string? EntityType { get; set; }
    public string? Outcome { get; set; }
    public string? Patient { get; set; }
    public string? Policy { get; set; }
    public string? Site { get; set; }
    public string? Source { get; set; }
    public string? Subtype { get; set; }
    public string? Type { get; set; }
}