using Edi.Domain.Shared.Enums;
using indice.Edi.Serialization;
using Scm.Edi.Domain.Shared.Attributes;

namespace Edi.Application.Contracts.Poco.X12_4010.Segments
{
    [EdiSegment]
    [EdiPath("AK1")]
    public class AK1
    {
        [EdiValue("X(2)", Path = "AK1/0", Description = "AK101 - Functional Identifier Code")]
        [EdiExtension(MinLength = 2, MaxLength = 2, Mandatory = true, EdiType = EdiType.Identifier)]
        public string FunctionalIdentifierCode { get; set; }

        [EdiValue("X(9)", Format = "N0", Path = "AK1/1", Description = "AK102 - Group Control Number")]
        [EdiExtension(MinLength = 1, MaxLength = 9, Mandatory = true, EdiType = EdiType.Numeric)]
        public string GroupControlNumber { get; set; }

        [EdiValue("X(12)", Path = "AK1/2", Description = "AK103 - Version / Release / Industry Identifier Code")]
        [EdiExtension(MinLength = 1, MaxLength = 12, Mandatory = false, EdiType = EdiType.Alphanumeric)]
        public string VersionOrReleaseOrIndustryIdentifierCode { get; set; }
    }
}
