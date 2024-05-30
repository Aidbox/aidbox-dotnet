using Aidbox.FHIR.Base;
using Aidbox.FHIR.Utils;

namespace Aidbox.FHIR.Resource;

public class MessageHeader : DomainResource, IResource
{
    public MessageHeader_Response? Response { get; set; }
    public string? Definition { get; set; }
    public Base.ResourceReference? Enterer { get; set; }
    public required MessageHeader_Source Source { get; set; }
    public Base.ResourceReference? Author { get; set; }
    public Base.CodeableConcept? Reason { get; set; }
    public Base.ResourceReference? Responsible { get; set; }
    public Base.ResourceReference? Sender { get; set; }
    public Base.ResourceReference[]? Focus { get; set; }
    public string? EventUri { get; set; }
    public MessageHeader_Destination[]? Destination { get; set; }
    public Base.Coding? EventCoding { get; set; }

    public class MessageHeader_Response : BackboneElement
    {
        public required string Code { get; set; }
        public Base.ResourceReference? Details { get; set; }
        public required string Identifier { get; set; }
    }

    public class MessageHeader_Source : BackboneElement
    {
        public string? Name { get; set; }
        public Base.ContactPoint? Contact { get; set; }
        public string? Version { get; set; }
        public required string Endpoint { get; set; }
        public string? Software { get; set; }
    }

    public class MessageHeader_Destination : BackboneElement
    {
        public string? Name { get; set; }
        public Base.ResourceReference? Target { get; set; }
        public required string Endpoint { get; set; }
        public Base.ResourceReference? Receiver { get; set; }
    }
}