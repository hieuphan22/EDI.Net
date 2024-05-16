using Edi.Domain.Shared.Attributes;
using Edi.Domain.Shared.Enums;
using indice.Edi.Serialization;
using Scm.Edi.Domain.Shared.Attributes;

namespace Edi.Domain.Shared.Poco.X12_4010.Segments
{
    [EdiSegment]
    [EdiPath("W10")]
    public class W10
    {
        [EdiValue("X(2)", Path = "W10/0", Description = "W1001 - Unit Load Option Code")]
        [EdiExtension(MinLength = 2, MaxLength = 2, Mandatory = false, EdiType = EdiType.Identifier)]
        public string UnitLoadOptionCode { get; set; }

        [EdiValue("X(3)", Path = "W10/1", Description = "W1002 - Quantity of Pallets Shipped")]
        [EdiExtension(MinLength = 1, MaxLength = 3, Mandatory = false, EdiType = EdiType.Numeric)]
        public string QuantityOfPalletsShipped { get; set; }

        [EdiValue("X(1)", Path = "W10/2", Description = "W1003 - Pallet Exchange Code")]
        [EdiExtension(MinLength = 1, MaxLength = 1, Mandatory = false, EdiType = EdiType.Identifier)]
        public string PalletExchangeCode { get; set; }

        [EdiValue("X(15)", Path = "W10/3", Description = "W1004 - Seal Number")]
        [EdiExtension(MinLength = 2, MaxLength = 15, Mandatory = false, EdiType = EdiType.Alphanumeric)]
        public string SealNumber { get; set; }

        [EdiValue("X(15)", Path = "W10/4", Description = "W1005 - Seal Number")]
        [EdiExtension(MinLength = 2, MaxLength = 15, Mandatory = false, EdiType = EdiType.Alphanumeric)]
        public string SealNumber02 { get; set; }

        [EdiValue("X(4)", Path = "W10/5", Description = "W1006 - Temperature")]
        [EdiExtension(MinLength = 1, MaxLength = 4, Mandatory = true, EdiType = EdiType.Decimal)]
        public string Temperature { get; set; }

        [EdiValue("X(2)", Path = "W10/6", Description = "W1007 - Unit or Basis for Measurement Code")]
        [EdiExtension(MinLength = 2, MaxLength = 2, EdiType = EdiType.Identifier)]
        public string UnitOrBasisForMeasurementCode { get; set; }

        [EdiValue("X(4)", Path = "W10/7", Description = "W1008 - Temperature")]
        [EdiExtension(MinLength = 1, MaxLength = 4, EdiType = EdiType.Decimal)]
        public string Temperature02 { get; set; }

        [EdiValue("X(2)", Path = "W10/8", Description = "W1009 - Unit or Basis for Measurement Code")]
        [EdiExtension(MinLength = 2, MaxLength = 2, EdiType = EdiType.Identifier)]
        public string UnitOrBasisForMeasurementCode02 { get; set; }
    }
}
