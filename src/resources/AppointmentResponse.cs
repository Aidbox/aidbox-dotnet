using Aidbox.FHIR.Base;
using Aidbox.FHIR.Utils;

namespace Aidbox.FHIR.Resource;

public class AppointmentResponse : DomainResource, IResource
{
    public string? End { get; set; }
    public Base.ResourceReference? Actor { get; set; }
    public string? Start { get; set; }
    public string? Comment { get; set; }
    public Base.Identifier[]? Identifier { get; set; }
    public required Base.ResourceReference Appointment { get; set; }
    public Base.CodeableConcept[]? ParticipantType { get; set; }
    public required string ParticipantStatus { get; set; }
}