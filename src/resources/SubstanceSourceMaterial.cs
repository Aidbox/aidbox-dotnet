using Aidbox.FHIR.Base;
using Aidbox.FHIR.Utils;

namespace Aidbox.FHIR.Resource;

public class SubstanceSourceMaterial : DomainResource, IResource
{
    public string[]? ParentSubstanceName { get; set; }
    public SubstanceSourceMaterial_Organism? Organism { get; set; }
    public SubstanceSourceMaterial_PartDescription[]? PartDescription { get; set; }
    public Base.CodeableConcept? DevelopmentStage { get; set; }
    public SubstanceSourceMaterial_FractionDescription[]? FractionDescription { get; set; }
    public Base.CodeableConcept? SourceMaterialState { get; set; }
    public Base.CodeableConcept[]? CountryOfOrigin { get; set; }
    public Base.CodeableConcept? SourceMaterialType { get; set; }
    public Base.Identifier? OrganismId { get; set; }
    public string? OrganismName { get; set; }
    public Base.Identifier[]? ParentSubstanceId { get; set; }
    public string[]? GeographicalLocation { get; set; }
    public Base.CodeableConcept? SourceMaterialClass { get; set; }

    public class SubstanceSourceMaterial_Organism_Author : BackboneElement
    {
        public Base.CodeableConcept? AuthorType { get; set; }
        public string? AuthorDescription { get; set; }
    }

    public class SubstanceSourceMaterial_Organism_Hybrid : BackboneElement
    {
        public Base.CodeableConcept? HybridType { get; set; }
        public string? MaternalOrganismId { get; set; }
        public string? PaternalOrganismId { get; set; }
        public string? MaternalOrganismName { get; set; }
        public string? PaternalOrganismName { get; set; }
    }

    public class SubstanceSourceMaterial_Organism_OrganismGeneral : BackboneElement
    {
        public Base.CodeableConcept? Class_ { get; set; }
        public Base.CodeableConcept? Order { get; set; }
        public Base.CodeableConcept? Phylum { get; set; }
        public Base.CodeableConcept? Kingdom { get; set; }
    }

    public class SubstanceSourceMaterial_Organism : BackboneElement
    {
        public Base.CodeableConcept? Genus { get; set; }
        public SubstanceSourceMaterial_Organism_Author[]? Author { get; set; }
        public Base.CodeableConcept? Family { get; set; }
        public SubstanceSourceMaterial_Organism_Hybrid? Hybrid { get; set; }
        public Base.CodeableConcept? Species { get; set; }
        public SubstanceSourceMaterial_Organism_OrganismGeneral? OrganismGeneral { get; set; }
        public Base.CodeableConcept? IntraspecificType { get; set; }
        public string? IntraspecificDescription { get; set; }
    }

    public class SubstanceSourceMaterial_PartDescription : BackboneElement
    {
        public Base.CodeableConcept? Part { get; set; }
        public Base.CodeableConcept? PartLocation { get; set; }
    }

    public class SubstanceSourceMaterial_FractionDescription : BackboneElement
    {
        public string? Fraction { get; set; }
        public Base.CodeableConcept? MaterialType { get; set; }
    }
}