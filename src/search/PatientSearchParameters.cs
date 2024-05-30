namespace Aidbox.FHIR.Search;

public class PatientSearchParameters : DomainResourceSearchParameters
{
    public string? Active { get; set; }
    public string? Address { get; set; }
    public string? AddressCity { get; set; }
    public string? AddressCountry { get; set; }
    public string? AddressPostalcode { get; set; }
    public string? AddressState { get; set; }
    public string? AddressUse { get; set; }
    public string? Birthdate { get; set; }
    public string? DeathDate { get; set; }
    public string? Deceased { get; set; }
    public string? Email { get; set; }
    public string? Ethnicity { get; set; }
    public string? Family { get; set; }
    public string? Gender { get; set; }
    public string? GeneralPractitioner { get; set; }
    public string? Given { get; set; }
    public string? Id { get; set; }
    public string? Identifier { get; set; }
    public string? Language { get; set; }
    public string? Link { get; set; }
    public string? Name { get; set; }
    public string? Organization { get; set; }
    public string? PartAgree { get; set; }
    public string? Phone { get; set; }
    public string? Phonetic { get; set; }
    public string? Race { get; set; }
    public string? Telecom { get; set; }
}