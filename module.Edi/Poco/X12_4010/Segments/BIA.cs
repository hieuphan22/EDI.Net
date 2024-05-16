using System.Collections.Generic;
using Edi.Domain.Shared.Enums;
using Edi.Domain.Shared.Validation;
using FluentValidation.Results;
using indice.Edi.Serialization;
using Scm.Edi.Domain.Shared.Attributes;

namespace Edi.Application.Contracts.Poco.X12_4010.Segments
{
    [EdiSegment]
    [EdiPath("BIA")]
    public class BIA : IEdiValidation<BIA>
    {
        [EdiValue("X(2)", Path = "BIA/0", Description = "BIA01 - Transaction Set Purpose Code")]
        [EdiExtension(MinLength = 2, MaxLength = 2, Mandatory = true, EdiType = EdiType.Identifier)]
        public string TransactionSetPurposeCode { get; set; }

        [EdiValue("X(2)", Path = "BIA/1", Description = "BIA02 - Report Type Code")]
        [EdiExtension(MinLength = 2, MaxLength = 2, Mandatory = true, EdiType = EdiType.Identifier)]
        public string ReportTypeCode { get; set; }

        [EdiValue("X(50)", Path = "BIA/2", Description = "BIA03 - Reference Identification")]
        [EdiExtension(MinLength = 1, MaxLength = 50, Mandatory = true, EdiType = EdiType.Alphanumeric)]
        public string ReferenceIdentification { get; set; }

        [EdiValue("X(8)", Path = "BIA/3", Format = "yyyyMMdd", Description = "BIA04 - Date")]
        [EdiExtension(MinLength = 8, MaxLength = 8, Mandatory = true, EdiType = EdiType.Date)]
        public string Date { get; set; }

        [EdiValue("X(4)", Path = "BIA/4", Format = "HHmm", Description = "BIA05 - Time")]
        [EdiExtension(MinLength = 4, MaxLength = 4, Mandatory = false, EdiType = EdiType.Time)]
        public string Time { get; set; }

        [EdiValue("X(2)", Path = "BIA/5", Description = "BIA06 - Action Code")]
        [EdiExtension(MinLength = 1, MaxLength = 2, Mandatory = false, EdiType = EdiType.Identifier)]
        public string ActionCode { get; set; }

        public List<ValidationResult> ValidateEdi(BIA model)
        {
            return new List<ValidationResult>();
        }
    }
}
