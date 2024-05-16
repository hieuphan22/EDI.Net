using Edi.Domain.Shared.Attributes;
using Edi.Domain.Shared.Enums;
using indice.Edi.Serialization;
using Scm.Edi.Domain.Shared.Attributes;

namespace Edi.Domain.Shared.Poco.X12_4010.Segments
{
    [EdiSegment]
    [EdiPath("AK5")]
    public class AK5
    {
        [EdiValue("X(1)", Path = "AK5/0", Description = "AK501 - Transaction Set Acknowledgment Code")]
        [EdiExtension(MinLength = 1, MaxLength = 1, Mandatory = true, EdiType = EdiType.Identifier)]
        public string TransactionSetAcknowledgmentCode { get; set; }

        [EdiValue("X(3)", Path = "AK5/1", Description = "AK502 - Transaction Set Syntax Error Code")]
        [EdiExtension(MinLength = 1, MaxLength = 3, Mandatory = false, EdiType = EdiType.Identifier)]
        public string TransactionSetSyntaxErrorCode { get; set; }

        [EdiValue("X(3)", Path = "AK5/2", Description = "AK503 - Transaction Set Syntax Error Code")]
        [EdiExtension(MinLength = 1, MaxLength = 3, Mandatory = false, EdiType = EdiType.Identifier)]
        public string TransactionSetSyntaxErrorCode02 { get; set; }

        [EdiValue("X(3)", Path = "AK5/3", Description = "AK504 - Transaction Set Syntax Error Code")]
        [EdiExtension(MinLength = 1, MaxLength = 3, Mandatory = false, EdiType = EdiType.Identifier)]
        public string TransactionSetSyntaxErrorCode03 { get; set; }

        [EdiValue("X(3)", Path = "AK5/4", Description = "AK505 - Transaction Set Syntax Error Code")]
        [EdiExtension(MinLength = 1, MaxLength = 3, Mandatory = false, EdiType = EdiType.Identifier)]
        public string TransactionSetSyntaxErrorCode04 { get; set; }

        [EdiValue("X(3)", Path = "AK5/5", Description = "AK506 - Transaction Set Syntax Error Code")]
        [EdiExtension(MinLength = 1, MaxLength = 3, Mandatory = false, EdiType = EdiType.Identifier)]
        public string TransactionSetSyntaxErrorCode05 { get; set; }
    }
}
