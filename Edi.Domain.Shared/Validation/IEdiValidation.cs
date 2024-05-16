using System.Collections.Generic;
using FluentValidation.Results;

namespace Edi.Domain.Shared.Validation
{
    public interface IEdiValidation<T>
    {
        List<ValidationResult> ValidateEdi(T model);
    }
}
