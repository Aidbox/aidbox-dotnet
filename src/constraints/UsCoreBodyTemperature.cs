using Aidbox.FHIR.Base;
using Aidbox.FHIR.Utils;

namespace Aidbox.FHIR.Constraint;

public class UsCoreBodyTemperature : DomainResource
{
    public new Meta Meta { get; } = new() { Profile = ["http://hl7.org/fhir/us/core/StructureDefinition/us-core-body-temperature"] };
    public required Base.CodeableConcept[] Category { get; set; }
    public Observation_ReferenceRange[]? ReferenceRange { get; set; }
    public Base.ResourceReference[]? HasMember { get; set; }
    public Base.ResourceReference[]? DerivedFrom { get; set; }
    public Base.CodeableConcept[]? Interpretation { get; set; }
    public Base.ResourceReference? Encounter { get; set; }
    public Base.CodeableConcept? Method { get; set; }
    public string? ValueTime { get; set; }
    public Base.ResourceReference? Specimen { get; set; }
    public Base.Quantity? ValueQuantity { get; set; }
    public string? ValueString { get; set; }
    public Base.Ratio? ValueRatio { get; set; }
    public bool? ValueBoolean { get; set; }
    public string? ValueDateTime { get; set; }
    public Observation_Component[]? Component { get; set; }
    public Base.Annotation[]? Note { get; set; }
    public Base.SampledData? ValueSampledData { get; set; }
    public string? EffectiveDateTime { get; set; }
    public required string Status { get; set; }
    public required Base.CodeableConcept Code { get; set; }
    public Base.Identifier[]? Identifier { get; set; }
    public Base.CodeableConcept? ValueCodeableConcept { get; set; }
    public Base.CodeableConcept? BodySite { get; set; }
    public Base.ResourceReference[]? Focus { get; set; }
    public string? Issued { get; set; }
    public Base.Period? ValuePeriod { get; set; }
    public Base.ResourceReference? Device { get; set; }
    public Base.ResourceReference[]? BasedOn { get; set; }
    public Base.Range? ValueRange { get; set; }
    public Base.ResourceReference[]? PartOf { get; set; }
    public int? ValueInteger { get; set; }
    public required Base.ResourceReference Subject { get; set; }
    public Base.ResourceReference[]? Performer { get; set; }
    public Base.CodeableConcept? DataAbsentReason { get; set; }
    public Base.Period? EffectivePeriod { get; set; }

    public class Observation_ReferenceRange : BackboneElement
    {
        public Base.Range? Age { get; set; }
        public Base.Quantity? Low { get; set; }
        public Base.Quantity? High { get; set; }
        public string? Text { get; set; }
        public Base.CodeableConcept? Type { get; set; }
        public Base.CodeableConcept[]? AppliesTo { get; set; }
    }

    public class Observation_Component_ReferenceRange : BackboneElement
    {
        public Base.Range? Age { get; set; }
        public Base.Quantity? Low { get; set; }
        public Base.Quantity? High { get; set; }
        public string? Text { get; set; }
        public Base.CodeableConcept? Type { get; set; }
        public Base.CodeableConcept[]? AppliesTo { get; set; }
    }

    public class Observation_Component : BackboneElement
    {
        public Observation_Component_ReferenceRange[]? ReferenceRange { get; set; }
        public Base.CodeableConcept[]? Interpretation { get; set; }
        public string? ValueTime { get; set; }
        public Base.Quantity? ValueQuantity { get; set; }
        public string? ValueString { get; set; }
        public Base.Ratio? ValueRatio { get; set; }
        public bool? ValueBoolean { get; set; }
        public string? ValueDateTime { get; set; }
        public Base.SampledData? ValueSampledData { get; set; }
        public required Base.CodeableConcept Code { get; set; }
        public Base.CodeableConcept? ValueCodeableConcept { get; set; }
        public Base.Period? ValuePeriod { get; set; }
        public Base.Range? ValueRange { get; set; }
        public int? ValueInteger { get; set; }
        public Base.CodeableConcept? DataAbsentReason { get; set; }
    }
}