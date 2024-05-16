using System.Collections.Generic;
using Edi.Application.Contracts.Poco.X12_4010.Common;
using Edi.Domain.Shared.Attributes;
using Edi.Domain.Shared.Enums;
using Edi.Domain.Shared.Poco.X12_4010.Segments;
using Edi.Domain.Shared.Validation;
using Edi.Translator.Validation.X12_4010._850;
using FluentValidation.Results;
using indice.Edi.Serialization;
using Scm.Edi.Domain.Shared.Attributes;

namespace Edi.Domain.Shared.Poco.X12_4010
{
    /// <summary>
    /// Purchase Order 850
    /// </summary>
    public class Base_X12_850 : IEdiValidation<Base_X12_850>
    {
        #region ISA and IEA
        public ISA ISA { get; set; }

        public IEA IEA { get; set; }

        #endregion

        public List<FunctionalGroup> Groups { get; set; }

        public List<ValidationResult> ValidateEdi(Base_X12_850 model) {
            var results = new List<ValidationResult>();
            var validationRules = new Base850Validation();
            results.Add(validationRules.Validate(model));
            return results;
        }

        [EdiGroup]
        public class FunctionalGroup : IEdiValidation<FunctionalGroup>
        {
            public GS GS { get; set; }

            public List<Order> Orders { get; set; }

            public GE GE { get; set; }

            public List<ValidationResult> ValidateEdi(FunctionalGroup model) {
                var results = new List<ValidationResult>();
                var validationRules = new FunctionalGroupValidation();
                results.Add(validationRules.Validate(model));
                return results;
            }
        }

        [EdiMessage]
        public class Order : IEdiValidation<Order>
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

            [EdiValue("X(30)", Path = "BEG/5", Format = "yyyyMMdd", Description = "BEG06 - Contract Number")]
            [EdiExtension(MinLength = 1, MaxLength = 30, Mandatory = false, EdiType = EdiType.Alphanumeric)]
            public string ContractNumber { get; set; }
            #endregion

            public List<REF> REFGroups { get; set; }

            public FOB FOB { get; set; }

            public CSH CSH { get; set; }

            public List<SACGroup> SACGroups { get; set; }

            public ITD ITD { get; set; }

            public List<DTM> DTMGroups { get; set; }

            public PKG PKG { get; set; }

            public List<N9Group> N9Groups { get; set; }

            public List<N1Group> N1Groups { get; set; }

            public List<OrderDetail> Items { get; set; }

            public List<CTTGroup> CTTGroups { get; set; }

            public SE SE { get; set; }

            public List<ValidationResult> ValidateEdi(Order model) {
                var results = new List<ValidationResult>();
                var validationRules = new OrderValidation();
                results.Add(validationRules.Validate(model));
                return results;
            }
        }

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

            public List<CTPGroup> CTPGroups { get; set; }

            public List<PIDGroup> PIDGroups { get; set; }

            public List<SACGroup> SACGroups { get; set; }

            public IT8 IT8 { get; set; }

            public List<ValidationResult> ValidateEdi(OrderDetail model) {
                var results = new List<ValidationResult>();
                var validationRules = new OrderDetailValidation();
                results.Add(validationRules.Validate(model));
                return results;
            }
        }

        #region Define Segment

        #region N1 Group
        [EdiSegment]
        [EdiSegmentGroup("N1", "N2", "N3", "N4", "REF", "PER", "SI", "FOB", "TD1", "TD5", "TD3", "TD4", "PKG")]
        public class N1Group : N1
        {
            public N2 N2 { get; set; }

            public N3 N3 { get; set; }

            public N4 N4 { get; set; }

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
        #endregion

        [EdiSegment]
        [EdiSegmentGroup("SAC", "CUR", "CTP")]
        public class SACGroup : SAC
        {
            public CUR CUR { get; set; }

            public CTP CTP { get; set; }
        }

        [EdiSegment]
        [EdiSegmentGroup("CTT", "AMT")]
        public class CTTGroup : CTT
        {
            public AMT AMT { get; set; }
        }

        [EdiSegment]
        [EdiSegmentGroup("CTP", "CUR")]
        public class CTPGroup : CTP
        {
            public CUR CUR { get; set; }
        }

        [EdiSegment]
        [EdiSegmentGroup("PID", "MEA")]
        public class PIDGroup : PID
        {
            public MEA MEA { get; set; }
        }

        [EdiSegment]
        [EdiSegmentGroup("N9", "MSG")]
        public class N9Group : N9
        {
            public MSG MSG { get; set; }
        }
        #endregion

    }
}
