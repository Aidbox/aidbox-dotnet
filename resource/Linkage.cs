using Aidbox.FHIR.Base;
using Utils;

namespace Aidbox.FHIR.Resource;

public class Linkage_Item : BackboneElement
{
	public required string Type { get; set; }
	public required Base.ResourceReference Resource { get; set; }
}

public class Linkage : DomainResource, IResource
{
	public bool? Active { get; set; }
	public Base.ResourceReference? Author { get; set; }
	public required Linkage_Item[] Item { get; set; }
}