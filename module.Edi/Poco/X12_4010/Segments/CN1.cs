using Edi.Domain.Shared.Enums;
using indice.Edi.Serialization;
using Scm.Edi.Domain.Shared.Attributes;
namespace Edi.Application.Contracts.Poco.X12_4010.Segments
{
    [EdiSegment]
    [EdiPath("CN1")]
    public class CN1
    {
        [EdiValue("X(2)", Path = "CN1/0", Description = "CN101 - Contract Type Code")]
        [EdiExtension(MinLength = 2, MaxLength = 2, Mandatory = true, EdiType = EdiType.Identifier)]
        [EdiAllowValue(AllowedValues = new string[] { "01", "02", "03", "04", "05", "06", "09", "AB", "AC", "AD", "AE", "AF", "AG", "AH", "AI", "AJ", "CA", "CB", "CH", "CP", "CS", "CW", "CX", "CY", "DI", "EA", "ER", "FA", "FB", "FC", "FD", "FE", "FF", "FG", "FH", "FI", "FJ", "FK", "FL", "FM", "FR", "FX", "LA", "LE", "LH", "OC", "PR", "SP", "TM", "ZZ" })]
        public string ContractTypeCode { get; set; }

        [EdiValue("X(18)", Path = "CN1/1", Description = "CN102 - Monetary Amount")]
        [EdiExtension(MinLength = 1, MaxLength = 18, Mandatory = false, EdiType = EdiType.Decimal)]
        public string MonetaryAmount { get; set; }

        [EdiValue("X(6)", Path = "CN1/2", Description = "CN103 - Percent")]
        [EdiExtension(MinLength = 1, MaxLength = 6, Mandatory = false, EdiType = EdiType.Decimal)]
        public string Percent { get; set; }

        [EdiValue("X(50)", Path = "CN1/3", Description = "CN104 - Reference Identification")]
        [EdiExtension(MinLength = 1, MaxLength = 50, Mandatory = false, EdiType = EdiType.Alphanumeric)]
        public string ReferenceIdentification { get; set; }

        [EdiValue("X(6)", Path = "CN1/4", Description = "CN105 - Terms Discount Percent")]
        [EdiExtension(MinLength = 1, MaxLength = 6, Mandatory = false, EdiType = EdiType.Decimal)]
        public string TermsDiscountPercent { get; set; }

        [EdiValue("X(30)", Path = "CN1/5", Description = "CN106 - Version Identifier")]
        [EdiExtension(MinLength = 1, MaxLength = 30, Mandatory = false, EdiType = EdiType.Alphanumeric)]
        public string VersionIdentifier { get; set; }
    }
}
