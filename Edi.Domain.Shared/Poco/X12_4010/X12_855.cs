using Edi.Domain.Shared.Poco.X12_4010.Common;

namespace Edi.Domain.Shared.Poco.X12_4010
{
    /// <summary>
    /// Purchase Order Acknowledgment 855
    /// </summary>
    public class X12_855 : X12_Interchange<X12_855_Message>
    {
        public X12_855() {
            FunctionalIdentifierCode = FunctionalIdentifierCode.PurchaseOrderAcknowledgment;
        }
    }
}