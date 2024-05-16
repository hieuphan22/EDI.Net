using Edi.Domain.Shared.Attributes;
using Edi.Domain.Shared.Enums;
using indice.Edi.Serialization;
using Scm.Edi.Domain.Shared.Attributes;

namespace Edi.Domain.Shared.Poco.X12_4010.Segments
{
    [EdiSegment]
    [EdiPath("L7")]
    public class L7
    {
        [EdiValue("X(3)", Format = "N0", Path = "L7/0", Description = "L701 - Lading Line Item Number")]
        [EdiExtension(MinLength = 1, MaxLength = 3, EdiType = EdiType.Numeric)]
        public string LadingLineItemNumber { get; set; }

        [EdiValue("X(4)", Path = "L7/1", Description = "L702 - Tariff Agency Code")]
        [EdiExtension(MinLength = 1, MaxLength = 4, EdiType = EdiType.Identifier)]
        public string TariffAgencyCode { get; set; }

        [EdiValue("X(7)", Path = "L7/2", Description = "L703 - Tariff Number")]
        [EdiExtension(MinLength = 1, MaxLength = 7, EdiType = EdiType.Alphanumeric)]
        public string TariffNumber { get; set; }

        [EdiValue("X(2)", Path = "L7/3", Description = "L704 - Tariff Section")]
        [EdiExtension(MinLength = 1, MaxLength = 2, EdiType = EdiType.Alphanumeric)]
        public string TariffSection { get; set; }

        [EdiValue("X(16)", Path = "L7/4", Description = "L705 - Tariff Item Number")]
        [EdiExtension(MinLength = 1, MaxLength = 16, EdiType = EdiType.Alphanumeric)]
        public string TariffItemNumber { get; set; }

        [EdiValue("X(2)", Format = "N0", Path = "L7/5", Description = "L706 - Tariff Item Part")]
        [EdiExtension(MinLength = 1, MaxLength = 2, EdiType = EdiType.Numeric)]
        public string TariffItemPart { get; set; }

        [EdiValue("X(5)", Path = "L7/6", Description = "L707 - Freight Class Code")]
        [EdiExtension(MinLength = 2, MaxLength = 5, EdiType = EdiType.Alphanumeric)]
        public string FreightClassCode { get; set; }

        [EdiValue("X(4)", Path = "L7/7", Description = "L708 - Tariff Supplement Identifier")]
        [EdiExtension(MinLength = 1, MaxLength = 4, EdiType = EdiType.Alphanumeric)]
        public string TariffSupplementIdentifier { get; set; }

        [EdiValue("X(4)", Path = "L7/8", Description = "L709 - ExParte")]
        [EdiExtension(MinLength = 4, MaxLength = 4, EdiType = EdiType.Alphanumeric)]
        public string ExParte { get; set; }

        [EdiValue("X(8)", Path = "L7/9", Format = "yyyyMMdd", Description = "L7010 - Date")]
        [EdiExtension(MinLength = 8, MaxLength = 8, EdiType = EdiType.Date)]
        public string Date { get; set; }

        [EdiValue("X(6)", Path = "L7/10", Description = "L711 - Rate Basis Number")]
        [EdiExtension(MinLength = 1, MaxLength = 6, EdiType = EdiType.Alphanumeric)]
        public string RateBasisNumber { get; set; }

        [EdiValue("X(2)", Path = "L7/11", Description = "L712 - Tariff Column")]
        [EdiExtension(MinLength = 1, MaxLength = 2, EdiType = EdiType.Alphanumeric)]
        public string TariffColumn { get; set; }

        [EdiValue("X(5)", Format = "N0", Path = "L7/12", Description = "L713 - Tariff Distance")]
        [EdiExtension(MinLength = 1, MaxLength = 5, EdiType = EdiType.Numeric)]
        public string TariffDistance { get; set; }

        [EdiValue("X(1)", Path = "L7/13", Description = "L714 - Distance Qualifier")]
        [EdiExtension(MinLength = 1, MaxLength = 1, EdiType = EdiType.Identifier)]
        public string DistanceQualifier { get; set; }

        [EdiValue("X(30)", Path = "L7/14", Description = "L715 - City Name")]
        [EdiExtension(MinLength = 2, MaxLength = 30, EdiType = EdiType.Alphanumeric)]
        public string CityName { get; set; }

        [EdiValue("X(2)", Path = "L7/15", Description = "L716 - State Or Province Code")]
        [EdiExtension(MinLength = 2, MaxLength = 2, EdiType = EdiType.Identifier)]
        public string StateOrProvinceCode { get; set; }
    }
}
