using Aidbox.FHIR.Base;
using Aidbox.FHIR.Utils;

namespace Aidbox.FHIR.Resource;

public class Subscription : DomainResource, IResource
{
    public string? End { get; set; }
    public string? Error { get; set; }
    public required string Reason { get; set; }
    public required string Status { get; set; }
    public required Subscription_Channel Channel { get; set; }
    public Base.ContactPoint[]? Contact { get; set; }
    public required string Criteria { get; set; }

    public class Subscription_Channel : BackboneElement
    {
        public required string Type { get; set; }
        public string[]? Header { get; set; }
        public string? Payload { get; set; }
        public string? Endpoint { get; set; }
    }
}