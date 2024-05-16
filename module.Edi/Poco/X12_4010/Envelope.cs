using System.Collections.Generic;
using Edi.Application.Contracts.Poco.X12_4010.Common;
using indice.Edi.Serialization;

namespace Edi.Application.Contracts.Poco.X12_4010
{
    /// <summary>
    /// X12 Envelope
    /// </summary>
    public class Envelope
    {
        public ISA ISA { get; set; }

        public IEA IEA { get; set; }

        public List<FunctionGroup> Groups { get; set; }

        [EdiGroup]
        public class FunctionGroup
        {
            public GS GS { get; set; }

            public GE GE { get; set; }
        }
    }
}
