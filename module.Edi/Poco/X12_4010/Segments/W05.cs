using Edi.Domain.Shared.Enums;
using indice.Edi.Serialization;
using Scm.Edi.Domain.Shared.Attributes;

namespace Edi.Application.Contracts.Poco.X12_4010.Segments
{
    /// <summary>
    /// Shipping Order Identification Segment
    /// </summary>
    [EdiSegment]
    [EdiPath("W05")]
    public class W05
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
        [EdiExtension(MinLength = 1, MaxLength = 30, Mandatory = true, EdiType = EdiType.Alphanumeric)]
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
    }
}
