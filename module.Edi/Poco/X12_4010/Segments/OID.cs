using Edi.Domain.Shared.Enums;
using indice.Edi.Serialization;
using Scm.Edi.Domain.Shared.Attributes;

namespace Edi.Application.Contracts.Poco.X12_4010.Segments
{
    [EdiSegment]
    [EdiPath("OID")]
    public class OID
    {
        [EdiValue("X(50)", Path = "OID/0", Description = "OID01 - Reference Identification")]
        [EdiExtension(MinLength = 1, MaxLength = 50, EdiType = EdiType.Alphanumeric)]
        public string ReferenceIdentification { get; set; }

        [EdiValue("X(22)", Path = "OID/1", Description = "OID02 - Purchase Order Number")]
        [EdiExtension(MinLength = 1, MaxLength = 22, EdiType = EdiType.Alphanumeric)]
        public string PurchaseOrderNumber { get; set; }

        [EdiValue("X(50)", Path = "OID/2", Description = "OID03 - Reference Identification")]
        [EdiExtension(MinLength = 1, MaxLength = 50, Mandatory = false, EdiType = EdiType.Alphanumeric)]
        public string ReferenceIdentification02 { get; set; }

        [EdiValue("X(3)", Path = "OID/3", Description = "OID04 - Packaging Form Code")]
        [EdiExtension(MinLength = 3, MaxLength = 3, EdiType = EdiType.Identifier)]
        public string PackagingFormCode { get; set; }

        [EdiValue("X(15)", Format = "R", Path = "OID/4", Description = "OID05 - Quantity")]
        [EdiExtension(MinLength = 1, MaxLength = 15, EdiType = EdiType.Decimal)]
        public string Quantity { get; set; }

        [EdiValue("X(1)", Path = "OID/5", Description = "OID06 - Weight Unit Code")]
        [EdiExtension(MinLength = 1, MaxLength = 1, EdiType = EdiType.Identifier)]
        public string WeightUnitCode { get; set; }

        [EdiValue("X(10)", Format = "R", Path = "OID/6", Description = "OID07 - Weight")]
        [EdiExtension(MinLength = 1, MaxLength = 10, EdiType = EdiType.Decimal)]
        public string Weight { get; set; }

        [EdiValue("X(1)", Path = "OID/7", Description = "OID08 - Volume Unit Qualifier")]
        [EdiExtension(MinLength = 1, MaxLength = 1, EdiType = EdiType.Alphanumeric)]
        public string VolumeUnitQualifier { get; set; }

        [EdiValue("X(8)", Format = "R", Path = "OID/8", Description = "OID09 - Volume")]
        [EdiExtension(MinLength = 1, MaxLength = 8, EdiType = EdiType.Decimal)]
        public string Volume { get; set; }

        [EdiValue("X(3)", Path = "OID/9", Description = "OID10 - Application Error Condition Code")]
        [EdiExtension(MinLength = 1, MaxLength = 3, Mandatory = false, EdiType = EdiType.Identifier)]
        public string ApplicationErrorConditionCode { get; set; }

        [EdiValue("X(50)", Path = "OID/10", Description = "OID11 - Reference Identification")]
        [EdiExtension(MinLength = 1, MaxLength = 50, Mandatory = false, EdiType = EdiType.Alphanumeric)]
        public string ReferenceIdentification03 { get; set; }
    }
}
