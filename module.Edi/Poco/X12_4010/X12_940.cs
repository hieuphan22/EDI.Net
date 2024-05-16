using Scm.Common.Domain.Shared.Enums.Edi;
using Scm.Edi.Dtos.X12_4010.Common;

namespace Edi.Application.Contracts.Poco.X12_4010
{
    /// <summary>
    /// FileName: X12.940.cs
    /// FileType: Visual C# Source file
    /// Author : Thin Do
    /// Created On : 6/1/2020
    /// Copy Rights : SCS Solutions
    /// Description : Class for defining 940 object
    /// </summary>
    public class X12_940 : X12_Envelope<X12_940_Message>
    {
        public X12_940()
        {
            FunctionalIdentifierCode = FunctionalIdentifierCode.WarehouseShippingOrder;
        }
    }
}
