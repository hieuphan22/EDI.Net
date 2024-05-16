using Edi.Domain.Shared.Attributes;
using Edi.Domain.Shared.Enums;
using indice.Edi.Serialization;
using Scm.Edi.Domain.Shared.Attributes;

namespace Edi.Domain.Shared.Poco.X12_4010.Segments
{
    [EdiSegment]
    [EdiPath("LHR")]
    public class LHR
    {
        [EdiValue("X(3)", Path = "LHR/0", Description = "LHR01 - Reference Identification Qualifier")]
        [EdiExtension(MinLength = 2, MaxLength = 3, Mandatory = true, EdiType = EdiType.Identifier)]
        public string ReferenceIdentificationQualifier { get; set; }

        [EdiValue("X(50)", Path = "LHR/1", Description = "LHR02 - Reference Identification")]
        [EdiExtension(MinLength = 1, MaxLength = 50, Mandatory = true, EdiType = EdiType.Alphanumeric)]
        public string ReferenceIdentification { get; set; }

        [EdiValue("X(8)", Path = "LHR/2", Format = "yyyyMMdd", Description = "LHR03 - Date")]
        [EdiExtension(MinLength = 8, MaxLength = 8, Mandatory = false, EdiType = EdiType.Date)]
        public string Date { get; set; }
    }
}
