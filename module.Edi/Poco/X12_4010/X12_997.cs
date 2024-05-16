using Scm.Common.Domain.Shared.Enums.Edi;
using Scm.Edi.Dtos.X12_4010.Common;

namespace Edi.Application.Contracts.Poco.X12_4010
{
    /// <summary>
    /// Purchase Order Change Request 860
    /// </summary>
    public class X12_997 : X12_Envelope<X12_997_Message>
    {
        public X12_997()
        {
            FunctionalIdentifierCode = FunctionalIdentifierCode.FunctionalAcknowledgment;
        }
    }
}
