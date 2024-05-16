using Edi.Domain.Shared.Enums;
using indice.Edi.Serialization;
using Scm.Edi.Domain.Shared.Attributes;

namespace Edi.Application.Contracts.Poco.X12_4010.Common
{
    [EdiSegment]
    [EdiPath("GE")]
    public class GE
    {
        [EdiValue("X(6)", Format = "N0", Path = "GE/0", Description = "GE01 - Number of Transaction Sets Included")]
        [EdiExtension(MinLength = 1, MaxLength = 6, Mandatory = true, EdiType = EdiType.Numeric)]
        //[EdiCount(EdiCountScope.Messages)]
        public string TransactionsCount { get; set; }

        [EdiValue("X(9)", Format = "N0", Path = "GE/1", Description = "GE02 - Group Control Number")]
        [EdiExtension(MinLength = 1, MaxLength = 9, Mandatory = true, EdiType = EdiType.Numeric)]
        public string GroupTrailerControlNumber { get; set; }
    }
}
