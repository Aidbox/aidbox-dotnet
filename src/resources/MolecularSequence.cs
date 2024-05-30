using Aidbox.FHIR.Base;
using Aidbox.FHIR.Utils;

namespace Aidbox.FHIR.Resource;

public class MolecularSequence : DomainResource, IResource
{
    public Base.ResourceReference? Patient { get; set; }
    public MolecularSequence_StructureVariant[]? StructureVariant { get; set; }
    public MolecularSequence_Repository[]? Repository { get; set; }
    public MolecularSequence_Variant[]? Variant { get; set; }
    public Base.ResourceReference? Specimen { get; set; }
    public string? Type { get; set; }
    public Base.ResourceReference[]? Pointer { get; set; }
    public string? ObservedSeq { get; set; }
    public Base.Identifier[]? Identifier { get; set; }
    public MolecularSequence_Quality[]? Quality { get; set; }
    public Base.ResourceReference? Device { get; set; }
    public Base.Quantity? Quantity { get; set; }
    public required int CoordinateSystem { get; set; }
    public MolecularSequence_ReferenceSeq? ReferenceSeq { get; set; }
    public Base.ResourceReference? Performer { get; set; }
    public int? ReadCoverage { get; set; }

    public class MolecularSequence_StructureVariant_Inner : BackboneElement
    {
        public int? End { get; set; }
        public int? Start { get; set; }
    }

    public class MolecularSequence_StructureVariant_Outer : BackboneElement
    {
        public int? End { get; set; }
        public int? Start { get; set; }
    }

    public class MolecularSequence_StructureVariant : BackboneElement
    {
        public bool? Exact { get; set; }
        public MolecularSequence_StructureVariant_Inner? Inner { get; set; }
        public MolecularSequence_StructureVariant_Outer? Outer { get; set; }
        public int? Length { get; set; }
        public Base.CodeableConcept? VariantType { get; set; }
    }

    public class MolecularSequence_Repository : BackboneElement
    {
        public string? Url { get; set; }
        public string? Name { get; set; }
        public required string Type { get; set; }
        public string? DatasetId { get; set; }
        public string? ReadsetId { get; set; }
        public string? VariantsetId { get; set; }
    }

    public class MolecularSequence_Variant : BackboneElement
    {
        public int? End { get; set; }
        public string? Cigar { get; set; }
        public int? Start { get; set; }
        public string? ObservedAllele { get; set; }
        public Base.ResourceReference? VariantPointer { get; set; }
        public string? ReferenceAllele { get; set; }
    }

    public class MolecularSequence_Quality_Roc : BackboneElement
    {
        public int[]? NumFN { get; set; }
        public int[]? NumFP { get; set; }
        public int[]? NumTP { get; set; }
        public int[]? Score { get; set; }
        public string[]? FMeasure { get; set; }
        public string[]? Precision { get; set; }
        public string[]? Sensitivity { get; set; }
    }

    public class MolecularSequence_Quality : BackboneElement
    {
        public string? TruthTP { get; set; }
        public string? FScore { get; set; }
        public string? TruthFN { get; set; }
        public string? QueryFP { get; set; }
        public Base.CodeableConcept? Method { get; set; }
        public string? Precision { get; set; }
        public int? Start { get; set; }
        public string? QueryTP { get; set; }
        public required string Type { get; set; }
        public string? Recall { get; set; }
        public MolecularSequence_Quality_Roc? Roc { get; set; }
        public Base.Quantity? Score { get; set; }
        public int? End { get; set; }
        public Base.CodeableConcept? StandardSequence { get; set; }
        public string? GtFP { get; set; }
    }

    public class MolecularSequence_ReferenceSeq : BackboneElement
    {
        public Base.CodeableConcept? Chromosome { get; set; }
        public Base.CodeableConcept? ReferenceSeqId { get; set; }
        public int? WindowEnd { get; set; }
        public string? Strand { get; set; }
        public string? GenomeBuild { get; set; }
        public string? Orientation { get; set; }
        public Base.ResourceReference? ReferenceSeqPointer { get; set; }
        public string? ReferenceSeqString { get; set; }
        public int? WindowStart { get; set; }
    }
}