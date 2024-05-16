using Edi.Domain.Shared.Enums;
using indice.Edi.Serialization;
using Scm.Edi.Domain.Shared.Attributes;
namespace Edi.Application.Contracts.Poco.X12_4010.Segments
{
    [EdiSegment]
    [EdiPath("ADV")]
    public class ADV
    {
        [EdiValue("X(2)", Path = "ADV/0", Description = "ADV01 - Agency Qualifier Code")]
        [EdiExtension(MinLength = 2, MaxLength = 2, Mandatory = true, EdiType = EdiType.Identifier)]
        [EdiAllowValue(AllowedValues = new string[] { "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36", "37", "38", "39", "40", "41", "42", "43", "44", "45", "46", "47", "48", "49", "50", "51", "52", "53", "54", "55", "56", "57", "58", "59", "60", "93", "94", "A1", "A2", "A3", "A4", "AA", "AB", "AC", "AD", "AE", "AG", "AH", "AI", "AJ", "AL", "AM", "AP", "AQ", "AS", "AT", "AW", "AX", "AY", "BE", "BF", "BI", "CA", "CB", "CC", "CE", "CI", "CL", "CM", "CO", "CR", "CS", "CU", "CX", "DA", "DD", "DE", "DF", "DI", "DL", "DN", "DO", "DR", "DS", "DX", "DY", "DZ", "EI", "EP", "ES", "ET", "EU", "EX", "FA", "FC", "FD", "FG", "FH", "FI", "GC", "GS", "GU", "HC", "HI", "HS", "HU", "IA", "IB", "IC", "IM", "IN", "IS", "JA", "LA", "LB", "LI", "MA", "MB", "MC", "ME", "MI", "MP", "MS", "MV", "NA", "NB", "NC", "NE", "NF", "NG", "NI", "NR", "NS", "NT", "NU", "NW", "OI", "OP", "OS", "PA", "PC", "SA", "SE", "SL", "SP", "ST", "TA", "TB", "TC", "TD", "TI", "TM", "TP", "TR", "TX", "UC", "UN", "VI", "WH", "ZZ" })]
        public string AgencyQualifierCode { get; set; }

        [EdiValue("X(2)", Path = "ADV/1", Description = "ADV02 - Service Characteristics Qualifier")]
        [EdiExtension(MinLength = 2, MaxLength = 2, Mandatory = true, EdiType = EdiType.Alphanumeric)]
        public string ServiceCharacteristicsQualifier { get; set; }

        [EdiValue("X(20)", Path = "ADV/2", Description = "ADV03 - Range Minimum")]
        [EdiExtension(MinLength = 1, MaxLength = 20, Mandatory = false, EdiType = EdiType.Decimal)]
        public string RangeMinimum { get; set; }

        [EdiValue("X(20)", Path = "ADV/3", Description = "ADV04 - Range Maximum")]
        [EdiExtension(MinLength = 1, MaxLength = 20, Mandatory = false, EdiType = EdiType.Decimal)]
        public string RangeMaximum { get; set; }

        [EdiValue("X(6)", Path = "ADV/4", Description = "ADV05 - Category")]
        [EdiExtension(MinLength = 1, MaxLength = 6, Mandatory = false, EdiType = EdiType.Alphanumeric)]
        public string Category { get; set; }

        [EdiValue("X(2)", Path = "ADV/5", Description = "ADV06 - Service Characteristics Qualifier")]
        [EdiExtension(MinLength = 2, MaxLength = 2, EdiType = EdiType.Alphanumeric)]
        public string ServiceCharacteristicsQualifier02 { get; set; }

        [EdiValue("X(20)", Path = "ADV/6", Description = "ADV07 - Measurement Value")]
        [EdiExtension(MinLength = 1, MaxLength = 20, EdiType = EdiType.Decimal)]
        public string MeasurementValue { get; set; }
    }
}
