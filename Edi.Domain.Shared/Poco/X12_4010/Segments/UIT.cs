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
    [EdiPath("UIT")]
    public class UIT : IEdiValidation<UIT>
    {
        [EdiValue("X(17)", Path = "UIT/0", Format = "R", Description = "UIT01 - Unit Price")]
        [EdiExtension(MinLength = 1, MaxLength = 17, EdiType = EdiType.Decimal)]
        public string UnitPrice { get; set; }

        [EdiValue("X(2)", Path = "UIT/1", Description = "UIT02 - Basis of Unit Price Code")]
        [EdiExtension(MinLength = 2, MaxLength = 2, EdiType = EdiType.Identifier)]
        public string BasisOfUnitPriceCode { get; set; }

        public List<ValidationResult> ValidateEdi(UIT model) {
            return new List<ValidationResult>();
        }
    }
}
