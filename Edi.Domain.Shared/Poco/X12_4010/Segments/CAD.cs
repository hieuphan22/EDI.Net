using Edi.Domain.Shared.Attributes;
using Edi.Domain.Shared.Enums;
using indice.Edi.Serialization;
using Scm.Edi.Domain.Shared.Attributes;

namespace Edi.Domain.Shared.Poco.X12_4010.Segments
{
    [EdiSegment, EdiPath("CAD")]
    public class CAD
    {
        [EdiValue("X(2)", Path = "CAD/0", Description = "CAD01 - Transportation Method/Type Code")]
        [EdiExtension(MinLength = 1, MaxLength = 2, Mandatory = false, EdiType = EdiType.Identifier)]
        public string TransportationMethodTypeCode { get; set; }

        [EdiValue("X(4)", Path = "CAD/1", Description = "CAD02 - Equipment Initial")]
        [EdiExtension(MinLength = 1, MaxLength = 4, Mandatory = false, EdiType = EdiType.Alphanumeric)]
        public string EquipmentInitial { get; set; }

        [EdiValue("X(10)", Path = "CAD/2", Description = "CAD03 - Equipment Number")]
        [EdiExtension(MinLength = 1, MaxLength = 10, Mandatory = false, EdiType = EdiType.Alphanumeric)]
        public string EquipmentNumber { get; set; }

        [EdiValue("X(4)", Path = "CAD/3", Description = "CAD04 - Standard Carrier Alpha Code")]
        [EdiExtension(MinLength = 2, MaxLength = 4, Mandatory = false, EdiType = EdiType.Identifier)]
        public string StandardCarrierAlphaCode { get; set; }

        [EdiValue("X(35)", Path = "CAD/4", Description = "CAD05 - Routing")]
        [EdiExtension(MinLength = 1, MaxLength = 35, Mandatory = false, EdiType = EdiType.Alphanumeric)]
        public string Routing { get; set; }

        [EdiValue("X(2)", Path = "CAD/5", Description = "CAD06 - Shipment/Order Status Code")]
        [EdiExtension(MinLength = 2, MaxLength = 2, Mandatory = false, EdiType = EdiType.Identifier)]
        public string ShipmentOrderStatusCode { get; set; }

        [EdiValue("X(3)", Path = "CAD/6", Description = "CAD07 - Reference Identification Qualifier")]
        [EdiExtension(MinLength = 2, MaxLength = 3, Mandatory = false, EdiType = EdiType.Identifier)]
        public string ReferenceIdentificationQualifier { get; set; }

        [EdiValue("X(30)", Path = "CAD/7", Description = "CAD08 - Reference Identification")]
        [EdiExtension(MinLength = 1, MaxLength = 30, Mandatory = false, EdiType = EdiType.Alphanumeric)]
        public string ReferenceIdentification { get; set; }

        [EdiValue("X(2)", Path = "CAD/8", Description = "CAD09 - Service Level Code")]
        [EdiExtension(MinLength = 1, MaxLength = 2, Mandatory = false, EdiType = EdiType.Identifier)]
        public string ServiceLevelCode { get; set; }
    }
}
