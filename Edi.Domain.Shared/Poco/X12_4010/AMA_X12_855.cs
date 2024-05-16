using System.Collections.Generic;
using Edi.Application.Contracts.Poco.X12_4010.Common;
using Edi.Domain.Shared.Attributes;
using Edi.Domain.Shared.Enums;
using Edi.Domain.Shared.Poco.X12_4010.Common;
using Edi.Domain.Shared.Poco.X12_4010.Segments;
using Edi.Domain.Shared.Ultilities;
using Edi.Domain.Shared.Validation;
using Edi.Domain.Shared.Validation.X12_4010._855.Amazon;
using FluentValidation.Results;
using indice.Edi.Serialization;
using Scm.Edi.Domain.Shared.Attributes;

namespace Edi.Domain.Shared.Poco.X12_4010
{
    /// <summary>
    /// Purchase Order Acknowledgment 855 for Amazon
    /// </summary>
    public class AMA_X12_855 : X12_Interchange<Order_AMA_855>
    {
        public AMA_X12_855() {
            FunctionalIdentifierCode = FunctionalIdentifierCode.PurchaseOrderAcknowledgment;
        }
    }

    [EdiMessage]
    public class Order_AMA_855 : X12_Transaction
    {
        #region BAK
        [EdiValue("X(2)", Path = "BAK/0", Description = "BAK01 - Transaction Set Purpose Code")]
        [EdiExtension(MinLength = 2, MaxLength = 2, Mandatory = true, EdiType = EdiType.Identifier)]
        public string TransactionSetPurposeCode { get; set; }

        [EdiValue("X(2)", Path = "BAK/1", Description = "BAK02 - Acknowledgment Type")]
        [EdiExtension(MinLength = 2, MaxLength = 2, Mandatory = true, EdiType = EdiType.Identifier)]
        public string AcknowledgmentType { get; set; }

        [EdiValue("X(22)", Path = "BAK/2", Description = "BAK03 - Purchase Order Number")]
        [EdiExtension(MinLength = 1, MaxLength = 22, Mandatory = true, EdiType = EdiType.Alphanumeric)]
        public string PurchaseOrderNumber { get; set; }

        [EdiValue("X(8)", Path = "BAK/3", Format = "yyyyMMdd", Description = "BAK04 - Date")]
        [EdiExtension(MinLength = 8, MaxLength = 8, Mandatory = true, EdiType = EdiType.Date)]
        public string Date { get; set; }

        [EdiValue("X(30)", Path = "BAK/7", Description = "BAK08 - Reference Identification")]
        [EdiExtension(MinLength = 1, MaxLength = 30, Mandatory = false, EdiType = EdiType.Alphanumeric)]
        public string ReferenceIdentification { get; set; }
        #endregion

        public List<N1> N1Groups { get; set; }

        public List<OrderDetail> Items { get; set; }

        public List<CTT> CTTGroups { get; set; }

        [EdiSegment]
        [EdiSegmentGroup("PO1", SequenceEnd = "CTT")]
        public class OrderDetail : IEdiValidation<OrderDetail>
        {
            #region PO1
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
            #endregion

            public CTP CTP { get; set; }

            public List<ACKGroup> ACKGroups { get; set; }

            public List<ValidationResult> ValidateEdi(OrderDetail model) {
                var results = new List<ValidationResult>();
                var validationRules = new Amazon855OrderDetailValidation();
                results.Add(validationRules.Validate(model));
                return results;
            }
        }

        [EdiSegment]
        [EdiSegmentGroup("ACK", "DTM")]
        public class ACKGroup : ACK
        {
            public DTM DTM { get; set; }
        }

        public void UpdateSegmentsCount() {
            var count = CountSegmentUtility.CountSegments(GetType(), this) + 1;
            SE.SegmentsCount = count.ToString();
        }
    }
}
