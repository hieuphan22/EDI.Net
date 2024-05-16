using Edi.Domain.Shared.Enums;
using indice.Edi.Serialization;
using Scm.Edi.Domain.Shared.Attributes;

namespace Edi.Application.Contracts.Poco.X12_4010.Segments
{
    [EdiSegment]
    [EdiPath("POC")]
    public class POC
    {
        [EdiValue("X(20)", Path = "POC/0", Description = "POC01 - Assigned Identification")]
        [EdiExtension(MinLength = 1, MaxLength = 20, Mandatory = true, EdiType = EdiType.Alphanumeric)]
        public string AssignedIdentification { get; set; }

        [EdiValue("X(2)", Path = "POC/1", Description = "POC02 - Change or Response Type Code")]
        [EdiExtension(MinLength = 2, MaxLength = 2, Mandatory = true, EdiType = EdiType.Identifier)]
        public string ChangeOrResponseTypeCode { get; set; }

        [EdiValue("X(15)", Path = "POC/2", Format = "R", Description = "POC03 - Quantity Ordered")]
        [EdiExtension(MinLength = 1, MaxLength = 15, Mandatory = true, EdiType = EdiType.Decimal)]
        public string QuantityOrdered { get; set; }

        [EdiValue("X(9)", Path = "POC/3", Format = "R", Description = "POC04 - Quantity Left to Receive")]
        [EdiExtension(MinLength = 1, MaxLength = 9, Mandatory = false, EdiType = EdiType.Decimal)]
        public string QuantityLeftToReceive { get; set; }

        [EdiValue("X(2)", Path = "POC/4", Description = "POC05 - Unit or Basis for Measurement Code")]
        [EdiExtension(MinLength = 2, MaxLength = 2, Mandatory = true, EdiType = EdiType.Identifier)]
        public string UnitOfMeasurement { get; set; }

        [EdiValue("X(17)", Path = "POC/5", Format = "R", Description = "POC06 - Unit Price")]
        [EdiExtension(MinLength = 1, MaxLength = 17, Mandatory = false, EdiType = EdiType.Decimal)]
        public string UnitPrice { get; set; }

        [EdiValue("X(2)", Path = "POC/6", Description = "POC07 - Basis of Unit Price Code")]
        [EdiExtension(MinLength = 2, MaxLength = 2, Mandatory = false, EdiType = EdiType.Identifier)]
        public string BasisOfUnitPriceCode { get; set; }

        [EdiValue("X(2)", Path = "POC/7", Description = "POC08 - Product/Service ID Qualifier")]
        [EdiExtension(MinLength = 2, MaxLength = 2, Mandatory = false, EdiType = EdiType.Identifier)]
        public string ProductServiceIDQualifier { get; set; }

        [EdiValue("X(48)", Path = "POC/8", Description = "POC09 - Product/Service ID")]
        [EdiExtension(MinLength = 1, MaxLength = 48, Mandatory = false, EdiType = EdiType.Alphanumeric)]
        public string ProductServiceID { get; set; }

        [EdiValue("X(2)", Path = "POC/9", Description = "POC10 - Product/Service ID Qualifier")]
        [EdiExtension(MinLength = 2, MaxLength = 2, Mandatory = false, EdiType = EdiType.Identifier)]
        public string ProductServiceIDQualifier2 { get; set; }

        [EdiValue("X(48)", Path = "POC/10", Description = "POC11 - Product/Service ID")]
        [EdiExtension(MinLength = 1, MaxLength = 48, Mandatory = false, EdiType = EdiType.Alphanumeric)]
        public string ProductServiceID2 { get; set; }

        [EdiValue("X(2)", Path = "POC/11", Description = "POC12 - Product/Service ID Qualifier")]
        [EdiExtension(MinLength = 2, MaxLength = 2, Mandatory = false, EdiType = EdiType.Identifier)]
        public string ProductServiceIDQualifier3 { get; set; }

        [EdiValue("X(48)", Path = "POC/12", Description = "POC13 - Product/Service ID")]
        [EdiExtension(MinLength = 1, MaxLength = 48, Mandatory = false, EdiType = EdiType.Alphanumeric)]
        public string ProductServiceID3 { get; set; }

        [EdiValue("X(2)", Path = "POC/13", Description = "POC14 - Product/Service ID Qualifier")]
        [EdiExtension(MinLength = 2, MaxLength = 2, Mandatory = false, EdiType = EdiType.Identifier)]
        public string ProductServiceIDQualifier4 { get; set; }

        [EdiValue("X(48)", Path = "POC/14", Description = "POC15 - Product/Service ID")]
        [EdiExtension(MinLength = 1, MaxLength = 48, Mandatory = false, EdiType = EdiType.Alphanumeric)]
        public string ProductServiceID4 { get; set; }

        [EdiValue("X(2)", Path = "POC/15", Description = "POC16 - Product/Service ID Qualifier")]
        [EdiExtension(MinLength = 2, MaxLength = 2, Mandatory = false, EdiType = EdiType.Identifier)]
        public string ProductServiceIDQualifier5 { get; set; }

        [EdiValue("X(48)", Path = "POC/16", Description = "POC17 - Product/Service ID")]
        [EdiExtension(MinLength = 1, MaxLength = 48, Mandatory = false, EdiType = EdiType.Alphanumeric)]
        public string ProductServiceID5 { get; set; }
    }
}
