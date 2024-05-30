namespace Aidbox.FHIR.Search;

public class BodyStructureSearchParameters : DomainResourceSearchParameters
{
    public string? Identifier { get; set; }
    public string? Location { get; set; }
    public string? Morphology { get; set; }
    public string? Patient { get; set; }
}