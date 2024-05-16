using Edi.Domain.Shared.Enums;
using Edi.Domain.Shared.Poco.X12_4010.Common;

namespace Edi.Domain.Shared.Poco.X12_4010
{
    /// <summary>
    /// Purchase Order 810
    /// </summary>
    public class X12_810 : X12_Interchange<X12_810_Message>
    {
        public X12_810() {
            FunctionalIdentifierCode = FunctionalIdentifierCode.Invoice;
        }
    }
}
