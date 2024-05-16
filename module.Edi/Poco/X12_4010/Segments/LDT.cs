using Edi.Domain.Shared.Enums;
using indice.Edi.Serialization;
using Scm.Edi.Domain.Shared.Attributes;

namespace Edi.Application.Contracts.Poco.X12_4010.Segments
{
    [EdiSegment]
    [EdiPath("LDT")]
    public class LDT
    {
        [EdiValue("X(2)", Path = "LDT/0", Description = "LDT01 - Lead Time Code")]
        [EdiExtension(MinLength = 2, MaxLength = 2, Mandatory = true, EdiType = EdiType.Identifier)]
        [EdiAllowValue(AllowedValues = new string[] { "AA", "AB", "AC", "AD", "AE", "AF", "AG", "AH", "AI", "AJ", "AK", "AL", "AM", "AP", "AR", "AS", "AT", "AU", "AV", "AW", "AX", "AY", "AZ", "BA", "BB", "BC", "BD", "BE", "BF", "BG" })]
        public string LeadTimeCode { get; set; }

        [EdiValue("X(15)", Path = "LDT/1", Format = "R", Description = "LDT02 - Quantity")]
        [EdiExtension(MinLength = 1, MaxLength = 15, Mandatory = true, EdiType = EdiType.Decimal)]
        public string Quantity { get; set; }

        [EdiValue("X(2)", Path = "LDT/2", Description = "LDT03 - Unit of Time Period or Interval")]
        [EdiExtension(MinLength = 2, MaxLength = 2, Mandatory = true, EdiType = EdiType.Identifier)]
        [EdiAllowValue(AllowedValues = new string[] { "AA", "AD", "AM", "AN", "AP", "AY", "BD", "BM", "BW", "CC", "CY", "DA", "DW", "DY", "EL", "F1", "F2", "FY", "HR", "ID", "KK", "KL", "LN", "LT", "MD", "MI", "MO", "MS", "MT", "NX", "PA", "PD", "PM", "PR", "Q1", "Q2", "Q3", "Q4", "QY", "SA", "SD", "SH", "SM", "SP", "TY", "WK", "WW", "WY", "YD", "ZZ" })]
        public string UnitOfTimePeriodOrInterval { get; set; }

        [EdiValue("X(8)", Path = "LDT/3", Format = "yyyyMMdd", Description = "LDT04 - Date")]
        [EdiExtension(MinLength = 8, MaxLength = 8, Mandatory = false, EdiType = EdiType.Date)]
        public string Date { get; set; }
    }
}
