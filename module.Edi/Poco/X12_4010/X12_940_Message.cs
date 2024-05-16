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
    /// Warehouse Shipping Order 940: Message
    /// </summary>
    [EdiMessage]
    public class X12_940_Message : X12_Transaction
    {
        [EdiValue("X(1)", Path = "W05/0", Description = "W0501 - Order Status Code")]
        [EdiExtension(MinLength = 1, MaxLength = 1, Mandatory = true, EdiType = EdiType.Identifier)]
        public string OrderStatusCode { get; set; }

        [EdiValue("X(30)", Path = "W05/1", Description = "W0502 - Depositor Order Number")]
        [EdiExtension(MinLength = 1, MaxLength = 30, Mandatory = true, EdiType = EdiType.Alphanumeric)]
        public string DepositorOrderNumber { get; set; }

        [EdiValue("X(22)", Path = "W05/2", Description = "W0503 - Purchase Order Number")]
        [EdiExtension(MinLength = 1, MaxLength = 30, Mandatory = true, EdiType = EdiType.Alphanumeric)]
        public string PurchaseOrderNumber { get; set; }

        [EdiValue("X(6)", Path = "W05/3", Description = "W0504 - Link Sequence Number")]
        [EdiExtension(MinLength = 1, MaxLength = 6, Mandatory = true, EdiType = EdiType.Alphanumeric)]
        public string LinkSequenceNumber { get; set; }

        [EdiValue("X(22)", Path = "W05/4", Description = "W0505 - Master Reference (Link) Number")]
        [EdiExtension(MinLength = 1, MaxLength = 50, Mandatory = true, EdiType = EdiType.Alphanumeric)]
        public string MasterLinkNumber { get; set; }

        [EdiValue("X(2)", Path = "W05/5", Description = "W0506 - Transaction Type Code")]
        [EdiExtension(MinLength = 2, MaxLength = 2, Mandatory = true, EdiType = EdiType.Identifier)]
        public string TransactionTypeCode { get; set; }

        [EdiValue("X(2)", Path = "W05/6", Description = "W0507 - Action Code")]
        [EdiExtension(MinLength = 1, MaxLength = 2, Mandatory = true, EdiType = EdiType.Identifier)]
        public string ActionCode { get; set; }

        public List<N1Group> N1Groups { get; set; }

        public List<N9> N9Groups { get; set; }

        public List<G61> G61Groups { get; set; }

        public List<G62> G62Groups { get; set; }

        [EdiSegment]
        [EdiPath("NTE")]
        public List<NTE> NTEGroups { get; set; }

        [EdiSegment]
        [EdiPath("W09")]
        public W09 W09 { get; set; }

        [EdiSegment]
        [EdiPath("W66")]
        public W66 W66 { get; set; }

        [EdiSegment]
        [EdiPath("W6")]
        public W6 W6 { get; set; }

        [EdiSegment]
        [EdiPath("R2")]
        public List<R2> R2Groups { get; set; }

        [EdiSegment]
        [EdiPath("BNX")]
        public BNX BNX { get; set; }

        public List<LMGroup> LMGroups { get; set; }

        public List<OrderDetail> OrderDetails { get; set; }

        [EdiSegment]
        [EdiPath("W76")]
        public W76 W76 { get; set; }

        [EdiSegment]
        [EdiSegmentGroup("N1", "N2", "N3", "N4", "PER")]
        public class N1Group : N1
        {
            [EdiSegment]
            [EdiPath("N2")]
            public List<N2> N2Groups { get; set; }

            [EdiSegment]
            [EdiPath("N3")]
            public List<N3> N3Groups { get; set; }

            [EdiSegment]
            [EdiPath("N4")]
            public N4 N4 { get; set; }

            public List<PER> PERGroups { get; set; }
        }

        [EdiSegment]
        [EdiSegmentGroup("LM", "LQ")]
        public class LMGroup : LM
        {
            [EdiSegment]
            [EdiPath("LQ")]
            public List<LQ> LQs { get; set; }
        }

        [EdiSegment]
        [EdiSegmentGroup("LX", SequenceEnd = "W76")]
        public class OrderDetail : LX
        {
            [EdiSegment]
            [EdiPath("MAN")]
            public MAN MAN { get; set; }

            [EdiSegment]
            [EdiPath("SDQ")]
            public SDQ SDQ { get; set; }

            [EdiSegment]
            [EdiPath("N1")]
            public N1 N1 { get; set; }

            public List<G62> G62Groups { get; set; }

            public List<ItemDetail> ItemDetails { get; set; }
        }

        [EdiSegment]
        [EdiSegmentGroup("W01")]
        public class ItemDetail : W01
        {
            public List<G69> G69Groups { get; set; }

            public List<N9> N9Groups { get; set; }

            [EdiSegment]
            [EdiPath("NTE")]
            public NTE NTE { get; set; }

            public List<W20> W20Groups { get; set; }

            public List<QTY> QTYGroups { get; set; }

            [EdiSegment]
            [EdiPath("AMT")]
            public AMT AMT { get; set; }

            public List<G62> G62Groups { get; set; }

            [EdiSegment]
            [EdiPath("G66")]
            public G66 G66 { get; set; }

            public List<N1> N1s { get; set; }

            public List<PER> PERGroups { get; set; }

            public List<LH2> LH2Groups { get; set; }

            [EdiSegment]
            [EdiPath("LHR")]
            public LHR LHR { get; set; }

            public List<LH6> LH6Groups { get; set; }

            public List<LMGroup> LMGroups { get; set; }

            [EdiSegment]
            [EdiPath("LS")]
            public LS LS { get; set; }

            public List<LXGroup> LXGroups { get; set; }

            [EdiSegment]
            [EdiPath("LE")]
            public LE LE { get; set; }

            public List<FA1Group> FA1Groups { get; set; }
        }

        [EdiSegment]
        [EdiSegmentGroup("LX", SequenceEnd = "LE")]
        public class LXGroup : LX
        {
            [EdiSegment]
            [EdiPath("N9")]
            public N9 N9 { get; set; }

            public List<G62> G62Groups { get; set; }

            [EdiSegment]
            [EdiPath("N1")]
            public N1 N1 { get; set; }

            [EdiSegment]
            [EdiPath("SDQ")]
            public SDQ SDQ { get; set; }

            public List<LMGroup> LMGroups { get; set; }

            public List<LH1Group> LH1Groups { get; set; }
        }

        [EdiSegment]
        [EdiSegmentGroup("LH1", SequenceEnd = "LE")]
        public class LH1Group : LH1
        {
            public List<LH2> LH2Groups { get; set; }

            public List<LH3> LH3Groups { get; set; }

            public List<LFH> LFHGroups { get; set; }

            public List<LEP> LEPGroups { get; set; }

            [EdiSegment]
            [EdiPath("LH4")]
            public LH4 LH4 { get; set; }

            public List<LHT> LHTGroups { get; set; }

            public List<LHR> LHRGroups { get; set; }

            public List<PER> PERGroups { get; set; }
        }

        [EdiSegment]
        [EdiSegmentGroup("FA1", "FA2")]
        public class FA1Group : FA1
        {
            [EdiSegment]
            [EdiPath("FA2")]
            public FA2 FA2 { get; set; }
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