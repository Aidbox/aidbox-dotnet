using Aidbox.FHIR.Base;
using Aidbox.FHIR.Utils;

namespace Aidbox.FHIR.Constraint;

public class McodeBodyStructureIdentifier : Element
{
    public new Meta Meta { get; } = new() { Profile = ["http://hl7.org/fhir/us/mcode/StructureDefinition/mcode-body-structure-identifier"] };
    public string? Use { get; set; }
    public Base.CodeableConcept? Type { get; set; }
    public required string Value { get; set; }
    public Base.Period? Period { get; set; }
    public string? System { get; set; }
    public Base.ResourceReference? Assigner { get; set; }
}