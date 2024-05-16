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
    [EdiPath("DD")]
    public class DD : IEdiValidation<DD>
    {
        [EdiValue("X(30)", Path = "DD/0", Description = "DD01 - Industry Code")]
        [EdiExtension(MinLength = 1, MaxLength = 30, EdiType = EdiType.Alphanumeric)]
        public string IndustryCode { get; set; }

        [EdiValue("X(3)", Path = "DD/1", Description = "DD02 - Code List Qualifier Code")]
        [EdiExtension(MinLength = 1, MaxLength = 3, Mandatory = false, EdiType = EdiType.Identifier)]
        public string CodeListQualifierCode { get; set; }

        [EdiValue("X(3)", Path = "DD/2", Description = "DD03 - Reference Identification Qualifier")]
        [EdiExtension(MinLength = 2, MaxLength = 3, EdiType = EdiType.Identifier)]
        public string ReferenceIdentificationQualifier { get; set; }

        [EdiValue("X(50)", Path = "DD/3", Description = "DD04 - Reference Identification")]
        [EdiExtension(MinLength = 1, MaxLength = 50, EdiType = EdiType.Alphanumeric)]
        public string ReferenceIdentification { get; set; }

        [EdiValue("X(30)", Path = "DD/4", Description = "DD05 - Industry Code")]
        [EdiExtension(MinLength = 1, MaxLength = 30, EdiType = EdiType.Alphanumeric)]
        public string IndustryCode02 { get; set; }

        [EdiValue("X(3)", Path = "DD/5", Description = "DD06 - Code List Qualifier Code")]
        [EdiExtension(MinLength = 1, MaxLength = 3, Mandatory = false, EdiType = EdiType.Identifier)]
        public string CodeListQualifierCode02 { get; set; }

        [EdiValue("X(15)", Path = "DD/6", Format = "R", Description = "DD07 - Quantity")]
        [EdiExtension(MinLength = 1, MaxLength = 15, Mandatory = false, EdiType = EdiType.Decimal)]
        public string Quantity { get; set; }

        [EdiValue("X(1)", Path = "DD/7", Description = "DD08 - Yes/No Condition or Response Code")]
        [EdiExtension(MinLength = 1, MaxLength = 1, Mandatory = false, EdiType = EdiType.Identifier)]
        public string YesOrNoConditionOrResponseCode { get; set; }

        [EdiValue("X(30)", Path = "DD/8", Description = "DD09 - Industry Code")]
        [EdiExtension(MinLength = 1, MaxLength = 30, EdiType = EdiType.Alphanumeric)]
        public string IndustryCode03 { get; set; }

        [EdiValue("X(3)", Path = "DD/9", Description = "DD10 - Code List Qualifier Code")]
        [EdiExtension(MinLength = 1, MaxLength = 3, Mandatory = false, EdiType = EdiType.Identifier)]
        public string CodeListQualifierCode03 { get; set; }

        public List<ValidationResult> ValidateEdi(DD model) {
            return new List<ValidationResult>();
        }
    }
}
