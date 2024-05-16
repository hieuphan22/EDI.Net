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
    /// Invoice 810
    /// </summary>
    [EdiMessage]
    public class X12_810_Message : X12_Transaction
    {
        [EdiValue("X(8)", Path = "BIG/0", Format = "yyyyMMdd", Description = "BIG01 - Date")]
        [EdiExtension(MinLength = 8, MaxLength = 8, Mandatory = true, EdiType = EdiType.Date)]
        public string Date { get; set; }

        [EdiValue("X(22)", Path = "BIG/1", Description = "BIG02 - Invoice Number")]
        [EdiExtension(MinLength = 1, MaxLength = 22, Mandatory = true, EdiType = EdiType.Alphanumeric)]
        public string InvoiceNumber { get; set; }

        [EdiValue("X(8)", Path = "BIG/2", Format = "yyyyMMdd", Description = "BIG03 - Purchase Order Date")]
        [EdiExtension(MinLength = 8, MaxLength = 8, Mandatory = false, EdiType = EdiType.Date)]
        public string PurchaseOrderDate { get; set; }

        [EdiValue("X(22)", Path = "BIG/3", Description = "BIG04 - Purchase Order Number")]
        [EdiExtension(MinLength = 1, MaxLength = 22, Mandatory = true, EdiType = EdiType.Alphanumeric)]
        public string PurchaseOrderNumber { get; set; }

        [EdiValue("X(30)", Path = "BIG/4", Description = "BIG05 - Release Number")]
        [EdiExtension(MinLength = 1, MaxLength = 30, Mandatory = false, EdiType = EdiType.Alphanumeric)]
        public string ReleaseNumber { get; set; }

        [EdiValue("X(8)", Path = "BIG/5", Description = "BIG06 - Change Order Sequence Number")]
        [EdiExtension(MinLength = 1, MaxLength = 8, Mandatory = false, EdiType = EdiType.Alphanumeric)]
        public string ChangeOrderSequenceNumber { get; set; }

        [EdiValue("X(2)", Path = "BIG/6", Description = "BIG07 - Transaction Type Code")]
        [EdiExtension(MinLength = 1, MaxLength = 2, Mandatory = false, EdiType = EdiType.Identifier)]
        public string TransactionTypeCode { get; set; }

        [EdiValue("X(2)", Path = "BIG/7", Description = "BIG08 - Transaction Set Purpose Code")]
        [EdiExtension(MinLength = 1, MaxLength = 2, Mandatory = false, EdiType = EdiType.Identifier)]
        public string TransactionSetPurposeCode { get; set; }

        [EdiValue("X(2)", Path = "BIG/8", Description = "BIG09 - Action Code")]
        [EdiExtension(MinLength = 1, MaxLength = 2, Mandatory = false, EdiType = EdiType.Identifier)]
        public string ActionCode { get; set; }

        [EdiValue("X(22)", Path = "BIG/9", Description = "BIG10 - Invoice Number 02")]
        [EdiExtension(MinLength = 1, MaxLength = 22, Mandatory = false, EdiType = EdiType.Alphanumeric)]
        public string InvoiceNumber02 { get; set; }

        public List<NTE> NTEs { get; set; }

        public CUR CUR { get; set; }

        public List<YNQ> YNQs { get; set; }

        public List<REF> REFs { get; set; }

        public List<PER> PERs { get; set; }

        public List<N1Group> N1Groups { get; set; }

        public ITD ITD { get; set; }

        public List<DTM> DTMs { get; set; }

        public FOB FOB { get; set; }

        public List<PID> PIDs { get; set; }

        public List<MEA> MEAs { get; set; }

        public List<PWK> PWKs { get; set; }

        public List<PKG> PKGs { get; set; }

        public L7 L7 { get; set; }
        public BAL BAL { get; set; }
        public INC INC { get; set; }
        public PAM PAM { get; set; }
        public CRC CRC { get; set; }

        public MTX MTX { get; set; }

        public List<LMGroup> LMGroups { get; set; }

        public List<N9Group> N9Groups { get; set; }

        public List<V1Group> V1Groups { get; set; }

        public List<FA1Group> FA1Groups { get; set; }

        public List<InvoiceDetail> Items { get; set; }

        public TDS TDS { get; set; }

        public List<TXI> TXIs { get; set; }

        public CAD CAD { get; set; }

        public AMT AMT { get; set; }

        public List<SACGroup> SACGroups { get; set; }

        public List<ISSGroup> ISSGroups { get; set; }

        public CTT CTT { get; set; }

        [EdiSegment]
        [EdiSegmentGroup("ISS", "DTM")]
        public class ISSGroup : ISS
        {
            public PID PID { get; set; }
        }

        [EdiSegment]
        [EdiSegmentGroup("SAC", "TXI")]
        public class SACGroup : SAC
        {
            public List<TXI> TXIs { get; set; }
        }

        [EdiSegment]
        [EdiSegmentGroup("N1", "N2", "N3", "N4", "REF", "PER", "DMG")]
        public class N1Group : N1
        {
            public List<N2> N2s { get; set; }

            public List<N3> N3s { get; set; }

            public N4 N4 { get; set; }

            public List<REF> REFs { get; set; }

            public List<PER> PERs { get; set; }

            public DMG DMG { get; set; }
        }

        [EdiSegment]
        [EdiSegmentGroup("LM", "LQ")]
        public class LMGroup : LM
        {
            public List<LQ> LQs { get; set; }
        }

        [EdiSegment]
        [EdiSegmentGroup("N9", "MSG")]
        public class N9Group : N9
        {
            public List<MSG> MSGs { get; set; }
        }

        [EdiSegment]
        [EdiSegmentGroup("V1", "R4", "DTM")]
        public class V1Group : V1
        {
            public R4 R4 { get; set; }
            public DTM DTM { get; set; }
        }

        [EdiSegment]
        [EdiSegmentGroup("FA1", "FA2")]
        public class FA1Group : FA1
        {
            public FA2 FA2 { get; set; }
        }

        [EdiSegment]
        [EdiSegmentGroup("PID", "MEA")]
        public class PIDGroup : PID
        {
            public List<MEA> MEAs { get; set; }
        }

        [EdiSegment]
        [EdiSegmentGroup("SLN", "DTM", "REF", "PID", "SAC", "TC2", "TXI")]
        public class SLNGroup : SLN
        {
            public DTM DTM { get; set; }

            public REF REF { get; set; }

            public List<PID> PIDs { get; set; }

            public List<SAC> SACs { get; set; }

            public List<TC2> TC2s { get; set; }

            public List<TXI> TXIs { get; set; }
        }

        [EdiSegment]
        [EdiSegmentGroup("IT1", SequenceEnd = "TDS")]
        public class InvoiceDetail : IT1
        {
            public CRC CRC { get; set; }

            public List<QTY> QTies { get; set; }

            public CUR CUR { get; set; }

            public List<IT3> IT3s { get; set; }

            public List<TXI> TXIs { get; set; }

            public List<CTP> CTPs { get; set; }

            public List<PAM> PAMs { get; set; }

            public List<MEA> MEAs { get; set; }

            public List<PIDGroup> PIDGroups { get; set; }

            public List<PWK> PWKs { get; set; }
            public List<PKG> PKGs { get; set; }

            public PO4 PO4 { get; set; }

            public List<ITD> ITDs { get; set; }

            public REF REF { get; set; }

            public List<YNQ> YNQs { get; set; }

            public List<PER> PERs { get; set; }

            public List<SDQ> SDQs { get; set; }

            public List<DTM> DTMs { get; set; }

            public CAD CAD { get; set; }

            public L7 L7 { get; set; }

            public SR SR { get; set; }

            public List<SACGroup> SACGroups { get; set; }

            public List<SLNGroup> SLNGroups { get; set; }

            public List<N1Group> N1Groups { get; set; }

            public List<LMGroup> LMGroups { get; set; }

            public List<V1Group> V1Groups { get; set; }

            public List<FA1Group> FA1Groups { get; set; }
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
