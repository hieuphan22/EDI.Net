using Edi.Domain.Shared.Attributes;
using Edi.Domain.Shared.Enums;
using indice.Edi.Serialization;
using Scm.Edi.Domain.Shared.Attributes;

namespace Edi.Domain.Shared.Poco.X12_4010.Segments
{
    [EdiSegment]
    [EdiPath("DIS")]
    public class DIS
    {
        [EdiValue("X(3)", Path = "DIS/0", Description = "DIS01 - Discount Terms Type Code")]
        [EdiExtension(MinLength = 3, MaxLength = 3, Mandatory = true, EdiType = EdiType.Identifier)]
        [EdiAllowValue(AllowedValues = new string[] { "AMT", "CSH", "DOR", "DPU", "DSH", "DSV", "POR", "PPU", "PSH", "PSV", "UNT", "ZZZ" })]
        public string DiscountTermsTypeCode { get; set; }

        [EdiValue("X(2)", Path = "DIS/1", Description = "DIS02 - Discount Base Qualifier")]
        [EdiExtension(MinLength = 2, MaxLength = 2, Mandatory = true, EdiType = EdiType.Identifier)]
        [EdiAllowValue(AllowedValues = new string[] { "CA", "PC", "UN", "ZZ" })]
        public string DiscountBaseQualifier { get; set; }

        [EdiValue("X(10)", Path = "DIS/2", Description = "DIS03 - Discount Base Value")]
        [EdiExtension(MinLength = 1, MaxLength = 10, Mandatory = true, EdiType = EdiType.Decimal)]
        public string DiscountBaseValue { get; set; }

        [EdiValue("X(3)", Path = "DIS/3", Description = "DIS04 - Discount Control Limit Qualifier")]
        [EdiExtension(MinLength = 3, MaxLength = 3, Mandatory = true, EdiType = EdiType.Identifier)]
        [EdiAllowValue(AllowedValues = new string[] { "DAT", "DOF" })]
        public string DiscountControlLimitQualifier { get; set; }

        [EdiValue("X(10)", Format = "N0", Path = "DIS/4", Description = "DIS05 - Discount Control Limit")]
        [EdiExtension(MinLength = 1, MaxLength = 10, Mandatory = true, EdiType = EdiType.Numeric)]
        public string DiscountControlLimit { get; set; }

        [EdiValue("X(10)", Format = "N0", Path = "DIS/5", Description = "DIS06 - Discount Control Limit")]
        [EdiExtension(MinLength = 1, MaxLength = 10, Mandatory = false, EdiType = EdiType.Numeric)]
        public string DiscountControlLimit02 { get; set; }

    }
}
