using Edi.Domain.Shared.Enums;
using indice.Edi.Serialization;
using Scm.Edi.Domain.Shared.Attributes;

namespace Edi.Application.Contracts.Poco.X12_4010.Segments
{
    [EdiSegment, EdiPath("NX2")]
    public class NX2
    {
        [EdiValue("X(2)", Path = "NX2/0", Description = "NX201 - Address Component Qualifier")]
        [EdiExtension(MinLength = 2, MaxLength = 2, Mandatory = true, EdiType = EdiType.Identifier)]
        [EdiAllowValue(AllowedValues = new string[] { "01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36", "37", "38", "39", "40", "41", "51", "52", "53", "54", "56", "57", "58", "59", "60", "61", "62", "63", "64", "65", "66", "67", "68", "69", "71", "74", "79", "80", "90", "91", "92", "93", "94", "96", "97" })]
        public string AddressComponentQualifier { get; set; }

        [EdiValue("X(55)", Path = "NX2/1", Description = "NX202 - Address Information")]
        [EdiExtension(MinLength = 1, MaxLength = 55, Mandatory = true, EdiType = EdiType.Alphanumeric)]
        public string AddressInformation { get; set; }

        [EdiValue("X(5)", Path = "NX2/2", Description = "NX203 - County Designator")]
        [EdiExtension(MinLength = 5, MaxLength = 5, Mandatory = false, EdiType = EdiType.Identifier)]
        public string CountyDesignator { get; set; }
    }
}
