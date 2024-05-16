using Edi.Domain.Shared.Attributes;
using Edi.Domain.Shared.Enums;
using indice.Edi.Serialization;
using Scm.Edi.Domain.Shared.Attributes;

namespace Edi.Domain.Shared.Poco.X12_4010.Segments
{
    [EdiSegment]
    [EdiPath("CLD")]
    public class CLD
    {
        [EdiValue("X(5)", Path = "CLD/0", Format = "N0", Description = "CLD01 - Number Of Loads")]
        [EdiExtension(MinLength = 1, MaxLength = 5, Mandatory = true, EdiType = EdiType.Numeric)]
        public string NumberOfLoads { get; set; }

        [EdiValue("9(10)", Path = "CLD/1", Format = "R", Description = "CLD02 - Number of Units Shipped")]
        [EdiExtension(MinLength = 1, MaxLength = 10, Mandatory = true, EdiType = EdiType.Decimal)]
        public string NumberOfUnitsShipped { get; set; }

        [EdiValue("X(5)", Path = "CLD/2", Description = "CLD03 - Packaging Code")]
        [EdiExtension(MinLength = 3, MaxLength = 5, Mandatory = false, EdiType = EdiType.Alphanumeric)]
        public string PackagingCode { get; set; }

        [EdiValue("9(8)", Format = "R", Path = "CLD/3", Description = "CLD04 - Size")]
        [EdiExtension(MinLength = 1, MaxLength = 8, Mandatory = false, EdiType = EdiType.Decimal)]
        public string Size { get; set; }

        [EdiValue("X(2)", Path = "CLD/4", Description = "CLD05 - Unit or Basis for Measurement Code")]
        [EdiExtension(MinLength = 2, MaxLength = 2, Mandatory = false, EdiType = EdiType.Identifier)]
        public string UnitOrBasisForMeasurementCode { get; set; }
    }
}