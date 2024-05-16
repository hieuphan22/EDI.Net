using Edi.Domain.Shared.Enums;
using indice.Edi.Serialization;
using Scm.Edi.Domain.Shared.Attributes;

namespace Edi.Application.Contracts.Poco.X12_4010.Segments
{
    [EdiSegment]
    [EdiPath("MSG")]
    public class MSG
    {
        [EdiValue("X(264)", Path = "MSG/0", Description = "MSG01 - Message Text")]
        [EdiExtension(MinLength = 1, MaxLength = 70, Mandatory = false, EdiType = EdiType.Alphanumeric)]
        public string FreeFormMessageText { get; set; }

        [EdiValue("X(2)", Path = "MSG/1", Description = "MSG02 - Printer Carriage Control Code")]
        [EdiExtension(MinLength = 2, MaxLength = 2, Mandatory = false, EdiType = EdiType.Identifier)]
        [EdiAllowValue(AllowedValues = new string[] { "AA", "AT", "DS", "LC", "NP", "NS", "SS" })]
        public string PrinterCarriageControlCode { get; set; }

        [EdiValue("X(9)", Format = "N0", Path = "MSG/2", Description = "MSG03 - Number")]
        [EdiExtension(MinLength = 1, MaxLength = 9, Mandatory = false, EdiType = EdiType.Numeric)]
        public string Number { get; set; }
    }
}
