using Scm.Common.Domain.Shared.Enums.Edi;
using Scm.Edi.Dtos.X12_4010.Common;

namespace Edi.Application.Contracts.Poco.X12_4010
{
    /// <summary>
    /// Routing Instructions 754
    /// </summary>
    public class X12_754 : X12_Envelope<X12_754_Message>
    {
        public X12_754()
        {
            FunctionalIdentifierCode = FunctionalIdentifierCode.RoutingInstructions;
        }
    }
}
