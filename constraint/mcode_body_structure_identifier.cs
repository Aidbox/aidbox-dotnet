using Aidbox.FHIR.Base;
using Utils;

namespace Aidbox.FHIR.Constraint;

public class McodeBodyStructureIdentifier : IResource
{
	public Meta Meta { get; set; } = new() { Profile = ["http://hl7.org/fhir/us/mcode/StructureDefinition/mcode-body-structure-identifier"] };
	public string? Use { get; set; }
	public Base.CodeableConcept? Type { get; set; }
	public string? System { get; set; }
	public required string Value { get; set; }
	public Base.Period? Period { get; set; }
	public Base.ResourceReference? Assigner { get; set; }
	public string? Id { get; set; }
	public Base.Extension[]? Extension { get; set; }
}