using indice.Edi.Serialization;

namespace module.Edi.Poco.X12_4010.Common
{
    [EdiSegment]
    [EdiPath("ST")]
    public class ST
    {
        [EdiValue("X(3)", Path = "ST/0", Description = "ST01 - Transaction set ID code")]
        public string TransactionSetCode { get; set; }

        [EdiValue("X(9)", Path = "ST/1", Description = "ST02 - Transaction set control number")]
        public string TransactionSetControlNumber { get; set; }
    }
}
