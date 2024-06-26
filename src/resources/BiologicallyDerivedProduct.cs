using Aidbox.FHIR.Base;
using Aidbox.FHIR.Utils;

namespace Aidbox.FHIR.Resource;

public class BiologicallyDerivedProduct : DomainResource, IResource
{
    public Base.ResourceReference[]? Request { get; set; }
    public BiologicallyDerivedProduct_Processing[]? Processing { get; set; }
    public Base.ResourceReference[]? Parent { get; set; }
    public string? Status { get; set; }
    public Base.Identifier[]? Identifier { get; set; }
    public Base.CodeableConcept? ProductCode { get; set; }
    public BiologicallyDerivedProduct_Storage[]? Storage { get; set; }
    public int? Quantity { get; set; }
    public string? ProductCategory { get; set; }
    public BiologicallyDerivedProduct_Manipulation? Manipulation { get; set; }
    public BiologicallyDerivedProduct_Collection? Collection { get; set; }

    public class BiologicallyDerivedProduct_Processing : BackboneElement
    {
        public Base.ResourceReference? Additive { get; set; }
        public Base.CodeableConcept? Procedure { get; set; }
        public Base.Period? TimePeriod { get; set; }
        public string? Description { get; set; }
        public string? TimeDateTime { get; set; }
    }

    public class BiologicallyDerivedProduct_Storage : BackboneElement
    {
        public string? Scale { get; set; }
        public Base.Period? Duration { get; set; }
        public string? Description { get; set; }
        public string? Temperature { get; set; }
    }

    public class BiologicallyDerivedProduct_Manipulation : BackboneElement
    {
        public Base.Period? TimePeriod { get; set; }
        public string? Description { get; set; }
        public string? TimeDateTime { get; set; }
    }

    public class BiologicallyDerivedProduct_Collection : BackboneElement
    {
        public Base.ResourceReference? Source { get; set; }
        public Base.ResourceReference? Collector { get; set; }
        public Base.Period? CollectedPeriod { get; set; }
        public string? CollectedDateTime { get; set; }
    }
}