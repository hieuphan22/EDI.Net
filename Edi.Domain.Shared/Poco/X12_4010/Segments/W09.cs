using Edi.Domain.Shared.Attributes;
using Edi.Domain.Shared.Enums;
using indice.Edi.Serialization;
using Scm.Edi.Domain.Shared.Attributes;

namespace Edi.Domain.Shared.Poco.X12_4010.Segments
{
    public class W09
    {
        [EdiValue("X(2)", Path = "W09/0", Description = "W0901 - Equipment Description Code")]
        [EdiExtension(MinLength = 2, MaxLength = 2, Mandatory = true, EdiType = EdiType.Identifier)]
        public string EquipmentDescriptionCode { get; set; }

        [EdiValue("X(4)", Path = "W09/1", Description = "W0902 - Temperature")]
        [EdiExtension(MinLength = 1, MaxLength = 4, EdiType = EdiType.Decimal)]
        public string Temperature { get; set; }

        [EdiValue("X(2)", Path = "W09/2", Description = "W0903 - Unit or Basis for Measurement Code")]
        [EdiExtension(MinLength = 2, MaxLength = 2, EdiType = EdiType.Identifier)]
        public string UnitOrBasisForMeasurementCode { get; set; }

        [EdiValue("X(4)", Path = "W09/3", Description = "W0904 - Temperature")]
        [EdiExtension(MinLength = 1, MaxLength = 4, EdiType = EdiType.Decimal)]
        public string Temperature02 { get; set; }

        [EdiValue("X(2)", Path = "W09/4", Description = "W0905 - Unit or Basis for Measurement Code")]
        [EdiExtension(MinLength = 2, MaxLength = 2, EdiType = EdiType.Identifier)]
        public string UnitOrBasisForMeasurementCode02 { get; set; }

        [EdiValue("X(60)", Path = "W09/5", Description = "W0906 - Free Form Message")]
        [EdiExtension(MinLength = 1, MaxLength = 60, Mandatory = false, EdiType = EdiType.Alphanumeric)]
        public string FreeFormMessage { get; set; }

        [EdiValue("X(1)", Path = "W09/6", Description = "W0907 - Vent Setting Code")]
        [EdiExtension(MinLength = 1, MaxLength = 1, EdiType = EdiType.Identifier)]
        public string VentSettingCode { get; set; }

        [EdiValue("X(3)", Path = "W09/7", Description = "W0908 - Percent")]
        [EdiExtension(MinLength = 1, MaxLength = 3, Mandatory = false, EdiType = EdiType.Numeric)]
        public string Percent { get; set; }

        [EdiValue("X(15)", Path = "W09/8", Description = "W0909 - Quantity")]
        [EdiExtension(MinLength = 1, MaxLength = 15, Mandatory = false, EdiType = EdiType.Decimal)]
        public string Quantity { get; set; }
    }
}
