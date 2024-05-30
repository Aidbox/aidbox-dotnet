using Aidbox.FHIR.Base;
using Aidbox.FHIR.Utils;

namespace Aidbox.FHIR.Constraint;

public class McodePatientBundle<T> : Base.Resource
{
    public new Meta Meta { get; } = new() { Profile = ["http://hl7.org/fhir/us/mcode/StructureDefinition/mcode-patient-bundle"] };
    public Bundle_Link[]? Link { get; set; }
    public required string Type { get; set; }
    public required Bundle_Entry[] Entry { get; set; }
    public uint? Total { get; set; }
    public Base.Signature? Signature { get; set; }
    public string? Timestamp { get; set; }
    public Base.Identifier? Identifier { get; set; }

    public class Bundle_Link : BackboneElement
    {
        public required string Url { get; set; }
        public required string Relation { get; set; }
    }

    public class Bundle_Entry_Link : BackboneElement
    {
        public required string Url { get; set; }
        public required string Relation { get; set; }
    }

    public class Bundle_Entry_Search : BackboneElement
    {
        public string? Mode { get; set; }
        public string? Score { get; set; }
    }

    public class Bundle_Entry_Request : BackboneElement
    {
        public required string Url { get; set; }
        public required string Method { get; set; }
        public string? IfMatch { get; set; }
        public string? IfNoneExist { get; set; }
        public string? IfNoneMatch { get; set; }
        public string? IfModifiedSince { get; set; }
    }

    public class Bundle_Entry_Response : BackboneElement
    {
        public string? Etag { get; set; }
        public required string Status { get; set; }
        public Base.Resource? Outcome { get; set; }
        public string? Location { get; set; }
        public string? LastModified { get; set; }
    }

    public class Bundle_Entry : BackboneElement
    {
        public Bundle_Entry_Link[]? Link { get; set; }
        public Bundle_Entry_Search? Search { get; set; }
        public string? FullUrl { get; set; }
        public Bundle_Entry_Request? Request { get; set; }
        public T? Resource { get; set; }
        public Bundle_Entry_Response? Response { get; set; }
    }
}