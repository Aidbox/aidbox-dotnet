using Aidbox.FHIR.Base;
using Utils;

namespace Aidbox.FHIR.Constraint;

public class UsCoreDiagnosticreportNote : IResource
{
	public Meta Meta { get; set; } = new() { Profile = ["http://hl7.org/fhir/us/core/StructureDefinition/us-core-diagnosticreport-note"] };
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
	public string? Issued { get; set; }
	public Base.Attachment[]? PresentedForm { get; set; }
	public Base.ResourceReference[]? BasedOn { get; set; }
	public Base.ResourceReference[]? ImagingStudy { get; set; }
	public DiagnosticReport_Media[]? Media { get; set; }
	public required Base.ResourceReference Subject { get; set; }
	public Base.ResourceReference[]? Performer { get; set; }
	public Base.Period? EffectivePeriod { get; set; }
	public Base.Narrative? Text { get; set; }
	public Base.Resource[]? Contained { get; set; }
	public Base.Extension[]? Extension { get; set; }
	public Base.Extension[]? ModifierExtension { get; set; }
	public string? Id { get; set; }
	public string? ImplicitRules { get; set; }
	public string? Language { get; set; }

public class DiagnosticReport_Media : BackboneElement
{
	public string? Comment { get; set; }
	public required Base.ResourceReference Link { get; set; }
}
}