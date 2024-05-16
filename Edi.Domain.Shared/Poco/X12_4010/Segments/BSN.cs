using Edi.Domain.Shared.Attributes;
using Edi.Domain.Shared.Enums;
using indice.Edi.Serialization;
using Scm.Edi.Domain.Shared.Attributes;

namespace Edi.Domain.Shared.Poco.X12_4010.Segments
{
    [EdiSegment]
    [EdiPath("BSN")]
    public class BSN
    {
        [EdiValue("X(2)", Path = "BSN/0", Description = "BSN01 - Transaction Set Purpose Code")]
        [EdiExtension(MinLength = 2, MaxLength = 2, Mandatory = true, EdiType = EdiType.Identifier)]
        public string TransactionSetPurposeCode { get; set; }

        [EdiValue("X(2)", Path = "BSN/1", Description = "BSN02 - Shipment Identification")]
        [EdiExtension(MinLength = 2, MaxLength = 30, Mandatory = true, EdiType = EdiType.Alphanumeric)]
        public string ShipmentIdentification { get; set; }

        [EdiValue("X(8)", Path = "BSN/2", Format = "yyyyMMdd", Description = "BSN03 - Date")]
        [EdiExtension(MinLength = 8, MaxLength = 8, Mandatory = true, EdiType = EdiType.Date)]
        public string Date { get; set; }

        [EdiValue("X(8)", Path = "BSN/3", Format = "HHmm", Description = "BSN04 - Time")]
        [EdiExtension(MinLength = 4, MaxLength = 8, Mandatory = true, EdiType = EdiType.Time)]
        public string Time { get; set; }

        [EdiValue("X(4)", Path = "BSN/4", Description = "BSN05 - Hierarchical Structure Code")]
        [EdiExtension(MinLength = 4, MaxLength = 4, Mandatory = false, EdiType = EdiType.Identifier)]
        public string HierarchicalStructureCode { get; set; }

        [EdiValue("X(2)", Path = "BSN/5", Description = "BSN06 - Transaction Type Code")]
        [EdiExtension(MinLength = 2, MaxLength = 2, Mandatory = false, EdiType = EdiType.Identifier)]
        public string TransactionTypeCode { get; set; }

        [EdiValue("X(3)", Path = "BSN/6", Description = "BSN07 - Status Reason Code")]
        [EdiExtension(MinLength = 3, MaxLength = 3, Mandatory = false, EdiType = EdiType.Identifier)]
        public string StatusReasonCode { get; set; }
    }
}
