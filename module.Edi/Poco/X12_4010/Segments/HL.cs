using Edi.Domain.Shared.Enums;
using indice.Edi.Serialization;
using Scm.Edi.Domain.Shared.Attributes;

namespace Edi.Application.Contracts.Poco.X12_4010.Segments
{
    /// <summary>
    /// Line Item Detail - Description
    /// </summary>
    [EdiSegment]
    [EdiPath("HL")]
    public class HL
    {
        [EdiValue("X(12)", Path = "HL/0", Description = "HL01 - Hierarchical ID Number")]
        [EdiExtension(MinLength = 1, MaxLength = 12, Mandatory = true, EdiType = EdiType.Identifier)]
        public string HierarchicalIDNumber { get; set; }

        [EdiValue("X(12)", Path = "HL/1", Description = "HL02 - Hierarchical Parent ID Number")]
        [EdiExtension(MinLength = 1, MaxLength = 12, Mandatory = false, EdiType = EdiType.Alphanumeric)]
        public string HierarchicalParentIDNumber { get; set; }

        [EdiValue("X(1)", Path = "HL/2", Description = "HL03 - Hierarchical Level")]
        [EdiExtension(MinLength = 1, MaxLength = 2, Mandatory = true, EdiType = EdiType.Identifier)]
        public string HierarchicalLevel { get; set; }

        [EdiValue("X(1)", Path = "HL/3", Description = "HL04 - Hierarchical Child Code")]
        [EdiExtension(MinLength = 1, MaxLength = 1, Mandatory = true, EdiType = EdiType.Identifier)]
        public string HierarchicalChildCode { get; set; }
    }
}
