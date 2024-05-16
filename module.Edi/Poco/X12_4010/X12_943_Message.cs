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
    /// 943 Warehouse Stock Transfer Shipment Advice
    /// </summary>
    [EdiMessage]
    public class X12_943_Message : X12_Transaction
    {
        [EdiValue("X(1)", Path = "W06/0", Description = "W0601 - Reporting Code")]
        [EdiExtension(MinLength = 1, MaxLength = 1, Mandatory = true, EdiType = EdiType.Identifier)]
        public string ReportingCode { get; set; }

        [EdiValue("X(30)", Path = "W06/1", Description = "W0602 - Depositor Order Number")]
        [EdiExtension(MinLength = 1, MaxLength = 30, Mandatory = true, EdiType = EdiType.Alphanumeric)]
        public string DepositorOrderNumber { get; set; }

        [EdiValue("X(8)", Format = "yyyyMMdd", Path = "W06/2", Description = "W0603 - Date (Format = CCYYMMDD)")]
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

        [EdiValue("X(6)", Format = "N0", Path = "W06/7", Description = "W0608 - Link Sequence Number")]
        [EdiExtension(MinLength = 1, MaxLength = 30, Mandatory = false, EdiType = EdiType.Numeric)]
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
        public List<G61> G61s { get; set; }
        public List<G62> G62s { get; set; }
        public List<NTE> NTEs { get; set; }
        public W27 W27 { get; set; }
        public W28 W28 { get; set; }
        public W10 W10 { get; set; }

        public List<WarehouseStockTransferShipmentDetail> WarehouseStockTransferShipmentDetails { get; set; }
        public W03 W03 { get; set; }

        [EdiSegment]
        [EdiSegmentGroup("W04", SequenceEnd = "W03")]
        public class WarehouseStockTransferShipmentDetail : W04
        {
            public List<G69> G69s { get; set; }
            public List<N9> N9s { get; set; }
            public List<W20> W20s { get; set; }
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

        public void UpdateSegmentsCount()
        {
            var count = CountSegmentUtility.CountSegments(GetType(), this) + 1;
            SE.SegmentsCount = count.ToString();
        }
        public string TransactionSegmentsCount { get; set; }
        public string TrailerTransactionSetControlNumber { get; set; }
    }
}