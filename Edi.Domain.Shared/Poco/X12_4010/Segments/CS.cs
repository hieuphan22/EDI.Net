using System.Collections.Generic;
using Edi.Domain.Shared.Attributes;
using Edi.Domain.Shared.Enums;
using Edi.Domain.Shared.Validation;
using FluentValidation.Results;
using indice.Edi.Serialization;
using Scm.Edi.Domain.Shared.Attributes;

namespace Edi.Domain.Shared.Poco.X12_4010.Segments
{
    [EdiSegment]
    [EdiPath("CS")]
    public class CS : IEdiValidation<CS>
    {
        [EdiValue("X(30)", Path = "CS/0", Description = "CS01 - Contract Number")]
        [EdiExtension(MinLength = 1, MaxLength = 30, Mandatory = false, EdiType = EdiType.Alphanumeric)]
        public string ContractNumber { get; set; }

        [EdiValue("X(8)", Path = "CS/1", Description = "CS02 - Change Order Sequence Number")]
        [EdiExtension(MinLength = 1, MaxLength = 8, Mandatory = false, EdiType = EdiType.Alphanumeric)]
        public string ChangeOrderSequenceNumber { get; set; }

        [EdiValue("X(30)", Path = "CS/2", Description = "CS03 - Release Number")]
        [EdiExtension(MinLength = 1, MaxLength = 30, Mandatory = false, EdiType = EdiType.Alphanumeric)]
        public string ReleaseNumber { get; set; }

        [EdiValue("X(3)", Path = "CS/3", Description = "CS04 - Reference Identification Qualifier")]
        [EdiExtension(MinLength = 2, MaxLength = 3, Mandatory = false, EdiType = EdiType.Identifier)]
        public string ReferenceIdentificationQualifier { get; set; }

        [EdiValue("X(50)", Path = "CS/4", Description = "CS05 - Reference Identification")]
        [EdiExtension(MinLength = 1, MaxLength = 50, EdiType = EdiType.Alphanumeric)]
        public string ReferenceIdentification { get; set; }

        [EdiValue("X(22)", Path = "CS/5", Description = "CS06 - Purchase Order Number")]
        [EdiExtension(MinLength = 1, MaxLength = 22, Mandatory = false, EdiType = EdiType.Alphanumeric)]
        public string PurchaseOrderNumber { get; set; }

        [EdiValue("X(10)", Path = "CS/6", Description = "CS07 - Special Services Code")]
        [EdiExtension(MinLength = 2, MaxLength = 10, Mandatory = false, EdiType = EdiType.Identifier)]
        public string SpecialServicesCode { get; set; }

        [EdiValue("X(2)", Path = "CS/7", Description = "CS08 - F.O.B. Point Code")]
        [EdiExtension(MinLength = 2, MaxLength = 2, Mandatory = false, EdiType = EdiType.Identifier)]
        public string FOBPointCode { get; set; }

        [EdiValue("X(10)", Path = "CS/8", Format = "R", Description = "CS09 - Percent")]
        [EdiExtension(MinLength = 1, MaxLength = 10, Mandatory = false, EdiType = EdiType.Decimal)]
        public string Percent { get; set; }

        [EdiValue("X(10)", Path = "CS/9", Format = "R", Description = "CS10 - Percent")]
        [EdiExtension(MinLength = 1, MaxLength = 10, Mandatory = false, EdiType = EdiType.Decimal)]
        public string Percent02 { get; set; }

        [EdiValue("X(18)", Path = "CS/10", Format = "R", Description = "CS11 - Monetary Amount")]
        [EdiExtension(MinLength = 1, MaxLength = 18, Mandatory = false, EdiType = EdiType.Decimal)]
        public string MonetaryAmount { get; set; }

        [EdiValue("X(2)", Path = "CS/11", Description = "CS12 - Terms Type Code")]
        [EdiExtension(MinLength = 2, MaxLength = 2, Mandatory = false, EdiType = EdiType.Identifier)]
        public string TermsTypeCode { get; set; }

        [EdiValue("X(10)", Path = "CS/12", Description = "CS13 - Special Services Code")]
        [EdiExtension(MinLength = 2, MaxLength = 10, Mandatory = false, EdiType = EdiType.Identifier)]
        public string SpecialServicesCode02 { get; set; }

        [EdiValue("X(2)", Path = "CS/13", Description = "CS14 - Unit or Basis for Measurement Code")]
        [EdiExtension(MinLength = 2, MaxLength = 2, Mandatory = false, EdiType = EdiType.Identifier)]
        public string UnitOrBasisForMeasurementCode { get; set; }

        [EdiValue("X(17)", Path = "CS/14", Format = "R", Description = "CS15 - Unit Price")]
        [EdiExtension(MinLength = 1, MaxLength = 17, Mandatory = false, EdiType = EdiType.Decimal)]
        public string UnitPrice { get; set; }

        [EdiValue("X(2)", Path = "CS/15", Description = "CS16 - Terms Type Code")]
        [EdiExtension(MinLength = 2, MaxLength = 2, Mandatory = false, EdiType = EdiType.Identifier)]
        public string TermsTypeCode02 { get; set; }

        [EdiValue("X(1)", Path = "CS/16", Description = "CS17 - Yes/No Condition or Response Code")]
        [EdiExtension(MinLength = 1, MaxLength = 1, Mandatory = false, EdiType = EdiType.Identifier)]
        public string YesOrNoConditionOrResponseCode { get; set; }

        [EdiValue("X(1)", Path = "CS/17", Description = "CS18 - Yes/No Condition or Response Code")]
        [EdiExtension(MinLength = 1, MaxLength = 1, Mandatory = false, EdiType = EdiType.Identifier)]
        public string YesOrNoConditionOrResponseCode02 { get; set; }

        public List<ValidationResult> ValidateEdi(CS model) {
            return new List<ValidationResult>();
        }
    }
}
