using Aidbox.FHIR.Base;
using Aidbox.FHIR.Utils;

namespace Aidbox.FHIR.Constraint;

public class SimpleQuantity : Element
{
    public new Meta Meta { get; } = new() { Profile = ["http://hl7.org/fhir/StructureDefinition/SimpleQuantity"] };
    public string? Code { get; set; }
    public string? Unit { get; set; }
    public string? Value { get; set; }
    public string? System { get; set; }
}