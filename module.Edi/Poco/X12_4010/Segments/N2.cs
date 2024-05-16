using Edi.Domain.Shared.Attributes;
using Edi.Domain.Shared.Enums;
using indice.Edi.Serialization;

namespace module.Edi.Poco.X12_4010.Segments
{
    [EdiSegment]
    [EdiPath("N2")]
    public class N2
    {
        [EdiValue("X(60)", Path = "N2/0", Description = "N201 - Name")]
        [EdiExtension(MinLength = 1, MaxLength = 60, Mandatory = true, EdiType = EdiType.Alphanumeric)]
        public string Name { get; set; }

        [EdiValue("X(60)", Path = "N2/1", Description = "N202 - Name")]
        [EdiExtension(MinLength = 1, MaxLength = 60, Mandatory = false, EdiType = EdiType.Alphanumeric)]
        public string Name2 { get; set; }
    }
}
