using Aidbox.FHIR.Base;
using Aidbox.FHIR.Utils;

namespace Aidbox.FHIR.Resource;

public class SubstanceProtein : DomainResource, IResource
{
    public SubstanceProtein_Subunit[]? Subunit { get; set; }
    public Base.CodeableConcept? SequenceType { get; set; }
    public string[]? DisulfideLinkage { get; set; }
    public int? NumberOfSubunits { get; set; }

    public class SubstanceProtein_Subunit : BackboneElement
    {
        public int? Length { get; set; }
        public int? Subunit { get; set; }
        public string? Sequence { get; set; }
        public Base.Attachment? SequenceAttachment { get; set; }
        public string? CTerminalModification { get; set; }
        public string? NTerminalModification { get; set; }
        public Base.Identifier? CTerminalModificationId { get; set; }
        public Base.Identifier? NTerminalModificationId { get; set; }
    }
}