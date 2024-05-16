using System.Collections.Generic;
using Edi.Domain.Shared.Attributes;
using Edi.Domain.Shared.Enums;
using Edi.Domain.Shared.Validation;
using FluentValidation.Results;
using indice.Edi.Serialization;
using Scm.Edi.Domain.Shared.Attributes;

namespace Edi.Domain.Shared.Poco.X12_4010.Segments
{
    [EdiSegment]
    [EdiPath("MEA")]
    public class MEA : IEdiValidation<MEA>
    {
        [EdiValue("X(2)", Path = "MEA/0", Description = "MEA01 - Measurement Reference ID Code")]
        [EdiExtension(MinLength = 2, MaxLength = 2, Mandatory = false, EdiType = EdiType.Identifier)]
        [EdiAllowValue(AllowedValues = new string[] { "9L", "AA", "AB", "AC", "AE", "AF", "AG", "AH", "AI", "AJ", "AK", "AM", "AN", "AO", "AP", "AQ", "AR", "AV", "BA", "BB", "BC", "BD", "BL", "BM", "BN", "BO", "BP", "BR", "BT", "BZ", "C1", "CA", "CB", "CC", "CF", "CG", "CH", "CJ", "CK", "CL", "CM", "CN", "CO", "CP", "CQ", "CS", "CT", "CU", "CV", "CW", "CY", "DE", "DN", "DT", "EA", "EE", "EF", "EL", "EN", "FC", "FD", "FH", "FJ", "FV", "FZ", "GC", "GL", "GO", "GP", "HC", "HR", "ID", "IN", "IR", "LC", "LD", "LG", "LL", "LM", "LP", "LS", "LT", "MP", "MR", "NC", "NE", "NX", "OD", "OG", "OL", "OP", "P1", "PA", "PB", "PC", "PD", "PI", "PJ", "PK", "PL", "PM", "PO", "PR", "PS", "PT", "PU", "PY", "QR", "QV", "R1", "R2", "RA", "RG", "RL", "RN", "RO", "RP", "RQ", "RS", "RT", "SA", "SB", "SC", "SD", "SE", "SF", "SH", "SJ", "SK", "SL", "SM", "SP", "SR", "ST", "SU", "SZ", "TA", "TD", "TE", "TI", "TL", "TO", "TP", "TR", "TS", "TT", "VT", "WA", "WR", "WT", "ZA", "ZP" })]
        public string MeasurementReferenceIDCode { get; set; }

        [EdiValue("X(3)", Path = "MEA/1", Description = "MEA02 - Measurement Qualifier")]
        [EdiExtension(MinLength = 2, MaxLength = 3, Mandatory = false, EdiType = EdiType.Identifier)]
        [EdiAllowValue(AllowedValues = new string[] { "1", "2", "3", "4", "5", "6", "7", "8", "A", "B", "C", "D", "E", "F", "G", "I", "L", "M", "N", "O", "Q", "R", "S", "T", "U", "X", "10", "11", "12", "13", "14", "15", "16", "18", "19", "1F", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "2F", "30", "31", "32", "33", "34", "35", "36", "37", "38", "39", "3A", "3B", "3C", "3D", "3E", "3F", "3G", "3H", "3I", "3J", "40", "41", "42", "43", "44", "4F", "5F", "6F", "8F", "A1", "A2", "A3", "A4", "A5", "A6", "A7", "A9", "AA", "AB", "AC", "AD", "AE", "AF", "AG", "AH", "AI", "AJ", "AK", "AL", "AM", "AN", "AP", "AS", "AT", "AU", "AV", "AW", "AX", "AY", "AZ", "B1", "B2", "B3", "B4", "B5", "B6", "BA", "BB", "BC", "BD", "BE", "BF", "BG", "BH", "BJ", "BK", "BL", "BN", "BO", "BP", "BQ", "BR", "BT", "BU", "BW", "BX", "C0", "C1", "C2", "C3", "C4", "CA", "CC", "CD", "CE", "CF", "CG", "CH", "CI", "CJ", "CK", "CL", "CM", "CN", "CO", "CP", "CQ", "CR", "CS", "CT", "CU", "CW", "CX", "CY", "D1", "D2", "D3", "D4", "D5", "D7", "DA", "DB", "DC", "DD", "DE", "DF", "DG", "DH", "DI", "DJ", "DL", "DM", "DN", "DP", "DR", "DS", "DT", "DU", "DW", "DY", "E0", "E1", "EA", "EB", "EC", "ED", "EE", "EF", "EG", "EH", "EI", "EJ", "EL", "EM", "EN", "EP", "ES", "EW", "EX", "F1", "F2", "F3", "F4", "F5", "F6", "F7", "F8", "F9", "FA", "FB", "FC", "FD", "FE", "FF", "FG", "FH", "FI", "FJ", "FK", "FL", "FN", "FP", "FQ", "FR", "FS", "FT", "FU", "FV", "FW", "FX", "FY", "FZ", "G1", "G2", "G3", "G4", "GA", "GB", "GC", "GD", "GE", "GF", "GG", "GH", "GI", "GJ", "GK", "GL", "GM", "GN", "GO", "GP", "GQ", "GR", "GS", "GT", "GW", "H1", "H8", "H9", "HA", "HB", "HC", "HD", "HE", "HF", "HG", "HH", "HI", "HJ", "HK", "HL", "HM", "HO", "HP", "HR", "HT", "HZ", "IA", "IB", "IC", "ID", "IE", "IF", "IG", "IH", "II", "IJ", "IK", "IL", "IM", "IN", "IO", "IP", "IQ", "IR", "IS", "IT", "IU", "IV", "IW", "IX", "IY", "IZ", "JA", "KA", "KB", "KN", "L0", "L1", "LA", "LB", "LC", "LD", "LE", "LF", "LG", "LL", "LM", "LN", "LO", "LP", "LS", "LT", "LW", "M1", "M2", "M3", "M4", "M5", "M6", "MA", "MB", "MC", "MD", "ME", "MF", "MG", "MH", "MI", "MJ", "MK", "MM", "MN", "MO", "MP", "MQ", "MR", "MS", "MT", "MU", "MV", "MW", "MX", "MY", "NA", "NB", "NC", "ND", "NF", "NG", "NH", "NI", "NJ", "NK", "NL", "NM", "NO", "NP", "NS", "NU", "NV", "O1", "OA", "OB", "OC", "OD", "OE", "OF", "OG", "OH", "OI", "OJ", "OK", "OL", "OM", "ON", "OO", "OP", "OQ", "OR", "OS", "OT", "OV", "OW", "OX", "OY", "P1", "PA", "PB", "PC", "PD", "PE", "PF", "PG", "PH", "PI", "PJ", "PK", "PL", "PM", "PN", "PO", "PP", "PQ", "PR", "PS", "PT", "PU", "PV", "PW", "PX", "PY", "PZ", "QA", "QB", "QC", "QD", "QE", "QF", "QL", "R1", "R2", "R3", "R4", "R7", "R8", "RA", "RB", "RC", "RD", "RE", "RF", "RG", "RH", "RI", "RJ", "RK", "RL", "RM", "RN", "RO", "RP", "RQ", "RR", "RS", "RT", "RU", "RV", "RW", "RX", "RY", "S1", "S2", "S3", "S4", "S5", "S6", "S7", "S8", "S9", "SA", "SB", "SC", "SD", "SE", "SF", "SG", "SH", "SI", "SJ", "SK", "SL", "SM", "SN", "SO", "SP", "SQ", "SR", "SS", "ST", "SU", "SV", "SW", "SX", "SY", "SZ", "T1", "T2", "T3", "T4", "T5", "TA", "TB", "TC", "TD", "TE", "TF", "TG", "TH", "TI", "TJ", "TK", "TL", "TM", "TN", "TO", "TP", "TQ", "TR", "TS", "TT", "TU", "TV", "TW", "TX", "TY", "UA", "UG", "VH", "VO", "VW", "WA", "WB", "WC", "WD", "WE", "WF", "WH", "WI", "WL", "WM", "WR", "WT", "WU", "WX", "XA", "XH", "XP", "XQ", "XZ", "YA", "YB", "YC", "YD", "ZA", "ZB", "ZC", "ZD", "ZF", "ZG", "ZH", "ZN", "ZO", "ZP", "ZR", "ZS", "ZV", "ZW", "AAP", "ABO", "ABR", "ABS", "ACN", "ADH", "ADM", "AGE", "AGI", "ALK", "ALN", "ALP", "AMI", "AMW", "AOX", "API", "APP", "ASH", "ASY", "AVT", "BDP", "BHF", "BHS", "BIC", "BND", "BOR", "BRS", "BSW", "BUD", "CAU", "CCF", "CCG", "CGR", "CHA", "CHC", "CHG", "CHL", "CIV", "CLA", "CLB", "CLN", "COH", "COL", "CON", "COR", "COS", "COT", "CPF", "CPS", "CRF", "CRL", "CRN", "CRT", "CSC", "CSR", "CST", "CTG", "CTT", "CUT", "CWT", "CYB", "DAT", "DCT", "DEM", "DIR", "DIS", "DME", "DMF", "DPM", "DRY", "DWP", "ELC", "ELE", "ELI", "ELL", "ELO", "ELP", "ELS", "ELT", "ELV", "ELW", "ELX", "EPL", "EVL", "EVR", "EXH", "EXT", "FBP", "FIL", "FIN", "FIT", "FLD", "FLN", "FLP", "FLV", "FML", "FMZ", "FNL", "FNS", "FOA", "FOH", "FOI", "FOR", "FPV", "FSI", "FUD", "GEL", "GGR", "GIR", "GLE", "GOR", "GRA", "GRI", "H2O", "HAR", "HAZ", "HCG", "HHW", "HIB", "HOC", "HTE", "HVM", "HWS", "HYD", "HZC", "IDE", "IGA", "IGR", "IHV", "IMP", "IND", "INS", "IPI", "IRA", "JOM", "LAI", "LC5", "LCG", "LD5", "LDH", "LEF", "LIR", "LIV", "LLD", "LOI", "LOS", "LOW", "LPG", "LPL", "LPR", "LSK", "LSS", "LTD", "MAT", "MCN", "MEF", "MEL", "MER", "MHI", "MIC", "MOI", "MOR", "MPR", "MTD", "MUL", "NEU", "NIL", "NNW", "NOC", "NON", "NOR", "NOX", "OAP", "OBT", "OCG", "OCR", "ODR", "OIL", "OLE", "ORC", "OTE", "OTH", "OTT", "OXI", "OXS", "PAR", "PBD", "PDE", "PDG", "PER", "PFO", "PHA", "PHW", "PIC", "POC", "POD", "POP", "PPS", "PRE", "PRF", "PRI", "PRL", "PRO", "PRQ", "PRY", "PSA", "PSP", "PSW", "PWA", "PWE", "PWF", "QUR", "R10", "R18", "RAD", "RAF", "REA", "RED", "REF", "REI", "REL", "RES", "ROH", "ROX", "RSZ", "RTB", "RUD", "RVP", "S10", "S12", "S18", "SAP", "SCH", "SEV", "SHA", "SIL", "SLD", "SLI", "SMB", "SMD", "SOD", "SOF", "SPG", "SPR", "STA", "STL", "STP", "SUM", "SUR", "SUT", "SVL", "SXX", "T50", "T90", "TAS", "TCL", "TDP", "TEE", "TES", "TEX", "TOA", "TOR", "TOX", "TPF", "TPL", "TPQ", "TPS", "TRA", "TRC", "TRD", "TRN", "TSZ", "TTL", "TUR", "TVD", "TWD", "UCB", "UNI", "UNK", "VAD", "VAP", "VCG", "VIN", "VIS", "VOC", "VOL", "VOT", "VOV", "VOW", "VSO", "VWT", "WDE", "WEL", "WOD", "WPF", "WPL", "WPS", "WRA", "WSK", "WTB", "ZAL", "ZAS", "ZBI", "ZBT", "ZBZ", "ZCA", "ZCB", "ZCD", "ZCE", "ZCO", "ZCR", "ZCU", "ZET", "ZFE", "ZFL", "ZFS", "ZGE", "ZHP", "ZHS", "ZHX", "ZIB", "ZIP", "ZMG", "ZMN", "ZMO", "ZMT", "ZNB", "ZNI", "ZNP", "ZOC", "ZPB", "ZPP", "ZPT", "ZSB", "ZSE", "ZSI", "ZSN", "ZTA", "ZTB", "ZTE", "ZTI", "ZZN", "ZZR", "ZZZ" })]

        public string MeasurementQualifier { get; set; }

        [EdiValue("9(20)", Path = "MEA/2", Format = "R", Description = "MEA03 - Measurement Value")]
        [EdiExtension(MinLength = 1, MaxLength = 20, Mandatory = false, EdiType = EdiType.Decimal)]
        public string MeasurementValue { get; set; }

        [EdiValue("X(2)", Path = "MEA/3", Description = "MEA04 - Composite Unit of Measure")]
        [EdiExtension(MinLength = 2, MaxLength = 2, Mandatory = false, EdiType = EdiType.Identifier)]
        public string CompositeUnitOfMeasure { get; set; }

        [EdiValue("9(20)", Path = "MEA/4", Format = "R", Description = "MEA05 - Range Minimum")]
        [EdiExtension(MinLength = 1, MaxLength = 20, Mandatory = false, EdiType = EdiType.Decimal)]
        public string RangeMinimum { get; set; }

        [EdiValue("9(20)", Path = "MEA/5", Format = "R", Description = "MEA06 - Range Maximum")]
        [EdiExtension(MinLength = 1, MaxLength = 20, Mandatory = false, EdiType = EdiType.Decimal)]
        public string RangeMaximum { get; set; }

        [EdiValue("X(2)", Path = "MEA/6", Description = "MEA07 - Measurement Significance Code")]
        [EdiExtension(MinLength = 2, MaxLength = 2, Mandatory = false, EdiType = EdiType.Identifier)]
        [EdiAllowValue(AllowedValues = new string[] { "01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "34", "35", "36", "37", "38", "39", "40", "41", "42", "43", "44", "45", "46", "47", "49", "50", "51", "52", "53", "54", "55", "56", "57", "58", "59", "60", "61", "62", "63", "64", "65", "66", "67", "68", "69", "70", "71", "72", "73", "74", "75", "76", "77", "78", "79", "80", "81", "82", "83", "84", "85", "86", "87", "88", "89", "90", "91", "92", "93", "94", "95", "96", "97", "ZZ" })]

        public string MeasurementSignificanceCode { get; set; }

        [EdiValue("X(2)", Path = "MEA/7", Description = "MEA08 - Measurement Attribute Code")]
        [EdiExtension(MinLength = 2, MaxLength = 2, Mandatory = false, EdiType = EdiType.Identifier)]
        [EdiAllowValue(AllowedValues = new string[] { "01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "40", "41", "42", "44", "45", "46", "48", "49", "50", "51", "52", "Q1", "Q2", "TA", "TB", "ZZ" })]

        public string MeasurementAttributeCode { get; set; }

        [EdiValue("X(2)", Path = "MEA/8", Description = "MEA09 - Surface Or Laye rOr Position Code")]
        [EdiExtension(MinLength = 2, MaxLength = 2, Mandatory = false, EdiType = EdiType.Identifier)]
        [EdiAllowValue(AllowedValues = new string[] { "1S", "2S", "A1", "AL", "AO", "AS", "B1", "BC", "BI", "BK", "BL", "BR", "BS", "BT", "CH", "CT", "DO", "DT", "DU", "EX", "FR", "FS", "GF", "IN", "IT", "KB", "LC", "LO", "LT", "M1", "MC", "MD", "NS", "NT", "OA", "OS", "OT", "R0", "R1", "R2", "R3", "R4", "R5", "R6", "R7", "R8", "R9", "RA", "RB", "RC", "RD", "RE", "RF", "RG", "RH", "RI", "RJ", "RK", "RL", "RM", "RN", "RO", "RP", "RQ", "RR", "RS", "RT", "RU", "RV", "RW", "RX", "RY", "RZ", "S1", "S2", "S3", "S4", "S5", "S6", "S7", "S8", "S9", "SA", "SB", "SC", "SD", "SE", "SF", "SN", "SP", "SS", "ST", "SU", "TB", "TP", "TS", "UC", "UN", "UP", "UT", "WF" })]

        public string SurfaceOrLayerOrPositionCode { get; set; }

        [EdiValue("X(4)", Path = "MEA/9", Description = "MEA10 - Measurement Method Or Device")]
        [EdiExtension(MinLength = 2, MaxLength = 4, Mandatory = false, EdiType = EdiType.Identifier)]
        public string MeasurementMethodOrDevice { get; set; }

        public List<ValidationResult> ValidateEdi(MEA model) {
            return new List<ValidationResult>();
        }
    }
}
