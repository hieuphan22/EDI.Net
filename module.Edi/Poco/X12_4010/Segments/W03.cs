using Edi.Domain.Shared.Enums;
using indice.Edi.Serialization;
using Scm.Edi.Domain.Shared.Attributes;

namespace Edi.Application.Contracts.Poco.X12_4010.Segments
{
    [EdiSegment]
    [EdiPath("W03")]
    public class W03
    {
        [EdiValue("X(10)", Path = "W03/0", Description = "W0301 - Number of Units Shipped")]
        [EdiExtension(MinLength = 1, MaxLength = 10, Mandatory = true, EdiType = EdiType.Decimal)]
        public string NumberOfUnitsShipped { get; set; }

        [EdiValue("X(10)", Path = "W03/1", Description = "W0302 - Weight")]
        [EdiExtension(MinLength = 1, MaxLength = 10, Mandatory = false, EdiType = EdiType.Decimal)]
        public string Weight { get; set; }

        [EdiValue("X(2)", Path = "W03/2", Description = "W0303 - Unit or Basis for Measurement Code")]
        [EdiExtension(MinLength = 2, MaxLength = 2, Mandatory = false, EdiType = EdiType.Identifier)]
        public string UnitOrBasisForMeasurementCode { get; set; }

        [EdiValue("X(8)", Path = "W03/3", Description = "W0304 - Volume")]
        [EdiExtension(MinLength = 1, MaxLength = 8, EdiType = EdiType.Decimal)]
        public string Volume { get; set; }

        [EdiValue("X(2)", Path = "W03/4", Description = "W0305 - Unit or Basis for Measurement Code")]
        [EdiExtension(MinLength = 2, MaxLength = 2, EdiType = EdiType.Identifier)]
        public string UnitOrBasisForMeasurementCode02 { get; set; }

        [EdiValue("X(7)", Path = "W03/5", Description = "W0306 - Lading Quantity")]
        [EdiExtension(MinLength = 1, MaxLength = 7, EdiType = EdiType.Numeric)]
        public string LadingQuantity { get; set; }

        [EdiValue("X(2)", Path = "W03/6", Description = "W0307 - Unit or Basis for Measurement Code")]
        [EdiExtension(MinLength = 2, MaxLength = 2, EdiType = EdiType.Identifier)]
        public string UnitOrBasisForMeasurementCode03 { get; set; }
    }
}
