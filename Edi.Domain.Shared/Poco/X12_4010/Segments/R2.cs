using Edi.Domain.Shared.Attributes;
using Edi.Domain.Shared.Enums;
using indice.Edi.Serialization;
using Scm.Edi.Domain.Shared.Attributes;

namespace Edi.Domain.Shared.Poco.X12_4010.Segments
{
    [EdiSegment]
    [EdiPath("R2")]
    public class R2
    {
        [EdiValue("X(4)", Path = "R2/0", Description = "R201 - Standard Carrier Alpha Code")]
        [EdiExtension(MinLength = 2, MaxLength = 4, Mandatory = true, EdiType = EdiType.Identifier)]
        public string StandardCarrierAlphaCode { get; set; }

        [EdiValue("X(2)", Path = "R2/1", Description = "R202 - Routing Sequence Code")]
        [EdiExtension(MinLength = 1, MaxLength = 2, Mandatory = true, EdiType = EdiType.Identifier)]
        public string RoutingSequenceCode { get; set; }

        [EdiValue("X(30)", Path = "R2/2", Description = "R203 - City Name")]
        [EdiExtension(MinLength = 2, MaxLength = 30, Mandatory = true, EdiType = EdiType.Alphanumeric)]
        public string CityName { get; set; }

        [EdiValue("X(9)", Path = "R2/3", Description = "R204 - Standard Point Location Code")]
        [EdiExtension(MinLength = 6, MaxLength = 9, Mandatory = true, EdiType = EdiType.Identifier)]
        public string StandardPointLocationCode { get; set; }

        [EdiValue("X(2)", Path = "R2/4", Description = "R205 - Intermodal Service Code")]
        [EdiExtension(MinLength = 1, MaxLength = 2, Mandatory = true, EdiType = EdiType.Identifier)]
        public string IntermodalServiceCode { get; set; }

        [EdiValue("X(2)", Path = "R2/5", Description = "R206 - Transportation Method/Type Code")]
        [EdiExtension(MinLength = 1, MaxLength = 2, Mandatory = true, EdiType = EdiType.Identifier)]
        public string TransportationMethodCode { get; set; }

        [EdiValue("X(4)", Path = "R2/6", Description = "R207 - Intermediate Switch Carrier")]
        [EdiExtension(MinLength = 2, MaxLength = 4, Mandatory = true, EdiType = EdiType.Identifier)]
        public string IntermediateSwitchCarrier { get; set; }

        [EdiValue("X(4)", Path = "R2/7", Description = "R208 - Intermediate Switch Carrier")]
        [EdiExtension(MinLength = 2, MaxLength = 4, Mandatory = true, EdiType = EdiType.Identifier)]
        public string IntermediateSwitchCarrier02 { get; set; }

        [EdiValue("X(22)", Path = "R2/8", Description = "R209 - Invoice Number")]
        [EdiExtension(MinLength = 1, MaxLength = 22, Mandatory = true, EdiType = EdiType.Alphanumeric)]
        public string InvoiceNumber { get; set; }

        [EdiValue("9(8)", Path = "R2/9", Format = "yyyyMMdd", Description = "R210 - Date")]
        [EdiExtension(MinLength = 8, MaxLength = 8, Mandatory = true, EdiType = EdiType.Date)]
        public string Date { get; set; }

        [EdiValue("X(45)", Path = "R2/10", Description = "R211 - Free-form Description")]
        [EdiExtension(MinLength = 1, MaxLength = 45, Mandatory = true, EdiType = EdiType.Alphanumeric)]
        public string FreeformDescription { get; set; }

        [EdiValue("X(2)", Path = "R2/11", Description = "R212 - Type of Service Code")]
        [EdiExtension(MinLength = 2, MaxLength = 2, Mandatory = true, EdiType = EdiType.Identifier)]
        public string TypeOfServiceCode { get; set; }

        [EdiValue("X(35)", Path = "R2/12", Description = "R213 - Route Description")]
        [EdiExtension(MinLength = 1, MaxLength = 35, Mandatory = true, EdiType = EdiType.Alphanumeric)]
        public string RouteDescription { get; set; }
    }
}
