using Edi.Domain.Shared.Enums;
using indice.Edi.Serialization;
using Scm.Edi.Domain.Shared.Attributes;

namespace Edi.Application.Contracts.Poco.X12_4010.Segments
{
    /// <summary>
    /// Contract Segment
    /// </summary>
    [EdiSegment]
    [EdiPath("W14")]
    public class W14
    {
        [EdiValue("X(7)", Path = "W14/0", Description = "W1401 - Quantity Received")]
        [EdiExtension(MinLength = 1, MaxLength = 7, Mandatory = true, EdiType = EdiType.Alphanumeric)]
        public string QuantityReceived { get; set; }

        [EdiValue("X(10)", Path = "W14/1", Format = "R", Description = "W1402 - Number of Units Shipped")]
        [EdiExtension(MinLength = 1, MaxLength = 10, Mandatory = false, EdiType = EdiType.Decimal)]
        public string NumberOfUnitsShipped { get; set; }

        [EdiValue("X(9)", Path = "W14/2", Format = "R", Description = "W1403 - Quantity Damaged/On Hold")]
        [EdiExtension(MinLength = 1, MaxLength = 9, Mandatory = false, EdiType = EdiType.Decimal)]
        public string QuantityDamagedOrOnHold { get; set; }

        [EdiValue("X(7)", Path = "W14/3", Description = "W1404 - Lading Quantity Received")]
        [EdiExtension(MinLength = 1, MaxLength = 7, Mandatory = false, EdiType = EdiType.Numeric)]
        public string LadingQuantityReceived { get; set; }

        [EdiValue("X(7)", Path = "W14/4", Description = "W1405 - Lading Quantity")]
        [EdiExtension(MinLength = 1, MaxLength = 7, Mandatory = false, EdiType = EdiType.Numeric)]
        public string LadingQuantity { get; set; }
    }
}
