﻿using System.Collections.Generic;
using Edi.Application.Contracts.Poco.X12_4010.Segments;
using Edi.Domain.Shared.Enums;
using Edi.Domain.Shared.Ultilities;
using indice.Edi.Serialization;
using Scm.Edi.Domain.Shared.Attributes;
using Scm.Edi.Dtos.X12_4010.Common;

namespace Edi.Application.Contracts.Poco.X12_4010
{
    /// <summary>
    /// Purchase Order Change Request 860: Message
    /// </summary>
    [EdiMessage]
    public class X12_860_Message : X12_Transaction
    {
        #region BCH
        [EdiValue("X(2)", Path = "BCH/0", Description = "BCH01 - Transaction Set Purpose Code")]
        [EdiExtension(MinLength = 2, MaxLength = 2, Mandatory = true, EdiType = EdiType.Identifier)]
        public string TransactionSetPurposeCode { get; set; }

        [EdiValue("X(2)", Path = "BCH/1", Description = "BCH02 - Purchase Order Type Code")]
        [EdiExtension(MinLength = 2, MaxLength = 2, Mandatory = true, EdiType = EdiType.Identifier)]
        public string PurchaseOrderTypeCode { get; set; }

        [EdiValue("X(22)", Path = "BCH/2", Description = "BCH03 - Purchase Order Number")]
        [EdiExtension(MinLength = 1, MaxLength = 22, Mandatory = true, EdiType = EdiType.Alphanumeric)]
        public string PurchaseOrderNumber { get; set; }

        [EdiValue("X(30)", Path = "BCH/3", Description = "BCH04 - Release Number")]
        [EdiExtension(MinLength = 1, MaxLength = 30, Mandatory = false, EdiType = EdiType.Alphanumeric)]
        public string ReleaseNumber { get; set; }

        [EdiValue("X(8)", Path = "BCH/4", Description = "BCH05 - Change Order Sequence Number")]
        [EdiExtension(MinLength = 1, MaxLength = 8, Mandatory = false, EdiType = EdiType.Alphanumeric)]
        public string ChangeOrderSequenceNumber { get; set; }

        [EdiValue("X(8)", Path = "BCH/5", Format = "yyyyMMdd", Description = "BCH06 - Date")]
        [EdiExtension(MinLength = 8, MaxLength = 8, Mandatory = true, EdiType = EdiType.Date)]
        public string Date { get; set; }

        [EdiValue("X(45)", Path = "BCH/6", Description = "BCH07 - Request Reference Number")]
        [EdiExtension(MinLength = 1, MaxLength = 45, Mandatory = false, EdiType = EdiType.Alphanumeric)]
        public string RequestReferenceNumber { get; set; }

        [EdiValue("X(30)", Path = "BCH/7", Description = "BCH08 - Contract Number")]
        [EdiExtension(MinLength = 1, MaxLength = 30, Mandatory = false, EdiType = EdiType.Alphanumeric)]
        public string ContractNumber { get; set; }

        [EdiValue("X(30)", Path = "BCH/8", Description = "BCH09 - Reference Identification")]
        [EdiExtension(MinLength = 1, MaxLength = 30, Mandatory = false, EdiType = EdiType.Alphanumeric)]
        public string ReferenceIdentification { get; set; }

        [EdiValue("X(8)", Path = "BCH/9", Format = "yyyyMMdd", Description = "BCH10 - Date")]
        [EdiExtension(MinLength = 8, MaxLength = 8, Mandatory = false, EdiType = EdiType.Date)]
        public string Date2 { get; set; }

        [EdiValue("X(8)", Path = "BCH/10", Format = "yyyyMMdd", Description = "BCH11 - Date")]
        [EdiExtension(MinLength = 8, MaxLength = 8, Mandatory = false, EdiType = EdiType.Date)]
        public string Date3 { get; set; }
        #endregion

        public CUR CUR { get; set; }

        public REF REF { get; set; }

        public FOB FOB { get; set; }

        public CSH CSH { get; set; }

        public List<SACGroup> SACGroups { get; set; }

        public ITD ITD { get; set; }

        public List<DTM> DTMGroups { get; set; }

        public PID PID { get; set; }

        public TD5 TD5 { get; set; }

        public List<N9Group> N9Groups { get; set; }

        public List<N1Group> N1Groups { get; set; }

        public List<OrderDetail> Items { get; set; }

        public List<CTTGroup> CTTGroups { get; set; }

        [EdiSegment]
        [EdiSegmentGroup("POC", SequenceEnd = "CTT")]
        public class OrderDetail : POC
        {
            /*
            #region POC
            [EdiValue("X(20)", Path = "POC/0", Description = "POC01 - Assigned Identification")]
            [EdiExtension(MinLength = 1, MaxLength = 20, Mandatory = true, EdiType = EdiType.Alphanumeric)]
            public string AssignedIdentification { get; set; }

            [EdiValue("X(2)", Path = "POC/1", Description = "POC02 - Change or Response Type Code")]
            [EdiExtension(MinLength = 2, MaxLength = 2, Mandatory = true, EdiType = EdiType.Identifier)]
            public string ChangeOrResponseTypeCode { get; set; }

            [EdiValue("X(15)", Path = "POC/2", Format = "R", Description = "POC03 - Quantity Ordered")]
            [EdiExtension(MinLength = 1, MaxLength = 15, Mandatory = true, EdiType = EdiType.Decimal)]
            public string QuantityOrdered { get; set; }

            [EdiValue("X(9)", Path = "POC/3", Format = "R", Description = "POC04 - Quantity Left to Receive")]
            [EdiExtension(MinLength = 1, MaxLength = 9, Mandatory = false, EdiType = EdiType.Decimal)]
            public string QuantityLeftToReceive { get; set; }

            [EdiValue("X(2)", Path = "POC/4", Description = "POC05 - Unit or Basis for Measurement Code")]
            [EdiExtension(MinLength = 2, MaxLength = 2, Mandatory = true, EdiType = EdiType.Identifier)]
            public string UnitOfMeasurement { get; set; }

            [EdiValue("X(17)", Path = "POC/5", Format = "R", Description = "POC06 - Unit Price")]
            [EdiExtension(MinLength = 1, MaxLength = 17, Mandatory = false, EdiType = EdiType.Decimal)]
            public string UnitPrice { get; set; }

            [EdiValue("X(2)", Path = "POC/6", Description = "POC07 - Basis of Unit Price Code")]
            [EdiExtension(MinLength = 2, MaxLength = 2, Mandatory = false, EdiType = EdiType.Identifier)]
            public string BasisOfUnitPriceCode { get; set; }

            [EdiValue("X(2)", Path = "POC/7", Description = "POC08 - Product/Service ID Qualifier")]
            [EdiExtension(MinLength = 2, MaxLength = 2, Mandatory = false, EdiType = EdiType.Identifier)]
            public string ProductServiceIDQualifier { get; set; }

            [EdiValue("X(48)", Path = "POC/8", Description = "POC09 - Product/Service ID")]
            [EdiExtension(MinLength = 1, MaxLength = 48, Mandatory = false, EdiType = EdiType.Alphanumeric)]
            public string ProductServiceID { get; set; }

            [EdiValue("X(2)", Path = "POC/9", Description = "POC10 - Product/Service ID Qualifier")]
            [EdiExtension(MinLength = 2, MaxLength = 2, Mandatory = false, EdiType = EdiType.Identifier)]
            public string ProductServiceIDQualifier2 { get; set; }

            [EdiValue("X(48)", Path = "POC/10", Description = "POC11 - Product/Service ID")]
            [EdiExtension(MinLength = 1, MaxLength = 48, Mandatory = false, EdiType = EdiType.Alphanumeric)]
            public string ProductServiceID2 { get; set; }

            [EdiValue("X(2)", Path = "POC/11", Description = "POC12 - Product/Service ID Qualifier")]
            [EdiExtension(MinLength = 2, MaxLength = 2, Mandatory = false, EdiType = EdiType.Identifier)]
            public string ProductServiceIDQualifier3 { get; set; }

            [EdiValue("X(48)", Path = "POC/12", Description = "POC13 - Product/Service ID")]
            [EdiExtension(MinLength = 1, MaxLength = 48, Mandatory = false, EdiType = EdiType.Alphanumeric)]
            public string ProductServiceID3 { get; set; }

            [EdiValue("X(2)", Path = "POC/13", Description = "POC14 - Product/Service ID Qualifier")]
            [EdiExtension(MinLength = 2, MaxLength = 2, Mandatory = false, EdiType = EdiType.Identifier)]
            public string ProductServiceIDQualifier4 { get; set; }

            [EdiValue("X(48)", Path = "POC/14", Description = "POC15 - Product/Service ID")]
            [EdiExtension(MinLength = 1, MaxLength = 48, Mandatory = false, EdiType = EdiType.Alphanumeric)]
            public string ProductServiceID4 { get; set; }

            [EdiValue("X(2)", Path = "POC/15", Description = "POC16 - Product/Service ID Qualifier")]
            [EdiExtension(MinLength = 2, MaxLength = 2, Mandatory = false, EdiType = EdiType.Identifier)]
            public string ProductServiceIDQualifier5 { get; set; }

            [EdiValue("X(48)", Path = "POC/16", Description = "POC17 - Product/Service ID")]
            [EdiExtension(MinLength = 1, MaxLength = 48, Mandatory = false, EdiType = EdiType.Alphanumeric)]
            public string ProductServiceID5 { get; set; }
            #endregion
            */

            public LIN LIN { get; set; }

            public CTP CTP { get; set; }

            public PO4 PO4 { get; set; }

            public List<SACGroup> SACGroups { get; set; }

            public DTM DTM { get; set; }

            public List<QTYGroup> QTYGroups { get; set; }

            public List<SCHGroup> SCHGroups { get; set; }

            public List<N9Group> N9Groups { get; set; }

            public List<LDTGroup> LDTGroups { get; set; }
        }

        [EdiSegment]
        [EdiSegmentGroup("SAC", "CUR")]
        public class SACGroup : SAC
        {
            public CUR CUR { get; set; }
        }

        [EdiSegment]
        [EdiSegmentGroup("N9", "DTM", "MSG")]
        public class N9Group : N9
        {
            public DTM DTM { get; set; }

            public MSG MSG { get; set; }
        }

        [EdiSegment]
        [EdiSegmentGroup("N1", "N2", "N3", "N4", "NX2", "REF", "PER", "SI", "FOB", "TD1", "TD5", "TD3", "TD4", "PKG")]
        public class N1Group : N1
        {
            public N2 N2 { get; set; }

            public N3 N3 { get; set; }

            public N4 N4 { get; set; }

            public NX2 NX2 { get; set; }

            public REF REF { get; set; }

            public PER PER { get; set; }

            public SI SI { get; set; }

            public FOB FOB { get; set; }

            public TD1 TD1 { get; set; }

            public TD5 TD5 { get; set; }

            public TD3 TD3 { get; set; }

            public TD4 TD4 { get; set; }

            public PKG PKG { get; set; }
        }

        [EdiSegment]
        [EdiSegmentGroup("CTT", "AMT")]
        public class CTTGroup : CTT
        {
            public AMT AMT { get; set; }
        }

        [EdiSegment]
        [EdiSegmentGroup("QTY", "SI")]
        public class QTYGroup : QTY
        {
            public SI SI { get; set; }
        }

        [EdiSegment]
        [EdiSegmentGroup("SCH", "TD1", "TD5", "TD3", "TD4")]
        public class SCHGroup : SCH
        {
            public TD1 TD1 { get; set; }

            public TD5 TD5 { get; set; }

            public TD3 TD3 { get; set; }

            public TD4 TD4 { get; set; }
        }

        [EdiSegment]
        [EdiSegmentGroup("LDT", "QTY", "MSG", "REF", "LM", "LQ")]
        public class LDTGroup : LDT
        {
            public QTY QTY { get; set; }

            public MSG MSG { get; set; }

            public REF REF { get; set; }

            public List<LMGroup> LMGroups { get; set; }
        }

        [EdiSegment]
        [EdiSegmentGroup("LM", "LQ")]
        public class LMGroup : LM
        {
            public LQ LQ { get; set; }
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