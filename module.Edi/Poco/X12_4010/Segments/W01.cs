using Edi.Domain.Shared.Enums;
using indice.Edi.Serialization;
using Scm.Edi.Domain.Shared.Attributes;

namespace Edi.Application.Contracts.Poco.X12_4010.Segments
{
    /// <summary>
    /// Line Item Detail - Warehouse
    /// </summary>
    [EdiSegment]
    [EdiPath("W01")]
    public class W01
    {
        [EdiValue("9(15)", Format = "N0", Path = "W01/0", Description = "W0101 - Quantity Ordered")]
        [EdiExtension(MinLength = 1, MaxLength = 15, Mandatory = true, EdiType = EdiType.Numeric)]
        public string QuantityOrdered { get; set; }

        [EdiValue("X(2)", Path = "W01/1", Description = "W0102 - Unit or Basis for Measurement Code")]
        [EdiExtension(MinLength = 2, MaxLength = 2, Mandatory = true, EdiType = EdiType.Identifier)]
        public string UnitOfMeasurement { get; set; }

        [EdiValue("X(12)", Path = "W01/2", Description = "W0103 - U.P.C. Case Code")]
        [EdiExtension(MinLength = 12, MaxLength = 12, Mandatory = true, EdiType = EdiType.Alphanumeric)]
        public string UpcCaseCode { get; set; }

        [EdiValue("X(2)", Path = "W01/3", Description = "W0104 - Product/Service ID Qualifier")]
        [EdiExtension(MinLength = 2, MaxLength = 2, Mandatory = true, EdiType = EdiType.Identifier)]
        public string ProductQualifier01 { get; set; }

        [EdiValue("X(48)", Path = "W01/4", Description = "W0105 - Product/Service ID")]
        [EdiExtension(MinLength = 1, MaxLength = 48, Mandatory = true, EdiType = EdiType.Alphanumeric)]
        public string Product01 { get; set; }

        [EdiValue("X(2)", Path = "W01/5", Description = "W0106 - Product/Service ID Qualifier")]
        [EdiExtension(MinLength = 2, MaxLength = 2, Mandatory = true, EdiType = EdiType.Identifier)]
        public string ProductQualifier02 { get; set; }

        [EdiValue("X(48)", Path = "W01/6", Description = "W0107 - Product/Service ID")]
        [EdiExtension(MinLength = 1, MaxLength = 48, Mandatory = true, EdiType = EdiType.Alphanumeric)]
        public string Product02 { get; set; }

        [EdiValue("X(5)", Path = "W01/7", Description = "W0108 - Freight Class Code")]
        [EdiExtension(MinLength = 2, MaxLength = 5, Mandatory = true, EdiType = EdiType.Alphanumeric)]
        public string FreightClassCode { get; set; }

        [EdiValue("X(3)", Path = "W01/8", Description = "W0109 - Rate Class Code")]
        [EdiExtension(MinLength = 1, MaxLength = 3, Mandatory = true, EdiType = EdiType.Identifier)]
        public string RateClassCode { get; set; }

        [EdiValue("X(1)", Path = "W01/9", Description = "W0110 - Commodity Code Qualifier")]
        [EdiExtension(MinLength = 1, MaxLength = 1, Mandatory = true, EdiType = EdiType.Identifier)]
        public string CommodityCodeQualifier { get; set; }

        [EdiValue("X(30)", Path = "W01/10", Description = "W0111 - Commodity Code")]
        [EdiExtension(MinLength = 1, MaxLength = 30, Mandatory = true, EdiType = EdiType.Alphanumeric)]
        public string CommodityCode { get; set; }

        [EdiValue("X(6)", Format = "N0", Path = "W01/11", Description = "W0112 - Pallet Block and Tiers")]
        [EdiExtension(MinLength = 6, MaxLength = 6, Mandatory = true, EdiType = EdiType.Numeric)]
        public string PalletBlock { get; set; }

        [EdiValue("X(12)", Path = "W01/12", Description = "W0113 - Warehouse Lot Number")]
        [EdiExtension(MinLength = 1, MaxLength = 12, Mandatory = true, EdiType = EdiType.Alphanumeric)]
        public string WarehouseLotNumber { get; set; }

        [EdiValue("X(2)", Path = "W01/13", Description = "W0114 - Product/Service Condition Code")]
        [EdiExtension(MinLength = 2, MaxLength = 2, Mandatory = true, EdiType = EdiType.Identifier)]
        public string ProductConditionCode { get; set; }

        [EdiValue("X(2)", Path = "W01/14", Description = "W0115 - Product/Service ID Qualifier")]
        [EdiExtension(MinLength = 2, MaxLength = 5, Mandatory = true, EdiType = EdiType.Identifier)]
        public string ProductQualifier03 { get; set; }

        [EdiValue("X(48)", Path = "W01/15", Description = "W0116 - Product/Service ID")]
        [EdiExtension(MinLength = 1, MaxLength = 48, Mandatory = true, EdiType = EdiType.Alphanumeric)]
        public string Product03 { get; set; }
    }
}
