using Edi.Domain.Shared.Enums;
using indice.Edi.Serialization;
using Scm.Edi.Domain.Shared.Attributes;

namespace Edi.Application.Contracts.Poco.X12_4010.Segments
{
    /// <summary>
    /// Contract Segment
    /// </summary>
    [EdiSegment]
    [EdiPath("W08")]
    public class W08
    {
        [EdiValue("X(2)", Path = "W08/0", Description = "W0801 - Transportation Method/Type Code")]
        [EdiExtension(MinLength = 1, MaxLength = 2, Mandatory = true, EdiType = EdiType.Identifier)]
        public string TransportationMethodOrTypeCode { get; set; }

        [EdiValue("X(4)", Path = "W08/1", Description = "W0802 - Standard Carrier Alpha Code")]
        [EdiExtension(MinLength = 2, MaxLength = 4, EdiType = EdiType.Identifier)]
        public string StandardCarrierAlphaCode { get; set; }

        [EdiValue("X(35)", Path = "W08/2", Description = "W0803 - Routing")]
        [EdiExtension(MinLength = 1, MaxLength = 35, Mandatory = false, EdiType = EdiType.Alphanumeric)]
        public string Routing { get; set; }

        [EdiValue("X(4)", Path = "W08/3", Description = "W0804 - Equipment Initial")]
        [EdiExtension(MinLength = 1, MaxLength = 4, EdiType = EdiType.Alphanumeric)]
        public string EquipmentInitial { get; set; }

        [EdiValue("X(10)", Path = "W08/4", Description = "W0805 - Equipment Number")]
        [EdiExtension(MinLength = 1, MaxLength = 10, EdiType = EdiType.Alphanumeric)]
        public string EquipmentNumber { get; set; }

        [EdiValue("X(15)", Path = "W08/5", Description = "W0806 - Seal Number")]
        [EdiExtension(MinLength = 2, MaxLength = 15, EdiType = EdiType.Alphanumeric)]
        public string SealNumber { get; set; }

        [EdiValue("X(15)", Path = "W08/6", Description = "W0807 - Seal Number")]
        [EdiExtension(MinLength = 2, MaxLength = 15, EdiType = EdiType.Alphanumeric)]
        public string SealNumber02 { get; set; }

        [EdiValue("X(2)", Path = "W08/7", Description = "W0808 - Seal Status Code")]
        [EdiExtension(MinLength = 2, MaxLength = 2, Mandatory = false, EdiType = EdiType.Identifier)]
        public string SealStatusCode { get; set; }

        [EdiValue("X(2)", Path = "W08/8", Description = "W0809 - Unit Load Option Code")]
        [EdiExtension(MinLength = 2, MaxLength = 2, Mandatory = false, EdiType = EdiType.Identifier)]
        public string UnitLoadOptionCode { get; set; }
    }
}
