using Edi.Domain.Shared.Attributes;
using Edi.Domain.Shared.Enums;
using indice.Edi.Serialization;
using Scm.Edi.Domain.Shared.Attributes;

namespace Edi.Domain.Shared.Poco.X12_4010.Segments
{
    [EdiSegment]
    [EdiPath("INC")]
    public class INC
    {
        [EdiValue("X(2)", Path = "INC/0", Description = "INC01 - Terms Type Code")]
        [EdiExtension(MinLength = 2, MaxLength = 2, Mandatory = true, EdiType = EdiType.Identifier)]
        [EdiAllowValue(AllowedValues = new string[] { "01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36", "37", "38", "39", "40", "41", "42", "43", "44", "45", "46", "47", "48", "49", "50", "52", "54", "55", "56", "57", "58", "61", "63", "64", "65", "CA", "CO", "NC", "PP", "ZZ" })]
        public string TermsTypeCode { get; set; }

        [EdiValue("X(15)", Path = "INC/1", Description = "INC02 - Quantity")]
        [EdiExtension(MinLength = 1, MaxLength = 15, Mandatory = true, EdiType = EdiType.Decimal)]
        public string Quantity { get; set; }

        [EdiValue("X(15)", Path = "INC/2", Description = "INC03 - Quantity")]
        [EdiExtension(MinLength = 1, MaxLength = 15, Mandatory = true, EdiType = EdiType.Decimal)]
        public string Quantity02 { get; set; }

        [EdiValue("X(18)", Path = "INC/3", Description = "INC04 - Monetary Amount")]
        [EdiExtension(MinLength = 1, MaxLength = 18, Mandatory = false, EdiType = EdiType.Decimal)]
        public string MonetaryAmount { get; set; }
    }
}
