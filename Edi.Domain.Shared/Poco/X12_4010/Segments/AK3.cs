using Edi.Domain.Shared.Attributes;
using Edi.Domain.Shared.Enums;
using indice.Edi.Serialization;
using Scm.Edi.Domain.Shared.Attributes;

namespace Edi.Domain.Shared.Poco.X12_4010.Segments
{
    [EdiSegment]
    [EdiPath("AK3")]
    public class AK3
    {
        [EdiValue("X(3)", Path = "AK3/0", Description = "AK301 - Segment ID Code")]
        [EdiExtension(MinLength = 2, MaxLength = 3, Mandatory = true, EdiType = EdiType.Identifier)]
        public string SegmentIDCode { get; set; }

        [EdiValue("X(10)", Format = "N0", Path = "AK3/1", Description = "AK302 - Segment Position in Transaction Set")]
        [EdiExtension(MinLength = 1, MaxLength = 10, Mandatory = true, EdiType = EdiType.Numeric)]
        public string SegmentPositionInTransactionSet { get; set; }

        [EdiValue("X(4)", Path = "AK3/2", Description = "AK303 - Loop Identifier Code")]
        [EdiExtension(MinLength = 1, MaxLength = 4, Mandatory = false, EdiType = EdiType.Alphanumeric)]
        public string LoopIdentifierCode { get; set; }

        [EdiValue("X(3)", Path = "AK3/3", Description = "AK304 - Segment Syntax Error Code")]
        [EdiExtension(MinLength = 1, MaxLength = 3, Mandatory = false, EdiType = EdiType.Identifier)]
        public string SegmentSyntaxErrorCode { get; set; }
    }
}
