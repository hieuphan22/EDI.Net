using Edi.Domain.Shared.Attributes;
using Edi.Domain.Shared.Enums;
using indice.Edi.Serialization;
using Scm.Edi.Domain.Shared.Attributes;

namespace Edi.Domain.Shared.Poco.X12_4010.Segments
{
    [EdiSegment]
    [EdiPath("LH6")]
    public class LH6
    {
        [EdiValue("X(60)", Path = "LH6/0", Description = "LH601 - Name")]
        [EdiExtension(MinLength = 1, MaxLength = 60, Mandatory = false, EdiType = EdiType.Alphanumeric)]
        public string Name { get; set; }

        [EdiValue("X(25)", Path = "LH6/1", Description = "LH602 - Hazardous Certification Code")]
        [EdiExtension(MinLength = 1, MaxLength = 25, Mandatory = false, EdiType = EdiType.Alphanumeric)]
        public string HazardousCertificationCode { get; set; }

        [EdiValue("X(25)", Path = "LH6/2", Description = "LH603 - Hazardous Certification Declaration")]
        [EdiExtension(MinLength = 1, MaxLength = 25, EdiType = EdiType.Alphanumeric)]
        public string HazardousCertificationDeclaration { get; set; }

        [EdiValue("X(25)", Path = "LH6/3", Description = "LH604 - Hazardous Certification Declaration")]
        [EdiExtension(MinLength = 1, MaxLength = 25, Mandatory = false, EdiType = EdiType.Alphanumeric)]
        public string HazardousCertificationDeclaration02 { get; set; }
    }
}
