using Aidbox.FHIR.Base;
using Aidbox.FHIR.Utils;

namespace Aidbox.FHIR.Resource;

public class OperationOutcome : DomainResource, IResource
{
    public required OperationOutcome_Issue[] Issue { get; set; }

    public class OperationOutcome_Issue : BackboneElement
    {
        public required string Code { get; set; }
        public Base.CodeableConcept? Details { get; set; }
        public string[]? Location { get; set; }
        public required string Severity { get; set; }
        public string[]? Expression { get; set; }
        public string? Diagnostics { get; set; }
    }
}