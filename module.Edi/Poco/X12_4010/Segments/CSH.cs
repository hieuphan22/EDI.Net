using System.Collections.Generic;
using Edi.Domain.Shared.Enums;
using Edi.Domain.Shared.Validation;
using FluentValidation.Results;
using indice.Edi.Serialization;
using Scm.Edi.Domain.Shared.Attributes;

namespace Edi.Application.Contracts.Poco.X12_4010.Segments
{
    [EdiSegment, EdiPath("CSH")]
    public class CSH : IEdiValidation<CSH>
    {
        [EdiValue("X(2)", Path = "CSH/0", Description = "CSH01 - Sales Requirement Code")]
        [EdiExtension(MinLength = 1, MaxLength = 2, Mandatory = false, EdiType = EdiType.Identifier)]
        [EdiAllowValue(AllowedValues = new string[] { "B", "C", "D", "E", "F", "K", "N", "O", "P", "Q", "R", "S", "T", "W", "Y", "Z", "8A", "AI", "AS", "BC", "BK", "EI", "FT", "GS", "IP", "IS", "LS", "MY", "NS", "P2", "P3", "P4", "QB", "QE", "QI", "QM", "QP", "SC", "SE", "SF", "SG", "SI", "SP", "SQ", "SS", "ST", "SU", "SV", "SW", "UC", "UL", "UP", "WY", "YI" })]

        public string SalesRequirementCode { get; set; }

        [EdiValue("X(2)", Path = "CSH/1", Description = "CSH02 - Action Code")]
        [EdiExtension(MinLength = 1, MaxLength = 2, Mandatory = false, EdiType = EdiType.Identifier)]
        [EdiAllowValue(AllowedValues = new string[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "34", "35", "36", "37", "38", "39", "40", "41", "42", "43", "44", "45", "46", "47", "48", "49", "50", "51", "52", "53", "54", "55", "56", "57", "58", "59", "60", "61", "62", "63", "64", "65", "66", "67", "68", "69", "70", "71", "72", "73", "74", "75", "76", "77", "78", "79", "80", "81", "82", "83", "84", "85", "86", "87", "88", "89", "90", "A1", "A2", "A3", "A4", "A5", "A6", "AA", "AB", "AC", "AD", "AE", "AF", "AG", "AH", "AI", "AJ", "AL", "AP", "AQ", "AR", "AS", "AT", "AV", "AW", "AX", "BD", "BI", "BO", "C1", "C2", "CA", "CB", "CC", "CD", "CE", "CF", "CG", "CL", "CM", "CN", "CO", "CP", "CS", "CT", "CU", "CV", "CX", "D1", "D2", "DA", "DB", "DC", "DD", "DE", "DF", "DG", "DH", "DI", "DJ", "DK", "DL", "DP", "DR", "DS", "DT", "DX", "EA", "EB", "EC", "ED", "EE", "EN", "EP", "ER", "EV", "EX", "F1", "FA", "FC", "FI", "FO", "FR", "GR", "HR", "I1", "IA", "IM", "IN", "IS", "IT", "JA", "JO", "JU", "KA", "LC", "LQ", "ME", "MO", "NA", "ND", "NP", "NS", "OD", "OP", "OR", "OT", "P1", "PA", "PB", "PC", "PD", "PF", "PI", "PJ", "PO", "PP", "PR", "PS", "PT", "PU", "PV", "R1", "R2", "R3", "R4", "R5", "R6", "R7", "R8", "R9", "RA", "RB", "RC", "RD", "RE", "RF", "RG", "RH", "RI", "RJ", "RK", "RL", "RM", "RN", "RO", "RP", "RQ", "RR", "RS", "RT", "RU", "RV", "RW", "RX", "S1", "S2", "SA", "SB", "SC", "SD", "SE", "SL", "SR", "SS", "SU", "SV", "SZ", "TD", "TE", "TG", "TN", "TP", "TR", "TS", "TU", "VA", "W1", "WD", "WI", "WQ", "WV" })]
        public string ActionCode { get; set; }

        [EdiValue("X(15)", Path = "CSH/2", Description = "CSH03 - Amount")]
        [EdiExtension(MinLength = 1, MaxLength = 15, Mandatory = false, EdiType = EdiType.Numeric)]
        public string Amount { get; set; }

        [EdiValue("X(35)", Path = "CSH/3", Description = "CSH04 - Account Number")]
        [EdiExtension(MinLength = 1, MaxLength = 35, Mandatory = false, EdiType = EdiType.Alphanumeric)]
        public string AccountNumber { get; set; }

        [EdiValue("X(8)", Path = "CSH/4", Format = "yyyyMMdd", Description = "CSH05 - Date")]
        [EdiExtension(MinLength = 8, MaxLength = 8, Mandatory = false, EdiType = EdiType.Date)]
        public string Date { get; set; }

        [EdiValue("X(2)", Path = "CSH/5", Description = "CSH06 - Agency Qualifier Code")]
        [EdiExtension(MinLength = 2, MaxLength = 2, Mandatory = false, EdiType = EdiType.Identifier)]
        [EdiAllowValue(AllowedValues = new string[] { "10 ", "11 ", "12 ", "13 ", "14 ", "15 ", "16 ", "17 ", "18 ", "19 ", "20 ", "21 ", "22 ", "23 ", "24 ", "25 ", "26 ", "27 ", "28 ", "29 ", "30 ", "31 ", "32 ", "33 ", "34 ", "35 ", "36 ", "37 ", "38 ", "39 ", "40 ", "41 ", "42 ", "43 ", "44 ", "45 ", "46 ", "47 ", "48 ", "49 ", "50 ", "51 ", "52 ", "53 ", "54 ", "55 ", "56 ", "57 ", "58 ", "59 ", "60 ", "93 ", "94 ", "A1 ", "A2 ", "A3 ", "A4 ", "AA ", "AB ", "AC ", "AD ", "AE ", "AG ", "AH ", "AI ", "AJ ", "AL ", "AM ", "AP ", "AQ ", "AS ", "AT ", "AW ", "AX ", "AY ", "BE ", "BF ", "BI ", "CA ", "CB ", "CC ", "CE ", "CI ", "CL ", "CM ", "CO ", "CR ", "CS ", "CU ", "CX ", "DA ", "DD ", "DE ", "DF ", "DI ", "DL ", "DN ", "DO ", "DR ", "DS ", "DX ", "DY ", "DZ ", "EI ", "EP ", "ES ", "ET ", "EU ", "EX ", "FA ", "FC ", "FD ", "FG ", "FH ", "FI ", "GC ", "GS ", "GU ", "HC ", "HI ", "HS ", "HU ", "IA ", "IB ", "IC ", "IM ", "IN ", "IS ", "JA ", "LA ", "LB ", "LI ", "MA ", "MB ", "MC ", "ME ", "MI ", "MP ", "MS ", "MV ", "NA ", "NB ", "NC ", "NE ", "NF ", "NG ", "NI ", "NR ", "NS ", "NT ", "NU ", "NW ", "OI ", "OP ", "OS ", "PA ", "PC ", "SA ", "SE ", "SL ", "SP ", "ST ", "TA ", "TB ", "TC ", "TD ", "TI ", "TM ", "TP ", "TR ", "TX ", "UC ", "UN ", "VI ", "WH ", "ZZ " })]
        public string AgencyQualifierCode { get; set; }

        [EdiValue("X(10)", Path = "CSH/6", Description = "CSH07 - Special Services Code")]
        [EdiExtension(MinLength = 2, MaxLength = 10, Mandatory = false, EdiType = EdiType.Identifier)]
        [EdiAllowValue(AllowedValues = new string[] { "AC", "AD", "AF", "AG", "AM", "AO", "BH", "BI", "C1", "C2", "CA", "CC", "CD", "CH", "CI", "CM", "CN", "CO", "CS", "CT", "CU", "CY", "CZ", "D1", "D2", "DA", "DE", "DH", "DI", "DL", "DS", "DV", "EG", "EM", "EN", "ER", "EU", "EX", "F1", "FG", "FS", "GI", "GP", "GU", "H1", "HC", "HH", "HS", "IC", "ID", "IG", "IK", "IL", "IM", "IN", "IO", "IP", "IQ", "IR", "IS", "IT", "KO", "L1", "LA", "LL", "LS", "MI", "ML", "NC", "OA", "ON", "OP", "PA", "PB", "PC", "PE", "PF", "PL", "PM", "PO", "PP", "RD", "RE", "RM", "RP", "S1", "S2", "S3", "SD", "SG", "SH", "SJ", "SR", "SS", "ST", "SU", "SV", "SW", "T1", "TC", "TE", "TH", "TM", "TO", "UN", "US", "V1", "V2", "WC", "WH", "XP", "XX", "YY", "ZZ", "BOP", "PLI", "PSF", "SLP", "SPI", "A0010", "A0020", "A0030", "B0020", "B0040", "C0012", "C0032", "C0036", "C0038", "D0020", "D0024", "D0031", "D0032", "E0030", "G0010", "G0052", "I0012", "I0013", "I0021", "I0022", "M0010", "M0042", "MNTAN", "MNTMN", "MNTON", "N0020", "N0021", "N0032", "P0012", "P0014", "P0016", "P0018", "P0022", "R0072", "R0076", "R0077", "R0110", "S0014", "S0016", "S0022", "S0024", "S0050", "S0052", "S0054", "S0056", "S0080", "T0070", "W0010", "X0010" })]
        public string SpecialServicesCode { get; set; }

        [EdiValue("X(2)", Path = "CSH/7", Description = "CSH08 - Product Or Service Substitution Code")]
        [EdiExtension(MinLength = 1, MaxLength = 2, Mandatory = false, EdiType = EdiType.Identifier)]
        [EdiAllowValue(AllowedValues = new string[] { "A", "X", "Y", "B0", "B1", "B2", "B3", "B4", "ZZ" })]
        public string ProductOrServiceSubstitutionCode { get; set; }

        [EdiValue("X(2)", Path = "CSH/8", Description = "CSH09 - Percent")]
        [EdiExtension(MinLength = 1, MaxLength = 10, Mandatory = false, EdiType = EdiType.Decimal)]
        public string Percent { get; set; }

        [EdiValue("X(2)", Path = "CSH/9", Description = "CSH10 - Percent Qualifier")]
        [EdiExtension(MinLength = 1, MaxLength = 2, Mandatory = false, EdiType = EdiType.Identifier)]
        [EdiAllowValue(AllowedValues = new string[] { "1 ", "2 ", "3 ", "4 ", "5 ", "6 ", "7 ", "8 ", "9 ", "A ", "B ", "C ", "D ", "E ", "F ", "M ", "N ", "O ", "P ", "R ", "S ", "T ", "W ", "X ", "01 ", "02 ", "05 ", "06 ", "07 ", "08 ", "09 ", "10 ", "11 ", "12 ", "13 ", "14 ", "15 ", "16 ", "17 ", "18 ", "19 ", "20 ", "21 ", "22 ", "23 ", "24 ", "25 ", "26 ", "27 ", "28 ", "30 ", "31 ", "32 ", "33 ", "34 ", "35 ", "36 ", "37 ", "38 ", "40 ", "41 ", "42 ", "43 ", "44 ", "45 ", "46 ", "47 ", "48 ", "49 ", "50 ", "51 ", "52 ", "53 ", "59 ", "60 ", "61 ", "62 ", "63 ", "64 ", "65 ", "66 ", "67 ", "68 ", "69 ", "70 ", "71 ", "72 ", "76 ", "77 ", "78 ", "79 ", "80 ", "81 ", "82 ", "83 ", "84 ", "85 ", "86 ", "87 ", "88 ", "89 ", "90 ", "91 ", "92 ", "93 ", "94 ", "95 ", "96 ", "97 ", "98 ", "99 ", "AB ", "AC ", "AD ", "AE ", "AF ", "AG ", "AH ", "AI ", "AJ ", "AK ", "AL ", "AM ", "AN ", "AP ", "AR ", "AT ", "BA ", "BB ", "BC ", "BD ", "BE ", "BF ", "BG ", "BH ", "BP ", "BS ", "BU ", "CA ", "CB ", "CH ", "CJ ", "CN ", "CO ", "CP ", "CR ", "CS ", "CU ", "DF ", "DY ", "EA ", "EF ", "EP ", "FT ", "FV ", "GA ", "IA ", "IN ", "KA ", "KB ", "LM ", "MA ", "MN ", "MS ", "MX ", "NA ", "NH ", "OC ", "OF ", "OH ", "OP ", "PA ", "PC ", "PD ", "PF ", "PH ", "PM ", "PN ", "PP ", "PR ", "PT ", "PV ", "RA ", "RB ", "RC ", "RD ", "RF ", "RG ", "RI ", "RL ", "RO ", "RP ", "RQ ", "RR ", "RS ", "SA ", "SC ", "SD ", "SE ", "SF ", "SG ", "TP ", "WI ", "WK ", "X1 ", "XT " })]
        public string PercentQualifier { get; set; }

        public List<ValidationResult> ValidateEdi(CSH model)
        {
            return new List<ValidationResult>();
        }
    }
}
