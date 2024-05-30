namespace Aidbox.FHIR.Search;

public class LocationSearchParameters : DomainResourceSearchParameters
{
    public string? Address { get; set; }
    public string? AddressCity { get; set; }
    public string? AddressCountry { get; set; }
    public string? AddressPostalcode { get; set; }
    public string? AddressState { get; set; }
    public string? AddressUse { get; set; }
    public string? Endpoint { get; set; }
    public string? Identifier { get; set; }
    public string? Name { get; set; }
    public string? Near { get; set; }
    public string? OperationalStatus { get; set; }
    public string? Organization { get; set; }
    public string? Partof { get; set; }
    public string? Status { get; set; }
    public string? Type { get; set; }
}