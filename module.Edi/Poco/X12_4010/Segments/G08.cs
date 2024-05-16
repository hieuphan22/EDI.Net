using Edi.Domain.Shared.Enums;
using indice.Edi.Serialization;
using Scm.Edi.Domain.Shared.Attributes;

namespace Edi.Application.Contracts.Poco.X12_4010.Segments
{
    /// <summary>
    /// Contract Segment
    /// </summary>
    [EdiSegment]
    [EdiPath("G08")]
    public class G08
    {
        [EdiValue("X(3)", Path = "G08/0", Description = "G0801 - Quantity of Pallets Received")]
        [EdiExtension(MinLength = 1, MaxLength = 3, Mandatory = false, EdiType = EdiType.Numeric)]
        public string QuantityOfPalletsReceived { get; set; }

        [EdiValue("X(3)", Path = "G08/1", Description = "G0802 - Quantity of Pallets Returned")]
        [EdiExtension(MinLength = 1, MaxLength = 3, Mandatory = false, EdiType = EdiType.Numeric)]
        public string QuantityOfPalletsReturned { get; set; }

        [EdiValue("X(7)", Path = "G08/2", Format = "R", Description = "G0803 - Quantity Contested")]
        [EdiExtension(MinLength = 1, MaxLength = 7, Mandatory = false, EdiType = EdiType.Decimal)]
        public string QuantityContested { get; set; }

        [EdiValue("X(2)", Path = "G08/3", Description = "G0804 - Receiving Condition Code")]
        [EdiExtension(MinLength = 2, MaxLength = 2, EdiType = EdiType.Identifier)]
        public string ReceivingConditionCode { get; set; }
    }
}
