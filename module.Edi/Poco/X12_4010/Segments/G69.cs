using Edi.Domain.Shared.Enums;
using indice.Edi.Serialization;
using Scm.Edi.Domain.Shared.Attributes;

namespace Edi.Application.Contracts.Poco.X12_4010.Segments
{
    /// <summary>
    /// Line Item Detail - Description
    /// </summary>
    [EdiSegment]
    [EdiPath("G69")]
    public class G69
    {
        [EdiValue("X(250)", Path = "G69/0", Description = "G6901 - Free-form Description")]
        [EdiExtension(MinLength = 2, MaxLength = 250, Mandatory = false, EdiType = EdiType.Alphanumeric)]
        public string FreeformDescription { get; set; }
    }
}
