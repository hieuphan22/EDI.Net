using Edi.Domain.Shared.Attributes;
using Edi.Domain.Shared.Enums;
using indice.Edi.Serialization;
using Scm.Edi.Domain.Shared.Attributes;

namespace Edi.Domain.Shared.Poco.X12_4010.Segments
{
    [EdiSegment]
    [EdiPath("ETD")]
    public class ETD
    {
        [EdiValue("X(2)", Path = "ETD/0", Description = "ETD01 - Excess Transportation Reason Code")]
        [EdiExtension(MinLength = 1, MaxLength = 2, Mandatory = true, EdiType = EdiType.Identifier)]
        public string ExcessTransportationReasonCode { get; set; }

        [EdiValue("X(1)", Path = "ETD/1", Description = "ETD02 - Excess Transportation Responsibility Code")]
        [EdiExtension(MinLength = 1, MaxLength = 1, Mandatory = true, EdiType = EdiType.Identifier)]
        public string ExcessTransportationResponsibilityCode { get; set; }

        [EdiValue("X(3)", Path = "ETD/2", Description = "ETD03 - Reference Identification Qualifier")]
        [EdiExtension(MinLength = 2, MaxLength = 3, Mandatory = false, EdiType = EdiType.Identifier)]
        public string ReferenceIdentificationQualifier { get; set; }

        [EdiValue("X(30)", Path = "ETD/3", Description = "ETD04 - Reference Identification")]
        [EdiExtension(MinLength = 1, MaxLength = 30, Mandatory = false, EdiType = EdiType.Alphanumeric)]
        public string ReferenceIdentification { get; set; }

        [EdiValue("X(2)", Path = "ETD/4", Description = "ETD05 - Returnable Container Freight Payment Responsibility Code")]
        [EdiExtension(MinLength = 1, MaxLength = 2, Mandatory = false, EdiType = EdiType.Identifier)]
        public string ReturnableContainerFreightPaymentResponsibilityCode { get; set; }
    }
}