using Edi.Application.Contracts.Poco.X12_4010.Common;
using FluentValidation;

namespace Edi.Application.Contracts.Validation.Common
{
    public class STValidation : AbstractValidator<ST>
    {
        public STValidation()
        {
            RuleFor(x => x.TransactionSetCode).NotNull().NotEmpty();
            RuleFor(x => x.TransactionSetControlNumber).NotNull().NotEmpty();
        }
    }
}
