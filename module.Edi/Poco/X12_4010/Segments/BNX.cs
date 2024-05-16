using Edi.Domain.Shared.Enums;
using indice.Edi.Serialization;
using Scm.Edi.Domain.Shared.Attributes;

namespace Edi.Application.Contracts.Poco.X12_4010.Segments
{
    public class BNX
    {
        [EdiValue("X(1)", Path = "BNX/0", Description = "BNX01 - Shipment Weight Code")]
        [EdiExtension(MinLength = 1, MaxLength = 1, Mandatory = false, EdiType = EdiType.Identifier)]
        public string ShipmentWeightCode { get; set; }

        [EdiValue("X(13)", Path = "BNX/1", Description = "BNX02 - Referenced Pattern Identifier")]
        [EdiExtension(MinLength = 1, MaxLength = 13, Mandatory = false, EdiType = EdiType.Alphanumeric)]
        public string ReferencedPatternIdentifier { get; set; }

        [EdiValue("X(5)", Format = "N0", Path = "BNX/2", Description = "BNX03 - Weight Capacity")]
        [EdiExtension(MinLength = 5, MaxLength = 5, Mandatory = false, EdiType = EdiType.Numeric)]
        public string WeightCapacity { get; set; }
    }
}
