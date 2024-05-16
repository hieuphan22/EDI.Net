using Edi.Domain.Shared.Enums;
using indice.Edi.Serialization;
using Scm.Edi.Domain.Shared.Attributes;

namespace Edi.Application.Contracts.Poco.X12_4010.Segments
{
    [EdiSegment]
    [EdiPath("LH1")]
    public class LH1
    {
        [EdiValue("X(2)", Path = "LH1/0", Description = "LH101 - Unit or Basis for Measurement Code")]
        [EdiExtension(MinLength = 2, MaxLength = 2, Mandatory = true, EdiType = EdiType.Identifier)]
        public string UnitOrBasisForMeasurementCode { get; set; }

        [EdiValue("X(7)", Path = "LH1/1", Description = "LH102 - Lading Quantity")]
        [EdiExtension(MinLength = 1, MaxLength = 7, Mandatory = true, EdiType = EdiType.Numeric)]
        public string LadingQuantity { get; set; }

        [EdiValue("X(6)", Path = "LH1/2", Description = "LH103 - UN/NA Identification Code")]
        [EdiExtension(MinLength = 6, MaxLength = 6, Mandatory = false, EdiType = EdiType.Identifier)]
        public string UNOrNAIdentificationCode { get; set; }

        [EdiValue("X(6)", Path = "LH1/3", Description = "LH104 - Hazardous Materials Page")]
        [EdiExtension(MinLength = 1, MaxLength = 6, Mandatory = false, EdiType = EdiType.Alphanumeric)]
        public string HazardousMaterialsPage { get; set; }

        [EdiValue("X(30)", Path = "LH1/4", Description = "LH105 - Commodity Code")]
        [EdiExtension(MinLength = 1, MaxLength = 30, Mandatory = false, EdiType = EdiType.Alphanumeric)]
        public string CommodityCode { get; set; }

        [EdiValue("X(2)", Path = "LH1/5", Description = "LH106 - Unit or Basis for Measurement Code")]
        [EdiExtension(MinLength = 2, MaxLength = 2, Mandatory = false, EdiType = EdiType.Identifier)]
        public string UnitOrBasisForMeasurementCode02 { get; set; }

        [EdiValue("X(15)", Path = "LH1/6", Description = "LH107 - Quantity")]
        [EdiExtension(MinLength = 1, MaxLength = 15, Mandatory = false, EdiType = EdiType.Decimal)]
        public string Quantity { get; set; }

        [EdiValue("X(1)", Path = "LH1/7", Description = "LH108 - Compartment ID Code")]
        [EdiExtension(MinLength = 1, MaxLength = 1, Mandatory = false, EdiType = EdiType.Identifier)]
        public string CompartmentIDCode { get; set; }

        [EdiValue("X(1)", Path = "LH1/8", Description = "LH109 - Residue Indicator Code")]
        [EdiExtension(MinLength = 1, MaxLength = 1, Mandatory = false, EdiType = EdiType.Identifier)]
        public string ResidueIndicatorCode { get; set; }

        [EdiValue("X(3)", Path = "LH1/9", Description = "LH110 - Packing Group Code")]
        [EdiExtension(MinLength = 1, MaxLength = 3, Mandatory = false, EdiType = EdiType.Identifier)]
        public string PackingGroupCode { get; set; }

        [EdiValue("X(3)", Path = "LH1/10", Description = "LH111 - Interim Hazardous Material Regulatory Number")]
        [EdiExtension(MinLength = 1, MaxLength = 5, Mandatory = false, EdiType = EdiType.Identifier)]
        public string InterimHazardousMaterialRegulatoryNumber { get; set; }
    }
}
