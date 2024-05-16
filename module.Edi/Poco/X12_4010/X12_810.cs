using Scm.Common.Domain.Shared.Enums.Edi;
using Scm.Edi.Dtos.X12_4010.Common;

namespace Edi.Application.Contracts.Poco.X12_4010
{
    /// <summary>
    /// Purchase Order 810
    /// </summary>
    public class X12_810 : X12_Envelope<X12_810_Message>
    {
        public X12_810()
        {
            FunctionalIdentifierCode = FunctionalIdentifierCode.Invoice;
        }
    }
}
