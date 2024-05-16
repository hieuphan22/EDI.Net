using Edi.Domain.Shared.Attributes;
using Edi.Domain.Shared.Enums;
using indice.Edi.Serialization;
using Scm.Edi.Domain.Shared.Attributes;

namespace Edi.Domain.Shared.Poco.X12_4010.Segments
{
    /// <summary>
    /// Date/Time Segment
    /// </summary>
    [EdiSegment]
    [EdiPath("G62")]
    public class G62
    {
        [EdiValue(Path = "G62/0", Description = "G6201 - Date Qualifier")]
        [EdiExtension(MinLength = 2, MaxLength = 2, Mandatory = true, EdiType = EdiType.Identifier)]
        public string DateQualifier { get; set; }

        [EdiValue("9(8)", Path = "G62/1", Format = "yyyyMMdd", Description = "G6202 - Date format =CCYYMMDD")]
        [EdiExtension(MinLength = 8, MaxLength = 8, Mandatory = true, EdiType = EdiType.Date)]
        public string Date { get; set; }

        [EdiValue(Path = "G62/2", Description = "G6203 - Time Qualifier")]
        [EdiExtension(MinLength = 1, MaxLength = 2, Mandatory = true, EdiType = EdiType.Identifier)]
        public string TimeQualifier { get; set; }

        [EdiValue("9(8)", Path = "G62/3", Format = "HHmm", Description = "G6204 - Time format =HHmmssff")]
        [EdiExtension(MinLength = 4, MaxLength = 8, Mandatory = true, EdiType = EdiType.Time)]
        public string Time { get; set; }

        [EdiValue(Path = "G62/4", Description = "G6205 - Time Code")]
        [EdiExtension(MinLength = 2, MaxLength = 2, Mandatory = false, EdiType = EdiType.Identifier)]
        public string TimeCode { get; set; }
    }
}
