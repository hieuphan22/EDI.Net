using Edi.Domain.Shared.Enums;
using indice.Edi.Serialization;
using Scm.Edi.Domain.Shared.Attributes;

namespace Edi.Application.Contracts.Poco.X12_4010.Segments
{
    /// <summary>
    /// Carrier Detail
    /// </summary>
    [EdiSegment]
    [EdiPath("W27")]
    public class W27
    {
        [EdiValue("X(2)", Path = "W27/0", Description = "W2701 - Transportation Method/Type Code")]
        [EdiExtension(MinLength = 1, MaxLength = 2, Mandatory = true, EdiType = EdiType.Identifier)]
        public string TransportationMethodTypeCode { get; set; }

        [EdiValue("X(4)", Path = "W27/1", Description = "W2702 - Standard Carrier Alpha Code")]
        [EdiExtension(MinLength = 2, MaxLength = 4, Mandatory = false, EdiType = EdiType.Identifier)]
        public string StandardCarrierAlphaCode { get; set; }

        [EdiValue("X(35)", Path = "W27/2", Description = "W2703 - Routing")]
        [EdiExtension(MinLength = 1, MaxLength = 35, Mandatory = false, EdiType = EdiType.Alphanumeric)]
        public string Routing { get; set; }

        [EdiValue("X(2)", Path = "W27/3", Description = "W2704 - Shipment Method of Payment")]
        [EdiExtension(MinLength = 2, MaxLength = 2, Mandatory = true, EdiType = EdiType.Identifier)]
        public string ShipmentMethodPayment { get; set; }

        [EdiValue("X(2)", Path = "W27/4", Description = "W2705 - Equipment Description Code")]
        [EdiExtension(MinLength = 2, MaxLength = 2, Mandatory = false, EdiType = EdiType.Identifier)]
        public string EquipmentDescriptionCode { get; set; }

        [EdiValue("X(4)", Path = "W27/5", Description = "W2706 - Equipment Initial")]
        [EdiExtension(MinLength = 1, MaxLength = 4, Mandatory = false, EdiType = EdiType.Alphanumeric)]
        public string EquipmentInitial { get; set; }

        [EdiValue("X(10)", Path = "W27/6", Description = "W2707 - Equipment Number")]
        [EdiExtension(MinLength = 1, MaxLength = 10, Mandatory = false, EdiType = EdiType.Alphanumeric)]
        public string EquipmentNumber { get; set; }

        [EdiValue("X(2)", Path = "W27/7", Description = "W2708 - Shipment/Order Status Code")]
        [EdiExtension(MinLength = 2, MaxLength = 2, Mandatory = false, EdiType = EdiType.Identifier)]
        public string ShipmentOrderStatusCode { get; set; }

        [EdiValue("X(3)", Path = "W27/8", Description = "W2709 - Special Handling Code")]
        [EdiExtension(MinLength = 2, MaxLength = 3, Mandatory = false, EdiType = EdiType.Identifier)]
        public string SpecialHandlingCode { get; set; }

        [EdiValue("X(2)", Path = "W27/9", Description = "W2710 - Carrier/Route Change Reason Code")]
        [EdiExtension(MinLength = 2, MaxLength = 2, Mandatory = false, EdiType = EdiType.Identifier)]
        public string CarrierChangeReasonCode { get; set; }
    }
}
