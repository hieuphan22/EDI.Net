using System.Collections.Generic;
using Edi.Domain.Shared.Enums;
using Edi.Domain.Shared.Validation;
using FluentValidation.Results;
using indice.Edi.Serialization;
using Scm.Edi.Domain.Shared.Attributes;

namespace Edi.Application.Contracts.Poco.X12_4010.Segments
{
    [EdiSegment]
    [EdiPath("PCT")]
    public class PCT : IEdiValidation<PCT>
    {
        [EdiValue("X(2)", Path = "PCT/0", Description = "PCT01 - Percent Qualifier")]
        [EdiExtension(MinLength = 1, MaxLength = 2, Mandatory = true, EdiType = EdiType.Identifier)]
        [EdiAllowValue(AllowedValues = new string[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "A", "B", "C", "D", "E", "F", "M", "N", "O", "P", "R", "S", "T", "W", "X", "01", "02", "05", "06", "07", "08", "09", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "30", "31", "32", "33", "34", "35", "36", "37", "38", "40", "41", "42", "43", "44", "45", "46", "47", "48", "49", "50", "51", "52", "53", "59", "60", "61", "62", "63", "64", "65", "66", "67", "68", "69", "70", "71", "72", "76", "77", "78", "79", "80", "81", "82", "83", "84", "85", "86", "87", "88", "89", "90", "91", "92", "93", "94", "95", "96", "97", "98", "99", "AB", "AC", "AD", "AE", "AF", "AG", "AH", "AI", "AJ", "AK", "AL", "AM", "AN", "AP", "AR", "AT", "BA", "BB", "BC", "BD", "BE", "BF", "BG", "BH", "BP", "BS", "BU", "CA", "CB", "CH", "CJ", "CN", "CO", "CP", "CR", "CS", "CU", "DF", "DY", "EA", "EF", "EP", "FT", "FV", "GA", "IA", "IN", "KA", "KB", "LM", "MA", "MN", "MS", "MX", "NA", "NH", "OC", "OF", "OH", "OP", "PA", "PC", "PD", "PF", "PH", "PM", "PN", "PP", "PR", "PT", "PV", "RA", "RB", "RC", "RD", "RF", "RG", "RI", "RL", "RO", "RP", "RQ", "RR", "RS", "SA", "SC", "SD", "SE", "SF", "SG", "TP", "WI", "WK", "X1", "XT" })]
        public string PercentQualifier { get; set; }

        [EdiValue("X(10)", Path = "PCT/1", Format = "R", Description = "PCT02 - Percent")]
        [EdiExtension(MinLength = 1, MaxLength = 10, Mandatory = true, EdiType = EdiType.Decimal)]
        public string Percent { get; set; }

        public List<ValidationResult> ValidateEdi(PCT model)
        {
            return new List<ValidationResult>();
        }
    }
}
