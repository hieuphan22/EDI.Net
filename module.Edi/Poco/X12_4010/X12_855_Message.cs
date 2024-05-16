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
    /// Purchase Order Acknowledgment 855: Message
    /// </summary>
    [EdiMessage]
    public class X12_855_Message : X12_Transaction
    {
        #region BAK
        [EdiValue("X(2)", Path = "BAK/0", Description = "BAK01 - Transaction Set Purpose Code")]
        [EdiExtension(MinLength = 2, MaxLength = 2, Mandatory = true, EdiType = EdiType.Identifier)]
        public string TransactionSetPurposeCode { get; set; }

        [EdiValue("X(2)", Path = "BAK/1", Description = "BAK02 - Acknowledgment Type")]
        [EdiExtension(MinLength = 2, MaxLength = 2, Mandatory = true, EdiType = EdiType.Identifier)]
        public string AcknowledgmentType { get; set; }

        [EdiValue("X(22)", Path = "BAK/2", Description = "BAK03 - Purchase Order Number")]
        [EdiExtension(MinLength = 1, MaxLength = 22, Mandatory = true, EdiType = EdiType.Alphanumeric)]
        public string PurchaseOrderNumber { get; set; }

        [EdiValue("X(8)", Path = "BAK/3", Format = "yyyyMMdd", Description = "BAK04 - Date")]
        [EdiExtension(MinLength = 8, MaxLength = 8, Mandatory = true, EdiType = EdiType.Date)]
        public string Date { get; set; }

        [EdiValue("X(30)", Path = "BAK/4", Description = "BAK05 - Release Number")]
        [EdiExtension(MinLength = 1, MaxLength = 30, Mandatory = false, EdiType = EdiType.Alphanumeric)]
        public string ReleaseNumber { get; set; }

        [EdiValue("X(45)", Path = "BAK/5", Description = "BAK06 - Request Reference Number")]
        [EdiExtension(MinLength = 1, MaxLength = 45, Mandatory = false, EdiType = EdiType.Alphanumeric)]
        public string RequestReferenceNumber { get; set; }

        [EdiValue("X(30)", Path = "BAK/6", Description = "BAK07 - Contract Number")]
        [EdiExtension(MinLength = 1, MaxLength = 30, Mandatory = false, EdiType = EdiType.Alphanumeric)]
        public string ContractNumber { get; set; }

        [EdiValue("X(30)", Path = "BAK/7", Description = "BAK08 - Reference Identification")]
        [EdiExtension(MinLength = 1, MaxLength = 30, Mandatory = false, EdiType = EdiType.Alphanumeric)]
        public string ReferenceIdentification { get; set; }

        [EdiValue("X(8)", Path = "BAK/8", Format = "yyyyMMdd", Description = "BAK09 - Date 02")]
        [EdiExtension(MinLength = 8, MaxLength = 8, Mandatory = false, EdiType = EdiType.Date)]
        public string Date02 { get; set; }

        [EdiValue("X(2)", Path = "BAK/9", Description = "BAK10 - Transaction Type Code")]
        [EdiExtension(MinLength = 2, MaxLength = 2, Mandatory = false, EdiType = EdiType.Alphanumeric)]
        public string TransactionTypeCode { get; set; }
        #endregion

        public CUR CUR { get; set; }

        public List<REF> REFs { get; set; }

        public List<PER> PERs { get; set; }

        public List<TAX> TAX { get; set; }

        public List<FOB> FOB { get; set; }

        public List<CTP> CTPs { get; set; }

        public List<PAM> PAMs { get; set; }

        public CSH CSH { get; set; }

        public List<SACGroup> SACGroups { get; set; }

        public List<ITD> ITDs { get; set; }

        public List<DIS> DISes { get; set; }

        public INC INC { get; set; }

        public List<DTM> DTMs { get; set; }

        public List<LDT> LDTs { get; set; }

        public List<LIN> LINs { get; set; }

        public List<SI> SIs { get; set; }

        public List<PID> PIDs { get; set; }

        public List<MEA> MEAs { get; set; }

        public List<PWK> PWKs { get; set; }

        public List<PKG> PKGs { get; set; }

        public List<TD1> TD1s { get; set; }

        public List<TD5> TD5s { get; set; }

        public List<TD3> TD3s { get; set; }

        public List<TD4> TD4s { get; set; }

        public List<MAN> MANs { get; set; }

        public List<TXI> TXIs { get; set; }

        public List<CTB> CTBs { get; set; }

        public List<N9Group> N9Groups { get; set; }

        public List<N1Group> N1Groups { get; set; }

        public List<ADVGroup> ADVGroups { get; set; }

        public List<PurchaseOrderAcknowledgmentDetail> Items { get; set; }

        public List<CTTGroup> CTTGroups { get; set; }

        [EdiSegment]
        [EdiSegmentGroup("PO1", SequenceEnd = "CTT")]
        public class PurchaseOrderAcknowledgmentDetail : PO1
        {
            public List<LIN> LINs { get; set; }

            public List<SI> SIs { get; set; }

            public CUR CUR { get; set; }

            public List<PO3> PO3s { get; set; }

            public List<CTP> CTPs { get; set; }

            public List<PAM> PAMs { get; set; }

            public List<MEA> MEAs { get; set; }

            public List<PIDGroup> PIDGroups { get; set; }

            public List<PWK> PWKs { get; set; }

            public List<PO4> PO4s { get; set; }

            public List<REF> REFs { get; set; }

            public List<PER> PERs { get; set; }

            public List<SACGroup> SACGroups { get; set; }

            public IT8 IT8 { get; set; }

            public List<CSH> CSHes { get; set; }

            public List<ITD> ITDs { get; set; }

            public List<DIS> DISes { get; set; }

            public INC INC { get; set; }

            public List<TAX> TAXs { get; set; }

            public List<FOB> FOBs { get; set; }

            public List<SDQ> SDQs { get; set; }

            public List<DTM> DTMs { get; set; }

            public List<LDT> LDTs { get; set; }

            public TD1 TD1 { get; set; }

            public List<TD5> TD5s { get; set; }

            public List<TD3> TD3s { get; set; }

            public List<TD4> TD4s { get; set; }

            public List<ACKGroup> ACKGroups { get; set; }

            public List<MAN> MANs { get; set; }

            public AMT AMT { get; set; }

            public List<CTB> CTBs { get; set; }

            public List<TXI> TXIs { get; set; }

            public List<QTYGroup> QTYGroups { get; set; }

            public List<PKGGroup> PKGGroups { get; set; }

            public List<SCHGroup> SCHGroups { get; set; }

            public List<N9Group> N9Groups { get; set; }

            public List<N1GroupDetail> N1Groups { get; set; }

            public List<SLNGroup> SLNGroups { get; set; }
        }

        [EdiSegment]
        [EdiSegmentGroup("SLN", SequenceEnd = "AMT")]
        public class SLNGroup : SLN
        {
            public MSG MSG { get; set; }

            public List<SI> SIs { get; set; }

            public List<PID> PIDs { get; set; }

            public List<PO3> PO3s { get; set; }

            public List<CTP> CTPs { get; set; }

            public List<PAM> PAMs { get; set; }

            public ACK ACK { get; set; }

            public List<SACGroup> SACGroups { get; set; }

            public List<DTM> DTMs { get; set; }

            public PO4 PO4 { get; set; }

            public List<TAX> TAXes { get; set; }

            public ADV ADV { get; set; }
            public List<QTYGroup> QTYGroups { get; set; }

            public List<N9GroupSLN> N9Groups { get; set; }

            public List<N1GroupSLN> N1GroupSLNs { get; set; }
        }

        [EdiSegment]
        [EdiSegmentGroup("N1", "N2", "N3", "N4", "NX2", "REF", "PER", "SI")]
        public class N1GroupSLN : N1
        {
            public List<N2> N2s { get; set; }

            public List<N3> N3s { get; set; }

            public N4 N4 { get; set; }

            public List<NX2> NX2s { get; set; }

            public List<REF> REFs { get; set; }

            public List<PER> PERs { get; set; }

            public List<SI> SIs { get; set; }
        }

        [EdiSegment]
        [EdiSegmentGroup("N9", "DTM", "MSG")]
        public class N9GroupSLN : N9
        {
            public DTM DTM { get; set; }

            public MSG MSG { get; set; }
        }

        [EdiSegment]
        [EdiSegmentGroup("SAC", "CUR")]
        public class SACGroup : SAC
        {
            public CUR CUR { get; set; }
        }

        [EdiSegment]
        [EdiSegmentGroup("N9", "DTM", "MSG")]
        public class N9Group : N9
        {
            public List<DTM> DTMs { get; set; }

            public List<MSG> MSGs { get; set; }
        }

        [EdiSegment]
        [EdiSegmentGroup("N1", "N2", "N3", "N4", "NX2", "REF", "PER", "SI", "FOB", "TD1", "TD5", "TD3", "TD4", "PKG", "MSG")]
        public class N1Group : N1
        {
            public List<N2> N2s { get; set; }

            public List<N3> N3s { get; set; }

            public N4 N4 { get; set; }

            public List<NX2> NX2s { get; set; }

            public List<REF> REFs { get; set; }

            public PER PER { get; set; }

            public List<SI> SIs { get; set; }

            public List<FOB> FOBs { get; set; }

            public List<TD1> TD1s { get; set; }

            public List<TD5> TD5s { get; set; }

            public List<TD3> TD3s { get; set; }

            public List<TD4> TD4s { get; set; }

            public List<PKG> PKGs { get; set; }

            public List<MSG> MSGs { get; set; }
        }
        [EdiSegment]
        [EdiSegmentGroup("N1", "N2", "N3", "N4", "NX2", "REF", "PER", "SI", "FOB", "TD1", "TD5", "TD3", "TD4", "PKG", "MSG")]
        public class N1GroupDetail : N1
        {
            public List<N2> N2s { get; set; }

            public List<N3> N3s { get; set; }

            public N4 N4 { get; set; }

            public List<NX2> NX2s { get; set; }

            public List<REF> REFs { get; set; }

            public List<PER> PERs { get; set; }

            public List<SI> SIs { get; set; }

            public DTM DTM { get; set; }

            public FOB FOB { get; set; }

            public List<TD1> TD1s { get; set; }

            public List<TD5> TD5s { get; set; }

            public List<TD3> TD3s { get; set; }

            public List<TD4> TD4s { get; set; }

            public List<QTY> QTYs { get; set; }

            public List<PKG> PKGs { get; set; }
        }

        [EdiSegment]
        [EdiSegmentGroup("CTT", "AMT")]
        public class CTTGroup : CTT
        {
            public AMT AMT { get; set; }
        }

        [EdiSegment]
        [EdiSegmentGroup("ACK", "DTM")]
        public class ACKGroup : ACK
        {
            public DTM DTM { get; set; }
        }

        [EdiSegment]
        [EdiSegmentGroup("ADV", "DTM", "MTX")]
        public class ADVGroup : ADV
        {
            public List<DTM> DTMs { get; set; }

            public List<MTX> MTXs { get; set; }
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
            public List<SI> SIs { get; set; }
        }

        [EdiSegment]
        [EdiSegmentGroup("PKG", "MEA")]
        public class PKGGroup : PKG
        {
            public List<MEA> MEAs { get; set; }
        }

        [EdiSegmentGroup("SCH", "TD1", "TD5", "TD3", "TD4", "REF")]
        public class SCHGroup : SCH
        {
            public List<TD1> TD1s { get; set; }

            public List<TD5> TD5s { get; set; }

            public List<TD3> TD3s { get; set; }

            public List<TD4> TD4s { get; set; }

            public List<REF> REFs { get; set; }
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