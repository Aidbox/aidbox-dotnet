using Aidbox.FHIR.Base;
using Aidbox.FHIR.Utils;

namespace Aidbox.FHIR.Resource;

public class Location : DomainResource, IResource
{
    public string? Description { get; set; }
    public Base.Address? Address { get; set; }
    public Base.ResourceReference? ManagingOrganization { get; set; }
    public string? Name { get; set; }
    public string? Mode { get; set; }
    public Base.CodeableConcept[]? Type { get; set; }
    public string[]? Alias { get; set; }
    public string? Status { get; set; }
    public Base.Identifier[]? Identifier { get; set; }
    public Location_HoursOfOperation[]? HoursOfOperation { get; set; }
    public string? AvailabilityExceptions { get; set; }
    public Location_Position? Position { get; set; }
    public Base.ContactPoint[]? Telecom { get; set; }
    public Base.Coding? OperationalStatus { get; set; }
    public Base.ResourceReference? PartOf { get; set; }
    public Base.CodeableConcept? PhysicalType { get; set; }
    public Base.ResourceReference[]? Endpoint { get; set; }

    public class Location_HoursOfOperation : BackboneElement
    {
        public bool? AllDay { get; set; }
        public string[]? DaysOfWeek { get; set; }
        public string? ClosingTime { get; set; }
        public string? OpeningTime { get; set; }
    }

    public class Location_Position : BackboneElement
    {
        public string? Altitude { get; set; }
        public required string Latitude { get; set; }
        public required string Longitude { get; set; }
    }
}