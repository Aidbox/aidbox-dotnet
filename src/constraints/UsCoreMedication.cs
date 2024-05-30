using Aidbox.FHIR.Base;
using Aidbox.FHIR.Utils;

namespace Aidbox.FHIR.Constraint;

public class UsCoreMedication : DomainResource
{
    public new Meta Meta { get; } = new() { Profile = ["http://hl7.org/fhir/us/core/StructureDefinition/us-core-medication"] };
    public required Base.CodeableConcept Code { get; set; }
    public Base.CodeableConcept? Form { get; set; }
    public Medication_Batch? Batch { get; set; }
    public Base.Ratio? Amount { get; set; }
    public string? Status { get; set; }
    public Base.Identifier[]? Identifier { get; set; }
    public Medication_Ingredient[]? Ingredient { get; set; }
    public Base.ResourceReference? Manufacturer { get; set; }

    public class Medication_Batch : BackboneElement
    {
        public string? LotNumber { get; set; }
        public string? ExpirationDate { get; set; }
    }

    public class Medication_Ingredient : BackboneElement
    {
        public bool? IsActive { get; set; }
        public Base.Ratio? Strength { get; set; }
        public Base.ResourceReference? ItemReference { get; set; }
        public Base.CodeableConcept? ItemCodeableConcept { get; set; }
    }
}