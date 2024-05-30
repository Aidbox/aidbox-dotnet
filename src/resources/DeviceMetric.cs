using Aidbox.FHIR.Base;
using Aidbox.FHIR.Utils;

namespace Aidbox.FHIR.Resource;

public class DeviceMetric : DomainResource, IResource
{
    public required string Category { get; set; }
    public string? MeasurementPeriod { get; set; }
    public string? Color { get; set; }
    public Base.ResourceReference? Parent { get; set; }
    public Base.CodeableConcept? Unit { get; set; }
    public required Base.CodeableConcept Type { get; set; }
    public Base.ResourceReference? Source { get; set; }
    public Base.Identifier[]? Identifier { get; set; }
    public DeviceMetric_Calibration[]? Calibration { get; set; }
    public string? OperationalStatus { get; set; }

    public class DeviceMetric_Calibration : BackboneElement
    {
        public string? Time { get; set; }
        public string? Type { get; set; }
        public string? State { get; set; }
    }
}