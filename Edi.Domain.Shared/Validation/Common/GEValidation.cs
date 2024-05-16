using Edi.Application.Contracts.Poco.X12_4010.Common;
using FluentValidation;

namespace Edi.Application.Contracts.Validation.Common
{
    public class GEValidation : AbstractValidator<GE>
    {
        public GEValidation()
        {
            RuleFor(x => x.TransactionsCount).NotNull().NotEmpty();
            RuleFor(x => x.GroupTrailerControlNumber).NotNull().NotEmpty();
        }
    }
}
