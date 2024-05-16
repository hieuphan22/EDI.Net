using Edi.Domain.Shared.Attributes;
using Edi.Domain.Shared.Enums;
using indice.Edi.Serialization;
using Scm.Edi.Domain.Shared.Attributes;

namespace Edi.Domain.Shared.Poco.X12_4010.Segments
{
    /// <summary>
    /// Line Item Detail - Packing
    /// </summary>
    [EdiSegment]
    [EdiPath("W20")]
    public class W20
    {
        [EdiValue("X(6)", Format = "N0", Path = "W20/0", Description = "W2001 - Pack")]
        [EdiExtension(MinLength = 1, MaxLength = 6, Mandatory = true, EdiType = EdiType.Numeric)]
        public string Pack { get; set; }

        [EdiValue("9(8)", Format = "R2", Path = "W20/1", Description = "W2002 - Size")]
        [EdiExtension(MinLength = 1, MaxLength = 8, Mandatory = true, EdiType = EdiType.Decimal)]
        public string Size { get; set; }

        [EdiValue("X(2)", Path = "W20/2", Description = "W2003 - Unit or Basis for Measurement Code")]
        [EdiExtension(MinLength = 2, MaxLength = 2, Mandatory = true, EdiType = EdiType.Identifier)]
        public string UnitOrBasisForMeasurementCode { get; set; }

        [EdiValue("9(10)", Format = "R2", Path = "W20/3", Description = "W2004 - Weight")]
        [EdiExtension(MinLength = 1, MaxLength = 10, Mandatory = true, EdiType = EdiType.Decimal)]
        public string Weight { get; set; }

        [EdiValue("X(2)", Path = "W20/4", Description = "W2005 - Weight Qualifier")]
        [EdiExtension(MinLength = 1, MaxLength = 2, Mandatory = true, EdiType = EdiType.Identifier)]
        public string WeightQualifier { get; set; }

        [EdiValue("X(1)", Path = "W20/5", Description = "W2006 - Weight Unit Code")]
        [EdiExtension(MinLength = 1, MaxLength = 1, Mandatory = true, EdiType = EdiType.Identifier)]
        public string WeightUnitCode { get; set; }

        [EdiValue("9(8)", Format = "R3", Path = "W20/6", Description = "W2007 - Unit Weight")]
        [EdiExtension(MinLength = 1, MaxLength = 2, Mandatory = true, EdiType = EdiType.Decimal)]
        public string UnitWeight { get; set; }

        [EdiValue("9(8)", Format = "R2", Path = "W20/7", Description = "W2008 - Volume")]
        [EdiExtension(MinLength = 1, MaxLength = 8, Mandatory = true, EdiType = EdiType.Decimal)]
        public string Volume { get; set; }

        [EdiValue("X(2)", Path = "W20/8", Description = "W2009 - Unit or Basis for Measurement Code")]
        [EdiExtension(MinLength = 2, MaxLength = 2, Mandatory = true, EdiType = EdiType.Identifier)]
        public string UnitOrBasisForMeasurementCode02 { get; set; }

        [EdiValue("X(10)", Path = "W20/9", Description = "W2010 - Color")]
        [EdiExtension(MinLength = 1, MaxLength = 10, Mandatory = true, EdiType = EdiType.Alphanumeric)]
        public string Color { get; set; }
    }
}
