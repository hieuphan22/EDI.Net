using Edi.Domain.Shared.Enums;
using indice.Edi.Serialization;
using Scm.Edi.Domain.Shared.Attributes;

namespace Edi.Application.Contracts.Poco.X12_4010.Segments
{
    /// <summary>
    /// Note/Special Instruction Segment
    /// </summary>
    [EdiSegment]
    [EdiPath("NTE")]
    public class NTE
    {
        [EdiValue("X(3)", Path = "NTE/0", Description = "NTE01 - Note Reference Code")]
        [EdiExtension(MinLength = 3, MaxLength = 3, Mandatory = true, EdiType = EdiType.Identifier)]
        public string NoteReferenceCode { get; set; }

        [EdiValue("X(80)", Path = "NTE/1", Description = "NTE02 - Description")]
        [EdiExtension(MinLength = 1, MaxLength = 80, Mandatory = true, EdiType = EdiType.Alphanumeric)]
        public string Description { get; set; }
    }
}
