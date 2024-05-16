using indice.Edi.Serialization;

namespace Edi.Domain.Shared.Poco.X12_4010.Common
{
    /// <summary>
    /// X12 Transaction
    /// </summary>
    [EdiMessage]
    public class X12_Transaction
    {
        public ST ST { get; set; }
        public SE SE { get; set; }
        public virtual void UpdateSegmentsCount() { }
    }
}
