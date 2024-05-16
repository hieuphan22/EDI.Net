using Edi.Domain.Shared.Enums;
using indice.Edi.Serialization;
using Scm.Edi.Domain.Shared.Attributes;

namespace Edi.Application.Contracts.Poco.X12_4010.Segments
{
    [EdiSegment]
    [EdiPath("MSI")]
    public class MSI
    {
        [EdiValue("X(1)", Path = "MSI/0", Description = "MSI01 - Yes/No Condition or Response Code")]
        [EdiExtension(MinLength = 1, MaxLength = 1, Mandatory = true, EdiType = EdiType.Identifier)]
        public string YesOrNoConditionOrResponseCode { get; set; }

        [EdiValue("X(3)", Path = "MSI/1", Format = "N0", Description = "MSI02 - Stop Sequence Number")]
        [EdiExtension(MinLength = 1, MaxLength = 3, Mandatory = false, EdiType = EdiType.Numeric)]
        public string StopSequenceNumber { get; set; }
    }
}
