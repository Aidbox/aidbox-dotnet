namespace Aidbox.FHIR.Resource;

public class PatientSearchParameters : ResourceSearchParameters
{
    public bool? Active;
    public string? Address;
    public string? AddressCity;
    public string? AddressCountry;
    public string? AddressPostalCode;
    public string? AddressState;
    public string? AddressUse;
    public string? BirthDate;
    public string? DeathDate;
    public string? Deceased;
    public string? Email;
}