using Edi.Domain.Shared.Enums;
using Edi.Domain.Shared.Poco.X12_4010.Common;

namespace Edi.Domain.Shared.Poco.X12_4010
{
    public class X12_943 : X12_Interchange<X12_943_Message>
    {
        public X12_943() {
            FunctionalIdentifierCode = FunctionalIdentifierCode.WarehouseStockTransferShipmentAdvice;
        }
    }
}
