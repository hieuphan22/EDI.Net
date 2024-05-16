﻿using Edi.Domain.Shared.Attributes;
using Edi.Domain.Shared.Enums;
using indice.Edi.Serialization;

namespace Edi.Domain.Shared.Poco.X12_4010.Segments
{
    [EdiSegment]
    [EdiPath("SAC")]
    public class SAC
    {
        [EdiValue("X(1)", Path = "SAC/0", Description = "SAC01 - Allowance or Charge Indicator")]
        [EdiExtension(MinLength = 1, MaxLength = 1, Mandatory = true, EdiType = EdiType.Identifier)]
        [EdiAllowValue(AllowedValues = new string[] { "A", "C", "N", "P", "Q", "R", "S" })]
        public string AllowanceOrChargeIndicator { get; set; }

        [EdiValue("X(4)", Path = "SAC/1", Description = "SAC02 - Service, Promotion, Allowance, or Charge Code")]
        [EdiExtension(MinLength = 4, MaxLength = 4, Mandatory = false, EdiType = EdiType.Identifier)]
        [EdiAllowValue(AllowedValues = new string[] { "A010", "A020", "A030", "A040", "A050", "A060", "A070", "A080", "A090", "A100", "A110", "A112", "A120", "A121", "A122", "A130", "A140", "A150", "A160", "A170", "A172", "A180", "A190", "A200", "A210", "A220", "A230", "A240", "A250", "A260", "A270", "A280", "A290", "A300", "A310", "A320", "A330", "A340", "A350", "A360", "A370", "A380", "A390", "A400", "A410", "A420", "A430", "A440", "A445", "A450", "A460", "A470", "A480", "A485", "A490", "A500", "A510", "A520", "A530", "A540", "A550", "A555", "A560", "A570", "A580", "A590", "A600", "A610", "A620", "A630", "A640", "A650", "A658", "A660", "A670", "A680", "A690", "A691", "A700", "A710", "A720", "A721", "A730", "A740", "A750", "A760", "A770", "A780", "A790", "A800", "A810", "A820", "A830", "A840", "A850", "A860", "A870", "A880", "A890", "A900", "A910", "A920", "A930", "A940", "A950", "A960", "A970", "A980", "A990", "ADOW", "ADRW", "AFEE", "ALPT", "B000", "B010", "B015", "B020", "B030", "B040", "B050", "B060", "B070", "B080", "B090", "B091", "B100", "B110", "B120", "B130", "B140", "B150", "B160", "B170", "B180", "B190", "B200", "B210", "B220", "B230", "B240", "B250", "B260", "B270", "B280", "B290", "B300", "B310", "B320", "B330", "B340", "B350", "B360", "B370", "B380", "B390", "B400", "B500", "B510", "B520", "B530", "B540", "B550", "B551", "B560", "B570", "B580", "B581", "B590", "B600", "B610", "B620", "B630", "B650", "B660", "B670", "B680", "B690", "B700", "B720", "B730", "B740", "B742", "B750", "B760", "B770", "B775", "B780", "B785", "B787", "B790", "B791", "B800", "B810", "B820", "B830", "B840", "B850", "B860", "B870", "B872", "B880", "B881", "B890", "B900", "B910", "B911", "B920", "B930", "B940", "B950", "B960", "B970", "B980", "B990", "B992", "B994", "B996", "B998", "BU2T", "BU4T", "BUAT", "BURD", "C000", "C010", "C020", "C030", "C040", "C050", "C060", "C070", "C080", "C090", "C100", "C110", "C120", "C130", "C140", "C150", "C160", "C170", "C180", "C190", "C200", "C210", "C220", "C230", "C231", "C240", "C250", "C260", "C270", "C280", "C290", "C300", "C310", "C320", "C330", "C340", "C350", "C360", "C370", "C380", "C390", "C400", "C401", "C402", "C410", "C420", "C430", "C440", "C450", "C460", "C470", "C480", "C490", "C500", "C510", "C520", "C530", "C531", "C540", "C550", "C560", "C570", "C580", "C590", "C600", "C610", "C630", "C640", "C650", "C660", "C670", "C675", "C680", "C690", "C700", "C710", "C720", "C730", "C740", "C750", "C760", "C770", "C780", "C790", "C800", "C810", "C820", "C830", "C840", "C850", "C860", "C870", "C880", "C890", "C900", "C910", "C920", "C930", "C940", "C950", "C960", "C970", "C980", "C990", "CA2T", "CA4T", "CFCT", "CFLT", "CGTT", "CLDT", "COMM", "CRLT", "CTLT", "CUFT", "D000", "D010", "D015", "D020", "D025", "D030", "D040", "D050", "D060", "D070", "D080", "D100", "D101", "D103", "D110", "D120", "D130", "D140", "D141", "D142", "D143", "D144", "D150", "D160", "D170", "D180", "D190", "D200", "D210", "D220", "D230", "D240", "D242", "D244", "D246", "D250", "D260", "D270", "D280", "D290", "D292", "D300", "D301", "D310", "D320", "D330", "D340", "D350", "D360", "D370", "D380", "D390", "D400", "D410", "D420", "D430", "D440", "D450", "D460", "D470", "D480", "D490", "D500", "D501", "D502", "D510", "D520", "D530", "D540", "D550", "D560", "D570", "D580", "D590", "D600", "D610", "D620", "D630", "D640", "D650", "D655", "D660", "D670", "D680", "D690", "D700", "D701", "D710", "D711", "D720", "D730", "D740", "D750", "D760", "D770", "D780", "D790", "D800", "D810", "D820", "D830", "D840", "D850", "D860", "D870", "D880", "D890", "D900", "D910", "D920", "D930", "D940", "D950", "D960", "D970", "D980", "D990", "D995", "DCET", "DCVT", "DDZT", "DEZT", "DFDT", "DGET", "DOVT", "DPDT", "DPET", "E000", "E010", "E020", "E022", "E030", "E040", "E050", "E060", "E063", "E065", "E067", "E068", "E069", "E070", "E080", "E090", "E100", "E110", "E120", "E130", "E140", "E150", "E160", "E170", "E180", "E190", "E191", "E192", "E193", "E200", "E210", "E220", "E230", "E240", "E250", "E260", "E270", "E280", "E290", "E300", "E310", "E320", "E330", "E340", "E350", "E360", "E370", "E380", "E381", "E382", "E384", "E386", "E388", "E389", "E390", "E400", "E410", "E420", "E430", "E440", "E450", "E460", "E470", "E480", "E485", "E490", "E500", "E510", "E520", "E530", "E540", "E550", "E560", "E570", "E580", "E585", "E590", "E600", "E610", "E620", "E630", "E640", "E650", "E660", "E670", "E680", "E690", "E695", "E700", "E710", "E720", "E730", "E740", "E750", "E760", "E770", "E780", "E790", "E800", "E805", "E810", "E820", "E830", "E840", "E850", "E860", "E870", "E880", "E890", "E900", "E910", "E920", "E930", "E940", "E950", "E960", "E970", "E980", "E990", "ENGA", "EXLT", "F000", "F010", "F020", "F030", "F040", "F050", "F060", "F061", "F062", "F063", "F065", "F067", "F070", "F080", "F090", "F100", "F110", "F120", "F130", "F140", "F150", "F155", "F160", "F170", "F180", "F190", "F200", "F210", "F220", "F225", "F230", "F240", "F250", "F260", "F270", "F271", "F272", "F280", "F290", "F300", "F310", "F320", "F330", "F340", "F350", "F360", "F370", "F380", "F390", "F400", "F401", "F410", "F420", "F430", "F440", "F445", "F450", "F460", "F465", "F470", "F480", "F490", "F500", "F510", "F520", "F530", "F540", "F550", "F560", "F570", "F580", "F590", "F600", "F610", "F620", "F630", "F640", "F650", "F660", "F670", "F680", "F690", "F700", "F710", "F720", "F730", "F740", "F750", "F760", "F770", "F780", "F790", "F800", "F810", "F820", "F830", "F840", "F850", "F860", "F870", "F880", "F890", "F900", "F910", "F920", "F930", "F940", "F950", "F960", "F970", "F980", "F990", "F991", "FAKT", "FLST", "G000", "G010", "G020", "G025", "G030", "G040", "G050", "G060", "G070", "G080", "G090", "G100", "G110", "G120", "G130", "G140", "G150", "G160", "G170", "G180", "G190", "G200", "G210", "G220", "G230", "G240", "G250", "G260", "G270", "G280", "G290", "G300", "G310", "G320", "G322", "G324", "G326", "G328", "G329", "G330", "G340", "G350", "G360", "G370", "G380", "G390", "G400", "G410", "G420", "G430", "G440", "G450", "G460", "G470", "G480", "G490", "G500", "G510", "G520", "G530", "G540", "G550", "G560", "G570", "G580", "G590", "G600", "G610", "G620", "G630", "G640", "G650", "G660", "G670", "G680", "G690", "G700", "G710", "G720", "G730", "G740", "G750", "G760", "G770", "G775", "G780", "G790", "G800", "G810", "G820", "G821", "G830", "G840", "G850", "G860", "G870", "G880", "G890", "G900", "G910", "G920", "G930", "G940", "G950", "G960", "G970", "G980", "G990", "GMST", "H000", "H010", "H020", "H030", "H040", "H050", "H060", "H070", "H080", "H090", "H100", "H110", "H120", "H130", "H140", "H150", "H151", "H160", "H170", "H180", "H190", "H200", "H210", "H215", "H220", "H230", "H240", "H250", "H260", "H270", "H280", "H290", "H300", "H310", "H320", "H330", "H340", "H350", "H360", "H370", "H380", "H390", "H400", "H410", "H420", "H430", "H440", "H450", "H460", "H470", "H480", "H490", "H500", "H505", "H507", "H510", "H520", "H530", "H535", "H540", "H550", "H551", "H560", "H570", "H580", "H590", "H600", "H605", "H610", "H620", "H625", "H630", "H640", "H650", "H660", "H670", "H680", "H690", "H700", "H710", "H720", "H730", "H740", "H750", "H760", "H770", "H780", "H790", "H800", "H806", "H810", "H820", "H830", "H840", "H850", "H855", "H860", "H870", "H880", "H890", "H900", "H910", "H920", "H930", "H935", "H940", "H950", "H960", "H970", "H980", "H990", "HZDT", "I000", "I010", "I020", "I030", "I040", "I050", "I060", "I070", "I080", "I090", "I100", "I110", "I120", "I130", "I131", "I132", "I133", "I134", "I136", "I138", "I140", "I150", "I160", "I170", "I180", "I190", "I200", "I210", "I220", "I230", "I240", "I250", "I260", "I270", "I280", "I290", "I300", "I310", "I320", "I330", "I340", "I350", "I360", "I370", "I380", "I390", "I400", "I410", "I411", "I420", "I430", "I431", "I432", "I440", "I450", "I460", "I470", "I480", "I490", "I495", "I500", "I510", "I520", "I530", "I540", "I550", "I560", "I570", "I580", "I590", "I595", "I600", "I610", "I620", "I630", "I640", "I650", "I660", "I670", "I680", "I690", "I700", "I710", "I720", "I730", "I740", "I750", "I760", "IDCT", "LC2T", "LC4T", "LCLT", "LECT", "LFDT", "LMDT", "LNDT", "LPDT", "LQDT", "LTET", "MATT", "OCNT", "OFFA", "OODT", "OTHR", "OWCT", "PRST", "PTAX", "PVPT", "R020", "R030", "R040", "R060", "R080", "RDHT", "RFMT", "RPDT", "RSTT", "SFBT", "SFDT", "SFET", "SSCT", "SSUT", "STDT", "STFT", "STOT", "TERT", "VCLT", "WBBT", "WCFT", "WFTT", "WRBT", "WRIT", "ZZZZ" })]
        public string ServicePromotionAllowanceChargeCode { get; set; }

        [EdiValue("X(2)", Path = "SAC/2", Description = "SAC03 - Agency Qualifier Code")]
        [EdiExtension(MinLength = 2, MaxLength = 2, Mandatory = false, EdiType = EdiType.Identifier)]
        [EdiAllowValue(AllowedValues = new string[] { "10 ", "11 ", "12 ", "13 ", "14 ", "15 ", "16 ", "17 ", "18 ", "19 ", "20 ", "21 ", "22 ", "23 ", "24 ", "25 ", "26 ", "27 ", "28 ", "29 ", "30 ", "31 ", "32 ", "33 ", "34 ", "35 ", "36 ", "37 ", "38 ", "39 ", "40 ", "41 ", "42 ", "43 ", "44 ", "45 ", "46 ", "47 ", "48 ", "49 ", "50 ", "51 ", "52 ", "53 ", "54 ", "55 ", "56 ", "57 ", "58 ", "59 ", "60 ", "93 ", "94 ", "A1 ", "A2 ", "A3 ", "A4 ", "AA ", "AB ", "AC ", "AD ", "AE ", "AG ", "AH ", "AI ", "AJ ", "AL ", "AM ", "AP ", "AQ ", "AS ", "AT ", "AW ", "AX ", "AY ", "BE ", "BF ", "BI ", "CA ", "CB ", "CC ", "CE ", "CI ", "CL ", "CM ", "CO ", "CR ", "CS ", "CU ", "CX ", "DA ", "DD ", "DE ", "DF ", "DI ", "DL ", "DN ", "DO ", "DR ", "DS ", "DX ", "DY ", "DZ ", "EI ", "EP ", "ES ", "ET ", "EU ", "EX ", "FA ", "FC ", "FD ", "FG ", "FH ", "FI ", "GC ", "GS ", "GU ", "HC ", "HI ", "HS ", "HU ", "IA ", "IB ", "IC ", "IM ", "IN ", "IS ", "JA ", "LA ", "LB ", "LI ", "MA ", "MB ", "MC ", "ME ", "MI ", "MP ", "MS ", "MV ", "NA ", "NB ", "NC ", "NE ", "NF ", "NG ", "NI ", "NR ", "NS ", "NT ", "NU ", "NW ", "OI ", "OP ", "OS ", "PA ", "PC ", "SA ", "SE ", "SL ", "SP ", "ST ", "TA ", "TB ", "TC ", "TD ", "TI ", "TM ", "TP ", "TR ", "TX ", "UC ", "UN ", "VI ", "WH ", "ZZ " })]
        public string AgencyQualifierCode { get; set; }

        [EdiValue("X(10)", Path = "SAC/3", Description = "SAC04 - Agency Service, Promotion, Allowance, or Charge Code")]
        [EdiExtension(MinLength = 1, MaxLength = 10, Mandatory = false, EdiType = EdiType.Alphanumeric)]
        public string AgencyServicePromotionAllowanceOrChargeCode { get; set; }

        [EdiValue("9(15)", Format = "N2", Path = "SAC/4", Description = "SAC05 - Amount")]
        [EdiExtension(MinLength = 1, MaxLength = 15, Mandatory = false, EdiType = EdiType.Decimal)]
        public string Amount { get; set; }

        [EdiValue("X(1)", Path = "SAC/5", Description = "SAC06 - Allowance/Charge Percent Qualifier")]
        [EdiExtension(MinLength = 1, MaxLength = 1, Mandatory = false, EdiType = EdiType.Identifier)]
        [EdiAllowValue(AllowedValues = new string[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "A", "Z" })]
        public string AllowanceChargePercentQualifier { get; set; }

        [EdiValue("9(6)", Format = "R", Path = "SAC/6", Description = "SAC07 - Percent")]
        [EdiExtension(MinLength = 1, MaxLength = 6, Mandatory = false, EdiType = EdiType.Decimal)]
        public string Percent { get; set; }

        [EdiValue("9(9)", Format = "R", Path = "SAC/7", Description = "SAC08 - Rate")]
        [EdiExtension(MinLength = 1, MaxLength = 9, Mandatory = false, EdiType = EdiType.Decimal)]
        public string Rate { get; set; }

        [EdiValue("X(2)", Path = "SAC/8", Description = "SAC09 - Unit or Basis for Measurement Code")]
        [EdiExtension(MinLength = 2, MaxLength = 2, Mandatory = false, EdiType = EdiType.Identifier)]
        [EdiAllowValue(AllowedValues = new string[] { "01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "1A", "1B", "1C", "1D", "1E", "1F", "1G", "1H", "1I", "1J", "1K", "1L", "1M", "1N", "1O", "1P", "1Q", "1R", "1X", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "2A", "2B", "2C", "2F", "2G", "2H", "2I", "2J", "2K", "2L", "2M", "2N", "2P", "2Q", "2R", "2U", "2V", "2W", "2X", "2Y", "2Z", "30", "31", "32", "33", "34", "35", "36", "37", "38", "39", "3B", "3C", "3E", "3F", "3G", "3H", "3I", "40", "41", "43", "44", "45", "46", "47", "48", "4A", "4B", "4C", "4D", "4E", "4F", "4G", "4H", "4I", "4J", "4K", "4L", "4M", "4N", "4O", "4P", "4Q", "4R", "4S", "4T", "4U", "4V", "4W", "4X", "50", "51", "52", "53", "54", "56", "57", "58", "59", "5A", "5B", "5C", "5E", "5F", "5G", "5H", "5I", "5J", "5K", "5P", "5Q", "60", "61", "62", "63", "64", "65", "66", "67", "68", "69", "70", "71", "72", "73", "74", "76", "77", "78", "79", "80", "81", "82", "83", "84", "85", "86", "87", "89", "8C", "8D", "8P", "8R", "8S", "8U", "90", "91", "92", "93", "94", "95", "96", "97", "98", "99", "A8", "AA", "AB", "AC", "AD", "AE", "AF", "AG", "AH", "AI", "AJ", "AK", "AL", "AM", "AN", "AO", "AP", "AQ", "AR", "AS", "AT", "AU", "AV", "AW", "AX", "AY", "AZ", "B0", "B1", "B2", "B3", "B4", "B5", "B6", "B7", "B8", "B9", "BA", "BB", "BC", "BD", "BE", "BF", "BG", "BH", "BI", "BJ", "BK", "BL", "BM", "BN", "BO", "BP", "BQ", "BR", "BS", "BT", "BU", "BV", "BW", "BX", "BY", "BZ", "C0", "C1", "C2", "C3", "C4", "C5", "C6", "C7", "C8", "C9", "CA", "CB", "CC", "CD", "CE", "CF", "CG", "CH", "CI", "CJ", "CK", "CL", "CM", "CN", "CO", "CP", "CQ", "CR", "CS", "CT", "CU", "CV", "CW", "CX", "CY", "CZ", "D2", "D3", "D5", "D8", "D9", "DA", "DB", "DC", "DD", "DE", "DF", "DG", "DH", "DI", "DJ", "DK", "DL", "DM", "DN", "DO", "DP", "DQ", "DR", "DS", "DT", "DU", "DW", "DX", "DY", "DZ", "E1", "E3", "E4", "E5", "E7", "E8", "E9", "EA", "EB", "EC", "ED", "EE", "EF", "EG", "EH", "EJ", "EM", "EP", "EQ", "EV", "EX", "EY", "EZ", "F1", "F2", "F3", "F4", "F5", "F6", "F9", "FA", "FB", "FC", "FD", "FE", "FF", "FG", "FH", "FJ", "FK", "FL", "FM", "FO", "FP", "FR", "FS", "FT", "FZ", "G2", "G3", "G4", "G5", "G7", "GA", "GB", "GC", "GD", "GE", "GF", "GG", "GH", "GI", "GJ", "GK", "GL", "GM", "GN", "GO", "GP", "GQ", "GR", "GS", "GT", "GU", "GV", "GW", "GX", "GY", "GZ", "H1", "H2", "H4", "HA", "HB", "HC", "HD", "HE", "HF", "HG", "HH", "HI", "HJ", "HK", "HL", "HM", "HN", "HO", "HP", "HQ", "HR", "HS", "HT", "HU", "HV", "HW", "HY", "HZ", "IA", "IB", "IC", "IE", "IF", "IH", "II", "IK", "IL", "IM", "IN", "IP", "IT", "IU", "IV", "IW", "J2", "JA", "JB", "JE", "JG", "JK", "JM", "JO", "JR", "JU", "K1", "K2", "K3", "K4", "K5", "K6", "K7", "K9", "KA", "KB", "KC", "KD", "KE", "KF", "KG", "KH", "KI", "KJ", "KK", "KL", "KM", "KO", "KP", "KQ", "KR", "KS", "KT", "KU", "KV", "KW", "KX", "L2", "LA", "LB", "LC", "LE", "LF", "LG", "LH", "LI", "LJ", "LK", "LL", "LM", "LN", "LO", "LP", "LQ", "LR", "LS", "LT", "LX", "LY", "M0", "M1", "M2", "M3", "M4", "M5", "M6", "M7", "M8", "M9", "MA", "MB", "MC", "MD", "ME", "MF", "MG", "MH", "MI", "MJ", "MK", "ML", "MM", "MN", "MO", "MP", "MQ", "MR", "MS", "MT", "MU", "MV", "MW", "MX", "MY", "MZ", "N1", "N2", "N3", "N4", "N6", "N7", "N9", "NA", "NB", "NC", "ND", "NE", "NF", "NG", "NH", "NI", "NJ", "NL", "NM", "NN", "NQ", "NR", "NS", "NT", "NU", "NV", "NW", "NX", "NY", "OA", "OC", "ON", "OP", "OT", "OZ", "P0", "P1", "P2", "P3", "P4", "P5", "P6", "P7", "P8", "P9", "PA", "PB", "PC", "PD", "PE", "PF", "PG", "PH", "PI", "PJ", "PK", "PL", "PM", "PN", "PO", "PP", "PQ", "PR", "PS", "PT", "PU", "PV", "PW", "PX", "PY", "PZ", "Q1", "Q2", "Q3", "Q4", "Q5", "Q6", "Q7", "QA", "QB", "QC", "QD", "QE", "QH", "QK", "QR", "QS", "QT", "QU", "R1", "R2", "R3", "R4", "R5", "R6", "R7", "R8", "R9", "RA", "RB", "RC", "RD", "RE", "RG", "RH", "RK", "RL", "RM", "RN", "RO", "RP", "RS", "RT", "RU", "S1", "S2", "S3", "S4", "S5", "S6", "S7", "S8", "S9", "SA", "SB", "SC", "SD", "SE", "SF", "SG", "SH", "SI", "SJ", "SK", "SL", "SM", "SN", "SO", "SP", "SQ", "SR", "SS", "ST", "SV", "SW", "SX", "SY", "SZ", "T0", "T1", "T2", "T3", "T4", "T5", "T6", "T7", "T8", "T9", "TA", "TB", "TC", "TD", "TE", "TF", "TG", "TH", "TI", "TJ", "TK", "TL", "TM", "TN", "TO", "TP", "TQ", "TR", "TS", "TT", "TU", "TV", "TW", "TX", "TY", "TZ", "U1", "U2", "U3", "U5", "UA", "UB", "UC", "UD", "UE", "UF", "UH", "UL", "UM", "UN", "UP", "UQ", "UR", "US", "UT", "UU", "UV", "UW", "UX", "UY", "UZ", "V1", "V2", "VA", "VC", "VI", "VP", "VR", "VS", "W2", "WA", "WB", "WD", "WE", "WG", "WH", "WI", "WK", "WM", "WP", "WR", "WW", "X1", "X2", "X3", "X4", "X5", "X6", "X7", "X8", "X9", "XP", "Y1", "Y2", "Y3", "Y4", "YD", "YL", "YR", "YT", "Z1", "Z2", "Z3", "Z4", "Z5", "Z6", "Z8", "ZA", "ZB", "ZC", "ZP", "ZZ" })]

        public string UnitOrBasisForMeasurementCode { get; set; }

        [EdiValue("X(10)", Format = "R", Path = "SAC/9", Description = "SAC10 - Quantity")]
        [EdiExtension(MinLength = 1, MaxLength = 10, Mandatory = false, EdiType = EdiType.Decimal)]
        public string Quantity { get; set; }

        [EdiValue("X(10)", Format = "R", Path = "SAC/10", Description = "SAC11 - Quantity of Free Goods")]
        [EdiExtension(MinLength = 1, MaxLength = 10, Mandatory = false, EdiType = EdiType.Decimal)]
        public string QuantityOfFreeGoods { get; set; }

        [EdiValue("X(2)", Path = "SAC/11", Description = "SAC12 - Allowance or Charge Method of Handling")]
        [EdiExtension(MinLength = 2, MaxLength = 2, Mandatory = false, EdiType = EdiType.Identifier)]
        [EdiAllowValue(AllowedValues = new string[] { "01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12", "13", "15", "18", "20", "21", "25", "CA", "CC", "PP", "ZZ" })]

        public string AllowanceOrChargeMethodOfHandling { get; set; }

        [EdiValue("X(30)", Path = "SAC/12", Description = "SAC13 - Reference Identification")]
        [EdiExtension(MinLength = 1, MaxLength = 30, Mandatory = false, EdiType = EdiType.Alphanumeric)]
        public string ReferenceIdentification { get; set; }

        [EdiValue("X(20)", Path = "SAC/13", Description = "SAC14 - Option Number")]
        [EdiExtension(MinLength = 1, MaxLength = 20, Mandatory = false, EdiType = EdiType.Alphanumeric)]
        public string OptionNumber { get; set; }

        [EdiValue("X(80)", Path = "SAC/14", Description = "SAC15 - Description")]
        [EdiExtension(MinLength = 1, MaxLength = 80, Mandatory = false, EdiType = EdiType.Alphanumeric)]
        public string Description { get; set; }

        [EdiValue("X(80)", Path = "SAC/15", Description = "SAC16 - Language Code")]
        [EdiExtension(MinLength = 1, MaxLength = 3, Mandatory = false, EdiType = EdiType.Alphanumeric)]
        public string LanguageCode { get; set; }
    }
}