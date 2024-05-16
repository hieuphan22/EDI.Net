using Edi.Domain.Shared.Enums;
using indice.Edi.Serialization;
using Scm.Edi.Domain.Shared.Attributes;

namespace Edi.Application.Contracts.Poco.X12_4010.Segments
{
    [EdiSegment]
    [EdiPath("GF")]
    public class GF
    {
        [EdiValue("X(3)", Path = "GF/0", Format ="N0", Description = "GF01 - Reference Identification Qualifier")]
        [EdiExtension(MinLength = 2, MaxLength = 3, Mandatory = false, EdiType = EdiType.Identifier)]
        public string ReferenceIdentificationQualifier { get; set; }

        [EdiValue("X(30)", Path = "GF/1", Description = "GF02 - Reference Identification")]
        [EdiExtension(MinLength = 1, MaxLength = 30, Mandatory = false, EdiType = EdiType.Alphanumeric)]
        public string ReferenceIdentification { get; set; }

        [EdiValue("X(30)", Path = "GF/2", Description = "GF03 - Contract Number")]
        [EdiExtension(MinLength = 1, MaxLength = 30, Mandatory = false, EdiType = EdiType.Alphanumeric)]
        public string ContractNumber { get; set; }

        [EdiValue("9(18)", Format = "R", Path = "GF/3", Description = "GF04 - Monetary Amount")]
        [EdiExtension(MinLength = 1, MaxLength = 18, Mandatory = false, EdiType = EdiType.Decimal)]
        public string MonetaryAmount { get; set; }

        [EdiValue("X(3)", Path = "GF/4", Description = "GF05 - Reference Identification Qualifier")]
        [EdiExtension(MinLength = 2, MaxLength = 3, Mandatory = false, EdiType = EdiType.Identifier)]
        public string ReferenceIdentificationQualifier02 { get; set; }

        [EdiValue("X(30)", Path = "GF/5", Description = "GF06 - Reference Identification")]
        [EdiExtension(MinLength = 1, MaxLength = 30, Mandatory = false, EdiType = EdiType.Alphanumeric)]
        public string ReferenceIdentification02 { get; set; }

        [EdiValue("X(30)", Path = "GF/6", Description = "GF07 - Release Number")]
        [EdiExtension(MinLength = 1, MaxLength = 30, Mandatory = false, EdiType = EdiType.Alphanumeric)]
        public string ReleaseNumber { get; set; }

        [EdiValue("X(3)", Path = "GF/7", Description = "GF08 - Reference Identification Qualifier")]
        [EdiExtension(MinLength = 2, MaxLength = 3, Mandatory = false, EdiType = EdiType.Identifier)]
        public string ReferenceIdentificationQualifier03 { get; set; }

        [EdiValue("X(30)", Path = "GF/8", Description = "GF09 - Reference Identification")]
        [EdiExtension(MinLength = 1, MaxLength = 30, Mandatory = false, EdiType = EdiType.Alphanumeric)]
        public string ReferenceIdentification03 { get; set; }
    }
}