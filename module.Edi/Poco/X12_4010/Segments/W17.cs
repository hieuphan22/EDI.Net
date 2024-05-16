using Edi.Domain.Shared.Enums;
using indice.Edi.Serialization;
using Scm.Edi.Domain.Shared.Attributes;

namespace Edi.Application.Contracts.Poco.X12_4010.Segments
{
    /// <summary>
    /// Contract Segment
    /// </summary>
    [EdiSegment]
    [EdiPath("W17")]
    public class W17
    {
        [EdiValue("X(1)", Path = "W17/0", Description = "W1701 - Reporting Code")]
        [EdiExtension(MinLength = 1, MaxLength = 1, Mandatory = true, EdiType = EdiType.Identifier)]
        public string ReportingCode { get; set; }

        [EdiValue("X(8)", Path = "W17/1", Description = "W1702 - Date")]
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

        [EdiValue("X(4)", Path = "W17/6", Description = "W1707 - Time")]
        [EdiExtension(MinLength = 8, MaxLength = 4, EdiType = EdiType.Time)]
        public string Time { get; set; }

        [EdiValue("X(22)", Path = "W17/7", Description = "W1708 - Master Reference (Link) Number")]
        [EdiExtension(MinLength = 1, MaxLength = 22, EdiType = EdiType.Alphanumeric)]
        public string MasterReferenceLinkNumber { get; set; }

        [EdiValue("X(6)", Path = "W17/8", Description = "W1709 - Link Sequence Number")]
        [EdiExtension(MinLength = 6, MaxLength = 6, EdiType = EdiType.Alphanumeric)]
        public string LinkSequenceNumber { get; set; }
    }
}
