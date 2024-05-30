using Aidbox.FHIR.Base;
using Aidbox.FHIR.Utils;

namespace Aidbox.FHIR.Constraint;

public class Groupdefinition : DomainResource
{
    public new Meta Meta { get; } = new() { Profile = ["http://hl7.org/fhir/StructureDefinition/groupdefinition"] };
    public string? Name { get; set; }
    public required string Type { get; set; }
    public Group_Characteristic[]? Characteristic { get; set; }
    public bool? Active { get; set; }
    public Base.CodeableConcept? Code { get; set; }
    public Base.Identifier[]? Identifier { get; set; }
    public uint? Quantity { get; set; }
    public Base.ResourceReference? ManagingEntity { get; set; }
    public required bool Actual { get; set; }

    public class Group_Member : BackboneElement
    {
        public required Base.ResourceReference Entity { get; set; }
        public Base.Period? Period { get; set; }
        public bool? Inactive { get; set; }
    }

    public class Group_Characteristic : BackboneElement
    {
        public required bool Exclude { get; set; }
        public Base.ResourceReference? ValueReference { get; set; }
        public Base.Quantity? ValueQuantity { get; set; }
        public bool? ValueBoolean { get; set; }
        public required Base.CodeableConcept Code { get; set; }
        public Base.CodeableConcept? ValueCodeableConcept { get; set; }
        public Base.Period? Period { get; set; }
        public Base.Range? ValueRange { get; set; }
    }
}