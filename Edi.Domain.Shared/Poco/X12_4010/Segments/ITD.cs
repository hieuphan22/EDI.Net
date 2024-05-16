using Edi.Domain.Shared.Attributes;
using Edi.Domain.Shared.Enums;
using FluentValidation.Results;
using indice.Edi.Serialization;

namespace Edi.Domain.Shared.Poco.X12_4010.Segments
{
    [EdiSegment, EdiPath("ITD")]
    public class ITD //: IEdiValidation<ITD>
    {
        [EdiValue("X(2)", Path = "ITD/0", Description = "ITD01 - Terms Type Code")]
        [EdiExtension(MinLength = 2, MaxLength = 2, Mandatory = false, EdiType = EdiType.Identifier)]
        [EdiAllowValue(AllowedValues = new string[] { "01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36", "37", "38", "39", "40", "41", "42", "43", "44", "45", "46", "47", "48", "49", "50", "52", "54", "55", "56", "57", "58", "61", "63", "64", "65", "CA", "CO", "NC", "PP", "ZZ" })]

        public string TermsTypeCode { get; set; }

        [EdiValue("X(2)", Path = "ITD/1", Description = "ITD02 - Terms Basis Date Code")]
        [EdiExtension(MinLength = 1, MaxLength = 2, Mandatory = false, EdiType = EdiType.Identifier)]
        [EdiAllowValue(AllowedValues = new string[] { "1", "2", "3", "4", "5", "6", "7", "8", "10", "11", "12", "13", "14", "15", "16", "9", "ZZ" })]

        public string TermsBasisDateCode { get; set; }

        [EdiValue("X(6)", Format = "R", Path = "ITD/2", Description = "ITD03 - Terms Discount Percent")]
        [EdiExtension(MinLength = 1, MaxLength = 6, Mandatory = false, EdiType = EdiType.Decimal)]
        public string TermsDiscountPercent { get; set; }

        [EdiValue("X(8)", Path = "ITD/3", Format = "yyyyMMdd", Description = "ITD04 - Terms Discount Due Date")]
        [EdiExtension(MinLength = 8, MaxLength = 8, Mandatory = false, EdiType = EdiType.Date)]
        public string TermsDiscountDueDate { get; set; }

        [EdiValue("X(3)", Format = "N0", Path = "ITD/4", Description = "ITD05 -Terms Discount Days Due")]
        [EdiExtension(MinLength = 1, MaxLength = 3, Mandatory = false, EdiType = EdiType.Numeric)]
        public string TermsDiscountDaysDue { get; set; }

        [EdiValue("X(8)", Path = "ITD/5", Format = "yyyyMMdd", Description = "ITD06 - Terms Net Due Date")]
        [EdiExtension(MinLength = 8, MaxLength = 8, Mandatory = false, EdiType = EdiType.Date)]
        public string TermsNetDueDate { get; set; }

        [EdiValue("X(3)", Format = "N0", Path = "ITD/6", Description = "ITD07 - Terms Net Days")]
        [EdiExtension(MinLength = 1, MaxLength = 3, Mandatory = false, EdiType = EdiType.Numeric)]
        public string TermsNetDays { get; set; }

        [EdiValue("9(10)", Format = "N2", Path = "ITD/7", Description = "ITD08 - Terms Discount Amount")]
        [EdiExtension(MinLength = 1, MaxLength = 10, Mandatory = false, EdiType = EdiType.Numeric)]
        public string TermsDiscountAmount { get; set; }

        [EdiValue("X(8)", Path = "ITD/8", Format = "yyyyMMdd", Description = "ITD09 - Terms Deferred Due Date")]
        [EdiExtension(MinLength = 8, MaxLength = 8, Mandatory = false, EdiType = EdiType.Date)]
        public string TermsDeferredDueDate { get; set; }

        [EdiValue("9(10)", Format = "N2", Path = "ITD/9", Description = "ITD10 - Deferred Amount Due")]
        [EdiExtension(MinLength = 1, MaxLength = 10, Mandatory = false, EdiType = EdiType.Numeric)]
        public string DeferredAmountDue { get; set; }

        [EdiValue("9(5)", Format = "N2", Path = "ITD/10", Description = "ITD11 - Percent of Invoice Payable")]
        [EdiExtension(MinLength = 1, MaxLength = 5, Mandatory = false, EdiType = EdiType.Decimal)]
        public string PercentOfInvoicePayable { get; set; }

        [EdiValue("X(80)", Path = "ITD/11", Description = "ITD12 - Description")]
        [EdiExtension(MinLength = 1, MaxLength = 80, Mandatory = false, EdiType = EdiType.Alphanumeric)]
        public string Description { get; set; }

        [EdiValue("9(2)", Format = "N0", Path = "ITD/12", Description = "ITD13 - Day of Month")]
        [EdiExtension(MinLength = 1, MaxLength = 2, Mandatory = false, EdiType = EdiType.Numeric)]
        public string DayOfMonth { get; set; }

        [EdiValue("X(2)", Path = "ITD/13", Description = "ITD14 - Payment Method Code")]
        [EdiExtension(MinLength = 1, MaxLength = 2, Mandatory = false, EdiType = EdiType.Identifier)]
        [EdiAllowValue(AllowedValues = new string[] { "1", "2", "3", "4", "8", "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "AA", "AB", "AC", "AD", "AE", "AF", "AG" })]
        public string PaymentMethodCode { get; set; }

        [EdiValue("9(10)", Format = "R", Path = "ITD/14", Description = "ITD15 - Percent")]
        [EdiExtension(MinLength = 1, MaxLength = 10, Mandatory = false, EdiType = EdiType.Decimal)]
        public string Percent { get; set; }

        public List<ValidationResult> ValidateEdi(ITD model) {
            return new List<ValidationResult>();
        }
    }
}
