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
    [EdiPath("G53")]
    public class G53 : IEdiValidation<G53>
    {
        [EdiValue("X(3)", Path = "G53/0", Description = "G5301 - Maintenance Type Code")]
        [EdiExtension(MinLength = 3, MaxLength = 3, Mandatory = false, EdiType = EdiType.Identifier)]
        public string MaintenanceTypeCode { get; set; }

        public List<ValidationResult> ValidateEdi(G53 model) {
            return new List<ValidationResult>();
        }
    }
}
