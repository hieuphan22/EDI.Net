using Edi.Domain.Shared.Attributes;
using Edi.Domain.Shared.Enums;
using indice.Edi.Serialization;

namespace Edi.Domain.Shared.Poco.X12_4010.Composite
{
    public class C030
    {
        [EdiValue("X(2)", Format = "N0", Path = "*/*/0", Description = "C03001 - Element Position in Segment")]
        [EdiExtension(MinLength = 1, MaxLength = 2, Mandatory = true, EdiType = EdiType.Numeric)]
        public string ElementPositionInSegment { get; set; }

        [EdiValue("X(2)", Format = "N0", Path = "*/*/1", Description = "C03002 - Component Data Element Position in Composite")]
        [EdiExtension(MinLength = 1, MaxLength = 2, Mandatory = false, EdiType = EdiType.Numeric)]
        public string ComponentDataElementPositionInComposite { get; set; }
    }
}
