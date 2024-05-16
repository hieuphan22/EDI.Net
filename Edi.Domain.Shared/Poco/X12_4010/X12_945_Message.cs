using System.Collections.Generic;
using Edi.Domain.Shared.Attributes;
using Edi.Domain.Shared.Enums;
using Edi.Domain.Shared.Poco.X12_4010.Common;
using Edi.Domain.Shared.Poco.X12_4010.Segments;
using Edi.Domain.Shared.Ultilities;
using indice.Edi.Serialization;
using Scm.Edi.Domain.Shared.Attributes;

namespace Edi.Domain.Shared.Poco.X12_4010
{
    /// <summary>
    /// Warehouse Shipping Advice 945
    /// </summary>
    [EdiMessage]
    public class X12_945_Message : X12_Transaction
    {
        [EdiValue("X(1)", Path = "W06/0", Description = "W0601 - Reporting Code")]
        [EdiExtension(MinLength = 1, MaxLength = 1, Mandatory = true, EdiType = EdiType.Identifier)]
        public string ReportingCode { get; set; }

        [EdiValue("X(30)", Path = "W06/1", Description = "W0602 - Depositor Order Number")]
        [EdiExtension(MinLength = 1, MaxLength = 30, Mandatory = true, EdiType = EdiType.Alphanumeric)]
        public string DepositorOrderNumber { get; set; }

        [EdiValue("X(8)", Format = "yyyyMMdd", Path = "W06/2", Description = "W0603 - Date")]
        [EdiExtension(MinLength = 8, MaxLength = 8, Mandatory = true, EdiType = EdiType.Date)]
        public string Date { get; set; }

        [EdiValue("X(30)", Path = "W06/3", Description = "W0604 - Shipment Identification Number")]
        [EdiExtension(MinLength = 1, MaxLength = 30, Mandatory = true, EdiType = EdiType.Alphanumeric)]
        public string ShipmentIdentificationNumber { get; set; }

        [EdiValue("X(12)", Path = "W06/4", Description = "W0605 - Agent Shipment ID Number")]
        [EdiExtension(MinLength = 1, MaxLength = 12, Mandatory = false, EdiType = EdiType.Alphanumeric)]
        public string AgentShipmentIdNumber { get; set; }

        [EdiValue("X(22)", Path = "W06/5", Description = "W0606 - Purchase Order Number")]
        [EdiExtension(MinLength = 1, MaxLength = 30, Mandatory = true, EdiType = EdiType.Alphanumeric)]
        public string PurchaseOrderNumber { get; set; }

        [EdiValue("X(50)", Path = "W06/6", Description = "W0607 - Master Reference (Link) Number")]
        [EdiExtension(MinLength = 1, MaxLength = 50, Mandatory = true, EdiType = EdiType.Alphanumeric)]
        public string MasterLinkNumber { get; set; }

        [EdiValue("X(6)", Path = "W06/7", Description = "W0608 - Link Sequence Number")]
        [EdiExtension(MinLength = 1, MaxLength = 30, Mandatory = false, EdiType = EdiType.Alphanumeric)]
        public string LinkSequenceNumber { get; set; }

        [EdiValue("X(3)", Path = "W06/8", Description = "W0609 - Special Handling Code")]
        [EdiExtension(MinLength = 2, MaxLength = 3, Mandatory = false, EdiType = EdiType.Identifier)]
        public string SpecialHandlingCode { get; set; }

        [EdiValue("X(2)", Path = "W06/9", Description = "W0610 - Shipping Date Change Reason Code")]
        [EdiExtension(MinLength = 2, MaxLength = 2, Mandatory = false, EdiType = EdiType.Identifier)]
        public string ShippingDateChangeReasonCode { get; set; }

        [EdiValue("X(2)", Path = "W06/10", Description = "W0611 - Transaction Type Code")]
        [EdiExtension(MinLength = 2, MaxLength = 2, Mandatory = false, EdiType = EdiType.Identifier)]
        public string TransactionTypeCode { get; set; }

        [EdiValue("X(2)", Path = "W06/11", Description = "W0612 - Action Code")]
        [EdiExtension(MinLength = 1, MaxLength = 2, Mandatory = false, EdiType = EdiType.Identifier)]
        public string ActionCode { get; set; }

        public List<N1Group> N1Groups { get; set; }

        public List<N9> N9s { get; set; }

        [EdiSegment]
        [EdiPath("G61")]
        public List<G61> G61s { get; set; }

        public List<G62> G62s { get; set; }

        [EdiSegment]
        [EdiPath("NTE")]
        public List<NTE> NTEs { get; set; }

        [EdiSegment]
        [EdiPath("W6")]
        public W6 W6 { get; set; }

        [EdiSegment]
        [EdiPath("W27")]
        public W27 W27 { get; set; }

        [EdiSegment]
        [EdiPath("W28")]
        public W28 W28 { get; set; }

        [EdiSegment]
        [EdiPath("W10")]
        public List<W10> W10s { get; set; }

        [EdiSegment]
        [EdiPath("G72")]
        public List<G72> G72s { get; set; }

        public List<LMGroup> LMGroups { get; set; }

        public List<OrderDetail> OrderDetails { get; set; }

        [EdiSegment]
        [EdiPath("W03")]
        public W03 W03 { get; set; }

        [EdiSegment]
        [EdiSegmentGroup("N1", "N2", "N3", "N4", "PER")]
        public class N1Group : N1
        {
            [EdiSegment]
            [EdiPath("N2")]
            public N2 N2 { get; set; }

            [EdiSegment]
            [EdiPath("N3")]
            public List<N3> N3s { get; set; }

            [EdiSegment]
            [EdiPath("N4")]
            public N4 N4 { get; set; }

            public List<PER> PERs { get; set; }
        }

        [EdiSegment]
        [EdiSegmentGroup("LX", SequenceEnd = "W03")]
        public class OrderDetail : LX
        {
            [EdiSegment]
            [EdiPath("MAN")]
            public List<MAN> MANs { get; set; }

            [EdiSegment]
            [EdiPath("PAL")]
            public PAL PAL { get; set; }

            public List<N9> N9s { get; set; }

            public List<ItemDetail> ItemDetails { get; set; }
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
        [EdiSegmentGroup("W12")]
        public class ItemDetail : W12
        {
            [EdiSegment]
            [EdiPath("G69")]
            public List<G69> G69s { get; set; }

            public List<N9> N9s { get; set; }
            public List<G62> G62s { get; set; }
            public List<QTY> QTYs { get; set; }
            public List<MEA> MEAs { get; set; }
            public AMT AMT { get; set; }
            public List<R4> R4s { get; set; }
            public W27 W27 { get; set; }
            public List<N1> N1s { get; set; }
            public List<G72> G72s { get; set; }

            public List<LMGroup> LMGroups { get; set; }

            public List<FA1Group> FA1Groups { get; set; }
        }

        [EdiSegment]
        [EdiSegmentGroup("FA1", "FA2")]
        public class FA1Group : FA1
        {
            [EdiSegment]
            [EdiPath("FA2")]
            public List<FA2> FA2s { get; set; }
        }

        public void UpdateSegmentsCount() {
            var count = CountSegmentUtility.CountSegments(GetType(), this) + 1;
            SE.SegmentsCount = count.ToString();
        }
        public string TransactionSegmentsCount { get; set; }
        public string TrailerTransactionSetControlNumber { get; set; }
    }
}
