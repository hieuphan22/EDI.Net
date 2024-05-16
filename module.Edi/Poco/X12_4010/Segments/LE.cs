using Edi.Domain.Shared.Enums;
using indice.Edi.Serialization;
using Scm.Edi.Domain.Shared.Attributes;

namespace Edi.Application.Contracts.Poco.X12_4010.Segments
{
    [EdiSegment]
    [EdiPath("LE")]
    public class LE
    {
        [EdiValue("X(6)", Path = "LS/0", Description = "LS01 - Loop Identifier Code")]
        [EdiExtension(MinLength = 1, MaxLength = 6, Mandatory = true, EdiType = EdiType.Alphanumeric)]
        public string TrailerLoopIdentifierCode { get; set; }
    }
}
