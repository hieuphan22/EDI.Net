using Edi.Application.Contracts.Poco.X12_4010.Common;
using FluentValidation;

namespace Edi.Application.Contracts.Validation.Common
{
    public class IEAValidation : AbstractValidator<IEA>
    {
        public IEAValidation()
        {
            RuleFor(x => x.GroupsCount).NotNull().NotEmpty();
            RuleFor(x => x.TrailerControlNumber).NotNull().NotEmpty();
        }
    }
}
