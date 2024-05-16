using System.Collections.Generic;
using Edi.Application.Contracts.Poco.X12_4010.Segments;
using Edi.Domain.Shared.Enums;
using Edi.Domain.Shared.Ultilities;
using indice.Edi.Serialization;
using Scm.Edi.Domain.Shared.Attributes;
using Scm.Edi.Dtos.X12_4010.Common;

namespace Edi.Application.Contracts.Poco.X12_4010
{
    /// <summary>
    /// Advance Shipment Notification 856: Message
    /// </summary>
    [EdiMessage]
    public class X12_856_Message : X12_Transaction
    {
        [EdiValue(Path = "BSN/0", Description = "BSN01 - Transaction Set Purpose Code")]
        [EdiExtension(MinLength = 2, MaxLength = 2, Mandatory = true, EdiType = EdiType.Identifier)]
        public string TransactionSetPurposeCode { get; set; }

        [EdiValue(Path = "BSN/1", Description = "BSN02 - Shipment Identification")]
        [EdiExtension(MinLength = 2, MaxLength = 30, Mandatory = true, EdiType = EdiType.Alphanumeric)]
        public string ShipmentIdentification { get; set; }

        [EdiValue(Path = "BSN/2", Format = "yyyyMMdd", Description = "BSN03 - Date")]
        [EdiExtension(MinLength = 8, MaxLength = 8, Mandatory = true, EdiType = EdiType.Date)]
        public string Date { get; set; }

        [EdiValue(Path = "BSN/3", Format = "hhmmss", Description = "BSN04 - Time")]
        [EdiExtension(MinLength = 4, MaxLength = 8, Mandatory = true, EdiType = EdiType.Time)]
        public string Time { get; set; }

        [EdiValue(Path = "BSN/4", Description = "BSN05 - Hierarchical Structure Code")]
        [EdiExtension(MinLength = 4, MaxLength = 4, Mandatory = false, EdiType = EdiType.Identifier)]
        public string HierarchicalStructureCode { get; set; }

        [EdiValue(Path = "BSN/5", Description = "BSN06 - Transaction Type Code")]
        [EdiExtension(MinLength = 2, MaxLength = 2, Mandatory = false, EdiType = EdiType.Identifier)]
        public string TransactionTypeCode { get; set; }

        [EdiValue(Path = "BSN/6", Description = "BSN07 - Status Reason Code")]
        [EdiExtension(MinLength = 3, MaxLength = 3, Mandatory = false, EdiType = EdiType.Identifier)]
        public string StatusReasonCode { get; set; }

        public List<DTM> DTMs { get; set; }

        public List<ShipNoticeDetail> Items { get; set; }

        public CTT CTT { get; set; }

        [EdiSegment]
        [EdiSegmentGroup("HL", SequenceEnd = "CTT")]
        public class ShipNoticeDetail : HL
        {
            public LIN LIN { get; set; }

            public SN1 SN1 { get; set; }

            public List<SLN> SLNs { get; set; }

            public PRF PRF { get; set; }

            public PO4 PO4 { get; set; }

            public List<PID> PIDs { get; set; }

            public List<MEA> MEAs { get; set; }

            public List<PKG> PKGs { get; set; }

            public List<TD1> TD1s { get; set; }

            public List<TD5> TD5s { get; set; }

            public List<TD3> TD3s { get; set; }

            public List<TD4> TD4s { get; set; }

            public TSD TSD { get; set; }

            public List<REF> REFs { get; set; }

            public List<DTM> DTMs { get; set; }

            public FOB FOB { get; set; }

            public PAL PAL { get; set; }

            public List<N1Group> N1Groups { get; set; }

            public List<V1Groups> V1Groups { get; set; }

            public List<PWK> PWKs { get; set; }

            public PER PER { get; set; }

            public List<LH1Group> LH1Groups { get; set; }

            public List<CLDGroup> CLDGroups { get; set; }

            public MAN MAN { get; set; }

            public List<SDQ> SDQs { get; set; }

            public ETD ETD { get; set; }

            public CUR CUR { get; set; }

            public List<SACGroup> SACGroups { get; set; }

            public GF GF { get; set; }

            public List<YNQ> YNQs { get; set; }

            public List<LMGroup> LMGroups { get; set; }
        }

        [EdiSegment]
        [EdiSegmentGroup("N1", "N2", "N3", "N4", "REF", "PER", "FOB")]
        public class N1Group : N1
        {
            public List<N2> N2s { get; set; }

            public List<N3> N3s { get; set; }

            public N4 N4 { get; set; }

            public List<REF> REFs { get; set; }

            public List<PER> PERs { get; set; }

            public FOB FOB { get; set; }
        }

        [EdiSegment]
        [EdiSegmentGroup("V1", "R4", "DTM")]
        public class V1Groups : V1
        {
            public R4 R4 { get; set; }

            public DTM DTM { get; set; }
        }

        [EdiSegment]
        [EdiSegmentGroup("LH1", SequenceEnd = "LHE")]
        public class LH1Group : LH1
        {
            public List<LH2> LH2s { get; set; }

            public List<LH3> LH3s { get; set; }

            public List<LFH> LFHs { get; set; }

            public LEP LEP { get; set; }

            public LH4 LH4 { get; set; }

            public List<LHT> LHTs { get; set; }

            public List<LHR> LHRs { get; set; }

            public List<PER> PERs { get; set; }

            public LHE LHE { get; set; }
        }

        [EdiSegment]
        [EdiSegmentGroup("CLD", "REF", "DTP")]
        public class CLDGroup : CLD
        {
            public List<REF> REFs { get; set; }

            public DTP DTP { get; set; }
        }

        [EdiSegment]
        [EdiSegmentGroup("SAC", "CUR")]
        public class SACGroup : SAC
        {
            public CUR CUR { get; set; }
        }

        [EdiSegment]
        [EdiSegmentGroup("LM", "LQ")]
        public class LMGroup : LM
        {
            public List<LQ> LQs { get; set; }
        }

        public void UpdateSegmentsCount()
        {
            var count = CountSegmentUtility.CountSegments(GetType(), this) + 1;
            SE.SegmentsCount = count.ToString();
        }
        public string TransactionSegmentsCount { get; set; }
        public string TrailerTransactionSetControlNumber { get; set; }
    }
}