using System.ComponentModel;
using Edi.Domain.Shared.Attributes;

namespace Edi.Domain.Shared.Enums
{
    public enum FunctionalIdentifierCode
    {
        [Description("Account Analysis (822)")]
        [StringValue("AA")]
        AccountAnalysis,
        [Description("Logistics Service Request (219)")]
        [StringValue("AB")]
        LogisticsServiceRequest,
        [Description("Individual Life, Annuity and Disability Application (267)")]
        [StringValue("AD")]
        IndividualLifeAnnuityAndDisabilityApplication,
        [Description("Application for Admission to Educational Institutions (189)")]
        [StringValue("AF")]
        ApplicationForAdmissionToEducationalInstitutions,
        [Description("Application Advice (824)")]
        [StringValue("AG")]
        ApplicationAdvice,
        [Description("Logistics Service Response (220)")]
        [StringValue("AH")]
        LogisticsServiceResponse,
        [Description("Automotive Inspection Detail (928)")]
        [StringValue("AI")]
        AutomotiveInspectionDetail,
        [Description("Student Educational Record (Transcript) Acknowledgment (131)")]
        [StringValue("AK")]
        StudentEducationalRecordAcknowledgment,
        [Description("Set Cancellation (998) and Application Acceptance/Rejection Advice (499)")]
        [StringValue("AL")]
        SetCancellation,
        [Description("Return Merchandise Authorization and Notification (180)")]
        [StringValue("AN")]
        ReturnMerchandiseAuthorizationAndNotification,
        [Description("Income or Asset Offset (521)")]
        [StringValue("AO")]
        IncomeOrAssetOffset,
        [Description("Warehouse Stock Transfer Shipment Advice (943)")]
        [StringValue("AR")]
        WarehouseStockTransferShipmentAdvice,
        [Description("Transportation Appointment Schedule Information (163)")]
        [StringValue("AS")]
        TransportationAppointmentScheduleInformation,
        [Description("Animal Toxicological Data (249)")]
        [StringValue("AT")]
        AnimalToxicologicalData,
        [Description("Warehouse Inventory Adjustment Advice (947)")]
        [StringValue("AW")]
        WarehouseInventoryAdjustmentAdvice,
        [Description("Business Credit Report (155)")]
        [StringValue("BC")]
        BusinessCreditReport,
        [Description("Benefit Enrollment and Maintenance (834)")]
        [StringValue("BE")]
        BenefitEnrollmentAndMaintenance,
        [Description("Business Entity Filings (105)")]
        [StringValue("BF")]
        BusinessEntityFilings,
        [Description("Motor Carrier Bill of Lading (211)")]
        [StringValue("BL")]
        MotorCarrierBillOfLading,
        [Description("Shipment and Billing Notice (857)")]
        [StringValue("BS")]
        ShipmentAndBillingNotice,
        [Description("Purchase Order Change Acknowledgment/Request - Seller Initiated (865)")]
        [StringValue("CA")]
        PurchaseOrderChangeRequestAcknowledgment,
        [Description("Unemployment Insurance Tax Claim or Charge Information (153)")]
        [StringValue("CB")]
        UnemploymentInsuranceTaxClaimOrChargeInformation,
        [Description("Clauses and Provisions (504)")]
        [StringValue("CC")]
        ClausesAndProvisions,
        [Description("Credit/Debit Adjustment (812)")]
        [StringValue("CD")]
        CreditOrDebitAdjustment,
        [Description("Cartage Work Assignment (222)")]
        [StringValue("CE")]
        CartageWorkAssignment,
        [Description("Corporate Financial Adjustment Information (844 and 849)")]
        [StringValue("CF")]
        CorporateFinancialAdjustmentInformation,
        [Description("Administrative Message (994)")]
        [StringValue("CG")]
        AdministrativeMessage,
        [Description("Car Handling Information (420)")]
        [StringValue("CH")]
        CarHandlingInformation,
        [Description("Consolidated Service Invoice/Statement (811)")]
        [StringValue("CI")]
        ConsolidatedServiceInvoiceOrStatement,
        [Description("Manufacturer Coupon Family Code Structure (877)")]
        [StringValue("CJ")]
        ManufacturerCouponFamilyCodeStructure,
        [Description("Manufacturer Coupon Redemption Detail (881)")]
        [StringValue("CK")]
        ManufacturerCouponRedemptionDetail,
        [Description("Component Parts Content (871)")]
        [StringValue("CM")]
        ComponentPartsContent,
        [Description("Coupon Notification (887)")]
        [StringValue("CN")]
        CouponNotification,
        [Description("Cooperative Advertising Agreements (290)")]
        [StringValue("CO")]
        CooperativeAdvertisingAgreements,
        [Description("Electronic Proposal Information (251, 805)")]
        [StringValue("CP")]
        ElectronicProposalInformation,
        [Description("Rail Carhire Settlements (414)")]
        [StringValue("CR")]
        RailCarhireSettlements,
        [Description("Cryptographic Service Message (815)")]
        [StringValue("CS")]
        CryptographicServiceMessage,
        [Description("Application Control Totals (831)")]
        [StringValue("CT")]
        ApplicationControlTotals,
        [Description("Commercial Vehicle Safety and Credentials Information Exchange (285)")]
        [StringValue("CV")]
        CommercialVehicleSafetyAndCredentialsInformationExchange,
        [Description("Contract Completion Status (567)")]
        [StringValue("D3")]
        ContractCompletionStatus,
        [Description("Contract Abstract (561)")]
        [StringValue("D4")]
        ContractAbstract,
        [Description("Contract Payment Management Report (568)")]
        [StringValue("D5")]
        ContractPaymentManagementReport,
        [Description("Debit Authorization (828)")]
        [StringValue("DA")]
        DebitAuthorization,
        [Description("Shipment Delivery Discrepancy Information (854)")]
        [StringValue("DD")]
        ShipmentDeliveryDiscrepancyInformation,
        [Description("Market Development Fund Allocation (883)")]
        [StringValue("DF")]
        MarketDevelopmentFundAllocation,
        [Description("Dealer Information (128)")]
        [StringValue("DI")]
        DealerInformation,
        [Description("Shipper's Car Order (422)")]
        [StringValue("DM")]
        ShippersCarOrder,
        [Description("Data Status Tracking (242)")]
        [StringValue("DS")]
        DataStatusTracking,
        [Description("Direct Exchange Delivery and Return Information (894, 895)")]
        [StringValue("DX")]
        DirectExchangeDeliveryAndReturnInformation,
        [Description("Educational Course Inventory (188)")]
        [StringValue("EC")]
        EducationalCourseInventory,
        [Description("Student Educational Record (Transcript) (130)")]
        [StringValue("ED")]
        StudentEducationalRecord,
        [Description("Railroad Equipment Inquiry or Advice (456)")]
        [StringValue("EI")]
        RailroadEquipmentInquiryOrAdvice,
        [Description("Revenue Receipts Statement (170)")]
        [StringValue("ER")]
        RevenueReceiptsStatement,
        [Description("Notice of Employment Status (540)")]
        [StringValue("ES")]
        NoticeOfEmploymentStatus,
        [Description("Railroad Event Report (451)")]
        [StringValue("EV")]
        RailroadEventReport,
        [Description("Excavation Communication (620)")]
        [StringValue("EX")]
        ExcavationCommunication,
        [Description("Functional Acknowledgment (997)")]
        [StringValue("FA")]
        FunctionalAcknowledgment,
        [Description("Freight Invoice (859)")]
        [StringValue("FB")]
        FreightInvoice,
        [Description("Court and Law Enforcement Information (175, 176)")]
        [StringValue("FC")]
        CourtAndLawEnforcementInformation,
        [Description("Motor Carrier Loading and Route Guide (217)")]
        [StringValue("FG")]
        MotorCarrierLoadingAndRouteGuide,
        [Description("Motor Carrier Tariff Information (218)")]
        [StringValue("FH")]
        MotorCarrierTariffInformation,
        [Description("Financial Reporting (821, 827)")]
        [StringValue("FR")]
        FinancialReporting,
        [Description("File Transfer (996)")]
        [StringValue("FT")]
        FileTransfer,
        [Description("Average Agreement Demurrage (423)")]
        [StringValue("GB")]
        AverageAgreementDemurrage,
        [Description("Damage Claim Transaction Sets (920, 924, 925, 926)")]
        [StringValue("GC")]
        DamageClaimTransactionSets,
        [Description("General Request, Response or Confirmation (814)")]
        [StringValue("GE")]
        GeneralRequestResponseOrConfirmation,
        [Description("Response to a Load Tender (990)")]
        [StringValue("GF")]
        ResponseToALoadTender,
        [Description("Intermodal Group Loading Plan (715)")]
        [StringValue("GL")]
        IntermodalGroupLoadingPlan,
        [Description("Grocery Products Invoice (880)")]
        [StringValue("GP")]
        GroceryProductsInvoice,
        [Description("Statistical Government Information (152)")]
        [StringValue("GR")]
        StatisticalGovernmentInformation,
        [Description("Grant or Assistance Application (194)")]
        [StringValue("GT")]
        GrantOrAssistanceApplication,
        [Description("Eligibility, Coverage or Benefit Information (271)")]
        [StringValue("HB")]
        EligibilityCoverageOrBenefitInformation,
        [Description("Health Care Claim (837)")]
        [StringValue("HC")]
        HealthCareClaim,
        [Description("Health Care Services Review Information (278)")]
        [StringValue("HI")]
        HealthCareServicesReviewInformation,
        [Description("Health Care Claim Status Notification (277)")]
        [StringValue("HN")]
        HealthCareClaimStatusNotification,
        [Description("Health Care Claim Payment/Advice (835)")]
        [StringValue("HP")]
        HealthCareClaimPaymentOrAdvice,
        [Description("Health Care Claim Status Request (276)")]
        [StringValue("HR")]
        HealthCareClaimStatusRequest,
        [Description("Eligibility, Coverage or Benefit Inquiry (270)")]
        [StringValue("HS")]
        EligibilityCoverageOrBenefitInquiry,
        [Description("Air Freight Details and Invoice (110, 980)")]
        [StringValue("IA")]
        AirFreightDetailsAndInvoice,
        [Description("Inventory Inquiry/Advice (846)")]
        [StringValue("IB")]
        InventoryInquiryOrAdvice,
        [Description("Rail Advance Interchange Consist (418)")]
        [StringValue("IC")]
        RailAdvanceInterchangeConsist,
        [Description("Insurance/Annuity Application Status (273)")]
        [StringValue("ID")]
        InsuranceOrAnnuityApplicationStatus,
        [Description("Insurance Producer Administration (252)")]
        [StringValue("IE")]
        InsuranceProducerAdministration,
        [Description("Direct Store Delivery Summary Information (882)")]
        [StringValue("IG")]
        DirectStoreDeliverySummaryInformation,
        [Description("Rail Freight Details and Invoice Summary (411)")]
        [StringValue("II")]
        RailFreightDetailsAndInvoiceSummary,
        [Description("Report of Injury, Illness or Incident (148)")]
        [StringValue("IJ")]
        ReportOfInjuryIllnessOrIncident,
        [Description("Motor Carrier Freight Details and Invoice (210, 980)")]
        [StringValue("IM")]
        MotorCarrierFreightDetailsAndInvoice,
        [Description("Invoice Information (810,819)")]
        [StringValue("IN")]
        Invoice,
        [Description("Ocean Shipment Billing Details (310, 312, 980)")]
        [StringValue("IO")]
        OceanShipmentBillingDetails,
        [Description("Intermodal Ramp Activity (622)")]
        [StringValue("IP")]
        IntermodalRampActivity,
        [Description("Rail Carrier Freight Details and Invoice (410, 980)")]
        [StringValue("IR")]
        RailCarrierFreightDetailsAndInvoice,
        [Description("Estimated Time of Arrival and Car Scheduling (421)")]
        [StringValue("IS")]
        EstimatedTimeOfArrivalAndCarScheduling,
        [Description("Commercial Vehicle Credentials (286)")]
        [StringValue("KM")]
        CommercialVehicleCredentials,
        [Description("Federal Communications Commission (FCC) License Application (195)")]
        [StringValue("LA")]
        FederalCommunicationsCommission,
        [Description("Lockbox (823)")]
        [StringValue("LB")]
        Lockbox,
        [Description("Locomotive Information (436)")]
        [StringValue("LI")]
        LocomotiveInformation,
        [Description("Property and Casualty Loss Notification (272)")]
        [StringValue("LN")]
        PropertyAndCasualtyLossNotification,
        [Description("Logistics Reassignment (536)")]
        [StringValue("LR")]
        LogisticsReassignment,
        [Description("Asset Schedule (851)")]
        [StringValue("LS")]
        AssetSchedule,
        [Description("Student Loan Transfer and Status Verification (144)")]
        [StringValue("LT")]
        StudentLoanTransferAndStatusVerification,
        [Description("Motor Carrier Summary Freight Bill Manifest (224)")]
        [StringValue("MA")]
        MotorCarrierSummaryFreightBillManifest,
        [Description("Request for Motor Carrier Rate Proposal (107)")]
        [StringValue("MC")]
        RequestForMotorCarrierRateProposal,
        [Description("Department of Defense Inventory Management (527)")]
        [StringValue("MD")]
        DepartmentOfDefenseInventoryManagement,
        [Description("Mortgage Origination (198, 200, 201, 261, 262, 263, 833, 872)")]
        [StringValue("ME")]
        MortgageOrigination,
        [Description("Market Development Funds Settlement (884)")]
        [StringValue("MF")]
        MarketDevelopmentFundsSettlement,
        [Description("Mortgage Servicing Transaction Sets (203, 206, 260, 264, 266)")]
        [StringValue("MG")]
        MortgageServicingTransactionSets,
        [Description("Motor Carrier Rate Proposal (106)")]
        [StringValue("MH")]
        MotorCarrierRateProposal,
        [Description("Motor Carrier Shipment Status Inquiry (213)")]
        [StringValue("MI")]
        MotorCarrierShipmentStatusInquiry,
        [Description("Secondary Mortgage Market Loan Delivery (202)")]
        [StringValue("MJ")]
        SecondaryMortgageMarketLoanDelivery,
        [Description("Response to a Motor Carrier Rate Proposal (108)")]
        [StringValue("MK")]
        ResponseToAMotorCarrierRateProposal,
        [Description("Medical Event Reporting (500)")]
        [StringValue("MM")]
        MedicalEventReporting,
        [Description("Mortgage Note (205)")]
        [StringValue("MN")]
        MortgageNote,
        [Description("Maintenance Service Order (650)")]
        [StringValue("MO")]
        MaintenanceServiceOrder,
        [Description("Motion Picture Booking Confirmation (159)")]
        [StringValue("MP")]
        MotionPictureBookingConfirmation,
        [Description("Consolidators Freight Bill and Invoice (223)")]
        [StringValue("MQ")]
        ConsolidatorsFreightBillAndInvoice,
        [Description("Multilevel Railcar Load Details (125)")]
        [StringValue("MR")]
        MultilevelRailcarLoadDetails,
        [Description("Material Safety Data Sheet (848)")]
        [StringValue("MS")]
        MaterialSafetyDataSheet,
        [Description("Electronic Form Structure (868)")]
        [StringValue("MT")]
        ElectronicFormStructure,
        [Description("Material Obligation Validation (517)")]
        [StringValue("MV")]
        MaterialObligationValidation,
        [Description("Rail Waybill Response (427)")]
        [StringValue("MW")]
        RailWaybillResponse,
        [Description("Material Claim (847)")]
        [StringValue("MX")]
        MaterialClaim,
        [Description("Response to a Cartage Work Assignment (225)")]
        [StringValue("MY")]
        ResponseToACartageWorkAssignment,
        [Description("Nonconformance Report (842)")]
        [StringValue("NC")]
        NonconformanceReport,
        [Description("Name and Address Lists (101)")]
        [StringValue("NL")]
        NameAndAddressLists,
        [Description("Notice of Power of Attorney (157)")]
        [StringValue("NP")]
        NoticeOfPowerOfAttorney,
        [Description("Notice of Tax Adjustment or Assessment (149)")]
        [StringValue("NT")]
        NoticeOfTaxAdjustmentOrAssessment,
        [Description("Cargo Insurance Advice of Shipment (362)")]
        [StringValue("OC")]
        CargoInsuranceAdviceOfShipment,
        [Description("Order Group - Grocery (875, 876)")]
        [StringValue("OG")]
        OrderGroupGrocery,
        [Description("Organizational Relationships (816)")]
        [StringValue("OR")]
        OrganizationalRelationships,
        [Description("Warehouse Shipping Order (940)")]
        [StringValue("OW")]
        WarehouseShippingOrder,
        [Description("Price Authorization Acknowledgment/Status (845)")]
        [StringValue("PA")]
        PriceAuthorizationAcknowledgmentOrStatus,
        [Description("Railroad Parameter Trace Registration (455)")]
        [StringValue("PB")]
        RailroadParameterTraceRegistration,
        [Description("Purchase Order Change Request - Buyer Initiated (860)")]
        [StringValue("PC")]
        PurchaseOrderChangeRequest,
        [Description("Product Activity Data (852)")]
        [StringValue("PD")]
        ProductActivityData,
        [Description("Periodic Compensation (256)")]
        [StringValue("PE")]
        PeriodicCompensation,
        [Description("Annuity Activity (268)")]
        [StringValue("PF")]
        AnnuityActivity,
        [Description("Insurance Plan Description (100)")]
        [StringValue("PG")]
        InsurancePlanDescription,
        [Description("Pricing History (503)")]
        [StringValue("PH")]
        PricingHistory,
        [Description("Patient Information (275)")]
        [StringValue("PI")]
        PatientInformation,
        [Description("Project Schedule Reporting (806)")]
        [StringValue("PJ")]
        ProjectScheduleReporting,
        [Description("Project Cost Reporting (839) and Contractor Cost Data Reporting (196)")]
        [StringValue("PK")]
        ProjectCostReporting,
        [Description("Railroad Problem Log Inquiry or Advice (452)")]
        [StringValue("PL")]
        RailroadProblemLogInquiryOrAdvice,
        [Description("Product Source Information (244)")]
        [StringValue("PN")]
        ProductSourceInformation,
        [Description("Purchase Order (850)")]
        [StringValue("PO")]
        PurchaseOrder,
        [Description("Property Damage Report (112)")]
        [StringValue("PQ")]
        PropertyDamageReport,
        [Description("Purchase Order Acknowledgment (855)")]
        [StringValue("PR")]
        PurchaseOrderAcknowledgment,
        [Description("Planning Schedule with Release Capability (830)")]
        [StringValue("PS")]
        PlanningScheduleWithReleaseCapability,
        [Description("Product Transfer and Resale Report (867)")]
        [StringValue("PT")]
        ProductTransferAndResaleReport,
        [Description("Motor Carrier Shipment Pick-up Notification (216)")]
        [StringValue("PU")]
        MotorCarrierShipmentPickupNotification,
        [Description("Purchase Order Shipment Management Document (250)")]
        [StringValue("PV")]
        PurchaseOrderShipmentManagementDocument,
        [Description("Payment Cancellation Request (829)")]
        [StringValue("PY")]
        PaymentCancellationRequest,
        [Description("Product Information (878, 879, 888, 889, 893, 896)")]
        [StringValue("QG")]
        ProductInformation,
        [Description("Transportation Carrier Shipment Status Message (214)")]
        [StringValue("QM")]
        TransportationCarrierShipmentStatusMessage,
        [Description("Ocean Shipment Status Information (313, 315)")]
        [StringValue("QO")]
        OceanShipmentStatusInformation,
        [Description("Payment Order/Remittance Advice (820)")]
        [StringValue("RA")]
        PaymentOrderOrRemittanceAdvice,
        [Description("Railroad Clearance (470)")]
        [StringValue("RB")]
        RailroadClearance,
        [Description("Receiving Advice/Acceptance Certificate (861)")]
        [StringValue("RC")]
        ReceivingAdviceOrAcceptanceCertificate,
        [Description("Royalty Regulatory Report (185)")]
        [StringValue("RD")]
        RoyaltyRegulatoryReport,
        [Description("Warehouse Stock Receipt Advice (944)")]
        [StringValue("RE")]
        WarehouseStockReceiptAdvice,
        [Description("Railroad Reciprocal Switch File (433)")]
        [StringValue("RH")]
        RailroadReciprocalSwitchFile,
        [Description("Routing and Carrier Instruction (853)")]
        [StringValue("RI")]
        RoutingAndCarrierInstruction,
        [Description("Railroad Mark Register Update Activity (434)")]
        [StringValue("RJ")]
        RailroadMarkRegisterUpdateActivity,
        [Description("Standard Transportation Commodity Code Master (435)")]
        [StringValue("RK")]
        StandardTransportationCommodityCodeMaster,
        [Description("Rail Industrial Switch List (423)")]
        [StringValue("RL")]
        RailIndustrialSwitchList,
        [Description("Railroad Station Master File (431)")]
        [StringValue("RM")]
        RailroadStationMasterFile,
        [Description("Requisition Transaction (511)")]
        [StringValue("RN")]
        RequisitionTransaction,
        [Description("Ocean Booking Information (300, 301,303)")]
        [StringValue("RO")]
        OceanBookingInformation,
        [Description("Commission Sales Report (818)")]
        [StringValue("RP")]
        CommissionSalesReport,
        [Description("Request for Quotation (840) and Procurement Notices (836)")]
        [StringValue("RQ")]
        RequestForQuotation,
        [Description("Response to Request For Quotation (843)")]
        [StringValue("RR")]
        ResponseToRequestForQuotation,
        [Description("Order Status Information (869, 870)")]
        [StringValue("RS")]
        OrderStatusInformation,
        [Description("Report of Test Results (863)")]
        [StringValue("RT")]
        ReportOfTestResults,
        [Description("Railroad Retirement Activity (429)")]
        [StringValue("RU")]
        RailroadRetirementActivity,
        [Description("Railroad Junctions and Interchanges Activity (437)")]
        [StringValue("RV")]
        RailroadJunctionsAndInterchangesActivity,
        [Description("Rail Revenue Waybill (426)")]
        [StringValue("RW")]
        RailRevenueWaybill,
        [Description("Rail Deprescription (432)")]
        [StringValue("RX")]
        RailDeprescription,
        [Description("Request for Student Educational Record (Transcript) (146)")]
        [StringValue("RY")]
        RequestForStudentEducationalRecord,
        [Description("Response to Request for Student Educational Record (Transcript) (147)")]
        [StringValue("RZ")]
        ResponseToRequestForStudentEducationalRecord,
        [Description("Air Shipment Information (104)")]
        [StringValue("SA")]
        AirShipmentInformation,
        [Description("Switch Rails (424)")]
        [StringValue("SB")]
        SwitchRails,
        [Description("Price/Sales Catalog (832)")]
        [StringValue("SC")]
        PriceOrSalesCatalog,
        [Description("Student Loan Pre-Claims and Claims (191)")]
        [StringValue("SD")]
        StudentLoanPreClaimsAndClaims,
        [Description("Shipper's Export Declaration (601)")]
        [StringValue("SE")]
        ShippersExportDeclaration,
        [Description("SG Receiving Advice - Grocery (885)")]
        [StringValue("SG")]
        SGReceivingAdviceGrocery,
        [Description("Ship Notice/Manifest (856)")]
        [StringValue("SH")]
        AdvancedShippingNotice,
        [Description("Shipment Information (858)")]
        [StringValue("SI")]
        ShipmentInformation,
        [Description("Transportation Automatic Equipment Identification (160)")]
        [StringValue("SJ")]
        TransportationAutomaticEquipmentIdentification,
        [Description("Student Loan Application and Guarantee (135, 139)")]
        [StringValue("SL")]
        StudentLoanApplicationAndGuarantee,
        [Description("Motor Carrier Load Tender (204)")]
        [StringValue("SM")]
        MotorCarrierLoadTender,
        [Description("Rail Route File Maintenance (475)")]
        [StringValue("SN")]
        RailRouteFileMaintenance,
        [Description("Ocean Shipment Information (304, 306, 309, 311, 317, 319, 321, 322, 323, 324, ")]
        [StringValue("SO")]
        OceanShipmentInformation,
        [Description("Specifications/Technical Information (841)")]
        [StringValue("SP")]
        SpecificationsOrTechnicalInformation,
        [Description("Production Sequence (866)")]
        [StringValue("SQ")]
        ProductionSequence,
        [Description("Rail Carrier Shipment Information (404, 419)")]
        [StringValue("SR")]
        RailCarrierShipmentInformation,
        [Description("Shipping Schedule (862)")]
        [StringValue("SS")]
        ShippingSchedule,
        [Description("Railroad Service Commitment Advice (453)")]
        [StringValue("ST")]
        RailroadServiceCommitmentAdvice,
        [Description("Account Assignment/Inquiry and Service/Status (248)")]
        [StringValue("SU")]
        AccountAssignmentOrInquiryAndServiceOrStatus,
        [Description("Student Enrollment Verification (190)")]
        [StringValue("SV")]
        StudentEnrollmentVerification,
        [Description("Warehouse Shipping Advice (945)")]
        [StringValue("SW")]
        WarehouseShippingAdvice,
        [Description("Electronic Filing of Tax Return Data Acknowledgment (151)")]
        [StringValue("TA")]
        ElectronicFilingOfTaxReturnDataAcknowledgment,
        [Description("Court Submission (176)")]
        [StringValue("TC")]
        CourtSubmission,
        [Description("Trading Partner Profile (838)")]
        [StringValue("TD")]
        TradingPartnerProfile,
        [Description("Electronic Filing of Tax Return Data (813)")]
        [StringValue("TF")]
        ElectronicFilingOfTaxReturnData,
        [Description("Tax Information Exchange (826)")]
        [StringValue("TI")]
        TaxInformationExchange,
        [Description("Motor Carrier Delivery Trailer Manifest (212)")]
        [StringValue("TM")]
        MotorCarrierDeliveryTrailerManifest,
        [Description("Tax Rate Notification (150)")]
        [StringValue("TN")]
        TaxRateNotification,
        [Description("Real Estate Title Services (197, 199, 265)")]
        [StringValue("TO")]
        RealEstateTitleServices,
        [Description("Rail Rate Transactions (460, 463, 466, 468, 485, 486, 490, 492, 494)")]
        [StringValue("TP")]
        RailRateTransactions,
        [Description("Train Sheet (161)")]
        [StringValue("TR")]
        TrainSheet,
        [Description("Transportation Services Tender (602)")]
        [StringValue("TS")]
        TransportationServicesTender,
        [Description("Testing Results Request and Report (138)")]
        [StringValue("TT")]
        TestingResultsRequestAndReport,
        [Description("Text Message (864)")]
        [StringValue("TX")]
        TextMessage,
        [Description("Retail Account Characteristics (885)")]
        [StringValue("UA")]
        RetailAccountCharacteristics,
        [Description("Customer Call Reporting (886)")]
        [StringValue("UB")]
        CustomerCallReporting,
        [Description("Uniform Commercial Code Filing (154)")]
        [StringValue("UC")]
        UniformCommercialCodeFiling,
        [Description("Deduction Research Report (891)")]
        [StringValue("UD")]
        DeductionResearchReport,
        [Description("Underwriting Information Services (255)")]
        [StringValue("UI")]
        UnderwritingInformationServices,
        [Description("Motor Carrier Pick-up Manifest (215)")]
        [StringValue("UP")]
        MotorCarrierPickupManifest,
        [Description("Insurance Underwriting Requirements Reporting (186)")]
        [StringValue("UW")]
        InsuranceUnderwritingRequirementsReporting,
        [Description("Vehicle Application Advice (126)")]
        [StringValue("VA")]
        VehicleApplicationAdvice,
        [Description("Vehicle Baying Order (127)")]
        [StringValue("VB")]
        VehicleBayingOrder,
        [Description("Vehicle Shipping Order (120)")]
        [StringValue("VC")]
        VehicleShippingOrder,
        [Description("Vehicle Damage (124)")]
        [StringValue("VD")]
        VehicleDamage,
        [Description("Vessel Content Details (109)")]
        [StringValue("VE")]
        VesselContentDetails,
        [Description("Vehicle Carrier Rate Update (129)")]
        [StringValue("VH")]
        VehicleCarrierRateUpdate,
        [Description("Voter Registration Information (280)")]
        [StringValue("VI")]
        VoterRegistrationInformation,
        [Description("Vehicle Service (121)")]
        [StringValue("VS")]
        VehicleService,
        [Description("Product Service Transaction Sets (140, 141, 142, 143)")]
        [StringValue("WA")]
        ProductServiceTransactionSets,
        [Description("Rail Carrier Waybill Interchange (417)")]
        [StringValue("WB")]
        RailCarrierWaybillInterchange,
        [Description("Vendor Performance Review (501)")]
        [StringValue("WG")]
        VendorPerformanceReview,
        [Description("Wage Determination (288)")]
        [StringValue("WI")]
        WageDetermination,
        [Description("Well Information (625)")]
        [StringValue("WL")]
        WellInformation,
        [Description("Shipment Weights (440)")]
        [StringValue("WR")]
        ShipmentWeights,
        [Description("Rail Waybill Request (425)")]
        [StringValue("WT")]
        RailWaybillRequest,
        [Description("Request for Routing Instructions (753)")]
        [StringValue("RF")]
        RoutingRequest,
        [Description("Routing Instructions (754)")]
        [StringValue("RG")]
        RoutingInstructions,
    }

    public enum ResponsibleAgencyCode
    {
        [Description("Accredited Standards Committee X12")]
        [StringValue("X")]
        AccreditedStandards,

        [Description("Transportation Data Coordinating Committee (TDCC)")]
        [StringValue("T")]
        TransportationData,
    }

    public enum VersionIdentifierCode
    {
        [Description("Draft Standards Approved for Publication by ASC X12 Procedures Review Board through October 1997")]
        [StringValue("004010")]
        DraftStandards,
    }

    public enum TransactionSetIdentifierCode
    {
        [Description("Purchase Order")]
        [StringValue("850")]
        PurchaseOrder,
        [Description("Purchase Order Acknowledgment")]
        [StringValue("855")]
        PurchaseOrderAcknowledgment,
        [Description("Purchase Order Change Request")]
        [StringValue("860")]
        PurchaseOrderChangeRequest,
        [Description("Purchase Order Change Request Acknowledgment")]
        [StringValue("865")]
        PurchaseOrderChangeRequestAcknowledgment,
        [Description("Functional Acknowledgment")]
        [StringValue("997")]
        FunctionalAcknowledgment,
        [Description("Request for Routing Instructions")]
        [StringValue("753")]
        RoutingRequest,
        [Description("Routing Instructions")]
        [StringValue("754")]
        RoutingInstructions,
        [Description("Warehouse Shipping Order")]
        [StringValue("940")]
        WarehouseShippingOrder,
        [Description("Ship Notice/Manifest")]
        [StringValue("856")]
        AdvancedShippingNotice,
        [Description("Inventory Inquiry/Advice")]
        [StringValue("846")]
        InventoryInquiryOrAdvice,
        [Description("Warehouse Shipping Advice")]
        [StringValue("945")]
        WarehouseShippingAdvice,
        [Description("Invoice")]
        [StringValue("810")]
        Invoice,
        [Description("Warehouse Stock Transfer Shipment Advice (943)")]
        [StringValue("943")]
        WarehouseStockTransferShipmentAdvice,
        [Description("Warehouse Stock Receipt Advice (944)")]
        [StringValue("944")]
        WarehouseStockReceiptAdvice,

    }
    public enum TransactionSetIdentifierCodeFull
    {
        [Description("Insurance Plan Description")]
        [StringValue("100")]
        InsurancePlanDescription,
        [Description("Name and Address Lists")]
        [StringValue("101")]
        NameandAddressLists,
        [Description("Air Shipment Information")]
        [StringValue("104")]
        AirShipmentInformation,
        [Description("Business Entity Filings")]
        [StringValue("105")]
        BusinessEntityFilings,
        [Description("Motor Carrier Rate Proposal")]
        [StringValue("106")]
        MotorCarrierRateProposal,
        [Description("Request for Motor Carrier Rate Proposal")]
        [StringValue("107")]
        RequestforMotorCarrierRateProposal,
        [Description("Response to a Motor Carrier Rate Proposal")]
        [StringValue("108")]
        ResponsetoaMotorCarrierRateProposal,
        [Description("Vessel Content Details")]
        [StringValue("109")]
        VesselContentDetails,
        [Description("Air Freight Details and Invoice")]
        [StringValue("110")]
        AirFreightDetailsandInvoice,
        [Description("Property Damage Report")]
        [StringValue("112")]
        PropertyDamageReport,
        [Description("Vehicle Shipping Order")]
        [StringValue("120")]
        VehicleShippingOrder,
        [Description("Vehicle Service")]
        [StringValue("121")]
        VehicleService,
        [Description("Vehicle Damage")]
        [StringValue("124")]
        VehicleDamage,
        [Description("Multilevel Railcar Load Details")]
        [StringValue("125")]
        MultilevelRailcarLoadDetails,
        [Description("Vehicle Application Advice")]
        [StringValue("126")]
        VehicleApplicationAdvice,
        [Description("Vehicle Baying Order")]
        [StringValue("127")]
        VehicleBayingOrder,
        [Description("Dealer Information")]
        [StringValue("128")]
        DealerInformation,
        [Description("Vehicle Carrier Rate Update")]
        [StringValue("129")]
        VehicleCarrierRateUpdate,
        [Description("Student Educational Record (Transcript)")]
        [StringValue("130")]
        StudentEducationalRecordTranscript,
        [Description("Student Educational Record (Transcript) Acknowledgment")]
        [StringValue("131")]
        StudentEducationalRecordTranscriptAcknowledgment,
        [Description("Student Loan Application")]
        [StringValue("135")]
        StudentLoanApplication,
        [Description("Testing Results Request and Report")]
        [StringValue("138")]
        TestingResultsRequestandReport,
        [Description("Student Loan Guarantee Result")]
        [StringValue("139")]
        StudentLoanGuaranteeResult,
        [Description("Product Registration")]
        [StringValue("140")]
        ProductRegistration,
        [Description("Product Service Claim Response")]
        [StringValue("141")]
        ProductServiceClaimResponse,
        [Description("Product Service Claim")]
        [StringValue("142")]
        ProductServiceClaim,
        [Description("Product Service Notification")]
        [StringValue("143")]
        ProductServiceNotification,
        [Description("Student Loan Transfer and Status Verification")]
        [StringValue("144")]
        StudentLoanTransferandStatusVerification,
        [Description("Request for Student Educational Record (Transcript)")]
        [StringValue("146")]
        RequestforStudentEducationalRecordTranscript,
        [Description("Response to Request for Student Educational Record (Transcript)")]
        [StringValue("147")]
        ResponsetoRequestforStudentEducationalRecordTranscript,
        [Description("Report of Injury, Illness or Incident")]
        [StringValue("148")]
        ReportofInjury, IllnessorIncident,
        [Description("Notice of Tax Adjustment or Assessment")]
        [StringValue("149")]
        NoticeofTaxAdjustmentorAssessment,
        [Description("Tax Rate Notification")]
        [StringValue("150")]
        TaxRateNotification,
        [Description("Electronic Filing of Tax Return Data Acknowledgment")]
        [StringValue("151")]
        ElectronicFilingofTaxReturnDataAcknowledgment,
        [Description("Statistical Government Information")]
        [StringValue("152")]
        StatisticalGovernmentInformation,
        [Description("Unemployment Insurance Tax Claim or Charge Information")]
        [StringValue("153")]
        UnemploymentInsuranceTaxClaimorChargeInformation,
        [Description("Uniform Commercial Code Filing")]
        [StringValue("154")]
        UniformCommercialCodeFiling,
        [Description("Business Credit Report")]
        [StringValue("155")]
        BusinessCreditReport,
        [Description("Notice of Power of Attorney")]
        [StringValue("157")]
        NoticeofPowerofAttorney,
        [Description("Motion Picture Booking Confirmation")]
        [StringValue("159")]
        MotionPictureBookingConfirmation,
        [Description("Transportation Automatic Equipment Identification")]
        [StringValue("160")]
        TransportationAutomaticEquipmentIdentification,
        [Description("Train Sheet")]
        [StringValue("161")]
        TrainSheet,
        [Description("Transportation Appointment Schedule Information")]
        [StringValue("163")]
        TransportationAppointmentScheduleInformation,
        [Description("Revenue Receipts Statement")]
        [StringValue("170")]
        RevenueReceiptsStatement,
        [Description("Court and Law Enforcement Notice")]
        [StringValue("175")]
        CourtandLawEnforcementNotice,
        [Description("Court Submission")]
        [StringValue("176")]
        CourtSubmission,
        [Description("Return Merchandise Authorization and Notification")]
        [StringValue("180")]
        ReturnMerchandiseAuthorizationandNotification,
        [Description("Royalty Regulatory Report")]
        [StringValue("185")]
        RoyaltyRegulatoryReport,
        [Description("Insurance Underwriting Requirements Reporting")]
        [StringValue("186")]
        InsuranceUnderwritingRequirementsReporting,
        [Description("Educational Course Inventory")]
        [StringValue("188")]
        EducationalCourseInventory,
        [Description("Application for Admission to Educational Institutions")]
        [StringValue("189")]
        ApplicationforAdmissiontoEducationalInstitutions,
        [Description("Student Enrollment Verification")]
        [StringValue("190")]
        StudentEnrollmentVerification,
        [Description("Student Loan Pre-Claims and Claims")]
        [StringValue("191")]
        StudentLoanPreClaimsandClaims,
        [Description("Grant or Assistance Application")]
        [StringValue("194")]
        GrantorAssistanceApplication,
        [Description("Federal Communications Commission (FCC) License Application")]
        [StringValue("195")]
        FederalCommunicationsCommissionFCCLicenseApplication,
        [Description("Contractor Cost Data Reporting")]
        [StringValue("196")]
        ContractorCostDataReporting,
        [Description("Real Estate Title Evidence")]
        [StringValue("197")]
        RealEstateTitleEvidence,
        [Description("Loan Verification Information")]
        [StringValue("198")]
        LoanVerificationInformation,
        [Description("Real Estate Settlement Information")]
        [StringValue("199")]
        RealEstateSettlementInformation,
        [Description("Mortgage Credit Report")]
        [StringValue("200")]
        MortgageCreditReport,
        [Description("Residential Loan Application")]
        [StringValue("201")]
        ResidentialLoanApplication,
        [Description("Secondary Mortgage Market Loan Delivery")]
        [StringValue("202")]
        SecondaryMortgageMarketLoanDelivery,
        [Description("Secondary Mortgage Market Investor Report")]
        [StringValue("203")]
        SecondaryMortgageMarketInvestorReport,
        [Description("Motor Carrier Load Tender")]
        [StringValue("204")]
        MotorCarrierLoadTender,
        [Description("Mortgage Note")]
        [StringValue("205")]
        MortgageNote,
        [Description("Real Estate Inspection")]
        [StringValue("206")]
        RealEstateInspection,
        [Description("Motor Carrier Freight Details and Invoice")]
        [StringValue("210")]
        MotorCarrierFreightDetailsandInvoice,
        [Description("Motor Carrier Bill of Lading")]
        [StringValue("211")]
        MotorCarrierBillofLading,
        [Description("Motor Carrier Delivery Trailer Manifest")]
        [StringValue("212")]
        MotorCarrierDeliveryTrailerManifest,
        [Description("Motor Carrier Shipment Status Inquiry")]
        [StringValue("213")]
        MotorCarrierShipmentStatusInquiry,
        [Description("Transportation Carrier Shipment Status Message")]
        [StringValue("214")]
        TransportationCarrierShipmentStatusMessage,
        [Description("Motor Carrier Pick-up Manifest")]
        [StringValue("215")]
        MotorCarrierPickupManifest,
        [Description("Motor Carrier Shipment Pick-up Notification")]
        [StringValue("216")]
        MotorCarrierShipmentPickupNotification,
        [Description("Motor Carrier Loading and Route Guide")]
        [StringValue("217")]
        MotorCarrierLoadingandRouteGuide,
        [Description("Motor Carrier Tariff Information")]
        [StringValue("218")]
        MotorCarrierTariffInformation,
        [Description("Logistics Service Request")]
        [StringValue("219")]
        LogisticsServiceRequest,
        [Description("Logistics Service Response")]
        [StringValue("220")]
        LogisticsServiceResponse,
        [Description("Cartage Work Assignment")]
        [StringValue("222")]
        CartageWorkAssignment,
        [Description("Consolidators Freight Bill and Invoice")]
        [StringValue("223")]
        ConsolidatorsFreightBillandInvoice,
        [Description("Motor Carrier Summary Freight Bill Manifest")]
        [StringValue("224")]
        MotorCarrierSummaryFreightBillManifest,
        [Description("Response to a Cartage Work Assignment")]
        [StringValue("225")]
        ResponsetoaCartageWorkAssignment,
        [Description("Data Status Tracking")]
        [StringValue("242")]
        DataStatusTracking,
        [Description("Product Source Information")]
        [StringValue("244")]
        ProductSourceInformation,
        [Description("Account Assignment/Inquiry and Service/Status")]
        [StringValue("248")]
        AccountAssignmentInquiryandServiceStatus,
        [Description("Animal Toxicological Data")]
        [StringValue("249")]
        AnimalToxicologicalData,
        [Description("Purchase Order Shipment Management Document")]
        [StringValue("250")]
        PurchaseOrderShipmentManagementDocument,
        [Description("Pricing Support")]
        [StringValue("251")]
        PricingSupport,
        [Description("Insurance Producer Administration")]
        [StringValue("252")]
        InsuranceProducerAdministration,
        [Description("Underwriting Information Services")]
        [StringValue("255")]
        UnderwritingInformationServices,
        [Description("Periodic Compensation")]
        [StringValue("256")]
        PeriodicCompensation,
        [Description("Application for Mortgage Insurance Benefits")]
        [StringValue("260")]
        ApplicationforMortgageInsuranceBenefits,
        [Description("Real Estate Information Request")]
        [StringValue("261")]
        RealEstateInformationRequest,
        [Description("Real Estate Information Report")]
        [StringValue("262")]
        RealEstateInformationReport,
        [Description("Residential Mortgage Insurance Application Response")]
        [StringValue("263")]
        ResidentialMortgageInsuranceApplicationResponse,
        [Description("Mortgage Loan Default Status")]
        [StringValue("264")]
        MortgageLoanDefaultStatus,
        [Description("Real Estate Title Insurance Services Order")]
        [StringValue("265")]
        RealEstateTitleInsuranceServicesOrder,
        [Description("Mortgage or Property Record Change Notification")]
        [StringValue("266")]
        MortgageorPropertyRecordChangeNotification,
        [Description("Individual Life, Annuity and Disability Application")]
        [StringValue("267")]
        IndividualLifeAnnuityandDisabilityApplication,
        [Description("Annuity Activity")]
        [StringValue("268")]
        AnnuityActivity,
        [Description("Eligibility, Coverage or Benefit Inquiry")]
        [StringValue("270")]
        EligibilityCoverageorBenefitInquiry,
        [Description("Eligibility, Coverage or Benefit Information")]
        [StringValue("271")]
        EligibilityCoverageorBenefitInformation,
        [Description("Property and Casualty Loss Notification")]
        [StringValue("272")]
        PropertyandCasualtyLossNotification,
        [Description("Insurance/Annuity Application Status")]
        [StringValue("273")]
        InsuranceAnnuityApplicationStatus,
        [Description("Patient Information")]
        [StringValue("275")]
        PatientInformation,
        [Description("Health Care Claim Status Request")]
        [StringValue("276")]
        HealthCareClaimStatusRequest,
        [Description("Health Care Claim Status Notification")]
        [StringValue("277")]
        HealthCareClaimStatusNotification,
        [Description("Health Care Services Review Information")]
        [StringValue("278")]
        HealthCareServicesReviewInformation,
        [Description("Voter Registration Information")]
        [StringValue("280")]
        VoterRegistrationInformation,
        [Description("Commercial Vehicle Safety and Credentials Information Exchange")]
        [StringValue("285")]
        CommercialVehicleSafetyandCredentialsInformationExchange,
        [Description("Commercial Vehicle Credentials")]
        [StringValue("286")]
        CommercialVehicleCredentials,
        [Description("Wage Determination")]
        [StringValue("288")]
        WageDetermination,
        [Description("Cooperative Advertising Agreements")]
        [StringValue("290")]
        CooperativeAdvertisingAgreements,
        [Description("Reservation (Booking Request) (Ocean)")]
        [StringValue("300")]
        ReservationBookingRequestOcean,
        [Description("Confirmation (Ocean)")]
        [StringValue("301")]
        ConfirmationOcean,
        [Description("Booking Cancellation (Ocean)")]
        [StringValue("303")]
        BookingCancellationOcean,
        [Description("Shipping Instructions")]
        [StringValue("304")]
        ShippingInstructions,
        [Description("Dock Receipt")]
        [StringValue("306")]
        DockReceipt,
        [Description("U.S. Customs Manifest")]
        [StringValue("309")]
        USCustomsManifest,
        [Description("Freight Receipt and Invoice (Ocean)")]
        [StringValue("310")]
        FreightReceiptandInvoiceOcean,
        [Description("Canadian Customs Information")]
        [StringValue("311")]
        CanadianCustomsInformation,
        [Description("Arrival Notice (Ocean)")]
        [StringValue("312")]
        ArrivalNoticeOcean,
        [Description("Shipment Status Inquiry (Ocean)")]
        [StringValue("313")]
        ShipmentStatusInquiryOcean,
        [Description("Status Details (Ocean)")]
        [StringValue("315")]
        StatusDetailsOcean,
        [Description("Delivery/Pickup Order")]
        [StringValue("317")]
        DeliveryPickupOrder,
        [Description("Terminal Information")]
        [StringValue("319")]
        TerminalInformation,
        [Description("Demurrage Guarantee (Ocean)")]
        [StringValue("321")]
        DemurrageGuaranteeOcean,
        [Description("Terminal Operations and Intermodal Ramp Activity")]
        [StringValue("322")]
        TerminalOperationsandIntermodalRampActivity,
        [Description("Vessel Schedule and Itinerary (Ocean)")]
        [StringValue("323")]
        VesselScheduleandItineraryOcean,
        [Description("Vessel Stow Plan (Ocean)")]
        [StringValue("324")]
        VesselStowPlanOcean,
        [Description("Consolidation of Goods in Container")]
        [StringValue("325")]
        ConsolidationofGoodsinContainer,
        [Description("Consignment Summary List")]
        [StringValue("326")]
        ConsignmentSummaryList,
        [Description("U.S. Customs Status Information")]
        [StringValue("350")]
        USCustomsStatusInformation,
        [Description("U.S. Customs Carrier General Order Status")]
        [StringValue("352")]
        USCustomsCarrierGeneralOrderStatus,
        [Description("U.S. Customs Events Advisory Details")]
        [StringValue("353")]
        USCustomsEventsAdvisoryDetails,
        [Description("U.S. Customs Automated Manifest Archive Status")]
        [StringValue("354")]
        USCustomsAutomatedManifestArchiveStatus,
        [Description("U.S. Customs Acceptance/Rejection")]
        [StringValue("355")]
        USCustomsAcceptanceRejection,
        [Description("U.S. Customs Permit to Transfer Request")]
        [StringValue("356")]
        USCustomsPermittoTransferRequest,
        [Description("U.S. Customs In-Bond Information")]
        [StringValue("357")]
        USCustomsInBondInformation,
        [Description("U.S. Customs Consist Information")]
        [StringValue("358")]
        USCustomsConsistInformation,
        [Description("Carrier Interchange Agreement (Ocean)")]
        [StringValue("361")]
        CarrierInterchangeAgreementOcean,
        [Description("Cargo Insurance Advice of Shipment")]
        [StringValue("362")]
        CargoInsuranceAdviceofShipment,
        [Description("Rail Carrier Shipment Information")]
        [StringValue("404")]
        RailCarrierShipmentInformation,
        [Description("Rail Carrier Freight Details and Invoice")]
        [StringValue("410")]
        RailCarrierFreightDetailsandInvoice,
        [Description("Freight Details and Invoice Summary (Rail)")]
        [StringValue("411")]
        FreightDetailsandInvoiceSummaryRail,
        [Description("Rail Carhire Settlements")]
        [StringValue("414")]
        RailCarhireSettlements,
        [Description("Rail Carrier Waybill Interchange")]
        [StringValue("417")]
        RailCarrierWaybillInterchange,
        [Description("Rail Advance Interchange Consist")]
        [StringValue("418")]
        RailAdvanceInterchangeConsist,
        [Description("Advance Car Disposition")]
        [StringValue("419")]
        AdvanceCarDisposition,
        [Description("Car Handling Information")]
        [StringValue("420")]
        CarHandlingInformation,
        [Description("Estimated Time of Arrival and Car Scheduling")]
        [StringValue("421")]
        EstimatedTimeofArrivalandCarScheduling,
        [Description("Shipper's Car Order")]
        [StringValue("422")]
        ShippersCarOrder,
        [Description("Rail Industrial Switch List")]
        [StringValue("423")]
        RailIndustrialSwitchList,
        [Description("Rail Waybill Request")]
        [StringValue("425")]
        RailWaybillRequest,
        [Description("Rail Revenue Waybill")]
        [StringValue("426")]
        RailRevenueWaybill,
        [Description("Railroad Retirement Activity")]
        [StringValue("429")]
        RailroadRetirementActivity,
        [Description("Railroad Station Master File")]
        [StringValue("431")]
        RailroadStationMasterFile,
        [Description("Rail Deprescription")]
        [StringValue("432")]
        RailDeprescription,
        [Description("Railroad Reciprocal Switch File")]
        [StringValue("433")]
        RailroadReciprocalSwitchFile,
        [Description("Railroad Mark Register Update Activity")]
        [StringValue("434")]
        RailroadMarkRegisterUpdateActivity,
        [Description("Standard Transportation Commodity Code Master")]
        [StringValue("435")]
        StandardTransportationCommodityCodeMaster,
        [Description("Locomotive Information")]
        [StringValue("436")]
        LocomotiveInformation,
        [Description("Railroad Junctions and Interchanges Activity")]
        [StringValue("437")]
        RailroadJunctionsandInterchangesActivity,
        [Description("Shipment Weights")]
        [StringValue("440")]
        ShipmentWeights,
        [Description("Railroad Event Report")]
        [StringValue("451")]
        RailroadEventReport,
        [Description("Railroad Problem Log Inquiry or Advice")]
        [StringValue("452")]
        RailroadProblemLogInquiryorAdvice,
        [Description("Railroad Service Commitment Advice")]
        [StringValue("453")]
        RailroadServiceCommitmentAdvice,
        [Description("Railroad Parameter Trace Registration")]
        [StringValue("455")]
        RailroadParameterTraceRegistration,
        [Description("Railroad Equipment Inquiry or Advice")]
        [StringValue("456")]
        RailroadEquipmentInquiryorAdvice,
        [Description("Railroad Price Distribution Request or Response")]
        [StringValue("460")]
        RailroadPriceDistributionRequestorResponse,
        [Description("Rail Rate Reply")]
        [StringValue("463")]
        RailRateReply,
        [Description("Rate Request")]
        [StringValue("466")]
        RateRequest,
        [Description("Rate Docket Journal Log")]
        [StringValue("468")]
        RateDocketJournalLog,
        [Description("Railroad Clearance")]
        [StringValue("470")]
        RailroadClearance,
        [Description("Rail Route File Maintenance")]
        [StringValue("475")]
        RailRouteFileMaintenance,
        [Description("Ratemaking Action")]
        [StringValue("485")]
        RatemakingAction,
        [Description("Rate Docket Expiration")]
        [StringValue("486")]
        RateDocketExpiration,
        [Description("Rate Group Definition")]
        [StringValue("490")]
        RateGroupDefinition,
        [Description("Miscellaneous Rates")]
        [StringValue("492")]
        MiscellaneousRates,
        [Description("Scale Rate Table")]
        [StringValue("494")]
        ScaleRateTable,
        [Description("Medical Event Reporting")]
        [StringValue("500")]
        MedicalEventReporting,
        [Description("Vendor Performance Review")]
        [StringValue("501")]
        VendorPerformanceReview,
        [Description("Pricing History")]
        [StringValue("503")]
        PricingHistory,
        [Description("Clauses and Provisions")]
        [StringValue("504")]
        ClausesandProvisions,
        [Description("Requisition")]
        [StringValue("511")]
        Requisition,
        [Description("Material Obligation Validation")]
        [StringValue("517")]
        MaterialObligationValidation,
        [Description("Income or Asset Offset")]
        [StringValue("521")]
        IncomeorAssetOffset,
        [Description("Material Due-In and Receipt")]
        [StringValue("527")]
        MaterialDueInandReceipt,
        [Description("Logistics Reassignment")]
        [StringValue("536")]
        LogisticsReassignment,
        [Description("Notice of Employment Status")]
        [StringValue("540")]
        NoticeofEmploymentStatus,
        [Description("Contract Abstract")]
        [StringValue("561")]
        ContractAbstract,
        [Description("Contract Completion Status")]
        [StringValue("567")]
        ContractCompletionStatus,
        [Description("Contract Payment Management Report")]
        [StringValue("568")]
        ContractPaymentManagementReport,
        [Description("U.S. Customs Export Shipment Information")]
        [StringValue("601")]
        USCustomsExportShipmentInformation,
        [Description("Transportation Services Tender")]
        [StringValue("602")]
        TransportationServicesTender,
        [Description("Excavation Communication")]
        [StringValue("620")]
        ExcavationCommunication,
        [Description("Intermodal Ramp Activity")]
        [StringValue("622")]
        IntermodalRampActivity,
        [Description("Well Information")]
        [StringValue("625")]
        WellInformation,
        [Description("Maintenance Service Order")]
        [StringValue("650")]
        MaintenanceServiceOrder,
        [Description("Intermodal Group Loading Plan")]
        [StringValue("715")]
        IntermodalGroupLoadingPlan,
        [Description("Contract Pricing Proposal")]
        [StringValue("805")]
        ContractPricingProposal,
        [Description("Project Schedule Reporting")]
        [StringValue("806")]
        ProjectScheduleReporting,
        [Description("Invoice")]
        [StringValue("810")]
        Invoice,
        [Description("Consolidated Service Invoice/Statement")]
        [StringValue("811")]
        ConsolidatedServiceInvoiceStatement,
        [Description("Credit/Debit Adjustment")]
        [StringValue("812")]
        CreditDebitAdjustment,
        [Description("Electronic Filing of Tax Return Data")]
        [StringValue("813")]
        ElectronicFilingofTaxReturnData,
        [Description("General Request, Response or Confirmation")]
        [StringValue("814")]
        GeneralRequest, ResponseorConfirmation,
        [Description("Cryptographic Service Message")]
        [StringValue("815")]
        CryptographicServiceMessage,
        [Description("Organizational Relationships")]
        [StringValue("816")]
        OrganizationalRelationships,
        [Description("Commission Sales Report")]
        [StringValue("818")]
        CommissionSalesReport,
        [Description("Operating Expense Statement")]
        [StringValue("819")]
        OperatingExpenseStatement,
        [Description("Payment Order/Remittance Advice")]
        [StringValue("820")]
        PaymentOrderRemittanceAdvice,
        [Description("Financial Information Reporting")]
        [StringValue("821")]
        FinancialInformationReporting,
        [Description("Account Analysis")]
        [StringValue("822")]
        AccountAnalysis,
        [Description("Lockbox")]
        [StringValue("823")]
        Lockbox,
        [Description("Application Advice")]
        [StringValue("824")]
        ApplicationAdvice,
        [Description("Tax Information Exchange")]
        [StringValue("826")]
        TaxInformationExchange,
        [Description("Financial Return Notice")]
        [StringValue("827")]
        FinancialReturnNotice,
        [Description("Debit Authorization")]
        [StringValue("828")]
        DebitAuthorization,
        [Description("Payment Cancellation Request")]
        [StringValue("829")]
        PaymentCancellationRequest,
        [Description("Planning Schedule with Release Capability")]
        [StringValue("830")]
        PlanningSchedulewithReleaseCapability,
        [Description("Application Control Totals")]
        [StringValue("831")]
        ApplicationControlTotals,
        [Description("Price/Sales Catalog")]
        [StringValue("832")]
        PriceSalesCatalog,
        [Description("Mortgage Credit Report Order")]
        [StringValue("833")]
        MortgageCreditReportOrder,
        [Description("Benefit Enrollment and Maintenance")]
        [StringValue("834")]
        BenefitEnrollmentandMaintenance,
        [Description("Health Care Claim Payment/Advice")]
        [StringValue("835")]
        HealthCareClaimPaymentAdvice,
        [Description("Procurement Notices")]
        [StringValue("836")]
        ProcurementNotices,
        [Description("Health Care Claim")]
        [StringValue("837")]
        HealthCareClaim,
        [Description("Trading Partner Profile")]
        [StringValue("838")]
        TradingPartnerProfile,
        [Description("Project Cost Reporting")]
        [StringValue("839")]
        ProjectCostReporting,
        [Description("Request for Quotation")]
        [StringValue("840")]
        RequestforQuotation,
        [Description("Specifications/Technical Information")]
        [StringValue("841")]
        SpecificationsTechnicalInformation,
        [Description("Nonconformance Report")]
        [StringValue("842")]
        NonconformanceReport,
        [Description("Response to Request for Quotation")]
        [StringValue("843")]
        ResponsetoRequestforQuotation,
        [Description("Product Transfer Account Adjustment")]
        [StringValue("844")]
        ProductTransferAccountAdjustment,
        [Description("Price Authorization Acknowledgment/Status")]
        [StringValue("845")]
        PriceAuthorizationAcknowledgmentStatus,
        [Description("Inventory Inquiry/Advice")]
        [StringValue("846")]
        InventoryInquiryAdvice,
        [Description("Material Claim")]
        [StringValue("847")]
        MaterialClaim,
        [Description("Material Safety Data Sheet")]
        [StringValue("848")]
        MaterialSafetyDataSheet,
        [Description("Response to Product Transfer Account Adjustment")]
        [StringValue("849")]
        ResponsetoProductTransferAccountAdjustment,
        [Description("Purchase Order")]
        [StringValue("850")]
        PurchaseOrder,
        [Description("Asset Schedule")]
        [StringValue("851")]
        AssetSchedule,
        [Description("Product Activity Data")]
        [StringValue("852")]
        ProductActivityData,
        [Description("Routing and Carrier Instruction")]
        [StringValue("853")]
        RoutingandCarrierInstruction,
        [Description("Shipment Delivery Discrepancy Information")]
        [StringValue("854")]
        ShipmentDeliveryDiscrepancyInformation,
        [Description("Purchase Order Acknowledgment")]
        [StringValue("855")]
        PurchaseOrderAcknowledgment,
        [Description("Ship Notice/Manifest")]
        [StringValue("856")]
        ShipNoticeManifest,
        [Description("Shipment and Billing Notice")]
        [StringValue("857")]
        ShipmentandBillingNotice,
        [Description("Shipment Information")]
        [StringValue("858")]
        ShipmentInformation,
        [Description("Freight Invoice")]
        [StringValue("859")]
        FreightInvoice,
        [Description("Purchase Order Change Request - Buyer Initiated")]
        [StringValue("860")]
        PurchaseOrderChangeRequestBuyerInitiated,
        [Description("Receiving Advice/Acceptance Certificate")]
        [StringValue("861")]
        ReceivingAdviceAcceptanceCertificate,
        [Description("Shipping Schedule")]
        [StringValue("862")]
        ShippingSchedule,
        [Description("Report of Test Results")]
        [StringValue("863")]
        ReportofTestResults,
        [Description("Text Message")]
        [StringValue("864")]
        TextMessage,
        [Description("Purchase Order Change Acknowledgment/Request - Seller Initiated")]
        [StringValue("865")]
        PurchaseOrderChangeAcknowledgmentRequestSellerInitiated,
        [Description("Production Sequence")]
        [StringValue("866")]
        ProductionSequence,
        [Description("Product Transfer and Resale Report")]
        [StringValue("867")]
        ProductTransferandResaleReport,
        [Description("Electronic Form Structure")]
        [StringValue("868")]
        ElectronicFormStructure,
        [Description("Order Status Inquiry")]
        [StringValue("869")]
        OrderStatusInquiry,
        [Description("Order Status Report")]
        [StringValue("870")]
        OrderStatusReport,
        [Description("Component Parts Content")]
        [StringValue("871")]
        ComponentPartsContent,
        [Description("Residential Mortgage Insurance Application")]
        [StringValue("872")]
        ResidentialMortgageInsuranceApplication,
        [Description("Grocery Products Purchase Order")]
        [StringValue("875")]
        GroceryProductsPurchaseOrder,
        [Description("Grocery Products Purchase Order Change")]
        [StringValue("876")]
        GroceryProductsPurchaseOrderChange,
        [Description("Manufacturer Coupon Family Code Structure")]
        [StringValue("877")]
        ManufacturerCouponFamilyCodeStructure,
        [Description("Product Authorization/De-Authorization")]
        [StringValue("878")]
        ProductAuthorizationDeAuthorization,
        [Description("Price Information")]
        [StringValue("879")]
        PriceInformation,
        [Description("Grocery Products Invoice")]
        [StringValue("880")]
        GroceryProductsInvoice,
        [Description("Manufacturer Coupon Redemption Detail")]
        [StringValue("881")]
        ManufacturerCouponRedemptionDetail,
        [Description("Direct Store Delivery Summary Information")]
        [StringValue("882")]
        DirectStoreDeliverySummaryInformation,
        [Description("Market Development Fund Allocation")]
        [StringValue("883")]
        MarketDevelopmentFundAllocation,
        [Description("Market Development Fund Settlement")]
        [StringValue("884")]
        MarketDevelopmentFundSettlement,
        [Description("Retail Account Characteristics")]
        [StringValue("885")]
        RetailAccountCharacteristics,
        [Description("Customer Call Reporting")]
        [StringValue("886")]
        CustomerCallReporting,
        [Description("Coupon Notification")]
        [StringValue("887")]
        CouponNotification,
        [Description("Item Maintenance")]
        [StringValue("888")]
        ItemMaintenance,
        [Description("Promotion Announcement")]
        [StringValue("889")]
        PromotionAnnouncement,
        [Description("Deduction Research Report")]
        [StringValue("891")]
        DeductionResearchReport,
        [Description("Item Information Request")]
        [StringValue("893")]
        ItemInformationRequest,
        [Description("Delivery/Return Base Record")]
        [StringValue("894")]
        DeliveryReturnBaseRecord,
        [Description("Delivery/Return Acknowledgment or Adjustment")]
        [StringValue("895")]
        DeliveryReturnAcknowledgmentorAdjustment,
        [Description("Product Dimension Maintenance")]
        [StringValue("896")]
        ProductDimensionMaintenance,
        [Description("Loss or Damage Claim - General Commodities")]
        [StringValue("920")]
        LossorDamageClaimGeneralCommodities,
        [Description("Loss or Damage Claim - Motor Vehicle")]
        [StringValue("924")]
        LossorDamageClaimMotorVehicle,
        [Description("Claim Tracer")]
        [StringValue("925")]
        ClaimTracer,
        [Description("Claim Status Report and Tracer Reply")]
        [StringValue("926")]
        ClaimStatusReportandTracerReply,
        [Description("Automotive Inspection Detail")]
        [StringValue("928")]
        AutomotiveInspectionDetail,
        [Description("Warehouse Shipping Order")]
        [StringValue("940")]
        WarehouseShippingOrder,
        [Description("Warehouse Stock Transfer Shipment Advice")]
        [StringValue("943")]
        WarehouseStockTransferShipmentAdvice,
        [Description("Warehouse Stock Transfer Receipt Advice")]
        [StringValue("944")]
        WarehouseStockTransferReceiptAdvice,
        [Description("Warehouse Shipping Advice")]
        [StringValue("945")]
        WarehouseShippingAdvice,
        [Description("Warehouse Inventory Adjustment Advice")]
        [StringValue("947")]
        WarehouseInventoryAdjustmentAdvice,
        [Description("Functional Group Totals")]
        [StringValue("980")]
        FunctionalGroupTotals,
        [Description("Response To a Load Tender")]
        [StringValue("990")]
        ResponseToaLoadTender,
        [Description("Administrative Message")]
        [StringValue("994")]
        AdministrativeMessage,
        [Description("File Transfer")]
        [StringValue("996")]
        FileTransfer,
        [Description("Functional Acknowledgment")]
        [StringValue("997")]
        FunctionalAcknowledgment,
        [Description("Set Cancellation")]
        [StringValue("998")]
        SetCancellation
    }
}
