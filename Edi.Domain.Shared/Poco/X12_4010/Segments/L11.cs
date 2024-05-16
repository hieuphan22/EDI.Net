using Edi.Domain.Shared.Attributes;
using Edi.Domain.Shared.Enums;
using indice.Edi.Serialization;
using Scm.Edi.Domain.Shared.Attributes;

namespace Edi.Domain.Shared.Poco.X12_4010.Segments
{
    [EdiSegment]
    [EdiPath("L11")]
    public class L11
    {
        [EdiValue("X(50)", Path = "L11/0", Description = "L1101 - Reference Identification")]
        [EdiExtension(MinLength = 1, MaxLength = 50, EdiType = EdiType.Alphanumeric)]
        public string ReferenceIdentification { get; set; }

        [EdiValue("X(3)", Path = "L11/1", Description = "L1102 - Reference Identification Qualifier")]
        [EdiExtension(MinLength = 2, MaxLength = 3, EdiType = EdiType.Identifier)]
        public string ReferenceIdentificationQualifier { get; set; }

        [EdiValue("X(80)", Path = "L11/2", Description = "L1103 - Description")]
        [EdiExtension(MinLength = 1, MaxLength = 80, EdiType = EdiType.Alphanumeric)]
        public string Description { get; set; }

        [EdiValue("X(8)", Path = "L11/3", Format = "yyyyMMdd", Description = "L1104 - Date")]
        [EdiExtension(MinLength = 8, MaxLength = 8, EdiType = EdiType.Date)]
        public string Date { get; set; }
    }
}
