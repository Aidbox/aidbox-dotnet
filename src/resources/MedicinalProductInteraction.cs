using Aidbox.FHIR.Base;
using Aidbox.FHIR.Utils;

namespace Aidbox.FHIR.Resource;

public class MedicinalProductInteraction : DomainResource, IResource
{
    public Base.CodeableConcept? Type { get; set; }
    public Base.CodeableConcept? Effect { get; set; }
    public Base.ResourceReference[]? Subject { get; set; }
    public Base.CodeableConcept? Incidence { get; set; }
    public Base.CodeableConcept? Management { get; set; }
    public string? Description { get; set; }
    public MedicinalProductInteraction_Interactant[]? Interactant { get; set; }

    public class MedicinalProductInteraction_Interactant : BackboneElement
    {
        public Base.ResourceReference? ItemReference { get; set; }
        public Base.CodeableConcept? ItemCodeableConcept { get; set; }
    }
}