namespace Aidbox.FHIR.Search;

public class SpecimenDefinitionSearchParameters : DomainResourceSearchParameters
{
    public string? Container { get; set; }
    public string? Identifier { get; set; }
    public string? Type { get; set; }
}