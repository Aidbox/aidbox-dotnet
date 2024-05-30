using Aidbox.FHIR.Base;
using Aidbox.FHIR.Utils;

namespace Aidbox.FHIR.Resource;

public class Linkage : DomainResource, IResource
{
    public required Linkage_Item[] Item { get; set; }
    public bool? Active { get; set; }
    public Base.ResourceReference? Author { get; set; }

    public class Linkage_Item : BackboneElement
    {
        public required string Type { get; set; }
        public required Base.ResourceReference Resource { get; set; }
    }
}