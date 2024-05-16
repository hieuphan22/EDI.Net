using Edi.Domain.Shared.Attributes;
using Edi.Domain.Shared.Enums;
using indice.Edi.Serialization;
using Scm.Edi.Domain.Shared.Attributes;

namespace Edi.Domain.Shared.Poco.X12_4010.Segments
{
    [EdiSegment]
    [EdiPath("SI")]
    public class SI
    {
        [EdiValue("X(2)", Path = "SI/0", Description = "SI01 - Agency Qualifier Code")]
        [EdiExtension(MinLength = 2, MaxLength = 2, Mandatory = true, EdiType = EdiType.Identifier)]
        [EdiAllowValue(AllowedValues = new string[] { "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36", "37", "38", "39", "40", "41", "42", "43", "44", "45", "46", "47", "48", "49", "50", "51", "52", "53", "54", "55", "56", "57", "58", "59", "60", "93", "94", "A1", "A2", "A3", "A4", "AA", "AB", "AC", "AD", "AE", "AG", "AH", "AI", "AJ", "AL", "AM", "AP", "AQ", "AS", "AT", "AW", "AX", "AY", "BE", "BF", "BI", "CA", "CB", "CC", "CE", "CI", "CL", "CM", "CO", "CR", "CS", "CU", "CX", "DA", "DD", "DE", "DF", "DI", "DL", "DN", "DO", "DR", "DS", "DX", "DY", "DZ", "EI", "EP", "ES", "ET", "EU", "EX", "FA", "FC", "FD", "FG", "FH", "FI", "GC", "GS", "GU", "HC", "HI", "HS", "HU", "IA", "IB", "IC", "IM", "IN", "IS", "JA", "LA", "LB", "LI", "MA", "MB", "MC", "ME", "MI", "MP", "MS", "MV", "NA", "NB", "NC", "NE", "NF", "NG", "NI", "NR", "NS", "NT", "NU", "NW", "OI", "OP", "OS", "PA", "PC", "SA", "SE", "SL", "SP", "ST", "TA", "TB", "TC", "TD", "TI", "TM", "TP", "TR", "TX", "UC", "UN", "VI", "WH", "ZZ" })]
        public string AgencyQualifierCode { get; set; }

        [EdiValue("X(2)", Path = "SI/1", Description = "SI02 - Service Characteristics Qualifier")]
        [EdiExtension(MinLength = 2, MaxLength = 2, Mandatory = true, EdiType = EdiType.Alphanumeric)]
        public string ServiceCharacteristicsQualifier { get; set; }

        [EdiValue("X(48)", Path = "SI/2", Description = "SI03 - Product/Service ID")]
        [EdiExtension(MinLength = 1, MaxLength = 48, Mandatory = true, EdiType = EdiType.Alphanumeric)]
        public string ProductOrServiceID { get; set; }

        [EdiValue("X(2)", Path = "SI/3", Description = "SI04 - Service Characteristics Qualifier")]
        [EdiExtension(MinLength = 2, MaxLength = 2, Mandatory = false, EdiType = EdiType.Alphanumeric)]
        public string ServiceCharacteristicsQualifier2 { get; set; }

        [EdiValue("X(48)", Path = "SI/4", Description = "SI05 - Product/Service ID")]
        [EdiExtension(MinLength = 1, MaxLength = 48, Mandatory = false, EdiType = EdiType.Alphanumeric)]
        public string ProductOrServiceID2 { get; set; }

        [EdiValue("X(2)", Path = "SI/5", Description = "SI06 - Service Characteristics Qualifier")]
        [EdiExtension(MinLength = 2, MaxLength = 2, Mandatory = false, EdiType = EdiType.Alphanumeric)]
        public string ServiceCharacteristicsQualifier3 { get; set; }

        [EdiValue("X(48)", Path = "SI/6", Description = "SI07 - Product/Service ID")]
        [EdiExtension(MinLength = 1, MaxLength = 48, Mandatory = false, EdiType = EdiType.Alphanumeric)]
        public string ProductOrServiceID3 { get; set; }

        [EdiValue("X(2)", Path = "SI/7", Description = "SI08 - Service Characteristics Qualifier")]
        [EdiExtension(MinLength = 2, MaxLength = 2, Mandatory = false, EdiType = EdiType.Alphanumeric)]
        public string ServiceCharacteristicsQualifier4 { get; set; }

        [EdiValue("X(48)", Path = "SI/8", Description = "SI09 - Product/Service ID")]
        [EdiExtension(MinLength = 1, MaxLength = 48, Mandatory = false, EdiType = EdiType.Alphanumeric)]
        public string ProductOrServiceID4 { get; set; }

        [EdiValue("X(2)", Path = "SI/9", Description = "SI10 - Service Characteristics Qualifier")]
        [EdiExtension(MinLength = 2, MaxLength = 2, Mandatory = false, EdiType = EdiType.Alphanumeric)]
        public string ServiceCharacteristicsQualifier5 { get; set; }

        [EdiValue("X(48)", Path = "SI/10", Description = "SI11 - Product/Service ID")]
        [EdiExtension(MinLength = 1, MaxLength = 48, Mandatory = false, EdiType = EdiType.Alphanumeric)]
        public string ProductOrServiceID5 { get; set; }

        [EdiValue("X(2)", Path = "SI/11", Description = "SI12 - Service Characteristics Qualifier")]
        [EdiExtension(MinLength = 2, MaxLength = 2, Mandatory = false, EdiType = EdiType.Alphanumeric)]
        public string ServiceCharacteristicsQualifier6 { get; set; }

        [EdiValue("X(48)", Path = "SI/12", Description = "SI13 - Product/Service ID")]
        [EdiExtension(MinLength = 1, MaxLength = 48, Mandatory = false, EdiType = EdiType.Alphanumeric)]
        public string ProductOrServiceID6 { get; set; }

        [EdiValue("X(2)", Path = "SI/13", Description = "SI14 - Service Characteristics Qualifier")]
        [EdiExtension(MinLength = 2, MaxLength = 2, Mandatory = false, EdiType = EdiType.Alphanumeric)]
        public string ServiceCharacteristicsQualifier7 { get; set; }

        [EdiValue("X(48)", Path = "SI/14", Description = "SI15 - Product/Service ID")]
        [EdiExtension(MinLength = 1, MaxLength = 48, Mandatory = false, EdiType = EdiType.Alphanumeric)]
        public string ProductOrServiceID7 { get; set; }

        [EdiValue("X(2)", Path = "SI/15", Description = "SI16 - Service Characteristics Qualifier")]
        [EdiExtension(MinLength = 2, MaxLength = 2, Mandatory = false, EdiType = EdiType.Alphanumeric)]
        public string ServiceCharacteristicsQualifier8 { get; set; }

        [EdiValue("X(48)", Path = "SI/16", Description = "SI17 - Product/Service ID")]
        [EdiExtension(MinLength = 1, MaxLength = 48, Mandatory = false, EdiType = EdiType.Alphanumeric)]
        public string ProductOrServiceID8 { get; set; }

        [EdiValue("X(2)", Path = "SI/17", Description = "SI18 - Service Characteristics Qualifier")]
        [EdiExtension(MinLength = 2, MaxLength = 2, Mandatory = false, EdiType = EdiType.Alphanumeric)]
        public string ServiceCharacteristicsQualifier9 { get; set; }

        [EdiValue("X(48)", Path = "SI/18", Description = "SI19 - Product/Service ID")]
        [EdiExtension(MinLength = 1, MaxLength = 48, Mandatory = false, EdiType = EdiType.Alphanumeric)]
        public string ProductOrServiceID9 { get; set; }

        [EdiValue("X(2)", Path = "SI/19", Description = "SI20 - Service Characteristics Qualifier")]
        [EdiExtension(MinLength = 2, MaxLength = 2, Mandatory = false, EdiType = EdiType.Alphanumeric)]
        public string ServiceCharacteristicsQualifier10 { get; set; }

        [EdiValue("X(48)", Path = "SI/20", Description = "SI21 - Product/Service ID")]
        [EdiExtension(MinLength = 1, MaxLength = 48, Mandatory = false, EdiType = EdiType.Alphanumeric)]
        public string ProductOrServiceID10 { get; set; }
    }
}
