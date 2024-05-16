using Scm.Common.Domain.Shared.Enums.Edi;
using Scm.Edi.Dtos.X12_4010.Common;

namespace Edi.Application.Contracts.Poco.X12_4010
{
    public class X12_943 : X12_Envelope<X12_943_Message>
    {
        public X12_943()
        {
            FunctionalIdentifierCode = FunctionalIdentifierCode.WarehouseStockTransferShipmentAdvice;
        }
    }
}
