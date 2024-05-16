using Edi.Domain.Shared.Enums;
using Edi.Domain.Shared.Poco.X12_4010.Common;

namespace Edi.Domain.Shared.Poco.X12_4010
{
    /// <summary>
    /// Warehouse Shipping Advice 945: Message
    /// </summary>
    public class X12_945 : X12_Interchange<X12_945_Message>
    {
        public X12_945() {
            FunctionalIdentifierCode = FunctionalIdentifierCode.WarehouseShippingAdvice;
        }
    }
}
