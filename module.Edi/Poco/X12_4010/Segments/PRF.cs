using Edi.Domain.Shared.Enums;
using indice.Edi.Serialization;
using Scm.Edi.Domain.Shared.Attributes;

namespace Edi.Application.Contracts.Poco.X12_4010.Segments
{
    [EdiSegment]
    [EdiPath("PRF")]
    public class PRF
    {
        [EdiValue("X(8)", Path = "PRF/0", Description = "PRF01 - Purchase Order Number")]
        [EdiExtension(MinLength = 1, MaxLength = 22, Mandatory = true, EdiType = EdiType.Alphanumeric)]
        public string PurchaseOrderNumber { get; set; }

        [EdiValue("X(30)", Path = "PRF/1", Description = "PRF02 - Release Number")]
        [EdiExtension(MinLength = 1, MaxLength = 30, Mandatory = false, EdiType = EdiType.Alphanumeric)]
        public string ReleaseNumber { get; set; }

        [EdiValue("X(8)", Path = "PRF/2", Description = "PRF03 - Change Order Sequence Number")]
        [EdiExtension(MinLength = 1, MaxLength = 8, Mandatory = false, EdiType = EdiType.Alphanumeric)]
        public string ChangeOrderSequenceNumber { get; set; }

        [EdiValue("X(8)", Format = "yyyyMMdd", Path = "PRF/3", Description = "PRF04 - Date")]
        [EdiExtension(MinLength = 6, MaxLength = 8, Mandatory = false, EdiType = EdiType.Date)]
        public string Date { get; set; }

        [EdiValue("X(20)", Path = "PRF/4", Description = "PRF05 - Assigned Identification")]
        [EdiExtension(MinLength = 1, MaxLength = 20, Mandatory = false, EdiType = EdiType.Alphanumeric)]
        public string AssignedIdentification { get; set; }

        [EdiValue("X(30)", Path = "PRF/5", Description = "PRF06 - Contract Number")]
        [EdiExtension(MinLength = 1, MaxLength = 30, Mandatory = false, EdiType = EdiType.Alphanumeric)]
        public string ContractNumber { get; set; }

        [EdiValue("X(2)", Path = "PRF/6", Description = "PRF07 - Purchase Order Type Code")]
        [EdiExtension(MinLength = 2, MaxLength = 2, Mandatory = false, EdiType = EdiType.Identifier)]
        public string PurchaseOrderTypeCode { get; set; }
    }
}
