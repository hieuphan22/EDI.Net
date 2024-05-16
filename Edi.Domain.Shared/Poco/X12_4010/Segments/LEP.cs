using Edi.Domain.Shared.Attributes;
using Edi.Domain.Shared.Enums;
using indice.Edi.Serialization;
using Scm.Edi.Domain.Shared.Attributes;

namespace Edi.Domain.Shared.Poco.X12_4010.Segments
{
    [EdiSegment]
    [EdiPath("LEP")]
    public class LEP
    {
        [EdiValue("X(6)", Path = "LEP/0", Description = "LEP01 - EPA Waste Stream Number Code")]
        [EdiExtension(MinLength = 4, MaxLength = 6, Mandatory = false, EdiType = EdiType.Identifier)]
        public string EPAWasteStreamNumberCode { get; set; }

        [EdiValue("X(16)", Path = "LEP/1", Description = "LEP02 - Waste Characteristics Code")]
        [EdiExtension(MinLength = 12, MaxLength = 16, Mandatory = false, EdiType = EdiType.Identifier)]
        public string WasteCharacteristicsCode { get; set; }

        [EdiValue("X(2)", Path = "LEP/2", Description = "LEP03 - State or Province Code")]
        [EdiExtension(MinLength = 2, MaxLength = 2, EdiType = EdiType.Identifier)]
        public string StateOrProvinceCode { get; set; }

        [EdiValue("X(50)", Path = "LEP/3", Description = "LEP04 - Reference Identification")]
        [EdiExtension(MinLength = 1, MaxLength = 50, EdiType = EdiType.Alphanumeric)]
        public string ReferenceIdentification { get; set; }
    }
}
