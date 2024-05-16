using Edi.Domain.Shared.Enums;
using indice.Edi.Serialization;
using Scm.Edi.Domain.Shared.Attributes;
namespace Edi.Application.Contracts.Poco.X12_4010.Segments
{
    [EdiSegment]
    [EdiPath("MTX")]
    public class MTX
    {
        [EdiValue("X(3)", Path = "MTX/0", Description = "MTX01 - Note Reference Code")]
        [EdiExtension(MinLength = 3, MaxLength = 3, Mandatory = false, EdiType = EdiType.Identifier)]
        [EdiAllowValue(AllowedValues = new string[] { "AAA", "AAB", "AAC", "AAD", "AAE", "AAF", "ABN", "ACC", "ACI", "ACN", "ACS", "ACT", "ADD", "AES", "AET", "ALG", "ALL", "ALT", "AMN", "AOO", "APN", "APS", "BBD", "BBF", "BBH", "BBN", "BBO", "BBT", "BFD", "BOL", "BUR", "CAA", "CAB", "CAC", "CAD", "CAE", "CAF", "CAG", "CAH", "CAI", "CAJ", "CAK", "CAL", "CAM", "CAN", "CAO", "CAP", "CAQ", "CAR", "CAS", "CAT", "CAU", "CAV", "CAW", "CAX", "CAZ", "CBA", "CBB", "CBC", "CBH", "CBI", "CCA", "CCB", "CCC", "CCD", "CCE", "CCF", "CCG", "CCN", "CDD", "CER", "CHG", "CIG", "CLN", "CLR", "CMP", "CMT", "COD", "COM", "CON", "CRA", "CRK", "CRN", "CUS", "DCP", "DEE", "DEL", "DEP", "DFR", "DFS", "DGN", "DME", "DOD", "DOI", "ECD", "ECM", "ECN", "ECT", "EED", "EFD", "ELE", "EMC", "EMD", "ENR", "ERN", "EVL", "EXE", "EXR", "EXT", "FEE", "FUT", "GEN", "GPI", "GSI", "HHI", "ICN", "IDT", "IID", "IIE", "IIR", "IMP", "INS", "INT", "INV", "IVC", "JVD", "LAB", "LBD", "LBS", "LEN", "LIN", "LIQ", "LLA", "LLB", "LLC", "LOC", "LOI", "LSD", "MCD", "MDO", "MED", "MFG", "MKN", "MMD", "MSD", "NCD", "NPD", "NTR", "OBI", "OBL", "OCA", "OCC", "OCL", "OCP", "OCR", "ODT", "OLS", "OPO", "ORA", "ORE", "ORI", "OTH", "OTN", "OTS", "PAY", "PCS", "PDS", "PED", "PEN", "PES", "PID", "PKG", "PMT", "POB", "POC", "POL", "PPC", "PRI", "PRN", "PRO", "PRR", "PSY", "PUR", "QUL", "QUT", "RDI", "REC", "REG", "REP", "REV", "RFL", "RHB", "RLA", "RLH", "RNH", "RNI", "ROU", "RPT", "RST", "RVC", "SAN", "SCN", "SDD", "SET", "SFM", "SMD", "SOB", "SOW", "SPH", "SPT", "SPV", "SSA", "SSC", "SSD", "SSE", "SSG", "SSH", "SSI", "SSS", "SST", "TAF", "TCF", "TDA", "TES", "TIL", "TLF", "TLR", "TPO", "TRA", "TRE", "TRF", "TRS", "TSD", "TSF", "TST", "UPI", "VEC", "VNN", "WHI", "WRP", "ZZZ" })]
        public string NoteReferenceCode { get; set; }

        [EdiValue("X(4096)", Path = "MTX/1", Description = "MTX02 - Message Text")]
        [EdiExtension(MinLength = 1, MaxLength = 4096, EdiType = EdiType.Alphanumeric)]
        public string MessageText { get; set; }

        [EdiValue("X(4096)", Path = "MTX/2", Description = "MTX03 - Message Text")]
        [EdiExtension(MinLength = 1, MaxLength = 4096, Mandatory = false, EdiType = EdiType.Alphanumeric)]
        public string MessageText02 { get; set; }

        [EdiValue("X(2)", Path = "MTX/3", Description = "MTX04 - Printer Carriage Control Code")]
        [EdiExtension(MinLength = 2, MaxLength = 2, Mandatory = false, EdiType = EdiType.Identifier)]
        [EdiAllowValue(AllowedValues = new string[] { "AA", "AT", "DS", "LC", "NP", "NS", "SS" })]

        public string PrinterCarriageControlCode { get; set; }
    }
}
