using Edi.Domain.Shared.Attributes;
using Edi.Domain.Shared.Enums;
using indice.Edi.Serialization;
using Scm.Edi.Domain.Shared.Attributes;

namespace Edi.Domain.Shared.Poco.X12_4010.Segments
{
    /// <summary>
    /// Line Item Detail - Warehouse
    /// </summary>
    [EdiSegment]
    [EdiPath("W12")]
    public class W12
    {
        [EdiValue("X(2)", Path = "W12/0", Description = "W1201 - Shipment/Order Status Code")]
        [EdiExtension(MinLength = 2, MaxLength = 2, Mandatory = true, EdiType = EdiType.Identifier)]
        public string ShipmentOrOrderStatusCode { get; set; }

        [EdiValue("X(10)", Format = "N0", Path = "W12/1", Description = "W1202 - Quantity Ordered")]
        [EdiExtension(MinLength = 1, MaxLength = 10, Mandatory = false, EdiType = EdiType.Numeric)]
        public string QuantityOrdered { get; set; }

        [EdiValue("X(10)", Format = "N0", Path = "W12/2", Description = "W1203 - Number of Units Shipped")]
        [EdiExtension(MinLength = 1, MaxLength = 10, EdiType = EdiType.Numeric)]
        public string NumberOfUnitsShipped { get; set; }

        [EdiValue("X(10)", Format = "N0", Path = "W12/3", Description = "W1204 - Quantity Difference")]
        [EdiExtension(MinLength = 1, MaxLength = 10, Mandatory = false, EdiType = EdiType.Numeric)]
        public string QuantityDifference { get; set; }

        [EdiValue("X(2)", Path = "W12/4", Description = "W1205 - Unit or Basis for Measurement Code")]
        [EdiExtension(MinLength = 2, MaxLength = 2, Mandatory = false, EdiType = EdiType.Identifier)]
        public string UnitOrBasisForMeasurementCode { get; set; }

        [EdiValue("X(12)", Path = "W12/5", Description = "W1206 - UPC Case Code")]
        [EdiExtension(MinLength = 12, MaxLength = 12, Mandatory = false, EdiType = EdiType.Alphanumeric)]
        public string UpcCaseCode { get; set; }

        [EdiValue("X(2)", Path = "W12/6", Description = "W1207 - Product/Service Id Qualifier")]
        [EdiExtension(MinLength = 2, MaxLength = 2, EdiType = EdiType.Identifier)]
        public string ProductOrServiceIdQualifier { get; set; }

        [EdiValue("X(48)", Path = "W12/7", Description = "W1208 - Product/Service Id")]
        [EdiExtension(MinLength = 1, MaxLength = 48, Mandatory = false, EdiType = EdiType.Alphanumeric)]
        public string ProductOrServiceId { get; set; }

        [EdiValue("X(12)", Path = "W12/8", Format = "N0", Description = "W1209 - Warehouse Lot Number")]
        [EdiExtension(MinLength = 1, MaxLength = 12, Mandatory = false, EdiType = EdiType.Numeric)]
        public string WarehouseLotNumber { get; set; }

        [EdiValue("X(10)", Path = "W12/9", Format = "R", Description = "W1210 - Weight")]
        [EdiExtension(MinLength = 1, MaxLength = 10, Mandatory = false, EdiType = EdiType.Decimal)]
        public string Weight { get; set; }

        [EdiValue("X(2)", Path = "W12/10", Description = "W1211 - Weight Qualifier")]
        [EdiExtension(MinLength = 1, MaxLength = 2, Mandatory = false, EdiType = EdiType.Identifier)]
        public string WeightQualifier { get; set; }

        [EdiValue("X(1)", Path = "W12/11", Description = "W1212 - Weight Unit Code")]
        [EdiExtension(MinLength = 1, MaxLength = 1, Mandatory = false, EdiType = EdiType.Identifier)]
        public string WeightUnitCode { get; set; }

        [EdiValue("X(10)", Path = "W12/12", Format = "R", Description = "W1213 - Weight")]
        [EdiExtension(MinLength = 1, MaxLength = 10, Mandatory = false, EdiType = EdiType.Decimal)]
        public string Weight2 { get; set; }

        [EdiValue("X(2)", Path = "W12/13", Description = "W1214 - Weight Qualifier")]
        [EdiExtension(MinLength = 1, MaxLength = 2, Mandatory = false, EdiType = EdiType.Identifier)]
        public string WeightQualifier2 { get; set; }

        [EdiValue("X(1)", Path = "W12/14", Description = "W1215 - Weight Unit Code")]
        [EdiExtension(MinLength = 1, MaxLength = 1, Mandatory = false, EdiType = EdiType.Identifier)]
        public string WeightUnitCode2 { get; set; }

        [EdiValue("X(12)", Path = "W12/15", Description = "W1216 - UPC Case Code")]
        [EdiExtension(MinLength = 12, MaxLength = 12, Mandatory = false, EdiType = EdiType.Alphanumeric)]
        public string UpcCaseCode02 { get; set; }

        [EdiValue("X(2)", Path = "W12/16", Description = "W1217 - Product/Service Id Qualifier")]
        [EdiExtension(MinLength = 2, MaxLength = 2, Mandatory = false, EdiType = EdiType.Identifier)]
        public string ProductOrServiceIdQualifier2 { get; set; }

        [EdiValue("X(48)", Path = "W12/17", Description = "W1218 - Product/Service Id")]
        [EdiExtension(MinLength = 1, MaxLength = 48, Mandatory = false, EdiType = EdiType.Alphanumeric)]
        public string ProductOrServiceId2 { get; set; }

        [EdiValue("X(2)", Path = "W12/18", Description = "W1219 - Line Item Change Code")]
        [EdiExtension(MinLength = 2, MaxLength = 2, Mandatory = false, EdiType = EdiType.Identifier)]
        public string LineItemChangeCode { get; set; }

        [EdiValue("X(1)", Path = "W12/19", Description = "W1220 - Warehouse Detail Id")]
        [EdiExtension(MinLength = 1, MaxLength = 1, Mandatory = false, EdiType = EdiType.Identifier)]
        public string WarehouseDetailId { get; set; }

        [EdiValue("X(2)", Path = "W12/20", Description = "W1221 - Product/Service Id Qualifier")]
        [EdiExtension(MinLength = 2, MaxLength = 2, Mandatory = false, EdiType = EdiType.Identifier)]
        public string ProductOrServiceIdQualifier3 { get; set; }

        [EdiValue("X(48)", Path = "W12/21", Description = "W1222 - Product/Service Id")]
        [EdiExtension(MinLength = 1, MaxLength = 48, Mandatory = false, EdiType = EdiType.Alphanumeric)]
        public string ProductOrServiceId3 { get; set; }
    }
}
