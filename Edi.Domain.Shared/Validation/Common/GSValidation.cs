using Edi.Application.Contracts.Poco.X12_4010.Common;
using FluentValidation;

namespace Edi.Application.Contracts.Validation.Common
{
    public class GSValidation : AbstractValidator<GS>
    {
        public GSValidation()
        {
            RuleFor(x => x.FunctionalIdentifierCode).NotNull().NotEmpty();
            RuleFor(x => x.ApplicationSenderCode).NotNull().NotEmpty();
            RuleFor(x => x.ApplicationReceiverCode).NotNull().NotEmpty();
            RuleFor(x => x.Date).NotNull().NotEmpty();
            RuleFor(x => x.Time).NotNull().NotEmpty();
            RuleFor(x => x.GroupControlNumber).NotNull().NotEmpty();
            RuleFor(x => x.AgencyCode).NotNull().NotEmpty();
            RuleFor(x => x.Version).NotNull().NotEmpty();
        }
    }
}
