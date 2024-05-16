using System.Collections.Generic;
using Edi.Application.Contracts.Poco.X12_4010.Segments;
using Edi.Domain.Shared.Enums;
using Edi.Domain.Shared.Ultilities;
using indice.Edi.Serialization;
using Scm.Edi.Domain.Shared.Attributes;
using Scm.Edi.Dtos.X12_4010.Common;

namespace Edi.Application.Contracts.Poco.X12_4010
{
    /// <summary>
    /// EDI 850 Basic: Message
    /// </summary>
    [EdiMessage]
    public class X12_850_Message : X12_Transaction
    {
        [EdiValue("X(2)", Path = "BEG/0", Description = "BEG01 - Transation Set Purpose Code")]
        [EdiExtension(MinLength = 2, MaxLength = 2, Mandatory = true, EdiType = EdiType.Identifier)]
        [EdiAllowValue(AllowedValues = new string[] { "00", "01", "02", "03", "04", "05", "06", "07", "08", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "24", "25", "26", "27", "28", "30", "31", "32", "33", "34", "35", "36", "37", "38", "39", "40", "41", "42", "43", "44", "45", "46", "47", "48", "49", "50", "51", "52", "53", "54", "55", "56", "5C", "77", "CN", "CO", "EX", "GR", "PR", "RH", "RV", "SU", "ZZ" })]
        public string TransactionSetPurposeCode { get; set; }

        [EdiValue("X(2)", Path = "BEG/1", Description = "BEG02 - Purchase Order Type Code")]
        [EdiExtension(MinLength = 2, MaxLength = 2, Mandatory = true, EdiType = EdiType.Identifier)]
        [EdiAllowValue(AllowedValues = new string[] { "AB", "AC", "AO", "BD", "BE", "BH", "BK", "BL", "BQ", "BY", "CA", "CC", "CF", "CN", "CO", "CP", "CR", "DR", "DS", "EO", "FH", "IN", "JL", "KA", "KB", "KC", "KD", "KE", "KG", "KI", "KN", "KO", "KP", "KQ", "KR", "KS", "KT", "LB", "LS", "NE", "NO", "NP", "NS", "OS", "PR", "RA", "RC", "RE", "RL", "RN", "RO", "RR", "RT", "RU", "RW", "SA", "SO", "SP", "SS", "ST", "SW", "TC", "TM", "TR", "UD", "UE", "US", "WO", "ZZ" })]
        public string PurchaseOrderTypeCode { get; set; }

        [EdiValue("X(22)", Path = "BEG/2", Description = "BEG03 - Purchase Order Number")]
        [EdiExtension(MinLength = 1, MaxLength = 22, Mandatory = true, EdiType = EdiType.Alphanumeric)]
        public string PurchaseOrderNumber { get; set; }

        [EdiValue("X(30)", Path = "BEG/3", Description = "BEG04 - Release Number")]
        [EdiExtension(MinLength = 1, MaxLength = 30, Mandatory = false, EdiType = EdiType.Alphanumeric)]
        public string ReleaseNumber { get; set; }

        [EdiValue("X(8)", Path = "BEG/4", Format = "yyyyMMdd", Description = "BEG05 - Date")]
        [EdiExtension(MinLength = 8, MaxLength = 8, Mandatory = true, EdiType = EdiType.Date)]
        public string PurchaseOrderDate { get; set; }

        [EdiValue("X(30)", Path = "BEG/5", Description = "BEG06 - Contract Number")]
        [EdiExtension(MinLength = 1, MaxLength = 30, Mandatory = false, EdiType = EdiType.Alphanumeric)]
        public string ContractNumber { get; set; }

        [EdiValue("X(2)", Path = "BEG/6", Description = "BEG07 - Acknowledgment Type")]
        [EdiExtension(MinLength = 2, MaxLength = 2, Mandatory = false, EdiType = EdiType.Identifier)]
        [EdiAllowValue(AllowedValues = new string[] { "AC", "AD", "AE", "AH", "AK", "AP", "AT", "NA", "RD", "RF", "RJ", "RN", "RO", "RV", "ZZ" })]
        public string AcknowledgmentType { get; set; }

        [EdiValue("X(3)", Path = "BEG/7", Description = "BEG08 - Invoice Type Code")]
        [EdiExtension(MinLength = 3, MaxLength = 3, Mandatory = false, EdiType = EdiType.Identifier)]
        [EdiAllowValue(AllowedValues = new string[] { "IBM", "IEL", "INR" })]

        public string InvoiceTypeCode { get; set; }

        [EdiValue("X(2)", Path = "BEG/8", Description = "BEG09 - Contract Type Code")]
        [EdiExtension(MinLength = 2, MaxLength = 2, Mandatory = false, EdiType = EdiType.Identifier)]
        [EdiAllowValue(AllowedValues = new string[] { "01", "02", "03", "04", "05", "06", "09", "AB", "AC", "AD", "AE", "AF", "AG", "AH", "AI", "AJ", "CA", "CB", "CH", "CP", "CS", "CW", "CX", "CY", "DI", "EA", "ER", "FA", "FB", "FC", "FD", "FE", "FF", "FG", "FH", "FI", "FJ", "FK", "FL", "FM", "FR", "FX", "LA", "LE", "LH", "OC", "PR", "SP", "TM", "ZZ" })]

        public string ContractTypeCode { get; set; }

        [EdiValue("X(2)", Path = "BEG/9", Description = "BEG10 - Purchase Category")]
        [EdiExtension(MinLength = 2, MaxLength = 2, Mandatory = false, EdiType = EdiType.Identifier)]
        [EdiAllowValue(AllowedValues = new string[] { "AE", "CN", "DR", "ER", "HW", "IR", "MD", "OV", "RD", "RE", "SB", "SP", "SU", "SV", "TE", "UT" })]

        public string PurchaseCategory { get; set; }

        [EdiValue("X(2)", Path = "BEG/10", Description = "BEG11 - Security Level Code")]
        [EdiExtension(MinLength = 2, MaxLength = 2, Mandatory = false, EdiType = EdiType.Identifier)]
        [EdiAllowValue(AllowedValues = new string[] { "00", "01", "02", "03", "04", "05", "06", "09", "11", "20", "21", "90", "92", "93", "94", "99", "ZZ" })]

        public string SecurityLevelCode { get; set; }

        [EdiValue("X(2)", Path = "BEG/11", Description = "BEG12 - Transaction Type Code")]
        [EdiExtension(MinLength = 2, MaxLength = 2, Mandatory = false, EdiType = EdiType.Identifier)]
        [EdiAllowValue(AllowedValues = new string[] { "01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "33", "34", "35", "36", "37", "38", "39", "3M", "40", "41", "60", "62", "63", "64", "65", "66", "67", "68", "69", "6A", "6C", "6N", "6R", "6S", "70", "71", "72", "73", "74", "75", "76", "77", "78", "79", "80", "81", "82", "83", "85", "87", "88", "91", "94", "95", "97", "98", "99", "A0", "A1", "A3", "A4", "A5", "A6", "A7", "AA", "AB", "AC", "AD", "AE", "AF", "AG", "AI", "AM", "AN", "AP", "AQ", "AR", "AS", "AT", "AV", "AW", "AZ", "BA", "BB", "BD", "BF", "BH", "BJ", "BK", "BL", "BM", "BN", "BO", "BP", "BR", "BS", "BT", "BU", "BV", "BW", "C0", "C1", "C2", "C3", "CA", "CB", "CC", "CD", "CE", "CF", "CG", "CH", "CI", "CJ", "CK", "CL", "CM", "CN", "CO", "CP", "CR", "CS", "CT", "CU", "CV", "CW", "CX", "CY", "CZ", "D1", "D4", "DA", "DB", "DC", "DD", "DE", "DF", "DG", "DH", "DI", "DK", "DL", "DN", "DO", "DP", "DQ", "DR", "DS", "DT", "DU", "EA", "EB", "EF", "EI", "EM", "EP", "ER", "EX", "FA", "FB", "FC", "FD", "FE", "FF", "FG", "FI", "FL", "FM", "FN", "FP", "FR", "FS", "FT", "GA", "GI", "GR", "HP", "I1", "IA", "IB", "IC", "ID", "IE", "IF", "II", "IM", "IN", "IO", "IR", "IU", "IW", "IX", "IZ", "JM", "JO", "JR", "JS", "JU", "JX", "KB", "KC", "KD", "KE", "KF", "KG", "KH", "KI", "KJ", "KK", "KL", "KM", "KN", "KS", "KT", "LC", "LD", "LE", "LF", "LN", "LO", "LP", "LR", "LV", "M1", "MA", "MB", "MC", "MD", "ME", "MF", "MI", "ML", "MM", "MP", "MR", "MS", "MU", "N1", "N2", "N3", "N4", "N5", "N6", "N7", "N8", "NA", "NB", "NC", "ND", "NE", "NF", "NG", "NH", "NI", "NJ", "NK", "NL", "NM", "NO", "NP", "NQ", "NR", "NT", "NU", "OC", "OF", "OP", "OR", "P1", "PA", "PB", "PC", "PD", "PE", "PF", "PG", "PI", "PL", "PM", "PO", "PP", "PR", "PS", "PT", "PU", "PV", "PW", "PX", "PZ", "QA", "QB", "QC", "QD", "QE", "QF", "QG", "QH", "QJ", "QK", "QL", "QP", "QR", "R1", "R2", "R3", "R4", "R5", "R6", "R7", "R8", "RA", "RB", "RC", "RD", "RE", "RF", "RG", "RH", "RK", "RM", "RP", "RQ", "RS", "RT", "RU", "RZ", "S1", "S2", "S3", "S4", "SA", "SB", "SC", "SD", "SE", "SF", "SG", "SH", "SL", "SM", "SO", "SP", "SQ", "SR", "SS", "ST", "SU", "SV", "TD", "TG", "TH", "TI", "TJ", "TK", "TP", "TR", "TS", "TT", "TX", "U1", "U2", "U4", "U5", "U9", "UA", "UC", "UD", "UF", "UI", "UM", "UO", "UP", "UR", "UT", "V1", "VH", "VJ", "VL", "VM", "VN", "VO", "VP", "VQ", "VR", "W1", "W4", "W5", "WA", "WC", "WD", "WH", "WO", "WS", "WT", "X1", "XA", "XB", "XC", "XD", "XX", "XY", "XZ", "YI", "YR", "ZA", "ZB", "ZC", "ZD", "ZE", "ZF", "ZG", "ZH", "ZI", "ZJ", "ZK", "ZL", "ZM", "ZN", "ZO", "ZP", "ZQ", "ZR", "ZS", "ZT", "ZU", "ZW", "ZZ" })]

        public string TransactionTypeCode { get; set; }

        public CUR CUR { get; set; }

        public List<REF> REFs { get; set; }

        public PER PER { get; set; }

        public TAX TAX { get; set; }

        public FOB FOB { get; set; }

        public CTP CTP { get; set; }

        public List<PAM> PAMs { get; set; }

        public List<CSH> CSHes { get; set; }

        public TC2 TC2 { get; set; }

        public List<SACGroupHeader> SACGroups { get; set; }

        public ITD ITD { get; set; }

        public List<DIS> DISes { get; set; }

        public INC INC { get; set; }

        public List<DTM> DTMs { get; set; }

        public List<LDT> LDTs { get; set; }

        public List<LIN> LINs { get; set; }

        public SI SI { get; set; }

        public List<PID> PIDs { get; set; }

        public List<MEA> MEAs { get; set; }

        public List<PWK> PWKs { get; set; }

        public List<PKG> PKGs { get; set; }

        public List<TD1> TD1s { get; set; }

        public List<TD5> TD5s { get; set; }

        public List<TD3> TD3s { get; set; }

        public List<TD4> TD4s { get; set; }

        public List<MAN> MANs { get; set; }

        public PCT PCT { get; set; }

        public List<CTB> CTBs { get; set; }

        public TXI TXI { get; set; }

        public List<AMTGroupHeader> AMTGroups { get; set; }

        public List<N9GroupHeader> N9Groups { get; set; }

        public List<N1GroupHeader> N1Groups { get; set; }

        public List<LMGroup> LMGroups { get; set; }

        public List<SPIGroup> SPIGroups { get; set; }

        public List<ADVGroup> ADVGroups { get; set; }

        public List<OrderDetail> Items { get; set; }

        public List<CTTGroup> CTTGroups { get; set; }

        [EdiSegment]
        [EdiSegmentGroup("PO1", SequenceEnd = "CTT")]
        public class OrderDetail : PO1
        {
            public LIN LIN { get; set; }

            public SI SI { get; set; }

            public CUR CUR { get; set; }

            public CN1 CN1 { get; set; }

            public List<PO3> PO3s { get; set; }

            public List<CTPGroup> CTPGroups { get; set; }

            public List<PAM> PAMs { get; set; }

            public List<MEA> MEAs { get; set; }

            public List<PIDGroup> PIDGroups { get; set; }

            public List<PWK> PWKs { get; set; }

            public PO4 PO4 { get; set; }

            public REF REF { get; set; }

            public List<PER> PERs { get; set; }

            public List<SACGroup> SACGroups { get; set; }

            public IT8 IT8 { get; set; }

            public CSH CSH { get; set; }

            public List<ITD> ITDs { get; set; }

            public List<DIS> DISes { get; set; }

            public INC INC { get; set; }

            public TAX TAX { get; set; }

            public FOB FOB { get; set; }

            public List<SDQ> SDQs { get; set; }

            public List<IT3> IT3s { get; set; }

            public List<DTM> DTMs { get; set; }

            public TC2 TC2 { get; set; }

            public TD1 TD1 { get; set; }

            public List<TD5> TD5s { get; set; }

            public List<TD3> TD3s { get; set; }

            public List<TD4> TD4s { get; set; }

            public PCT PCT { get; set; }

            public List<MAN> MANs { get; set; }

            public MSG MSG { get; set; }

            public SPI SPI { get; set; }

            public TXI TXI { get; set; }

            public CTB CTB { get; set; }

            public List<QTYGroup> QTYGroups { get; set; }

            public List<SCHGroup> SCHGroups { get; set; }

            public List<PKGGroup> PKGGroups { get; set; }

            public LS LS { get; set; }

            public List<LDTGroup> LDTGroups { get; set; }

            public LE LE { get; set; }

            public List<N9Group> N9Groups { get; set; }

            public List<N1GroupDetail> N1Groups { get; set; }

            public List<SLNGroup> SLNGroups { get; set; }

            public List<AMTGroupDetail> AMTGroups { get; set; }

            public List<LMGroup> LMGroups { get; set; }
        }

        [EdiSegment]
        [EdiSegmentGroup("SAC", "CUR")]
        public class SACGroupHeader : SAC
        {
            public CUR CUR { get; set; }
        }

        [EdiSegment]
        [EdiSegmentGroup("AMT", SequenceEnd = "N9")]
        public class AMTGroupHeader : AMT
        {
            public REF REF { get; set; }

            public DTM DTM { get; set; }

            public PCT PCT { get; set; }

            public List<FA1Group> FA1Groups { get; set; }
        }

        [EdiSegment]
        [EdiSegmentGroup("AMT", "REF", "PCT")]
        public class AMTGroupDetail : AMT
        {
            public REF REF { get; set; }

            public PCT PCT { get; set; }
        }

        [EdiSegment]
        [EdiSegmentGroup("N9", "DTM", "MSG")]
        public class N9GroupHeader : N9
        {
            public DTM DTM { get; set; }

            public List<MSG> MSGs { get; set; }
        }

        [EdiSegment]
        [EdiSegmentGroup("N1", "N2", "N3", "N4", "NX2", "REF", "PER", "SI", "FOB", "TD1", "TD5", "TD3", "TD4", "PKG")]
        public class N1GroupHeader : N1
        {
            public List<N2> N2s { get; set; }

            public List<N3> N3s { get; set; }

            public N4 N4 { get; set; }

            public NX2 NX2 { get; set; }

            public List<REF> REFs { get; set; }

            public PER PER { get; set; }

            public SI SI { get; set; }

            public FOB FOB { get; set; }

            public List<TD1> TD1s { get; set; }

            public List<TD5> TD5s { get; set; }

            public List<TD3> TD3s { get; set; }

            public List<TD4> TD4s { get; set; }

            public List<PKG> PKGs { get; set; }
        }

        [EdiSegment]
        [EdiSegmentGroup("SAC", "CUR", "CTP")]
        public class SACGroup : SAC
        {
            public CUR CUR { get; set; }

            public CTP CTP { get; set; }
        }

        [EdiSegment]
        [EdiSegmentGroup("N9", "DTM", "MEA", "MSG")]
        public class N9Group : N9
        {
            public DTM DTM { get; set; }

            public List<MEA> MEAs { get; set; }

            public List<MSG> MSGs { get; set; }
        }

        [EdiSegment]
        [EdiSegmentGroup("FA1", "FA2")]
        public class FA1Group : FA1
        {
            public FA2 FA2 { get; set; }
        }

        [EdiSegment]
        [EdiSegmentGroup("N1", SequenceEnd = "SLN")]
        public class N1GroupDetail : N1
        {
            public List<N2> N2s { get; set; }

            public List<N3> N3s { get; set; }

            public N4 N4 { get; set; }

            public QTY QTY { get; set; }

            public NX2 NX2 { get; set; }

            public List<REF> REFs { get; set; }

            public List<PER> PERs { get; set; }

            public SI SI { get; set; }

            public DTM DTM { get; set; }

            public FOB FOB { get; set; }

            public List<SCH> SCHes { get; set; }

            public List<TD1> TD1s { get; set; }

            public List<TD5> TD5s { get; set; }

            public List<TD3> TD3s { get; set; }

            public List<TD4> TD4s { get; set; }

            public List<PKG> PKGs { get; set; }

            public List<LDTGroupN1> LDTGroups { get; set; }
        }

        [EdiSegment]
        [EdiSegmentGroup("CTP", "CUR")]
        public class CTPGroup : CTP
        {
            public CUR CUR { get; set; }
        }

        [EdiSegment]
        [EdiSegmentGroup("PID", "MEA")]
        public class PIDGroup : PID
        {
            public List<MEA> MEAs { get; set; }
        }

        [EdiSegment]
        [EdiSegmentGroup("QTY", "SI")]
        public class QTYGroup : QTY
        {
            public SI SI { get; set; }
        }

        [EdiSegment]
        [EdiSegmentGroup("SCH", "TD1", "TD5", "TD3", "TD4", "REF")]
        public class SCHGroup : SCH
        {
            public List<TD1> TD1s { get; set; }

            public List<TD5> TD5s { get; set; }

            public List<TD3> TD3s { get; set; }

            public List<TD4> TD4s { get; set; }

            public REF REF { get; set; }
        }

        [EdiSegment]
        [EdiSegmentGroup("PKG", "MEA")]
        public class PKGGroup : PKG
        {
            public MEA MEA { get; set; }
        }

        [EdiSegment]
        [EdiSegmentGroup("LDT", SequenceEnd = "LE")]
        public class LDTGroup : LDT
        {
            public QTY QTY { get; set; }

            public MSG MSG { get; set; }

            public List<REF> REFs { get; set; }

            public List<LMGroup> LMGroups { get; set; }
        }

        [EdiSegment]
        [EdiSegmentGroup("LDT", "MAN", "QTY", "MSG", "REF")]
        public class LDTGroupN1 : LDT
        {
            public List<MAN> MANs { get; set; }

            public List<QTY> QTIes { get; set; }

            public MSG MSG { get; set; }

            public List<REF> REFs { get; set; }
        }

        [EdiSegment]
        [EdiSegmentGroup("SLN", SequenceEnd = "AMT")]
        public class SLNGroup : SLN
        {
            public MSG MSG { get; set; }

            public SI SI { get; set; }

            public List<PID> PIDs { get; set; }

            public List<PO3> PO3s { get; set; }

            public TC2 TC2 { get; set; }

            public ADV ADV { get; set; }

            public List<DTM> DTMs { get; set; }

            public List<CTP> CTPs { get; set; }

            public List<PAM> PAMs { get; set; }

            public PO4 PO4 { get; set; }

            public List<TAX> TAXes { get; set; }

            public List<N9GroupSLN> N9Groups { get; set; }

            public List<SACGroup> SACGroups { get; set; }

            public List<QTYGroup> QTYGroups { get; set; }

            public List<N1GroupSLN> N1GroupSLNs { get; set; }
        }

        [EdiSegment]
        [EdiSegmentGroup("N9", "DTM", "MSG")]
        public class N9GroupSLN : N9
        {
            public DTM DTM { get; set; }

            public MSG MSG { get; set; }
        }

        [EdiSegment]
        [EdiSegmentGroup("N1", "N2", "N3", "N4", "NX2", "REF", "PER", "SI")]
        public class N1GroupSLN : N1
        {
            public List<N2> N2s { get; set; }

            public List<N3> N3s { get; set; }

            public N4 N4 { get; set; }

            public NX2 NX2 { get; set; }

            public List<REF> REFs { get; set; }

            public List<PER> PERs { get; set; }

            public SI SI { get; set; }
        }

        [EdiSegment]
        [EdiSegmentGroup("LM", "LQ")]
        public class LMGroup : LM
        {
            public LQ LQ { get; set; }
        }

        [EdiSegment]
        [EdiSegmentGroup("SPI", SequenceEnd = "ADV")]
        public class SPIGroup : SPI
        {
            public List<REF> REFs { get; set; }

            public List<DTM> DTMs { get; set; }

            public List<MSG> MSGs { get; set; }

            public List<N1GroupSPI> N1GroupSPIs { get; set; }

            public List<CB1Group> CB1Groups { get; set; }
        }

        [EdiSegment]
        [EdiSegmentGroup("CB1", "REF", "DTM", "LDT", "MSG")]
        public class CB1Group : CB1
        {
            public List<REF> REFs { get; set; }

            public List<DTM> DTMs { get; set; }

            public LDT LDT { get; set; }

            public List<MSG> MSGs { get; set; }
        }

        [EdiSegment]
        [EdiSegmentGroup("N1", "N2", "N3", "N4", "REF", "G61", "MSG")]
        public class N1GroupSPI : N1
        {
            public List<N2> N2s { get; set; }

            public List<N3> N3s { get; set; }

            public N4 N4 { get; set; }

            public List<REF> REFs { get; set; }

            public G61 G61 { get; set; }

            public List<MSG> MSGs { get; set; }
        }

        [EdiSegment]
        [EdiSegmentGroup("ADV", "DTM", "MTX")]
        public class ADVGroup : ADV
        {
            public DTM DTM { get; set; }

            public MTX MTX { get; set; }
        }

        [EdiSegment]
        [EdiSegmentGroup("CTT", "AMT")]
        public class CTTGroup : CTT
        {
            public AMT AMT { get; set; }
        }

        public void UpdateSegmentsCount()
        {
            var count = CountSegmentUtility.CountSegments(GetType(), this) + 1;
            SE.SegmentsCount = count.ToString();
        }
        public string TransactionSegmentsCount { get; set; }
        public string TrailerTransactionSetControlNumber { get; set; }
    }
}
