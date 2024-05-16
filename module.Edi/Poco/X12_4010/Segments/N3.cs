using Edi.Domain.Shared.Enums;
using indice.Edi.Serialization;
using Scm.Edi.Domain.Shared.Attributes;

namespace Edi.Application.Contracts.Poco.X12_4010.Segments
{
    [EdiSegment]
    [EdiPath("N3")]
    public class N3
    {
        [EdiValue("X(55)", Path = "N3/0", Description = "N301 - Address Information")]
        [EdiExtension(MinLength = 1, MaxLength = 55, Mandatory = true, EdiType = EdiType.Alphanumeric)]
        public string AddressInformation { get; set; }

        [EdiValue("X(55)", Path = "N3/1", Description = "N302 - Address Information")]
        [EdiExtension(MinLength = 1, MaxLength = 55, Mandatory = false, EdiType = EdiType.Alphanumeric)]
        public string AddressInformation2 { get; set; }
    }
}
