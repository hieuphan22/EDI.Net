using Edi.Domain.Shared.Enums;
using indice.Edi.Serialization;
using Scm.Edi.Domain.Shared.Attributes;

namespace Edi.Application.Contracts.Poco.X12_4010.Segments
{
    [EdiSegment]
    [EdiPath("W28")]
    public class W28
    {
        [EdiValue("X(1)", Path = "W28/0", Description = "W2801 - Consolidation Code")]
        [EdiExtension(MinLength = 1, MaxLength = 1, Mandatory = true, EdiType = EdiType.Identifier)]
        public string ConsolidationCode { get; set; }

        [EdiValue("X(10)", Path = "W28/1", Description = "W2802 - Weight")]
        [EdiExtension(MinLength = 1, MaxLength = 10, EdiType = EdiType.Decimal)]
        public string Weight { get; set; }

        [EdiValue("X(2)", Path = "W28/2", Description = "W2803 - Weight Qualifier")]
        [EdiExtension(MinLength = 1, MaxLength = 2, EdiType = EdiType.Identifier)]
        public string WeightQualifier { get; set; }

        [EdiValue("X(1)", Path = "W28/3", Description = "W2804 - Weight Unit Code")]
        [EdiExtension(MinLength = 1, MaxLength = 1, EdiType = EdiType.Identifier)]
        public string WeightUnitCode { get; set; }

        [EdiValue("X(2)", Path = "W28/4", Description = "W2805 - Total Stopoffs")]
        [EdiExtension(MinLength = 1, MaxLength = 2, Mandatory = false, EdiType = EdiType.Numeric)]
        public string TotalStopoffs { get; set; }

        [EdiValue("X(30)", Path = "W28/5", Description = "W2806 - Location Identifier")]
        [EdiExtension(MinLength = 1, MaxLength = 30, EdiType = EdiType.Alphanumeric)]
        public string LocationIdentifier { get; set; }

        [EdiValue("X(2)", Path = "W28/6", Description = "W2807 - Location Qualifier")]
        [EdiExtension(MinLength = 1, MaxLength = 2, EdiType = EdiType.Identifier)]
        public string LocationQualifier { get; set; }

        [EdiValue("X(12)", Path = "W28/7", Description = "W2808 - Bill of Lading/Waybill Number")]
        [EdiExtension(MinLength = 1, MaxLength = 12, Mandatory = false, EdiType = EdiType.Alphanumeric)]
        public string BillOfLadingOrWaybillNumber { get; set; }
    }
}
