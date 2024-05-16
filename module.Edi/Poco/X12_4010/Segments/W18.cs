using Edi.Domain.Shared.Enums;
using indice.Edi.Serialization;
using Scm.Edi.Domain.Shared.Attributes;

namespace Edi.Application.Contracts.Poco.X12_4010.Segments
{
    /// <summary>
    /// Contract Segment
    /// </summary>
    [EdiSegment]
    [EdiPath("W18")]
    public class W18
    {
        [EdiValue("X(2)", Path = "W18/0", Description = "W1801 - Temperature Probe Location Code")]
        [EdiExtension(MinLength = 2, MaxLength = 2, Mandatory = true, EdiType = EdiType.Identifier)]
        public string TemperatureProbeLocationCode { get; set; }

        [EdiValue("X(4)", Path = "W18/1", Format = "R", Description = "W1802 - Temperature")]
        [EdiExtension(MinLength = 1, MaxLength = 4, Mandatory = true, EdiType = EdiType.Decimal)]
        public string Temperature { get; set; }

        [EdiValue("X(2)", Path = "W18/2", Description = "W1803 - Unit or Basis for Measurement Code")]
        [EdiExtension(MinLength = 2, MaxLength = 2, Mandatory = false, EdiType = EdiType.Identifier)]
        public string UnitOrBasisForMeasurementCode { get; set; }
    }
}
