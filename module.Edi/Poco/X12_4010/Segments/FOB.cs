using System.Collections.Generic;
using Edi.Domain.Shared.Attributes;
using Edi.Domain.Shared.Enums;
using Edi.Domain.Shared.Validation;
using FluentValidation.Results;
using indice.Edi.Serialization;
using Scm.Edi.Domain.Shared.Attributes;

namespace Edi.Application.Contracts.Poco.X12_4010.Segments
{
    [EdiSegment]
    [EdiPath("FOB")]
    public class FOB : IEdiValidation<FOB>
    {
        [EdiValue("X(2)", Path = "FOB/0", Description = "FOB01 - Shipment Method of Payment")]
        [EdiExtension(MinLength = 2, MaxLength = 2, Mandatory = true, EdiType = EdiType.Identifier)]
        [EdiAllowValue(AllowedValues = new string[] { "11", "BP", "CA", "CC", "CD", "CF", "DE", "DF", "FO", "HP", "MX", "NC", "NR", "PA", "PB", "PC", "PD", "PE", "PL", "PO", "PP", "PS", "PU", "RC", "RF", "RS", "TP", "WC" })]
        public string ShipmentMethodOfPayment { get; set; }

        [EdiValue("X(2)", Path = "FOB/1", Description = "FOB02 - Location Qualifier")]
        [EdiExtension(MinLength = 1, MaxLength = 2, Mandatory = false, EdiType = EdiType.Identifier)]
        [EdiAllowValue(AllowedValues = new string[] { "A", "B", "C", "D", "E", "F", "H", "I", "K", "L", "M", "O", "P", "W", "10", "11", "12", "13", "14", "18", "19", "20", "21", "22", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36", "38", "39", "40", "41", "42", "43", "44", "45", "46", "47", "48", "49", "50", "52", "53", "54", "55", "57", "58", "59", "60", "93", "94", "A1", "AA", "AC", "AP", "AR", "B1", "BE", "BL", "BS", "C2", "CA", "CB", "CC", "CD", "CE", "CI", "CL", "CO", "CR", "CS", "CY", "DC", "DE", "DL", "DO", "DP", "DR", "DT", "EA", "EL", "FA", "FE", "FF", "FI", "FR", "FS", "FT", "FV", "GL", "IA", "IB", "IM", "IP", "IS", "IT", "KE", "KL", "KP", "LO", "MI", "MS", "MZ", "NS", "OA", "OF", "OL", "OP", "OR", "OV", "PA", "PB", "PC", "PD", "PE", "PF", "PG", "PH", "PL", "PO", "PP", "PQ", "PR", "PS", "PT", "PU", "RA", "RC", "RE", "RG", "RJ", "RL", "RS", "RT", "SA", "SB", "SC", "SD", "SE", "SG", "SH", "SL", "SN", "SP", "SS", "ST", "SW", "TA", "TC", "TL", "TM", "TN", "TP", "TR", "TX", "UN", "UR", "UT", "VA", "VI", "VS", "WF", "WH", "WI", "ZN", "ZZ" })]
        public string LocationQualifier { get; set; }

        [EdiValue("X(80)", Path = "FOB/2", Description = "FOB03 - Description")]
        [EdiExtension(MinLength = 1, MaxLength = 80, Mandatory = false, EdiType = EdiType.Alphanumeric)]
        public string Description { get; set; }

        [EdiValue("X(2)", Path = "FOB/3", Description = "FOB04 - Transportation Terms Qualifier Code")]
        [EdiExtension(MinLength = 2, MaxLength = 2, Mandatory = false, EdiType = EdiType.Identifier)]
        [EdiAllowValue(AllowedValues = new string[] { "01", "02", "ZZ" })]
        public string TransportationTermsQualifierCode { get; set; }

        [EdiValue("X(3)", Path = "FOB/4", Description = "FOB05 - Transportation Terms code")]
        [EdiExtension(MinLength = 3, MaxLength = 3, Mandatory = false, EdiType = EdiType.Identifier)]
        [EdiAllowValue(AllowedValues = new string[] { "CAF", "CFR", "CIF", "CIP", "CPT", "DAF", "DDP", "DDU", "DEQ", "DES", "DOM", "DUP", "EXQ", "EXS", "EXW", "FAS", "FCA", "FCI", "FCP", "FOB", "FOR", "FOT", "NPF", "PPF", "ZZZ" })]

        public string TransportationTermscode { get; set; }

        [EdiValue("X(2)", Path = "FOB/5", Description = "FOB06 - Location Qualifier")]
        [EdiExtension(MinLength = 1, MaxLength = 2, Mandatory = false, EdiType = EdiType.Identifier)]
        [EdiAllowValue(AllowedValues = new string[] { "A", "B", "C", "D", "E", "F", "H", "I", "K", "L", "M", "O", "P", "W", "10", "11", "12", "13", "14", "18", "19", "20", "21", "22", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36", "38", "39", "40", "41", "42", "43", "44", "45", "46", "47", "48", "49", "50", "52", "53", "54", "55", "57", "58", "59", "60", "93", "94", "A1", "AA", "AC", "AP", "AR", "B1", "BE", "BL", "BS", "C2", "CA", "CB", "CC", "CD", "CE", "CI", "CL", "CO", "CR", "CS", "CY", "DC", "DE", "DL", "DO", "DP", "DR", "DT", "EA", "EL", "FA", "FE", "FF", "FI", "FR", "FS", "FT", "FV", "GL", "IA", "IB", "IM", "IP", "IS", "IT", "KE", "KL", "KP", "LO", "MI", "MS", "MZ", "NS", "OA", "OF", "OL", "OP", "OR", "OV", "PA", "PB", "PC", "PD", "PE", "PF", "PG", "PH", "PL", "PO", "PP", "PQ", "PR", "PS", "PT", "PU", "RA", "RC", "RE", "RG", "RJ", "RL", "RS", "RT", "SA", "SB", "SC", "SD", "SE", "SG", "SH", "SL", "SN", "SP", "SS", "ST", "SW", "TA", "TC", "TL", "TM", "TN", "TP", "TR", "TX", "UN", "UR", "UT", "VA", "VI", "VS", "WF", "WH", "WI", "ZN", "ZZ" })]

        public string LocationQualifier2 { get; set; }

        [EdiValue("X(80)", Path = "FOB/6", Description = "FOB07 - Description")]
        [EdiExtension(MinLength = 1, MaxLength = 80, Mandatory = false, EdiType = EdiType.Alphanumeric)]
        public string Description2 { get; set; }

        [EdiValue("X(2)", Path = "FOB/7", Description = "FOB08 - Shipment Method of Payment")]
        [EdiExtension(MinLength = 2, MaxLength = 2, Mandatory = false, EdiType = EdiType.Identifier)]
        public string RiskOfLossCode { get; set; }

        [EdiValue("X(80)", Path = "FOB/8", Description = "FOB09 - Description")]
        [EdiExtension(MinLength = 1, MaxLength = 80, Mandatory = false, EdiType = EdiType.Alphanumeric)]
        public string Description03 { get; set; }

        public List<ValidationResult> ValidateEdi(FOB model)
        {
            return new List<ValidationResult>();
        }
    }
}
