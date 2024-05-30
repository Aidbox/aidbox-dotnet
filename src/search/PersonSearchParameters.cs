namespace Aidbox.FHIR.Search;

public class PersonSearchParameters : DomainResourceSearchParameters
{
    public string? Address { get; set; }
    public string? AddressCity { get; set; }
    public string? AddressCountry { get; set; }
    public string? AddressPostalcode { get; set; }
    public string? AddressState { get; set; }
    public string? AddressUse { get; set; }
    public string? Birthdate { get; set; }
    public string? Email { get; set; }
    public string? Gender { get; set; }
    public string? Identifier { get; set; }
    public string? Link { get; set; }
    public string? Name { get; set; }
    public string? Organization { get; set; }
    public string? Patient { get; set; }
    public string? Phone { get; set; }
    public string? Phonetic { get; set; }
    public string? Practitioner { get; set; }
    public string? Relatedperson { get; set; }
    public string? Telecom { get; set; }
}