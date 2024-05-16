using Edi.Domain.Shared.Attributes;
using Edi.Domain.Shared.Enums;
using Edi.Domain.Shared.Poco.X12_4010.Composite;
using indice.Edi.Serialization;
using Scm.Edi.Domain.Shared.Attributes;

namespace Edi.Domain.Shared.Poco.X12_4010.Segments
{
    [EdiSegment]
    [EdiPath("AK4")]
    public class AK4
    {
        [EdiPath("AK4/0")]
        public C030 C030 { get; set; }

        [EdiValue("X(4)", Format = "N0", Path = "AK4/1", Description = "AK402 - Data Element Reference Number")]
        [EdiExtension(MinLength = 1, MaxLength = 4, Mandatory = false, EdiType = EdiType.Numeric)]
        public string DataElementReferenceNumber { get; set; }

        [EdiValue("X(3)", Path = "AK4/2", Description = "AK403 - Data Element Syntax Error Code")]
        [EdiExtension(MinLength = 1, MaxLength = 3, Mandatory = true, EdiType = EdiType.Identifier)]
        public string DataElementSyntaxErrorCode { get; set; }

        [EdiValue("X(99)", Path = "AK4/3", Description = "AK404 - Copy of Bad Data Element")]
        [EdiExtension(MinLength = 1, MaxLength = 99, Mandatory = false, EdiType = EdiType.Alphanumeric)]
        public string CopyOfBadDataElement { get; set; }
    }
}
