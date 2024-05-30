using Aidbox.FHIR.Base;
using Aidbox.FHIR.Utils;

namespace Aidbox.FHIR.Resource;

public class Schedule : DomainResource, IResource
{
    public required Base.ResourceReference[] Actor { get; set; }
    public bool? Active { get; set; }
    public string? Comment { get; set; }
    public Base.CodeableConcept[]? Specialty { get; set; }
    public Base.Identifier[]? Identifier { get; set; }
    public Base.CodeableConcept[]? ServiceType { get; set; }
    public Base.Period? PlanningHorizon { get; set; }
    public Base.CodeableConcept[]? ServiceCategory { get; set; }
}