using Edi.Domain.Shared.Enums;
using indice.Edi.Serialization;
using Scm.Edi.Domain.Shared.Attributes;
namespace Edi.Application.Contracts.Poco.X12_4010.Segments
{
    [EdiSegment]
    [EdiPath("PO3")]
    public class PO3
    {
        [EdiValue("X(2)", Path = "PO3/0", Description = "PO301 - Change Reason Code")]
        [EdiExtension(MinLength = 2, MaxLength = 2, Mandatory = true, EdiType = EdiType.Identifier)]
        [EdiAllowValue(AllowedValues = new string[] { "AQ", "BB", "BD", "C1", "C2", "C3", "C4", "C5", "C6", "DC", "EV", "FE", "GU", "GW", "LD", "MC", "MP", "PC", "PQ", "PS", "QH", "QO", "QP", "QT", "SC", "UM", "UP", "WD", "WO", "ZZ" })]
        public string ChangeReasonCode { get; set; }

        [EdiValue("X(8)", Path = "PO3/1", Description = "PO302 - Date")]
        [EdiExtension(MinLength = 8, MaxLength = 8, Mandatory = false, EdiType = EdiType.Date)]
        public string Date { get; set; }

        [EdiValue("X(3)", Path = "PO3/2", Description = "PO303 - Price Identifier Code")]
        [EdiExtension(MinLength = 3, MaxLength = 3, EdiType = EdiType.Identifier)]
        [EdiAllowValue(AllowedValues = new string[] { "ACT", "AGC", "ALT", "AWP", "BBP", "BCH", "C01", "C02", "C03", "C04", "C05", "C06", "C07", "C08", "C09", "C10", "C11", "C12", "C13", "C14", "C15", "C16", "C17", "C18", "C19", "C20", "C21", "C22", "C23", "C24", "C25", "C26", "C27", "C28", "C29", "C30", "CAN", "CAT", "CDF", "CDV", "CHG", "CON", "CUP", "CUS", "D01", "D02", "D03", "DAP", "DIS", "DPR", "DSC", "DSD", "DSP", "EDM", "EDP", "EDS", "EDW", "ELC", "EST", "EUP", "FCH", "FCP", "FDS", "FET", "FGP", "FSP", "FUL", "FUP", "GAP", "GDP", "GOV", "GSP", "GTP", "ICL", "IND", "INS", "INV", "LAR", "LPP", "LPR", "MAP", "MAS", "MAX", "MIN", "MNC", "MNR", "MOD", "MPR", "MSR", "MXR", "N01", "N02", "N03", "N04", "N05", "N06", "N07", "N08", "N09", "N10", "N11", "N12", "N13", "N14", "N15", "N16", "N17", "N18", "N19", "N20", "N21", "N22", "N23", "N24", "N25", "N26", "N27", "N28", "N29", "N30", "N31", "NET", "OAP", "OPP", "PAP", "PAQ", "PBQ", "PBR", "PHS", "PIE", "PLT", "PPA", "PPD", "PRF", "PRO", "PRP", "PUR", "QTE", "REG", "RES", "RPA", "RPM", "RPP", "RSH", "RTL", "SAC", "SDP", "SFP", "SHD", "SLP", "SPC", "SPE", "STA", "SUM", "SWP", "THP", "TOT", "TRF", "UCP", "ULC", "WAR", "WHL", "WSP", "ZNP" })]

        public string PriceIdentifierCode { get; set; }

        [EdiValue("X(17)", Path = "PO3/3", Description = "PO304 - Unit Price")]
        [EdiExtension(MinLength = 1, MaxLength = 17, Mandatory = false, EdiType = EdiType.Decimal)]
        public string UnitPrice { get; set; }

        [EdiValue("X(2)", Path = "PO3/4", Description = "PO305 - Basis of Unit Price Code")]
        [EdiExtension(MinLength = 2, MaxLength = 2, EdiType = EdiType.Identifier)]
        [EdiAllowValue(AllowedValues = new string[] { "AA", "AB", "AP", "AW", "BD", "BR", "BW", "CA", "CP", "CR", "CT", "DI", "DP", "DR", "DS", "EC", "EH", "ES", "FB", "FO", "FX", "HF", "HP", "HT", "KA", "KP", "KR", "LC", "LD", "LE", "LM", "LR", "ME", "ML", "NC", "NE", "NQ", "NS", "NT", "PA", "PB", "PD", "PE", "PF", "PG", "PK", "PL", "PM", "PN", "PO", "PP", "PQ", "PR", "PS", "PT", "PU", "PV", "PY", "QE", "QH", "QR", "QS", "QT", "RC", "RD", "RE", "RM", "RS", "RT", "SA", "SC", "SM", "SR", "ST", "SW", "TB", "TC", "TD", "TE", "TF", "TM", "TP", "TT", "UM", "VQ", "WC", "WD", "WE", "WH", "WI", "WM" })]

        public string BasisOfUnitPriceCode { get; set; }

        [EdiValue("X(15)", Path = "PO3/5", Description = "PO306 - Quantity")]
        [EdiExtension(MinLength = 1, MaxLength = 15, Mandatory = true, EdiType = EdiType.Decimal)]
        public string Quantity { get; set; }

        [EdiValue("X(2)", Path = "PO3/6", Description = "PO307 - Unit or Basis for Measurement Code")]
        [EdiExtension(MinLength = 2, MaxLength = 2, Mandatory = true, EdiType = EdiType.Identifier)]
        [EdiAllowValue(AllowedValues = new string[] { "01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "1A", "1B", "1C", "1D", "1E", "1F", "1G", "1H", "1I", "1J", "1K", "1L", "1M", "1N", "1O", "1P", "1Q", "1R", "1X", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "2A", "2B", "2C", "2F", "2G", "2H", "2I", "2J", "2K", "2L", "2M", "2N", "2P", "2Q", "2R", "2U", "2V", "2W", "2X", "2Y", "2Z", "30", "31", "32", "33", "34", "35", "36", "37", "38", "39", "3B", "3C", "3E", "3F", "3G", "3H", "3I", "40", "41", "43", "44", "45", "46", "47", "48", "4A", "4B", "4C", "4D", "4E", "4F", "4G", "4H", "4I", "4J", "4K", "4L", "4M", "4N", "4O", "4P", "4Q", "4R", "4S", "4T", "4U", "4V", "4W", "4X", "50", "51", "52", "53", "54", "56", "57", "58", "59", "5A", "5B", "5C", "5E", "5F", "5G", "5H", "5I", "5J", "5K", "5P", "5Q", "60", "61", "62", "63", "64", "65", "66", "67", "68", "69", "70", "71", "72", "73", "74", "76", "77", "78", "79", "80", "81", "82", "83", "84", "85", "86", "87", "89", "8C", "8D", "8P", "8R", "8S", "8U", "90", "91", "92", "93", "94", "95", "96", "97", "98", "99", "A8", "AA", "AB", "AC", "AD", "AE", "AF", "AG", "AH", "AI", "AJ", "AK", "AL", "AM", "AN", "AO", "AP", "AQ", "AR", "AS", "AT", "AU", "AV", "AW", "AX", "AY", "AZ", "B0", "B1", "B2", "B3", "B4", "B5", "B6", "B7", "B8", "B9", "BA", "BB", "BC", "BD", "BE", "BF", "BG", "BH", "BI", "BJ", "BK", "BL", "BM", "BN", "BO", "BP", "BQ", "BR", "BS", "BT", "BU", "BV", "BW", "BX", "BY", "BZ", "C0", "C1", "C2", "C3", "C4", "C5", "C6", "C7", "C8", "C9", "CA", "CB", "CC", "CD", "CE", "CF", "CG", "CH", "CI", "CJ", "CK", "CL", "CM", "CN", "CO", "CP", "CQ", "CR", "CS", "CT", "CU", "CV", "CW", "CX", "CY", "CZ", "D2", "D3", "D5", "D8", "D9", "DA", "DB", "DC", "DD", "DE", "DF", "DG", "DH", "DI", "DJ", "DK", "DL", "DM", "DN", "DO", "DP", "DQ", "DR", "DS", "DT", "DU", "DW", "DX", "DY", "DZ", "E1", "E3", "E4", "E5", "E7", "E8", "E9", "EA", "EB", "EC", "ED", "EE", "EF", "EG", "EH", "EJ", "EM", "EP", "EQ", "EV", "EX", "EY", "EZ", "F1", "F2", "F3", "F4", "F5", "F6", "F9", "FA", "FB", "FC", "FD", "FE", "FF", "FG", "FH", "FJ", "FK", "FL", "FM", "FO", "FP", "FR", "FS", "FT", "FZ", "G2", "G3", "G4", "G5", "G7", "GA", "GB", "GC", "GD", "GE", "GF", "GG", "GH", "GI", "GJ", "GK", "GL", "GM", "GN", "GO", "GP", "GQ", "GR", "GS", "GT", "GU", "GV", "GW", "GX", "GY", "GZ", "H1", "H2", "H4", "HA", "HB", "HC", "HD", "HE", "HF", "HG", "HH", "HI", "HJ", "HK", "HL", "HM", "HN", "HO", "HP", "HQ", "HR", "HS", "HT", "HU", "HV", "HW", "HY", "HZ", "IA", "IB", "IC", "IE", "IF", "IH", "II", "IK", "IL", "IM", "IN", "IP", "IT", "IU", "IV", "IW", "J2", "JA", "JB", "JE", "JG", "JK", "JM", "JO", "JR", "JU", "K1", "K2", "K3", "K4", "K5", "K6", "K7", "K9", "KA", "KB", "KC", "KD", "KE", "KF", "KG", "KH", "KI", "KJ", "KK", "KL", "KM", "KO", "KP", "KQ", "KR", "KS", "KT", "KU", "KV", "KW", "KX", "L2", "LA", "LB", "LC", "LE", "LF", "LG", "LH", "LI", "LJ", "LK", "LL", "LM", "LN", "LO", "LP", "LQ", "LR", "LS", "LT", "LX", "LY", "M0", "M1", "M2", "M3", "M4", "M5", "M6", "M7", "M8", "M9", "MA", "MB", "MC", "MD", "ME", "MF", "MG", "MH", "MI", "MJ", "MK", "ML", "MM", "MN", "MO", "MP", "MQ", "MR", "MS", "MT", "MU", "MV", "MW", "MX", "MY", "MZ", "N1", "N2", "N3", "N4", "N6", "N7", "N9", "NA", "NB", "NC", "ND", "NE", "NF", "NG", "NH", "NI", "NJ", "NL", "NM", "NN", "NQ", "NR", "NS", "NT", "NU", "NV", "NW", "NX", "NY", "OA", "OC", "ON", "OP", "OT", "OZ", "P0", "P1", "P2", "P3", "P4", "P5", "P6", "P7", "P8", "P9", "PA", "PB", "PC", "PD", "PE", "PF", "PG", "PH", "PI", "PJ", "PK", "PL", "PM", "PN", "PO", "PP", "PQ", "PR", "PS", "PT", "PU", "PV", "PW", "PX", "PY", "PZ", "Q1", "Q2", "Q3", "Q4", "Q5", "Q6", "Q7", "QA", "QB", "QC", "QD", "QE", "QH", "QK", "QR", "QS", "QT", "QU", "R1", "R2", "R3", "R4", "R5", "R6", "R7", "R8", "R9", "RA", "RB", "RC", "RD", "RE", "RG", "RH", "RK", "RL", "RM", "RN", "RO", "RP", "RS", "RT", "RU", "S1", "S2", "S3", "S4", "S5", "S6", "S7", "S8", "S9", "SA", "SB", "SC", "SD", "SE", "SF", "SG", "SH", "SI", "SJ", "SK", "SL", "SM", "SN", "SO", "SP", "SQ", "SR", "SS", "ST", "SV", "SW", "SX", "SY", "SZ", "T0", "T1", "T2", "T3", "T4", "T5", "T6", "T7", "T8", "T9", "TA", "TB", "TC", "TD", "TE", "TF", "TG", "TH", "TI", "TJ", "TK", "TL", "TM", "TN", "TO", "TP", "TQ", "TR", "TS", "TT", "TU", "TV", "TW", "TX", "TY", "TZ", "U1", "U2", "U3", "U5", "UA", "UB", "UC", "UD", "UE", "UF", "UH", "UL", "UM", "UN", "UP", "UQ", "UR", "US", "UT", "UU", "UV", "UW", "UX", "UY", "UZ", "V1", "V2", "VA", "VC", "VI", "VP", "VR", "VS", "W2", "WA", "WB", "WD", "WE", "WG", "WH", "WI", "WK", "WM", "WP", "WR", "WW", "X1", "X2", "X3", "X4", "X5", "X6", "X7", "X8", "X9", "XP", "Y1", "Y2", "Y3", "Y4", "YD", "YL", "YR", "YT", "Z1", "Z2", "Z3", "Z4", "Z5", "Z6", "Z8", "ZA", "ZB", "ZC", "ZP", "ZZ" })]

        public string UnitOrBasisForMeasurementCode { get; set; }

        [EdiValue("X(80)", Path = "PO3/7", Description = "PO308 - Description")]
        [EdiExtension(MinLength = 1, MaxLength = 80, Mandatory = false, EdiType = EdiType.Alphanumeric)]
        public string Description { get; set; }
    }
}
