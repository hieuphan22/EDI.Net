using Edi.Domain.Shared.Attributes;
using Edi.Domain.Shared.Enums;
using indice.Edi.Serialization;
using Scm.Edi.Domain.Shared.Attributes;

namespace Edi.Domain.Shared.Poco.X12_4010.Segments
{
    [EdiSegment]
    [EdiPath("PID")]
    public class PID
    {
        [EdiValue("X(1)", Path = "PID/0", Description = "PID01 - Item Description Type")]
        [EdiExtension(MinLength = 1, MaxLength = 1, Mandatory = true, EdiType = EdiType.Identifier)]
        [EdiAllowValue(AllowedValues = new string[] { "F", "S", "X" })]
        public string ItemDescriptionType { get; set; }

        [EdiValue("X(3)", Path = "PID/1", Description = "PID02 - Product/Process Characteristic Code")]
        [EdiExtension(MinLength = 2, MaxLength = 3, Mandatory = false, EdiType = EdiType.Identifier)]
        [EdiAllowValue(AllowedValues = new string[] { "01", "02", "08", "09", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "25", "28", "29", "30", "32", "33", "34", "35", "36", "37", "38", "39", "40", "41", "42", "43", "54", "55", "56", "58", "59", "60", "61", "62", "63", "64", "65", "66", "67", "68", "69", "70", "71", "72", "73", "74", "75", "76", "77", "78", "79", "80", "81", "82", "83", "84", "85", "86", "87", "88", "89", "90", "91", "92", "93", "94", "95", "96", "97", "99", "9A", "9B", "9C", "9D", "AF", "AG", "AT", "B8", "BC", "BW", "C2", "C3", "C4", "C5", "C6", "CD", "CH", "CL", "CM", "CO", "CP", "CS", "CU", "CW", "DE", "DF", "DM", "EC", "EN", "FA", "FC", "FL", "FQ", "GD", "GM", "GS", "HB", "HY", "HZ", "KI", "LC", "LO", "MA", "MB", "MS", "NH", "OC", "OD", "OR", "OT", "P6", "PD", "PF", "PG", "PP", "PR", "R3", "RA", "RM", "RR", "RX", "SC", "SE", "SF", "ST", "TC", "TE", "TF", "TP", "TR", "TZ", "VA", "VC", "VI", "WD", "WF", "WT", "ZZ", "AGE", "BCC", "BES", "BEV", "BLM", "BND", "BPI", "BRG", "CCN", "CFC", "CHF", "CLT", "CMS", "DAC", "DAF", "DIR", "FCD", "FDD", "FLV", "FMR", "GEN", "HZR", "ING", "INJ", "MAC", "MBU", "MSG", "ODR", "PFA", "PFC", "PFG", "PFI", "PFK", "PFL", "PFM", "PFN", "PFP", "PFS", "PFT", "PRI", "PRO", "PSC", "PUB", "PUR", "QAS", "RCC", "RSD", "RSE", "SEC", "SIZ", "SLM", "SOL", "STL", "SYN", "THR", "TIF", "TIR", "TRN", "TWF", "WLC", "WTT" })]

        public string ProductOrProcessCharacteristicCode { get; set; }

        [EdiValue("X(2)", Path = "PID/2", Description = "PID03 - Agency Qualifier Code")]
        [EdiExtension(MinLength = 2, MaxLength = 2, Mandatory = false, EdiType = EdiType.Identifier)]
        [EdiAllowValue(AllowedValues = new string[] { "10 ", "11 ", "12 ", "13 ", "14 ", "15 ", "16 ", "17 ", "18 ", "19 ", "20 ", "21 ", "22 ", "23 ", "24 ", "25 ", "26 ", "27 ", "28 ", "29 ", "30 ", "31 ", "32 ", "33 ", "34 ", "35 ", "36 ", "37 ", "38 ", "39 ", "40 ", "41 ", "42 ", "43 ", "44 ", "45 ", "46 ", "47 ", "48 ", "49 ", "50 ", "51 ", "52 ", "53 ", "54 ", "55 ", "56 ", "57 ", "58 ", "59 ", "60 ", "93 ", "94 ", "A1 ", "A2 ", "A3 ", "A4 ", "AA ", "AB ", "AC ", "AD ", "AE ", "AG ", "AH ", "AI ", "AJ ", "AL ", "AM ", "AP ", "AQ ", "AS ", "AT ", "AW ", "AX ", "AY ", "BE ", "BF ", "BI ", "CA ", "CB ", "CC ", "CE ", "CI ", "CL ", "CM ", "CO ", "CR ", "CS ", "CU ", "CX ", "DA ", "DD ", "DE ", "DF ", "DI ", "DL ", "DN ", "DO ", "DR ", "DS ", "DX ", "DY ", "DZ ", "EI ", "EP ", "ES ", "ET ", "EU ", "EX ", "FA ", "FC ", "FD ", "FG ", "FH ", "FI ", "GC ", "GS ", "GU ", "HC ", "HI ", "HS ", "HU ", "IA ", "IB ", "IC ", "IM ", "IN ", "IS ", "JA ", "LA ", "LB ", "LI ", "MA ", "MB ", "MC ", "ME ", "MI ", "MP ", "MS ", "MV ", "NA ", "NB ", "NC ", "NE ", "NF ", "NG ", "NI ", "NR ", "NS ", "NT ", "NU ", "NW ", "OI ", "OP ", "OS ", "PA ", "PC ", "SA ", "SE ", "SL ", "SP ", "ST ", "TA ", "TB ", "TC ", "TD ", "TI ", "TM ", "TP ", "TR ", "TX ", "UC ", "UN ", "VI ", "WH ", "ZZ " })]

        public string AgencyQualifierCode { get; set; }

        [EdiValue("X(12)", Path = "PID/3", Description = "PID04 - Product Description Code")]
        [EdiExtension(MinLength = 1, MaxLength = 12, Mandatory = false, EdiType = EdiType.Alphanumeric)]
        public string ProductDescriptionCode { get; set; }

        [EdiValue("X(80)", Path = "PID/4", Description = "PID05 - Description")]
        [EdiExtension(MinLength = 1, MaxLength = 80, Mandatory = false, EdiType = EdiType.Alphanumeric)]
        public string Description { get; set; }

        [EdiValue("X(2)", Path = "PID/5", Description = "PID06 - Surface Or Layer Or Position Code")]
        [EdiExtension(MinLength = 2, MaxLength = 2, Mandatory = false, EdiType = EdiType.Identifier)]
        [EdiAllowValue(AllowedValues = new string[] { "1S", "2S", "A1", "AL", "AO", "AS", "B1", "BC", "BI", "BK", "BL", "BR", "BS", "BT", "CH", "CT", "DO", "DT", "DU", "EX", "FR", "FS", "GF", "IN", "IT", "KB", "LC", "LO", "LT", "M1", "MC", "MD", "NS", "NT", "OA", "OS", "OT", "R0", "R1", "R2", "R3", "R4", "R5", "R6", "R7", "R8", "R9", "RA", "RB", "RC", "RD", "RE", "RF", "RG", "RH", "RI", "RJ", "RK", "RL", "RM", "RN", "RO", "RP", "RQ", "RR", "RS", "RT", "RU", "RV", "RW", "RX", "RY", "RZ", "S1", "S2", "S3", "S4", "S5", "S6", "S7", "S8", "S9", "SA", "SB", "SC", "SD", "SE", "SF", "SN", "SP", "SS", "ST", "SU", "TB", "TP", "TS", "UC", "UN", "UP", "UT", "WF" })]

        public string SurfaceOrLayerOrPositionCode { get; set; }

        [EdiValue("X(15)", Path = "PID/6", Description = "PID07 - Source Sub qualifier")]
        [EdiExtension(MinLength = 1, MaxLength = 15, Mandatory = false, EdiType = EdiType.Alphanumeric)]
        public string SourceSubqualifier { get; set; }

        [EdiValue("X(1)", Path = "PID/7", Description = "PID08 - Yes Or No Condition Or ResponseCode")]
        [EdiExtension(MinLength = 1, MaxLength = 1, Mandatory = false, EdiType = EdiType.Identifier)]
        [EdiAllowValue(AllowedValues = new string[] { "N", "U", "W", "Y" })]

        public string YesOrNoConditionOrResponseCode { get; set; }

        [EdiValue("X(3)", Path = "PID/8", Description = "PID09 - Language Code")]
        [EdiExtension(MinLength = 2, MaxLength = 3, Mandatory = false, EdiType = EdiType.Identifier)]
        public string LanguageCode { get; set; }
    }
}