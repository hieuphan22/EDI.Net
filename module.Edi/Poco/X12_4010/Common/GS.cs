using Edi.Domain.Shared.Enums;
using indice.Edi.Serialization;
using Scm.Edi.Domain.Shared.Attributes;

namespace Edi.Application.Contracts.Poco.X12_4010.Common
{
    [EdiSegment]
    [EdiPath("GS")]
    public class GS
    {
        [EdiValue("X(2)", Path = "GS/0", Description = "GS01 - Functional Identifier Code")]
        [EdiExtension(MinLength = 2, MaxLength = 2, Mandatory = true, EdiType = EdiType.Identifier)]
        public string FunctionalIdentifierCode { get; set; }

        [EdiValue("X(15)", Path = "GS/1", Description = "GS02 - Application Sender's Code")]
        [EdiExtension(MinLength = 2, MaxLength = 15, Mandatory = true, EdiType = EdiType.Alphanumeric)]
        public string ApplicationSenderCode { get; set; }

        [EdiValue("X(15)", Path = "GS/2", Description = "GS03 - Application Receiver's Code")]
        [EdiExtension(MinLength = 2, MaxLength = 15, Mandatory = true, EdiType = EdiType.Alphanumeric)]
        public string ApplicationReceiverCode { get; set; }

        [EdiValue("X(8)", Path = "GS/3", Format = "yyyyMMdd", Description = "GS04 - Date")]
        [EdiExtension(MinLength = 8, MaxLength = 8, Mandatory = true, EdiType = EdiType.Date)]
        public string Date { get; set; }

        [EdiValue("X(8)", Path = "GS/4", Format = "HHmm", Description = "GS05 - Time")]
        [EdiExtension(MinLength = 4, MaxLength = 8, Mandatory = true, EdiType = EdiType.Time)]
        public string Time { get; set; }

        [EdiValue("X(9)", Format = "N0", Path = "GS/5", Description = "GS06 - Group Control Number")]
        [EdiExtension(MinLength = 1, MaxLength = 9, Mandatory = true, EdiType = EdiType.Numeric)]
        public string GroupControlNumber { get; set; }

        [EdiValue("X(2)", Path = "GS/6", Description = "GS07 - Responsible Agency Code")]
        [EdiExtension(MinLength = 1, MaxLength = 2, Mandatory = true, EdiType = EdiType.Identifier)]
        public string AgencyCode { get; set; }

        [EdiValue("X(12)", Path = "GS/7", Description = "GS08 - Version / Release / Industry Identifier Code")]
        [EdiExtension(MinLength = 1, MaxLength = 12, Mandatory = true, EdiType = EdiType.Alphanumeric)]
        public string Version { get; set; }
    }
}
