using Aidbox.FHIR.Base;
using Aidbox.FHIR.Utils;

namespace Aidbox.FHIR.Resource;

public class EpisodeOfCare : DomainResource, IResource
{
    public required Base.ResourceReference Patient { get; set; }
    public EpisodeOfCare_Diagnosis[]? Diagnosis { get; set; }
    public Base.ResourceReference? ManagingOrganization { get; set; }
    public Base.CodeableConcept[]? Type { get; set; }
    public Base.ResourceReference[]? Account { get; set; }
    public Base.ResourceReference[]? ReferralRequest { get; set; }
    public Base.ResourceReference[]? Team { get; set; }
    public required string Status { get; set; }
    public Base.Identifier[]? Identifier { get; set; }
    public Base.Period? Period { get; set; }
    public Base.ResourceReference? CareManager { get; set; }
    public EpisodeOfCare_StatusHistory[]? StatusHistory { get; set; }

    public class EpisodeOfCare_Diagnosis : BackboneElement
    {
        public string? Rank { get; set; }
        public Base.CodeableConcept? Role { get; set; }
        public required Base.ResourceReference Condition { get; set; }
    }

    public class EpisodeOfCare_StatusHistory : BackboneElement
    {
        public required Base.Period Period { get; set; }
        public required string Status { get; set; }
    }
}