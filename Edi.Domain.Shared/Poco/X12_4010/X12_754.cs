using Edi.Domain.Shared.Enums;
using Edi.Domain.Shared.Poco.X12_4010.Common;

namespace Edi.Domain.Shared.Poco.X12_4010
{
    /// <summary>
    /// Routing Instructions 754
    /// </summary>
    public class X12_754 : X12_Interchange<X12_754_Message>
    {
        public X12_754() {
            FunctionalIdentifierCode = FunctionalIdentifierCode.RoutingInstructions;
        }
    }
}
