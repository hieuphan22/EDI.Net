using Edi.Domain.Shared.Enums;
using indice.Edi.Serialization;
using Scm.Edi.Domain.Shared.Attributes;

namespace Edi.Application.Contracts.Poco.X12_4010.Segments
{
    /// <summary>
    /// Allowance or Charge
    /// </summary>
    [EdiSegment]
    [EdiPath("G72")]
    public class G72
    {
        [EdiValue("X(3)", Path = "G72/0", Description = "G7201 - Allowance or Charge Code")]
        [EdiExtension(MinLength = 1, MaxLength = 3, Mandatory = false, EdiType = EdiType.Identifier)]
        public string AllowanceOrChargeCode { get; set; }

        [EdiValue("X(2)", Path = "G72/1", Description = "G7202 - Allowance or Charge Method of Handling Code")]
        [EdiExtension(MinLength = 2, MaxLength = 2, Mandatory = false, EdiType = EdiType.Identifier)]
        public string AllowanceOrChargeMethodOfHandlingCode { get; set; }

        [EdiValue("X(16)", Path = "G72/2", Description = "G7203 - Allowance or Charge Number")]
        [EdiExtension(MinLength = 1, MaxLength = 16, EdiType = EdiType.Alphanumeric)]
        public string AllowanceOrChargeNumber { get; set; }

        [EdiValue("X(16)", Path = "G72/3", Description = "G7204 - Exception Number")]
        [EdiExtension(MinLength = 1, MaxLength = 16, EdiType = EdiType.Alphanumeric)]
        public string ExceptionNumber { get; set; }

        [EdiValue("X(5)", Path = "G72/4", Format = "R", Description = "G7205 - Allowance or Charge Rate")]
        [EdiExtension(MinLength = 1, MaxLength = 5, EdiType = EdiType.Decimal)]
        public string AllowanceOrChargeRate { get; set; }

        [EdiValue("X(10)", Path = "G72/5", Format = "R", Description = "G7206 - Allowance or Charge Quantity")]
        [EdiExtension(MinLength = 1, MaxLength = 10, EdiType = EdiType.Decimal)]
        public string AllowanceOrChargeQuantity { get; set; }

        [EdiValue("X(2)", Path = "G72/6", Description = "G7207 - Unit or Basis for Measurement Code")]
        [EdiExtension(MinLength = 2, MaxLength = 2, EdiType = EdiType.Identifier)]
        public string UnitOrBasisForMeasurementCode { get; set; }

        [EdiValue("X(15)", Format = "N2", Path = "G72/7", Description = "G7208 - Allowance or Charge Total Amount")]
        [EdiExtension(MinLength = 1, MaxLength = 15, EdiType = EdiType.Numeric)]
        public string AllowanceOrChargeTotalAmount { get; set; }

        [EdiValue("X(6)", Path = "G72/8", Format = "R", Description = "G7209 - Percent")]
        [EdiExtension(MinLength = 1, MaxLength = 6, EdiType = EdiType.Decimal)]
        public string Percent { get; set; }

        [EdiValue("X(9)", Path = "G72/9", Format = "R", Description = "G7210 - Dollar Basis For Percent")]
        [EdiExtension(MinLength = 1, MaxLength = 9, EdiType = EdiType.Decimal)]
        public string DollarBasisForPercent { get; set; }

        [EdiValue("X(20)", Path = "G72/10", Description = "G7211 - Option Number")]
        [EdiExtension(MinLength = 1, MaxLength = 20, EdiType = EdiType.Alphanumeric)]
        public string OptionNumber { get; set; }
    }
}
