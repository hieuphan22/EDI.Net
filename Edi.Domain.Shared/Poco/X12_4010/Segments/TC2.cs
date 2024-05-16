using Edi.Domain.Shared.Attributes;
using Edi.Domain.Shared.Enums;
using indice.Edi.Serialization;
using Scm.Edi.Domain.Shared.Attributes;

namespace Edi.Domain.Shared.Poco.X12_4010.Segments
{
    [EdiSegment]
    [EdiPath("TC2")]
    public class TC2
    {
        [EdiValue("X(1)", Path = "TC2/0", Description = "TC201 - Commodity Code Qualifier")]
        [EdiExtension(MinLength = 1, MaxLength = 1, Mandatory = true, EdiType = EdiType.Identifier)]
        [EdiAllowValue(AllowedValues = new string[] { "2", "3", "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "P", "Q", "S", "T", "U", "V", "Z" })]
        public string CommodityCodeQualifier { get; set; }

        [EdiValue("X(30)", Path = "TC2/1", Description = "TC202 - Commodity Code")]
        [EdiExtension(MinLength = 1, MaxLength = 30, Mandatory = true, EdiType = EdiType.Alphanumeric)]

        public string CommodityCode { get; set; }
    }
}
