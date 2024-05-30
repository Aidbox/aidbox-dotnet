using Aidbox.FHIR.Base;
using Aidbox.FHIR.Utils;

namespace Aidbox.FHIR.Resource;

public class MedicinalProductIngredient : DomainResource, IResource
{
    public required Base.CodeableConcept Role { get; set; }
    public MedicinalProductIngredient_Substance? Substance { get; set; }
    public Base.Identifier? Identifier { get; set; }
    public Base.ResourceReference[]? Manufacturer { get; set; }
    public MedicinalProductIngredient_SpecifiedSubstance[]? SpecifiedSubstance { get; set; }
    public bool? AllergenicIndicator { get; set; }

    public class MedicinalProductIngredient_Substance_Strength_ReferenceStrength : BackboneElement
    {
        public Base.CodeableConcept[]? Country { get; set; }
        public required Base.Ratio Strength { get; set; }
        public Base.CodeableConcept? Substance { get; set; }
        public string? MeasurementPoint { get; set; }
        public Base.Ratio? StrengthLowLimit { get; set; }
    }

    public class MedicinalProductIngredient_Substance_Strength : BackboneElement
    {
        public Base.CodeableConcept[]? Country { get; set; }
        public required Base.Ratio Presentation { get; set; }
        public Base.Ratio? Concentration { get; set; }
        public string? MeasurementPoint { get; set; }
        public MedicinalProductIngredient_Substance_Strength_ReferenceStrength[]? ReferenceStrength { get; set; }
        public Base.Ratio? PresentationLowLimit { get; set; }
        public Base.Ratio? ConcentrationLowLimit { get; set; }
    }

    public class MedicinalProductIngredient_Substance : BackboneElement
    {
        public required Base.CodeableConcept Code { get; set; }
        public MedicinalProductIngredient_Substance_Strength[]? Strength { get; set; }
    }

    public class MedicinalProductIngredient_SpecifiedSubstance_Strength_ReferenceStrength : BackboneElement
    {
        public Base.CodeableConcept[]? Country { get; set; }
        public required Base.Ratio Strength { get; set; }
        public Base.CodeableConcept? Substance { get; set; }
        public string? MeasurementPoint { get; set; }
        public Base.Ratio? StrengthLowLimit { get; set; }
    }

    public class MedicinalProductIngredient_SpecifiedSubstance_Strength : BackboneElement
    {
        public Base.CodeableConcept[]? Country { get; set; }
        public required Base.Ratio Presentation { get; set; }
        public Base.Ratio? Concentration { get; set; }
        public string? MeasurementPoint { get; set; }
        public MedicinalProductIngredient_SpecifiedSubstance_Strength_ReferenceStrength[]? ReferenceStrength { get; set; }
        public Base.Ratio? PresentationLowLimit { get; set; }
        public Base.Ratio? ConcentrationLowLimit { get; set; }
    }

    public class MedicinalProductIngredient_SpecifiedSubstance : BackboneElement
    {
        public required Base.CodeableConcept Code { get; set; }
        public required Base.CodeableConcept Group { get; set; }
        public MedicinalProductIngredient_SpecifiedSubstance_Strength[]? Strength { get; set; }
        public Base.CodeableConcept? Confidentiality { get; set; }
    }
}