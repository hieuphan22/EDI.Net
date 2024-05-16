using Edi.Domain.Shared.Enums;
using indice.Edi.Serialization;
using Scm.Edi.Domain.Shared.Attributes;

namespace Edi.Application.Contracts.Poco.X12_4010.Segments
{
    [EdiSegment]
    [EdiPath("PER")]
    public class PER
    {
        [EdiValue("X(2)", Path = "PER/0", Description = "PER01 - Contact Function Code")]
        [EdiExtension(MinLength = 2, MaxLength = 2, Mandatory = true, EdiType = EdiType.Identifier)]
        [EdiAllowValue(AllowedValues = new string[] { "1A", "1B", "1C", "1D", "1E", "1F", "1G", "1H", "3A", "A1", "A2", "A3", "A4", "A5", "AA", "AB", "AC", "AD", "AE", "AF", "AG", "AH", "AI", "AL", "AM", "AN", "AP", "AR", "AS", "AT", "AU", "AV", "BA", "BB", "BC", "BD", "BI", "BJ", "BK", "BL", "BM", "BP", "BS", "BU", "C2", "CA", "CB", "CC", "CD", "CE", "CF", "CG", "CH", "CI", "CJ", "CK", "CL", "CM", "CN", "CO", "CP", "CR", "CS", "CT", "CU", "CV", "CW", "CX", "CY", "CZ", "DA", "DC", "DD", "DE", "DF", "DI", "DM", "DN", "DV", "E1", "E2", "EA", "EB", "EC", "ED", "EF", "EG", "EM", "EN", "EO", "EP", "ES", "EV", "EX", "FA", "FB", "FC", "FD", "FF", "FL", "FM", "FN", "FO", "FP", "FQ", "FR", "GA", "GB", "GC", "GE", "GR", "HM", "HR", "IC", "IO", "IP", "IS", "KA", "KB", "KC", "KP", "KT", "LD", "MA", "MB", "MC", "MD", "ME", "MG", "MK", "ML", "MM", "NA", "NC", "NP", "NT", "OA", "OC", "OD", "OS", "OW", "PA", "PB", "PC", "PD", "PE", "PF", "PG", "PH", "PI", "PJ", "PK", "PL", "PM", "PN", "PO", "PP", "PQ", "PR", "PS", "PT", "PU", "PV", "PW", "PX", "PY", "PZ", "QA", "QC", "QI", "QM", "QP", "QR", "QY", "RA", "RB", "RC", "RD", "RE", "RF", "RG", "RP", "RQ", "RS", "RZ", "SA", "SB", "SC", "SD", "SE", "SF", "SG", "SH", "SI", "SJ", "SK", "SL", "SM", "SN", "SO", "SP", "SQ", "SR", "SS", "ST", "SU", "SV", "SW", "SY", "TA", "TB", "TC", "TD", "TE", "TH", "TM", "TN", "TP", "TR", "TY", "UG", "UP", "UQ", "UR", "VM", "VP", "WH", "WI", "WR", "ZZ" })]
        public string ContactFunctionCode { get; set; }

        [EdiValue("X(60)", Path = "PER/1", Description = "PER02 - Name")]
        [EdiExtension(MinLength = 1, MaxLength = 60, Mandatory = false, EdiType = EdiType.Alphanumeric)]
        public string Name { get; set; }

        [EdiValue("X(2)", Path = "PER/2", Description = "PER03 - Communication Number Qualifier")]
        [EdiExtension(MinLength = 2, MaxLength = 2, Mandatory = false, EdiType = EdiType.Identifier)]
        [EdiAllowValue(AllowedValues = new string[] { "AA", "AB", "AC", "AD", "AP", "AS", "AU", "BN", "BT", "CA", "CP", "DN", "ED", "EM", "EX", "FT", "FU", "FX", "HF", "HP", "IT", "MN", "NP", "OF", "OT", "PA", "PC", "PP", "PS", "SP", "TE", "TL", "TM", "TN", "TX", "UR", "VM", "WC", "WF", "WP" })]
        public string CommunicationNumberQualifier { get; set; }

        [EdiValue("X(80)", Path = "PER/3", Description = "PER04 - Communication Number")]
        [EdiExtension(MinLength = 1, MaxLength = 80, Mandatory = false, EdiType = EdiType.Alphanumeric)]
        public string CommunicationNumber { get; set; }

        [EdiValue("X(2)", Path = "PER/4", Description = "PER05 - Communication Number Qualifier")]
        [EdiExtension(MinLength = 2, MaxLength = 2, Mandatory = false, EdiType = EdiType.Identifier)]
        [EdiAllowValue(AllowedValues = new string[] { "AA", "AB", "AC", "AD", "AP", "AS", "AU", "BN", "BT", "CA", "CP", "DN", "ED", "EM", "EX", "FT", "FU", "FX", "HF", "HP", "IT", "MN", "NP", "OF", "OT", "PA", "PC", "PP", "PS", "SP", "TE", "TL", "TM", "TN", "TX", "UR", "VM", "WC", "WF", "WP" })]
        public string CommunicationNumberQualifier02 { get; set; }

        [EdiValue("X(80)", Path = "PER/5", Description = "PER06 - Communication Number")]
        [EdiExtension(MinLength = 1, MaxLength = 80, Mandatory = false, EdiType = EdiType.Alphanumeric)]
        public string CommunicationNumber02 { get; set; }

        [EdiValue("X(2)", Path = "PER/6", Description = "PER07 - Communication Number Qualifier")]
        [EdiExtension(MinLength = 2, MaxLength = 2, Mandatory = false, EdiType = EdiType.Identifier)]
        [EdiAllowValue(AllowedValues = new string[] { "AA", "AB", "AC", "AD", "AP", "AS", "AU", "BN", "BT", "CA", "CP", "DN", "ED", "EM", "EX", "FT", "FU", "FX", "HF", "HP", "IT", "MN", "NP", "OF", "OT", "PA", "PC", "PP", "PS", "SP", "TE", "TL", "TM", "TN", "TX", "UR", "VM", "WC", "WF", "WP" })]
        public string CommunicationNumberQualifier03 { get; set; }

        [EdiValue("X(80)", Path = "PER/7", Description = "PER08 - Communication Number")]
        [EdiExtension(MinLength = 1, MaxLength = 80, Mandatory = false, EdiType = EdiType.Alphanumeric)]
        public string CommunicationNumber03 { get; set; }

        [EdiValue("X(20)", Path = "PER/8", Description = "PER09 - Contact Inquiry Reference")]
        [EdiExtension(MinLength = 1, MaxLength = 20, Mandatory = false, EdiType = EdiType.Alphanumeric)]
        public string ContactInquiryReference { get; set; }
    }
}
