using Edi.Domain.Shared.Enums;
using indice.Edi.Serialization;
using Scm.Edi.Domain.Shared.Attributes;

namespace Edi.Application.Contracts.Poco.X12_4010.Segments
{
    [EdiSegment]
    [EdiPath("TXI")]
    public class TXI
    {
        [EdiValue("X(2)", Path = "TXI/0", Description = "TXI01 - Tax Type Code")]
        [EdiExtension(MinLength = 2, MaxLength = 2, Mandatory = true, EdiType = EdiType.Identifier)]
        [EdiAllowValue(AllowedValues = new string[] { "AA", "AB", "AT", "BP", "CA", "CB", "CG", "CI", "CP", "CR", "CS", "CT", "CV", "DL", "EQ", "ET", "EV", "F1", "F2", "F3", "FD", "FF", "FI", "FL", "FR", "FS", "FT", "GR", "GS", "HS", "HT", "HZ", "LB", "LO", "LS", "LT", "LU", "LV", "MA", "MN", "MP", "MS", "MT", "OH", "OT", "PG", "PS", "SA", "SB", "SC", "SE", "SF", "SL", "SP", "SR", "SS", "ST", "SU", "SX", "T1", "T2", "TD", "TT", "TX", "UL", "UT", "VA", "WS", "ZA", "ZB", "ZC", "ZD", "ZE", "ZZ" })]
        public string TaxTypeCode { get; set; }

        [EdiValue("9(18)", Format = "R", Path = "TXI/1", Description = "TXI02 - Monetary Amount")]
        [EdiExtension(MinLength = 1, MaxLength = 18, Mandatory = true, EdiType = EdiType.Decimal)]
        public string MonetaryAmount { get; set; }

        [EdiValue("9(10)", Format = "R", Path = "TXI/2", Description = "TXI03 - Percent")]
        [EdiExtension(MinLength = 1, MaxLength = 18, Mandatory = true, EdiType = EdiType.Decimal)]
        public string Percent { get; set; }

        [EdiValue("9(2)", Path = "TXI/3", Description = "TXI04 - Tax Jurisdiction Code Qualifier")]
        [EdiExtension(MinLength = 2, MaxLength = 2, Mandatory = false, EdiType = EdiType.Identifier)]
        [EdiAllowValue(AllowedValues = new string[] { "CD", "VD", "VE" })]

        public string TaxJurisdictionCodeQualifier { get; set; }

        [EdiValue("X(10)", Path = "TXI/4", Description = "TXI05 - Tax Jurisdiction Code")]
        [EdiExtension(MinLength = 1, MaxLength = 10, Mandatory = false, EdiType = EdiType.Alphanumeric)]
        public string TaxJurisdictionCode { get; set; }

        [EdiValue("X(1)", Path = "TXI/5", Description = "TXI06 - Tax Exempt Code")]
        [EdiExtension(MinLength = 1, MaxLength = 1, Mandatory = false, EdiType = EdiType.Identifier)]
        [EdiAllowValue(AllowedValues = new string[] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X" })]

        public string TaxExemptCode { get; set; }

        [EdiValue("X(1)", Path = "TXI/6", Description = "TXI07 - Relationship Code")]
        [EdiExtension(MinLength = 1, MaxLength = 1, Mandatory = false, EdiType = EdiType.Identifier)]
        [EdiAllowValue(AllowedValues = new string[] { "A", "D", "I", "O", "S" })]

        public string RelationshipCode { get; set; }

        [EdiValue("9(9)", Format = "RD", Path = "TXI/7", Description = "TXI08 - Dollar Basis For Percent")]
        [EdiExtension(MinLength = 1, MaxLength = 9, Mandatory = false, EdiType = EdiType.Decimal)]
        public string DollarBasisForPercent { get; set; }

        [EdiValue("X(20)", Path = "TXI/8", Description = "TXI09 - Tax Identification Number")]
        [EdiExtension(MinLength = 1, MaxLength = 20, Mandatory = false, EdiType = EdiType.Alphanumeric)]
        public string TaxIdentificationNumber { get; set; }

        [EdiValue("X(20)", Path = "TXI/9", Description = "TXI10 - Assigned Identification")]
        [EdiExtension(MinLength = 1, MaxLength = 20, Mandatory = false, EdiType = EdiType.Alphanumeric)]
        public string AssignedIdentification { get; set; }
    }
}
