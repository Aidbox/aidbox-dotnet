namespace Aidbox.FHIR.Search;

public class DeviceSearchParameters : DomainResourceSearchParameters
{
    public string? DeviceName { get; set; }
    public string? Identifier { get; set; }
    public string? Location { get; set; }
    public string? Manufacturer { get; set; }
    public string? Model { get; set; }
    public string? Organization { get; set; }
    public string? Patient { get; set; }
    public string? Status { get; set; }
    public string? Type { get; set; }
    public string? UdiCarrier { get; set; }
    public string? UdiDi { get; set; }
    public string? Url { get; set; }
}