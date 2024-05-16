using Edi.Domain.Shared.Attributes;
using Edi.Domain.Shared.Enums;
using indice.Edi.Serialization;
using Scm.Edi.Domain.Shared.Attributes;

namespace Edi.Domain.Shared.Poco.X12_4010.Segments
{
    [EdiSegment]
    [EdiPath("BLR")]
    public class BLR
    {
        [EdiValue("X(4)", Path = "BLR/0", Description = "BLR01 - Standard Carrier Alpha Code")]
        [EdiExtension(MinLength = 2, MaxLength = 4, Mandatory = false, EdiType = EdiType.Identifier)]
        public string StandardCarrierAlphaCode { get; set; }

        [EdiValue("9(8)", Path = "BLR/1", Format = "yyyyMMdd", Description = "BLR02 - Date")]
        [EdiExtension(MinLength = 8, MaxLength = 8, EdiType = EdiType.Date)]
        public string Date { get; set; }

        [EdiValue("9(4)", Path = "BLR/2", Format = "HHmm", Description = "BLR03 - Time")]
        [EdiExtension(MinLength = 8, MaxLength = 4, Mandatory = false, EdiType = EdiType.Time)]
        public string Time { get; set; }
    }
}
