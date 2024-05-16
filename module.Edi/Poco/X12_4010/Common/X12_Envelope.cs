using module.Edi.Poco.X12_4010.Common;

namespace Scm.Edi.Dtos.X12_4010.Common
{
    /// <summary>
    /// X12 Envelope
    /// </summary>
    public class X12_Envelope<T> : ISA
        where T : class
    {
        public X12_FunctionGroup<T> FunctionGroup { get; set; }

        public IEA IEA { get; set; }
    }

    /// <summary>
    /// X12 Envelope
    /// </summary>
    public class X12_Envelope
        : X12_Envelope<X12_Transaction>
    {
    }
}
