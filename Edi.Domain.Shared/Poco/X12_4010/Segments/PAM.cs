using Edi.Domain.Shared.Attributes;
using Edi.Domain.Shared.Enums;
using indice.Edi.Serialization;
using Scm.Edi.Domain.Shared.Attributes;

namespace Edi.Domain.Shared.Poco.X12_4010.Segments
{
    [EdiSegment]
    [EdiPath("PAM")]
    public class PAM
    {
        [EdiValue("X(2)", Path = "PAM/0", Description = "PAM01 - Quantity Qualifier")]
        [EdiExtension(MinLength = 2, MaxLength = 2, EdiType = EdiType.Alphanumeric)]
        [EdiAllowValue(AllowedValues = new string[] { "01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "1A", "1B", "1C", "1D", "1E", "1F", "1G", "1H", "1I", "1J", "1K", "1L", "1M", "1N", "1O", "1P", "1Q", "1R", "1S", "1T", "1U", "1V", "1W", "1X", "1Y", "1Z", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "2A", "2B", "2C", "2D", "2E", "2F", "2G", "2H", "2I", "2J", "2K", "2L", "2M", "2N", "2O", "2P", "2Q", "2R", "2S", "2T", "2U", "2V", "2W", "2X", "2Y", "2Z", "30", "31", "32", "33", "34", "35", "36", "37", "38", "39", "3A", "3B", "3C", "3D", "3E", "3F", "3G", "3H", "3I", "3J", "3K", "3L", "3M", "3N", "3P", "3Q", "3R", "3S", "3T", "3U", "3V", "3W", "3X", "3Y", "40", "41", "42", "43", "45", "46", "47", "48", "49", "4A", "4B", "4C", "4D", "4E", "4F", "4G", "4H", "4I", "4J", "4K", "4L", "4M", "4N", "4O", "4P", "4Q", "4R", "4S", "4T", "4U", "50", "51", "52", "53", "54", "55", "56", "57", "58", "5A", "5B", "5C", "5D", "5E", "5F", "5G", "5H", "5I", "5J", "5K", "5L", "5M", "5N", "5O", "5P", "5Q", "5R", "5S", "5T", "5U", "5V", "5W", "5X", "5Y", "5Z", "60", "61", "62", "63", "64", "65", "66", "67", "68", "69", "6A", "6B", "6C", "6D", "6E", "6F", "6G", "6H", "6I", "6J", "6K", "6L", "6M", "6N", "6O", "6P", "6Q", "6R", "6S", "6T", "6U", "6V", "6W", "6X", "6Z", "70", "72", "73", "74", "75", "76", "77", "78", "79", "7A", "7B", "7C", "7D", "7E", "7F", "7G", "7H", "7I", "7J", "7K", "7L", "7M", "7N", "7O", "7P", "7Q", "7R", "7S", "7T", "7U", "7V", "7W", "7X", "7Y", "7Z", "80", "81", "82", "83", "84", "85", "86", "87", "88", "89", "8A", "8B", "8C", "8D", "8E", "8F", "8G", "8H", "8I", "8J", "8K", "8L", "8M", "8N", "8O", "8P", "8Q", "8R", "8S", "90", "91", "92", "93", "94", "95", "96", "97", "98", "99", "9A", "9C", "9D", "9E", "9F", "9H", "9J", "9K", "9L", "9M", "9N", "A1", "A2", "A3", "A4", "A5", "A6", "A7", "A8", "A9", "AA", "AB", "AC", "AD", "AE", "AF", "AG", "AH", "AI", "AJ", "AK", "AL", "AN", "AO", "AP", "AQ", "AR", "AS", "AT", "AU", "AV", "AW", "AX", "AY", "AZ", "B1", "B2", "B3", "B4", "B5", "B6", "B7", "B8", "BA", "BB", "BC", "BD", "BE", "BF", "BG", "BH", "BI", "BJ", "BK", "BQ", "BR", "BW", "C0", "CA", "CB", "CC", "CD", "CE", "CF", "CG", "CH", "CI", "CL", "CN", "CO", "CP", "CR", "CS", "CW", "CY", "CZ", "D1", "D3", "DA", "DB", "DC", "DD", "DE", "DF", "DG", "DI", "DN", "DO", "DP", "DR", "DS", "DT", "DY", "E1", "E2", "E3", "E4", "E5", "EA", "EB", "EC", "ED", "EE", "EM", "EP", "EQ", "ER", "ES", "ET", "EW", "F1", "FA", "FB", "FC", "FD", "FE", "FF", "FG", "FH", "FI", "FJ", "FK", "FL", "FM", "FR", "FS", "FT", "GA", "GB", "GC", "GE", "GF", "GI", "GL", "GP", "GQ", "GR", "GS", "GT", "GU", "GV", "GW", "GX", "GZ", "HA", "HB", "HC", "HD", "HE", "HF", "HG", "HH", "HI", "HJ", "HK", "HL", "HM", "HN", "HO", "HP", "HR", "HS", "II", "IN", "IP", "IQ", "IS", "IT", "JA", "JB", "JC", "JD", "JE", "JF", "JG", "JH", "JI", "JJ", "JK", "JL", "JM", "JN", "JO", "JP", "JQ", "JR", "JS", "JT", "K6", "KA", "KB", "KC", "KD", "KE", "KF", "KG", "KH", "KI", "KJ", "KK", "KL", "KM", "KN", "KO", "KP", "KQ", "KR", "KS", "KU", "KV", "KW", "KX", "KY", "KZ", "L2", "L3", "L4", "L5", "L6", "L7", "LA", "LB", "LC", "LE", "LG", "LH", "LI", "LK", "LL", "LM", "LN", "LO", "LP", "LQ", "LR", "LS", "LT", "LV", "LW", "LX", "LY", "M1", "M2", "MA", "MD", "ME", "MF", "MI", "MM", "MN", "MO", "MQ", "MX", "N1", "N2", "N3", "N4", "N5", "N6", "NA", "NB", "NC", "ND", "NE", "NF", "NG", "NL", "NN", "NO", "NP", "NQ", "NR", "NS", "NT", "NU", "NV", "NW", "OC", "OD", "OF", "OG", "OH", "OI", "OL", "ON", "OO", "OR", "OT", "OU", "OV", "OW", "P1", "P3", "P4", "P5", "P6", "P7", "P8", "P9", "PA", "PB", "PC", "PD", "PE", "PF", "PG", "PK", "PL", "PO", "PP", "PQ", "PR", "PS", "PT", "PW", "PX", "Q1", "Q2", "Q3", "Q4", "QA", "QB", "QC", "QD", "QE", "QF", "QH", "QI", "QJ", "QL", "QM", "QN", "QO", "QP", "QQ", "QR", "QS", "QU", "QV", "QW", "QX", "R3", "R5", "R6", "R9", "RA", "RB", "RC", "RD", "RE", "RF", "RG", "RH", "RJ", "RL", "RM", "RN", "RQ", "RS", "RT", "RW", "RY", "S1", "S2", "S3", "S4", "S5", "S6", "S7", "S8", "S9", "SA", "SB", "SC", "SD", "SE", "SF", "SG", "SH", "SI", "SJ", "SK", "SL", "SM", "SN", "SO", "SP", "SQ", "SR", "SS", "ST", "SU", "SV", "SW", "SX", "SY", "T1", "T2", "T3", "T4", "T5", "T6", "T7", "TA", "TB", "TC", "TD", "TE", "TG", "TH", "TI", "TJ", "TK", "TM", "TN", "TO", "TP", "TR", "TS", "TT", "TU", "TV", "TW", "TX", "TY", "UA", "UG", "UL", "UO", "US", "UU", "V1", "V2", "V3", "V4", "V5", "VA", "VB", "VC", "VD", "VE", "VF", "VG", "VH", "VI", "VJ", "VK", "VL", "VM", "VN", "VP", "VR", "VS", "VT", "VV", "VY", "WA", "WB", "WC", "WD", "WE", "WG", "WL", "WO", "WP", "WR", "WT", "WV", "WW", "WX", "WY", "X1", "XA", "XB", "XC", "XD", "XE", "XG", "XI", "XJ", "XL", "XN", "XO", "XT", "XU", "XV", "XX", "XY", "XZ", "YA", "YB", "YC", "YD", "YE", "YF", "YG", "YH", "YJ", "YK", "YL", "YM", "YN", "YP", "YQ", "YR", "YS", "YT", "YW", "YX", "YY", "Z1", "Z2", "Z3", "Z4", "Z6", "ZA", "ZB", "ZC", "ZD", "ZE", "ZF", "ZG", "ZH", "ZI", "ZJ", "ZK", "ZL", "ZM", "ZN", "ZO", "ZP", "ZR", "ZS" })]

        public string QuantityQualifier { get; set; }

        [EdiValue("X(15)", Path = "PAM/1", Description = "PAM02 - Quantity")]
        [EdiExtension(MinLength = 1, MaxLength = 15, EdiType = EdiType.Decimal)]
        public string Quantity { get; set; }

        //[EdiValue("X(3)", Path = "PAM/2", Description = "PAM03 - Composite Unit of Measure")]
        //[EdiExtension(MinLength = 1, MaxLength = 3, EdiType = EdiType.Identifier)]
        //public string CompositeUnitOfMeasure { get; set; }

        [EdiValue("X(3)", Path = "PAM/3", Description = "PAM04 - Amount Qualifier Code")]
        [EdiExtension(MinLength = 1, MaxLength = 3, EdiType = EdiType.Identifier)]
        public string AmountQualifierCode { get; set; }

        [EdiValue("X(18)", Path = "PAM/4", Description = "PAM05 - Monetary Amount")]
        [EdiExtension(MinLength = 1, MaxLength = 18, EdiType = EdiType.Decimal)]
        public string MonetaryAmount { get; set; }

        [EdiValue("X(2)", Path = "PAM/5", Description = "PAM06 - Unit of Time Period or Interval")]
        [EdiExtension(MinLength = 2, MaxLength = 2, EdiType = EdiType.Alphanumeric)]
        public string UnitOfTimePeriodOrInterval { get; set; }

        [EdiValue("X(3)", Path = "PAM/6", Description = "PAM07 - Date/Time Qualifier")]
        [EdiExtension(MinLength = 3, MaxLength = 3, EdiType = EdiType.Identifier)]
        public string DateOrTimeQualifier { get; set; }

        [EdiValue("X(8)", Path = "PAM/7", Description = "PAM08 - Date")]
        [EdiExtension(MinLength = 8, MaxLength = 8, EdiType = EdiType.Date)]
        public string Date { get; set; }

        [EdiValue("X(4)", Path = "PAM/8", Description = "PAM09 - Time")]
        [EdiExtension(MinLength = 8, MaxLength = 4, EdiType = EdiType.Time)]
        public string Time { get; set; }

        [EdiValue("X(3)", Path = "PAM/9", Description = "PAM10 - Date/Time Qualifier")]
        [EdiExtension(MinLength = 3, MaxLength = 3, EdiType = EdiType.Identifier)]
        public string DateOrTimeQualifier02 { get; set; }

        [EdiValue("X(8)", Path = "PAM/10", Description = "PAM110 - Date")]
        [EdiExtension(MinLength = 8, MaxLength = 8, EdiType = EdiType.Date)]
        public string Date02 { get; set; }

        [EdiValue("X(4)", Path = "PAM/11", Description = "PAM12 - Time")]
        [EdiExtension(MinLength = 8, MaxLength = 4, EdiType = EdiType.Time)]
        public string Time02 { get; set; }

        [EdiValue("X(2)", Path = "PAM/12", Description = "PAM13 - Percent Qualifier")]
        [EdiExtension(MinLength = 1, MaxLength = 2, EdiType = EdiType.Identifier)]
        public string PercentQualifier { get; set; }

        [EdiValue("X(10)", Path = "PAM/13", Description = "PAM14 - Percent")]
        [EdiExtension(MinLength = 1, MaxLength = 10, EdiType = EdiType.Decimal)]
        public string Percent { get; set; }

        [EdiValue("X(1)", Path = "PAM/14", Description = "PAM15 - Yes/No Condition or Response Code")]
        [EdiExtension(MinLength = 1, MaxLength = 1, Mandatory = false, EdiType = EdiType.Identifier)]
        public string YesOrNoConditionOrResponseCode { get; set; }
    }
}