using Aidbox.FHIR.Base;
using Aidbox.FHIR.Utils;

namespace Aidbox.FHIR.Resource;

public class SupplyDelivery : DomainResource, IResource
{
    public Base.ResourceReference? Patient { get; set; }
    public Base.ResourceReference? Supplier { get; set; }
    public SupplyDelivery_SuppliedItem? SuppliedItem { get; set; }
    public Base.CodeableConcept? Type { get; set; }
    public string? OccurrenceTiming { get; set; }
    public Base.Period? OccurrencePeriod { get; set; }
    public string? Status { get; set; }
    public Base.Identifier[]? Identifier { get; set; }
    public Base.ResourceReference[]? BasedOn { get; set; }
    public Base.ResourceReference[]? PartOf { get; set; }
    public string? OccurrenceDateTime { get; set; }
    public Base.ResourceReference[]? Receiver { get; set; }
    public Base.ResourceReference? Destination { get; set; }

    public class SupplyDelivery_SuppliedItem : BackboneElement
    {
        public Base.Quantity? Quantity { get; set; }
        public Base.ResourceReference? ItemReference { get; set; }
        public Base.CodeableConcept? ItemCodeableConcept { get; set; }
    }
}