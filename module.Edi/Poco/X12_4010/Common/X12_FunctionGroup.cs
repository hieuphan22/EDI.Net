using System.Collections.Generic;
using Edi.Application.Contracts.Poco.X12_4010.Common;
using indice.Edi.Serialization;

namespace Scm.Edi.Dtos.X12_4010.Common
{
    /// <summary>
    /// X12 Function Group
    /// </summary>
    /// <typeparam name="T"></typeparam>
    [EdiGroup]
    public class X12_FunctionGroup<T> : GS
        where T : class
    {
        public List<T> Transactions { get; set; }

        public GE GE { get; set; }
    }

    /// <summary>
    /// X12 Function Group
    /// </summary>
    [EdiGroup]
    public class X12_FunctionGroup
        : X12_FunctionGroup<X12_Transaction>
    {
    }
}
