using Edi.Domain.Shared.Attributes;
using Edi.Domain.Shared.Enums;
using indice.Edi.Serialization;
using Scm.Edi.Domain.Shared.Attributes;

namespace Edi.Domain.Shared.Poco.X12_4010.Segments
{
    [EdiSegment]
    [EdiPath("LS")]
    public class LS
    {
        [EdiValue("X(6)", Path = "LS/0", Description = "LS01 - Loop Identifier Code")]
        [EdiExtension(MinLength = 1, MaxLength = 6, Mandatory = true, EdiType = EdiType.Alphanumeric)]
        public string LoopIdentifierCode { get; set; }
    }
}
