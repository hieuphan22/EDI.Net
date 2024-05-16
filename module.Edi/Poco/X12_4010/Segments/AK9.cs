using Edi.Domain.Shared.Enums;
using indice.Edi.Serialization;
using Scm.Edi.Domain.Shared.Attributes;

namespace Edi.Application.Contracts.Poco.X12_4010.Segments
{
    [EdiSegment]
    [EdiPath("AK9")]
    public class AK9
    {
        [EdiValue("X(1)", Path = "AK9/0", Description = "AK901 - Functional Group Acknowledge Code")]
        [EdiExtension(MinLength = 1, MaxLength = 1, Mandatory = true, EdiType = EdiType.Identifier)]
        public string FunctionalGroupAcknowledgeCode { get; set; }

        [EdiValue("X(6)", Format = "N0", Path = "AK9/1", Description = "AK902 - Number of Transaction Sets Included")]
        [EdiExtension(MinLength = 1, MaxLength = 6, Mandatory = true, EdiType = EdiType.Numeric)]
        public string NumberOfTransactionSetsIncluded { get; set; }

        [EdiValue("X(6)", Format = "N0", Path = "AK9/2", Description = "AK903 - Number of Received Transaction Sets")]
        [EdiExtension(MinLength = 1, MaxLength = 6, Mandatory = true, EdiType = EdiType.Numeric)]
        public string NumberOfReceivedTransactionSets { get; set; }

        [EdiValue("X(6)", Format = "N0", Path = "AK9/3", Description = "AK904 - Number of Accepted Transaction Sets")]
        [EdiExtension(MinLength = 1, MaxLength = 6, Mandatory = true, EdiType = EdiType.Numeric)]
        public string NumberOfAcceptedTransactionSets { get; set; }

        [EdiValue("X(3)", Path = "AK9/4", Description = "AK905 - Functional Group Syntax Error Code")]
        [EdiExtension(MinLength = 1, MaxLength = 3, Mandatory = false, EdiType = EdiType.Identifier)]
        public string FunctionalGroupSyntaxErrorCode { get; set; }

        [EdiValue("X(3)", Path = "AK9/5", Description = "AK906 - Functional Group Syntax Error Code")]
        [EdiExtension(MinLength = 1, MaxLength = 3, Mandatory = false, EdiType = EdiType.Identifier)]
        public string FunctionalGroupSyntaxErrorCode2 { get; set; }

        [EdiValue("X(3)", Path = "AK9/6", Description = "AK907 - Functional Group Syntax Error Code")]
        [EdiExtension(MinLength = 1, MaxLength = 3, Mandatory = false, EdiType = EdiType.Identifier)]
        public string FunctionalGroupSyntaxErrorCode3 { get; set; }

        [EdiValue("X(3)", Path = "AK9/7", Description = "AK908 - Functional Group Syntax Error Code")]
        [EdiExtension(MinLength = 1, MaxLength = 3, EdiType = EdiType.Identifier)]
        public string FunctionalGroupSyntaxErrorCode4 { get; set; }

        [EdiValue("X(3)", Path = "AK9/8", Description = "AK909 - Functional Group Syntax Error Code")]
        [EdiExtension(MinLength = 1, MaxLength = 3, Mandatory = false, EdiType = EdiType.Identifier)]
        public string FunctionalGroupSyntaxErrorCode05 { get; set; }
    }
}
