using Edi.Domain.Shared.Enums;
using indice.Edi.Serialization;
using Scm.Edi.Domain.Shared.Attributes;

namespace Edi.Application.Contracts.Poco.X12_4010.Segments
{
    [EdiSegment]
    [EdiPath("LX")]
    public class LX
    {
        [EdiValue("X(9)", Format = "N0", Path = "LX/0", Description = "LX01 - Assigned Number")]
        [EdiExtension(MinLength = 1, MaxLength = 6, Mandatory = true, EdiType = EdiType.Numeric)]
        public string AssignedNumber { get; set; }
    }
}
