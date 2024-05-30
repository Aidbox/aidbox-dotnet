namespace Aidbox.FHIR.Search;

public class MedicinalProductPackagedSearchParameters : DomainResourceSearchParameters
{
    public string? Identifier { get; set; }
    public string? Subject { get; set; }
}