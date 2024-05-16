using System.ComponentModel;
using Scm.Common.Domain.Shared.Attributes;

namespace Edi.Domain.Shared.Enums
{
    public enum EdiType
    {
        Default,
        Identifier, // ID
        Alphanumeric, // AN
        Date, // DT
        Time, // TM
        Binary, // B
        Numeric, // N
        Decimal, // R
    }

    /// <summary>
    /// 1250 Date Time Period Format Qualifier
    /// </summary>
    public enum DateTimeFormatQualifier
    {
        [Description("Unstructured")]
        [StringValue("UN")]
        UN,
        [Description("First Two Digits of Year Expressed in Format CCYY")]
        [StringValue("CCYY")]
        CC,
        [Description("Month and Year Expressed in Format MMMYYYY")]
        [StringValue("MMMYYYY")]
        CD,
        [Description("Date in Format CCYYMM")]
        [StringValue("CCYYMM")]
        CM,
        [Description("Date in Format CCYYQ")]
        [StringValue("CCYYQ")]
        CQ,
        [Description("Year Expressed in Format CCYY")]
        [StringValue("CCYY")]
        CY,
        [Description("Date Expressed in Format YYMMDD")]
        [StringValue("YYMMDD")]
        D6,
        [Description("Date Expressed in Format CCYYMMDD")]
        [StringValue("CCYYMMDD")]
        D8,
        [Description("Range of Dates within a Single Month Expressed in Format DD-DD")]
        [StringValue("DD-DD")]
        DA,
        [Description("Date Expressed in Format MMDDCCYY")]
        [StringValue("MMDDCCYY")]
        DB,
        [Description("Day of Month in Numeric Format")]
        [StringValue("DD")]
        DD,
        [Description("Date and Time Expressed in Format CCYYMMDDHHMM")]
        [StringValue("CCYYMMDDHHMM")]
        DT,
        [Description("Last Digit of Year and Julian Date Expressed in Format YDDD")]
        [StringValue("EH")]
        EH,
        [Description("Date Expressed in Format YYMMMDD")]
        [StringValue("YYMMMDD")]
        KA,
        [Description("Month of Year and Day of Month Expressed in Format MMDD")]
        [StringValue("MMDD")]
        MD,
        [Description("Month of Year in Numeric Format")]
        [StringValue("MM")]
        MM,
        [Description("Range of Dates Expressed in Format MMDDCCYY-MMDDCCYY")]
        [StringValue("MMDDCCYY")]
        RD,
        [Description("Julian Date Expressed in Format DDD")]
        [StringValue("DDD")]
        TC,
        [Description("Time Expressed in Format HHMM")]
        [StringValue("HHMM")]
        TM,
        [Description("Date Expressed in Format MMYY")]
        [StringValue("MMYY")]
        TQ,
        [Description("Date and Time Expressed in Format DDMMYYHHMM")]
        [StringValue("DDMMYYHHMM")]
        TR,
        [Description("Time Expressed in Format HHMMSS")]
        [StringValue("HHMMSS")]
        TS,
        [Description("Date Expressed in Format MMDDYY")]
        [StringValue("MMDDYY")]
        TT,
        [Description("Date Expressed in Format YYDDD")]
        [StringValue("YYDDD")]
        TU,
        [Description("Year and Month Expressed in Format YYMM")]
        [StringValue("YYMM")]
        YM,
        [Description("Last Two Digits of Year Expressed in Format CCYY")]
        [StringValue("CCYY")]
        YY,
        [Description("Range of Date and Time Expressed in Format CCYYMMDDHHMMSS-CCYYMMDDHHMMSS")]
        [StringValue("CCYYMMDDHHMMSS-CCYYMMDDHHMMSS")]
        DTS,
        [Description("Range of Years Expressed in Format YY-YY")]
        [StringValue("YY-YY")]
        RD2,
        [Description("Range of Years Expressed in Format CCYY-CCYY")]
        [StringValue("CCYY-CCYY")]
        RD4,
        [Description("Range of Years and Months Expressed in Format CCYYMM-CCYYMM")]
        [StringValue("CCYYMM-CCYYMM")]
        RD5,
        [Description("Range of Dates Expressed in Format YYMMDD-YYMMDD")]
        [StringValue("YYMMDD-YYMMDD")]
        RD6,
        [Description("Range of Dates Expressed in Format CCYYMMDD-CCYYMMDD")]
        [StringValue("CCYYMMDD-CCYYMMDD")]
        RD8,
        [Description("Range of Dates Expressed in Format YYMMDD-MMDD")]
        [StringValue("YYMMDD-MMDD")]
        RDM,
        [Description("Range of Date and Time, Expressed in Format CCYYMMDDHHMM-CCYYMMDDHHMM")]
        [StringValue("CCYYMMDDHHMM-CCYYMMDDHHMM")]
        RDT,
        [Description("Range of Months and Days Expressed in Format MMDD-MMDD")]
        [StringValue("MMDD-MMDD")]
        RMD,
        [Description("Range of Years and Months Expressed in Format YYMM-YYMM")]
        [StringValue("YYMM-YYMM")]
        RMY,
        [Description("Range of Time Expressed in Format HHMM-HHMM")]
        [StringValue("HHMM-HHMM")]
        RTM,
        [Description("Date and Time Expressed in Format CCYYMMDDHHMMSS")]
        [StringValue("CCYYMMDDHHMMSS")]
        RTS,
        [Description("Range of Year and Months, Expressed in CCYYMMM-MMM Format")]
        [StringValue("CCYYMMM-MMM")]
        YMM,
    }
}
