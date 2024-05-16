using Edi.Domain.Shared.Poco.X12_4010.Common;
using Edi.Domain.Shared.Poco.X12_4010.Segments;
using indice.Edi.Serialization;

namespace Edi.Domain.Shared.Poco.X12_4010
{
    /// <summary>
    /// EDI 850 Basic
    /// </summary>
    //public class X12_850 : X12_Envelope<X12_850_Message>
    //{
    //    public X12_850()
    //    {
    //        FunctionalIdentifierCode = FunctionalIdentifierCode.PurchaseOrder;
    //    }
    //}

    [EdiMessage]
    public class X12_850_Message : X12_Transaction
    {
        public BEG BEG { get; set; }
        public CUR CUR { get; set; }
        public REF REF { get; set; }
        public FOB FOB { get; set; }
        public ITD ITD { get; set; }
        public TD5 TD5 { get; set; }
        public MSG MSG { get; set; }

        public List<Address> Addresses { get; set; }

        public List<OrderDetail> Items { get; set; }

        [EdiValue(Path = "AMT/1", Description = "AMT02 - Total amount of the Purchase Order")]
        public string TotalTransactionAmount { get; set; }

    }

    [EdiSegment, EdiSegmentGroup("PO1", SequenceEnd = "CTT")]
    public class OrderDetail
    {
        [EdiValue(Path = "PO1/0", Description = "PO101 - Order Line Number")]
        public string OrderLineNumber { get; set; }

        [EdiValue(Path = "PO1/1", Description = "PO102 - Quantity Ordered")]
        public decimal QuantityOrdered { get; set; }

        [EdiValue(Path = "PO1/2", Description = "PO103 - Unit Of Measurement")]
        public string UnitOfMeasurement { get; set; }

        [EdiValue(Path = "PO1/3", Description = "PO104 - Unit Price")]
        public decimal UnitPrice { get; set; }

        [EdiValue(Path = "PO1/8", Description = "PO109 - Buyer’s Part #.")]
        public string BuyersPartno { get; set; }

        [EdiValue(Path = "PO1/10", Description = "PO111 - Vendor’s Part #.")]
        public string VendorsPartno { get; set; }

        [EdiValue(Path = "PID/4", Description = "PID05 - Product Description")]
        public string ProductDescription { get; set; }

        [EdiValue(Path = "MEA/2", Description = "MEA03 - Measurement Value")]
        public decimal MeasurementValue { get; set; }

        [EdiCondition("018", Path = "DTM/0/0")]
        public DTM AvailableFromDate { get; set; }

        [EdiCondition("067", Path = "DTM/0/0")]
        public DTM ArrivalDate { get; set; }

        [EdiCondition("002", Path = "DTM/0/0")]
        public DTM DeliveryRequestedDate { get; set; }

        [EdiCondition("038", Path = "DTM/0/0")]
        public DTM ShipNoLaterDate { get; set; }

        [EdiValue(Path = "TC2/0", Description = "TC201 - Measurement Value")]
        public string TC201 { get; set; }

        public List<MSG> MSG { get; set; }

    }

    [EdiSegment, EdiSegmentGroup("N1", SequenceEnd = "PO1")]
    public class Address
    {

        [EdiValue(Path = "N1/0", Description = "N101 - Address Code")]
        public string AddressCode { get; set; }

        [EdiValue(Path = "N1/1", Description = "N102 - Address Name")]
        public string AddressName { get; set; }

        [EdiValue(Path = "N3/0", Description = "N301 - Address Information")]
        public string AddressInformation { get; set; }

        [EdiValue(Path = "N4/0", Description = "N401 - City Name")]
        public string CityName { get; set; }

        [EdiValue(Path = "N4/3", Description = "N404 - Country Code")]
        public string CountryCode { get; set; }

    }

    [EdiSegment, EdiPath("DTM")]
    public class DTM
    {

        [EdiValue(Path = "DTM/0", Description = "DTM01 - Date/Time Qualifier")]
        public string DateTimeQualifier { get; set; }

        [EdiValue("9(8)", Path = "DTM/1", Format = "yyyyMMdd", Description = "DTM02 - Date format =CCYYMMDD")]
        public DateTime Date { get; set; }
    }

    [EdiSegment, EdiPath("MSG")]
    public class MSG
    {

        [EdiValue(Path = "MSG/0", Description = "MSG01 - Message Text")]
        public string MessageText { get; set; }
    }

    #region Edi Enumerations
    #endregion

}
