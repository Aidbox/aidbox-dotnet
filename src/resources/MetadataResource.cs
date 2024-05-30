using Aidbox.FHIR.Base;
using Aidbox.FHIR.Utils;

namespace Aidbox.FHIR.Resource;

public class MetadataResource : DomainResource, IResource
{
    public string? Description { get; set; }
    public string? Date { get; set; }
    public string? Publisher { get; set; }
    public Base.CodeableConcept[]? Jurisdiction { get; set; }
    public string? Name { get; set; }
    public Base.UsageContext[]? UseContext { get; set; }
    public bool? Experimental { get; set; }
    public string? Title { get; set; }
    public required string Status { get; set; }
    public string? Url { get; set; }
    public string? Version { get; set; }
    public Base.ContactDetail[]? Contact { get; set; }
}