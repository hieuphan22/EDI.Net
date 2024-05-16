using Edi.Domain.Shared.Enums;
using indice.Edi.Serialization;
using Scm.Edi.Domain.Shared.Attributes;

namespace Edi.Application.Contracts.Poco.X12_4010.Segments
{
    [EdiSegment]
    [EdiPath("V1")]
    public class V1
    {
        [EdiValue("X(8)", Path = "V1/0", Description = "V101 - Vessel Code")]
        [EdiExtension(MinLength = 1, MaxLength = 8, Mandatory = false, EdiType = EdiType.Identifier)]
        public string VesselCode { get; set; }

        [EdiValue("X(28)", Path = "V1/1", Description = "V102 - Vessel Name")]
        [EdiExtension(MinLength = 2, MaxLength = 28, Mandatory = false, EdiType = EdiType.Alphanumeric)]
        public string VesselName { get; set; }

        [EdiValue("X(3)", Path = "V1/2", Description = "V103 - Country Code")]
        [EdiExtension(MinLength = 2, MaxLength = 3, Mandatory = false, EdiType = EdiType.Identifier)]
        public string CountryCode { get; set; }

        [EdiValue("X(28)", Path = "V1/3", Description = "V104 - Flight/Voyage Number")]
        [EdiExtension(MinLength = 2, MaxLength = 10, Mandatory = false, EdiType = EdiType.Alphanumeric)]
        public string FlightVoyageNumber { get; set; }

        [EdiValue("X(3)", Path = "V1/4", Description = "V105 - Standard Carrier Alpha Code")]
        [EdiExtension(MinLength = 2, MaxLength = 4, Mandatory = false, EdiType = EdiType.Identifier)]
        public string StandardCarrierAlphaCode { get; set; }

        [EdiValue("X(1)", Path = "V1/5", Description = "V106 - Vessel Requirement Code")]
        [EdiExtension(MinLength = 1, MaxLength = 1, Mandatory = false, EdiType = EdiType.Identifier)]
        public string VesselRequirementCode { get; set; }

        [EdiValue("X(2)", Path = "V1/6", Description = "V107 - Vessel Type Code")]
        [EdiExtension(MinLength = 2, MaxLength = 2, Mandatory = false, EdiType = EdiType.Identifier)]
        public string VesselTypeCode { get; set; }

        [EdiValue("X(1)", Path = "V1/7", Description = "V108 - Vessel Code Qualifier")]
        [EdiExtension(MinLength = 1, MaxLength = 1, Mandatory = false, EdiType = EdiType.Identifier)]
        public string VesselCodeQualifier { get; set; }

        [EdiValue("X(2)", Path = "V1/8", Description = "V109 - Transportation Method/Type Code")]
        [EdiExtension(MinLength = 1, MaxLength = 2, Mandatory = false, EdiType = EdiType.Identifier)]
        public string TransportationMethodTypeCode { get; set; }
    }
}
