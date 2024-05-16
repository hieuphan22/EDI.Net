using Edi.Domain.Shared.Attributes;
using Edi.Domain.Shared.Enums;
using indice.Edi.Serialization;
using Scm.Edi.Domain.Shared.Attributes;

namespace Edi.Domain.Shared.Poco.X12_4010.Segments
{
    [EdiSegment]
    [EdiPath("LHE")]
    public class LHE
    {
        [EdiValue("X(25)", Path = "LHE/0", Format = "N0", Description = "LHE01 - Hazardous Material Shipping Name")]
        [EdiExtension(MinLength = 1, MaxLength = 25, Mandatory = true, EdiType = EdiType.Alphanumeric)]
        public string HazardousMaterialShippingName { get; set; }

        [EdiValue("X(40)", Path = "LHE/1", Description = "LHE02 - Hazardous Placard Notation")]
        [EdiExtension(MinLength = 14, MaxLength = 40, Mandatory = true, EdiType = EdiType.Identifier)]
        public string HazardousPlacardNotation { get; set; }

        [EdiValue("X(3)", Path = "LHE/2", Description = "LHE03 - Reference Identification Qualifier")]
        [EdiExtension(MinLength = 2, MaxLength = 3, Mandatory = true, EdiType = EdiType.Identifier)]
        public string ReferenceIdentificationQualifier { get; set; }

        [EdiValue("X(30)", Path = "LHE/3", Description = "LHE04 - Reference Identification")]
        [EdiExtension(MinLength = 1, MaxLength = 30, Mandatory = true, EdiType = EdiType.Alphanumeric)]
        public string ReferenceIdentification { get; set; }

        [EdiValue("X(2)", Path = "LHE/4", Description = "LHE05 - Reportable Quantity Code")]
        [EdiExtension(MinLength = 2, MaxLength = 2, Mandatory = false, EdiType = EdiType.Identifier)]
        public string ReportableQuantityCode { get; set; }
    }
}