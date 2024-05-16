using module.Edi.Poco.X12_4010.Common;

namespace module.Edi.Poco.X12_4010
{
    /// <summary>
    /// EDI 850 Basic
    /// </summary>
    public class X12_850_Default : X12_Interchange<X12_850_Message>
    {
        public X12_850_Default() {
            //FunctionalIdentifierCode = FunctionalIdentifierCode.PurchaseOrder;
        }
    }
}
