using indice.Edi.Serialization;

namespace Edi.Domain.Shared.Poco.X12_4010.Common
{
    [EdiSegment]
    [EdiPath("SE")]
    public class SE //: IEdiValidation<SE>
    {
        [EdiValue(Path = "SE/0", Description = "SE01 - Number of included segments")]
        [EdiCount(EdiCountScope.Segments)]
        public int SegmentsCounts { get; set; }

        [EdiValue("X(9)", Path = "SE/1", Description = "SE02 - Transaction set control number (same as ST02)")]
        public string TrailerTransactionSetControlNumber { get; set; }
    }
}
