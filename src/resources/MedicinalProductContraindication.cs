using Aidbox.FHIR.Base;
using Aidbox.FHIR.Utils;

namespace Aidbox.FHIR.Resource;

public class MedicinalProductContraindication : DomainResource, IResource
{
    public Base.CodeableConcept? Disease { get; set; }
    public Base.ResourceReference[]? Subject { get; set; }
    public Base.Population[]? Population { get; set; }
    public Base.CodeableConcept[]? Comorbidity { get; set; }
    public MedicinalProductContraindication_OtherTherapy[]? OtherTherapy { get; set; }
    public Base.CodeableConcept? DiseaseStatus { get; set; }
    public Base.ResourceReference[]? TherapeuticIndication { get; set; }

    public class MedicinalProductContraindication_OtherTherapy : BackboneElement
    {
        public Base.ResourceReference? MedicationReference { get; set; }
        public required Base.CodeableConcept TherapyRelationshipType { get; set; }
        public Base.CodeableConcept? MedicationCodeableConcept { get; set; }
    }
}