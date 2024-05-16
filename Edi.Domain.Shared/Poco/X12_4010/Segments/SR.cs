using Edi.Domain.Shared.Attributes;
using Edi.Domain.Shared.Enums;
using indice.Edi.Serialization;
using Scm.Edi.Domain.Shared.Attributes;

namespace Edi.Domain.Shared.Poco.X12_4010.Segments
{
    [EdiSegment, EdiPath("SR")]
    public class SR
    {
        [EdiValue("X(20)", Path = "SR/0", Description = "SR01 - Assigned Identification")]
        [EdiExtension(MinLength = 1, MaxLength = 20, Mandatory = false, EdiType = EdiType.Alphanumeric)]
        public string AssignedIdentification { get; set; }

        [EdiValue("X(7)", Path = "SR/1", Description = "SR02 - Day Rotation")]
        [EdiExtension(MinLength = 1, MaxLength = 7, Mandatory = false, EdiType = EdiType.Alphanumeric)]
        public string DayRotation { get; set; }

        [EdiValue("X(8)", Path = "SR/2", Format = "HHmm", Description = "SR03 - Time")]
        [EdiExtension(MinLength = 4, MaxLength = 8, Mandatory = false, EdiType = EdiType.Time)]
        public string Time { get; set; }

        [EdiValue("X(8)", Path = "SR/3", Format = "HHmm", Description = "SR04 - Time")]
        [EdiExtension(MinLength = 4, MaxLength = 8, Mandatory = false, EdiType = EdiType.Time)]
        public string Time02 { get; set; }

        [EdiValue("X(60)", Path = "SR/4", Description = "SR05 - FreeForm Message")]
        [EdiExtension(MinLength = 1, MaxLength = 60, Mandatory = false, EdiType = EdiType.Alphanumeric)]
        public string FreeFormMessage { get; set; }

        [EdiValue("X(17)", Path = "SR/5", Format = "R", Description = "SR06 - Unit Price")]
        [EdiExtension(MinLength = 1, MaxLength = 17, Mandatory = false, EdiType = EdiType.Decimal)]
        public string UnitPrice { get; set; }

        [EdiValue("X(15)", Path = "SR/6", Format = "R", Description = "SR07 - Quantity")]
        [EdiExtension(MinLength = 1, MaxLength = 15, Mandatory = false, EdiType = EdiType.Decimal)]
        public string Quantity { get; set; }

        [EdiValue("X(8)", Path = "SR/7", Format = "yyyyMMdd", Description = "SR08 - Date")]
        [EdiExtension(MinLength = 8, MaxLength = 8, Mandatory = false, EdiType = EdiType.Date)]
        public string Date { get; set; }

        [EdiValue("X(8)", Path = "SR/8", Format = "yyyyMMdd", Description = "SR09 - Date")]
        [EdiExtension(MinLength = 8, MaxLength = 8, Mandatory = false, EdiType = EdiType.Date)]
        public string Date02 { get; set; }

        [EdiValue("X(48)", Path = "SR/9", Description = "SR10 - Product Or Service ID")]
        [EdiExtension(MinLength = 1, MaxLength = 48, Mandatory = false, EdiType = EdiType.Alphanumeric)]
        public string ProductOrServiceID { get; set; }

        [EdiValue("X(48)", Path = "SR/10", Description = "SR11 - Product Or Service ID")]
        [EdiExtension(MinLength = 1, MaxLength = 48, Mandatory = false, EdiType = EdiType.Alphanumeric)]
        public string ProductOrServiceID02 { get; set; }
    }
}
