using Scm.Common.Domain.Shared.Enums.Edi;
using Scm.Edi.Dtos.X12_4010.Common;

namespace Edi.Application.Contracts.Poco.X12_4010
{
    /// <summary>
    /// Warehouse Shipping Advice 945: Message
    /// </summary>
    public class X12_945 : X12_Envelope<X12_945_Message>
    {
        public X12_945()
        {
            FunctionalIdentifierCode = FunctionalIdentifierCode.WarehouseShippingAdvice;
        }
    }
}
