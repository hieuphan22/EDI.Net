using Edi.Domain.Shared.Enums;
using indice.Edi.Serialization;
using Scm.Edi.Domain.Shared.Attributes;

namespace Edi.Application.Contracts.Poco.X12_4010.Segments
{
    /// <summary>
    /// Warehouse Handling Information Segment
    /// </summary>
    [EdiSegment]
    [EdiPath("W66")]
    public class W66
    {
        [EdiValue("X(2)", Path = "W66/0", Description = "W6601 - Shipment Method of Payment")]
        [EdiExtension(MinLength = 2, MaxLength = 2, Mandatory = true, EdiType = EdiType.Identifier)]
        public string ShipmentMethodPayment { get; set; }

        [EdiValue("X(2)", Path = "W66/1", Description = "W6602 - Transportation Method/Type Code")]
        [EdiExtension(MinLength = 1, MaxLength = 2, Mandatory = true, EdiType = EdiType.Identifier)]
        public string TransportationMethod { get; set; }

        [EdiValue("X(1)", Path = "W66/2", Description = "W6603 - Pallet Exchange Code")]
        [EdiExtension(MinLength = 1, MaxLength = 1, Mandatory = false, EdiType = EdiType.Identifier)]
        public string PalletExchangeCode { get; set; }

        [EdiValue("X(2)", Path = "W66/3", Description = "W6604 - Unit Load Option Code")]
        [EdiExtension(MinLength = 2, MaxLength = 2, Mandatory = false, EdiType = EdiType.Identifier)]
        public string UnitLoadOptionCode { get; set; }

        [EdiValue("X(35)", Path = "W66/4", Description = "W6605 - Routing")]
        [EdiExtension(MinLength = 1, MaxLength = 35, Mandatory = false, EdiType = EdiType.Alphanumeric)]
        public string Routing { get; set; }

        [EdiValue("X(2)", Path = "W66/5", Description = "W6606 - F.O.B. Point Code")]
        [EdiExtension(MinLength = 2, MaxLength = 2, Mandatory = false, EdiType = EdiType.Identifier)]
        public string FobPointCode { get; set; }

        [EdiValue("X(30)", Path = "W66/6", Description = "W6607 - F.O.B. Point Code")]
        [EdiExtension(MinLength = 2, MaxLength = 30, Mandatory = false, EdiType = EdiType.Alphanumeric)]
        public string FobPoint { get; set; }

        [EdiValue("X(1)", Path = "W66/7", Description = "W6608 - COD Method of Payment Code ")]
        [EdiExtension(MinLength = 1, MaxLength = 1, Mandatory = false, EdiType = EdiType.Identifier)]
        public string CodMethodPaymentCode { get; set; }

        [EdiValue("9(15)", Format = "N2", Path = "W66/8", Description = "W6609 - Monetary amount")]
        [EdiExtension(MinLength = 1, MaxLength = 15, Mandatory = false, EdiType = EdiType.Numeric)]
        public string Amount { get; set; }

        [EdiValue("X(4)", Path = "W66/9", Description = "W6610 - Standard Carrier Alpha Code")]
        [EdiExtension(MinLength = 2, MaxLength = 4, Mandatory = false, EdiType = EdiType.Identifier)]
        public string StandardCarrierAlphaCode { get; set; }
    }
}