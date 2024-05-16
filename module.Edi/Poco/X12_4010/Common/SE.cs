using System.Collections.Generic;
using Edi.Application.Contracts.Validation.Common;
using Edi.Domain.Shared.Attributes;
using Edi.Domain.Shared.Enums;
using Edi.Domain.Shared.Validation;
using FluentValidation;
using FluentValidation.Results;
using indice.Edi.Serialization;
using Scm.Edi.Domain.Shared.Attributes;

namespace module.Edi.Poco.X12_4010.Common
{
    [EdiSegment]
    [EdiPath("SE")]
    public class SE //: IEdiValidation<SE>
    {
        [EdiValue(Path = "SE/0", Description = "SE01 - Number of included segments")]
        [EdiCount(EdiCountScope.Segments)]
        public int SegmentsCounts { get; set; }

        [EdiValue("X(9)", Path = "SE/1", Description = "SE02 - Transaction set control number (same as ST02)")]
        public string TrailerTransactionSetControlNumber { get; set; }
    }
}
