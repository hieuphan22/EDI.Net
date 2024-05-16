using Edi.Domain.Shared.Enums;
using indice.Edi.Serialization;
using Scm.Edi.Domain.Shared.Attributes;

namespace Edi.Application.Contracts.Poco.X12_4010.Segments
{
    [EdiSegment]
    [EdiPath("CRC")]
    public class CRC
    {
        [EdiValue("X(2)", Path = "CRC/0", Description = "CRC01 - Code Category")]
        [EdiExtension(MinLength = 2, MaxLength = 2, Mandatory = true, EdiType = EdiType.Identifier)]
        public string CodeCategory { get; set; }

        [EdiValue("X(1)", Path = "CRC/1", Description = "CRC02 - Yes Or No Condition Or Response Code")]
        [EdiExtension(MinLength = 1, MaxLength = 1, Mandatory = true, EdiType = EdiType.Identifier)]
        public string YesOrNoConditionOrResponseCode { get; set; }

        [EdiValue("X(2)", Path = "CRC/2", Description = "CRC03 - Condition Indicator")]
        [EdiExtension(MinLength = 2, MaxLength = 2, Mandatory = true, EdiType = EdiType.Identifier)]
        public string ConditionIndicator { get; set; }

        [EdiValue("X(2)", Path = "CRC/3", Description = "CRC04 - Condition Indicator")]
        [EdiExtension(MinLength = 2, MaxLength = 2, Mandatory = false, EdiType = EdiType.Identifier)]
        public string ConditionIndicator02 { get; set; }

        [EdiValue("X(2)", Path = "CRC/4", Description = "CRC05 - Condition Indicator")]
        [EdiExtension(MinLength = 2, MaxLength = 2, Mandatory = false, EdiType = EdiType.Identifier)]
        public string ConditionIndicator03 { get; set; }
        [EdiValue("X(2)", Path = "CRC/5", Description = "CRC06 - Condition Indicator")]
        [EdiExtension(MinLength = 2, MaxLength = 2, Mandatory = false, EdiType = EdiType.Identifier)]
        public string ConditionIndicator04 { get; set; }
        [EdiValue("X(2)", Path = "CRC/6", Description = "CRC07 - Condition Indicator")]
        [EdiExtension(MinLength = 2, MaxLength = 2, Mandatory = false, EdiType = EdiType.Identifier)]
        public string ConditionIndicator05 { get; set; }
    }
}
