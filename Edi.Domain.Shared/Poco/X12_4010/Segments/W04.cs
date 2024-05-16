using Edi.Domain.Shared.Attributes;
using Edi.Domain.Shared.Enums;
using indice.Edi.Serialization;
using Scm.Edi.Domain.Shared.Attributes;

namespace Edi.Domain.Shared.Poco.X12_4010.Segments
{
    [EdiSegment]
    [EdiPath("W04")]
    public class W04
    {
        [EdiValue("X(10)", Path = "W04/0", Description = "W0401 - Number of Units Shipped")]
        [EdiExtension(MinLength = 1, MaxLength = 10, Mandatory = true, EdiType = EdiType.Decimal)]
        public string NumberOfUnitsShipped { get; set; }

        [EdiValue("X(2)", Path = "W04/1", Description = "W0402 - Unit or Basis for Measurement Code")]
        [EdiExtension(MinLength = 2, MaxLength = 2, Mandatory = true, EdiType = EdiType.Identifier)]
        public string UnitOrBasisForMeasurementCode { get; set; }

        [EdiValue("X(12)", Path = "W04/2", Description = "W0403 - U.P.C. Case Code")]
        [EdiExtension(MinLength = 12, MaxLength = 12, EdiType = EdiType.Alphanumeric)]
        public string UPCCaseCode { get; set; }

        [EdiValue("X(2)", Path = "W04/3", Description = "W0404 - Product/Service ID Qualifier")]
        [EdiExtension(MinLength = 2, MaxLength = 2, EdiType = EdiType.Identifier)]
        public string ProductOrServiceIDQualifier { get; set; }

        [EdiValue("X(48)", Path = "W04/4", Description = "W0405 - Product/Service ID")]
        [EdiExtension(MinLength = 1, MaxLength = 48, EdiType = EdiType.Alphanumeric)]
        public string ProductOrServiceID { get; set; }

        [EdiValue("X(2)", Path = "W04/5", Description = "W0406 - Product/Service ID Qualifier")]
        [EdiExtension(MinLength = 2, MaxLength = 2, EdiType = EdiType.Identifier)]
        public string ProductOrServiceIDQualifier02 { get; set; }

        [EdiValue("X(48)", Path = "W04/6", Description = "W0407 - Product/Service ID")]
        [EdiExtension(MinLength = 1, MaxLength = 48, EdiType = EdiType.Alphanumeric)]
        public string ProductOrServiceID02 { get; set; }

        [EdiValue("X(5)", Path = "W04/7", Description = "W0408 - Freight Class Code")]
        [EdiExtension(MinLength = 2, MaxLength = 5, Mandatory = false, EdiType = EdiType.Alphanumeric)]
        public string FreightClassCode { get; set; }

        [EdiValue("X(3)", Path = "W04/8", Description = "W0409 - Rate Class Code")]
        [EdiExtension(MinLength = 1, MaxLength = 3, Mandatory = false, EdiType = EdiType.Identifier)]
        public string RateClassCode { get; set; }

        [EdiValue("X(1)", Path = "W04/9", Description = "W0410 - Commodity Code Qualifier")]
        [EdiExtension(MinLength = 1, MaxLength = 1, EdiType = EdiType.Identifier)]
        public string CommodityCodeQualifier { get; set; }

        [EdiValue("X(30)", Path = "W04/10", Description = "W0411 - Commodity Code")]
        [EdiExtension(MinLength = 1, MaxLength = 30, EdiType = EdiType.Alphanumeric)]
        public string CommodityCode { get; set; }

        [EdiValue("X(6)", Path = "W04/11", Description = "W0412 - Pallet Block and Tiers")]
        [EdiExtension(MinLength = 6, MaxLength = 6, Mandatory = false, EdiType = EdiType.Numeric)]
        public string PalletBlockAndTiers { get; set; }

        [EdiValue("X(2)", Path = "W04/12", Description = "W0413 - Inbound Condition Hold Code")]
        [EdiExtension(MinLength = 2, MaxLength = 2, Mandatory = false, EdiType = EdiType.Identifier)]
        public string InboundConditionHoldCode { get; set; }

        [EdiValue("X(2)", Path = "W04/13", Description = "W0414 - Product/Service ID Qualifier")]
        [EdiExtension(MinLength = 2, MaxLength = 2, EdiType = EdiType.Identifier)]
        public string ProductOrServiceIDQualifier03 { get; set; }

        [EdiValue("X(48)", Path = "W04/14", Description = "W0415 - Product/Service ID")]
        [EdiExtension(MinLength = 1, MaxLength = 48, EdiType = EdiType.Alphanumeric)]
        public string ProductOrServiceID03 { get; set; }
    }
}
