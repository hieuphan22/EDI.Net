using Scm.Common.Domain.Shared.Enums.Edi;
using Scm.Edi.Dtos.X12_4010.Common;

namespace Edi.Application.Contracts.Poco.X12_4010
{
    /// <summary>
    /// Request for Routing Instructions 753
    /// </summary>
    public class X12_753 : X12_Envelope<X12_753_Message>
    {
        public X12_753()
        {
            FunctionalIdentifierCode = FunctionalIdentifierCode.RoutingRequest;
        }
    }
}
