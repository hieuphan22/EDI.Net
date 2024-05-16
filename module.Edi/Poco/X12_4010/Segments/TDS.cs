using Edi.Domain.Shared.Enums;
using indice.Edi.Serialization;
using Scm.Edi.Domain.Shared.Attributes;
namespace Edi.Application.Contracts.Poco.X12_4010.Segments
{
    [EdiSegment]
    [EdiPath("TDS")]
    public class TDS
    {
        [EdiValue("9(15)", Format = "N2", Path = "TDS/0", Description = "TDS01 - Amount")]
        [EdiExtension(MinLength = 1, MaxLength = 15, Mandatory = true, EdiType = EdiType.Numeric)]
        public string Amount { get; set; }
        [EdiValue("9(15)", Format = "N2", Path = "TDS/1", Description = "TDS02 - Amount")]
        [EdiExtension(MinLength = 1, MaxLength = 15, Mandatory = false, EdiType = EdiType.Numeric)]
        public string Amount02 { get; set; }
        [EdiValue("9(15)", Format = "N2", Path = "TDS/2", Description = "TDS03 -Amount")]
        [EdiExtension(MinLength = 1, MaxLength = 15, Mandatory = false, EdiType = EdiType.Numeric)]
        public string Amount03 { get; set; }

        [EdiValue("9(15)", Format = "N2", Path = "TDS/3", Description = "TDS04 -Amount")]
        [EdiExtension(MinLength = 1, MaxLength = 15, Mandatory = false, EdiType = EdiType.Numeric)]
        public string Amount04 { get; set; }
    }
}
