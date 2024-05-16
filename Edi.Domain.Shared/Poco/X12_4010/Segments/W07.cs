using Edi.Domain.Shared.Attributes;
using Edi.Domain.Shared.Enums;
using indice.Edi.Serialization;
using Scm.Edi.Domain.Shared.Attributes;

namespace Edi.Domain.Shared.Poco.X12_4010.Segments
{
    /// <summary>
    /// Contract Segment
    /// </summary>
    [EdiSegment]
    [EdiPath("W07")]
    public class W07
    {
        [EdiValue("X(7)", Path = "W07/0", Format = "R", Description = "W0701 - Quantity Received")]
        [EdiExtension(MinLength = 1, MaxLength = 7, Mandatory = true, EdiType = EdiType.Decimal)]
        public string QuantityReceived { get; set; }

        [EdiValue("X(2)", Path = "W07/1", Description = "W0702 - Unit or Basis for Measurement Code")]
        [EdiExtension(MinLength = 2, MaxLength = 2, Mandatory = true, EdiType = EdiType.Identifier)]
        public string UnitOrBasisForMeasurementCode { get; set; }

        [EdiValue("X(12)", Path = "W07/2", Description = "W0703 - UPC Case Code")]
        [EdiExtension(MinLength = 12, MaxLength = 12, Mandatory = false, EdiType = EdiType.Alphanumeric)]
        public string UPCCaseCode { get; set; }

        [EdiValue("X(2)", Path = "W07/3", Description = "W0704 - Product/Service ID Qualifier")]
        [EdiExtension(MinLength = 2, MaxLength = 2, Mandatory = false, EdiType = EdiType.Identifier)]
        public string ProductOrServiceIDQualifier { get; set; }

        [EdiValue("X(48)", Path = "W07/4", Description = "W0705 - Product/Service ID")]
        [EdiExtension(MinLength = 1, MaxLength = 48, Mandatory = false, EdiType = EdiType.Alphanumeric)]
        public string ProductOrServiceID { get; set; }

        [EdiValue("X(2)", Path = "W07/5", Description = "W0706 - Product/Service ID Qualifier")]
        [EdiExtension(MinLength = 2, MaxLength = 2, Mandatory = false, EdiType = EdiType.Identifier)]
        public string ProductOrServiceIDQualifier02 { get; set; }

        [EdiValue("X(48)", Path = "W07/6", Description = "W0707 - Product/Service ID")]
        [EdiExtension(MinLength = 1, MaxLength = 48, Mandatory = false, EdiType = EdiType.Alphanumeric)]
        public string ProductOrServiceID02 { get; set; }

        [EdiValue("X(12)", Path = "W07/7", Description = "W0708 - Warehouse Lot Number")]
        [EdiExtension(MinLength = 1, MaxLength = 12, Mandatory = false, EdiType = EdiType.Alphanumeric)]
        public string WarehouseLotNumber { get; set; }

        [EdiValue("X(1)", Path = "W07/8", Description = "W0709 - Warehouse Detail Adjustment Identifier")]
        [EdiExtension(MinLength = 1, MaxLength = 1, Mandatory = false, EdiType = EdiType.Identifier)]
        public string WarehouseDetailAdjustmentIdentifier { get; set; }

        [EdiValue("X(2)", Path = "W07/9", Description = "W0710 - Product/Service ID Qualifier")]
        [EdiExtension(MinLength = 2, MaxLength = 2, Mandatory = false, EdiType = EdiType.Identifier)]
        public string ProductOrServiceIDQualifier03 { get; set; }

        [EdiValue("X(48)", Path = "W07/10", Description = "W0711 - Product/Service ID")]
        [EdiExtension(MinLength = 1, MaxLength = 48, Mandatory = false, EdiType = EdiType.Alphanumeric)]
        public string ProductOrServiceID03 { get; set; }
    }
}
