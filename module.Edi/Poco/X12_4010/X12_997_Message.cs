using System.Collections.Generic;
using Edi.Application.Contracts.Poco.X12_4010.Segments;
using Edi.Domain.Shared.Enums;
using Edi.Domain.Shared.Ultilities;
using indice.Edi.Serialization;
using Scm.Edi.Domain.Shared.Attributes;
using Scm.Edi.Dtos.X12_4010.Common;

namespace Edi.Application.Contracts.Poco.X12_4010
{
    /// <summary>
    /// Purchase Order Change Request 860: Message
    /// </summary>
    [EdiMessage]
    public class X12_997_Message : X12_Transaction
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

        public List<AK2Group> AK2Groups { get; set; }

        public AK9 AK9 { get; set; }

        [EdiSegment]
        [EdiSegmentGroup("AK2", SequenceEnd = "AK5")]
        public class AK2Group : AK2
        {
            public List<AK3Group> AK3Groups { get; set; }
            public AK5 AK5 { get; set; }
        }

        [EdiSegment]
        [EdiSegmentGroup("AK3", "AK4")]
        public class AK3Group : AK3
        {
            public AK4 AK4 { get; set; }
        }

        public void UpdateSegmentsCount()
        {
            var count = CountSegmentUtility.CountSegments(GetType(), this) + 1;
            if (SE == null)
            {
                SE = new Common.SE();
            }
            SE.SegmentsCount = count.ToString();
        }
    }
}