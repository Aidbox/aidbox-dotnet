namespace Aidbox.FHIR.Search;

public class DeviceDefinitionSearchParameters : DomainResourceSearchParameters
{
    public string? Identifier { get; set; }
    public string? Parent { get; set; }
    public string? Type { get; set; }
}