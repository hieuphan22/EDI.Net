using Edi.Domain.Shared.Attributes;
using Edi.Domain.Shared.Enums;
using indice.Edi.Serialization;

namespace Edi.Domain.Shared.Poco.X12_4010.Common
{
    [EdiSegment]
    [EdiPath("IEA")]
    public class IEA
    {
        [EdiValue("X(5)", Format = "N0", Path = "IEA/0", Description = "IEA01 - Number of Included Functional Groups")]
        [EdiExtension(MinLength = 1, MaxLength = 5, Mandatory = true, EdiType = EdiType.Numeric)]
        //[EdiCount(EdiCountScope.Groups)]
        public string GroupsCount { get; set; }

        [EdiValue("X(9)", Format = "N0", Path = "IEA/1", Description = "IEA02 - Interchange Control Number")]
        [EdiExtension(MinLength = 5, MaxLength = 9, Mandatory = true, EdiType = EdiType.Numeric)]
        public string TrailerControlNumber { get; set; }
    }
}
