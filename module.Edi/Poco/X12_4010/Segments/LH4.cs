using Edi.Domain.Shared.Enums;
using indice.Edi.Serialization;
using Scm.Edi.Domain.Shared.Attributes;

namespace Edi.Application.Contracts.Poco.X12_4010.Segments
{
    [EdiSegment]
    [EdiPath("LH4")]
    public class LH4
    {
        [EdiValue("X(12)", Path = "LH4/0", Description = "LH401 - Emergency Response Plan Number")]
        [EdiExtension(MinLength = 1, MaxLength = 12, Mandatory = false, EdiType = EdiType.Alphanumeric)]
        public string EmergencyResponsePlanNumber { get; set; }

        [EdiValue("X(80)", Path = "LH4/1", Description = "LH402 - Communication Number")]
        [EdiExtension(MinLength = 1, MaxLength = 80, Mandatory = false, EdiType = EdiType.Alphanumeric)]
        public string CommunicationNumber { get; set; }

        [EdiValue("X(3)", Path = "LH4/2", Description = "LH403 - Packing Group Code")]
        [EdiExtension(MinLength = 1, MaxLength = 3, Mandatory = false, EdiType = EdiType.Identifier)]
        public string PackingGroupCode { get; set; }

        [EdiValue("X(3)", Path = "LH4/3", Description = "LH404 - Subsidiary Classification")]
        [EdiExtension(MinLength = 1, MaxLength = 3, Mandatory = false, EdiType = EdiType.Identifier)]
        public string SubsidiaryClassification { get; set; }

        [EdiValue("X(3)", Path = "LH4/4", Description = "LH405 - Subsidiary Classification")]
        [EdiExtension(MinLength = 1, MaxLength = 3, Mandatory = false, EdiType = EdiType.Identifier)]
        public string SubsidiaryClassification02 { get; set; }

        [EdiValue("X(3)", Path = "LH4/5", Description = "LH406 - Subsidiary Classification")]
        [EdiExtension(MinLength = 1, MaxLength = 3, Mandatory = false, EdiType = EdiType.Identifier)]
        public string SubsidiaryClassification03 { get; set; }

        [EdiValue("X(2)", Path = "LH4/6", Description = "LH407 - Subsidiary Risk Indicator")]
        [EdiExtension(MinLength = 1, MaxLength = 2, Mandatory = false, EdiType = EdiType.Identifier)]
        public string SubsidiaryRiskIndicator { get; set; }

        [EdiValue("X(6)", Format = "N0", Path = "LH4/7", Description = "LH408 - Net Explosive Quantity")]
        [EdiExtension(MinLength = 1, MaxLength = 6, EdiType = EdiType.Numeric)]
        public string NetExplosiveQuantity { get; set; }

        [EdiValue("X(25)", Path = "LH4/8", Description = "LH409 - Canadian Hazardous Notation")]
        [EdiExtension(MinLength = 1, MaxLength = 25, Mandatory = false, EdiType = EdiType.Alphanumeric)]
        public string CanadianHazardousNotation { get; set; }

        [EdiValue("X(1)", Path = "LH4/9", Description = "LH410 - Special Commodity Indicator Code")]
        [EdiExtension(MinLength = 1, MaxLength = 1, Mandatory = false, EdiType = EdiType.Identifier)]
        public string SpecialCommodityIndicatorCode { get; set; }

        [EdiValue("X(80)", Path = "LH4/10", Description = "LH411 - Communication Number")]
        [EdiExtension(MinLength = 1, MaxLength = 80, Mandatory = false, EdiType = EdiType.Alphanumeric)]
        public string CommunicationNumber02 { get; set; }

        [EdiValue("X(2)", Path = "LH4/11", Description = "LH412 - Unit or Basis for Measurement Code")]
        [EdiExtension(MinLength = 2, MaxLength = 2, EdiType = EdiType.Identifier)]
        public string UnitOrBasisForMeasurementCode { get; set; }
    }
}
