using Scm.Common.Domain.Shared.Enums.Edi;
using Scm.Edi.Dtos.X12_4010.Common;

namespace Edi.Application.Contracts.Poco.X12_4010
{
    /// <summary>
    /// Purchase Order Change Acknowledgment 865
    /// </summary>
    public class X12_865 : X12_Envelope<X12_865_Message>
    {
        public X12_865()
        {
            FunctionalIdentifierCode = FunctionalIdentifierCode.PurchaseOrderChangeRequestAcknowledgment;
        }
    }
}
