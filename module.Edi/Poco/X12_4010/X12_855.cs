using Scm.Common.Domain.Shared.Enums.Edi;
using Scm.Edi.Dtos.X12_4010.Common;

namespace Edi.Application.Contracts.Poco.X12_4010
{
    /// <summary>
    /// Purchase Order Acknowledgment 855
    /// </summary>
    public class X12_855 : X12_Envelope<X12_855_Message>
    {
        public X12_855()
        {
            FunctionalIdentifierCode = FunctionalIdentifierCode.PurchaseOrderAcknowledgment;
        }
    }
}