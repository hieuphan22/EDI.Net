using Edi.Domain.Shared.Attributes;
using Edi.Domain.Shared.Enums;
using indice.Edi.Serialization;
using Scm.Edi.Domain.Shared.Attributes;

namespace Edi.Domain.Shared.Poco.X12_4010.Segments
{
    [EdiSegment, EdiPath("ACK")]
    public class ACK
    {
        [EdiValue("X(2)", Path = "ACK/0", Description = "ACK01 - Line Item Status Code")]
        [EdiExtension(MinLength = 2, MaxLength = 2, Mandatory = true, EdiType = EdiType.Identifier)]
        public string LineItemStatusCode { get; set; }

        [EdiValue("X(15)", Path = "ACK/1", Format = "R", Description = "ACK02 - Quantity")]
        [EdiExtension(MinLength = 1, MaxLength = 15, Mandatory = false, EdiType = EdiType.Decimal)]
        public string Quantity { get; set; }

        [EdiValue("X(2)", Path = "ACK/2", Description = "ACK03 - Unit or Basis for Measurement Code")]
        [EdiExtension(MinLength = 2, MaxLength = 2, Mandatory = false, EdiType = EdiType.Identifier)]
        public string UnitOrBasisForMeasurementCode { get; set; }

        [EdiValue("X(3)", Path = "ACK/3", Description = "ACK04 - Date/Time Qualifier")]
        [EdiExtension(MinLength = 3, MaxLength = 3, Mandatory = false, EdiType = EdiType.Identifier)]
        public string DateTimeQualifier { get; set; }

        [EdiValue("X(8)", Path = "ACK/4", Format = "yyyyMMdd", Description = "ACK05 - Date")]
        [EdiExtension(MinLength = 8, MaxLength = 8, Mandatory = false, EdiType = EdiType.Date)]
        public string Date { get; set; }

        [EdiValue("X(1)", Path = "ACK/5", Description = "ACK06 - Request Reference Number")]
        [EdiExtension(MinLength = 1, MaxLength = 1, Mandatory = false, EdiType = EdiType.Alphanumeric)]
        public string RequestReferenceNumber { get; set; }

        [EdiValue("X(2)", Path = "ACK/6", Description = "ACK07 - Product Or Service ID Qualifier")]
        [EdiExtension(MinLength = 2, MaxLength = 2, Mandatory = false, EdiType = EdiType.Identifier)]
        public string ProductOrServiceIDQualifier { get; set; }

        [EdiValue("X(48)", Path = "ACK/7", Description = "ACK08 - Product Or Service ID")]
        [EdiExtension(MinLength = 1, MaxLength = 48, Mandatory = false, EdiType = EdiType.Alphanumeric)]
        public string ProductOrServiceID { get; set; }

        [EdiValue("X(2)", Path = "ACK/8", Description = "ACK09 - Product Or Service ID Qualifier 02")]
        [EdiExtension(MinLength = 2, MaxLength = 2, Mandatory = false, EdiType = EdiType.Identifier)]
        public string ProductOrServiceIDQualifier02 { get; set; }

        [EdiValue("X(48)", Path = "ACK/9", Description = "ACK010 - Product Or Service ID 02")]
        [EdiExtension(MinLength = 1, MaxLength = 48, Mandatory = false, EdiType = EdiType.Alphanumeric)]
        public string ProductOrServiceID02 { get; set; }

        [EdiValue("X(2)", Path = "ACK/10", Description = "ACK11 - Product Or Service ID Qualifier 03")]
        [EdiExtension(MinLength = 2, MaxLength = 2, Mandatory = false, EdiType = EdiType.Identifier)]
        public string ProductOrServiceIDQualifier03 { get; set; }

        [EdiValue("X(48)", Path = "ACK/11", Description = "ACK12 - Product Or Service ID 03")]
        [EdiExtension(MinLength = 1, MaxLength = 48, Mandatory = false, EdiType = EdiType.Alphanumeric)]
        public string ProductOrServiceID03 { get; set; }

        [EdiValue("X(2)", Path = "ACK/12", Description = "ACK13 - Product Or Service ID Qualifier 04")]
        [EdiExtension(MinLength = 2, MaxLength = 2, Mandatory = false, EdiType = EdiType.Identifier)]
        public string ProductOrServiceIDQualifier04 { get; set; }

        [EdiValue("X(48)", Path = "ACK/13", Description = "ACK14 - Product Or Service ID 04")]
        [EdiExtension(MinLength = 1, MaxLength = 48, Mandatory = false, EdiType = EdiType.Alphanumeric)]
        public string ProductOrServiceID04 { get; set; }

        [EdiValue("X(2)", Path = "ACK/14", Description = "ACK15 - Product Or Service ID Qualifier 05")]
        [EdiExtension(MinLength = 2, MaxLength = 2, Mandatory = false, EdiType = EdiType.Identifier)]
        public string ProductOrServiceIDQualifier05 { get; set; }

        [EdiValue("X(48)", Path = "ACK/15", Description = "ACK26 - Product Or Service ID 05")]
        [EdiExtension(MinLength = 1, MaxLength = 48, Mandatory = false, EdiType = EdiType.Alphanumeric)]
        public string ProductOrServiceID05 { get; set; }

        [EdiValue("X(2)", Path = "ACK/16", Description = "ACK17 - Product Or Service ID Qualifier 06")]
        [EdiExtension(MinLength = 2, MaxLength = 2, Mandatory = false, EdiType = EdiType.Identifier)]
        public string ProductOrServiceIDQualifier06 { get; set; }

        [EdiValue("X(48)", Path = "ACK/17", Description = "ACK18 - Product Or Service ID 06")]
        [EdiExtension(MinLength = 1, MaxLength = 48, Mandatory = false, EdiType = EdiType.Alphanumeric)]
        public string ProductOrServiceID06 { get; set; }

        [EdiValue("X(2)", Path = "ACK/18", Description = "ACK19 - Product Or Service ID Qualifier 07")]
        [EdiExtension(MinLength = 2, MaxLength = 2, Mandatory = false, EdiType = EdiType.Identifier)]
        public string ProductOrServiceIDQualifier07 { get; set; }

        [EdiValue("X(48)", Path = "ACK/19", Description = "ACK20 - Product Or Service ID 07")]
        [EdiExtension(MinLength = 1, MaxLength = 48, Mandatory = false, EdiType = EdiType.Alphanumeric)]
        public string ProductOrServiceID07 { get; set; }

        [EdiValue("X(2)", Path = "ACK/20", Description = "ACK21 - Product Or Service ID Qualifier 08")]
        [EdiExtension(MinLength = 2, MaxLength = 2, Mandatory = false, EdiType = EdiType.Identifier)]
        public string ProductOrServiceIDQualifier08 { get; set; }

        [EdiValue("X(48)", Path = "ACK/21", Description = "ACK22 - Product Or Service ID 08")]
        [EdiExtension(MinLength = 1, MaxLength = 48, Mandatory = false, EdiType = EdiType.Alphanumeric)]
        public string ProductOrServiceID08 { get; set; }

        [EdiValue("X(2)", Path = "ACK/22", Description = "ACK23 - Product Or Service ID Qualifier 09")]
        [EdiExtension(MinLength = 2, MaxLength = 2, Mandatory = false, EdiType = EdiType.Identifier)]
        public string ProductOrServiceIDQualifier09 { get; set; }

        [EdiValue("X(48)", Path = "ACK/23", Description = "ACK24 - Product Or Service ID 09")]
        [EdiExtension(MinLength = 1, MaxLength = 48, Mandatory = false, EdiType = EdiType.Alphanumeric)]
        public string ProductOrServiceID09 { get; set; }

        [EdiValue("X(2)", Path = "ACK/24", Description = "ACK25 - Product Or Service ID Qualifier 10")]
        [EdiExtension(MinLength = 2, MaxLength = 2, Mandatory = false, EdiType = EdiType.Identifier)]
        public string ProductOrServiceIDQualifier10 { get; set; }

        [EdiValue("X(48)", Path = "ACK/25", Description = "ACK26 - Product Or Service ID 10")]
        [EdiExtension(MinLength = 1, MaxLength = 48, Mandatory = false, EdiType = EdiType.Alphanumeric)]
        public string ProductOrServiceID10 { get; set; }

        [EdiValue("X(2)", Path = "ACK/26", Description = "ACK27 - Agency Qualifier Code")]
        [EdiExtension(MinLength = 2, MaxLength = 2, Mandatory = false, EdiType = EdiType.Identifier)]
        public string AgencyQualifierCode { get; set; }

        [EdiValue("X(15)", Path = "ACK/27", Description = "ACK28 - Product Or Service ID 10")]
        [EdiExtension(MinLength = 1, MaxLength = 15, Mandatory = false, EdiType = EdiType.Alphanumeric)]
        public string SourceSubqualifier { get; set; }

        [EdiValue("X(30)", Path = "ACK/28", Description = "ACK29 - Industry Code")]
        [EdiExtension(MinLength = 1, MaxLength = 30, Mandatory = false, EdiType = EdiType.Alphanumeric)]
        public string IndustryCode { get; set; }
    }
}
