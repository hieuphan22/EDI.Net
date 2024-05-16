using System.Collections.Generic;
using Edi.Domain.Shared.Enums;
using Edi.Domain.Shared.Validation;
using FluentValidation.Results;
using indice.Edi.Serialization;
using Scm.Edi.Domain.Shared.Attributes;

namespace Edi.Application.Contracts.Poco.X12_4010.Segments
{
    [EdiSegment]
    [EdiPath("CTP")]
    public class CTP : IEdiValidation<CTP>
    {
        [EdiValue("X(2)", Path = "CTP/0", Description = "CTP01 - Class of Trade Code")]
        [EdiExtension(MinLength = 2, MaxLength = 2, Mandatory = false, EdiType = EdiType.Identifier)]
        [EdiAllowValue(AllowedValues = new string[] { "AA", "AB", "AC", "AD", "AG", "AI", "AP", "AS", "BG", "BR", "CB", "CN", "CO", "CR", "CX", "CY", "DE", "DF", "DI", "DR", "EX", "FS", "GA", "GM", "GR", "GV", "HS", "ID", "IN", "IR", "JB", "LC", "MC", "MF", "ML", "OE", "OF", "ON", "PF", "PH", "PT", "PY", "RS", "SA", "SB", "SE", "ST", "TR", "WA", "WC", "WH", "WS" })]

        public string ClassOfTradeCode { get; set; }

        [EdiValue("X(3)", Path = "CTP/1", Description = "CTP02 - Price Identifier Code")]
        [EdiExtension(MinLength = 3, MaxLength = 3, Mandatory = false, EdiType = EdiType.Identifier)]
        [EdiAllowValue(AllowedValues = new string[] { "ACT", "AGC", "ALT", "AWP", "BBP", "BCH", "C01", "C02", "C03", "C04", "C05", "C06", "C07", "C08", "C09", "C10", "C11", "C12", "C13", "C14", "C15", "C16", "C17", "C18", "C19", "C20", "C21", "C22", "C23", "C24", "C25", "C26", "C27", "C28", "C29", "C30", "CAN", "CAT", "CDF", "CDV", "CHG", "CON", "CUP", "CUS", "D01", "D02", "D03", "DAP", "DIS", "DPR", "DSC", "DSD", "DSP", "EDM", "EDP", "EDS", "EDW", "ELC", "EST", "EUP", "FCH", "FCP", "FDS", "FET", "FGP", "FSP", "FUL", "FUP", "GAP", "GDP", "GOV", "GSP", "GTP", "ICL", "IND", "INS", "INV", "LAR", "LPP", "LPR", "MAP", "MAS", "MAX", "MIN", "MNC", "MNR", "MOD", "MPR", "MSR", "MXR", "N01", "N02", "N03", "N04", "N05", "N06", "N07", "N08", "N09", "N10", "N11", "N12", "N13", "N14", "N15", "N16", "N17", "N18", "N19", "N20", "N21", "N22", "N23", "N24", "N25", "N26", "N27", "N28", "N29", "N30", "N31", "NET", "OAP", "OPP", "PAP", "PAQ", "PBQ", "PBR", "PHS", "PIE", "PLT", "PPA", "PPD", "PRF", "PRO", "PRP", "PUR", "QTE", "REG", "RES", "RPA", "RPM", "RPP", "RSH", "RTL", "SAC", "SDP", "SFP", "SHD", "SLP", "SPC", "SPE", "STA", "SUM", "SWP", "THP", "TOT", "TRF", "UCP", "ULC", "WAR", "WHL", "WSP", "ZNP" })]

        public string PriceIdentifierCode { get; set; }

        [EdiValue("X(17)", Format = "R", Path = "CTP/2", Description = "CTP03 - Unit Price")]
        [EdiExtension(MinLength = 1, MaxLength = 17, Mandatory = false, EdiType = EdiType.Decimal)]
        public string UnitPrice { get; set; }

        [EdiValue("9(15)", Format = "R", Path = "CTP/3", Description = "CTP04 - Quantity")]
        [EdiExtension(MinLength = 1, MaxLength = 15, Mandatory = false, EdiType = EdiType.Decimal)]
        public string Quantity { get; set; }

        [EdiValue("9(2)", Path = "CTP/4", Description = "CTP05 - Unit or Basis for Measurement Code")]
        [EdiExtension(MinLength = 2, MaxLength = 2, Mandatory = false, EdiType = EdiType.Identifier)]
        public string UnitOrBasisForMeasurementCode { get; set; }

        [EdiValue("X(3)", Path = "CTP/5", Description = "CTP06 - Price Multiplier Qualifier")]
        [EdiExtension(MinLength = 3, MaxLength = 3, Mandatory = false, EdiType = EdiType.Identifier)]
        [EdiAllowValue(AllowedValues = new string[] { "CSD", "CSR", "DIS", "ILP", "PSP", "SEL" })]

        public string PriceMultiplierQualifier { get; set; }

        [EdiValue("9(10)", Format = "R", Path = "CTP/6", Description = "CTP07 - Multiplier")]
        [EdiExtension(MinLength = 1, MaxLength = 10, Mandatory = false, EdiType = EdiType.Decimal)]
        public string Multiplier { get; set; }

        [EdiValue("9(18)", Format = "R", Path = "CTP/7", Description = "CTP08 - Monetary Amount")]
        [EdiExtension(MinLength = 1, MaxLength = 18, Mandatory = false, EdiType = EdiType.Decimal)]
        public string MonetaryAmount { get; set; }

        [EdiValue("X(2)", Path = "CTP/8", Description = "CTP09 - Basis Of Unit Price Code")]
        [EdiExtension(MinLength = 2, MaxLength = 2, Mandatory = false, EdiType = EdiType.Identifier)]
        [EdiAllowValue(AllowedValues = new string[] { "AA", "AB", "AP", "AW", "BD", "BR", "BW", "CA", "CP", "CR", "CT", "DI", "DP", "DR", "DS", "EC", "EH", "ES", "FB", "FO", "FX", "HF", "HP", "HT", "KA", "KP", "KR", "LC", "LD", "LE", "LM", "LR", "ME", "ML", "NC", "NE", "NQ", "NS", "NT", "PA", "PB", "PD", "PE", "PF", "PG", "PK", "PL", "PM", "PN", "PO", "PP", "PQ", "PR", "PS", "PT", "PU", "PV", "PY", "QE", "QH", "QR", "QS", "QT", "RC", "RD", "RE", "RM", "RS", "RT", "SA", "SC", "SM", "SR", "ST", "SW", "TB", "TC", "TD", "TE", "TF", "TM", "TP", "TT", "UM", "VQ", "WC", "WD", "WE", "WH", "WI", "WM" })]
        public string BasisOfUnitPriceCode { get; set; }

        [EdiValue("X(10)", Path = "CTP/9", Description = "CTP10 - Condition Value")]
        [EdiExtension(MinLength = 1, MaxLength = 10, Mandatory = false, EdiType = EdiType.Alphanumeric)]
        public string ConditionValue { get; set; }

        [EdiValue("X(2)", Format = "N0", Path = "CTP/10", Description = "CTP11 - Multiple Price Quantity")]
        [EdiExtension(MinLength = 1, MaxLength = 2, Mandatory = false, EdiType = EdiType.Numeric)]
        public string MultiplePriceQuantity { get; set; }

        public List<ValidationResult> ValidateEdi(CTP model)
        {
            return new List<ValidationResult>();
        }
    }
}