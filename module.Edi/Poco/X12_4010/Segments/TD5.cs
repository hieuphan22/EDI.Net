using Edi.Domain.Shared.Attributes;
using Edi.Domain.Shared.Enums;
using indice.Edi.Serialization;

namespace module.Edi.Poco.X12_4010.Segments
{
    [EdiSegment]
    [EdiPath("TD5")]
    public class TD5
    {
        [EdiValue("X(2)", Path = "TD5/0", Description = "TD501 - Routing Sequence Code")]
        [EdiExtension(MinLength = 1, MaxLength = 2, Mandatory = false, EdiType = EdiType.Identifier)]
        [EdiAllowValue(AllowedValues = new string[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "A", "B", "D", "H", "I", "M", "O", "R", "S", "V", "X", "Z", "JD", "JO" })]

        public string RoutingSequenceCode { get; set; }

        [EdiValue("X(2)", Path = "TD5/1", Description = "TD502 - Identification Code Qualifier")]
        [EdiExtension(MinLength = 1, MaxLength = 2, Mandatory = false, EdiType = EdiType.Identifier)]
        [EdiAllowValue(AllowedValues = new string[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "A", "C", "D", "E", "F", "G", "I", "J", "K", "L", "N", "S", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36", "37", "38", "39", "40", "41", "42", "43", "44", "45", "46", "47", "48", "49", "50", "53", "54", "55", "56", "57", "58", "59", "61", "62", "63", "64", "71", "72", "73", "74", "75", "76", "77", "78", "81", "82", "90", "91", "92", "93", "94", "95", "96", "97", "98", "99", "A1", "A2", "A3", "A4", "A5", "A6", "AA", "AB", "AC", "AD", "AE", "AL", "AP", "BC", "BD", "BE", "BG", "BP", "BS", "C1", "C2", "C5", "CA", "CB", "CC", "CD", "CE", "CF", "CI", "CL", "CM", "CP", "CR", "CS", "CT", "DG", "DL", "DN", "DP", "DS", "EC", "EH", "EI", "EP", "EQ", "ER", "ES", "FA", "FB", "FC", "FD", "FI", "FJ", "FN", "GA", "GC", "HC", "HN", "LC", "LD", "LE", "LI", "LN", "M3", "M4", "M5", "M6", "MA", "MB", "MC", "MD", "MI", "MK", "ML", "MN", "MP", "MR", "NA", "ND", "NI", "NO", "OC", "OP", "PA", "PB", "PC", "PI", "PP", "PR", "RA", "RB", "RC", "RD", "RE", "RT", "SA", "SB", "SD", "SF", "SI", "SJ", "SL", "SP", "ST", "SV", "SW", "TA", "TC", "TZ", "UC", "UL", "UM", "UP", "UR", "US", "WR", "XV", "XX", "ZC", "ZN", "ZY", "ZZ" })]

        public string IdentificationCodeQualifier { get; set; }

        [EdiValue("X(80)", Path = "TD5/2", Description = "TD503 - Identification Code")]
        [EdiExtension(MinLength = 2, MaxLength = 80, Mandatory = false, EdiType = EdiType.Alphanumeric)]
        public string IdentificationCode { get; set; }

        [EdiValue("X(2)", Path = "TD5/3", Description = "TD504 - Transportation Method/Type Code")]
        [EdiExtension(MinLength = 1, MaxLength = 2, Mandatory = false, EdiType = EdiType.Identifier)]
        [EdiAllowValue(AllowedValues = new string[] { "6", "7", "A", "B", "C", "D", "E", "F", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "W", "X", "Y", "AC", "AE", "AF", "AH", "AR", "BP", "BU", "CE", "DA", "DW", "ED", "FA", "FL", "GG", "GR", "GS", "HH", "LA", "LT", "MB", "MP", "PA", "PG", "PL", "PP", "PR", "PT", "RC", "RR", "SB", "SC", "SD", "SE", "SR", "SS", "ST", "TA", "TC", "TT", "VA", "VE", "VL", "WP", "Y1", "Y2", "ZZ" })]

        public string TransportationMethodOrTypeCode { get; set; }

        [EdiValue("X(135)", Path = "TD5/4", Description = "TD505 - Routing")]
        [EdiExtension(MinLength = 1, MaxLength = 35, Mandatory = false, EdiType = EdiType.Alphanumeric)]
        public string Routing { get; set; }

        [EdiValue("X(2)", Path = "TD5/5", Description = "TD506 - Shipment Or Order Status Code")]
        [EdiExtension(MinLength = 2, MaxLength = 2, Mandatory = false, EdiType = EdiType.Identifier)]
        [EdiAllowValue(AllowedValues = new string[] { "AA", "AB", "AN", "AP", "AS", "AU", "AV", "BK", "BM", "BO", "BP", "BT", "BW", "CA", "CB", "CC", "CD", "CE", "CF", "CI", "CK", "CL", "CM", "CN", "CO", "CP", "CS", "CT", "CU", "DA", "DD", "DE", "DI", "DO", "DP", "DR", "DS", "EC", "ED", "EW", "EX", "FS", "HQ", "IC", "ID", "IN", "IP", "IS", "LM", "LS", "LW", "MC", "NF", "NN", "NS", "NY", "OB", "OF", "OP", "OR", "PA", "PC", "PD", "PH", "PI", "PK", "PL", "PN", "PO", "PP", "PR", "PS", "PT", "QN", "QP", "RC", "RD", "RI", "RT", "RW", "SA", "SB", "SC", "SD", "SE", "SF", "SG", "SH", "SI", "SJ", "SK", "SL", "SP", "SQ", "SS", "ST", "SU", "UB", "UN", "UR", "WS", "ZZ" })]

        public string ShipmentOrOrderStatusCode { get; set; }

        [EdiValue("X(2)", Path = "TD5/6", Description = "TD507 - Location Qualifier")]
        [EdiExtension(MinLength = 1, MaxLength = 2, Mandatory = false, EdiType = EdiType.Identifier)]
        [EdiAllowValue(AllowedValues = new string[] { "A", "B", "C", "D", "E", "F", "H", "I", "K", "L", "M", "O", "P", "W", "10", "11", "12", "13", "14", "18", "19", "20", "21", "22", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36", "38", "39", "40", "41", "42", "43", "44", "45", "46", "47", "48", "49", "50", "52", "53", "54", "55", "57", "58", "59", "60", "93", "94", "A1", "AA", "AC", "AP", "AR", "B1", "BE", "BL", "BS", "C2", "CA", "CB", "CC", "CD", "CE", "CI", "CL", "CO", "CR", "CS", "CY", "DC", "DE", "DL", "DO", "DP", "DR", "DT", "EA", "EL", "FA", "FE", "FF", "FI", "FR", "FS", "FT", "FV", "GL", "IA", "IB", "IM", "IP", "IS", "IT", "KE", "KL", "KP", "LO", "MI", "MS", "MZ", "NS", "OA", "OF", "OL", "OP", "OR", "OV", "PA", "PB", "PC", "PD", "PE", "PF", "PG", "PH", "PL", "PO", "PP", "PQ", "PR", "PS", "PT", "PU", "RA", "RC", "RE", "RG", "RJ", "RL", "RS", "RT", "SA", "SB", "SC", "SD", "SE", "SG", "SH", "SL", "SN", "SP", "SS", "ST", "SW", "TA", "TC", "TL", "TM", "TN", "TP", "TR", "TX", "UN", "UR", "UT", "VA", "VI", "VS", "WF", "WH", "WI", "ZN", "ZZ" })]

        public string LocationQualifier { get; set; }

        [EdiValue("X(30)", Path = "TD5/7", Description = "TD508 - Location Identifier")]
        [EdiExtension(MinLength = 1, MaxLength = 30, Mandatory = false, EdiType = EdiType.Alphanumeric)]
        public string LocationIdentifier { get; set; }

        [EdiValue("X(2)", Path = "TD5/8", Description = "TD509 - Transit Direction Code")]
        [EdiExtension(MinLength = 2, MaxLength = 2, Mandatory = false, EdiType = EdiType.Identifier)]
        [EdiAllowValue(AllowedValues = new string[] { "BS", "SB", "SC", "SD", "SF", "SS", "ZZ" })]

        public string TransitDirectionCode { get; set; }

        [EdiValue("X(2)", Path = "TD5/9", Description = "TD510 - Transit Time Direction Qualifier")]
        [EdiExtension(MinLength = 2, MaxLength = 2, Mandatory = false, EdiType = EdiType.Identifier)]
        [EdiAllowValue(AllowedValues = new string[] { "AA", "AD", "CD", "CW", "HO", "SD", "SH", "WD", "WW", "ZZ" })]

        public string TransitTimeDirectionQualifier { get; set; }

        [EdiValue("X(4)", Path = "TD5/10", Format = "R", Description = "TD511 - TransitTime")]
        [EdiExtension(MinLength = 1, MaxLength = 4, Mandatory = false, EdiType = EdiType.Decimal)]
        public string TransitTime { get; set; }

        [EdiValue("X(2)", Path = "TD5/11", Description = "TD512 - Service Level Code")]
        [EdiExtension(MinLength = 2, MaxLength = 2, Mandatory = false, EdiType = EdiType.Identifier)]
        [EdiAllowValue(AllowedValues = new string[] { "01", "09", "3D", "9A", "AC", "AE", "AM", "BC", "CB", "CE", "CG", "CX", "D1", "D2", "D3", "DC", "DF", "DR", "DS", "DT", "ES", "ET", "FC", "G2", "GP", "GT", "IA", "IE", "IX", "ME", "MW", "ND", "NF", "NH", "NM", "NS", "ON", "PA", "PB", "PC", "PI", "PM", "PN", "PO", "PR", "PS", "R1", "R2", "R3", "R4", "R5", "R6", "R7", "R8", "RS", "SA", "SC", "SD", "SE", "SG", "SH", "SI", "SM", "SP", "ST", "ZZ" })]

        public string ServiceLevelCode { get; set; }

        [EdiValue("X(2)", Path = "TD5/12", Description = "TD513 - Service Level Code")]
        [EdiExtension(MinLength = 2, MaxLength = 2, Mandatory = false, EdiType = EdiType.Identifier)]
        [EdiAllowValue(AllowedValues = new string[] { "01", "09", "3D", "9A", "AC", "AE", "AM", "BC", "CB", "CE", "CG", "CX", "D1", "D2", "D3", "DC", "DF", "DR", "DS", "DT", "ES", "ET", "FC", "G2", "GP", "GT", "IA", "IE", "IX", "ME", "MW", "ND", "NF", "NH", "NM", "NS", "ON", "PA", "PB", "PC", "PI", "PM", "PN", "PO", "PR", "PS", "R1", "R2", "R3", "R4", "R5", "R6", "R7", "R8", "RS", "SA", "SC", "SD", "SE", "SG", "SH", "SI", "SM", "SP", "ST", "ZZ" })]
        public string ServiceLevelCode02 { get; set; }

        [EdiValue("X(2)", Path = "TD5/13", Description = "TD514 - Service Level Code")]
        [EdiExtension(MinLength = 2, MaxLength = 2, Mandatory = false, EdiType = EdiType.Identifier)]
        [EdiAllowValue(AllowedValues = new string[] { "01", "09", "3D", "9A", "AC", "AE", "AM", "BC", "CB", "CE", "CG", "CX", "D1", "D2", "D3", "DC", "DF", "DR", "DS", "DT", "ES", "ET", "FC", "G2", "GP", "GT", "IA", "IE", "IX", "ME", "MW", "ND", "NF", "NH", "NM", "NS", "ON", "PA", "PB", "PC", "PI", "PM", "PN", "PO", "PR", "PS", "R1", "R2", "R3", "R4", "R5", "R6", "R7", "R8", "RS", "SA", "SC", "SD", "SE", "SG", "SH", "SI", "SM", "SP", "ST", "ZZ" })]
        public string ServiceLevelCode03 { get; set; }

        [EdiValue("X(3)", Path = "TD5/14", Description = "TD515 - Country Code")]
        [EdiExtension(MinLength = 2, MaxLength = 3, Mandatory = false, EdiType = EdiType.Identifier)]
        [EdiAllowValue(AllowedValues = new string[] { "US", "CA", "VN" })]

        public string CountryCode { get; set; }
    }
}