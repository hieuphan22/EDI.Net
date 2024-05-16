using Edi.Domain.Shared.Attributes;
using Edi.Domain.Shared.Enums;
using indice.Edi.Serialization;
using Scm.Edi.Domain.Shared.Attributes;

namespace Edi.Domain.Shared.Poco.X12_4010.Segments
{
    /// <summary>
    /// Transportation Instructions
    /// </summary>
    [EdiSegment]
    [EdiPath("G66")]
    public class G66
    {
        [EdiValue("X(2)", Path = "G66/0", Description = "G6601 - Shipment Method of Payment")]
        [EdiExtension(MinLength = 2, MaxLength = 2, Mandatory = false, EdiType = EdiType.Identifier)]
        public string ShipmentMethodPayment { get; set; }

        [EdiValue("X(2)", Path = "G66/1", Description = "G6602 - Transportation Method/Type Code")]
        [EdiExtension(MinLength = 1, MaxLength = 2, Mandatory = false, EdiType = EdiType.Identifier)]
        public string TransportationMethod { get; set; }

        [EdiValue("X(1)", Path = "G66/2", Description = "G6603 - Pallet Exchange Code")]
        [EdiExtension(MinLength = 1, MaxLength = 1, Mandatory = false, EdiType = EdiType.Identifier)]
        public string PalletExchangeCode { get; set; }

        [EdiValue("X(2)", Path = "G66/3", Description = "G6604 - Unit Load Option Code")]
        [EdiExtension(MinLength = 2, MaxLength = 2, Mandatory = false, EdiType = EdiType.Identifier)]
        public string UnitLoadOptionCode { get; set; }

        [EdiValue("X(35)", Path = "G66/4", Description = "G6605 - Routing")]
        [EdiExtension(MinLength = 1, MaxLength = 35, Mandatory = false, EdiType = EdiType.Alphanumeric)]
        public string Routing { get; set; }

        [EdiValue("X(2)", Path = "G66/5", Description = "G6606 - F.O.B. Point Code")]
        [EdiExtension(MinLength = 2, MaxLength = 2, Mandatory = false, EdiType = EdiType.Identifier)]
        public string FobPointCode { get; set; }

        [EdiValue("X(30)", Path = "G66/6", Description = "G6607 - F.O.B. Point Code")]
        [EdiExtension(MinLength = 2, MaxLength = 30, Mandatory = false, EdiType = EdiType.Alphanumeric)]
        public string FobPoint { get; set; }
    }
}
