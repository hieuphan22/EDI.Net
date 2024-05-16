using Edi.Domain.Shared.Enums;

namespace Edi.Domain.Shared.Attributes
{
    public static class AllFunctionals
    {
        public static FunctionalIdentifierCode[] All {
            get {
                return new[]
                {
                    FunctionalIdentifierCode.PurchaseOrder,
                    FunctionalIdentifierCode.Invoice,
                    FunctionalIdentifierCode.PurchaseOrderAcknowledgment,
                };
            }
        }
    }
}
