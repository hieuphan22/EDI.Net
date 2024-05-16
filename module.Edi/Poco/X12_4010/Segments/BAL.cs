using Edi.Domain.Shared.Enums;
using indice.Edi.Serialization;
using Scm.Edi.Domain.Shared.Attributes;

namespace Edi.Application.Contracts.Poco.X12_4010.Segments
{
    [EdiSegment]
    [EdiPath("BAL")]
    public class BAL
    {
        [EdiValue("X(2)", Path = "BAL/0", Description = "BAL01 - Balance Type Code")]
        [EdiExtension(MinLength = 1, MaxLength = 2, Mandatory = true, EdiType = EdiType.Identifier)]
        public string BalanceTypeCode { get; set; }

        [EdiValue("X(3)", Path = "BAL/1", Description = "BAL02 - Amount Qualifier Code")]
        [EdiExtension(MinLength = 1, MaxLength = 3, Mandatory = true, EdiType = EdiType.Identifier)]
        public string AmountQualifierCode { get; set; }

        [EdiValue("X(18)", Path = "BAL/2", Format = "R", Description = "BAL03 - Monetary Amount")]
        [EdiExtension(MinLength = 1, MaxLength = 18, Mandatory = true, EdiType = EdiType.Decimal)]
        public string MonetaryAmount { get; set; }
    }
}
