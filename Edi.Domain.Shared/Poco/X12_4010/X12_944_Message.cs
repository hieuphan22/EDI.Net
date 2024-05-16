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
    /// 944 Warehouse Stock Transfer Receipt Advice
    /// </summary>
    [EdiMessage]
    public class X12_944_Message : X12_Transaction
    {
        [EdiValue("X(1)", Path = "W17/0", Description = "W1701 - Reporting Code")]
        [EdiExtension(MinLength = 1, MaxLength = 1, Mandatory = true, EdiType = EdiType.Identifier)]
        public string ReportingCode { get; set; }

        [EdiValue("X(8)", Path = "W17/1", Format = "yyyyMMdd", Description = "W1702 - Date")]
        [EdiExtension(MinLength = 8, MaxLength = 8, Mandatory = true, EdiType = EdiType.Date)]
        public string Date { get; set; }

        [EdiValue("X(12)", Path = "W17/2", Description = "W1703 - Warehouse Receipt Number")]
        [EdiExtension(MinLength = 1, MaxLength = 12, Mandatory = true, EdiType = EdiType.Alphanumeric)]
        public string WarehouseReceiptNumber { get; set; }

        [EdiValue("X(22)", Path = "W17/3", Description = "W1704 - Depositor Order Number")]
        [EdiExtension(MinLength = 1, MaxLength = 22, Mandatory = false, EdiType = EdiType.Alphanumeric)]
        public string DepositorOrderNumber { get; set; }

        [EdiValue("X(30)", Path = "W17/4", Description = "W1705 - Shipment Identification Number")]
        [EdiExtension(MinLength = 1, MaxLength = 30, Mandatory = false, EdiType = EdiType.Alphanumeric)]
        public string ShipmentIdentificationNumber { get; set; }

        [EdiValue("X(2)", Path = "W17/5", Description = "W1706 - Time Qualifier")]
        [EdiExtension(MinLength = 1, MaxLength = 2, EdiType = EdiType.Identifier)]
        public string TimeQualifier { get; set; }

        [EdiValue("X(4)", Path = "W17/6", Format = "HHmm", Description = "W1707 - Time")]
        [EdiExtension(MinLength = 8, MaxLength = 4, EdiType = EdiType.Time)]
        public string Time { get; set; }

        [EdiValue("X(22)", Path = "W17/7", Description = "W1708 - Master Reference (Link) Number")]
        [EdiExtension(MinLength = 1, MaxLength = 22, EdiType = EdiType.Alphanumeric)]
        public string MasterReferenceLinkNumber { get; set; }

        [EdiValue("X(6)", Path = "W17/8", Description = "W1709 - Link Sequence Number")]
        [EdiExtension(MinLength = 6, MaxLength = 6, EdiType = EdiType.Alphanumeric)]
        public string LinkSequenceNumber { get; set; }
        public List<N1Group> N1Groups { get; set; }
        public List<N9> N9s { get; set; }
        public List<G61> G61s { get; set; }
        public List<G62> G62s { get; set; }
        public List<NTE> NTEs { get; set; }
        public W08 W08 { get; set; }
        public List<W18> W18s { get; set; }
        public List<G08> G08s { get; set; }
        public List<WarehouseStockTransferReceiptAdviceDetail> WarehouseStockTransferReceiptAdviceDetails { get; set; }
        public W14 W14 { get; set; }

        [EdiSegment]
        [EdiSegmentGroup("W07", SequenceEnd = "W14")]
        public class WarehouseStockTransferReceiptAdviceDetail : W07
        {
            public List<G69> G69s { get; set; }
            public List<N9> N9s { get; set; }
            public List<W20> W20s { get; set; }
            public List<W13Group> W13Groups { get; set; }
        }
        [EdiSegment]
        [EdiSegmentGroup("N1", "N2", "N3", "N4", "PER")]
        public class N1Group : N1
        {
            public N2 N2 { get; set; }
            public List<N3> N3s { get; set; }
            public N4 N4 { get; set; }
            public List<PER> PERs { get; set; }
        }
        [EdiSegment]
        [EdiSegmentGroup("W13", "N9")]
        public class W13Group : W13
        {
            public List<N9> N9s { get; set; }
        }

        public void UpdateSegmentsCount() {
            var count = CountSegmentUtility.CountSegments(GetType(), this) + 1;
            SE.SegmentsCount = count.ToString();
        }
        public string TransactionSegmentsCount { get; set; }
        public string TrailerTransactionSetControlNumber { get; set; }
    }
}