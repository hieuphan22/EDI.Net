namespace module.Edi.Poco.X12_4010.Common
{
    /// <summary>
    /// X12 Envelope
    /// </summary>
    public class X12_Interchange<T> where T : class
    {
        public ISA ISA { get; set; }

        public X12_FunctionGroup<T> FunctionGroup { get; set; }

        public IEA IEA { get; set; }
    }

    /// <summary>
    /// X12 Envelope
    /// </summary>
    public class X12_Interchange : X12_Interchange<X12_Transaction>
    {
    }
}
