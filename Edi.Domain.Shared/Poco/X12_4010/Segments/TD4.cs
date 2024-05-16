using Edi.Domain.Shared.Attributes;
using Edi.Domain.Shared.Enums;
using indice.Edi.Serialization;
using Scm.Edi.Domain.Shared.Attributes;

namespace Edi.Domain.Shared.Poco.X12_4010.Segments
{
    [EdiSegment]
    [EdiPath("TD4")]
    public class TD4
    {
        [EdiValue("X(3)", Path = "TD4/0", Description = "TD401 - Special Handling Code ")]
        [EdiExtension(MinLength = 4, MaxLength = 4, Mandatory = true, EdiType = EdiType.Identifier)]
        [EdiAllowValue(AllowedValues = new string[] { "15", "25", "35", "45", "AB", "AK", "AT", "AV", "AW", "BA", "BL", "BN", "BW", "CC", "CD", "CE", "CF", "CH", "CI", "CM", "CO", "CR", "CW", "CX", "CY", "DA", "DE", "DM", "DN", "DR", "DS", "DT", "DU", "DV", "DW", "ED", "EE", "EL", "EP", "ER", "EV", "EW", "EX", "FA", "FB", "FC", "FD", "FG", "FL", "FP", "FR", "FS", "GI", "HE", "HH", "HM", "HO", "HP", "HR", "HT", "HV", "HW", "IB", "IC", "ID", "IM", "IP", "IR", "IS", "JS", "LB", "LC", "LD", "LF", "LN", "LP", "LR", "LS", "LT", "MC", "MF", "MP", "MR", "NC", "ND", "NE", "NH", "NI", "NP", "NS", "NT", "NW", "NX", "OS", "OV", "PB", "PD", "PG", "PI", "PS", "PW", "RA", "RB", "RC", "RM", "RO", "RR", "RS", "RT", "SB", "SC", "SD", "SE", "SH", "SI", "SK", "SM", "SP", "SR", "ST", "SW", "TA", "TC", "TF", "TN", "TS", "TT", "TV", "UB", "UI", "UL", "UN", "UP", "UR", "US", "VN", "VT", "WB", "WD", "WE", "WH", "WI", "WM", "WO", "WW", "XP", "XT", "045", "170", "510", "520", "550", "555", "565", "570", "585", "665", "670", "675", "761", "A1M", "A3M", "A5M", "AAS", "ADL", "AFN", "AGG", "AGS", "AIB", "ALP", "ALT", "AMM", "ANC", "APD", "APL", "ARC", "ARG", "ARR", "ART", "ASY", "AUX", "BCP", "BKA", "BLK", "BLS", "BNS", "BOX", "BU2", "BU4", "BUA", "CA2", "CA4", "CAR", "CCB", "CCH", "CCS", "CDD", "CFC", "CFL", "CGC", "CGR", "CGT", "CHN", "CIP", "CIS", "CLN", "CLS", "CMD", "CNL", "CNS", "CON", "COR", "COU", "COV", "CPC", "CPM", "CRL", "CSD", "CSP", "CTL", "CTM", "CTR", "CUF", "DBL", "DBP", "DCS", "DDN", "DDP", "DDS", "DDZ", "DEL", "DEP", "DET", "DEZ", "DFD", "DFM", "DFS", "DIS", "DLP", "DLR", "DNC", "DNF", "DNT", "DOC", "DOV", "DPB", "DPD", "DPE", "DPL", "DPT", "DPU", "DRO", "DRU", "DSK", "DSM", "DSR", "DSV", "DTB", "DTP", "DTV", "DWP", "EAX", "ECR", "ECS", "EDD", "EDO", "EED", "ELS", "EMR", "EMT", "END", "ERS", "ERT", "EXC", "EXD", "EXL", "EXO", "EXP", "EXQ", "EXT", "EXU", "EXZ", "EZE", "FAK", "FAS", "FCS", "FFC", "FFS", "FLS", "FPT", "FRZ", "FST", "FTR", "GMS", "GOC", "GSP", "GSS", "HAL", "HAN", "HBR", "HDH", "HDW", "HEA", "HES", "HET", "HMA", "HMI", "HOL", "HOR", "HOS", "HOX", "HQT", "HRS", "HTI", "HZC", "HZD", "IDC", "IDL", "IIH", "IMP", "IMS", "INT", "IPU", "ITS", "JIT", "JLX", "KEG", "KMD", "LAB", "LAY", "LBL", "LBR", "LBT", "LC2", "LC4", "LCL", "LEC", "LFD", "LHS", "LIE", "LMD", "LME", "LPD", "LTE", "LTT", "LYC", "MAT", "MEN", "MES", "MET", "MIN", "MNS", "MOT", "MRF", "MSS", "MTE", "MVS", "NHC", "NHL", "NPR", "NSV", "OAH", "OBL", "OCA", "OCL", "OCN", "OCS", "OCV", "ODI", "OEH", "OFH", "OFU", "OHC", "OIL", "ONC", "ONS", "OOB", "OOD", "OOL", "OPR", "OPT", "OSB", "OST", "OTC", "OTD", "OTH", "OTO", "OTS", "OUC", "OUW", "OVR", "OWC", "OWR", "PAJ", "PAV", "PDS", "PDY", "PER", "PFH", "PHR", "PIR", "PMM", "PMR", "PMS", "PMT", "POC", "PPD", "PRL", "PRT", "PSG", "PSS", "PTS", "PUC", "PUD", "PUK", "PUP", "PVB", "PVD", "PVI", "PVL", "PVP", "PVS", "PVT", "PYS", "RCC", "RCL", "RDH", "RDR", "REP", "RES", "RFM", "RIE", "RLS", "RMC", "RMP", "RMS", "RPD", "RRR", "RSP", "RSS", "RSV", "RWR", "SAS", "SAT", "SCC", "SCL", "SDL", "SDS", "SEC", "SED", "SEE", "SER", "SEV", "SFB", "SFD", "SFE", "SFT", "SGL", "SHH", "SHL", "SHW", "SKT", "SLC", "SMP", "SMS", "SNM", "SNS", "SNT", "SOC", "SOL", "SPC", "SPR", "SPT", "SPU", "SRG", "SRS", "SSC", "SSN", "SSU", "STA", "STD", "STO", "STP", "STR", "SUA", "SUB", "SUP", "SVS", "TDC", "TDP", "TER", "TLS", "TMS", "TMV", "TOF", "TPS", "TRA", "TRK", "TRL", "TRM", "TRN", "TRP", "TRS", "TRT", "TSC", "TSP", "TSS", "UFC", "UPK", "URC", "UTL", "VAC", "VAN", "VCL", "VFN", "VIS", "VSO", "VTS", "WBB", "WCT", "WDS", "WFG", "WRB", "WRI", "WTV", "ZZZ" })]

        public string SpecialHandlingCode { get; set; }

        [EdiValue("X(1)", Path = "TD4/1", Description = "TD402 - Hazardous Material Code Qualifier")]
        [EdiExtension(MinLength = 1, MaxLength = 1, Mandatory = false, EdiType = EdiType.Identifier)]
        [EdiAllowValue(AllowedValues = new string[] { "4", "6", "9", "A", "C", "D", "E", "F", "I", "R", "T", "U", "X" })]

        public string HazardousMaterialCodeQualifier { get; set; }

        [EdiValue("X(4)", Path = "TD4/2", Description = "TD403 - Hazardous Material Class Code")]
        [EdiExtension(MinLength = 1, MaxLength = 4, Mandatory = false, EdiType = EdiType.Alphanumeric)]
        public string HazardousMaterialClassCode { get; set; }

        [EdiValue("X(2)", Path = "TD4/3", Description = "TD404 - Description")]
        [EdiExtension(MinLength = 1, MaxLength = 80, Mandatory = true, EdiType = EdiType.Alphanumeric)]
        public string Description { get; set; }

        [EdiValue("X(1)", Path = "TD4/4", Description = "TD405 - Yes/No Condition or Response Code")]
        [EdiExtension(MinLength = 1, MaxLength = 1, Mandatory = false, EdiType = EdiType.Identifier)]
        [EdiAllowValue(AllowedValues = new string[] { "N", "U", "W", "Y" })]

        public string YesOrNoConditionOrResponseCode { get; set; }
    }
}
