using Edi.Domain.Shared.Attributes;
using Edi.Domain.Shared.Enums;
using indice.Edi.Serialization;
using Scm.Edi.Domain.Shared.Attributes;

namespace Edi.Domain.Shared.Poco.X12_4010.Segments
{
    [EdiSegment, EdiPath("DMG")]
    public class DMG
    {
        [EdiValue("X(3)", Path = "DMG/0", Description = "DMG01 - Date Time Period Format Qualifier")]
        [EdiExtension(MinLength = 2, MaxLength = 3, Mandatory = true, EdiType = EdiType.Identifier)]
        public string DateTimePeriodFormatQualifier { get; set; }

        [EdiValue("X(35)", Path = "DMG/1", Description = "DMG02 - Date Time Period")]
        [EdiExtension(MinLength = 1, MaxLength = 35, Mandatory = true, EdiType = EdiType.Alphanumeric)]
        public string DateTimePeriod { get; set; }

        [EdiValue("X(1)", Path = "DMG/2", Description = "DMG03 - Gender Code")]
        [EdiExtension(MinLength = 1, MaxLength = 1, Mandatory = true, EdiType = EdiType.Identifier)]
        public string GenderCode { get; set; }

        [EdiValue("X(1)", Path = "DMG/3", Description = "DMG04 - Marital Status Code")]
        [EdiExtension(MinLength = 1, MaxLength = 1, Mandatory = true, EdiType = EdiType.Identifier)]
        public string MaritalStatusCode { get; set; }

        [EdiValue("X(1)", Path = "DMG/4", Description = "DMG05 - Race or Ethnicity Code")]
        [EdiExtension(MinLength = 1, MaxLength = 1, Mandatory = true, EdiType = EdiType.Identifier)]
        public string RaceOrEthnicityCode { get; set; }

        [EdiValue("X(2)", Path = "DMG/5", Description = "DMG06 - Citizenship Status Code")]
        [EdiExtension(MinLength = 1, MaxLength = 2, Mandatory = true, EdiType = EdiType.Identifier)]
        public string CitizenshipStatusCode { get; set; }

        [EdiValue("X(3)", Path = "DMG/6", Description = "DMG07 - Country Code")]
        [EdiExtension(MinLength = 2, MaxLength = 3, Mandatory = true, EdiType = EdiType.Identifier)]
        public string CountryCode { get; set; }

        [EdiValue("X(2)", Path = "DMG/7", Description = "DMG08 - Basis of Verification Code")]
        [EdiExtension(MinLength = 1, MaxLength = 2, Mandatory = true, EdiType = EdiType.Alphanumeric)]
        public string BasisOfVerificationCode { get; set; }

        [EdiValue("X(15)", Format = "R", Path = "DMG/8", Description = "DMG09 - Quantity")]
        [EdiExtension(MinLength = 1, MaxLength = 15, Mandatory = true, EdiType = EdiType.Decimal)]
        public string Quantity { get; set; }

        [EdiValue("X(3)", Path = "DMG/9", Description = "DMG10 - Code List Qualifier Code")]
        [EdiExtension(MinLength = 2, MaxLength = 3, Mandatory = true, EdiType = EdiType.Identifier)]
        public string CodeListQualifierCode { get; set; }

        [EdiValue("X(30)", Path = "DMG/10", Description = "DMG11 - Industry Code")]
        [EdiExtension(MinLength = 1, MaxLength = 30, Mandatory = true, EdiType = EdiType.Alphanumeric)]
        public string IndustryCode { get; set; }
    }
}
