using Aidbox.FHIR.Base;
using Aidbox.FHIR.Utils;

namespace Aidbox.FHIR.Resource;

public class SubstanceNucleicAcid : DomainResource, IResource
{
    public SubstanceNucleicAcid_Subunit[]? Subunit { get; set; }
    public Base.CodeableConcept? SequenceType { get; set; }
    public int? NumberOfSubunits { get; set; }
    public string? AreaOfHybridisation { get; set; }
    public Base.CodeableConcept? OligoNucleotideType { get; set; }

    public class SubstanceNucleicAcid_Subunit_Sugar : BackboneElement
    {
        public string? Name { get; set; }
        public Base.Identifier? Identifier { get; set; }
        public string? ResidueSite { get; set; }
    }

    public class SubstanceNucleicAcid_Subunit_Linkage : BackboneElement
    {
        public string? Name { get; set; }
        public Base.Identifier? Identifier { get; set; }
        public string? ResidueSite { get; set; }
        public string? Connectivity { get; set; }
    }

    public class SubstanceNucleicAcid_Subunit : BackboneElement
    {
        public SubstanceNucleicAcid_Subunit_Sugar[]? Sugar { get; set; }
        public int? Length { get; set; }
        public SubstanceNucleicAcid_Subunit_Linkage[]? Linkage { get; set; }
        public int? Subunit { get; set; }
        public string? Sequence { get; set; }
        public Base.CodeableConcept? FivePrime { get; set; }
        public Base.CodeableConcept? ThreePrime { get; set; }
        public Base.Attachment? SequenceAttachment { get; set; }
    }
}