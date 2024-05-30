namespace Aidbox.FHIR.Search;

public class DeviceUseStatementSearchParameters : DomainResourceSearchParameters
{
    public string? Device { get; set; }
    public string? Identifier { get; set; }
    public string? Patient { get; set; }
    public string? Subject { get; set; }
}