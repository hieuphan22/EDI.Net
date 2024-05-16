using Edi.Domain.Shared.Attributes;
using Edi.Domain.Shared.Enums;
using indice.Edi.Serialization;
using Scm.Edi.Domain.Shared.Attributes;

namespace Edi.Domain.Shared.Poco.X12_4010.Segments
{
    [EdiSegment]
    [EdiPath("CMC")]
    public class CMC
    {
        [EdiValue("X(30)", Path = "CMC/0", Description = "CMC01 - Commodity Code")]
        [EdiExtension(MinLength = 1, MaxLength = 30, Mandatory = false, EdiType = EdiType.Alphanumeric)]
        public string CommodityCode { get; set; }

        [EdiValue("X(5)", Path = "CMC/1", Description = "CMC02 - Freight Class Code")]
        [EdiExtension(MinLength = 2, MaxLength = 5, Mandatory = false, EdiType = EdiType.Alphanumeric)]
        public string FreightClassCode { get; set; }
    }
}
