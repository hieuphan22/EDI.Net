using Edi.Application.Contracts.Poco.X12_4010.Common;
using FluentValidation;

namespace Edi.Application.Contracts.Validation.Common
{
    public class SEValidation : AbstractValidator<SE>
    {
        public SEValidation()
        {
            RuleFor(x => x.SegmentsCount).NotNull().NotEmpty();
            RuleFor(x => x.TrailerTransactionSetControlNumber).NotNull().NotEmpty();
        }
    }
}
