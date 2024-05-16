using System.Collections.Generic;
using Edi.Application.Contracts.Poco.X12_4010.Segments;
using Edi.Domain.Shared.Enums;
using indice.Edi.Serialization;
using Scm.Edi.Domain.Shared.Attributes;
using Scm.Edi.Dtos.X12_4010.Common;

namespace Edi.Application.Contracts.Poco.X12_4010
{
    /// <summary>
    /// Request for Routing Instructions 753
    /// </summary>
    [EdiMessage]
    public class X12_753_Message : X12_Transaction
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
        [EdiExtension(MinLength = 4, MaxLength = 4, EdiType = EdiType.Time)]
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
        [EdiSegmentGroup("N1", "N2", "N3", "N4", "L11", "G62", "USI", "OID", "CMC")]
        public class USIGroup : N1
        {
            public N2 N2 { get; set; }

            public N3 N3 { get; set; }

            public N4 N4 { get; set; }

            public L11 L11 { get; set; }

            public G62 G62 { get; set; }

            public USI USI { get; set; }

            public List<OIDGroup> ShipmentItems { get; set; }
        }

        [EdiSegment]
        [EdiSegmentGroup("OID", "CMC")]
        public class OIDGroup : OID
        {
            public CMC CMC { get; set; }
        }

        [EdiSegment]
        [EdiSegmentGroup("IT1", SequenceEnd = "TDS")]
        public class RoutingDetail : LX
        {
            public List<USIGroup> USIGroups { get; set; }
        }
    }
}