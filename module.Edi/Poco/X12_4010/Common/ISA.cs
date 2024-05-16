using Edi.Domain.Shared.Enums;
using Edi.Domain.Shared.Attributes;
using indice.Edi.Serialization;

namespace module.Edi.Poco.X12_4010.Common
{
    [EdiSegment]
    [EdiPath("ISA")]
    public class ISA
    {
        [EdiValue("X(2)", Path = "ISA/0", Description = "ISA01 - Authorization Information Qualifier")]
        [EdiExtension(MinLength = 2, MaxLength = 2, Mandatory = true, EdiType = EdiType.Identifier)]
        public string AuthorizationInformationQualifier { get; set; }

        [EdiValue("X(10)", Path = "ISA/1", Description = "ISA02 - Authorization Information")]
        [EdiExtension(MinLength = 10, MaxLength = 10, Mandatory = true, EdiType = EdiType.Alphanumeric)]
        public string AuthorizationInformation { get; set; }

        [EdiValue("X(2)", Path = "ISA/2", Description = "ISA03 - Security Information Qualifier")]
        [EdiExtension(MinLength = 2, MaxLength = 2, Mandatory = true, EdiType = EdiType.Identifier)]
        public string SecurityInformationQualifier { get; set; }

        [EdiValue("X(10)", Path = "ISA/3", Description = "ISA04 - Security Information")]
        [EdiExtension(MinLength = 10, MaxLength = 10, Mandatory = true, EdiType = EdiType.Alphanumeric)]
        public string SecurityInformation { get; set; }

        [EdiValue("X(2)", Path = "ISA/4", Description = "ISA05 - Interchange ID Qualifier")]
        [EdiExtension(MinLength = 2, MaxLength = 2, Mandatory = true, EdiType = EdiType.Identifier)]
        public string IdQualifier { get; set; }

        [EdiValue("X(15)", Path = "ISA/5", Description = "ISA06 - Interchange Sender ID")]
        [EdiExtension(MinLength = 15, MaxLength = 15, Mandatory = true, EdiType = EdiType.Alphanumeric)]
        public string SenderId { get; set; }

        [EdiValue("X(2)", Path = "ISA/6", Description = "ISA07 - Interchange ID Qualifier")]
        [EdiExtension(MinLength = 2, MaxLength = 2, Mandatory = true, EdiType = EdiType.Identifier)]
        public string IdQualifier2 { get; set; }

        [EdiValue("X(15)", Path = "ISA/7", Description = "ISA08 - Interchange Receiver ID")]
        [EdiExtension(MinLength = 15, MaxLength = 15, Mandatory = true, EdiType = EdiType.Alphanumeric)]
        public string ReceiverId { get; set; }

        [EdiValue("X(6)", Path = "ISA/8", Format = "yyMMdd", Description = "I09 - Interchange Date")]
        [EdiExtension(MinLength = 6, MaxLength = 6, Mandatory = true, EdiType = EdiType.Date)]
        public string InterchangeDate { get; set; }

        [EdiValue("X(4)", Path = "ISA/9", Format = "HHmm", Description = "I10 - Interchange Time")]
        [EdiExtension(MinLength = 4, MaxLength = 4, Mandatory = true, EdiType = EdiType.Time)]
        public string InterchangeTime { get; set; }

        [EdiValue("X(1)", Path = "ISA/10", Description = "ISA11 - Interchange Control Standards ID")]
        [EdiExtension(MinLength = 1, MaxLength = 1, Mandatory = true, EdiType = EdiType.Identifier)]
        public string ControlStandardsId { get; set; }

        [EdiValue("X(5)", Path = "ISA/11", Description = "ISA12 - Interchange Control Version Num")]
        [EdiExtension(MinLength = 5, MaxLength = 5, Mandatory = true, EdiType = EdiType.Identifier)]
        public string ControlVersion { get; set; }

        [EdiValue("X(9)", Format = "N0", Path = "ISA/12", Description = "ISA13 - Interchange Control Number")]
        [EdiExtension(MinLength = 9, MaxLength = 9, Mandatory = true, EdiType = EdiType.Numeric)]
        public string ControlNumber { get; set; }

        [EdiValue("X(1)", Path = "ISA/13", Description = "ISA14 - Acknowledgement Requested")]
        [EdiExtension(MinLength = 1, MaxLength = 1, Mandatory = true, EdiType = EdiType.Identifier)]
        public string AcknowledgementRequested { get; set; }

        [EdiValue("X(1)", Path = "ISA/14", Description = "ISA15 - Usage Indicator")]
        [EdiExtension(MinLength = 1, MaxLength = 1, Mandatory = true, EdiType = EdiType.Identifier)]
        public string UsageIndicator { get; set; }

        [EdiValue("X(1)", Path = "ISA/15", Description = "ISA16 - Component Element Separator")]
        [EdiExtension(MinLength = 1, MaxLength = 1, Mandatory = true, EdiType = EdiType.Alphanumeric)]
        public string ComponentElementSeparator { get; set; }
    }
}
