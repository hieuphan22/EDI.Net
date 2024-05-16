using Edi.Domain.Shared.Attributes;
using Edi.Domain.Shared.Enums;
using indice.Edi.Serialization;
using Scm.Edi.Domain.Shared.Attributes;

namespace Edi.Domain.Shared.Poco.X12_4010.Segments
{
    [EdiSegment, EdiPath("PAL")]
    public class PAL
    {
        [EdiValue("X(2)", Path = "PAL/0", Description = "PAL01 - Pallet Type Code")]
        [EdiExtension(MinLength = 1, MaxLength = 2, Mandatory = false, EdiType = EdiType.Identifier)]
        public string PalletTypeCode { get; set; }

        [EdiValue("X(3)", Format = "N0", Path = "PAL/1", Description = "PAL02 - Pallet Tiers")]
        [EdiExtension(MinLength = 1, MaxLength = 3, Mandatory = false, EdiType = EdiType.Numeric)]
        public string PalletTiers { get; set; }

        [EdiValue("X(3)", Format = "N0", Path = "PAL/2", Description = "PAL03 - Pallet Blocks")]
        [EdiExtension(MinLength = 1, MaxLength = 3, Mandatory = false, EdiType = EdiType.Numeric)]
        public string PalletBlocks { get; set; }

        [EdiValue("X(6)", Format = "N0", Path = "PAL/3", Description = "PAL04 - Pack")]
        [EdiExtension(MinLength = 1, MaxLength = 6, Mandatory = false, EdiType = EdiType.Numeric)]
        public string Pack { get; set; }

        [EdiValue("X(8)", Format = "R", Path = "PAL/4", Description = "PAL05 - Unit Weight")]
        [EdiExtension(MinLength = 1, MaxLength = 8, Mandatory = false, EdiType = EdiType.Decimal)]
        public string UnitWeight { get; set; }

        [EdiValue("X(2)", Path = "PAL/5", Description = "PAL06 - Unit or Basis for Measurement Code")]
        [EdiExtension(MinLength = 2, MaxLength = 2, Mandatory = false, EdiType = EdiType.Identifier)]
        public string UnitBasisMeasurementCode { get; set; }

        [EdiValue("X(8)", Format = "R", Path = "PAL/6", Description = "PAL07 - Length")]
        [EdiExtension(MinLength = 1, MaxLength = 8, Mandatory = false, EdiType = EdiType.Decimal)]
        public string Length { get; set; }

        [EdiValue("X(8)", Format = "R", Path = "PAL/7", Description = "PAL08 - Width")]
        [EdiExtension(MinLength = 1, MaxLength = 8, Mandatory = false, EdiType = EdiType.Decimal)]
        public string Width { get; set; }

        [EdiValue("X(8)", Format = "R", Path = "PAL/8", Description = "PAL09 - Height")]
        [EdiExtension(MinLength = 1, MaxLength = 8, Mandatory = false, EdiType = EdiType.Decimal)]
        public string Height { get; set; }

        [EdiValue("X(2)", Path = "PAL/9", Description = "PAL10 - Unit or Basis for Measurement Code")]
        [EdiExtension(MinLength = 2, MaxLength = 2, Mandatory = false, EdiType = EdiType.Identifier)]
        public string UnitBasisMeasurementCode2 { get; set; }

        [EdiValue("X(9)", Format = "R", Path = "PAL/10", Description = "PAL11 - Gross Weight per Pack")]
        [EdiExtension(MinLength = 1, MaxLength = 9, Mandatory = false, EdiType = EdiType.Decimal)]
        public string GrossWeightPerPack { get; set; }

        [EdiValue("X(2)", Path = "PAL/11", Description = "PAL12 - Unit or Basis for Measurement Code")]
        [EdiExtension(MinLength = 2, MaxLength = 2, Mandatory = false, EdiType = EdiType.Identifier)]
        public string UnitBasisMeasurementCode3 { get; set; }

        [EdiValue("X(9)", Format = "R", Path = "PAL/12", Description = "PAL13 - Gross Volume per Pack")]
        [EdiExtension(MinLength = 1, MaxLength = 9, Mandatory = false, EdiType = EdiType.Decimal)]
        public string GrossVolumePerPack { get; set; }

        [EdiValue("X(2)", Path = "PAL/13", Description = "PAL14 - Unit or Basis for Measurement Code")]
        [EdiExtension(MinLength = 2, MaxLength = 2, Mandatory = false, EdiType = EdiType.Identifier)]
        public string UnitBasisMeasurementCode4 { get; set; }

        [EdiValue("X(1)", Path = "PAL/14", Description = "PAL15 - Pallet Exchange Code")]
        [EdiExtension(MinLength = 1, MaxLength = 1, Mandatory = false, EdiType = EdiType.Identifier)]
        public string PalletExchangeCode { get; set; }

        [EdiValue("X(6)", Format = "N0", Path = "PAL/15", Description = "PAL16 - Inner Pack")]
        [EdiExtension(MinLength = 1, MaxLength = 6, Mandatory = false, EdiType = EdiType.Numeric)]
        public string InnerPack { get; set; }

        [EdiValue("X(1)", Path = "PAL/16", Description = "PAL17 - Pallet Structure Code")]
        [EdiExtension(MinLength = 1, MaxLength = 1, Mandatory = false, EdiType = EdiType.Identifier)]
        public string PalletStructureCode { get; set; }
    }
}
