/**
 * PPRetailTransactionRecord.h
 *
 * DO NOT EDIT THIS FILE! IT IS AUTOMATICALLY GENERATED AND SHOULD NOT BE CHECKED IN.
 * Generated from: dist/transaction/TransactionRecord.js
 *
 * 
 */

#import "PayPalRetailSDKTypeDefs.h"
#import "PPRetailObject.h"
#import "PPRetailRecord.h"

@class PPRetailSDK;
@class PPRetailError;
@class PPRetailPayPalErrorInfo;
@class PPRetailAccountSummary;
@class PPRetailAccountSummarySection;
@class PPRetailInvoiceAddress;
@class PPRetailInvoiceAttachment;
@class PPRetailInvoiceBillingInfo;
@class PPRetailInvoiceCCInfo;
@class PPRetailCountries;
@class PPRetailCountry;
@class PPRetailInvoiceCustomAmount;
@class PPRetailInvoice;
@class PPRetailInvoiceActions;
@class PPRetailInvoiceConstants;
@class PPRetailInvoiceListRequest;
@class PPRetailInvoiceListResponse;
@class PPRetailInvoiceMetaData;
@class PPRetailInvoiceTemplatesResponse;
@class PPRetailInvoicingService;
@class PPRetailInvoiceItem;
@class PPRetailInvoiceMerchantInfo;
@class PPRetailInvoiceNotification;
@class PPRetailInvoicePayment;
@class PPRetailInvoicePaymentTerm;
@class PPRetailInvoiceRefund;
@class PPRetailInvoiceSearchRequest;
@class PPRetailInvoiceShippingInfo;
@class PPRetailInvoiceTemplate;
@class PPRetailInvoiceTemplateSettings;
@class PPRetailMerchant;
@class PPRetailNetworkRequest;
@class PPRetailNetworkResponse;
@class PPRetailSdkEnvironmentInfo;
@class PPRetailRetailInvoice;
@class PPRetailRetailInvoicePayment;
@class PPRetailBraintreeManager;
@class PPRetailSimulationManager;
@class PPRetailMerchantManager;
@class PPRetailCaptureHandler;

@class PPRetailTransactionContext;
@class PPRetailTransactionManager;
@class PPRetailTransactionBeginOptions;
@class PPRetailReceiptDestination;
@class PPRetailDeviceManager;
@class PPRetailSignatureReceiver;
@class PPRetailReceiptOptionsViewContent;
@class PPRetailReceiptEmailEntryViewContent;
@class PPRetailReceiptSMSEntryViewContent;
@class PPRetailReceiptViewContent;
@class PPRetailOfflinePaymentStatus;
@class PPRetailOfflinePaymentInfo;
@class PPRetailOfflineTransactionRecord;
@class PPRetailQRCRecord;
@class PPRetailTokenExpirationHandler;
@class PPRetailCard;
@class PPRetailBatteryInfo;
@class PPRetailMagneticCard;
@class PPRetailDigitalCard;
@class PPRetailPaymentDevice;
@class PPRetailManuallyEnteredCard;
@class PPRetailDeviceUpdate;
@class PPRetailCardInsertedHandler;
@class PPRetailDeviceStatus;
@class PPRetailPayer;
@class PPRetailDigitalCardInfo;
@class PPRetailTransactionRecord;
@class PPRetailVaultRecord;
@class PPRetailAuthorizedTransaction;
@class PPRetailPage;
@class PPRetailDiscoveredCardReader;
@class PPRetailCardReaderScanAndDiscoverOptions;
@class PPRetailDeviceConnectorOptions;
@class PPRetailReaderConfiguration;
@class PPRetailSimulationOptions;

/*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*/
/**
 * Information about a completed transaction
 */
@interface PPRetailTransactionRecord : PPRetailRecord
/**
 * The PayPal transaction reference number @readonly
 */
@property (nonatomic,strong,nullable,readonly) NSString* transactionNumber;/**
 * The PayPal invoice id @readonly
 */
@property (nonatomic,strong,nullable,readonly) NSString* invoiceId;/**
 * The payment method used for this payment
 */
@property (nonatomic,assign) PPRetailInvoicePaymentMethod paymentMethod;/**
 * The PayPal authCode @readonly
 */
@property (nonatomic,strong,nullable,readonly) NSString* authCode;/**
 * Payment Mode used for this transaction @readonly
 */
@property (nonatomic,strong,nullable,readonly) NSString* paymentAction;/**
 * An identifier available throughout the EMV transaction flow
 * (allocated before the transaction is complete, unlike transactionNumber) @readonly
 */
@property (nonatomic,strong,nullable,readonly) NSString* transactionHandle;/**
 * The acquirer response code @readonly
 */
@property (nonatomic,strong,nullable,readonly) NSString* responseCode;/**
 * Holds Response information for a digital card payment @readonly
 */
@property (nonatomic,strong,nullable,readonly) PPRetailDigitalCardInfo* digitalCardInfo;/**
 * Information about the payer, if available @readonly
 */
@property (nonatomic,strong,nullable,readonly) PPRetailPayer* payer;/**
 * The correlationId used for obtaining additional support
 * from PayPal for this transaction attempt @readonly
 */
@property (nonatomic,strong,nullable,readonly) NSString* correlationId;/**
 * Indicates whether an email or a text
 * receipt was sent or not. @readonly
 */
@property (nonatomic,strong,nullable,readonly) PPRetailReceiptDestination* receiptDestination;/**
 * The reference id for the captured authorization @readonly
 */
@property (nonatomic,strong,nullable,readonly) NSString* captureId;

- (instancetype _Nullable)init;
    







@end