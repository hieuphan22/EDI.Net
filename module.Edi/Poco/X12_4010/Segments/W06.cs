using Edi.Domain.Shared.Enums;
using indice.Edi.Serialization;
using Scm.Edi.Domain.Shared.Attributes;

namespace Edi.Application.Contracts.Poco.X12_4010.Segments
{
    /// <summary>
    /// Shipping Order Identification Segment
    /// </summary>
    [EdiSegment]
    [EdiPath("W06")]
    public class W06
    {
        [EdiValue("X(1)", Path = "W06/0", Description = "W0601 - Reporting Code")]
        [EdiExtension(MinLength = 1, MaxLength = 1, Mandatory = true, EdiType = EdiType.Identifier)]
        public string ReportingCode { get; set; }

        [EdiValue("X(30)", Path = "W06/1", Description = "W0602 - Depositor Order Number")]
        [EdiExtension(MinLength = 1, MaxLength = 30, Mandatory = true, EdiType = EdiType.Alphanumeric)]
        public string DepositorOrderNumber { get; set; }

        [EdiValue("X(8)", Format = "CCYYMMDD", Path = "W06/2", Description = "W0603 - Date")]
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
    }
}
