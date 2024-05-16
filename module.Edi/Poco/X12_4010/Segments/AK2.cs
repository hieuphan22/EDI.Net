using Edi.Domain.Shared.Enums;
using indice.Edi.Serialization;
using Scm.Edi.Domain.Shared.Attributes;

namespace Edi.Application.Contracts.Poco.X12_4010.Segments
{
    [EdiSegment]
    [EdiPath("AK2")]
    public class AK2
    {
        [EdiValue("X(3)", Path = "AK2/0", Description = "AK201 - Transaction Set Identifier Code")]
        [EdiExtension(MinLength = 3, MaxLength = 3, Mandatory = true, EdiType = EdiType.Identifier)]
        public string TransactionSetIdentifierCode { get; set; }

        [EdiValue("X(9)", Path = "AK2/1", Description = "AK202 - Transaction Set Control Number")]
        [EdiExtension(MinLength = 4, MaxLength = 9, Mandatory = true, EdiType = EdiType.Alphanumeric)]
        public string TransactionSetControlNumber { get; set; }
    }
}
