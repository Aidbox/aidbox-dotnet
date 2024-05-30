namespace Aidbox.FHIR.Search;

public class PractitionerSearchParameters : DomainResourceSearchParameters
{
    public string? Active { get; set; }
    public string? Address { get; set; }
    public string? AddressCity { get; set; }
    public string? AddressCountry { get; set; }
    public string? AddressPostalcode { get; set; }
    public string? AddressState { get; set; }
    public string? AddressUse { get; set; }
    public string? Communication { get; set; }
    public string? Email { get; set; }
    public string? Family { get; set; }
    public string? Gender { get; set; }
    public string? Given { get; set; }
    public string? Identifier { get; set; }
    public string? Name { get; set; }
    public string? Phone { get; set; }
    public string? Phonetic { get; set; }
    public string? Telecom { get; set; }
}