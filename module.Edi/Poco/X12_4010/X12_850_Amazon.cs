﻿using System.Collections.Generic;
using Edi.Application.Contracts.Poco.X12_4010.Common;
using Edi.Application.Contracts.Poco.X12_4010.Segments;
using Edi.Domain.Shared.Enums;
using indice.Edi.Serialization;
using Scm.Edi.Domain.Shared.Attributes;

namespace Edi.Application.Contracts.Poco.X12_4010
{
    /// <summary>
    /// Purchase Order 850 for Amazon
    /// </summary>
    public class X12_850_Amazon
    {
        public ISA ISA { get; set; }

        public List<FunctionalGroup> Groups { get; set; }

        public IEA IEA { get; set; }

        [EdiGroup]
        public class FunctionalGroup
        {
            public GS GS { get; set; }

            public List<Order> Transactions { get; set; }

            public GE GE { get; set; }
        }

        [EdiMessage]
        public class Order
        {
            public ST ST { get; set; }

            #region BEG
            [EdiValue("X(2)", Path = "BEG/0", Description = "BEG01 - Transation Set Purpose Code")]
            [EdiExtension(MinLength = 2, MaxLength = 2, Mandatory = true, EdiType = EdiType.Identifier)]
            public string TransSetPurposeCode { get; set; }

            [EdiValue("X(2)", Path = "BEG/1", Description = "BEG02 - Purchase Order Type Code")]
            [EdiExtension(MinLength = 2, MaxLength = 2, Mandatory = true, EdiType = EdiType.Identifier)]
            public string PurchaseOrderTypeCode { get; set; }

            [EdiValue("X(22)", Path = "BEG/2", Description = "BEG03 - Purchase Order Number")]
            [EdiExtension(MinLength = 1, MaxLength = 22, Mandatory = true, EdiType = EdiType.Alphanumeric)]
            public string PurchaseOrderNumber { get; set; }

            [EdiValue("X(30)", Path = "BEG/3", Description = "BEG04 - Release Number")]
            [EdiExtension(MinLength = 1, MaxLength = 30, Mandatory = false, EdiType = EdiType.Alphanumeric)]
            public string ReleaseNumber { get; set; }

            [EdiValue("X(8)", Path = "BEG/4", Format = "yyyyMMdd", Description = "BEG05 - Date")]
            [EdiExtension(MinLength = 8, MaxLength = 8, Mandatory = true, EdiType = EdiType.Date)]
            public string PurchaseOrderDate { get; set; }
            #endregion

            public List<REF> REFGroups { get; set; }

            public FOB FOB { get; set; }

            public CSH CSH { get; set; }

            public List<SAC> SACGroups { get; set; }

            public ITD ITD { get; set; }

            public List<DTM> DTMGroups { get; set; }

            public PKG PKG { get; set; }

            public List<N9Group> N9Groups { get; set; }

            public List<N1> N1Groups { get; set; }

            public List<PurchaseOrderDetail> Items { get; set; }

            public List<CTT> CTTGroups { get; set; }

            public SE SE { get; set; }
        }

        [EdiSegment, EdiSegmentGroup("PO1", SequenceEnd = "CTT")]
        public class PurchaseOrderDetail
        {
            [EdiValue("X(20)", Path = "PO1/0", Description = "PO101 - Assigned Identification")]
            [EdiExtension(MinLength = 1, MaxLength = 20, Mandatory = true, EdiType = EdiType.Alphanumeric)]
            public string AssignedIdentification { get; set; }

            [EdiValue("X(15)", Path = "PO1/1", Format = "R", Description = "PO102 - Quantity Ordered")]
            [EdiExtension(MinLength = 1, MaxLength = 15, Mandatory = true, EdiType = EdiType.Decimal)]
            public string QuantityOrdered { get; set; }

            [EdiValue("X(2)", Path = "PO1/2", Description = "PO103 - Unit Of Measurement Code")]
            [EdiExtension(MinLength = 2, MaxLength = 2, Mandatory = true, EdiType = EdiType.Identifier)]
            public string UnitOfMeasurement { get; set; }

            [EdiValue("X(17)", Path = "PO1/3", Format = "R", Description = "PO104 - Unit Price")]
            [EdiExtension(MinLength = 1, MaxLength = 17, Mandatory = true, EdiType = EdiType.Decimal)]
            public string UnitPrice { get; set; }

            [EdiValue("X(2)", Path = "PO1/4", Description = "PO105 - Basis of Unit Price Code")]
            [EdiExtension(MinLength = 2, MaxLength = 2, Mandatory = true, EdiType = EdiType.Identifier)]
            public string BasisOfUnitPriceCode { get; set; }

            [EdiValue("X(2)", Path = "PO1/5", Description = "PO106 - Product/Service ID Qualifier")]
            [EdiExtension(MinLength = 2, MaxLength = 2, Mandatory = true, EdiType = EdiType.Identifier)]
            public string ProductServiceIDQualifier { get; set; }

            [EdiValue("X(48)", Path = "PO1/6", Description = "PO107 - Product/Service ID")]
            [EdiExtension(MinLength = 1, MaxLength = 48, Mandatory = true, EdiType = EdiType.Alphanumeric)]
            public string ProductServiceID { get; set; }

            public IT8 IT8 { get; set; }
        }

        [EdiSegment, EdiSegmentGroup("N9", "MSG")]
        public class N9Group : N9
        {
            public MSG MSG { get; set; }
        }
    }
}
