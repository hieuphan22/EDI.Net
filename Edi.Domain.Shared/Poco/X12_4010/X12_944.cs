using Edi.Domain.Shared.Enums;
using Edi.Domain.Shared.Poco.X12_4010.Common;

namespace Edi.Domain.Shared.Poco.X12_4010
{
    public class X12_944 : X12_Interchange<X12_944_Message>
    {
        public X12_944() {
            FunctionalIdentifierCode = FunctionalIdentifierCode.WarehouseStockReceiptAdvice;
        }
    }
}
