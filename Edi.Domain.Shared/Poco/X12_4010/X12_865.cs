using Edi.Domain.Shared.Enums;
using Edi.Domain.Shared.Poco.X12_4010.Common;

namespace Edi.Domain.Shared.Poco.X12_4010
{
    /// <summary>
    /// Purchase Order Change Acknowledgment 865
    /// </summary>
    public class X12_865 : X12_Interchange<X12_865_Message>
    {
        public X12_865() {
            FunctionalIdentifierCode = FunctionalIdentifierCode.PurchaseOrderChangeRequestAcknowledgment;
        }
    }
}
