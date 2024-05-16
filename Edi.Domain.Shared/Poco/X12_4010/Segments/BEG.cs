using indice.Edi.Serialization;

namespace Edi.Domain.Shared.Poco.X12_4010.Segments
{
    [EdiSegment]
    [EdiPath("BEG")]
    public class BEG //: IEdiValidation<BEG>
    {
        [EdiValue("X(2)", Path = "BEG/0", Description = "BEG01 - Trans. Set Purpose Code")]
        public string TransSetPurposeCode { get; set; }

        [EdiValue("X(2)", Path = "BEG/1", Description = "BEG02 - Purchase Order Type Code")]
        public string PurchaseOrderTypeCode { get; set; }

        [EdiValue(Path = "BEG/2", Description = "BEG03 - Purchase Order Number")]
        public string PurchaseOrderNumber { get; set; }

        [EdiValue("9(8)", Path = "BEG/4", Format = "yyyyMMdd", Description = "BEG05 - Purchase Order Date")]
        public string PurchaseOrderDate { get; set; }
    }
}
