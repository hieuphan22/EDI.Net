using Edi.Domain.Shared.Attributes;
using Edi.Domain.Shared.Enums;
using indice.Edi.Serialization;

namespace Edi.Domain.Shared.Poco.X12_4010.Segments
{
    [EdiSegment]
    [EdiPath("N4")]
    public class N4
    {
        [EdiValue("X(30)", Path = "N4/0", Description = "N401 - City Name")]
        [EdiExtension(MinLength = 2, MaxLength = 30, Mandatory = true, EdiType = EdiType.Alphanumeric)]
        public string CityName { get; set; }

        [EdiValue("X(2)", Path = "N4/1", Description = "N402 - State or Province Code")]
        [EdiExtension(MinLength = 2, MaxLength = 2, Mandatory = true, EdiType = EdiType.Identifier)]
        [EdiAllowValue(AllowedValues = new string[] { "AA", "AE", "AK", "AL", "AP", "AR", "AS", "AZ", "CA", "CO", "CT", "DC", "DE", "FL", "FM", "GA", "GU", "HI", "IA", "ID", "IL", "IN", "KS", "KY", "LA", "MA", "MD", "ME", "MH", "MI", "MN", "MO", "MS", "MT", "NC", "ND", "NE", "NH", "NJ", "NM", "NV", "NY", "OH", "OK", "OR", "PA", "PR", "PW", "RI", "SC", "SD", "TN", "TX", "UT", "VA", "VI", "VT", "WA", "WI", "WV", "WY", "QC", "AG", "BL", "BK", "BG", "BN", "BT", "BD", "BÄ", "BP", "BTH", "CM", "CB", "CT", "ÄN", "ÄNO", "ÄB", "ÄNA", "ÄT", "GL", "HG", "HAUG", "HNA", "HN", "HT", "HD", "HP", "HB", "HY", "HCM", "KH", "KG", "KT", "LC", "LS", "LCA", "LÄ", "LA", "NÄ", "NA", "NB", "NT", "PT", "PY", "QB", "QN", "QNG", "QNI", "QT", "ST", "SL", "TN", "TB", "TNG", "TH", "TTH", "TV", "TQ", "VT", "VP", "YB" })]

        public string StateOrProvinceCode { get; set; }

        [EdiValue("X(15)", Path = "N4/2", Description = "N403 - Postal Code")]
        [EdiExtension(MinLength = 3, MaxLength = 15, Mandatory = true, EdiType = EdiType.Identifier)]
        public string PostalCode { get; set; }

        [EdiValue("X(3)", Path = "N4/3", Description = "N404 - Country Code")]
        [EdiExtension(MinLength = 2, MaxLength = 3, Mandatory = false, EdiType = EdiType.Identifier)]
        [EdiAllowValue(AllowedValues = new string[] { "US", "CA", "VN" })]

        public string CountryCode { get; set; }

        [EdiValue("X(2)", Path = "N4/4", Description = "N405 - Location Qualifier")]
        [EdiExtension(MinLength = 1, MaxLength = 2, Mandatory = false, EdiType = EdiType.Identifier)]
        [EdiAllowValue(AllowedValues = new string[] { "A", "B", "C", "D", "E", "F", "H", "I", "K", "L", "M", "O", "P", "W", "10", "11", "12", "13", "14", "18", "19", "20", "21", "22", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36", "38", "39", "40", "41", "42", "43", "44", "45", "46", "47", "48", "49", "50", "52", "53", "54", "55", "57", "58", "59", "60", "93", "94", "A1", "AA", "AC", "AP", "AR", "B1", "BE", "BL", "BS", "C2", "CA", "CB", "CC", "CD", "CE", "CI", "CL", "CO", "CR", "CS", "CY", "DC", "DE", "DL", "DO", "DP", "DR", "DT", "EA", "EL", "FA", "FE", "FF", "FI", "FR", "FS", "FT", "FV", "GL", "IA", "IB", "IM", "IP", "IS", "IT", "KE", "KL", "KP", "LO", "MI", "MS", "MZ", "NS", "OA", "OF", "OL", "OP", "OR", "OV", "PA", "PB", "PC", "PD", "PE", "PF", "PG", "PH", "PL", "PO", "PP", "PQ", "PR", "PS", "PT", "PU", "RA", "RC", "RE", "RG", "RJ", "RL", "RS", "RT", "SA", "SB", "SC", "SD", "SE", "SG", "SH", "SL", "SN", "SP", "SS", "ST", "SW", "TA", "TC", "TL", "TM", "TN", "TP", "TR", "TX", "UN", "UR", "UT", "VA", "VI", "VS", "WF", "WH", "WI", "ZN", "ZZ" })]
        public string LocationQualifier { get; set; }

        [EdiValue("X(30)", Path = "N4/5", Description = "N406 - Location Identifier")]
        [EdiExtension(MinLength = 1, MaxLength = 30, Mandatory = false, EdiType = EdiType.Alphanumeric)]
        public string LocationIdentifier { get; set; }

        [EdiValue("X(3)", Path = "N4/6", Description = "N407 - Country Subdivision Code")]
        [EdiExtension(MinLength = 3, MaxLength = 3, Mandatory = false, EdiType = EdiType.Identifier)]
        public string CountrySubdivisionCode { get; set; }
    }
}
