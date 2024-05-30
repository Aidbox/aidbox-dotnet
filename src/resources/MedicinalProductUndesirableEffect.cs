using Aidbox.FHIR.Base;
using Aidbox.FHIR.Utils;

namespace Aidbox.FHIR.Resource;

public class MedicinalProductUndesirableEffect : DomainResource, IResource
{
    public Base.ResourceReference[]? Subject { get; set; }
    public Base.Population[]? Population { get; set; }
    public Base.CodeableConcept? Classification { get; set; }
    public Base.CodeableConcept? FrequencyOfOccurrence { get; set; }
    public Base.CodeableConcept? SymptomConditionEffect { get; set; }
}