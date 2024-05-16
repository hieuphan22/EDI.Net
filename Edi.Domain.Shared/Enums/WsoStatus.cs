using System.ComponentModel.DataAnnotations;

namespace Scm.Edi.Domain.Shared.Enums
{
    public enum WsoStatus
    {
        [Display(Name = "Open", Description = "Open", Order = 0)]
        Open = 1,
        [Display(Name = "Verified", Description = "Verified", Order = 1)]
        Verified = 2,
        [Display(Name = "Posted", Description = "Posted", Order = 2)]
        Posted = 3,
    }
}
