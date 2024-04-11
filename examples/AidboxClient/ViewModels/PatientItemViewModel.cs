using Aidbox.FHIR.Base;
using Aidbox.FHIR.Resource;

public class PatientItemViewModel
{
    public string? Id;
    public string? Name;
    public string? Active;
    public string? Gender;
    public string? BirthDate;
    public string? Address;


    public PatientItemViewModel(Patient patient)
    {
        Id = patient.Id;
        Name = this.nameToString(patient.Name);
        Active = this.activeToString(patient.Active);
        Gender = patient.Gender ?? "N/A";
        BirthDate = patient.BirthDate ?? "N/A";
        Address = this.addressToString(patient.Address);
    }

    private string nameToString(HumanName[]? name)
    {
        return name?.First().Text ?? "N/A";
    }

    private string addressToString(Address[]? address)
    {
        return "N/A";
    }

    private string activeToString(bool? active)
    {
        if (active is null)
        {
            return "N/A";
        }

        return (bool)active ? "Yes" : "No";
    }
}