using Aidbox.FHIR.Base;
using Aidbox.FHIR.Utils;

namespace Aidbox.FHIR.Constraint;

public class Cdshooksguidanceresponse : DomainResource
{
    public new Meta Meta { get; } = new() { Profile = ["http://hl7.org/fhir/StructureDefinition/cdshooksguidanceresponse"] };
    public Base.DataRequirement[]? DataRequirement { get; set; }
    public string? ModuleCanonical { get; set; }
    public Base.ResourceReference? Encounter { get; set; }
    public Base.CodeableConcept[]? ReasonCode { get; set; }
    public Base.ResourceReference? OutputParameters { get; set; }
    public Base.ResourceReference[]? EvaluationMessage { get; set; }
    public required Base.Identifier RequestIdentifier { get; set; }
    public Base.Annotation[]? Note { get; set; }
    public required string Status { get; set; }
    public Base.ResourceReference? Result { get; set; }
    public required Base.Identifier[] Identifier { get; set; }
    public Base.CodeableConcept? ModuleCodeableConcept { get; set; }
    public required string ModuleUri { get; set; }
    public string? OccurrenceDateTime { get; set; }
    public Base.ResourceReference? Subject { get; set; }
    public Base.ResourceReference? Performer { get; set; }
    public Base.ResourceReference[]? ReasonReference { get; set; }
}