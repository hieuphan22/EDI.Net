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
    /// Inventory Inquiry 846: Message
    /// </summary>
    [EdiMessage]
    public class X12_846_Message : X12_Transaction
    {
        [EdiValue("X(2)", Path = "BIA/0", Description = "BIA01 - Transaction Set Purpose Code")]
        [EdiExtension(MinLength = 2, MaxLength = 2, Mandatory = true, EdiType = EdiType.Identifier)]
        public string TransactionSetPurposeCode { get; set; }

        [EdiValue("X(2)", Path = "BIA/1", Description = "BIA02 - Report Type Code")]
        [EdiExtension(MinLength = 2, MaxLength = 2, Mandatory = true, EdiType = EdiType.Identifier)]
        public string ReportTypeCode { get; set; }

        [EdiValue("X(50)", Path = "BIA/2", Description = "BIA03 - Reference Identification")]
        [EdiExtension(MinLength = 1, MaxLength = 50, Mandatory = true, EdiType = EdiType.Alphanumeric)]
        public string ReferenceIdentification { get; set; }

        [EdiValue("X(8)", Path = "BIA/3", Format = "yyyyMMdd", Description = "BIA04 - Date")]
        [EdiExtension(MinLength = 8, MaxLength = 8, Mandatory = true, EdiType = EdiType.Date)]
        public string Date { get; set; }

        [EdiValue("X(4)", Path = "BIA/4", Format = "HHmm", Description = "BIA05 - Time")]
        [EdiExtension(MinLength = 4, MaxLength = 4, Mandatory = false, EdiType = EdiType.Time)]
        public string Time { get; set; }
        [EdiValue("X(2)", Path = "BIA/5", Description = "BIA06 - Action Code")]
        [EdiExtension(MinLength = 1, MaxLength = 2, Mandatory = false, EdiType = EdiType.Identifier)]
        public string ActionCode { get; set; }
        public CUR CUR { get; set; }
        public DTM DTM { get; set; }
        public REF REF { get; set; }
        public PER PER { get; set; }
        public MEA MEA { get; set; }
        public List<N1Group> N1Groups { get; set; }
        public List<LMGroup> LMGroups { get; set; }
        public List<InventoryDetail> InventoryDetails { get; set; }
        public CTP CTP { get; set; }
        public CTT CTT { get; set; }
        [EdiSegment]
        [EdiSegmentGroup("LIN", SequenceEnd = "CTT")]
        public class InventoryDetail : LIN
        {
            public PID PID { get; set; }
            public MEA MEA { get; set; }
            public PKG PKG { get; set; }
            public DTM DTM { get; set; }
            public CTP CTP { get; set; }
            public CUR CUR { get; set; }
            public SAC SAC { get; set; }
            public REF REF { get; set; }
            public PER PER { get; set; }
            public SDQ SDQ { get; set; }
            public MAN MAN { get; set; }
            public UIT UIT { get; set; }
            public CS CS { get; set; }
            public DD DD { get; set; }
            public G53 G53 { get; set; }
            public PCT PCT { get; set; }
            public LDT LDT { get; set; }
            public List<LMGroup> LMGroups { get; set; }
            public List<SLNGroup> SLNGroups { get; set; }
            public List<QTYGroup> QTYGroups { get; set; }
            public List<N1Group> N1Groups { get; set; }
        }

        [EdiSegment]
        [EdiSegmentGroup("N1", "N2", "N3", "N4", "REF", "PER")]
        public class N1Group : N1
        {
            public N2 N2 { get; set; }

            public N3 N3 { get; set; }

            public N4 N4 { get; set; }

            public REF REF { get; set; }

            public PER PER { get; set; }
        }

        [EdiSegment]
        [EdiSegmentGroup("LM", "LQ")]
        public class LMGroup : LM
        {
            public LQ LQ { get; set; }
        }

        [EdiSegment]
        [EdiSegmentGroup("SLN", "PID", "MEA", "PKG", "MAN", "MEA")]
        public class SLNGroup : SLN
        {
            public PID PID { get; set; }
            public MEA MEA { get; set; }
            public PKG PKG { get; set; }
            public List<MANGroup> MANGroups { get; set; }
        }

        [EdiSegment]
        [EdiSegmentGroup("MAN", "MEA")]
        public class MANGroup : MAN
        {
            public MEA MEA { get; set; }
        }

        [EdiSegment]
        [EdiSegmentGroup("QTY", "UIT", "MEA", "LDT", "DTM", "SCH", "LM", "LQ", "LS", "REF", "N1", "LE")]
        public class QTYGroup : QTY
        {
            public UIT UIT { get; set; }
            public MEA MEA { get; set; }
            public LDT LDT { get; set; }
            public DTM DTM { get; set; }
            public List<SCHGroup> SCHGroups { get; set; }
            public List<LMGroup> LMGroups { get; set; }
            public List<REFGroup> REFGroups { get; set; }
        }

        [EdiSegment]
        [EdiSegmentGroup("SCH", "MEA")]
        public class SCHGroup : SCH
        {
            public MEA MEA { get; set; }
        }

        [EdiSegment]
        [EdiSegmentGroup("REF", "DTM", "N1", "LM", "LQ")]
        public class REFGroup : REF
        {
            public DTM DTM { get; set; }
            public N1 N1 { get; set; }
            public List<LMGroup> LMGroups { get; set; }
        }

        public void UpdateSegmentsCount() {
            var count = CountSegmentUtility.CountSegments(GetType(), this) + 1;
            SE.SegmentsCount = count.ToString();
        }
        public string TransactionSegmentsCount { get; set; }
        public string TrailerTransactionSetControlNumber { get; set; }
    }
}