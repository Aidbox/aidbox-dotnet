namespace Aidbox.FHIR.Search;

public class MedicinalProductSearchParameters : DomainResourceSearchParameters
{
    public string? Identifier { get; set; }
    public string? Name { get; set; }
    public string? NameLanguage { get; set; }
}