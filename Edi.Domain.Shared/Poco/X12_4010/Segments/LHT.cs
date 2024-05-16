using Edi.Domain.Shared.Attributes;
using Edi.Domain.Shared.Enums;
using indice.Edi.Serialization;
using Scm.Edi.Domain.Shared.Attributes;

namespace Edi.Domain.Shared.Poco.X12_4010.Segments
{
    [EdiSegment]
    [EdiPath("LHT")]
    public class LHT
    {
        [EdiValue("X(30)", Path = "LHT/0", Description = "LHT01 - Hazardous Classification")]
        [EdiExtension(MinLength = 1, MaxLength = 30, Mandatory = false, EdiType = EdiType.Identifier)]
        public string HazardousClassification { get; set; }

        [EdiValue("X(40)", Path = "LHT/1", Description = "LHT02 - Hazardous Placard Notation")]
        [EdiExtension(MinLength = 14, MaxLength = 40, Mandatory = false, EdiType = EdiType.Identifier)]
        public string HazardousPlacardNotation { get; set; }

        [EdiValue("X(25)", Path = "LHT/2", Description = "LHT03 - Hazardous Endorsement")]
        [EdiExtension(MinLength = 4, MaxLength = 25, Mandatory = false, EdiType = EdiType.Identifier)]
        public string HazardousEndorsement { get; set; }
    }
}
