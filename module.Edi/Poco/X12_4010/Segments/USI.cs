using Edi.Domain.Shared.Enums;
using indice.Edi.Serialization;
using Scm.Edi.Domain.Shared.Attributes;

namespace Edi.Application.Contracts.Poco.X12_4010.Segments
{
    [EdiSegment]
    [EdiPath("USI")]
    public class USI
    {
        [EdiValue("X(15)", Format = "R", Path = "USI/0", Description = "USI01 - Quantity")]
        [EdiExtension(MinLength = 1, MaxLength = 15, Mandatory = true, EdiType = EdiType.Decimal)]
        public string Quantity { get; set; }

        [EdiValue("X(3)", Path = "USI/1", Description = "USI02 - Packaging Form Code")]
        [EdiExtension(MinLength = 3, MaxLength = 3, Mandatory = true, EdiType = EdiType.Identifier)]
        public string PackagingFormCode { get; set; }

        [EdiValue("X(1)", Path = "USI/2", Description = "USI03 - Yes/No Condition or Response Code")]
        [EdiExtension(MinLength = 1, MaxLength = 1, Mandatory = false, EdiType = EdiType.Identifier)]
        public string YesOrNoConditionOrResponseCode { get; set; }
    }
}
