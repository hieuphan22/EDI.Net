﻿using Scm.Common.Domain.Shared.Enums.Edi;
using Scm.Edi.Dtos.X12_4010.Common;

namespace Edi.Application.Contracts.Poco.X12_4010
{
    public class X12_944 : X12_Envelope<X12_944_Message>
    {
        public X12_944()
        {
            FunctionalIdentifierCode = FunctionalIdentifierCode.WarehouseStockReceiptAdvice;
        }
    }
}