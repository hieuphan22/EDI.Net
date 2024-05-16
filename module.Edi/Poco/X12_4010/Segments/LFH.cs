using Edi.Domain.Shared.Enums;
using indice.Edi.Serialization;
using Scm.Edi.Domain.Shared.Attributes;

namespace Edi.Application.Contracts.Poco.X12_4010.Segments
{
    [EdiSegment]
    [EdiPath("LFH")]
    public class LFH
    {
        [EdiValue("X(3)", Path = "LFH/0", Description = "LFH01 - Hazardous Material Shipment Information Qualifier")]
        [EdiExtension(MinLength = 3, MaxLength = 3, Mandatory = true, EdiType = EdiType.Identifier)]
        public string HazardousMaterialShipmentInformationQualifier { get; set; }

        [EdiValue("X(25)", Path = "LFH/1", Description = "LFH02 - Hazardous Material Shipment Information")]
        [EdiExtension(MinLength = 1, MaxLength = 25, Mandatory = true, EdiType = EdiType.Alphanumeric)]
        public string HazardousMaterialShipmentInformation { get; set; }

        [EdiValue("X(25)", Path = "LFH/2", Description = "LFH03 - Hazardous Material Shipment Information")]
        [EdiExtension(MinLength = 1, MaxLength = 25, Mandatory = false, EdiType = EdiType.Alphanumeric)]
        public string HazardousMaterialShipmentInformation02 { get; set; }

        [EdiValue("X(1)", Path = "LFH/3", Description = "LFH04 - Hazard Zone Code")]
        [EdiExtension(MinLength = 1, MaxLength = 1, Mandatory = false, EdiType = EdiType.Identifier)]
        public string HazardZoneCode { get; set; }

        [EdiValue("X(2)", Path = "LFH/4", Description = "LFH05 - Unit or Basis for Measurement Code")]
        [EdiExtension(MinLength = 2, MaxLength = 2, EdiType = EdiType.Identifier)]
        public string UnitOrBasisForMeasurementCode { get; set; }

        [EdiValue("X(15)", Path = "LFH/5", Description = "LFH06 - Quantity")]
        [EdiExtension(MinLength = 1, MaxLength = 15, EdiType = EdiType.Decimal)]
        public string Quantity { get; set; }

        [EdiValue("X(15)", Path = "LFH/6", Description = "LFH07 - Quantity")]
        [EdiExtension(MinLength = 1, MaxLength = 15, Mandatory = false, EdiType = EdiType.Decimal)]
        public string Quantity02 { get; set; }
    }
}
