using Edi.Domain.Shared.Enums;
using indice.Edi.Serialization;
using Scm.Edi.Domain.Shared.Attributes;

namespace Edi.Application.Contracts.Poco.X12_4010.Segments
{
    [EdiSegment]
    [EdiPath("DTP")]
    public class DTP
    {
        [EdiValue("X(3)", Path = "DTP/0", Description = "DTP01 - Date/Time Qualifier")]
        [EdiExtension(MinLength = 3, MaxLength = 3, Mandatory = true, EdiType = EdiType.Identifier)]
        public string DateTimeQualifier { get; set; }

        [EdiValue("X(3)", Path = "DTP/1", Description = "DTP02 - Date Time Period Format Qualifier")]
        [EdiExtension(MinLength = 2, MaxLength = 3, Mandatory = true, EdiType = EdiType.Identifier)]
        public string DateTimePeriodFormatQualifier { get; set; }

        [EdiValue("X(35)", Path = "DTP/2", Description = "DTP03 - Date Time Period")]
        [EdiExtension(MinLength = 1, MaxLength = 35, EdiType = EdiType.Alphanumeric)]
        public string DateTimePeriod { get; set; }
    }
}
