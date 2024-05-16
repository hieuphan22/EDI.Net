using Edi.Domain.Shared.Attributes;
using Edi.Domain.Shared.Enums;
using indice.Edi.Serialization;
using Scm.Edi.Domain.Shared.Attributes;

namespace Edi.Domain.Shared.Poco.X12_4010.Segments
{
    [EdiSegment]
    [EdiPath("LH2")]
    public class LH2
    {
        [EdiValue("X(30)", Path = "LH2/0", Description = "LH201 - Hazardous Classification")]
        [EdiExtension(MinLength = 1, MaxLength = 30, Mandatory = false, EdiType = EdiType.Identifier)]
        public string HazardousClassification { get; set; }

        [EdiValue("X(1)", Path = "LH2/1", Description = "LH202 - Hazardous Class Qualifier")]
        [EdiExtension(MinLength = 1, MaxLength = 1, Mandatory = false, EdiType = EdiType.Identifier)]
        public string HazardousClassQualifier { get; set; }

        [EdiValue("X(40)", Path = "LH2/2", Description = "LH203 - Hazardous Placard Notation")]
        [EdiExtension(MinLength = 14, MaxLength = 40, Mandatory = false, EdiType = EdiType.Identifier)]
        public string HazardousPlacardNotation { get; set; }

        [EdiValue("X(25)", Path = "LH2/3", Description = "LH204 - Hazardous Endorsement")]
        [EdiExtension(MinLength = 4, MaxLength = 25, Mandatory = false, EdiType = EdiType.Identifier)]
        public string HazardousEndorsement { get; set; }

        [EdiValue("X(2)", Path = "LH2/4", Description = "LH205 - Reportable Quantity Code")]
        [EdiExtension(MinLength = 2, MaxLength = 2, Mandatory = false, EdiType = EdiType.Identifier)]
        public string ReportableQuantityCode { get; set; }

        [EdiValue("X(2)", Path = "LH2/5", Description = "LH206 - Unit or Basis for Measurement Code")]
        [EdiExtension(MinLength = 2, MaxLength = 2, Mandatory = false, EdiType = EdiType.Identifier)]
        public string UnitOrBasisForMeasurementCode { get; set; }

        [EdiValue("X(4)", Path = "LH2/6", Description = "LH207 - Temperature")]
        [EdiExtension(MinLength = 1, MaxLength = 4, EdiType = EdiType.Decimal)]
        public string Temperature { get; set; }

        [EdiValue("X(2)", Path = "LH2/7", Description = "LH208 - Unit or Basis for Measurement Code")]
        [EdiExtension(MinLength = 2, MaxLength = 2, EdiType = EdiType.Identifier)]
        public string UnitOrBasisForMeasurementCode02 { get; set; }

        [EdiValue("X(4)", Path = "LH2/8", Description = "LH209 - Temperature")]
        [EdiExtension(MinLength = 1, MaxLength = 4, EdiType = EdiType.Decimal)]
        public string Temperature02 { get; set; }

        [EdiValue("X(2)", Path = "LH2/9", Description = "LH210 - Unit or Basis for Measurement Code")]
        [EdiExtension(MinLength = 2, MaxLength = 2, EdiType = EdiType.Identifier)]
        public string UnitOrBasisForMeasurementCode03 { get; set; }

        [EdiValue("X(4)", Path = "LH2/10", Description = "LH211 - Temperature")]
        [EdiExtension(MinLength = 1, MaxLength = 4, EdiType = EdiType.Decimal)]
        public string Temperature03 { get; set; }
    }
}
