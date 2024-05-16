using Edi.Domain.Shared.Attributes;
using Edi.Domain.Shared.Enums;
using indice.Edi.Serialization;
using Scm.Edi.Domain.Shared.Attributes;

namespace Edi.Domain.Shared.Poco.X12_4010.Segments
{
    [EdiSegment]
    [EdiPath("TSD")]
    public class TSD
    {
        [EdiValue("X(20)", Path = "TSD/0", Description = "TSD01	- Assigned Identification")]
        [EdiExtension(MinLength = 1, MaxLength = 20, Mandatory = false, EdiType = EdiType.Alphanumeric)]
        public string AssignedIdentification { get; set; }

        [EdiValue("X(3)", Path = "TSD/1", Description = "TSD02 - Position")]
        [EdiExtension(MinLength = 1, MaxLength = 3, Mandatory = false, EdiType = EdiType.Alphanumeric)]
        public string Position { get; set; }
    }
}
