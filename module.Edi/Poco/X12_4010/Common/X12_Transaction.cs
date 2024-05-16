using indice.Edi.Serialization;
using module.Edi.Poco.X12_4010.Common;

namespace Scm.Edi.Dtos.X12_4010.Common
{
    /// <summary>
    /// X12 Transaction
    /// </summary>
    [EdiMessage]
    public class X12_Transaction : ST
    {
        public SE SE { get; set; }
        public virtual void UpdateSegmentsCount() { }
    }
}
