using Edi.Application.Contracts.Poco.X12_4010.Common;
using FluentValidation;

namespace Edi.Application.Contracts.Validation.Common
{
    public class ISAValidation : AbstractValidator<ISA>
    {
        public ISAValidation()
        {
            RuleFor(x => x.AuthorizationInformationQualifier).NotNull().NotEmpty();
            RuleFor(x => x.AuthorizationInformation).NotNull();
            RuleFor(x => x.SecurityInformationQualifier).NotNull().NotEmpty();
            RuleFor(x => x.SecurityInformation).NotNull();
            RuleFor(x => x.IdQualifier).NotNull().NotEmpty();
            RuleFor(x => x.SenderId).NotNull().NotEmpty();
            RuleFor(x => x.IdQualifier2).NotNull().NotEmpty();
            RuleFor(x => x.ReceiverId).NotNull().NotEmpty();
            RuleFor(x => x.InterchangeDate).NotNull().NotEmpty();
            RuleFor(x => x.InterchangeTime).NotNull().NotEmpty();
            RuleFor(x => x.ControlVersion).NotNull().NotEmpty();
            RuleFor(x => x.ControlNumber).NotNull().NotEmpty();
            RuleFor(x => x.AcknowledgementRequested).NotNull().NotEmpty();
            RuleFor(x => x.UsageIndicator).NotNull().NotEmpty();
        }
    }
}
