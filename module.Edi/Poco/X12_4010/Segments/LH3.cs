using Edi.Domain.Shared.Enums;
using indice.Edi.Serialization;
using Scm.Edi.Domain.Shared.Attributes;

namespace Edi.Application.Contracts.Poco.X12_4010.Segments
{
    [EdiSegment]
    [EdiPath("LH3")]
    public class LH3
    {
        [EdiValue("X(25)", Path = "LH3/0", Description = "LH301 - Hazardous Material Shipping Name")]
        [EdiExtension(MinLength = 1, MaxLength = 25, EdiType = EdiType.Alphanumeric)]
        public string HazardousMaterialShippingName { get; set; }

        [EdiValue("X(1)", Path = "LH3/1", Description = "LH302 - Hazardous Material Shipping Name Qualifier")]
        [EdiExtension(MinLength = 1, MaxLength = 1, EdiType = EdiType.Identifier)]
        public string HazardousMaterialShippingNameQualifier { get; set; }

        [EdiValue("X(3)", Path = "LH3/2", Description = "LH303 - N.O.S. Indicator Code")]
        [EdiExtension(MinLength = 3, MaxLength = 3, Mandatory = false, EdiType = EdiType.Identifier)]
        public string NOSIndicatorCode { get; set; }

        [EdiValue("X(1)", Path = "LH3/3", Description = "LH304 - Yes/No Condition or Response Code")]
        [EdiExtension(MinLength = 1, MaxLength = 1, Mandatory = false, EdiType = EdiType.Identifier)]
        public string YesOrNoConditionOrResponseCode { get; set; }
    }
}
