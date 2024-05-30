using Aidbox.FHIR.Base;
using Aidbox.FHIR.Utils;

namespace Aidbox.FHIR.Constraint;

public class McodeGenomicsReport : DomainResource
{
    public new Meta Meta { get; } = new() { Profile = ["http://hl7.org/fhir/us/mcode/StructureDefinition/mcode-genomics-report"] };
    public required Base.CodeableConcept[] Category { get; set; }
    public Base.CodeableConcept[]? ConclusionCode { get; set; }
    public string? Conclusion { get; set; }
    public Base.ResourceReference? Encounter { get; set; }
    public Base.ResourceReference[]? Specimen { get; set; }
    public string? EffectiveDateTime { get; set; }
    public Base.ResourceReference[]? ResultsInterpreter { get; set; }
    public required string Status { get; set; }
    public Base.ResourceReference[]? Result { get; set; }
    public required Base.CodeableConcept Code { get; set; }
    public Base.Identifier[]? Identifier { get; set; }
    public required string Issued { get; set; }
    public Base.Attachment[]? PresentedForm { get; set; }
    public Base.ResourceReference[]? BasedOn { get; set; }
    public Base.ResourceReference[]? ImagingStudy { get; set; }
    public DiagnosticReport_Media[]? Media { get; set; }
    public required Base.ResourceReference Subject { get; set; }
    public Base.ResourceReference[]? Performer { get; set; }
    public Base.Period? EffectivePeriod { get; set; }

    public class DiagnosticReport_Media : BackboneElement
    {
        public required Base.ResourceReference Link { get; set; }
        public string? Comment { get; set; }
    }
}