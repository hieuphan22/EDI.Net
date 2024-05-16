using Edi.Domain.Shared.Enums;
using indice.Edi.Serialization;
using Scm.Edi.Domain.Shared.Attributes;

namespace Edi.Application.Contracts.Poco.X12_4010.Segments
{
    [EdiSegment]
    [EdiPath("PKG")]
    public class PKG
    {
        [EdiValue("X(1)", Path = "PKG/0", Description = "PKG01 - Item Description Type")]
        [EdiExtension(MinLength = 1, MaxLength = 1, Mandatory = false, EdiType = EdiType.Identifier)]
        [EdiAllowValue(AllowedValues = new string[] { "F", "S", "X" })]

        public string ItemDescriptionType { get; set; }

        [EdiValue("X(5)", Path = "PKG/1", Description = "PKG02 - Packaging Characteristic Code")]
        [EdiExtension(MinLength = 1, MaxLength = 5, Mandatory = false, EdiType = EdiType.Identifier)]
        [EdiAllowValue(AllowedValues = new string[] { "01", "10", "11", "12", "13", "34", "35", "36", "37", "38", "39", "40", "42", "43", "44", "45", "60", "61", "62", "63", "65", "66", "67", "68", "CB", "CC", "CD", "CS", "CT", "HM", "IC", "IP", "LP", "PK", "PM", "PN", "UC", "UP", "WM", "CUD", "OPI", "PML", "SMK", "UCL" })]

        public string PackagingCharacteristicCode { get; set; }

        [EdiValue("X(2)", Path = "PKG/2", Description = "PKG03 - Agency Qualifier Code")]
        [EdiExtension(MinLength = 2, MaxLength = 2, Mandatory = false, EdiType = EdiType.Identifier)]
        [EdiAllowValue(AllowedValues = new string[] { "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36", "37", "38", "39", "40", "41", "42", "43", "44", "45", "46", "47", "48", "49", "50", "51", "52", "53", "54", "55", "56", "57", "58", "59", "60", "93", "94", "A1", "A2", "A3", "A4", "AA", "AB", "AC", "AD", "AE", "AG", "AH", "AI", "AJ", "AL", "AM", "AP", "AQ", "AS", "AT", "AW", "AX", "AY", "BE", "BF", "BI", "CA", "CB", "CC", "CE", "CI", "CL", "CM", "CO", "CR", "CS", "CU", "CX", "DA", "DD", "DE", "DF", "DI", "DL", "DN", "DO", "DR", "DS", "DX", "DY", "DZ", "EI", "EP", "ES", "ET", "EU", "EX", "FA", "FC", "FD", "FG", "FH", "FI", "GC", "GS", "GU", "HC", "HI", "HS", "HU", "IA", "IB", "IC", "IM", "IN", "IS", "JA", "LA", "LB", "LI", "MA", "MB", "MC", "ME", "MI", "MP", "MS", "MV", "NA", "NB", "NC", "NE", "NF", "NG", "NI", "NR", "NS", "NT", "NU", "NW", "OI", "OP", "OS", "PA", "PC", "SA", "SE", "SL", "SP", "ST", "TA", "TB", "TC", "TD", "TI", "TM", "TP", "TR", "TX", "UC", "UN", "VI", "WH", "ZZ" })]

        public string AgencyQualifierCode { get; set; }

        [EdiValue("X(7)", Path = "PKG/3", Description = "PKG04 - Packaging Description Code")]
        [EdiExtension(MinLength = 1, MaxLength = 7, Mandatory = false, EdiType = EdiType.Alphanumeric)]
        public string PackagingDescriptionCode { get; set; }

        [EdiValue("X(80)", Path = "PKG/4", Description = "PKG05 - Description")]
        [EdiExtension(MinLength = 1, MaxLength = 80, Mandatory = false, EdiType = EdiType.Alphanumeric)]
        public string Description { get; set; }

        [EdiValue("X(2)", Path = "PKG/5", Description = "PKG06 - Unit Load Option Code")]
        [EdiExtension(MinLength = 2, MaxLength = 2, Mandatory = false, EdiType = EdiType.Identifier)]
        [EdiAllowValue(AllowedValues = new string[] { "01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "ZZ" })]

        public string UnitLoadOptionCode { get; set; }
    }
}
