using Edi.Domain.Shared.Enums;
using indice.Edi.Serialization;
using Scm.Edi.Domain.Shared.Attributes;

namespace Edi.Application.Contracts.Poco.X12_4010.Segments
{
    [EdiSegment]
    [EdiPath("TAX")]
    public class TAX
    {
        [EdiValue("X(20)", Path = "TAX/0", Description = "TAX01 - Tax Identification Number")]
        [EdiExtension(MinLength = 1, MaxLength = 20, EdiType = EdiType.Alphanumeric)]
        public string TaxIdentificationNumber { get; set; }

        [EdiValue("X(2)", Path = "TAX/1", Description = "TAX02 - Location Qualifier")]
        [EdiExtension(MinLength = 1, MaxLength = 2, EdiType = EdiType.Identifier)]
        [EdiAllowValue(AllowedValues = new string[] { "A", "B", "C", "D", "E", "F", "H", "I", "K", "L", "M", "O", "P", "W", "10", "11", "12", "13", "14", "18", "19", "20", "21", "22", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36", "38", "39", "40", "41", "42", "43", "44", "45", "46", "47", "48", "49", "50", "52", "53", "54", "55", "57", "58", "59", "60", "93", "94", "A1", "AA", "AC", "AP", "AR", "B1", "BE", "BL", "BS", "C2", "CA", "CB", "CC", "CD", "CE", "CI", "CL", "CO", "CR", "CS", "CY", "DC", "DE", "DL", "DO", "DP", "DR", "DT", "EA", "EL", "FA", "FE", "FF", "FI", "FR", "FS", "FT", "FV", "GL", "IA", "IB", "IM", "IP", "IS", "IT", "KE", "KL", "KP", "LO", "MI", "MS", "MZ", "NS", "OA", "OF", "OL", "OP", "OR", "OV", "PA", "PB", "PC", "PD", "PE", "PF", "PG", "PH", "PL", "PO", "PP", "PQ", "PR", "PS", "PT", "PU", "RA", "RC", "RE", "RG", "RJ", "RL", "RS", "RT", "SA", "SB", "SC", "SD", "SE", "SG", "SH", "SL", "SN", "SP", "SS", "ST", "SW", "TA", "TC", "TL", "TM", "TN", "TP", "TR", "TX", "UN", "UR", "UT", "VA", "VI", "VS", "WF", "WH", "WI", "ZN", "ZZ" })]
        public string LocationQualifier { get; set; }

        [EdiValue("X(30)", Path = "TAX/2", Description = "TAX03 - Location Identifier")]
        [EdiExtension(MinLength = 1, MaxLength = 30, EdiType = EdiType.Alphanumeric)]
        public string LocationIdentifier { get; set; }

        [EdiValue("X(2)", Path = "TAX/3", Description = "TAX04 - Location Qualifier")]
        [EdiExtension(MinLength = 1, MaxLength = 2, EdiType = EdiType.Identifier)]
        [EdiAllowValue(AllowedValues = new string[] { "A", "B", "C", "D", "E", "F", "H", "I", "K", "L", "M", "O", "P", "W", "10", "11", "12", "13", "14", "18", "19", "20", "21", "22", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36", "38", "39", "40", "41", "42", "43", "44", "45", "46", "47", "48", "49", "50", "52", "53", "54", "55", "57", "58", "59", "60", "93", "94", "A1", "AA", "AC", "AP", "AR", "B1", "BE", "BL", "BS", "C2", "CA", "CB", "CC", "CD", "CE", "CI", "CL", "CO", "CR", "CS", "CY", "DC", "DE", "DL", "DO", "DP", "DR", "DT", "EA", "EL", "FA", "FE", "FF", "FI", "FR", "FS", "FT", "FV", "GL", "IA", "IB", "IM", "IP", "IS", "IT", "KE", "KL", "KP", "LO", "MI", "MS", "MZ", "NS", "OA", "OF", "OL", "OP", "OR", "OV", "PA", "PB", "PC", "PD", "PE", "PF", "PG", "PH", "PL", "PO", "PP", "PQ", "PR", "PS", "PT", "PU", "RA", "RC", "RE", "RG", "RJ", "RL", "RS", "RT", "SA", "SB", "SC", "SD", "SE", "SG", "SH", "SL", "SN", "SP", "SS", "ST", "SW", "TA", "TC", "TL", "TM", "TN", "TP", "TR", "TX", "UN", "UR", "UT", "VA", "VI", "VS", "WF", "WH", "WI", "ZN", "ZZ" })]
        public string LocationQualifier02 { get; set; }

        [EdiValue("X(30)", Path = "TAX/4", Description = "TAX05 - Location Identifier")]
        [EdiExtension(MinLength = 1, MaxLength = 30, EdiType = EdiType.Alphanumeric)]
        public string LocationIdentifier02 { get; set; }

        [EdiValue("X(2)", Path = "TAX/5", Description = "TAX06 - Location Qualifier")]
        [EdiExtension(MinLength = 1, MaxLength = 2, EdiType = EdiType.Identifier)]
        [EdiAllowValue(AllowedValues = new string[] { "A", "B", "C", "D", "E", "F", "H", "I", "K", "L", "M", "O", "P", "W", "10", "11", "12", "13", "14", "18", "19", "20", "21", "22", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36", "38", "39", "40", "41", "42", "43", "44", "45", "46", "47", "48", "49", "50", "52", "53", "54", "55", "57", "58", "59", "60", "93", "94", "A1", "AA", "AC", "AP", "AR", "B1", "BE", "BL", "BS", "C2", "CA", "CB", "CC", "CD", "CE", "CI", "CL", "CO", "CR", "CS", "CY", "DC", "DE", "DL", "DO", "DP", "DR", "DT", "EA", "EL", "FA", "FE", "FF", "FI", "FR", "FS", "FT", "FV", "GL", "IA", "IB", "IM", "IP", "IS", "IT", "KE", "KL", "KP", "LO", "MI", "MS", "MZ", "NS", "OA", "OF", "OL", "OP", "OR", "OV", "PA", "PB", "PC", "PD", "PE", "PF", "PG", "PH", "PL", "PO", "PP", "PQ", "PR", "PS", "PT", "PU", "RA", "RC", "RE", "RG", "RJ", "RL", "RS", "RT", "SA", "SB", "SC", "SD", "SE", "SG", "SH", "SL", "SN", "SP", "SS", "ST", "SW", "TA", "TC", "TL", "TM", "TN", "TP", "TR", "TX", "UN", "UR", "UT", "VA", "VI", "VS", "WF", "WH", "WI", "ZN", "ZZ" })]
        public string LocationQualifier03 { get; set; }

        [EdiValue("X(30)", Path = "TAX/6", Description = "TAX07 - Location Identifier")]
        [EdiExtension(MinLength = 1, MaxLength = 30, EdiType = EdiType.Alphanumeric)]
        public string LocationIdentifier03 { get; set; }

        [EdiValue("X(2)", Path = "TAX/7", Description = "TAX08 - Location Qualifier")]
        [EdiExtension(MinLength = 1, MaxLength = 2, EdiType = EdiType.Identifier)]
        [EdiAllowValue(AllowedValues = new string[] { "A", "B", "C", "D", "E", "F", "H", "I", "K", "L", "M", "O", "P", "W", "10", "11", "12", "13", "14", "18", "19", "20", "21", "22", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36", "38", "39", "40", "41", "42", "43", "44", "45", "46", "47", "48", "49", "50", "52", "53", "54", "55", "57", "58", "59", "60", "93", "94", "A1", "AA", "AC", "AP", "AR", "B1", "BE", "BL", "BS", "C2", "CA", "CB", "CC", "CD", "CE", "CI", "CL", "CO", "CR", "CS", "CY", "DC", "DE", "DL", "DO", "DP", "DR", "DT", "EA", "EL", "FA", "FE", "FF", "FI", "FR", "FS", "FT", "FV", "GL", "IA", "IB", "IM", "IP", "IS", "IT", "KE", "KL", "KP", "LO", "MI", "MS", "MZ", "NS", "OA", "OF", "OL", "OP", "OR", "OV", "PA", "PB", "PC", "PD", "PE", "PF", "PG", "PH", "PL", "PO", "PP", "PQ", "PR", "PS", "PT", "PU", "RA", "RC", "RE", "RG", "RJ", "RL", "RS", "RT", "SA", "SB", "SC", "SD", "SE", "SG", "SH", "SL", "SN", "SP", "SS", "ST", "SW", "TA", "TC", "TL", "TM", "TN", "TP", "TR", "TX", "UN", "UR", "UT", "VA", "VI", "VS", "WF", "WH", "WI", "ZN", "ZZ" })]
        public string LocationQualifier04 { get; set; }

        [EdiValue("X(30)", Path = "TAX/8", Description = "TAX09 - Location Identifier")]
        [EdiExtension(MinLength = 1, MaxLength = 30, EdiType = EdiType.Alphanumeric)]
        public string LocationIdentifier04 { get; set; }

        [EdiValue("X(2)", Path = "TAX/9", Description = "TAX10 - Location Qualifier")]
        [EdiExtension(MinLength = 1, MaxLength = 2, EdiType = EdiType.Identifier)]
        [EdiAllowValue(AllowedValues = new string[] { "A", "B", "C", "D", "E", "F", "H", "I", "K", "L", "M", "O", "P", "W", "10", "11", "12", "13", "14", "18", "19", "20", "21", "22", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36", "38", "39", "40", "41", "42", "43", "44", "45", "46", "47", "48", "49", "50", "52", "53", "54", "55", "57", "58", "59", "60", "93", "94", "A1", "AA", "AC", "AP", "AR", "B1", "BE", "BL", "BS", "C2", "CA", "CB", "CC", "CD", "CE", "CI", "CL", "CO", "CR", "CS", "CY", "DC", "DE", "DL", "DO", "DP", "DR", "DT", "EA", "EL", "FA", "FE", "FF", "FI", "FR", "FS", "FT", "FV", "GL", "IA", "IB", "IM", "IP", "IS", "IT", "KE", "KL", "KP", "LO", "MI", "MS", "MZ", "NS", "OA", "OF", "OL", "OP", "OR", "OV", "PA", "PB", "PC", "PD", "PE", "PF", "PG", "PH", "PL", "PO", "PP", "PQ", "PR", "PS", "PT", "PU", "RA", "RC", "RE", "RG", "RJ", "RL", "RS", "RT", "SA", "SB", "SC", "SD", "SE", "SG", "SH", "SL", "SN", "SP", "SS", "ST", "SW", "TA", "TC", "TL", "TM", "TN", "TP", "TR", "TX", "UN", "UR", "UT", "VA", "VI", "VS", "WF", "WH", "WI", "ZN", "ZZ" })]
        public string LocationQualifier05 { get; set; }

        [EdiValue("X(30)", Path = "TAX/10", Description = "TAX11 - Location Identifier")]
        [EdiExtension(MinLength = 1, MaxLength = 30, EdiType = EdiType.Alphanumeric)]
        public string LocationIdentifier05 { get; set; }

        [EdiValue("X(1)", Path = "TAX/11", Description = "TAX12 - Tax Exempt Code")]
        [EdiExtension(MinLength = 1, MaxLength = 1, EdiType = EdiType.Alphanumeric)]
        [EdiAllowValue(AllowedValues = new string[] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X" })]

        public string TaxExemptCode { get; set; }

        [EdiValue("X(1)", Path = "TAX/12", Description = "TAX13 - Customs Entry Type Group Code")]
        [EdiExtension(MinLength = 1, MaxLength = 1, Mandatory = false, EdiType = EdiType.Alphanumeric)]
        [EdiAllowValue(AllowedValues = new string[] { "C", "W" })]
        public string CustomsEntryTypeGroupCode { get; set; }
    }
}