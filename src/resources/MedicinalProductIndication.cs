using Aidbox.FHIR.Base;
using Aidbox.FHIR.Utils;

namespace Aidbox.FHIR.Resource;

public class MedicinalProductIndication : DomainResource, IResource
{
    public Base.CodeableConcept? DiseaseSymptomProcedure { get; set; }
    public Base.ResourceReference[]? UndesirableEffect { get; set; }
    public Base.Quantity? Duration { get; set; }
    public MedicinalProductIndication_OtherTherapy[]? OtherTherapy { get; set; }
    public Base.CodeableConcept[]? Comorbidity { get; set; }
    public Base.CodeableConcept? IntendedEffect { get; set; }
    public Base.Population[]? Population { get; set; }
    public Base.CodeableConcept? DiseaseStatus { get; set; }
    public Base.ResourceReference[]? Subject { get; set; }

    public class MedicinalProductIndication_OtherTherapy : BackboneElement
    {
        public Base.ResourceReference? MedicationReference { get; set; }
        public required Base.CodeableConcept TherapyRelationshipType { get; set; }
        public Base.CodeableConcept? MedicationCodeableConcept { get; set; }
    }
}