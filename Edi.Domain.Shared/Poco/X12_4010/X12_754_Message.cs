using System.Collections.Generic;
using Edi.Domain.Shared.Attributes;
using Edi.Domain.Shared.Enums;
using Edi.Domain.Shared.Poco.X12_4010.Common;
using Edi.Domain.Shared.Poco.X12_4010.Segments;
using Edi.Domain.Shared.Ultilities;
using indice.Edi.Serialization;
using Scm.Edi.Domain.Shared.Attributes;

namespace Edi.Domain.Shared.Poco.X12_4010
{
    /// <summary>
    /// Routing Instructions 754
    /// </summary>
    [EdiMessage]
    public class X12_754_Message : X12_Transaction
    {
        [EdiValue("X(2)", Path = "BGN/0", Description = "BGN01 - Transaction Set Purpose Code")]
        [EdiExtension(MinLength = 2, MaxLength = 2, Mandatory = true, EdiType = EdiType.Identifier)]
        public string TransactionSetPurposeCode { get; set; }

        [EdiValue("X(50)", Path = "BGN/1", Description = "BGN02 - Reference Identification")]
        [EdiExtension(MinLength = 1, MaxLength = 50, Mandatory = true, EdiType = EdiType.Alphanumeric)]
        public string ReferenceIdentification { get; set; }

        [EdiValue("X(8)", Path = "BGN/2", Format = "yyyyMMdd", Description = "BGN03 - Date")]
        [EdiExtension(MinLength = 8, MaxLength = 8, Mandatory = true, EdiType = EdiType.Date)]
        public string Date { get; set; }

        [EdiValue("X(4)", Path = "BGN/3", Format = "HHmm", Description = "BGN04 - Time")]
        [EdiExtension(MinLength = 8, MaxLength = 4, EdiType = EdiType.Time)]
        public string Time { get; set; }

        [EdiValue("X(2)", Path = "BGN/4", Description = "BGN05 - Time Code")]
        [EdiExtension(MinLength = 2, MaxLength = 2, Mandatory = false, EdiType = EdiType.Identifier)]
        public string TimeCode { get; set; }

        [EdiValue("X(50)", Path = "BGN/5", Description = "BGN06 - Reference Identification")]
        [EdiExtension(MinLength = 1, MaxLength = 50, Mandatory = false, EdiType = EdiType.Alphanumeric)]
        public string ReferenceIdentification02 { get; set; }

        [EdiValue("X(2)", Path = "BGN/6", Description = "BGN07 - Transaction Type Code")]
        [EdiExtension(MinLength = 2, MaxLength = 2, Mandatory = false, EdiType = EdiType.Identifier)]
        public string TransactionTypeCode { get; set; }

        [EdiValue("X(2)", Path = "BGN/7", Description = "BGN08 - Action Code")]
        [EdiExtension(MinLength = 1, MaxLength = 2, Mandatory = false, EdiType = EdiType.Identifier)]
        public string ActionCode { get; set; }

        [EdiValue("X(2)", Path = "BGN/8", Description = "BGN09 - Security Level Code")]
        [EdiExtension(MinLength = 2, MaxLength = 2, Mandatory = false, EdiType = EdiType.Identifier)]
        public string SecurityLevelCode { get; set; }

        public PER PER { get; set; }

        public List<N1Group> N1Groups { get; set; }

        public List<RoutingDetail> Items { get; set; }

        [EdiSegment]
        [EdiSegmentGroup("N1", "N2", "N3", "N4")]
        public class N1Group : N1
        {
            public N2 N2 { get; set; }

            public N3 N3 { get; set; }

            public N4 N4 { get; set; }
        }

        [EdiSegment]
        [EdiSegmentGroup("IT1", SequenceEnd = "TDS")]
        public class RoutingDetail : LX
        {
            public L11 L11 { get; set; }

            public BLR BLR { get; set; }

            public OID OID { get; set; }

            public G62 G62 { get; set; }

            public MSI MSI { get; set; }

            public List<QTY> QTYGroups { get; set; }

            public List<N1Group> N1Groups { get; set; }
        }
        public void UpdateSegmentsCount() {
            var count = CountSegmentUtility.CountSegments(GetType(), this) + 1;
            SE.SegmentsCount = count.ToString();
        }
        public string TransactionSegmentsCount { get; set; }
        public string TrailerTransactionSetControlNumber { get; set; }
    }
}
