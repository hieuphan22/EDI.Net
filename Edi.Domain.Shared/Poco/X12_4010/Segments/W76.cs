using Edi.Domain.Shared.Attributes;
using Edi.Domain.Shared.Enums;
using indice.Edi.Serialization;
using Scm.Edi.Domain.Shared.Attributes;

namespace Edi.Domain.Shared.Poco.X12_4010.Segments
{
    /// <summary>
    /// Total Shipping Order Segment
    /// </summary>
    [EdiSegment]
    [EdiPath("W76")]
    public class W76
    {
        [EdiValue("9(15)", Format = "N0", Path = "W76/0", Description = "W7601 - Quantity Ordered")]
        [EdiExtension(MinLength = 1, MaxLength = 15, Mandatory = false, EdiType = EdiType.Numeric)]
        public string QuantityOrdered { get; set; }

        [EdiValue("9(10)", Format = "R", Path = "W76/1", Description = "W7602 - Weight")]
        [EdiExtension(MinLength = 1, MaxLength = 10, Mandatory = false, EdiType = EdiType.Decimal)]
        public string Weight { get; set; }

        [EdiValue("X(2)", Path = "W76/2", Description = "W7603 - Unit or Basis for Measurement Code")]
        [EdiExtension(MinLength = 2, MaxLength = 2, Mandatory = false, EdiType = EdiType.Identifier)]
        public string UnitOfMeasurement { get; set; }

        [EdiValue("X(10)", Format = "R", Path = "W76/3", Description = "W7604 - Volume")]
        [EdiExtension(MinLength = 2, MaxLength = 8, Mandatory = false, EdiType = EdiType.Decimal)]
        public string Volumne { get; set; }

        [EdiValue("X(10)", Path = "W76/4", Description = "W7605 - Unit or Basis for Measurement Code")]
        [EdiExtension(MinLength = 2, MaxLength = 2, Mandatory = false, EdiType = EdiType.Identifier)]
        public string UnitOfMeasurementOfVolumne { get; set; }

        [EdiValue("X(10)", Path = "W76/5", Description = "W7606 - Order Sizing Factor")]
        [EdiExtension(MinLength = 2, MaxLength = 10, Mandatory = false, EdiType = EdiType.Decimal)]
        public string OrderSizingFactor { get; set; }
    }
}
