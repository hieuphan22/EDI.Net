using indice.Edi.Serialization;

namespace module.Edi.Poco.X12_4010.Common
{
    /// <summary>
    /// X12 Function Group
    /// </summary>
    /// <typeparam name="T"></typeparam>
    [EdiGroup]
    public class X12_FunctionGroup<T> where T : class
    {
        public GS GS { get; set; }

        public List<T> Transactions { get; set; }

        public GE GE { get; set; }
    }

    /// <summary>
    /// X12 Function Group
    /// </summary>
    [EdiGroup]
    public class X12_FunctionGroup : X12_FunctionGroup<X12_Transaction>
    {
    }
}
