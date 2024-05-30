using Aidbox.FHIR.Base;
using Aidbox.FHIR.Utils;

namespace Aidbox.FHIR.Resource;

public class MessageDefinition : DomainResource, IResource
{
    public string? Description { get; set; }
    public string? Category { get; set; }
    public required string Date { get; set; }
    public string? Publisher { get; set; }
    public string[]? Parent { get; set; }
    public Base.CodeableConcept[]? Jurisdiction { get; set; }
    public string? Purpose { get; set; }
    public string? Name { get; set; }
    public Base.UsageContext[]? UseContext { get; set; }
    public string? Copyright { get; set; }
    public bool? Experimental { get; set; }
    public string? Title { get; set; }
    public required string Status { get; set; }
    public MessageDefinition_AllowedResponse[]? AllowedResponse { get; set; }
    public string[]? Graph { get; set; }
    public string? Url { get; set; }
    public Base.Identifier[]? Identifier { get; set; }
    public MessageDefinition_Focus[]? Focus { get; set; }
    public string[]? Replaces { get; set; }
    public string? ResponseRequired { get; set; }
    public string? Base { get; set; }
    public string? Version { get; set; }
    public Base.ContactDetail[]? Contact { get; set; }
    public string? EventUri { get; set; }
    public Base.Coding? EventCoding { get; set; }

    public class MessageDefinition_AllowedResponse : BackboneElement
    {
        public required string Message { get; set; }
        public string? Situation { get; set; }
    }

    public class MessageDefinition_Focus : BackboneElement
    {
        public string? Max { get; set; }
        public required uint Min { get; set; }
        public required string Code { get; set; }
        public string? Profile { get; set; }
    }
}