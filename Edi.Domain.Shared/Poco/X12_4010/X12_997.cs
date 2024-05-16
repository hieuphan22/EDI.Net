using Edi.Domain.Shared.Enums;
using Edi.Domain.Shared.Poco.X12_4010.Common;

namespace Edi.Domain.Shared.Poco.X12_4010
{
    /// <summary>
    /// Purchase Order Change Request 860
    /// </summary>
    public class X12_997 : X12_Interchange<X12_997_Message>
    {
        public X12_997() {
            FunctionalIdentifierCode = FunctionalIdentifierCode.FunctionalAcknowledgment;
        }
    }
}
