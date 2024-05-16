using System.Collections.Generic;
using Edi.Application.Contracts.Poco.X12_4010.Common;
using indice.Edi.Serialization;

namespace Edi.Application.Contracts.Poco.X12_4010
{
    /// <summary>
    /// X12 Envelope
    /// </summary>
    public class X12Envelope : ISA
    {
        public X12FunctionGroup FunctionGroup { get; set; }

        public IEA IEA { get; set; }
    }

    [EdiGroup]
    public class X12FunctionGroup : GS
    {
        public List<X12Transaction> Transactions { get; set; }

        public GE GE { get; set; }
    }

    [EdiMessage]
    public class X12Transaction : ST
    {
        public SE SE { get; set; }
    }
}
