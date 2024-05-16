using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scm.Edi.Domain.Shared.Enums
{
    public enum WarehouseShippingReferenceType
    {
        [Display(Name = "WarehouseShippingOrder", Description = "Warehouse Shipping Order", Order = 0)]
        WarehouseShippingOrder = 1,

        [Display(Name = "WarehouseShippingAdvice", Description = "Warehouse Shipping Advice", Order = 1)]
        WarehouseShippingAdvice = 2,
    }
}
