using Edi.Domain.Shared.Enums;
using indice.Edi.Serialization;
using Scm.Edi.Domain.Shared.Attributes;

namespace Edi.Application.Contracts.Poco.X12_4010.Segments
{
    public class W6
    {
        [EdiValue("X(3)", Path = "W6/0", Description = "W601 - Special Handling Code")]
        [EdiExtension(MinLength = 2, MaxLength = 3, Mandatory = true, EdiType = EdiType.Identifier)]
        public string SpecialHandlingCode { get; set; }

        [EdiValue("X(3)", Path = "W6/1", Description = "W602 - Special Handling Code")]
        [EdiExtension(MinLength = 2, MaxLength = 3, Mandatory = false, EdiType = EdiType.Identifier)]
        public string SpecialHandlingCode02 { get; set; }

        [EdiValue("X(3)", Path = "W6/2", Description = "W603 - Special Handling Code")]
        [EdiExtension(MinLength = 2, MaxLength = 3, Mandatory = false, EdiType = EdiType.Identifier)]
        public string SpecialHandlingCode03 { get; set; }

        [EdiValue("X(3)", Path = "W6/3", Description = "W604 - Special Handling Code")]
        [EdiExtension(MinLength = 2, MaxLength = 3, Mandatory = false, EdiType = EdiType.Identifier)]
        public string SpecialHandlingCode04 { get; set; }
    }
}