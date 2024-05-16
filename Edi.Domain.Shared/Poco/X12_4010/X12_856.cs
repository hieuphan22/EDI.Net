using Edi.Domain.Shared.Enums;
using Edi.Domain.Shared.Poco.X12_4010.Common;

namespace Edi.Domain.Shared.Poco.X12_4010
{
    public class X12_856 : X12_Interchange<X12_856_Message>
    {
        public X12_856() {
            FunctionalIdentifierCode = FunctionalIdentifierCode.AdvancedShippingNotice;
        }
    }
}
