using Edi.Domain.Shared.Enums;
using indice.Edi.Serialization;
using Scm.Edi.Domain.Shared.Attributes;

namespace Edi.Application.Contracts.Poco.X12_4010.Segments
{
    [EdiSegment, EdiPath("YNQ")]
    public class YNQ
    {
        [EdiValue("X(2)", Path = "YNQ/0", Description = "YNQ01 - Condition Indicator")]
        [EdiExtension(MinLength = 2, MaxLength = 2, Mandatory = false, EdiType = EdiType.Identifier)]
        public string ConditionIndicator { get; set; }

        [EdiValue("X(1)", Path = "YNQ/1", Description = "YNQ02 - Yes Or No Condition Or Response Code")]
        [EdiExtension(MinLength = 1, MaxLength = 1, Mandatory = true, EdiType = EdiType.Identifier)]
        public string YesOrNoConditionOrResponseCode { get; set; }

        [EdiValue("X(3)", Path = "YNQ/2", Description = "YNQ03 - Date Time Period Format Qualifier")]
        [EdiExtension(MinLength = 1, MaxLength = 1, Mandatory = false, EdiType = EdiType.Identifier)]
        public string DateTimePeriodFormatQualifier { get; set; }

        [EdiValue("X(35)", Path = "YNQ/3", Description = "YNQ04 - Date Time Period")]
        [EdiExtension(MinLength = 1, MaxLength = 35, Mandatory = false, EdiType = EdiType.Alphanumeric)]
        public string DateTimePeriod { get; set; }

        [EdiValue("X(264)", Path = "YNQ/4", Description = "YNQ05 - FreeForm Message Text")]
        [EdiExtension(MinLength = 1, MaxLength = 264, Mandatory = false, EdiType = EdiType.Alphanumeric)]
        public string FreeFormMessageText { get; set; }

        [EdiValue("X(264)", Path = "YNQ/5", Description = "YNQ06 - FreeForm Message Text")]
        [EdiExtension(MinLength = 1, MaxLength = 264, Mandatory = false, EdiType = EdiType.Alphanumeric)]
        public string FreeFormMessageText02 { get; set; }

        [EdiValue("X(264)", Path = "YNQ/6", Description = "YNQ07 - FreeForm Message Text")]
        [EdiExtension(MinLength = 1, MaxLength = 264, Mandatory = false, EdiType = EdiType.Alphanumeric)]
        public string FreeFormMessageText03 { get; set; }

        [EdiValue("X(3)", Path = "YNQ/7", Description = "YNQ08 - Code List Qualifier Code")]
        [EdiExtension(MinLength = 1, MaxLength = 3, Mandatory = false, EdiType = EdiType.Identifier)]
        public string CodeListQualifierCode { get; set; }

        [EdiValue("X(30)", Path = "YNQ/8", Description = "YNQ09 - Industry Code")]
        [EdiExtension(MinLength = 1, MaxLength = 30, Mandatory = false, EdiType = EdiType.Alphanumeric)]
        public string IndustryCode { get; set; }

        [EdiValue("X(264)", Path = "YNQ/9", Description = "YNQ10 - FreeForm Message Text")]
        [EdiExtension(MinLength = 1, MaxLength = 264, Mandatory = false, EdiType = EdiType.Alphanumeric)]
        public string FreeFormMessageText04 { get; set; }
    }
}
