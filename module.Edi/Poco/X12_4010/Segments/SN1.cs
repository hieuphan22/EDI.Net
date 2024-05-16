using Edi.Domain.Shared.Enums;
using indice.Edi.Serialization;
using Scm.Edi.Domain.Shared.Attributes;

namespace Edi.Application.Contracts.Poco.X12_4010.Segments
{
    [EdiSegment]
    [EdiPath("SN1")]
    public class SN1
    {
        [EdiValue("X(20)", Path = "SN1/0", Description = "SN101 - Assigned Identification")]
        [EdiExtension(MinLength = 1, MaxLength = 20, Mandatory = false, EdiType = EdiType.Identifier)]
        public string AssignedIdentification { get; set; }

        [EdiValue("X(10)", Format = "R", Path = "SN1/1", Description = "SN102 - Number of Units Shipped")]
        [EdiExtension(MinLength = 1, MaxLength = 10, Mandatory = false, EdiType = EdiType.Decimal)]
        public string NumberOfUnitsShipped { get; set; }

        [EdiValue("X(2)", Path = "SN1/2", Description = "SN103 - Unit or Basis for Measurement Code")]
        [EdiExtension(MinLength = 2, MaxLength = 2, Mandatory = true, EdiType = EdiType.Identifier)]
        public string UnitBasisMeasurementCode { get; set; }

        [EdiValue("X(15)", Format = "R", Path = "SN1/3", Description = "SN104 - Quantity Shipped to Date")]
        [EdiExtension(MinLength = 1, MaxLength = 15, Mandatory = false, EdiType = EdiType.Decimal)]
        public string QuantityShippedToDate { get; set; }

        [EdiValue("X(15)", Format = "R", Path = "SN1/4", Description = "SN105 - Quantity Ordered")]
        [EdiExtension(MinLength = 1, MaxLength = 15, Mandatory = false, EdiType = EdiType.Decimal)]
        public string QuantityOrdered { get; set; }

        [EdiValue("X(2)", Path = "SN1/5", Description = "SN106 - Unit or Basis for Measurement Code")]
        [EdiExtension(MinLength = 2, MaxLength = 2, Mandatory = false, EdiType = EdiType.Identifier)]
        public string UnitBasisMeasurementCode2 { get; set; }

        [EdiValue("X(2)", Path = "SN1/6", Description = "SN107 - Returnable Container Load Make- Up Code")]
        [EdiExtension(MinLength = 1, MaxLength = 2, Mandatory = false, EdiType = EdiType.Identifier)]
        public string ReturnableContainerLoadMakeUpCode { get; set; }

        [EdiValue("X(2)", Path = "SN1/7", Description = "SN108 - Line Item Status Code")]
        [EdiExtension(MinLength = 2, MaxLength = 2, Mandatory = true, EdiType = EdiType.Identifier)]
        public string LineItemStatusCode { get; set; }
    }
}
