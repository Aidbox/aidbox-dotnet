namespace Aidbox.FHIR.Search;

public class MediaSearchParameters : DomainResourceSearchParameters
{
    public string? BasedOn { get; set; }
    public string? Created { get; set; }
    public string? Device { get; set; }
    public string? Encounter { get; set; }
    public string? Identifier { get; set; }
    public string? Modality { get; set; }
    public string? Operator { get; set; }
    public string? Patient { get; set; }
    public string? Site { get; set; }
    public string? Status { get; set; }
    public string? Subject { get; set; }
    public string? Type { get; set; }
    public string? View { get; set; }
}