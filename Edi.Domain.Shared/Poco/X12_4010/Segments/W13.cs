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
    [EdiPath("W13")]
    public class W13
    {
        [EdiValue("X(15)", Path = "W13/0", Format = "R", Description = "W1301 - Quantity")]
        [EdiExtension(MinLength = 1, MaxLength = 15, Mandatory = true, EdiType = EdiType.Decimal)]
        public string Quantity { get; set; }

        [EdiValue("X(2)", Path = "W13/1", Description = "W1302 - Unit or Basis for Measurement Code")]
        [EdiExtension(MinLength = 2, MaxLength = 2, Mandatory = true, EdiType = EdiType.Identifier)]
        public string UnitOrBasisForMeasurementCode { get; set; }

        [EdiValue("X(2)", Path = "W13/2", Description = "W1303 - Receiving Condition Code")]
        [EdiExtension(MinLength = 2, MaxLength = 2, Mandatory = true, EdiType = EdiType.Identifier)]
        public string ReceivingConditionCode { get; set; }

        [EdiValue("X(12)", Path = "W13/3", Description = "W1304 - Warehouse Lot Number")]
        [EdiExtension(MinLength = 1, MaxLength = 12, Mandatory = false, EdiType = EdiType.Alphanumeric)]
        public string WarehouseLotNumber { get; set; }

        [EdiValue("X(2)", Path = "W13/4", Description = "W1305 - Damage Reason Code")]
        [EdiExtension(MinLength = 2, MaxLength = 2, Mandatory = false, EdiType = EdiType.Identifier)]
        public string DamageReasonCode { get; set; }
    }
}
