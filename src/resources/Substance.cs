using Aidbox.FHIR.Base;
using Aidbox.FHIR.Utils;

namespace Aidbox.FHIR.Resource;

public class Substance : DomainResource, IResource
{
    public required Base.CodeableConcept Code { get; set; }
    public string? Status { get; set; }
    public Base.CodeableConcept[]? Category { get; set; }
    public Substance_Instance[]? Instance { get; set; }
    public Base.Identifier[]? Identifier { get; set; }
    public Substance_Ingredient[]? Ingredient { get; set; }
    public string? Description { get; set; }

    public class Substance_Instance : BackboneElement
    {
        public string? Expiry { get; set; }
        public Base.Quantity? Quantity { get; set; }
        public Base.Identifier? Identifier { get; set; }
    }

    public class Substance_Ingredient : BackboneElement
    {
        public Base.Ratio? Quantity { get; set; }
        public Base.ResourceReference? SubstanceReference { get; set; }
        public Base.CodeableConcept? SubstanceCodeableConcept { get; set; }
    }
}