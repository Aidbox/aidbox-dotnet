namespace Aidbox.FHIR.Search;

public class GroupSearchParameters : DomainResourceSearchParameters
{
    public string? Actual { get; set; }
    public string? Characteristic { get; set; }
    public string? CharacteristicValue { get; set; }
    public string? Code { get; set; }
    public string? Exclude { get; set; }
    public string? Identifier { get; set; }
    public string? ManagingEntity { get; set; }
    public string? Member { get; set; }
    public string? Type { get; set; }
    public string? Value { get; set; }
}