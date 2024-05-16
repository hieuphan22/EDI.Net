using indice.Edi.Tests.Models;
using System;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using Xunit;

namespace indice.Edi.Tests
{
    public class EdiTextReaderTests
    {
       

        [Fact]
        [Trait(Traits.Tag, "X12")]
        public void X12_Grammar_Test() {
            var grammar = EdiGrammar.NewX12();
            var interchange = default(Models.PurchaseOrder_850);
            using (var stream = Helpers.GetResourceStream("x12.850.edi")) {
                interchange = new EdiSerializer().Deserialize<Models.PurchaseOrder_850>(new StreamReader(stream), grammar);
            }
            Assert.Equal(new DateTime(2009, 8, 27, 9, 36, 00), interchange.Date);
            Assert.Equal(new DateTime(2009, 8, 27, 10, 41, 00), interchange.Groups[0].Date);
            Assert.Equal(19.95M, interchange.Groups[0].Orders[0].Items[0].UnitPrice);
            Assert.Equal("126 Any St", interchange.Groups[0].Orders[0].Addresses[0].AddressInformation);
        }

        [Fact]
        [Trait(Traits.Issue, "#27")]
        [Trait(Traits.Tag, "X12")]
        public void X12_850_Issue27_Test() {
            var grammar = EdiGrammar.NewX12();
            var interchange = default(Models.PurchaseOrder_850);
            using (var stream = Helpers.GetResourceStream("x12.850a.edi")) {
                interchange = new EdiSerializer().Deserialize<Models.PurchaseOrder_850>(new StreamReader(stream), grammar);
            }
            Assert.Equal(new DateTime(2009, 8, 27, 9, 36, 00), interchange.Date);
            Assert.Equal(new DateTime(2009, 8, 27, 10, 41, 00), interchange.Groups[0].Date);
            Assert.Equal(2.53M, interchange.Groups[0].Orders[0].Items[0].UnitPrice);
            Assert.Equal("East Point Drive, Suite 500", interchange.Groups[0].Orders[0].Addresses[0].AddressInformation);
            Assert.Equal(2, interchange.Groups[0].Orders[0].Items[0].MSG.Count());
            Assert.Equal("4.4OZ 100% POLYESTER QUILT", interchange.Groups[0].Orders[0].Items[0].MSG[0].MessageText);
            Assert.Equal("First Quality", interchange.Groups[0].Orders[0].Items[0].MSG[1].MessageText);
        }

        [Fact]
        [Trait(Traits.Tag, "X12")]
        public void X12_214_Test() {
            var grammar = EdiGrammar.NewX12();
            var interchange = default(Models.Transportation_214);
            using (var stream = Helpers.GetResourceStream("x12.214.edi")) {
                interchange = new EdiSerializer().Deserialize<Models.Transportation_214>(new StreamReader(stream), grammar);
            }
            var message = interchange.Groups[0].Messages[0];
            Assert.Equal(3, message.Places.Count);
            Assert.Equal(1751807, message.ReferenceIdentification);
        }

        [Fact]
        [Trait(Traits.Tag, "X12")]
        public void X12_214_Trailers_Test() {
            var grammar = EdiGrammar.NewX12();
            var interchange = default(Models.Transportation_214);
            using (var stream = Helpers.GetResourceStream("x12.214.edi")) {
                interchange = new EdiSerializer().Deserialize<Models.Transportation_214>(new StreamReader(stream), grammar);
            }
            var group = interchange.Groups[0];
            var message = group.Messages[0];

            Assert.Equal(16, message.MessageSegmetsCount);
            Assert.Equal("822650001", message.MessageControlNumber);
            Assert.Equal(1, group.TransactionsCount);
            Assert.Equal(82265, group.GroupTrailerControlNumber);
        }
        [Fact]
        [Trait(Traits.Tag, "X12")]
        public void X12_204_Test() {
            var grammar = EdiGrammar.NewX12();
            grammar.SetAdvice(
                segmentNameDelimiter: '*',
                dataElementSeparator: '*',
                componentDataElementSeparator: ':',
                segmentTerminator: '~',
                releaseCharacter: null,
                reserved: null,
                decimalMark: '.');

            string text = string.Empty;
            using (var filestream = Helpers.GetResourceStream("204-MGCTLYST-SAMPLE.EDI"))
            using (var reader = new StreamReader(filestream))
                text = reader.ReadToEnd();

            var stream = new MemoryStream(Encoding.UTF8.GetBytes(text.Replace('\n', '~')));

            var segmentCount = 0;
            using (var ediReader = new EdiTextReader(new StreamReader(stream), grammar)) {
                while (ediReader.Read()) {
                    if (ediReader.TokenType == EdiToken.SegmentName) {
                        segmentCount++;
                    }
                }
            }
            Assert.Equal(42, segmentCount);
        }

        [Fact]
        [Trait(Traits.Tag, "Parser")]
        public void ReaderStrips_Z_Padding_Test() {
            var grammar = EdiGrammar.NewEdiFact();
            using (var ediReader = new EdiTextReader(new StreamReader(Helpers.StreamFromString("DTM+ZZZ'DTM+ZZ1'")), grammar)) {
                ediReader.Read();
                ediReader.Read();
                ediReader.Read();
                ediReader.Read(); // move to component
                var number = ediReader.ReadAsInt32();
                Assert.Null(number);
                ediReader.Read();
                ediReader.Read();
                ediReader.Read();
                ediReader.Read(); // move to component;
                var number2 = ediReader.ReadAsInt32();
                Assert.Equal(1, number2.Value);
            }
        }

        [Fact]
        [Trait(Traits.Tag, "EDIFact")]
        public void EdiFact_D95B_CUSCAR_Test() {
            var grammar = EdiGrammar.NewEdiFact();

            var interchange = default(Interchange_D95B_CUSCAR);
            using (var stream = Helpers.GetResourceStream("edifact.D95B.CUSCAR.EDI")) {
                interchange = new EdiSerializer().Deserialize<Interchange_D95B_CUSCAR>(new StreamReader(stream), grammar);
            }

            //Interchange header
            Assert.Equal("UNOA", interchange.Header_Field1a);
            Assert.Equal("1", interchange.Header_Field1b);
            Assert.Equal("MSC", interchange.Header_Field2);
            Assert.Equal("ECA", interchange.Header_Field3);
            Assert.Equal("20170119", interchange.Header_Field4a);
            Assert.Equal("1010", interchange.Header_Field4b);
            Assert.Equal("20170119101016", interchange.Header_Field5);


            //Message header info
            Assert.NotNull(interchange.Message);
            Assert.Equal("201701191AB652", interchange.Message.Field1);
            Assert.Null(interchange.Message.Field2a);
            Assert.Equal("D", interchange.Message.Field2b);
            Assert.Equal("95B", interchange.Message.Field2c);
            Assert.Equal("UN", interchange.Message.Field2d);


            //BGM - Begging of message
            Assert.Equal("85", interchange.Message.BGM.Field1);
            Assert.Equal("201701191AB652", interchange.Message.BGM.Field2);
            Assert.Equal("9", interchange.Message.BGM.Field3);


            Assert.Equal("137", interchange.Message.DTM.Field1a);
            Assert.Equal("20170119", interchange.Message.DTM.Field1b);
            Assert.Equal("102", interchange.Message.DTM.Field1c);

            //NAD - Name And Addresses
            Assert.Equal("MS", interchange.Message.NAD.Field1);
            Assert.Equal("202487288", interchange.Message.NAD.Field2a);
            Assert.Equal("172", interchange.Message.NAD.Field2b);
            Assert.Equal("166", interchange.Message.NAD.Field2c);
            Assert.Equal("MSC", interchange.Message.NAD.Field3);

            //Grou 1 - TDT Details of transport
            Assert.NotNull(interchange.Message.TDT_Group1);
            Assert.Single(interchange.Message.TDT_Group1);

            Assert.Equal("20", interchange.Message.TDT_Group1[0].Field1);
            Assert.Equal("AB652A", interchange.Message.TDT_Group1[0].Field2);
            Assert.Equal("1", interchange.Message.TDT_Group1[0].Field3);
            Assert.Null(interchange.Message.TDT_Group1[0].Field4);
            Assert.Equal("MSC", interchange.Message.TDT_Group1[0].Field5a);
            Assert.Equal("172", interchange.Message.TDT_Group1[0].Field5b);
            Assert.Equal("166", interchange.Message.TDT_Group1[0].Field5c);
            Assert.Equal("MSC SENA", interchange.Message.TDT_Group1[0].Field5d);
            Assert.Null(interchange.Message.TDT_Group1[0].Field6);
            Assert.Null(interchange.Message.TDT_Group1[0].Field7a);
            Assert.Null(interchange.Message.TDT_Group1[0].Field7b);
            Assert.Equal("202487288", interchange.Message.TDT_Group1[0].Field7c);
            Assert.Equal("D5LQ7", interchange.Message.TDT_Group1[0].Field8a);
            Assert.Equal("146", interchange.Message.TDT_Group1[0].Field8b);
            Assert.Equal("14", interchange.Message.TDT_Group1[0].Field8c);
            Assert.Null(interchange.Message.TDT_Group1[0].Field8d);
            Assert.Equal("EG", interchange.Message.TDT_Group1[0].Field8e);

            //Group 1 - LOC Place/location identification
            Assert.NotNull(interchange.Message.TDT_Group1[0].LOC);
            Assert.Single(interchange.Message.TDT_Group1[0].LOC);
            Assert.Equal("60", interchange.Message.TDT_Group1[0].LOC[0].Field1);
            Assert.Equal("EGEDK", interchange.Message.TDT_Group1[0].LOC[0].Field2a);
            Assert.Equal("139", interchange.Message.TDT_Group1[0].LOC[0].Field2b);
            Assert.Null(interchange.Message.TDT_Group1[0].LOC[0].Field2c);
            Assert.Equal("El Dekheila", interchange.Message.TDT_Group1[0].LOC[0].Field2d);

            //Group 1 - DTM Date/time/period
            Assert.NotNull(interchange.Message.TDT_Group1[0].DTM);
            Assert.Equal(2, interchange.Message.TDT_Group1[0].DTM.Count());

            Assert.Equal("132", interchange.Message.TDT_Group1[0].DTM[0].Field1a);
            Assert.Equal("1701290000", interchange.Message.TDT_Group1[0].DTM[0].Field1b);
            Assert.Equal("201", interchange.Message.TDT_Group1[0].DTM[0].Field1c);
            Assert.Equal("137", interchange.Message.TDT_Group1[0].DTM[1].Field1a);
            Assert.Equal("20170110", interchange.Message.TDT_Group1[0].DTM[1].Field1b);
            Assert.Equal("102", interchange.Message.TDT_Group1[0].DTM[1].Field1c);


            //Group 4 - CNI
            Assert.NotNull(interchange.Message.CNI_Group4);
            Assert.Equal(2, interchange.Message.CNI_Group4.Count());

            //CNI Segment 1
            Assert.Equal("1", interchange.Message.CNI_Group4[0].Field1);
            Assert.Equal("MSCUXP080935", interchange.Message.CNI_Group4[0].Field2);

            Assert.Equal("AAA", interchange.Message.CNI_Group4[0].RFF_Group5[0].Field1);
            Assert.Equal("MSCUDB592345", interchange.Message.CNI_Group4[0].RFF_Group5[0].Field2);
            Assert.Equal("9", interchange.Message.CNI_Group4[0].RFF_Group5[0].LOC[0].Field1);
            Assert.Equal("IEDUB", interchange.Message.CNI_Group4[0].RFF_Group5[0].LOC[0].Field2a);
            Assert.Equal("139", interchange.Message.CNI_Group4[0].RFF_Group5[0].LOC[0].Field2b);
            Assert.Null(interchange.Message.CNI_Group4[0].RFF_Group5[0].LOC[0].Field2c);
            Assert.Null(interchange.Message.CNI_Group4[0].RFF_Group5[0].LOC[0].Field2d);

            Assert.Equal("11", interchange.Message.CNI_Group4[0].RFF_Group5[0].LOC[1].Field1);
            Assert.Equal("EGEDK", interchange.Message.CNI_Group4[0].RFF_Group5[0].LOC[1].Field2a);
            Assert.Equal("139", interchange.Message.CNI_Group4[0].RFF_Group5[0].LOC[1].Field2b);
            Assert.Null(interchange.Message.CNI_Group4[0].RFF_Group5[0].LOC[1].Field2c);
            Assert.Null(interchange.Message.CNI_Group4[0].RFF_Group5[0].LOC[1].Field2d);


            Assert.Equal("CZ", interchange.Message.CNI_Group4[0].RFF_Group5[0].NAD[0].Field1);
            Assert.Null(interchange.Message.CNI_Group4[0].RFF_Group5[0].NAD[0].Field2a);
            Assert.Null(interchange.Message.CNI_Group4[0].RFF_Group5[0].NAD[0].Field2b);
            Assert.Null(interchange.Message.CNI_Group4[0].RFF_Group5[0].NAD[0].Field2c);
            Assert.Equal("LAKELAND DAIRIES,", interchange.Message.CNI_Group4[0].RFF_Group5[0].NAD[0].Field3);

            Assert.Equal("CN", interchange.Message.CNI_Group4[0].RFF_Group5[0].NAD[1].Field1);
            Assert.Null(interchange.Message.CNI_Group4[0].RFF_Group5[0].NAD[1].Field2a);
            Assert.Null(interchange.Message.CNI_Group4[0].RFF_Group5[0].NAD[1].Field2b);
            Assert.Null(interchange.Message.CNI_Group4[0].RFF_Group5[0].NAD[1].Field2c);
            Assert.Equal("FRONERI ICE CREAM EGYPT", interchange.Message.CNI_Group4[0].RFF_Group5[0].NAD[1].Field3);

            Assert.Equal("N1", interchange.Message.CNI_Group4[0].RFF_Group5[0].NAD[2].Field1);
            Assert.Null(interchange.Message.CNI_Group4[0].RFF_Group5[0].NAD[2].Field2a);
            Assert.Null(interchange.Message.CNI_Group4[0].RFF_Group5[0].NAD[2].Field2b);
            Assert.Null(interchange.Message.CNI_Group4[0].RFF_Group5[0].NAD[2].Field2c);
            Assert.Equal("FRONERI ICE CREAM EGYPT", interchange.Message.CNI_Group4[0].RFF_Group5[0].NAD[2].Field3);


            Assert.Equal("1", interchange.Message.CNI_Group4[0].RFF_Group5[0].GID_Group10[0].Field1);
            Assert.Equal("560", interchange.Message.CNI_Group4[0].RFF_Group5[0].GID_Group10[0].Field2a);
            Assert.Equal("BG", interchange.Message.CNI_Group4[0].RFF_Group5[0].GID_Group10[0].Field2b);


            Assert.Equal("2", interchange.Message.CNI_Group4[0].RFF_Group5[0].GID_Group10[1].Field1);
            Assert.Equal("880", interchange.Message.CNI_Group4[0].RFF_Group5[0].GID_Group10[1].Field2a);
            Assert.Equal("BG", interchange.Message.CNI_Group4[0].RFF_Group5[0].GID_Group10[1].Field2b);


            Assert.Equal("1", interchange.Message.CNI_Group4[0].RFF_Group5[0].GID_Group10[0].Field1);
            Assert.Equal("560", interchange.Message.CNI_Group4[0].RFF_Group5[0].GID_Group10[0].Field2a);
            Assert.Equal("BG", interchange.Message.CNI_Group4[0].RFF_Group5[0].GID_Group10[0].Field2b);

            Assert.Equal("AAA", interchange.Message.CNI_Group4[0].RFF_Group5[0].GID_Group10[0].FTX.Field1);
            Assert.Equal("36 METRIC TONNES MILK SKIMMED POWDER LH HALAL 25KGS NO OF BAGS:1440 X", interchange.Message.CNI_Group4[0].RFF_Group5[0].GID_Group10[0].FTX.Field4a);
            Assert.Equal(" 25KGS NETT WEIGHT :36000.00KGS GROSS WEIGHT:36468.00KGS TOTAL VGM W", interchange.Message.CNI_Group4[0].RFF_Group5[0].GID_Group10[0].FTX.Field4b);
            Assert.Equal("EIGHT: 42488.00KGS GROSS CARGO WEIGHT IS EQUAL TO GROSS WEIGHT FREIGH", interchange.Message.CNI_Group4[0].RFF_Group5[0].GID_Group10[0].FTX.Field4c);
            Assert.Equal("T COLLECT 28 DAYS FREE DEMURRAGE", interchange.Message.CNI_Group4[0].RFF_Group5[0].GID_Group10[0].FTX.Field4d);

            Assert.Equal("AAE", interchange.Message.CNI_Group4[0].RFF_Group5[0].GID_Group10[0].MEA[0].Field1);

            Assert.Equal("FCIU5956299", interchange.Message.CNI_Group4[0].RFF_Group5[0].GID_Group10[0].SPG.Field1);



            //CNI Segment 2
            Assert.Equal("2", interchange.Message.CNI_Group4[1].Field1);
            Assert.Equal("MSCUEK569969", interchange.Message.CNI_Group4[1].Field2);

            Assert.Equal("BM", interchange.Message.CNI_Group4[1].RFF_Group5[0].Field1);
            Assert.Equal("MSCUEK569969", interchange.Message.CNI_Group4[1].RFF_Group5[0].Field2);

            Assert.Equal("9", interchange.Message.CNI_Group4[1].RFF_Group5[0].LOC[0].Field1);
            Assert.Equal("SGSIN", interchange.Message.CNI_Group4[1].RFF_Group5[0].LOC[0].Field2a);
            Assert.Equal("139", interchange.Message.CNI_Group4[1].RFF_Group5[0].LOC[0].Field2b);
            Assert.Null(interchange.Message.CNI_Group4[1].RFF_Group5[0].LOC[0].Field2c);
            Assert.Null(interchange.Message.CNI_Group4[1].RFF_Group5[0].LOC[0].Field2d);

            Assert.Equal("11", interchange.Message.CNI_Group4[1].RFF_Group5[0].LOC[1].Field1);
            Assert.Equal("EGALY", interchange.Message.CNI_Group4[1].RFF_Group5[0].LOC[1].Field2a);
            Assert.Equal("139", interchange.Message.CNI_Group4[1].RFF_Group5[0].LOC[1].Field2b);
            Assert.Null(interchange.Message.CNI_Group4[1].RFF_Group5[0].LOC[1].Field2c);
            Assert.Null(interchange.Message.CNI_Group4[1].RFF_Group5[0].LOC[1].Field2d);

            Assert.Equal("8", interchange.Message.CNI_Group4[1].RFF_Group5[0].LOC[2].Field1);
            Assert.Null(interchange.Message.CNI_Group4[1].RFF_Group5[0].LOC[2].Field2a);
            Assert.Equal("139", interchange.Message.CNI_Group4[1].RFF_Group5[0].LOC[2].Field2b);
            Assert.Null(interchange.Message.CNI_Group4[1].RFF_Group5[0].LOC[2].Field2c);
            Assert.Null(interchange.Message.CNI_Group4[1].RFF_Group5[0].LOC[2].Field2d);

            Assert.Equal("80", interchange.Message.CNI_Group4[1].RFF_Group5[0].LOC[3].Field1);
            Assert.Equal("SG", interchange.Message.CNI_Group4[1].RFF_Group5[0].LOC[3].Field2a);
            Assert.Equal("139", interchange.Message.CNI_Group4[1].RFF_Group5[0].LOC[3].Field2b);
            Assert.Null(interchange.Message.CNI_Group4[1].RFF_Group5[0].LOC[3].Field2c);
            Assert.Null(interchange.Message.CNI_Group4[1].RFF_Group5[0].LOC[3].Field2d);

            Assert.Equal("28", interchange.Message.CNI_Group4[1].RFF_Group5[0].LOC[4].Field1);
            Assert.Null(interchange.Message.CNI_Group4[1].RFF_Group5[0].LOC[4].Field2a);
            Assert.Equal("139", interchange.Message.CNI_Group4[1].RFF_Group5[0].LOC[4].Field2b);
            Assert.Null(interchange.Message.CNI_Group4[1].RFF_Group5[0].LOC[4].Field2c);
            Assert.Null(interchange.Message.CNI_Group4[1].RFF_Group5[0].LOC[4].Field2d);



            Assert.Equal("CZ", interchange.Message.CNI_Group4[1].RFF_Group5[0].NAD[0].Field1);
            Assert.Null(interchange.Message.CNI_Group4[1].RFF_Group5[0].NAD[0].Field2a);
            Assert.Null(interchange.Message.CNI_Group4[1].RFF_Group5[0].NAD[0].Field2b);
            Assert.Null(interchange.Message.CNI_Group4[1].RFF_Group5[0].NAD[0].Field2c);
            Assert.Equal("BPI A/S", interchange.Message.CNI_Group4[1].RFF_Group5[0].NAD[0].Field3);

            Assert.Equal("CN", interchange.Message.CNI_Group4[1].RFF_Group5[0].NAD[1].Field1);
            Assert.Null(interchange.Message.CNI_Group4[1].RFF_Group5[0].NAD[1].Field2a);
            Assert.Null(interchange.Message.CNI_Group4[1].RFF_Group5[0].NAD[1].Field2b);
            Assert.Null(interchange.Message.CNI_Group4[1].RFF_Group5[0].NAD[1].Field2c);
            Assert.Equal("TO ORDER", interchange.Message.CNI_Group4[1].RFF_Group5[0].NAD[1].Field3);

            Assert.Equal("N1", interchange.Message.CNI_Group4[1].RFF_Group5[0].NAD[2].Field1);
            Assert.Null(interchange.Message.CNI_Group4[1].RFF_Group5[0].NAD[2].Field2a);
            Assert.Null(interchange.Message.CNI_Group4[1].RFF_Group5[0].NAD[2].Field2b);
            Assert.Null(interchange.Message.CNI_Group4[1].RFF_Group5[0].NAD[2].Field2c);
            Assert.Equal("EL IMAN COMPANY FOR TRADING EXPORT AND IMPORT (SAAD AND MOHAMED ELFAR)", interchange.Message.CNI_Group4[1].RFF_Group5[0].NAD[2].Field3);


            Assert.Equal("1", interchange.Message.CNI_Group4[1].RFF_Group5[0].GID_Group10[0].Field1);
            Assert.Equal("699", interchange.Message.CNI_Group4[1].RFF_Group5[0].GID_Group10[0].Field2a);
            Assert.Equal("BG", interchange.Message.CNI_Group4[1].RFF_Group5[0].GID_Group10[0].Field2b);

            Assert.Equal("AAA", interchange.Message.CNI_Group4[1].RFF_Group5[0].GID_Group10[0].FTX.Field1);

            Assert.Equal("AAE", interchange.Message.CNI_Group4[1].RFF_Group5[0].GID_Group10[0].MEA[0].Field1);

            Assert.Equal("FCIU2469131", interchange.Message.CNI_Group4[1].RFF_Group5[0].GID_Group10[0].SPG.Field1);

            //Interchange trailer
            Assert.Equal(1, interchange.Trailer_Field1);
            Assert.Equal("20170119101016", interchange.Trailer_Field2);
        }

        [Fact]
        [Trait(Traits.Tag, "EDIFact")]
        [Trait(Traits.Issue, "#35")]
        [Trait(Traits.Issue, "#42")]
        public void EdiFact_ORDRSP_Test() {
            var grammar = EdiGrammar.NewEdiFact();

            var interchange = default(Interchange_ORDRSP);
            using (var stream = Helpers.GetResourceStream("edifact.ORDRSP-formatted.edi")) {
                interchange = new EdiSerializer().Deserialize<Interchange_ORDRSP>(new StreamReader(stream), grammar);
            }

            Assert.Equal(2, interchange.Message.IMD_List.Count);
            Assert.NotNull(interchange.Message.IMD_Other);

            Assert.Null(interchange.Message.IMD_List[0].FieldA);
            Assert.Equal("Z01", interchange.Message.IMD_List[0].FieldB);
            Assert.Null(interchange.Message.IMD_List[0].FieldC);

            Assert.Null(interchange.Message.IMD_List[1].FieldA);
            Assert.Equal("Z10", interchange.Message.IMD_List[1].FieldB);
            Assert.Null(interchange.Message.IMD_List[1].FieldC);

            Assert.Null(interchange.Message.IMD_Other.FieldA);
            Assert.Equal("Z14", interchange.Message.IMD_Other.FieldB);
            Assert.Equal("Z07", interchange.Message.IMD_Other.FieldC);
        }

        [Fact]
        [Trait(Traits.Tag, "X12")]
        [Trait(Traits.Tag, "810")]
        [Trait(Traits.Issue, "#83")]
        public void X12_810_MandatoryConditions_Test() {
            var grammar = EdiGrammar.NewX12();

            var interchange = default(Invoice_810);
            using (var stream = Helpers.GetResourceStream("x12.810.mandatory-conditions.edi")) {
                interchange = new EdiSerializer().Deserialize<Invoice_810>(new StreamReader(stream), grammar);
            }

            Assert.NotNull(interchange.Groups[0].Invoice.TotalOutstandingBalance);
            Assert.NotNull(interchange.Groups[0].Invoice.TotalPaymentsAndRefunds);
            Assert.Equal(5.55M, interchange.Groups[0].Invoice.TotalPaymentsAndRefunds.Value);
            Assert.Equal(3.33M, interchange.Groups[0].Invoice.TotalOutstandingBalance.Value);
            Assert.Equal(6.66M, interchange.Groups[0].Invoice.PriorBalance.Value);
        }

        [Fact]
        [Trait(Traits.Tag, "X12")]
        [Trait(Traits.Issue, "#88")]
        public void X12_Stack_Empty_InvalidOp_Exception() {
            var grammar = EdiGrammar.NewX12();

            var interchange = default(Interchange_Issue88);
            using (var stream = Helpers.GetResourceStream("x12.Issue88.edi")) {
                interchange = new EdiSerializer().Deserialize<Interchange_Issue88>(new StreamReader(stream), grammar);
            }

            Assert.Equal(1, interchange.TrailerControlNumber);
        }

        [Fact]
        [Trait(Traits.Tag, "X12")]
        [Trait(Traits.Issue, "#91")]
        public void X12_SegmentGroups_Nesting_SameSegment() {
            var grammar = EdiGrammar.NewX12();

            var interchange = default(Interchange_Issue91);
            using (var stream = Helpers.GetResourceStream("x12.Issue91.edi")) {
                interchange = new EdiSerializer().Deserialize<Interchange_Issue91>(new StreamReader(stream), grammar);
            }
            Assert.Equal(2, interchange.Msg.Foos.Count);
            Assert.Equal("TOM", interchange.Msg.Foos[0].Name);
            Assert.NotNull(interchange.Msg.Foos[0].Bars);
            Assert.Equal(2, interchange.Msg.Foos[0].Bars.Count);
            Assert.Equal(123, interchange.Msg.Foos[0].Bars[0].Amount);
            Assert.Equal(456, interchange.Msg.Foos[0].Bars[1].Amount);
            Assert.Equal("TIM", interchange.Msg.Foos[1].Name);
            Assert.Single(interchange.Msg.Foos[1].Bars);
            Assert.Equal(125, interchange.Msg.Foos[1].Bars[0].Amount);
        }

        [Fact]
        [Trait(Traits.Tag, "EDIFact")]
        [Trait(Traits.Issue, "#98")]
        public void EDIFact_SegmentGroups_Weird_Group_Behaviour() {
            var grammar = EdiGrammar.NewEdiFact();

            var interchange = default(Interchange_Issue98);
            using (var stream = Helpers.GetResourceStream("edifact.Issue98.edi")) {
                interchange = new EdiSerializer().Deserialize<Interchange_Issue98>(new StreamReader(stream), grammar);
            }

            Assert.Equal("3210987654321", interchange.Message.Buyer.PartyIdentifier);
            Assert.Equal(2, interchange.Message.Buyer.References.Count);
        }

        [Fact]
        [Trait(Traits.Tag, "X12")]
        [Trait(Traits.Issue, "#101")]
        public void X12_EndMessage_Mapping() {
            var grammar = EdiGrammar.NewX12();

            var interchange = default(Interchange_Issue101);
            using (var stream = Helpers.GetResourceStream("x12.Issue101.edi")) {
                interchange = new EdiSerializer().Deserialize<Interchange_Issue101>(new StreamReader(stream), grammar);
            }

            Assert.NotNull(interchange.Msg.Return);
            var rtn = interchange.Msg.Return;
            Assert.Equal("12345", rtn.FormGroupSegment.Id);
            Assert.NotNull(rtn.FormGroupSegment.DateSegment);
            Assert.Equal(new DateTime(2018, 5, 25), rtn.FormGroupSegment.DateSegment.Date);
            Assert.Equal("0012", interchange.Msg.HeaderControl);
            Assert.Equal(interchange.Msg.HeaderControl, interchange.Msg.TrailerControl);
        }

        [Fact]
        [Trait(Traits.Tag, "Tradacoms")]
        [Trait(Traits.Issue, "#103")]
        public void Tradacoms_ProductPlanning_SampleTest() {
            var grammar = EdiGrammar.NewTradacoms();

            var interchange = default(PPRHDR);
            using (var stream = Helpers.GetResourceStream("tradacoms.productplanning.edi")) {
                interchange = new EdiSerializer().Deserialize<PPRHDR>(new StreamReader(stream), grammar);
            }

            Assert.NotNull(interchange.Detail);
            Assert.Equal(2, interchange.Detail.ProductRows.Count);
            Assert.Equal(4, interchange.Detail.ProductRows[0].PosRows.Count);
            Assert.Equal(3, interchange.Detail.ProductRows[1].PosRows.Count);
        }

        [Fact, Trait(Traits.Tag, "EDIFact"), Trait(Traits.Issue, "#110")]
        public void SegmentGroup_Close_logic_Should_Iterate_Over_Parents() {
            var grammar = EdiGrammar.NewEdiFact();
            var interchange = default(EDIFact_D01B_IFCSUM);
            using (var stream = Helpers.GetResourceStream("edifact.D01B.IFCSUM.EDI")) {
                interchange = new EdiSerializer().Deserialize<EDIFact_D01B_IFCSUM>(new StreamReader(stream), grammar);
            }

            Assert.Equal(2, interchange.Messages[0].Consignments[0].Goods.Count);
        }

        [Fact, Trait(Traits.Tag, "EDIFact"), Trait(Traits.Issue, "#24"), Trait(Traits.Issue, "#19")]
        public void EdiTextReader_NewLine_Terminator_support() {
            var grammar = EdiGrammar.NewEdiFact();
            grammar.SetAdvice(new[] {':', '+', '.', '?', ' ', '\n'});
            var interchange = default(EDIFact_D01B_IFCSUM);
            using (var stream = Helpers.GetResourceStream("edifact.D01B.IFCSUM.NewLines.EDI")) {
                interchange = new EdiSerializer().Deserialize<EDIFact_D01B_IFCSUM>(new StreamReader(stream), grammar);
            }

            Assert.Equal(2, interchange.Messages[0].Consignments[0].Goods.Count);
        }

        [Fact, Trait(Traits.Tag, "EDIFact"), Trait(Traits.Issue, "#24"), Trait(Traits.Issue, "#19")]
        public void EdiTextReader_NewLine_Terminator_CardridgeReturn_ShouldbeIgnored() {

            var getInput = new Func<string, StringBuilder>((terminator) => {
                var input = new StringBuilder();
                input.Append($"UNB+UNOA:1+5011408000007:14+5999999999952:14+180525:2030+2216+PASSWORD+IFCSUM{terminator}");
                input.Append($"UNH+1+IFCSUM:D:01B:UN:EAN003{terminator}");
                input.Append($"BGM+610+1000505549+9{terminator}");
                input.Append($"DTM+137:20180525:102{terminator}");
                input.Append($"DTM+11:20180525:102{terminator}");
                input.Append($"CNT+10:5{terminator}");
                input.Append($"CNT+7:25.784:KG{terminator}");
                input.Append($"NAD+CZ+5011408000007.::9+UK2.{terminator}");
                input.Append($"NAD+CA+5999999999950::9{terminator}");
                input.Append($"TDT+20++10:SEA{terminator}");
                input.Append($"CNI+1+311447177::I{terminator}");
                input.Append($"DTM+2:201805290000:203{terminator}");
                input.Append($"CNT+2:64:PA{terminator}");
                input.Append($"CNT+11:1:PA{terminator}");
                input.Append($"CNT+7:8.269:KG{terminator}");
                input.Append($"TSR+3+++11{terminator}");
                input.Append($"NAD+DP+PC+1919990312{terminator}");
                input.Append($"RFF+DQ:5000706244{terminator}");
                input.Append($"RFF+CR:TUESDAY 29TH MAY{terminator}");
                input.Append($"GID+1+:350114081527920321:1:9+1:3600530124848:PK:9{terminator}");
                input.Append($"PIA+1+B0918306:::91{terminator}");
                input.Append($"FTX+AAA+++MAYB NAIL ForeverStrong 06 DeepRed 12{terminator}");
                input.Append($"MEA+AAE+UCO:4+UN:3{terminator}");
                input.Append($"GID+2+:350114081527920321:1:9+1:3600530521845:PK:9{terminator}");
                input.Append($"PIA+1+B1297005:::91{terminator}");
                input.Append($"FTX+AAA+++MAYB Found. Dream Satin Liquid Sand 30{terminator}");
                input.Append($"MEA+AAE+UCO:4+UN:3{terminator}");
                input.Append($"UNT+787+1{terminator}");
                input.Append($"UNZ+1+2216{terminator}");
                return input;
            });
            var grammar = EdiGrammar.NewEdiFact();
            grammar.SetAdvice(new[] {':', '+', '.', '?', ' ', '\r'});
            var interchange = default(EDIFact_D01B_IFCSUM);
            using (var stream = new MemoryStream(Encoding.UTF8.GetBytes(getInput("\r\n").ToString()))) {
                interchange = new EdiSerializer().Deserialize<EDIFact_D01B_IFCSUM>(new StreamReader(stream), grammar);
            }
            Assert.Equal(2, interchange.Messages[0].Consignments[0].Goods.Count);
            grammar.SetAdvice(new[] {':', '+', '.', '?', ' ', '\''});
            using (var stream = new MemoryStream(Encoding.UTF8.GetBytes(getInput("'\r\n").ToString()))) {
                interchange = new EdiSerializer().Deserialize<EDIFact_D01B_IFCSUM>(new StreamReader(stream), grammar);
            }
            Assert.Equal(2, interchange.Messages[0].Consignments[0].Goods.Count);
            //var output = new StringBuilder();
            //using (var writer = new EdiTextWriter(new StringWriter(output), grammar)) {
            //    new EdiSerializer().Serialize(writer, interchange);
            //}
            //Assert.Equal(input.ToString(), output.ToString());
        }


        [Fact, Trait(Traits.Tag, "X12"), Trait(Traits.Issue, "#122")]
        public void X12_832_PriceSalesCatalogs() {
            var grammar = EdiGrammar.NewX12();
            var interchange = default(X12_832_PriceScalesCatalog);
            using (var stream = Helpers.GetResourceStream("x12.832.edi")) {
                interchange = new EdiSerializer().Deserialize<X12_832_PriceScalesCatalog>(new StreamReader(stream), grammar);
            }
            Assert.Equal(2, interchange.ItemDetails.Count);
            Assert.Equal(3, interchange.ItemDetails[0].Descriptions.Count);
            Assert.Equal('S', interchange.ItemDetails[0].Descriptions[0].ItemDescriptionType);
        }

        [Fact, Trait(Traits.Tag, "EDIFact"), Trait(Traits.Issue, "#121")]
        public void EdiFact_ElementList() {
            var grammar = EdiGrammar.NewEdiFact();
            var interchange = default(EdiFact_Issue121_ElementList);
            using (var stream = Helpers.GetResourceStream("edifact.Issue121.ElementList.edi")) {
                interchange = new EdiSerializer().Deserialize<EdiFact_Issue121_ElementList>(new StreamReader(stream), grammar);
            }
            Assert.Equal(3, interchange.Msg.Attributes.Count);
            Assert.Equal(6, interchange.Msg.Attributes[2].Infos.Count);
            Assert.Equal("PRIL", interchange.Msg.Attributes[2].Infos[5].Code);
            Assert.Equal("N", interchange.Msg.Attributes[2].Infos[5].Value);
        }


        [Fact, Trait(Traits.Tag, "EDIFact"), Trait(Traits.Issue, "#121")]
        public void EdiFact_ElementList_WithConditions() {
            var grammar = EdiGrammar.NewEdiFact();
            var interchange = default(EdiFact_Issue121_ElementList_Conditions);
            using (var stream = Helpers.GetResourceStream("edifact.Issue121.ElementList.Conditions.edi")) {
                interchange = new EdiSerializer().Deserialize<EdiFact_Issue121_ElementList_Conditions>(new StreamReader(stream), grammar);
            }
            Assert.Equal(3, interchange.Msg.Attributes.Count);
            Assert.Equal(6, interchange.Msg.Attributes[2].Infos.Count);
            Assert.Equal("PRIL", interchange.Msg.Attributes[2].Infos[5].Code);
            Assert.Equal("N", interchange.Msg.Attributes[2].Infos[5].Value);
            Assert.Single(interchange.Msg.Attributes1);
            Assert.Equal(2, interchange.Msg.Attributes1[0].Infos.Count);
            Assert.Equal("V", interchange.Msg.Attributes1[0].Infos[1].Code);
            Assert.Equal("�2", interchange.Msg.Attributes1[0].LTS.Value);
        }


        [Fact, Trait(Traits.Tag, "X12"), Trait(Traits.Issue, "#135")]
        public void X12_DTM_Should_not_be_empty() {
            var grammar = EdiGrammar.NewX12();
            var interchange = default(PurchaseOrder_850);
            using (var stream = Helpers.GetResourceStream("x12.850.issue135.edi")) {
                interchange = new EdiSerializer().Deserialize<PurchaseOrder_850>(new StreamReader(stream), grammar);
            }
            Assert.NotNull(interchange.Groups[0].Orders[0].Items[0].DeliveryRequestedDate);
            Assert.NotNull(interchange.Groups[0].Orders[0].Items[0].ShipNoLaterDate);
        }

        [Fact, Trait(Traits.Tag, "EDIFact"), Trait(Traits.Issue, "#137")]
        public void DeserializingMessage_without_Interchange() {
            var grammar = EdiGrammar.NewEdiFact();
            var message = default(Message_D95B);
            using (var stream = Helpers.GetResourceStream("edifact.D95B.Issue137.EDI")) {
                message = new EdiSerializer().Deserialize<Message_D95B>(new StreamReader(stream), grammar);
            }
            Assert.NotNull(message);
        }

        [Fact, Trait(Traits.Tag, "X12"), Trait(Traits.Issue, "#140")]
        public void Parsing_820_throws_an_error_at_GS() {
            var grammar = EdiGrammar.NewX12();
            grammar.SetAdvice('*', '*', '>', '\n', null, null, '.');
            var message = default(RemittanceAdvice_820);
            using (var stream = Helpers.GetResourceStream("x12.820.issue140.edi")) {
                message = new EdiSerializer().Deserialize<RemittanceAdvice_820>(new StreamReader(stream), grammar);
            }
            Assert.NotNull(message);
        }


        [Fact, Trait(Traits.Tag, "EDIFact"), Trait(Traits.Issue, "#152")]
        public void EmptySegment_Withought_A_segmentname_separator_should_parse() {
            var grammar = EdiGrammar.NewEdiFact();
            var interchange = default(EdiFact_Issue152_Wikipedia_Transmission);
            using (var stream = Helpers.GetResourceStream("edifact.Issue152.Wikipedia.edi")) {
                interchange = new EdiSerializer().Deserialize<EdiFact_Issue152_Wikipedia_Transmission>(new StreamReader(stream), grammar);
            }
            Assert.NotNull(interchange);
        }


        [Fact, Trait(Traits.Tag, "EDIFact"), Trait(Traits.Issue, "#157")]
        public void BadEscapeSequenseErrorCanbeSuppressed() {
            var grammar = EdiGrammar.NewEdiFact();
            var interchange = default(EdiFact_Issue152_Wikipedia_Transmission);
            using (var stream = Helpers.GetResourceStream("edifact.Issue157.Wikipedia.edi")) {
                interchange = new EdiSerializer() {
                    SuppressBadEscapeSequenceErrors = true
                }.Deserialize<EdiFact_Issue152_Wikipedia_Transmission>(new StreamReader(stream), grammar);
            }
            Assert.NotNull(interchange);
            Assert.Equal("XYZCOMPANY AVAILABILITY", interchange.AvailabilityRequest.Description[0].Text);
        }


        [Fact, Trait(Traits.Tag, "EDIFact"), Trait(Traits.Issue, "#170")]
        public void EdiFact_ElementList_PathAnnotation_ShouldWork_OnClass() {
            var grammar = EdiGrammar.NewEdiFact();
            var interchange = default(EdiFact_Issue170_ElementList);
            using (var stream = Helpers.GetResourceStream("edifact.Issue170.ElementList.edi")) {
                interchange = new EdiSerializer().Deserialize<EdiFact_Issue170_ElementList>(new StreamReader(stream), grammar);
            }
            Assert.Equal(3, interchange.Msg.InteractiveFreeTexts.Count);
            Assert.Equal(3, interchange.Msg.InteractiveFreeTexts[2].Texts.Count);
            Assert.Equal("This is the first", interchange.Msg.InteractiveFreeTexts[0].ToString());
            Assert.Equal("And this is the seccond", interchange.Msg.InteractiveFreeTexts[1].ToString());
            Assert.Equal("while this should come third", interchange.Msg.InteractiveFreeTexts[2].ToString());
        }

        [Fact]
        [Trait(Traits.Tag, "X12")]
        [Trait(Traits.Issue, "#172")]
        public void X12_SegmentGroups_Nesting_SameSegment_MultipleLevels() {
            var grammar = EdiGrammar.NewX12();

            var interchange = default(Interchange_Issue172);
            using (var stream = Helpers.GetResourceStream("x12.Issue172.edi")) {
                interchange = new EdiSerializer().Deserialize<Interchange_Issue172>(new StreamReader(stream), grammar);
            }
            Assert.Single(interchange.Msg.HighLevelNames);
            Assert.Equal("NAME 1", interchange.Msg.HighLevelNames[0].Name);
            Assert.Equal("ADDITIONAL NAME 1", interchange.Msg.HighLevelNames[0].OtherName.OtherName);

            Assert.NotNull(interchange.Msg.HighLevelNames[0].MidLevelNames);
            Assert.Equal(2, interchange.Msg.HighLevelNames[0].MidLevelNames.Count);
            Assert.Equal("NAME 2", interchange.Msg.HighLevelNames[0].MidLevelNames[0].Name);
            Assert.Equal("ADDITIONAL NAME 2", interchange.Msg.HighLevelNames[0].MidLevelNames[0].OtherName.OtherName);

            Assert.NotNull(interchange.Msg.HighLevelNames[0].MidLevelNames[0].LowLevelNames);
            Assert.Single(interchange.Msg.HighLevelNames[0].MidLevelNames[0].LowLevelNames);
            Assert.Equal("NAME 3", interchange.Msg.HighLevelNames[0].MidLevelNames[0].LowLevelNames[0].Name);
            Assert.Equal("ADDITIONAL NAME 3", interchange.Msg.HighLevelNames[0].MidLevelNames[0].LowLevelNames[0].OtherName.OtherName);

            Assert.Equal("NAME 4", interchange.Msg.HighLevelNames[0].MidLevelNames[1].Name);
            Assert.Equal("ADDITIONAL NAME 4", interchange.Msg.HighLevelNames[0].MidLevelNames[1].OtherName.OtherName);
        }

        [Fact, Trait(Traits.Tag, "EDIFact"), Trait(Traits.Issue, "#174")]
        public void EdiFact_Issue174() {
            var grammar = EdiGrammar.NewEdiFact();
            var interchange = default(Interchange_Issue174);
            using (var stream = Helpers.GetResourceStream("edifact.Issue174.edi")) {
                interchange = new EdiSerializer().Deserialize<Interchange_Issue174>(new StreamReader(stream), grammar);
            }
            Assert.Equal(3, interchange.Msg.VehicleRecord.GIR_List.Count);
        }

        [Fact]
        [Trait(Traits.Tag, "EDIFact"), Trait(Traits.Issue, "#188")]
        public void EdiFact_MissingPath_On_Condition_Doesnot_enter_InfiniteLoop_Issue188() {
            var grammar = EdiGrammar.NewEdiFact();
            var interchange = default(Models.Interchange_Issue188);
            using (var stream = Helpers.GetResourceStream("edifact.Issue188.edi")) {
                interchange = new EdiSerializer().Deserialize<Interchange_Issue188>(new StreamReader(stream), grammar);
            }
            // This test originally would eat all your memory.
            // There is a misconfiguration made in order to trigger the bug that makes the SearchForward function to enter into an infinite loop.
            // The correct configuration to change the Path on the two EdiCondition attributes to UNH/1/0, and it works.

            Assert.Equal(0, interchange.IftminMessages.Count);
        }

        [Fact]
        [Trait(Traits.Tag, "EDIFact"), Trait(Traits.Issue, "#203")]
        public void EdiFact_EdiCondition_how_to_Issue203() {
            var grammar = EdiGrammar.NewEdiFact();
            var interchange = default(Models.Edifact_Issue203);
            using (var stream = Helpers.GetResourceStream("edifact.Issue203.edi")) {
                interchange = new EdiSerializer().Deserialize<Models.Edifact_Issue203>(new StreamReader(stream), grammar);
            }
            //I want to create condition to check if TAX is already behind UNS

            Assert.NotNull(interchange.EDIFACT_INVOICS4);
            Assert.Equal(5, interchange.EDIFACT_INVOICS4.SG6.Count);
            Assert.Equal(1, interchange.EDIFACT_INVOICS4.UNS.SG52.Count);
        }

        [Fact]
        [Trait(Traits.Tag, "EDIFact"), Trait(Traits.Bug, "#196")]
        public void EdiFact_SameSegment_With_Condition_Issue196() {
            var grammar = EdiGrammar.NewEdiFact();
            var interchange = default(Models.EdiFact_Issue196_delfor);
            using (var stream = Helpers.GetResourceStream("edifact.Issue196.edi")) {
                interchange = new EdiSerializer().Deserialize<Models.EdiFact_Issue196_delfor>(new StreamReader(stream), grammar);
            }
            // Failing to deserialize when segments and segment group begin with the same segment and use condition.

            Assert.NotNull(interchange.Messages);
            Assert.Single(interchange.Messages);
            Assert.NotNull(interchange.Messages[0].BuyerData);
            Assert.Equal("BY", interchange.Messages[0].BuyerData.PartyQualifier);
            Assert.NotNull(interchange.Messages[0].InvoicePartyData);
            Assert.Equal("IV", interchange.Messages[0].InvoicePartyData.PartyQualifier);
            Assert.NotNull(interchange.Messages[0].SellerData);
            Assert.Equal("SE", interchange.Messages[0].SellerData.PartyQualifier);
            Assert.Single(interchange.Messages[0].Details);
            Assert.Equal("CN", interchange.Messages[0].Details[0].PartyQualifier);
        }

    }
}
