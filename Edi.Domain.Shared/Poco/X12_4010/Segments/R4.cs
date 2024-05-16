using Edi.Domain.Shared.Attributes;
using Edi.Domain.Shared.Enums;
using indice.Edi.Serialization;
using Scm.Edi.Domain.Shared.Attributes;

namespace Edi.Domain.Shared.Poco.X12_4010.Segments
{
    [EdiSegment, EdiPath("R4")]
    public class R4
    {
        [EdiValue("X(1)", Path = "R4/0", Description = "R401 - Port or Terminal Function Code")]
        [EdiExtension(MinLength = 1, MaxLength = 1, Mandatory = true, EdiType = EdiType.Identifier)]
        public string PortOrTerminalFunctionCode { get; set; }

        [EdiValue("X(2)", Path = "R4/1", Description = "R402 - Location Qualifier")]
        [EdiExtension(MinLength = 1, MaxLength = 2, Mandatory = true, EdiType = EdiType.Identifier)]
        public string LocationQualifier { get; set; }

        [EdiValue("X(30)", Path = "R4/2", Description = "R403 - Location Identifier")]
        [EdiExtension(MinLength = 1, MaxLength = 30, Mandatory = false, EdiType = EdiType.Alphanumeric)]
        public string LocationIdentifier { get; set; }

        [EdiValue("X(24)", Path = "R4/3", Description = "R404 - Port Name")]
        [EdiExtension(MinLength = 2, MaxLength = 24, Mandatory = false, EdiType = EdiType.Alphanumeric)]
        public string PortName { get; set; }

        [EdiValue("X(3)", Path = "R4/4", Description = "R405 - Country Code")]
        [EdiExtension(MinLength = 2, MaxLength = 3, Mandatory = true, EdiType = EdiType.Identifier)]
        public string CountryCode { get; set; }

        [EdiValue("X(30)", Path = "R4/5", Description = "R406 - Terminal Name")]
        [EdiExtension(MinLength = 2, MaxLength = 30, Mandatory = false, EdiType = EdiType.Alphanumeric)]
        public string TerminalName { get; set; }

        [EdiValue("X(4)", Path = "R4/6", Description = "R407 - Pier Number")]
        [EdiExtension(MinLength = 1, MaxLength = 4, Mandatory = false, EdiType = EdiType.Alphanumeric)]
        public string PierNumber { get; set; }

        [EdiValue("X(2)", Path = "R4/7", Description = "R408 - State or Province Code")]
        [EdiExtension(MinLength = 2, MaxLength = 2, Mandatory = true, EdiType = EdiType.Identifier)]
        public string StateOrProvinceCode { get; set; }
    }
}
