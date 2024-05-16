using Edi.Domain.Shared.Enums;
using Edi.Domain.Shared.Poco.X12_4010.Common;

namespace Edi.Domain.Shared.Poco.X12_4010
{
    /// <summary>
    /// Request for Routing Instructions 753
    /// </summary>
    public class X12_753 : X12_Interchange<X12_753_Message>
    {
        public X12_753() {
            FunctionalIdentifierCode = FunctionalIdentifierCode.RoutingRequest;
        }
    }
}
