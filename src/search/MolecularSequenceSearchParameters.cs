namespace Aidbox.FHIR.Search;

public class MolecularSequenceSearchParameters : DomainResourceSearchParameters
{
    public string? Chromosome { get; set; }
    public string? ChromosomeVariantCoordinate { get; set; }
    public string? ChromosomeWindowCoordinate { get; set; }
    public string? Identifier { get; set; }
    public string? Patient { get; set; }
    public string? Referenceseqid { get; set; }
    public string? ReferenceseqidVariantCoordinate { get; set; }
    public string? ReferenceseqidWindowCoordinate { get; set; }
    public string? Type { get; set; }
    public string? VariantEnd { get; set; }
    public string? VariantStart { get; set; }
    public string? WindowEnd { get; set; }
    public string? WindowStart { get; set; }
}