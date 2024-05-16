using Edi.Domain.Shared.Attributes;
using Edi.Domain.Shared.Enums;
using indice.Edi.Serialization;
using Scm.Edi.Domain.Shared.Attributes;

namespace Edi.Domain.Shared.Poco.X12_4010.Segments
{
    [EdiSegment]
    [EdiPath("FA2")]
    public class FA2
    {
        [EdiValue("X(2)", Path = "FA2/0", Description = "FA201 - Breakdown Structure Detail Code")]
        [EdiExtension(MinLength = 2, MaxLength = 2, Mandatory = true, EdiType = EdiType.Identifier)]
        [EdiAllowValue(AllowedValues = new string[] { "01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36", "37", "38", "39", "40", "41", "42", "43", "44", "45", "46", "47", "48", "49", "50", "51", "52", "53", "54", "55", "56", "57", "58", "59", "60", "61", "62", "63", "64", "65", "66", "67", "70", "71", "72", "73", "74", "75", "77", "78", "79", "80", "81", "82", "83", "84", "85", "86", "87", "88", "A1", "A2", "A3", "A4", "A5", "A6", "A7", "A8", "A9", "AT", "B1", "B2", "B3", "B4", "B5", "BL", "BY", "C1", "C2", "C3", "C4", "CM", "CY", "D1", "D2", "D3", "D4", "D5", "D6", "D7", "E1", "E2", "E3", "E4", "EH", "ES", "EX", "F1", "F2", "F3", "F4", "FE", "FP", "FR", "G1", "G2", "G3", "G4", "G5", "H1", "H2", "H3", "H4", "H5", "I1", "IN", "J1", "J2", "K6", "L1", "LM", "M1", "MD", "MR", "N1", "NP", "P1", "P2", "P3", "P4", "P5", "P6", "RL", "SC", "TA", "TC", "TD", "TR", "TU", "UB", "ZZ" })]
        public string BreakdownStructureDetailCode { get; set; }

        [EdiValue("X(80)", Path = "FA2/1", Description = "FA202 - Financial Information Code")]
        [EdiExtension(MinLength = 1, MaxLength = 80, Mandatory = true, EdiType = EdiType.Alphanumeric)]
        public string FinancialInformationCode { get; set; }
    }
}
