using Edi.Domain.Shared.Attributes;
using Edi.Domain.Shared.Enums;
using indice.Edi.Serialization;
using Scm.Edi.Domain.Shared.Attributes;

namespace Edi.Domain.Shared.Poco.X12_4010.Segments
{
    [EdiSegment]
    [EdiPath("IT1")]
    public class IT1
    {
        [EdiValue("X(20)", Path = "IT1/0", Description = "IT101 - Assigned Identification")]
        [EdiExtension(MinLength = 1, MaxLength = 20, Mandatory = true, EdiType = EdiType.Alphanumeric)]
        public string AssignedIdentification { get; set; }

        [EdiValue("9(10)", Format = "R", Path = "IT1/1", Description = "IT102 - Quantity Invoiced")]
        [EdiExtension(MinLength = 1, MaxLength = 10, Mandatory = true, EdiType = EdiType.Decimal)]
        public string QuantityInvoiced { get; set; }

        [EdiValue("X(2)", Path = "IT1/2", Description = "IT103 - Unit or Basis for Measurement Code")]
        [EdiExtension(MinLength = 2, MaxLength = 2, Mandatory = true, EdiType = EdiType.Identifier)]
        public string MeasurementCode { get; set; }

        [EdiValue("9(17)", Format = "R", Path = "IT1/3", Description = "IT104 - Unit Price")]
        [EdiExtension(MinLength = 1, MaxLength = 17, Mandatory = true, EdiType = EdiType.Decimal)]
        public string UnitPrice { get; set; }

        [EdiValue("X(2)", Path = "IT1/4", Description = "IT105 - Basis of Unit Price Code")]
        [EdiExtension(MinLength = 2, MaxLength = 2, Mandatory = true, EdiType = EdiType.Identifier)]
        public string UnitPriceCode { get; set; }

        [EdiValue("X(2)", Path = "IT1/5", Description = "IT106 - Product/Service ID Qualifier")]
        [EdiExtension(MinLength = 2, MaxLength = 2, Mandatory = true, EdiType = EdiType.Identifier)]
        public string ProductServiceIdQualifier01 { get; set; }

        [EdiValue("X(48)", Path = "IT1/6", Description = "IT107 - Product/Service ID")]
        [EdiExtension(MinLength = 1, MaxLength = 48, Mandatory = true, EdiType = EdiType.Alphanumeric)]
        public string ProductServiceId01 { get; set; }

        [EdiValue("X(2)", Path = "IT1/7", Description = "IT108 - Product/Service ID Qualifier")]
        [EdiExtension(MinLength = 2, MaxLength = 2, Mandatory = false, EdiType = EdiType.Identifier)]
        public string ProductServiceIdQualifier02 { get; set; }

        [EdiValue("X(48)", Path = "IT1/8", Description = "IT109 - Product/Service ID")]
        [EdiExtension(MinLength = 1, MaxLength = 48, Mandatory = false, EdiType = EdiType.Alphanumeric)]
        public string ProductServiceId02 { get; set; }

        [EdiValue("X(2)", Path = "IT1/9", Description = "IT110 - Product/Service ID Qualifier")]
        [EdiExtension(MinLength = 2, MaxLength = 2, Mandatory = true, EdiType = EdiType.Identifier)]
        public string ProductServiceIdQualifier03 { get; set; }

        [EdiValue("X(48)", Path = "IT1/10", Description = "IT111 - Product/Service ID")]
        [EdiExtension(MinLength = 1, MaxLength = 48, Mandatory = true, EdiType = EdiType.Alphanumeric)]
        public string ProductServiceId03 { get; set; }

        [EdiValue("X(2)", Path = "IT1/11", Description = "IT112 - Product/Service ID Qualifier")]
        [EdiExtension(MinLength = 2, MaxLength = 2, Mandatory = true, EdiType = EdiType.Identifier)]
        public string ProductServiceIdQualifier04 { get; set; }

        [EdiValue("X(48)", Path = "IT1/12", Description = "IT113 - Product/Service ID")]
        [EdiExtension(MinLength = 1, MaxLength = 48, Mandatory = true, EdiType = EdiType.Alphanumeric)]
        public string ProductServiceId04 { get; set; }

        [EdiValue("X(2)", Path = "IT1/13", Description = "IT114 - Product/Service ID Qualifier")]
        [EdiExtension(MinLength = 2, MaxLength = 2, Mandatory = true, EdiType = EdiType.Identifier)]
        public string ProductServiceIdQualifier05 { get; set; }

        [EdiValue("X(48)", Path = "IT1/14", Description = "IT115- Product/Service ID")]
        [EdiExtension(MinLength = 1, MaxLength = 48, Mandatory = true, EdiType = EdiType.Alphanumeric)]
        public string ProductServiceId05 { get; set; }

        [EdiValue("X(2)", Path = "IT1/15", Description = "IT116 - Product/Service ID Qualifier")]
        [EdiExtension(MinLength = 2, MaxLength = 2, Mandatory = true, EdiType = EdiType.Identifier)]
        public string ProductServiceIdQualifier06 { get; set; }

        [EdiValue("X(48)", Path = "IT1/16", Description = "IT117 - Product/Service ID")]
        [EdiExtension(MinLength = 1, MaxLength = 48, Mandatory = true, EdiType = EdiType.Alphanumeric)]
        public string ProductServiceId06 { get; set; }

        [EdiValue("X(2)", Path = "IT1/17", Description = "IT118 - Product/Service ID Qualifier")]
        [EdiExtension(MinLength = 2, MaxLength = 2, Mandatory = true, EdiType = EdiType.Identifier)]
        public string ProductServiceIdQualifier07 { get; set; }

        [EdiValue("X(48)", Path = "IT1/18", Description = "IT119 - Product/Service ID")]
        [EdiExtension(MinLength = 1, MaxLength = 48, Mandatory = true, EdiType = EdiType.Alphanumeric)]
        public string ProductServiceId07 { get; set; }

        [EdiValue("X(2)", Path = "IT1/19", Description = "IT120 - Product/Service ID Qualifier")]
        [EdiExtension(MinLength = 2, MaxLength = 2, Mandatory = true, EdiType = EdiType.Identifier)]
        public string ProductServiceIdQualifier08 { get; set; }

        [EdiValue("X(48)", Path = "IT1/20", Description = "IT121 - Product/Service ID")]
        [EdiExtension(MinLength = 1, MaxLength = 48, Mandatory = true, EdiType = EdiType.Alphanumeric)]
        public string ProductServiceId08 { get; set; }

        [EdiValue("X(2)", Path = "IT1/21", Description = "IT122 - Product/Service ID Qualifier")]
        [EdiExtension(MinLength = 2, MaxLength = 2, Mandatory = true, EdiType = EdiType.Identifier)]
        public string ProductServiceIdQualifier09 { get; set; }

        [EdiValue("X(48)", Path = "IT1/22", Description = "IT123 - Product/Service ID")]
        [EdiExtension(MinLength = 1, MaxLength = 48, Mandatory = true, EdiType = EdiType.Alphanumeric)]
        public string ProductServiceId09 { get; set; }

        [EdiValue("X(2)", Path = "IT1/23", Description = "IT124 - Product/Service ID Qualifier")]
        [EdiExtension(MinLength = 2, MaxLength = 2, Mandatory = true, EdiType = EdiType.Identifier)]
        public string ProductServiceIdQualifier10 { get; set; }

        [EdiValue("X(48)", Path = "IT1/24", Description = "IT125 - Product/Service ID")]
        [EdiExtension(MinLength = 1, MaxLength = 48, Mandatory = true, EdiType = EdiType.Alphanumeric)]
        public string ProductServiceId10 { get; set; }
    }
}
