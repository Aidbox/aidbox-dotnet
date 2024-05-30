using Aidbox.FHIR.Base;
using Aidbox.FHIR.Utils;

namespace Aidbox.FHIR.Resource;

public class DeviceUseStatement : DomainResource, IResource
{
    public Base.ResourceReference[]? DerivedFrom { get; set; }
    public Base.Period? TimingPeriod { get; set; }
    public Base.CodeableConcept[]? ReasonCode { get; set; }
    public Base.ResourceReference? Source { get; set; }
    public Base.Annotation[]? Note { get; set; }
    public string? TimingDateTime { get; set; }
    public string? TimingTiming { get; set; }
    public required string Status { get; set; }
    public string? RecordedOn { get; set; }
    public Base.Identifier[]? Identifier { get; set; }
    public Base.CodeableConcept? BodySite { get; set; }
    public required Base.ResourceReference Device { get; set; }
    public Base.ResourceReference[]? BasedOn { get; set; }
    public required Base.ResourceReference Subject { get; set; }
    public Base.ResourceReference[]? ReasonReference { get; set; }
}