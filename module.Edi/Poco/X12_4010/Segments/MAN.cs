using Edi.Domain.Shared.Enums;
using indice.Edi.Serialization;
using Scm.Edi.Domain.Shared.Attributes;

namespace Edi.Application.Contracts.Poco.X12_4010.Segments
{
    [EdiSegment]
    [EdiPath("MAN")]
    public class MAN
    {
        [EdiValue("X(2)", Path = "MAN/0", Description = "MAN01 - Marks and Numbers Qualifier")]
        [EdiExtension(MinLength = 1, MaxLength = 1, Mandatory = true, EdiType = EdiType.Identifier)]
        [EdiAllowValue(AllowedValues = new string[] { "L", "R", "S", "W", "X", "AA", "AI", "CA", "CP", "DZ", "GM", "MC", "PB", "SI", "SM", "SR", "SS", "UC", "UP", "ZZ" })]
        public string MarksAndNumbersQualifier { get; set; }

        [EdiValue("X(50)", Path = "MAN/1", Description = "MAN02 - Marks and Numbers")]
        [EdiExtension(MinLength = 1, MaxLength = 50, Mandatory = true, EdiType = EdiType.Alphanumeric)]
        public string MarksAndNumbers { get; set; }

        [EdiValue("X(50)", Path = "MAN/2", Description = "MAN03 - Marks and Numbers")]
        [EdiExtension(MinLength = 1, MaxLength = 50, Mandatory = false, EdiType = EdiType.Alphanumeric)]
        public string MarksAndNumbers02 { get; set; }

        [EdiValue("X(2)", Path = "MAN/3", Description = "MAN04 - Marks and Numbers Qualifier")]
        [EdiExtension(MinLength = 1, MaxLength = 1, Mandatory = false, EdiType = EdiType.Identifier)]
        [EdiAllowValue(AllowedValues = new string[] { "L", "R", "S", "W", "X", "AA", "AI", "CA", "CP", "DZ", "GM", "MC", "PB", "SI", "SM", "SR", "SS", "UC", "UP", "ZZ" })]
        public string MarksAndNumbersQualifier02 { get; set; }

        [EdiValue("X(2)", Path = "MAN/4", Description = "MAN05 - Marks and Numbers")]
        [EdiExtension(MinLength = 1, MaxLength = 2, Mandatory = false, EdiType = EdiType.Numeric)]
        public string MarksAndNumbers03 { get; set; }

        [EdiValue("X(2)", Path = "MAN/5", Description = "MAN06 - Marks and Numbers")]
        [EdiExtension(MinLength = 1, MaxLength = 2, Mandatory = false, EdiType = EdiType.Numeric)]
        public string MarksAndNumbers04 { get; set; }
    }
}