using Aidbox.FHIR.Base;
using Aidbox.FHIR.Utils;

namespace Aidbox.FHIR.Resource;

public class PractitionerRole : DomainResource, IResource
{
    public PractitionerRole_AvailableTime[]? AvailableTime { get; set; }
    public Base.CodeableConcept[]? Specialty { get; set; }
    public PractitionerRole_NotAvailable[]? NotAvailable { get; set; }
    public Base.ResourceReference? Organization { get; set; }
    public bool? Active { get; set; }
    public Base.CodeableConcept[]? Code { get; set; }
    public Base.Identifier[]? Identifier { get; set; }
    public string? AvailabilityExceptions { get; set; }
    public Base.ResourceReference? Practitioner { get; set; }
    public Base.ContactPoint[]? Telecom { get; set; }
    public Base.Period? Period { get; set; }
    public Base.ResourceReference[]? Location { get; set; }
    public Base.ResourceReference[]? Endpoint { get; set; }
    public Base.ResourceReference[]? HealthcareService { get; set; }

    public class PractitionerRole_AvailableTime : BackboneElement
    {
        public bool? AllDay { get; set; }
        public string[]? DaysOfWeek { get; set; }
        public string? AvailableEndTime { get; set; }
        public string? AvailableStartTime { get; set; }
    }

    public class PractitionerRole_NotAvailable : BackboneElement
    {
        public Base.Period? During { get; set; }
        public required string Description { get; set; }
    }
}