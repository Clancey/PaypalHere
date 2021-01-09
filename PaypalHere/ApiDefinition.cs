﻿using System;
using Foundation;
using JavaScriptCore;
using ObjCRuntime;
using UIKit;

namespace PayPalHere {
	//Security UIKit JavaScriptCore Foundation SafariServices AVFoundation AudioToolbox CFNetwork CoreBluetooth CoreLocation CoreTelephony ExternalAccessory MediaPlayer MobileCoreServices SystemConfiguration
	// @interface SdkCredential : NSObject
	[BaseType (typeof (NSObject))]
	[DisableDefaultCtor]
	interface SdkCredential {
		// -(id)initWithAccessToken:(NSString *)aToken refreshUrl:(NSString *)rUrl environment:(NSString *)env;
		[Export ("initWithAccessToken:refreshUrl:environment:")]
		IntPtr Constructor (string aToken, string rUrl, string env);

		// -(id)initWithEnvironment:(NSString *)env;
		[Export ("initWithEnvironment:")]
		IntPtr Constructor (string env);

		// -(SdkCredential *)setTokenRefreshUrl:(NSString *)refreshUrl;
		[Export ("setTokenRefreshUrl:")]
		SdkCredential SetTokenRefreshUrl (string refreshUrl);

		// -(SdkCredential *)setRepo:(NSString *)repository;
		[Export ("setRepo:")]
		SdkCredential SetRepo (string repository);

		// -(SdkCredential *)setFirstPartyCredentials:(NSString *)clientId appSecret:(NSString *)appSecret;
		[Export ("setFirstPartyCredentials:appSecret:")]
		SdkCredential SetFirstPartyCredentials (string clientId, string appSecret);

		// -(SdkCredential *)setThirdPartyCredentials:(NSString *)accessToken;
		[Export ("setThirdPartyCredentials:")]
		SdkCredential SetThirdPartyCredentials (string accessToken);

		// @property (copy, nonatomic) NSString * accessToken;
		[Export ("accessToken")]
		string AccessToken { get; set; }

		// @property (copy, nonatomic) NSString * refreshUrl;
		[Export ("refreshUrl")]
		string RefreshUrl { get; set; }

		// @property (copy, nonatomic) NSString * refreshToken;
		[Export ("refreshToken")]
		string RefreshToken { get; set; }

		// @property (copy, nonatomic) NSString * clientId;
		[Export ("clientId")]
		string ClientId { get; set; }

		// @property (copy, nonatomic) NSString * appSecret;
		[Export ("appSecret")]
		string AppSecret { get; set; }

		// @property (copy, nonatomic) NSString * environment;
		[Export ("environment")]
		string Environment { get; set; }

		// @property (copy, nonatomic) NSString * repository;
		[Export ("repository")]
		string Repository { get; set; }
	}

	// @interface PPHRetailMerchantCardSettings : NSObject
	[BaseType (typeof (NSObject))]
	interface PPHRetailMerchantCardSettings {
		// @property (copy, nonatomic) NSString * minimum;
		[Export ("minimum")]
		string Minimum { get; set; }

		// @property (copy, nonatomic) NSString * maximum;
		[Export ("maximum")]
		string Maximum { get; set; }

		// @property (copy, nonatomic) NSString * signatureRequiredAbove;
		[Export ("signatureRequiredAbove")]
		string SignatureRequiredAbove { get; set; }

		// @property (nonatomic, strong) NSArray * unsupportedCardTypes;
		[Export ("unsupportedCardTypes", ArgumentSemantic.Strong)]
		//[Verify (StronglyTypedNSArray)]
		NSObject [] UnsupportedCardTypes { get; set; }
	}

	// @interface PPHRetailMerchantStatus : NSObject
	[BaseType (typeof (NSObject))]
	interface PPHRetailMerchantStatus {
		// @property (copy, nonatomic) NSString * status;
		[Export ("status")]
		string Status { get; set; }

		// @property (nonatomic, strong) NSArray * paymentTypes;
		[Export ("paymentTypes", ArgumentSemantic.Strong)]
		//[Verify (StronglyTypedNSArray)]
		NSObject [] PaymentTypes { get; set; }

		// @property (nonatomic, strong) PPHRetailMerchantCardSettings * cardSettings;
		[Export ("cardSettings", ArgumentSemantic.Strong)]
		PPHRetailMerchantCardSettings CardSettings { get; set; }

		// @property (copy, nonatomic) NSString * currencyCode;
		[Export ("currencyCode")]
		string CurrencyCode { get; set; }

		// @property (assign, nonatomic) BOOL businessCategoryExists;
		[Export ("businessCategoryExists")]
		bool BusinessCategoryExists { get; set; }
	}

	// typedef void (^PPRetailSDKInterceptHandler)(PPRetailNetworkRequest *);
	delegate void PPRetailSDKInterceptHandler (PPRetailNetworkRequest arg0);

	// typedef void (^PPRetailInvoiceGotDetailsHandler)(PPRetailError *);
	delegate void PPRetailInvoiceGotDetailsHandler (PPRetailError arg0);

	// typedef void (^PPRetailInvoiceSavedHandler)(PPRetailError *);
	delegate void PPRetailInvoiceSavedHandler (PPRetailError arg0);

	// typedef void (^PPRetailInvoiceSentHandler)(PPRetailError *);
	delegate void PPRetailInvoiceSentHandler (PPRetailError arg0);

	// typedef void (^PPRetailInvoiceDeletedHandler)(PPRetailError *);
	delegate void PPRetailInvoiceDeletedHandler (PPRetailError arg0);

	// typedef void (^PPRetailInvoiceRemindedHandler)(PPRetailError *);
	delegate void PPRetailInvoiceRemindedHandler (PPRetailError arg0);

	// typedef void (^PPRetailInvoiceCancelledHandler)(PPRetailError *);
	delegate void PPRetailInvoiceCancelledHandler (PPRetailError arg0);

	// typedef void (^PPRetailInvoicePaidHandler)(PPRetailError *);
	delegate void PPRetailInvoicePaidHandler (PPRetailError arg0);

	// typedef void (^PPRetailInvoiceRefundedHandler)(PPRetailError *);
	delegate void PPRetailInvoiceRefundedHandler (PPRetailError arg0);

	// typedef void (^PPRetailInvoicingServiceGetInvoicesHandler)(PPRetailError *, PPRetailInvoiceListResponse *);
	delegate void PPRetailInvoicingServiceGetInvoicesHandler (PPRetailError arg0, PPRetailInvoiceListResponse arg1);

	// typedef void (^PPRetailInvoicingServiceSearchInvoicesHandler)(PPRetailError *, PPRetailInvoiceListResponse *);
	delegate void PPRetailInvoicingServiceSearchInvoicesHandler (PPRetailError arg0, PPRetailInvoiceListResponse arg1);

	// typedef void (^PPRetailInvoicingServiceGetInvoiceHandler)(PPRetailError *, PPRetailInvoice *);
	delegate void PPRetailInvoicingServiceGetInvoiceHandler (PPRetailError arg0, PPRetailInvoice arg1);

	// typedef void (^PPRetailInvoicingServiceGetAccountSummaryHandler)(PPRetailError *, PPRetailAccountSummary *);
	delegate void PPRetailInvoicingServiceGetAccountSummaryHandler (PPRetailError arg0, PPRetailAccountSummary arg1);

	// typedef void (^PPRetailInvoicingServiceGetTemplatesHandler)(PPRetailError *, PPRetailInvoiceTemplatesResponse *);
	delegate void PPRetailInvoicingServiceGetTemplatesHandler (PPRetailError arg0, PPRetailInvoiceTemplatesResponse arg1);

	// typedef void (^PPRetailInvoicingServiceGetNextInvoiceNumberHandler)(PPRetailError *, NSString *);
	delegate void PPRetailInvoicingServiceGetNextInvoiceNumberHandler (PPRetailError arg0, string arg1);

	// typedef void (^PPRetailInvoicingServiceUploadFileHandler)(PPRetailError *, PPRetailInvoiceAttachment *);
	delegate void PPRetailInvoicingServiceUploadFileHandler (PPRetailError arg0, PPRetailInvoiceAttachment arg1);

	// typedef void (^PPRetailMerchantReceiptForwardedHandler)(PPRetailError *);
	delegate void PPRetailMerchantReceiptForwardedHandler (PPRetailError arg0);

	// typedef void (^PPRetailMerchantTokenExpirationHandlerHandler)(PPRetailTokenExpirationHandler *);
	delegate void PPRetailMerchantTokenExpirationHandlerHandler (PPRetailTokenExpirationHandler arg0);

	// typedef void (^PPRetailTransactionContextTransactionCompletedHandler)(PPRetailError *, PPRetailTransactionRecord *);
	delegate void PPRetailTransactionContextTransactionCompletedHandler (PPRetailError arg0, PPRetailTransactionRecord arg1);

	// typedef void (^PPRetailTransactionContextVaultCompletedHandler)(PPRetailError *, PPRetailVaultRecord *);
	delegate void PPRetailTransactionContextVaultCompletedHandler (PPRetailError arg0, PPRetailVaultRecord arg1);

	// typedef void (^PPRetailTransactionContextOfflineTransactionAddedHandler)(PPRetailError *, PPRetailOfflineTransactionRecord *);
	delegate void PPRetailTransactionContextOfflineTransactionAddedHandler (PPRetailError arg0, PPRetailOfflineTransactionRecord arg1);

	// typedef void (^PPRetailTransactionContextOnQRCStatusHandler)(PPRetailError *, PPRetailQRCRecord *);
	delegate void PPRetailTransactionContextOnQRCStatusHandler (PPRetailError arg0, PPRetailQRCRecord arg1);

	// typedef void (^PPRetailTransactionContextCardPresentedHandler)(PPRetailCard *);
	delegate void PPRetailTransactionContextCardPresentedHandler (PPRetailCard arg0);

	// typedef void (^PPRetailTransactionContextSignatureCollectorHandler)(PPRetailSignatureReceiver *);
	delegate void PPRetailTransactionContextSignatureCollectorHandler (PPRetailSignatureReceiver arg0);

	// typedef void (^PPRetailTransactionContextTokenExpirationHandlerHandler)(PPRetailTokenExpirationHandler *);
	delegate void PPRetailTransactionContextTokenExpirationHandlerHandler (PPRetailTokenExpirationHandler arg0);

	// typedef void (^PPRetailTransactionContextCardInsertedHandlerHandler)(PPRetailCardInsertedHandler *);
	delegate void PPRetailTransactionContextCardInsertedHandlerHandler (PPRetailCardInsertedHandler arg0);

	// typedef void (^PPRetailTransactionContextOnAuthCompleteHandler)(PPRetailError *, PPRetailCaptureHandler *, PPRetailTransactionRecord *);
	delegate void PPRetailTransactionContextOnAuthCompleteHandler (PPRetailError arg0, PPRetailCaptureHandler arg1, PPRetailTransactionRecord arg2);

	// typedef void (^PPRetailTransactionContextReceiptOptionHandlerHandler)(int, NSString *, PPRetailTransactionRecord *);
	delegate void PPRetailTransactionContextReceiptOptionHandlerHandler (int arg0, string arg1, PPRetailTransactionRecord arg2);

	// typedef void (^PPRetailTransactionContextCancellationHandlerHandler)(PPRetailError *, NSString *);
	delegate void PPRetailTransactionContextCancellationHandlerHandler (PPRetailError arg0, string arg1);

	// typedef void (^PPRetailTransactionContextCompleteHandler)(PPRetailError *);
	delegate void PPRetailTransactionContextCompleteHandler (PPRetailError arg0);

	// typedef void (^PPRetailTransactionContextVoidCompletedHandler)(PPRetailError *, PPRetailTransactionRecord *);
	delegate void PPRetailTransactionContextVoidCompletedHandler (PPRetailError arg0, PPRetailTransactionRecord arg1);

	// typedef void (^PPRetailTransactionManagerTransactionHandler)(PPRetailError *, PPRetailTransactionContext *);
	delegate void PPRetailTransactionManagerTransactionHandler (PPRetailError arg0, PPRetailTransactionContext arg1);

	// typedef void (^PPRetailTransactionManagerRetrieveAuthorizedTransactionsHandler)(PPRetailError *, NSArray *, NSString *);
	delegate void PPRetailTransactionManagerRetrieveAuthorizedTransactionsHandler (PPRetailError arg0, NSObject [] arg1, string arg2);

	// typedef void (^PPRetailTransactionManagerVoidAuthorizationHandler)(PPRetailError *);
	delegate void PPRetailTransactionManagerVoidAuthorizationHandler (PPRetailError arg0);

	// typedef void (^PPRetailTransactionManagerCaptureAuthorizedTransactionHandler)(PPRetailError *, NSString *);
	delegate void PPRetailTransactionManagerCaptureAuthorizedTransactionHandler (PPRetailError arg0, string arg1);

	// typedef void (^PPRetailTransactionManagerOfflinePaymentStatusHandler)(PPRetailError *, PPRetailOfflinePaymentInfo *);
	delegate void PPRetailTransactionManagerOfflinePaymentStatusHandler (PPRetailError arg0, PPRetailOfflinePaymentInfo arg1);

	// typedef void (^PPRetailDeviceManagerConnectionHandler)(PPRetailError *, PPRetailPaymentDevice *);
	delegate void PPRetailDeviceManagerConnectionHandler (PPRetailError arg0, PPRetailPaymentDevice arg1);

	// typedef void (^PPRetailDeviceManagerPairedBTDevicesHandler)(NSArray *);
	delegate void PPRetailDeviceManagerPairedBTDevicesHandler (NSObject [] arg0);

	// typedef void (^PPRetailPaymentDeviceBatteryInfoHandler)(PPRetailError *, PPRetailBatteryInfo *);
	delegate void PPRetailPaymentDeviceBatteryInfoHandler (PPRetailError arg0, PPRetailBatteryInfo arg1);

	// typedef void (^PPRetailPaymentDeviceConnectHandler)(PPRetailError *);
	delegate void PPRetailPaymentDeviceConnectHandler (PPRetailError arg0);

	// typedef void (^PPRetailPaymentDeviceDisconnectHandler)(PPRetailError *);
	delegate void PPRetailPaymentDeviceDisconnectHandler (PPRetailError arg0);

	// typedef void (^PPRetailPaymentDeviceDeviceLogsHandler)(PPRetailError *);
	delegate void PPRetailPaymentDeviceDeviceLogsHandler (PPRetailError arg0);

	// typedef void (^PPRetailDeviceUpdateCompletedHandler)(PPRetailError *, BOOL);
	delegate void PPRetailDeviceUpdateCompletedHandler (PPRetailError arg0, bool arg1);

	// typedef void (^PPRetailAuthorizedTransactionVoidCompleteHandler)(PPRetailError *);
	delegate void PPRetailAuthorizedTransactionVoidCompleteHandler (PPRetailError arg0);

	// typedef void (^PPRetailAuthorizedTransactionCaptureCompleteHandler)(PPRetailError *, NSString *);
	delegate void PPRetailAuthorizedTransactionCaptureCompleteHandler (PPRetailError arg0, string arg1);

	// typedef void (^PPRetailPageViewedEvent)(PPRetailError *, PPRetailPage *);
	delegate void PPRetailPageViewedEvent (PPRetailError arg0, PPRetailPage arg1);

	// typedef void (^PPRetailUntrustedNetworkEvent)(PPRetailError *);
	delegate void PPRetailUntrustedNetworkEvent (PPRetailError arg0);

	// typedef void (^PPRetailContactlessReaderDeactivatedEvent)();
	delegate void PPRetailContactlessReaderDeactivatedEvent ();

	// typedef void (^PPRetailContactlessReaderActivatedEvent)();
	delegate void PPRetailContactlessReaderActivatedEvent ();

	// typedef void (^PPRetailPinEntryEvent)(BOOL, BOOL, int, BOOL);
	delegate void PPRetailPinEntryEvent (bool arg0, bool arg1, int arg2, bool arg3);

	// typedef void (^PPRetailWillPresentSignatureEvent)();
	delegate void PPRetailWillPresentSignatureEvent ();

	// typedef void (^PPRetailReaderTippingCompletedEvent)(NSDecimalNumber *);
	delegate void PPRetailReaderTippingCompletedEvent (NSDecimalNumber arg0);

	// typedef void (^PPRetailDidCompleteSignatureEvent)(PPRetailError *);
	delegate void PPRetailDidCompleteSignatureEvent (PPRetailError arg0);

	// typedef void (^PPRetailDeviceDiscoveredEvent)(PPRetailPaymentDevice *);
	delegate void PPRetailDeviceDiscoveredEvent (PPRetailPaymentDevice arg0);

	// typedef void (^PPRetailCancelledEvent)();
	delegate void PPRetailCancelledEvent ();

	// typedef void (^PPRetailConnectedEvent)();
	delegate void PPRetailConnectedEvent ();

	// typedef void (^PPRetailSelectedEvent)();
	delegate void PPRetailSelectedEvent ();

	// typedef void (^PPRetailConnectionErrorEvent)(PPRetailError *);
	delegate void PPRetailConnectionErrorEvent (PPRetailError arg0);

	// typedef void (^PPRetailDisconnectedEvent)(PPRetailError *);
	delegate void PPRetailDisconnectedEvent (PPRetailError arg0);

	// typedef void (^PPRetailUpdateRequiredEvent)(PPRetailDeviceUpdate *);
	delegate void PPRetailUpdateRequiredEvent (PPRetailDeviceUpdate arg0);

	// typedef void (^PPRetailBatteryStatusUpdateEvent)(PPRetailBatteryInfo *);
	delegate void PPRetailBatteryStatusUpdateEvent (PPRetailBatteryInfo arg0);

	// typedef void (^PPRetailCardRemovedEvent)();
	delegate void PPRetailCardRemovedEvent ();

	// typedef void (^PPRetailCardPresentedEvent)(PPRetailCard *);
	delegate void PPRetailCardPresentedEvent (PPRetailCard arg0);

	// typedef void (^PPRetailBlacklistedEvent)();
	delegate void PPRetailBlacklistedEvent ();

	// typedef void (^PPRetailReconnectReaderEvent)(int);
	delegate void PPRetailReconnectReaderEvent (int arg0);

	// typedef void (^PPRetailOnCardReaderDiscoveredEvent)(PPRetailDiscoveredCardReader *);
	delegate void PPRetailOnCardReaderDiscoveredEvent (PPRetailDiscoveredCardReader arg0);

	// typedef void (^PPRetailOnScanCompleteEvent)(PPRetailError *);
	delegate void PPRetailOnScanCompleteEvent (PPRetailError arg0);

	// typedef void (^PPRetailOnConnectionStatusEvent)(PPRetailError *, PPRetailDiscoveredCardReader *);
	delegate void PPRetailOnConnectionStatusEvent (PPRetailError arg0, PPRetailDiscoveredCardReader arg1);

	// typedef void (^PPRetailOnConnectionResultEvent)(PPRetailError *, PPRetailPaymentDevice *);
	delegate void PPRetailOnConnectionResultEvent (PPRetailError arg0, PPRetailPaymentDevice arg1);

	// @protocol PPManticoreNativeObjectProtocol <NSObject>
	[Protocol, Model]
	//[BaseType (typeof (NSObject))]
	interface IPPManticoreNativeObjectProtocol {
		// @required -(JSValue *)impl;
		[Abstract]
		[Export ("impl")]
		//[Verify (MethodToProperty)]
		JSValue Impl { get; }

		// @required +(PPManticoreEngine *)engine;
		//[Static, Abstract]
		//[Export ("engine")]
		//[Verify (MethodToProperty)]
		//PPManticoreEngine Engine { get; }

		// @required +(Class)nativeClassForObject:(JSValue *)value;
		[Static, Abstract]
		[Export ("nativeClassForObject:")]
		Class NativeClassForObject (JSValue value);

		// @required -(id)initFromJavascript:(JSValue *)value;
		[Abstract]
		[Export ("initFromJavascript:")]
		IntPtr Constructor (JSValue value);
	}

	// @interface PPManticoreEventHolder : NSObject
	[BaseType (typeof (NSObject))]
	interface PPManticoreEventHolder {
		// @property (copy, nonatomic) id block;
		[Export ("block", ArgumentSemantic.Copy)]
		NSObject Block { get; set; }
	}

	// @interface PPManticoreNativeInterface : NSObject <JSExport>
	[BaseType (typeof (NSObject))]
	interface PPManticoreNativeInterface : IJSExport {
		// @property (readonly, nonatomic, strong) JSValue * manticoreObject;
		[Export ("manticoreObject", ArgumentSemantic.Strong)]
		JSValue ManticoreObject { get; }

		// @property (nonatomic) NSURLSession * urlSession;
		[Export ("urlSession", ArgumentSemantic.Assign)]
		NSUrlSession UrlSession { get; set; }

		// @property (readonly, nonatomic, strong) JSValue * globalObject;
		[Export ("globalObject", ArgumentSemantic.Strong)]
		JSValue GlobalObject { get; }

		// -(instancetype)initWithEngine:(PPManticoreEngine *)engine;
		//[Export ("initWithEngine:")]
		//IntPtr Constructor (PPManticoreEngine engine);

		// -(void)log:(NSString *)level component:(NSString *)component message:(NSString *)message;
		[Export ("log:component:message:")]
		void Log (string level, string component, string message);

		// -(JSValue *)http:(JSValue *)options callback:(JSValue *)callback;
		[Export ("http:callback:")]
		JSValue Http (JSValue options, JSValue callback);

		// -(JSValue *)setTimeout:(void (^)())function after:(NSInteger)milliseconds;
		[Export ("setTimeout:after:")]
		JSValue SetTimeout (Action function, nint milliseconds);

		// -(JSValue *)setInterval:(void (^)())function after:(NSInteger)milliseconds;
		[Export ("setInterval:after:")]
		JSValue SetInterval (Action function, nint milliseconds);

		// -(void)clearInterval:(JSValue *)jsValue;
		[Export ("clearInterval:")]
		void ClearInterval (JSValue jsValue);

		// -(void)clearTimeout:(JSValue *)jsValue;
		[Export ("clearTimeout:")]
		void ClearTimeout (JSValue jsValue);
	}

	// @interface PPRetailObject : NSObject <PPManticoreNativeObjectProtocol>
	[BaseType (typeof (NSObject))]
	interface PPRetailObject : IPPManticoreNativeObjectProtocol {
		// @property (nonatomic, strong) JSValue * impl;
		//[Export ("impl", ArgumentSemantic.Strong)]
		//JSValue Impl { get; set; }
	}

	// @interface PPRetailInvoiceAddress : PPRetailObject
	[BaseType (typeof (PPRetailObject))]
	interface PPRetailInvoiceAddress {
		// @property (nonatomic, strong) NSString * _Nullable line1;
		[NullAllowed, Export ("line1", ArgumentSemantic.Strong)]
		string Line1 { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable line2;
		[NullAllowed, Export ("line2", ArgumentSemantic.Strong)]
		string Line2 { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable city;
		[NullAllowed, Export ("city", ArgumentSemantic.Strong)]
		string City { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable state;
		[NullAllowed, Export ("state", ArgumentSemantic.Strong)]
		string State { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable postalCode;
		[NullAllowed, Export ("postalCode", ArgumentSemantic.Strong)]
		string PostalCode { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable country;
		[NullAllowed, Export ("country", ArgumentSemantic.Strong)]
		string Country { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable phone;
		[NullAllowed, Export ("phone", ArgumentSemantic.Strong)]
		string Phone { get; set; }

		// @property (assign, nonatomic) BOOL isPrimary;
		[Export ("isPrimary")]
		bool IsPrimary { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable addressee;
		[NullAllowed, Export ("addressee", ArgumentSemantic.Strong)]
		string Addressee { get; set; }

		// -(BOOL)hasAnyValue;
		[Export ("hasAnyValue")]
		//[Verify (MethodToProperty)]
		bool HasAnyValue { get; }
	}

	// @interface PPHRetailMerchantUserInfo : NSObject
	[BaseType (typeof (NSObject))]
	interface PPHRetailMerchantUserInfo {
		// @property (copy, nonatomic) NSString * name;
		[Export ("name")]
		string Name { get; set; }

		// @property (copy, nonatomic) NSString * givenName;
		[Export ("givenName")]
		string GivenName { get; set; }

		// @property (copy, nonatomic) NSString * familyName;
		[Export ("familyName")]
		string FamilyName { get; set; }

		// @property (copy, nonatomic) NSString * email;
		[Export ("email")]
		string Email { get; set; }

		// @property (copy, nonatomic) NSString * businessSubCategory;
		[Export ("businessSubCategory")]
		string BusinessSubCategory { get; set; }

		// @property (copy, nonatomic) NSString * businessCategory;
		[Export ("businessCategory")]
		string BusinessCategory { get; set; }

		// @property (copy, nonatomic) NSString * payerId;
		[Export ("payerId")]
		string PayerId { get; set; }

		// @property (nonatomic, strong) PPRetailInvoiceAddress * address;
		[Export ("address", ArgumentSemantic.Strong)]
		PPRetailInvoiceAddress Address { get; set; }
	}

	// @interface PPHRetailMerchant : NSObject
	[BaseType (typeof (NSObject))]
	interface PPHRetailMerchant {
		// @property (nonatomic, strong) SdkCredential * credential;
		[Export ("credential", ArgumentSemantic.Strong)]
		SdkCredential Credential { get; set; }

		// @property (nonatomic, strong) PPHRetailMerchantStatus * status;
		[Export ("status", ArgumentSemantic.Strong)]
		PPHRetailMerchantStatus Status { get; set; }

		// @property (nonatomic, strong) PPHRetailMerchantUserInfo * userInfo;
		[Export ("userInfo", ArgumentSemantic.Strong)]
		PPHRetailMerchantUserInfo UserInfo { get; set; }

		// @property (copy, nonatomic) NSString * logglyAccessToken;
		[Export ("logglyAccessToken")]
		string LogglyAccessToken { get; set; }

		// @property (copy, nonatomic) NSString * pairingId;
		[Export ("pairingId")]
		string PairingId { get; set; }
	}

	// @interface PPInstrumentationConstants : NSObject
	[BaseType (typeof (NSObject))]
	interface PPInstrumentationConstants {
	}

	[Static]
	//[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants {
		// extern NSString *const _Nonnull READER_CONNECTION_ASK;
		[Field ("READER_CONNECTION_ASK", "__Internal")]
		NSString READER_CONNECTION_ASK { get; }

		// extern NSString *const _Nonnull READER_ASK_CONNECT_CLICKED;
		[Field ("READER_ASK_CONNECT_CLICKED", "__Internal")]
		NSString READER_ASK_CONNECT_CLICKED { get; }

		// extern NSString *const _Nonnull READER_ASK_CLOSED;
		[Field ("READER_ASK_CLOSED", "__Internal")]
		NSString READER_ASK_CLOSED { get; }

		// extern NSString *const _Nonnull READER_ASK_FIND_ANOTHER_CLICKED;
		[Field ("READER_ASK_FIND_ANOTHER_CLICKED", "__Internal")]
		NSString READER_ASK_FIND_ANOTHER_CLICKED { get; }

		// extern NSString *const _Nonnull READER_FIND_REFRESH_CLICKED;
		[Field ("READER_FIND_REFRESH_CLICKED", "__Internal")]
		NSString READER_FIND_REFRESH_CLICKED { get; }

		// extern NSString *const _Nonnull READER_FIND_CONNECT_CLICKED;
		[Field ("READER_FIND_CONNECT_CLICKED", "__Internal")]
		NSString READER_FIND_CONNECT_CLICKED { get; }

		// extern NSString *const _Nonnull READER_FIND_CLOSED;
		[Field ("READER_FIND_CLOSED", "__Internal")]
		NSString READER_FIND_CLOSED { get; }

		// extern NSString *const _Nonnull TRANSACTION_SIGNATURE;
		[Field ("TRANSACTION_SIGNATURE", "__Internal")]
		NSString TRANSACTION_SIGNATURE { get; }

		// extern NSString *const _Nonnull TRANSACTION_SIGNATURE_DONE;
		[Field ("TRANSACTION_SIGNATURE_DONE", "__Internal")]
		NSString TRANSACTION_SIGNATURE_DONE { get; }

		// extern NSString *const _Nonnull TRANSACTION_SIGNATURE_CANCEL;
		[Field ("TRANSACTION_SIGNATURE_CANCEL", "__Internal")]
		NSString TRANSACTION_SIGNATURE_CANCEL { get; }

		// extern NSString *const _Nonnull TRANSACTION_RECEIPT;
		[Field ("TRANSACTION_RECEIPT", "__Internal")]
		NSString TRANSACTION_RECEIPT { get; }

		// extern NSString *const _Nonnull TRANSACTION_RECEIPT_OPTION_SELECTED;
		[Field ("TRANSACTION_RECEIPT_OPTION_SELECTED", "__Internal")]
		NSString TRANSACTION_RECEIPT_OPTION_SELECTED { get; }

		// extern NSString *const _Nonnull RECEIPT_TYPE;
		[Field ("RECEIPT_TYPE", "__Internal")]
		NSString RECEIPT_TYPE { get; }
	}

	// @interface PPRetailAccountSummary : PPRetailObject
	[BaseType (typeof (PPRetailObject))]
	interface PPRetailAccountSummary {
		// @property (nonatomic, strong) NSDecimalNumber * _Nullable outstandingAmount;
		[NullAllowed, Export ("outstandingAmount", ArgumentSemantic.Strong)]
		NSDecimalNumber OutstandingAmount { get; set; }

		// @property (nonatomic, strong) PPRetailAccountSummarySection * _Nullable pastDueSection;
		[NullAllowed, Export ("pastDueSection", ArgumentSemantic.Strong)]
		PPRetailAccountSummarySection PastDueSection { get; set; }

		// @property (nonatomic, strong) PPRetailAccountSummarySection * _Nullable awaitingPaymentSection;
		[NullAllowed, Export ("awaitingPaymentSection", ArgumentSemantic.Strong)]
		PPRetailAccountSummarySection AwaitingPaymentSection { get; set; }

		// @property (nonatomic, strong) PPRetailAccountSummarySection * _Nullable draftSection;
		[NullAllowed, Export ("draftSection", ArgumentSemantic.Strong)]
		PPRetailAccountSummarySection DraftSection { get; set; }

		// @property (nonatomic, strong) PPRetailAccountSummarySection * _Nullable paidSection;
		[NullAllowed, Export ("paidSection", ArgumentSemantic.Strong)]
		PPRetailAccountSummarySection PaidSection { get; set; }
	}

	// @interface PPRetailAccountSummarySection : PPRetailObject
	[BaseType (typeof (PPRetailObject))]
	interface PPRetailAccountSummarySection {
		// @property (nonatomic, strong) NSDecimalNumber * _Nullable totalCount;
		[NullAllowed, Export ("totalCount", ArgumentSemantic.Strong)]
		NSDecimalNumber TotalCount { get; set; }

		// @property (nonatomic, strong) NSDecimalNumber * _Nullable totalAmount;
		[NullAllowed, Export ("totalAmount", ArgumentSemantic.Strong)]
		NSDecimalNumber TotalAmount { get; set; }

		// @property (nonatomic, strong) NSDecimalNumber * _Nullable paidAmount;
		[NullAllowed, Export ("paidAmount", ArgumentSemantic.Strong)]
		NSDecimalNumber PaidAmount { get; set; }

		// @property (nonatomic, strong) NSDecimalNumber * _Nullable refundedAmount;
		[NullAllowed, Export ("refundedAmount", ArgumentSemantic.Strong)]
		NSDecimalNumber RefundedAmount { get; set; }
	}

	// @interface PPRetailAuthorizedTransaction : PPRetailObject
	[BaseType (typeof (PPRetailObject))]
	[DisableDefaultCtor]
	interface PPRetailAuthorizedTransaction {
		// @property (readonly, nonatomic, strong) NSString * _Nullable authorizationId;
		[NullAllowed, Export ("authorizationId", ArgumentSemantic.Strong)]
		string AuthorizationId { get; }

		// @property (readonly, nonatomic, strong) NSString * _Nullable invoiceId;
		[NullAllowed, Export ("invoiceId", ArgumentSemantic.Strong)]
		string InvoiceId { get; }

		// @property (nonatomic, strong) NSDate * _Nullable timeCreated;
		[NullAllowed, Export ("timeCreated", ArgumentSemantic.Strong)]
		NSDate TimeCreated { get; set; }

		// @property (nonatomic, strong) NSDecimalNumber * _Nullable authorizedAmount;
		[NullAllowed, Export ("authorizedAmount", ArgumentSemantic.Strong)]
		NSDecimalNumber AuthorizedAmount { get; set; }

		// @property (readonly, nonatomic, strong) NSString * _Nullable currency;
		[NullAllowed, Export ("currency", ArgumentSemantic.Strong)]
		string Currency { get; }

		// @property (nonatomic, strong) NSString * _Nullable status;
		[NullAllowed, Export ("status", ArgumentSemantic.Strong)]
		string Status { get; set; }

		// -(instancetype _Nullable)initWithAuthorizationId:(NSString * _Nullable)authorizationId invoiceId:(NSString * _Nullable)invoiceId currency:(NSString * _Nullable)currency;
		[Export ("initWithAuthorizationId:invoiceId:currency:")]
		IntPtr Constructor ([NullAllowed] string authorizationId, [NullAllowed] string invoiceId, [NullAllowed] string currency);

		// -(void)voidTransaction:(PPRetailAuthorizedTransactionVoidCompleteHandler _Nullable)callback;
		[Export ("voidTransaction:")]
		void VoidTransaction ([NullAllowed] PPRetailAuthorizedTransactionVoidCompleteHandler callback);

		// -(void)captureTransaction:(NSDecimalNumber * _Nullable)totalAmount gratuityAmount:(NSDecimalNumber * _Nullable)gratuityAmount callback:(PPRetailAuthorizedTransactionCaptureCompleteHandler _Nullable)callback;
		[Export ("captureTransaction:gratuityAmount:callback:")]
		void CaptureTransaction ([NullAllowed] NSDecimalNumber totalAmount, [NullAllowed] NSDecimalNumber gratuityAmount, [NullAllowed] PPRetailAuthorizedTransactionCaptureCompleteHandler callback);

		// -(void)captureTransaction:(NSDecimalNumber * _Nullable)totalAmount gratuityAmount:(NSDecimalNumber * _Nullable)gratuityAmount base64SignatureJpeg:(NSString * _Nullable)base64SignatureJpeg callback:(PPRetailAuthorizedTransactionCaptureCompleteHandler _Nullable)callback;
		[Export ("captureTransaction:gratuityAmount:base64SignatureJpeg:callback:")]
		void CaptureTransaction ([NullAllowed] NSDecimalNumber totalAmount, [NullAllowed] NSDecimalNumber gratuityAmount, [NullAllowed] string base64SignatureJpeg, [NullAllowed] PPRetailAuthorizedTransactionCaptureCompleteHandler callback);
	}

	// @interface PPRetailBatteryInfo : PPRetailObject
	[BaseType (typeof (PPRetailObject))]
	[DisableDefaultCtor]
	interface PPRetailBatteryInfo {
		// @property (readonly, assign, nonatomic) int percentage;
		[Export ("percentage")]
		int Percentage { get; }

		// @property (readonly, assign, nonatomic) BOOL isCharging;
		[Export ("isCharging")]
		bool IsCharging { get; }

		// @property (readonly, assign, nonatomic) BOOL isLevelCritical;
		[Export ("isLevelCritical")]
		bool IsLevelCritical { get; }

		// @property (readonly, assign, nonatomic) BOOL isLevelUpdateCritical;
		[Export ("isLevelUpdateCritical")]
		bool IsLevelUpdateCritical { get; }

		// @property (readonly, nonatomic, strong) NSDate * _Nullable measuredOn;
		[NullAllowed, Export ("measuredOn", ArgumentSemantic.Strong)]
		NSDate MeasuredOn { get; }

		// @property (readonly, assign, nonatomic) PPRetailbatteryStatus status;
		[Export ("status", ArgumentSemantic.Assign)]
		PPRetailbatteryStatus Status { get; }

		// -(instancetype _Nullable)initWithPercentage:(int)percentage measuredOn:(NSDate * _Nullable)measuredOn status:(PPRetailbatteryStatus)status;
		[Export ("initWithPercentage:measuredOn:status:")]
		IntPtr Constructor (int percentage, [NullAllowed] NSDate measuredOn, PPRetailbatteryStatus status);
	}

	// @interface PPRetailBraintreeManager : PPRetailObject
	[BaseType (typeof (PPRetailObject))]
	interface PPRetailBraintreeManager {
		// -(NSString * _Nullable)getBtLoginUrl;
		[NullAllowed, Export ("getBtLoginUrl")]
		//[Verify (MethodToProperty)]
		string BtLoginUrl { get; }

		// -(BOOL)isBtReturnUrlValid:(NSString * _Nullable)returnUrl;
		[Export ("isBtReturnUrlValid:")]
		bool IsBtReturnUrlValid ([NullAllowed] string returnUrl);
	}

	// @interface PPRetailCaptureHandler : PPRetailObject
	[BaseType (typeof (PPRetailObject))]
	interface PPRetailCaptureHandler {
		// -(void)doCapture:(NSDecimalNumber * _Nullable)gratuityAmount signature:(NSString * _Nullable)signature;
		[Export ("doCapture:signature:")]
		void DoCapture ([NullAllowed] NSDecimalNumber gratuityAmount, [NullAllowed] string signature);

		// -(void)doVoid;
		[Export ("doVoid")]
		void DoVoid ();
	}

	// @interface PPRetailCard : PPRetailObject
	[BaseType (typeof (PPRetailObject))]
	interface PPRetailCard {
		// @property (readonly, assign, nonatomic) PPRetailFormFactor formFactor;
		[Export ("formFactor", ArgumentSemantic.Assign)]
		PPRetailFormFactor FormFactor { get; }

		// @property (readonly, assign, nonatomic) BOOL failed;
		[Export ("failed")]
		bool Failed { get; }

		// @property (readonly, nonatomic, strong) PPRetailPaymentDevice * _Nullable reader;
		[NullAllowed, Export ("reader", ArgumentSemantic.Strong)]
		PPRetailPaymentDevice Reader { get; }

		// @property (readonly, nonatomic, strong) NSString * _Nullable timestamp;
		[NullAllowed, Export ("timestamp", ArgumentSemantic.Strong)]
		string Timestamp { get; }

		// @property (readonly, nonatomic, strong) NSString * _Nullable lastFourDigits;
		[NullAllowed, Export ("lastFourDigits", ArgumentSemantic.Strong)]
		string LastFourDigits { get; }

		// @property (readonly, nonatomic, strong) NSString * _Nullable firstFourDigits;
		[NullAllowed, Export ("firstFourDigits", ArgumentSemantic.Strong)]
		string FirstFourDigits { get; }

		// @property (readonly, nonatomic, strong) NSString * _Nullable firstSixDigits;
		[NullAllowed, Export ("firstSixDigits", ArgumentSemantic.Strong)]
		string FirstSixDigits { get; }

		// @property (readonly, nonatomic, strong) NSString * _Nullable panNumber;
		[NullAllowed, Export ("panNumber", ArgumentSemantic.Strong)]
		string PanNumber { get; }

		// @property (readonly, assign, nonatomic) PPRetailCardIssuer cardIssuer;
		[Export ("cardIssuer", ArgumentSemantic.Assign)]
		PPRetailCardIssuer CardIssuer { get; }

		// @property (readonly, nonatomic, strong) NSString * _Nullable cardholderName;
		[NullAllowed, Export ("cardholderName", ArgumentSemantic.Strong)]
		string CardholderName { get; }

		// @property (readonly, assign, nonatomic) BOOL pinPresent;
		[Export ("pinPresent")]
		bool PinPresent { get; }

		// @property (readonly, assign, nonatomic) BOOL isContactlessMSD;
		[Export ("isContactlessMSD")]
		bool IsContactlessMSD { get; }

		// @property (readonly, assign, nonatomic) BOOL isSignatureRequired;
		[Export ("isSignatureRequired")]
		bool IsSignatureRequired { get; }

		// -(BOOL)isEmv;
		[Export ("isEmv")]
		//[Verify (MethodToProperty)]
		bool IsEmv { get; }
	}

	// @interface PPRetailCardInsertedHandler : PPRetailObject
	[BaseType (typeof (PPRetailObject))]
	interface PPRetailCardInsertedHandler {
		// -(void)continueWithCardDataRead;
		[Export ("continueWithCardDataRead")]
		void ContinueWithCardDataRead ();

		// -(void)dismissSDKUIPrompt;
		[Export ("dismissSDKUIPrompt")]
		void DismissSDKUIPrompt ();
	}

	// @interface PPRetailCardReaderScanAndDiscoverOptions : PPRetailObject
	[BaseType (typeof (PPRetailObject))]
	interface PPRetailCardReaderScanAndDiscoverOptions {
		// -(void)connectToCardReader:(NSString * _Nullable)id;
		[Export ("connectToCardReader:")]
		void ConnectToCardReader ([NullAllowed] string id);

		// -(void)onAddedObserver;
		[Export ("onAddedObserver")]
		void OnAddedObserver ();

		// -(PPRetailOnCardReaderDiscoveredSignal _Nullable)addOnCardReaderDiscoveredListener:(PPRetailOnCardReaderDiscoveredEvent _Nullable)listener;
		[Export ("addOnCardReaderDiscoveredListener:")]
		[return: NullAllowed]
		NSObject AddOnCardReaderDiscoveredListener ([NullAllowed] PPRetailOnCardReaderDiscoveredEvent listener);

		// -(void)removeOnCardReaderDiscoveredListener:(PPRetailOnCardReaderDiscoveredSignal _Nullable)listenerToken;
		[Export ("removeOnCardReaderDiscoveredListener:")]
		void RemoveOnCardReaderDiscoveredListener ([NullAllowed] NSObject listenerToken);

		// -(PPRetailOnScanCompleteSignal _Nullable)addOnScanCompleteListener:(PPRetailOnScanCompleteEvent _Nullable)listener;
		[Export ("addOnScanCompleteListener:")]
		[return: NullAllowed]
		NSObject AddOnScanCompleteListener ([NullAllowed] PPRetailOnScanCompleteEvent listener);

		// -(void)removeOnScanCompleteListener:(PPRetailOnScanCompleteSignal _Nullable)listenerToken;
		[Export ("removeOnScanCompleteListener:")]
		void RemoveOnScanCompleteListener ([NullAllowed] NSObject listenerToken);

		// -(PPRetailOnConnectionStatusSignal _Nullable)addOnConnectionStatusListener:(PPRetailOnConnectionStatusEvent _Nullable)listener;
		[Export ("addOnConnectionStatusListener:")]
		[return: NullAllowed]
		NSObject AddOnConnectionStatusListener ([NullAllowed] PPRetailOnConnectionStatusEvent listener);

		// -(void)removeOnConnectionStatusListener:(PPRetailOnConnectionStatusSignal _Nullable)listenerToken;
		[Export ("removeOnConnectionStatusListener:")]
		void RemoveOnConnectionStatusListener ([NullAllowed] NSObject listenerToken);
	}

	// @interface PPRetailCountries : PPRetailObject
	[BaseType (typeof (PPRetailObject))]
	interface PPRetailCountries {
		// +(NSArray * _Nullable)countries;
		[Static]
		[NullAllowed, Export ("countries")]
		//[Verify (MethodToProperty), Verify (StronglyTypedNSArray)]
		NSObject [] Countries { get; }

		// +(NSString * _Nullable)countryForCountryCode:(NSString * _Nullable)countryCode;
		[Static]
		[Export ("countryForCountryCode:")]
		[return: NullAllowed]
		string CountryForCountryCode ([NullAllowed] string countryCode);
	}

	// @interface PPRetailCountry : PPRetailObject
	[BaseType (typeof (PPRetailObject))]
	[DisableDefaultCtor]
	interface PPRetailCountry {
		// @property (readonly, nonatomic, strong) NSString * _Nullable code;
		[NullAllowed, Export ("code", ArgumentSemantic.Strong)]
		string Code { get; }

		// @property (readonly, nonatomic, strong) NSString * _Nullable name;
		[NullAllowed, Export ("name", ArgumentSemantic.Strong)]
		string Name { get; }

		// -(instancetype _Nullable)initWithCountryCode:(NSString * _Nullable)countryCode countryName:(NSString * _Nullable)countryName;
		[Export ("initWithCountryCode:countryName:")]
		IntPtr Constructor ([NullAllowed] string countryCode, [NullAllowed] string countryName);
	}

	// @interface PPRetailDeviceConnectorOptions : PPRetailObject
	[BaseType (typeof (PPRetailObject))]
	interface PPRetailDeviceConnectorOptions {
		// @property (nonatomic, strong) NSString * _Nullable readerId;
		[NullAllowed, Export ("readerId", ArgumentSemantic.Strong)]
		string ReaderId { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable readerDescription;
		[NullAllowed, Export ("readerDescription", ArgumentSemantic.Strong)]
		string ReaderDescription { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable readerImgId;
		[NullAllowed, Export ("readerImgId", ArgumentSemantic.Strong)]
		string ReaderImgId { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable hardwareAddress;
		[NullAllowed, Export ("hardwareAddress", ArgumentSemantic.Strong)]
		string HardwareAddress { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable titleLastReaderUsed;
		[NullAllowed, Export ("titleLastReaderUsed", ArgumentSemantic.Strong)]
		string TitleLastReaderUsed { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable titleConnected;
		[NullAllowed, Export ("titleConnected", ArgumentSemantic.Strong)]
		string TitleConnected { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable msgConnecting;
		[NullAllowed, Export ("msgConnecting", ArgumentSemantic.Strong)]
		string MsgConnecting { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable msgCheckReader;
		[NullAllowed, Export ("msgCheckReader", ArgumentSemantic.Strong)]
		string MsgCheckReader { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable msgTurnOnBlueTooth;
		[NullAllowed, Export ("msgTurnOnBlueTooth", ArgumentSemantic.Strong)]
		string MsgTurnOnBlueTooth { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable msgConnectionFailed;
		[NullAllowed, Export ("msgConnectionFailed", ArgumentSemantic.Strong)]
		string MsgConnectionFailed { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable msgFindFailed;
		[NullAllowed, Export ("msgFindFailed", ArgumentSemantic.Strong)]
		string MsgFindFailed { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable btnConnect;
		[NullAllowed, Export ("btnConnect", ArgumentSemantic.Strong)]
		string BtnConnect { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable btnFindAnother;
		[NullAllowed, Export ("btnFindAnother", ArgumentSemantic.Strong)]
		string BtnFindAnother { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable btnDone;
		[NullAllowed, Export ("btnDone", ArgumentSemantic.Strong)]
		string BtnDone { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable btnSwitchCardReader;
		[NullAllowed, Export ("btnSwitchCardReader", ArgumentSemantic.Strong)]
		string BtnSwitchCardReader { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable btnTryAgain;
		[NullAllowed, Export ("btnTryAgain", ArgumentSemantic.Strong)]
		string BtnTryAgain { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable btnCancel;
		[NullAllowed, Export ("btnCancel", ArgumentSemantic.Strong)]
		string BtnCancel { get; set; }

		// -(void)connectToLastReader;
		[Export ("connectToLastReader")]
		void ConnectToLastReader ();

		// -(PPRetailOnConnectionResultSignal _Nullable)addOnConnectionResultListener:(PPRetailOnConnectionResultEvent _Nullable)listener;
		[Export ("addOnConnectionResultListener:")]
		[return: NullAllowed]
		NSObject AddOnConnectionResultListener ([NullAllowed] PPRetailOnConnectionResultEvent listener);

		// -(void)removeOnConnectionResultListener:(PPRetailOnConnectionResultSignal _Nullable)listenerToken;
		[Export ("removeOnConnectionResultListener:")]
		void RemoveOnConnectionResultListener ([NullAllowed] NSObject listenerToken);
	}

	// @interface PPRetailDeviceManager : PPRetailObject
	[BaseType (typeof (PPRetailObject))]
	interface PPRetailDeviceManager {
		// -(void)searchAndConnect:(PPRetailReaderConfiguration * _Nullable)readerConfig callback:(PPRetailDeviceManagerConnectionHandler _Nullable)callback;
		[Export ("searchAndConnect:callback:")]
		void SearchAndConnect ([NullAllowed] PPRetailReaderConfiguration readerConfig, [NullAllowed] PPRetailDeviceManagerConnectionHandler callback);

		// -(void)searchAndConnect:(PPRetailDeviceManagerConnectionHandler _Nullable)callback;
		[Export ("searchAndConnect:")]
		void SearchAndConnect ([NullAllowed] PPRetailDeviceManagerConnectionHandler callback);

		// -(void)searchAndConnectWithoutCallback;
		[Export ("searchAndConnectWithoutCallback")]
		void SearchAndConnectWithoutCallback ();

		// -(void)connectToLastActiveReader:(PPRetailDeviceManagerConnectionHandler _Nullable)callback;
		[Export ("connectToLastActiveReader:")]
		void ConnectToLastActiveReader ([NullAllowed] PPRetailDeviceManagerConnectionHandler callback);

		// -(void)scanAndAutoConnectToBluetoothReader:(NSString * _Nullable)readerName callback:(PPRetailDeviceManagerConnectionHandler _Nullable)callback;
		[Export ("scanAndAutoConnectToBluetoothReader:callback:")]
		void ScanAndAutoConnectToBluetoothReader ([NullAllowed] string readerName, [NullAllowed] PPRetailDeviceManagerConnectionHandler callback);

		// -(void)setActiveReader:(PPRetailPaymentDevice * _Nullable)pd;
		[Export ("setActiveReader:")]
		void SetActiveReader ([NullAllowed] PPRetailPaymentDevice pd);

		// -(BOOL)isConnectedToMiura;
		[Export ("isConnectedToMiura")]
		//[Verify (MethodToProperty)]
		bool IsConnectedToMiura { get; }

		// -(PPRetailPaymentDevice * _Nullable)getActiveReader;
		[NullAllowed, Export ("getActiveReader")]
		//[Verify (MethodToProperty)]
		PPRetailPaymentDevice ActiveReader { get; }

		// -(NSArray * _Nullable)getDiscoveredDevices;
		[NullAllowed, Export ("getDiscoveredDevices")]
		//[Verify (MethodToProperty), Verify (StronglyTypedNSArray)]
		NSObject [] DiscoveredDevices { get; }

		// -(NSString * _Nullable)getLastActiveBluetoothReader;
		[NullAllowed, Export ("getLastActiveBluetoothReader")]
		//[Verify (MethodToProperty)]
		string LastActiveBluetoothReader { get; }

		// -(void)getPairedBluetoothDevices:(PPRetailDeviceManagerPairedBTDevicesHandler _Nullable)callback;
		[Export ("getPairedBluetoothDevices:")]
		void GetPairedBluetoothDevices ([NullAllowed] PPRetailDeviceManagerPairedBTDevicesHandler callback);

		// -(void)stopScanningForBluetoothReaders;
		[Export ("stopScanningForBluetoothReaders")]
		void StopScanningForBluetoothReaders ();

		// -(PPRetailDeviceDiscoveredSignal _Nullable)addDeviceDiscoveredListener:(PPRetailDeviceDiscoveredEvent _Nullable)listener;
		[Export ("addDeviceDiscoveredListener:")]
		[return: NullAllowed]
		NSObject AddDeviceDiscoveredListener ([NullAllowed] PPRetailDeviceDiscoveredEvent listener);

		// -(void)removeDeviceDiscoveredListener:(PPRetailDeviceDiscoveredSignal _Nullable)listenerToken;
		[Export ("removeDeviceDiscoveredListener:")]
		void RemoveDeviceDiscoveredListener ([NullAllowed] NSObject listenerToken);
	}

	// @interface PPRetailDeviceStatus : PPRetailObject
	[BaseType (typeof (PPRetailObject))]
	interface PPRetailDeviceStatus {
		// @property (readonly, assign, nonatomic) BOOL isReady;
		[Export ("isReady")]
		bool IsReady { get; }

		// @property (readonly, nonatomic, strong) PPRetailError * _Nullable error;
		[NullAllowed, Export ("error", ArgumentSemantic.Strong)]
		PPRetailError Error { get; }
	}

	// @interface PPRetailDeviceUpdate : PPRetailObject
	[BaseType (typeof (PPRetailObject))]
	[DisableDefaultCtor]
	interface PPRetailDeviceUpdate {
		// @property (assign, nonatomic) BOOL isRequired;
		[Export ("isRequired")]
		bool IsRequired { get; set; }

		// @property (assign, nonatomic) BOOL wasInstalled;
		[Export ("wasInstalled")]
		bool WasInstalled { get; set; }

		// @property (readonly, assign, nonatomic) BOOL updateInProgress;
		[Export ("updateInProgress")]
		bool UpdateInProgress { get; }

		// -(instancetype _Nullable)initWithDevice:(PPRetailPaymentDevice * _Nullable)device;
		[Export ("initWithDevice:")]
		IntPtr Constructor ([NullAllowed] PPRetailPaymentDevice device);

		// -(void)offer:(PPRetailDeviceUpdateCompletedHandler _Nullable)callback;
		[Export ("offer:")]
		void Offer ([NullAllowed] PPRetailDeviceUpdateCompletedHandler callback);

		// -(void)offer:(NSString * _Nullable)tag callback:(PPRetailDeviceUpdateCompletedHandler _Nullable)callback;
		[Export ("offer:callback:")]
		void Offer ([NullAllowed] string tag, [NullAllowed] PPRetailDeviceUpdateCompletedHandler callback);

		// -(void)begin:(PPRetailDeviceUpdateCompletedHandler _Nullable)callback;
		[Export ("begin:")]
		void Begin ([NullAllowed] PPRetailDeviceUpdateCompletedHandler callback);

		// -(void)begin:(NSString * _Nullable)tag callback:(PPRetailDeviceUpdateCompletedHandler _Nullable)callback;
		[Export ("begin:callback:")]
		void Begin ([NullAllowed] string tag, [NullAllowed] PPRetailDeviceUpdateCompletedHandler callback);

		// -(void)validateUpdateEligibility;
		[Export ("validateUpdateEligibility")]
		void ValidateUpdateEligibility ();

		// -(PPRetailReconnectReaderSignal _Nullable)addReconnectReaderListener:(PPRetailReconnectReaderEvent _Nullable)listener;
		[Export ("addReconnectReaderListener:")]
		[return: NullAllowed]
		NSObject AddReconnectReaderListener ([NullAllowed] PPRetailReconnectReaderEvent listener);

		// -(void)removeReconnectReaderListener:(PPRetailReconnectReaderSignal _Nullable)listenerToken;
		[Export ("removeReconnectReaderListener:")]
		void RemoveReconnectReaderListener ([NullAllowed] NSObject listenerToken);
	}

	// @interface PPRetailDigitalCard : PPRetailCard
	[BaseType (typeof (PPRetailCard))]
	interface PPRetailDigitalCard {
		// @property (nonatomic, strong) NSString * _Nullable code;
		[NullAllowed, Export ("code", ArgumentSemantic.Strong)]
		string Code { get; set; }
	}

	// @interface PPRetailDigitalCardInfo : PPRetailObject
	[BaseType (typeof (PPRetailObject))]
	interface PPRetailDigitalCardInfo {
		// @property (readonly, nonatomic, strong) NSString * _Nullable code;
		[NullAllowed, Export ("code", ArgumentSemantic.Strong)]
		string Code { get; }

		// @property (readonly, nonatomic, strong) NSString * _Nullable currency;
		[NullAllowed, Export ("currency", ArgumentSemantic.Strong)]
		string Currency { get; }

		// @property (readonly, nonatomic, strong) NSDecimalNumber * _Nullable redeemedAmount;
		[NullAllowed, Export ("redeemedAmount", ArgumentSemantic.Strong)]
		NSDecimalNumber RedeemedAmount { get; }

		// @property (readonly, nonatomic, strong) NSDecimalNumber * _Nullable balanceAmount;
		[NullAllowed, Export ("balanceAmount", ArgumentSemantic.Strong)]
		NSDecimalNumber BalanceAmount { get; }
	}

	// @interface PPRetailDiscoveredCardReader : PPRetailObject
	[BaseType (typeof (PPRetailObject))]
	interface PPRetailDiscoveredCardReader {
		// @property (nonatomic, strong) NSString * _Nullable readerId;
		[NullAllowed, Export ("readerId", ArgumentSemantic.Strong)]
		string ReaderId { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable readerDescription;
		[NullAllowed, Export ("readerDescription", ArgumentSemantic.Strong)]
		string ReaderDescription { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable readerImgId;
		[NullAllowed, Export ("readerImgId", ArgumentSemantic.Strong)]
		string ReaderImgId { get; set; }

		// @property (assign, nonatomic) BOOL isConnected;
		[Export ("isConnected")]
		bool IsConnected { get; set; }
	}

	// @interface PPRetailError : PPRetailObject
	[BaseType (typeof (PPRetailObject))]
	interface PPRetailError {
		// @property (nonatomic, strong) NSString * _Nullable domain;
		[NullAllowed, Export ("domain", ArgumentSemantic.Strong)]
		string Domain { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable code;
		[NullAllowed, Export ("code", ArgumentSemantic.Strong)]
		string Code { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable message;
		[NullAllowed, Export ("message", ArgumentSemantic.Strong)]
		string Message { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable debugId;
		[NullAllowed, Export ("debugId", ArgumentSemantic.Strong)]
		string DebugId { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable developerMessage;
		[NullAllowed, Export ("developerMessage", ArgumentSemantic.Strong)]
		string DeveloperMessage { get; set; }

		// +(PPRetailError * _Nullable)makeError:(PPRetailError * _Nullable)error info:(PPRetailPayPalErrorInfo * _Nullable)info;
		[Static]
		[Export ("makeError:info:")]
		[return: NullAllowed]
		PPRetailError MakeError ([NullAllowed] PPRetailError error, [NullAllowed] PPRetailPayPalErrorInfo info);

		// -(void)equals:(PPRetailError * _Nullable)paypalError;
		[Export ("equals:")]
		void Equals ([NullAllowed] PPRetailError paypalError);
	}

	// @interface PPRetailInvoice : PPRetailObject
	[BaseType (typeof (PPRetailObject))]
	interface PPRetailInvoice {
		// @property (nonatomic, strong) NSString * _Nullable currency;
		[NullAllowed, Export ("currency", ArgumentSemantic.Strong)]
		string Currency { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable invoiceDate;
		[NullAllowed, Export ("invoiceDate", ArgumentSemantic.Strong)]
		string InvoiceDate { get; set; }

		// @property (readonly, nonatomic, strong) NSString * _Nullable payPalId;
		[NullAllowed, Export ("payPalId", ArgumentSemantic.Strong)]
		string PayPalId { get; }

		// @property (nonatomic, strong) NSString * _Nullable number;
		[NullAllowed, Export ("number", ArgumentSemantic.Strong)]
		string Number { get; set; }

		// @property (readonly, assign, nonatomic) PPRetailInvoiceStatus status;
		[Export ("status", ArgumentSemantic.Assign)]
		PPRetailInvoiceStatus Status { get; }

		// @property (nonatomic, strong) NSString * _Nullable reference;
		[NullAllowed, Export ("reference", ArgumentSemantic.Strong)]
		string Reference { get; set; }

		// @property (nonatomic, strong) PPRetailInvoiceMerchantInfo * _Nullable merchantInfo;
		[NullAllowed, Export ("merchantInfo", ArgumentSemantic.Strong)]
		PPRetailInvoiceMerchantInfo MerchantInfo { get; set; }

		// @property (nonatomic, strong) PPRetailInvoiceBillingInfo * _Nullable billingInfo;
		[NullAllowed, Export ("billingInfo", ArgumentSemantic.Strong)]
		PPRetailInvoiceBillingInfo BillingInfo { get; set; }

		// @property (nonatomic, strong) PPRetailInvoiceShippingInfo * _Nullable shippingInfo;
		[NullAllowed, Export ("shippingInfo", ArgumentSemantic.Strong)]
		PPRetailInvoiceShippingInfo ShippingInfo { get; set; }

		// @property (assign, nonatomic) BOOL taxInclusive;
		[Export ("taxInclusive")]
		bool TaxInclusive { get; set; }

		// @property (assign, nonatomic) BOOL taxCalculatedAfterDiscount;
		[Export ("taxCalculatedAfterDiscount")]
		bool TaxCalculatedAfterDiscount { get; set; }

		// @property (nonatomic, strong) NSArray * _Nullable items;
		[NullAllowed, Export ("items", ArgumentSemantic.Strong)]
		//[Verify (StronglyTypedNSArray)]
		NSObject [] Items { get; set; }

		// @property (readonly, assign, nonatomic) int itemCount;
		[Export ("itemCount")]
		int ItemCount { get; }

		// @property (nonatomic, strong) PPRetailInvoicePaymentTerm * _Nullable paymentTerms;
		[NullAllowed, Export ("paymentTerms", ArgumentSemantic.Strong)]
		PPRetailInvoicePaymentTerm PaymentTerms { get; set; }

		// @property (nonatomic, strong) NSDecimalNumber * _Nullable gratuityAmount;
		[NullAllowed, Export ("gratuityAmount", ArgumentSemantic.Strong)]
		NSDecimalNumber GratuityAmount { get; set; }

		// @property (nonatomic, strong) NSDecimalNumber * _Nullable discountAmount;
		[NullAllowed, Export ("discountAmount", ArgumentSemantic.Strong)]
		NSDecimalNumber DiscountAmount { get; set; }

		// @property (nonatomic, strong) NSDecimalNumber * _Nullable minimumAmountDue;
		[NullAllowed, Export ("minimumAmountDue", ArgumentSemantic.Strong)]
		NSDecimalNumber MinimumAmountDue { get; set; }

		// @property (nonatomic, strong) NSDecimalNumber * _Nullable discountPercentage;
		[NullAllowed, Export ("discountPercentage", ArgumentSemantic.Strong)]
		NSDecimalNumber DiscountPercentage { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable note;
		[NullAllowed, Export ("note", ArgumentSemantic.Strong)]
		string Note { get; set; }

		// @property (nonatomic, strong) NSDecimalNumber * _Nullable shippingAmount;
		[NullAllowed, Export ("shippingAmount", ArgumentSemantic.Strong)]
		NSDecimalNumber ShippingAmount { get; set; }

		// @property (nonatomic, strong) NSDecimalNumber * _Nullable shippingTaxRate;
		[NullAllowed, Export ("shippingTaxRate", ArgumentSemantic.Strong)]
		NSDecimalNumber ShippingTaxRate { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable shippingTaxName;
		[NullAllowed, Export ("shippingTaxName", ArgumentSemantic.Strong)]
		string ShippingTaxName { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable termsAndConditions;
		[NullAllowed, Export ("termsAndConditions", ArgumentSemantic.Strong)]
		string TermsAndConditions { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable merchantMemo;
		[NullAllowed, Export ("merchantMemo", ArgumentSemantic.Strong)]
		string MerchantMemo { get; set; }

		// @property (readonly, assign, nonatomic) BOOL isDirtyFromServer;
		[Export ("isDirtyFromServer")]
		bool IsDirtyFromServer { get; }

		// @property (readonly, assign, nonatomic) BOOL hasDetails;
		[Export ("hasDetails")]
		bool HasDetails { get; }

		// @property (readonly, nonatomic, strong) NSDecimalNumber * _Nullable total;
		[NullAllowed, Export ("total", ArgumentSemantic.Strong)]
		NSDecimalNumber Total { get; }

		// @property (readonly, nonatomic, strong) NSDecimalNumber * _Nullable subTotal;
		[NullAllowed, Export ("subTotal", ArgumentSemantic.Strong)]
		NSDecimalNumber SubTotal { get; }

		// @property (readonly, nonatomic, strong) NSDecimalNumber * _Nullable itemTax;
		[NullAllowed, Export ("itemTax", ArgumentSemantic.Strong)]
		NSDecimalNumber ItemTax { get; }

		// @property (readonly, nonatomic, strong) NSDecimalNumber * _Nullable itemDiscounts;
		[NullAllowed, Export ("itemDiscounts", ArgumentSemantic.Strong)]
		NSDecimalNumber ItemDiscounts { get; }

		// @property (readonly, nonatomic, strong) NSDecimalNumber * _Nullable discountPrice;
		[NullAllowed, Export ("discountPrice", ArgumentSemantic.Strong)]
		NSDecimalNumber DiscountPrice { get; }

		// @property (readonly, nonatomic, strong) NSDecimalNumber * _Nullable totalDiscount;
		[NullAllowed, Export ("totalDiscount", ArgumentSemantic.Strong)]
		NSDecimalNumber TotalDiscount { get; }

		// @property (readonly, nonatomic, strong) NSDictionary * _Nullable taxBreakdown;
		[NullAllowed, Export ("taxBreakdown", ArgumentSemantic.Strong)]
		NSDictionary TaxBreakdown { get; }

		// @property (assign, nonatomic) BOOL allowPartialPayment;
		[Export ("allowPartialPayment")]
		bool AllowPartialPayment { get; set; }

		// @property (nonatomic, strong) NSArray * _Nullable CCInfo;
		[NullAllowed, Export ("CCInfo", ArgumentSemantic.Strong)]
		//[Verify (StronglyTypedNSArray)]
		NSObject [] CCInfo { get; set; }

		// @property (readonly, nonatomic, strong) NSArray * _Nullable payments;
		[NullAllowed, Export ("payments", ArgumentSemantic.Strong)]
		//[Verify (StronglyTypedNSArray)]
		NSObject [] Payments { get; }

		// @property (readonly, nonatomic, strong) NSArray * _Nullable refunds;
		[NullAllowed, Export ("refunds", ArgumentSemantic.Strong)]
		//[Verify (StronglyTypedNSArray)]
		NSObject [] Refunds { get; }

		// @property (readonly, nonatomic, strong) NSDecimalNumber * _Nullable paidAmount;
		[NullAllowed, Export ("paidAmount", ArgumentSemantic.Strong)]
		NSDecimalNumber PaidAmount { get; }

		// @property (readonly, nonatomic, strong) NSDecimalNumber * _Nullable paidAmountPayPal;
		[NullAllowed, Export ("paidAmountPayPal", ArgumentSemantic.Strong)]
		NSDecimalNumber PaidAmountPayPal { get; }

		// @property (readonly, nonatomic, strong) NSDecimalNumber * _Nullable paidAmountOther;
		[NullAllowed, Export ("paidAmountOther", ArgumentSemantic.Strong)]
		NSDecimalNumber PaidAmountOther { get; }

		// @property (readonly, nonatomic, strong) NSDecimalNumber * _Nullable refundedAmount;
		[NullAllowed, Export ("refundedAmount", ArgumentSemantic.Strong)]
		NSDecimalNumber RefundedAmount { get; }

		// @property (readonly, nonatomic, strong) NSDecimalNumber * _Nullable refundedAmountPayPal;
		[NullAllowed, Export ("refundedAmountPayPal", ArgumentSemantic.Strong)]
		NSDecimalNumber RefundedAmountPayPal { get; }

		// @property (readonly, nonatomic, strong) NSDecimalNumber * _Nullable refundedAmountOther;
		[NullAllowed, Export ("refundedAmountOther", ArgumentSemantic.Strong)]
		NSDecimalNumber RefundedAmountOther { get; }

		// @property (readonly, nonatomic, strong) NSDecimalNumber * _Nullable remainingAmount;
		[NullAllowed, Export ("remainingAmount", ArgumentSemantic.Strong)]
		NSDecimalNumber RemainingAmount { get; }

		// @property (readonly, nonatomic, strong) NSDecimalNumber * _Nullable amountPaidNet;
		[NullAllowed, Export ("amountPaidNet", ArgumentSemantic.Strong)]
		NSDecimalNumber AmountPaidNet { get; }

		// @property (readonly, assign, nonatomic) BOOL hasBeenPaid;
		[Export ("hasBeenPaid")]
		bool HasBeenPaid { get; }

		// @property (nonatomic, strong) NSString * _Nullable uri;
		[NullAllowed, Export ("uri", ArgumentSemantic.Strong)]
		string Uri { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable logoURL;
		[NullAllowed, Export ("logoURL", ArgumentSemantic.Strong)]
		string LogoURL { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable additionalData;
		[NullAllowed, Export ("additionalData", ArgumentSemantic.Strong)]
		string AdditionalData { get; set; }

		// @property (nonatomic, strong) PPRetailInvoiceCustomAmount * _Nullable custom;
		[NullAllowed, Export ("custom", ArgumentSemantic.Strong)]
		PPRetailInvoiceCustomAmount Custom { get; set; }

		// @property (readonly, nonatomic, strong) PPRetailInvoiceMetaData * _Nullable metadata;
		[NullAllowed, Export ("metadata", ArgumentSemantic.Strong)]
		PPRetailInvoiceMetaData Metadata { get; }

		// @property (assign, nonatomic) BOOL wasDeleted;
		[Export ("wasDeleted")]
		bool WasDeleted { get; set; }

		// @property (nonatomic, strong) NSArray * _Nullable attachments;
		[NullAllowed, Export ("attachments", ArgumentSemantic.Strong)]
		//[Verify (StronglyTypedNSArray)]
		NSObject [] Attachments { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable templateID;
		[NullAllowed, Export ("templateID", ArgumentSemantic.Strong)]
		string TemplateID { get; set; }

		// @property (readonly, assign, nonatomic) BOOL isPastDue;
		[Export ("isPastDue")]
		bool IsPastDue { get; }

		// @property (readonly, nonatomic, strong) NSString * _Nullable payerViewUrl;
		[NullAllowed, Export ("payerViewUrl", ArgumentSemantic.Strong)]
		string PayerViewUrl { get; }

		// @property (assign, nonatomic) BOOL allowTip;
		[Export ("allowTip")]
		bool AllowTip { get; set; }

		// -(instancetype _Nullable)initWithCurrencyCode:(NSString * _Nullable)currencyCode;
		[Export ("initWithCurrencyCode:")]
		IntPtr Constructor ([NullAllowed] string currencyCode);

		// +(PPRetailInvoice * _Nullable)withInvoice:(PPRetailInvoice * _Nullable)invoice;
		[Static]
		[Export ("withInvoice:")]
		[return: NullAllowed]
		PPRetailInvoice WithInvoice ([NullAllowed] PPRetailInvoice invoice);

		// +(NSArray * _Nullable)supportedCurrencies;
		[Static]
		[NullAllowed, Export ("supportedCurrencies")]
		//[Verify (MethodToProperty), Verify (StronglyTypedNSArray)]
		NSObject [] SupportedCurrencies { get; }

		// -(PPRetailInvoice * _Nullable)duplicate;
		[NullAllowed, Export ("duplicate")]
		//[Verify (MethodToProperty)]
		PPRetailInvoice Duplicate { get; }

		// -(NSArray * _Nullable)addAttachment:(PPRetailInvoiceAttachment * _Nullable)attachment;
		[Export ("addAttachment:")]
		//[Verify (StronglyTypedNSArray)]
		[return: NullAllowed]
		NSObject [] AddAttachment ([NullAllowed] PPRetailInvoiceAttachment attachment);

		// -(BOOL)removeAttachment:(PPRetailInvoiceAttachment * _Nullable)attachment;
		[Export ("removeAttachment:")]
		bool RemoveAttachment ([NullAllowed] PPRetailInvoiceAttachment attachment);

		// -(PPRetailInvoiceItem * _Nullable)addItem:(NSString * _Nullable)name quantity:(NSDecimalNumber * _Nullable)quantity unitPrice:(NSDecimalNumber * _Nullable)unitPrice itemId:(int)itemId detailId:(NSString * _Nullable)detailId;
		[Export ("addItem:quantity:unitPrice:itemId:detailId:")]
		[return: NullAllowed]
		PPRetailInvoiceItem AddItem ([NullAllowed] string name, [NullAllowed] NSDecimalNumber quantity, [NullAllowed] NSDecimalNumber unitPrice, int itemId, [NullAllowed] string detailId);

		// -(PPRetailInvoiceItem * _Nullable)addInvoiceItem:(PPRetailInvoiceItem * _Nullable)item;
		[Export ("addInvoiceItem:")]
		[return: NullAllowed]
		PPRetailInvoiceItem AddInvoiceItem ([NullAllowed] PPRetailInvoiceItem item);

		// -(BOOL)deepEqual:(PPRetailInvoice * _Nullable)invoice;
		[Export ("deepEqual:")]
		bool DeepEqual ([NullAllowed] PPRetailInvoice invoice);

		// -(void)removeAllItems;
		[Export ("removeAllItems")]
		void RemoveAllItems ();

		// -(BOOL)removeItem:(PPRetailInvoiceItem * _Nullable)item;
		[Export ("removeItem:")]
		bool RemoveItem ([NullAllowed] PPRetailInvoiceItem item);

		// -(PPRetailInvoiceItem * _Nullable)findItem:(int)itemId detailId:(NSString * _Nullable)detailId;
		[Export ("findItem:detailId:")]
		[return: NullAllowed]
		PPRetailInvoiceItem FindItem (int itemId, [NullAllowed] string detailId);

		// -(PPRetailInvoiceItem * _Nullable)getItem:(int)itemIndex;
		[Export ("getItem:")]
		[return: NullAllowed]
		PPRetailInvoiceItem GetItem (int itemIndex);

		// -(void)getDetails:(PPRetailInvoiceGotDetailsHandler _Nullable)callback;
		[Export ("getDetails:")]
		void GetDetails ([NullAllowed] PPRetailInvoiceGotDetailsHandler callback);

		// -(void)save:(PPRetailInvoiceSavedHandler _Nullable)callback;
		[Export ("save:")]
		void Save ([NullAllowed] PPRetailInvoiceSavedHandler callback);

		// -(void)update:(BOOL)shouldNotifyMerchant shouldNotifyCustomer:(BOOL)shouldNotifyCustomer callback:(PPRetailInvoiceSavedHandler _Nullable)callback;
		[Export ("update:shouldNotifyCustomer:callback:")]
		void Update (bool shouldNotifyMerchant, bool shouldNotifyCustomer, [NullAllowed] PPRetailInvoiceSavedHandler callback);

		// -(void)send:(BOOL)shouldNotifyMerchant callback:(PPRetailInvoiceSentHandler _Nullable)callback;
		[Export ("send:callback:")]
		void Send (bool shouldNotifyMerchant, [NullAllowed] PPRetailInvoiceSentHandler callback);

		// -(void)deleteFromServer:(PPRetailInvoiceDeletedHandler _Nullable)callback;
		[Export ("deleteFromServer:")]
		void DeleteFromServer ([NullAllowed] PPRetailInvoiceDeletedHandler callback);

		// -(void)remind:(PPRetailInvoiceNotification * _Nullable)notification callback:(PPRetailInvoiceRemindedHandler _Nullable)callback;
		[Export ("remind:callback:")]
		void Remind ([NullAllowed] PPRetailInvoiceNotification notification, [NullAllowed] PPRetailInvoiceRemindedHandler callback);

		// -(void)cancel:(PPRetailInvoiceNotification * _Nullable)notification callback:(PPRetailInvoiceCancelledHandler _Nullable)callback;
		[Export ("cancel:callback:")]
		void Cancel ([NullAllowed] PPRetailInvoiceNotification notification, [NullAllowed] PPRetailInvoiceCancelledHandler callback);

		// -(void)recordPayment:(PPRetailInvoicePayment * _Nullable)paymentInfo callback:(PPRetailInvoicePaidHandler _Nullable)callback;
		[Export ("recordPayment:callback:")]
		void RecordPayment ([NullAllowed] PPRetailInvoicePayment paymentInfo, [NullAllowed] PPRetailInvoicePaidHandler callback);

		// -(void)recordRefund:(PPRetailInvoiceRefund * _Nullable)refundInfo callback:(PPRetailInvoicePaidHandler _Nullable)callback;
		[Export ("recordRefund:callback:")]
		void RecordRefund ([NullAllowed] PPRetailInvoiceRefund refundInfo, [NullAllowed] PPRetailInvoicePaidHandler callback);
	}

	// @interface PPRetailInvoiceActions : PPRetailObject
	[BaseType (typeof (PPRetailObject))]
	interface PPRetailInvoiceActions {
		// +(NSArray * _Nullable)availableActions:(PPRetailInvoice * _Nullable)invoice;
		[Static]
		[Export ("availableActions:")]
		//[Verify (StronglyTypedNSArray)]
		[return: NullAllowed]
		NSObject [] AvailableActions ([NullAllowed] PPRetailInvoice invoice);
	}

	// @interface PPRetailInvoiceAttachment : PPRetailObject
	[BaseType (typeof (PPRetailObject))]
	interface PPRetailInvoiceAttachment {
		// @property (nonatomic, strong) NSString * _Nullable name;
		[NullAllowed, Export ("name", ArgumentSemantic.Strong)]
		string Name { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable url;
		[NullAllowed, Export ("url", ArgumentSemantic.Strong)]
		string Url { get; set; }

		// -(NSString * _Nullable)usableURL;
		[NullAllowed, Export ("usableURL")]
		//[Verify (MethodToProperty)]
		string UsableURL { get; }
	}

	// @interface PPRetailInvoiceBillingInfo : PPRetailObject
	[BaseType (typeof (PPRetailObject))]
	interface PPRetailInvoiceBillingInfo {
		// @property (nonatomic, strong) NSString * _Nullable email;
		[NullAllowed, Export ("email", ArgumentSemantic.Strong)]
		string Email { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable firstName;
		[NullAllowed, Export ("firstName", ArgumentSemantic.Strong)]
		string FirstName { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable lastName;
		[NullAllowed, Export ("lastName", ArgumentSemantic.Strong)]
		string LastName { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable businessName;
		[NullAllowed, Export ("businessName", ArgumentSemantic.Strong)]
		string BusinessName { get; set; }

		// @property (nonatomic, strong) PPRetailInvoiceAddress * _Nullable address;
		[NullAllowed, Export ("address", ArgumentSemantic.Strong)]
		PPRetailInvoiceAddress Address { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable language;
		[NullAllowed, Export ("language", ArgumentSemantic.Strong)]
		string Language { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable additionalInfo;
		[NullAllowed, Export ("additionalInfo", ArgumentSemantic.Strong)]
		string AdditionalInfo { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable notificationChannel;
		[NullAllowed, Export ("notificationChannel", ArgumentSemantic.Strong)]
		string NotificationChannel { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable countryCode;
		[NullAllowed, Export ("countryCode", ArgumentSemantic.Strong)]
		string CountryCode { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable nationalNumber;
		[NullAllowed, Export ("nationalNumber", ArgumentSemantic.Strong)]
		string NationalNumber { get; set; }

		// -(BOOL)hasAnyValue;
		[Export ("hasAnyValue")]
		//[Verify (MethodToProperty)]
		bool HasAnyValue { get; }
	}

	// @interface PPRetailInvoiceCCInfo : PPRetailObject
	[BaseType (typeof (PPRetailObject))]
	interface PPRetailInvoiceCCInfo {
		// @property (nonatomic, strong) NSString * _Nullable email;
		[NullAllowed, Export ("email", ArgumentSemantic.Strong)]
		string Email { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable firstName;
		[NullAllowed, Export ("firstName", ArgumentSemantic.Strong)]
		string FirstName { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable lastName;
		[NullAllowed, Export ("lastName", ArgumentSemantic.Strong)]
		string LastName { get; set; }

		// @property (nonatomic, strong) PPRetailInvoiceAddress * _Nullable address;
		[NullAllowed, Export ("address", ArgumentSemantic.Strong)]
		PPRetailInvoiceAddress Address { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable businessName;
		[NullAllowed, Export ("businessName", ArgumentSemantic.Strong)]
		string BusinessName { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable phone;
		[NullAllowed, Export ("phone", ArgumentSemantic.Strong)]
		string Phone { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable fax;
		[NullAllowed, Export ("fax", ArgumentSemantic.Strong)]
		string Fax { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable website;
		[NullAllowed, Export ("website", ArgumentSemantic.Strong)]
		string Website { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable additionalInfo;
		[NullAllowed, Export ("additionalInfo", ArgumentSemantic.Strong)]
		string AdditionalInfo { get; set; }
	}

	// @interface PPRetailInvoiceConstants : PPRetailObject
	[BaseType (typeof (PPRetailObject))]
	interface PPRetailInvoiceConstants {
		// +(NSDecimalNumber * _Nullable)taxRateDecimalPrecision;
		[Static]
		[NullAllowed, Export ("taxRateDecimalPrecision")]
		//[Verify (MethodToProperty)]
		NSDecimalNumber TaxRateDecimalPrecision { get; }

		// +(NSDecimalNumber * _Nullable)discountPercentageDecimalPrecision;
		[Static]
		[NullAllowed, Export ("discountPercentageDecimalPrecision")]
		//[Verify (MethodToProperty)]
		NSDecimalNumber DiscountPercentageDecimalPrecision { get; }

		// +(NSDecimalNumber * _Nullable)invoiceNumberMaxLength;
		[Static]
		[NullAllowed, Export ("invoiceNumberMaxLength")]
		//[Verify (MethodToProperty)]
		NSDecimalNumber InvoiceNumberMaxLength { get; }

		// +(NSDecimalNumber * _Nullable)invoiceTermsMaxLength;
		[Static]
		[NullAllowed, Export ("invoiceTermsMaxLength")]
		//[Verify (MethodToProperty)]
		NSDecimalNumber InvoiceTermsMaxLength { get; }

		// +(NSDecimalNumber * _Nullable)invoiceNoteMaxLength;
		[Static]
		[NullAllowed, Export ("invoiceNoteMaxLength")]
		//[Verify (MethodToProperty)]
		NSDecimalNumber InvoiceNoteMaxLength { get; }

		// +(NSDecimalNumber * _Nullable)invoiceMerchantMemoMaxLength;
		[Static]
		[NullAllowed, Export ("invoiceMerchantMemoMaxLength")]
		//[Verify (MethodToProperty)]
		NSDecimalNumber InvoiceMerchantMemoMaxLength { get; }

		// +(NSDecimalNumber * _Nullable)invoiceReferenceMaxLength;
		[Static]
		[NullAllowed, Export ("invoiceReferenceMaxLength")]
		//[Verify (MethodToProperty)]
		NSDecimalNumber InvoiceReferenceMaxLength { get; }

		// +(NSDecimalNumber * _Nullable)itemQuantityDecimalPrecision;
		[Static]
		[NullAllowed, Export ("itemQuantityDecimalPrecision")]
		//[Verify (MethodToProperty)]
		NSDecimalNumber ItemQuantityDecimalPrecision { get; }

		// +(NSDecimalNumber * _Nullable)itemQuantityMax;
		[Static]
		[NullAllowed, Export ("itemQuantityMax")]
		//[Verify (MethodToProperty)]
		NSDecimalNumber ItemQuantityMax { get; }

		// +(NSDecimalNumber * _Nullable)itemQuantityMin;
		[Static]
		[NullAllowed, Export ("itemQuantityMin")]
		//[Verify (MethodToProperty)]
		NSDecimalNumber ItemQuantityMin { get; }

		// +(NSDecimalNumber * _Nullable)itemNameMaxLength;
		[Static]
		[NullAllowed, Export ("itemNameMaxLength")]
		//[Verify (MethodToProperty)]
		NSDecimalNumber ItemNameMaxLength { get; }

		// +(NSDecimalNumber * _Nullable)itemDescriptionMaxLength;
		[Static]
		[NullAllowed, Export ("itemDescriptionMaxLength")]
		//[Verify (MethodToProperty)]
		NSDecimalNumber ItemDescriptionMaxLength { get; }

		// +(NSDecimalNumber * _Nullable)itemPriceMax;
		[Static]
		[NullAllowed, Export ("itemPriceMax")]
		//[Verify (MethodToProperty)]
		NSDecimalNumber ItemPriceMax { get; }

		// +(NSDecimalNumber * _Nullable)taxRateMaxValue;
		[Static]
		[NullAllowed, Export ("taxRateMaxValue")]
		//[Verify (MethodToProperty)]
		NSDecimalNumber TaxRateMaxValue { get; }
	}

	// @interface PPRetailInvoiceCustomAmount : PPRetailObject
	[BaseType (typeof (PPRetailObject))]
	interface PPRetailInvoiceCustomAmount {
		// @property (nonatomic, strong) NSString * _Nullable label;
		[NullAllowed, Export ("label", ArgumentSemantic.Strong)]
		string Label { get; set; }

		// @property (nonatomic, strong) NSDecimalNumber * _Nullable amount;
		[NullAllowed, Export ("amount", ArgumentSemantic.Strong)]
		NSDecimalNumber Amount { get; set; }
	}

	// @interface PPRetailInvoiceItem : PPRetailObject
	[BaseType (typeof (PPRetailObject))]
	[DisableDefaultCtor]
	interface PPRetailInvoiceItem {
		// @property (nonatomic, strong) NSString * _Nullable name;
		[NullAllowed, Export ("name", ArgumentSemantic.Strong)]
		string Name { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable itemDescription;
		[NullAllowed, Export ("itemDescription", ArgumentSemantic.Strong)]
		string ItemDescription { get; set; }

		// @property (nonatomic, strong) NSDecimalNumber * _Nullable quantity;
		[NullAllowed, Export ("quantity", ArgumentSemantic.Strong)]
		NSDecimalNumber Quantity { get; set; }

		// @property (nonatomic, strong) NSDecimalNumber * _Nullable unitPrice;
		[NullAllowed, Export ("unitPrice", ArgumentSemantic.Strong)]
		NSDecimalNumber UnitPrice { get; set; }

		// @property (readonly, assign, nonatomic) int itemId;
		[Export ("itemId")]
		int ItemId { get; }

		// @property (readonly, nonatomic, strong) NSString * _Nullable detailId;
		[NullAllowed, Export ("detailId", ArgumentSemantic.Strong)]
		string DetailId { get; }

		// @property (nonatomic, strong) NSString * _Nullable taxName;
		[NullAllowed, Export ("taxName", ArgumentSemantic.Strong)]
		string TaxName { get; set; }

		// @property (nonatomic, strong) NSDecimalNumber * _Nullable taxRate;
		[NullAllowed, Export ("taxRate", ArgumentSemantic.Strong)]
		NSDecimalNumber TaxRate { get; set; }

		// @property (nonatomic, strong) NSDecimalNumber * _Nullable discountPercentage;
		[NullAllowed, Export ("discountPercentage", ArgumentSemantic.Strong)]
		NSDecimalNumber DiscountPercentage { get; set; }

		// @property (nonatomic, strong) NSDecimalNumber * _Nullable discountAmount;
		[NullAllowed, Export ("discountAmount", ArgumentSemantic.Strong)]
		NSDecimalNumber DiscountAmount { get; set; }

		// @property (nonatomic, strong) NSDate * _Nullable date;
		[NullAllowed, Export ("date", ArgumentSemantic.Strong)]
		NSDate Date { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable imageURL;
		[NullAllowed, Export ("imageURL", ArgumentSemantic.Strong)]
		string ImageURL { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable unitOfMeasure;
		[NullAllowed, Export ("unitOfMeasure", ArgumentSemantic.Strong)]
		string UnitOfMeasure { get; set; }

		// -(instancetype _Nullable)initWithName:(NSString * _Nullable)name quantity:(NSDecimalNumber * _Nullable)quantity unitPrice:(NSDecimalNumber * _Nullable)unitPrice itemId:(int)itemId detailId:(NSString * _Nullable)detailId;
		[Export ("initWithName:quantity:unitPrice:itemId:detailId:")]
		IntPtr Constructor ([NullAllowed] string name, [NullAllowed] NSDecimalNumber quantity, [NullAllowed] NSDecimalNumber unitPrice, int itemId, [NullAllowed] string detailId);

		// -(PPRetailInvoiceItem * _Nullable)duplicate;
		[NullAllowed, Export ("duplicate")]
		//[Verify (MethodToProperty)]
		PPRetailInvoiceItem Duplicate { get; }

		// -(NSDecimalNumber * _Nullable)discountAmountForDisplay;
		[NullAllowed, Export ("discountAmountForDisplay")]
		//[Verify (MethodToProperty)]
		NSDecimalNumber DiscountAmountForDisplay { get; }

		// -(BOOL)isEqualToItem:(PPRetailInvoiceItem * _Nullable)item;
		[Export ("isEqualToItem:")]
		bool IsEqualToItem ([NullAllowed] PPRetailInvoiceItem item);
	}

	// @interface PPRetailInvoiceListRequest : PPRetailObject
	[BaseType (typeof (PPRetailObject))]
	interface PPRetailInvoiceListRequest {
		// @property (assign, nonatomic) int startIndex;
		[Export ("startIndex")]
		int StartIndex { get; set; }

		// @property (assign, nonatomic) int pageSize;
		[Export ("pageSize")]
		int PageSize { get; set; }

		// @property (assign, nonatomic) BOOL totalCountRequired;
		[Export ("totalCountRequired")]
		bool TotalCountRequired { get; set; }
	}

	// @interface PPRetailInvoiceListResponse : PPRetailObject
	[BaseType (typeof (PPRetailObject))]
	interface PPRetailInvoiceListResponse {
		// @property (nonatomic, strong) NSArray * _Nullable invoices;
		[NullAllowed, Export ("invoices", ArgumentSemantic.Strong)]
		//[Verify (StronglyTypedNSArray)]
		NSObject [] Invoices { get; set; }

		// @property (assign, nonatomic) int totalCount;
		[Export ("totalCount")]
		int TotalCount { get; set; }

		// @property (assign, nonatomic) BOOL hasMore;
		[Export ("hasMore")]
		bool HasMore { get; set; }
	}

	// @interface PPRetailInvoiceMerchantInfo : PPRetailObject
	[BaseType (typeof (PPRetailObject))]
	interface PPRetailInvoiceMerchantInfo {
		// @property (nonatomic, strong) NSString * _Nullable email;
		[NullAllowed, Export ("email", ArgumentSemantic.Strong)]
		string Email { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable firstName;
		[NullAllowed, Export ("firstName", ArgumentSemantic.Strong)]
		string FirstName { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable lastName;
		[NullAllowed, Export ("lastName", ArgumentSemantic.Strong)]
		string LastName { get; set; }

		// @property (nonatomic, strong) PPRetailInvoiceAddress * _Nullable address;
		[NullAllowed, Export ("address", ArgumentSemantic.Strong)]
		PPRetailInvoiceAddress Address { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable businessName;
		[NullAllowed, Export ("businessName", ArgumentSemantic.Strong)]
		string BusinessName { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable phone;
		[NullAllowed, Export ("phone", ArgumentSemantic.Strong)]
		string Phone { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable fax;
		[NullAllowed, Export ("fax", ArgumentSemantic.Strong)]
		string Fax { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable website;
		[NullAllowed, Export ("website", ArgumentSemantic.Strong)]
		string Website { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable taxId;
		[NullAllowed, Export ("taxId", ArgumentSemantic.Strong)]
		string TaxId { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable additionalInfoLabel;
		[NullAllowed, Export ("additionalInfoLabel", ArgumentSemantic.Strong)]
		string AdditionalInfoLabel { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable additionalInfo;
		[NullAllowed, Export ("additionalInfo", ArgumentSemantic.Strong)]
		string AdditionalInfo { get; set; }
	}

	// @interface PPRetailInvoiceMetaData : PPRetailObject
	[BaseType (typeof (PPRetailObject))]
	interface PPRetailInvoiceMetaData {
		// @property (readonly, nonatomic, strong) NSDate * _Nullable createdDate;
		[NullAllowed, Export ("createdDate", ArgumentSemantic.Strong)]
		NSDate CreatedDate { get; }

		// @property (readonly, nonatomic, strong) NSString * _Nullable createdBy;
		[NullAllowed, Export ("createdBy", ArgumentSemantic.Strong)]
		string CreatedBy { get; }

		// @property (readonly, nonatomic, strong) NSDate * _Nullable cancelledDate;
		[NullAllowed, Export ("cancelledDate", ArgumentSemantic.Strong)]
		NSDate CancelledDate { get; }

		// @property (readonly, nonatomic, strong) NSString * _Nullable cancelledBy;
		[NullAllowed, Export ("cancelledBy", ArgumentSemantic.Strong)]
		string CancelledBy { get; }

		// @property (readonly, nonatomic, strong) NSDate * _Nullable lastUpdatedDate;
		[NullAllowed, Export ("lastUpdatedDate", ArgumentSemantic.Strong)]
		NSDate LastUpdatedDate { get; }

		// @property (readonly, nonatomic, strong) NSString * _Nullable lastUpdatedBy;
		[NullAllowed, Export ("lastUpdatedBy", ArgumentSemantic.Strong)]
		string LastUpdatedBy { get; }

		// @property (readonly, nonatomic, strong) NSDate * _Nullable firstSentDate;
		[NullAllowed, Export ("firstSentDate", ArgumentSemantic.Strong)]
		NSDate FirstSentDate { get; }

		// @property (readonly, nonatomic, strong) NSDate * _Nullable lastSentDate;
		[NullAllowed, Export ("lastSentDate", ArgumentSemantic.Strong)]
		NSDate LastSentDate { get; }

		// @property (readonly, nonatomic, strong) NSString * _Nullable lastSentBy;
		[NullAllowed, Export ("lastSentBy", ArgumentSemantic.Strong)]
		string LastSentBy { get; }

		// @property (readonly, nonatomic, strong) NSString * _Nullable payerViewURL;
		[NullAllowed, Export ("payerViewURL", ArgumentSemantic.Strong)]
		string PayerViewURL { get; }
	}

	// @interface PPRetailInvoiceNotification : PPRetailObject
	[BaseType (typeof (PPRetailObject))]
	interface PPRetailInvoiceNotification {
		// @property (nonatomic, strong) NSString * _Nullable subject;
		[NullAllowed, Export ("subject", ArgumentSemantic.Strong)]
		string Subject { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable note;
		[NullAllowed, Export ("note", ArgumentSemantic.Strong)]
		string Note { get; set; }

		// @property (assign, nonatomic) BOOL shouldSendToMerchant;
		[Export ("shouldSendToMerchant")]
		bool ShouldSendToMerchant { get; set; }

		// @property (assign, nonatomic) BOOL shouldSendToPayer;
		[Export ("shouldSendToPayer")]
		bool ShouldSendToPayer { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable ccEmails;
		[NullAllowed, Export ("ccEmails", ArgumentSemantic.Strong)]
		string CcEmails { get; set; }
	}

	// @interface PPRetailInvoicePayment : PPRetailObject
	[BaseType (typeof (PPRetailObject))]
	interface PPRetailInvoicePayment {
		// @property (readonly, assign, nonatomic) PPRetailInvoicePaymentType type;
		[Export ("type", ArgumentSemantic.Assign)]
		PPRetailInvoicePaymentType Type { get; }

		// @property (readonly, nonatomic, strong) NSString * _Nullable transactionID;
		[NullAllowed, Export ("transactionID", ArgumentSemantic.Strong)]
		string TransactionID { get; }

		// @property (readonly, nonatomic, strong) NSString * _Nullable transactionType;
		[NullAllowed, Export ("transactionType", ArgumentSemantic.Strong)]
		string TransactionType { get; }

		// @property (nonatomic, strong) NSDate * _Nullable date;
		[NullAllowed, Export ("date", ArgumentSemantic.Strong)]
		NSDate Date { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable formattedDate;
		[NullAllowed, Export ("formattedDate", ArgumentSemantic.Strong)]
		string FormattedDate { get; set; }

		// @property (assign, nonatomic) PPRetailInvoicePaymentMethod method;
		[Export ("method", ArgumentSemantic.Assign)]
		PPRetailInvoicePaymentMethod Method { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable note;
		[NullAllowed, Export ("note", ArgumentSemantic.Strong)]
		string Note { get; set; }

		// @property (nonatomic, strong) NSDecimalNumber * _Nullable amount;
		[NullAllowed, Export ("amount", ArgumentSemantic.Strong)]
		NSDecimalNumber Amount { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable currency;
		[NullAllowed, Export ("currency", ArgumentSemantic.Strong)]
		string Currency { get; set; }
	}

	// @interface PPRetailInvoicePaymentTerm : PPRetailObject
	[BaseType (typeof (PPRetailObject))]
	interface PPRetailInvoicePaymentTerm {
		// @property (assign, nonatomic) PPRetailInvoicePaymentTermPaymentTerms paymentTerms;
		[Export ("paymentTerms", ArgumentSemantic.Assign)]
		PPRetailInvoicePaymentTermPaymentTerms PaymentTerms { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable dueDate;
		[NullAllowed, Export ("dueDate", ArgumentSemantic.Strong)]
		string DueDate { get; set; }

		// @property (assign, nonatomic) int daysForTerm;
		[Export ("daysForTerm")]
		int DaysForTerm { get; set; }
	}

	// @interface PPRetailInvoiceRefund : PPRetailObject
	[BaseType (typeof (PPRetailObject))]
	interface PPRetailInvoiceRefund {
		// @property (readonly, nonatomic, strong) NSString * _Nullable type;
		[NullAllowed, Export ("type", ArgumentSemantic.Strong)]
		string Type { get; }

		// @property (nonatomic, strong) NSDate * _Nullable date;
		[NullAllowed, Export ("date", ArgumentSemantic.Strong)]
		NSDate Date { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable note;
		[NullAllowed, Export ("note", ArgumentSemantic.Strong)]
		string Note { get; set; }

		// @property (nonatomic, strong) NSDecimalNumber * _Nullable amount;
		[NullAllowed, Export ("amount", ArgumentSemantic.Strong)]
		NSDecimalNumber Amount { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable currency;
		[NullAllowed, Export ("currency", ArgumentSemantic.Strong)]
		string Currency { get; set; }

		// @property (readonly, nonatomic, strong) NSString * _Nullable transactionID;
		[NullAllowed, Export ("transactionID", ArgumentSemantic.Strong)]
		string TransactionID { get; }
	}

	// @interface PPRetailInvoiceSearchRequest : PPRetailObject
	[BaseType (typeof (PPRetailObject))]
	interface PPRetailInvoiceSearchRequest {
		// @property (nonatomic, strong) NSString * _Nullable email;
		[NullAllowed, Export ("email", ArgumentSemantic.Strong)]
		string Email { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable recipientFirstName;
		[NullAllowed, Export ("recipientFirstName", ArgumentSemantic.Strong)]
		string RecipientFirstName { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable recipientLastName;
		[NullAllowed, Export ("recipientLastName", ArgumentSemantic.Strong)]
		string RecipientLastName { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable recipientBusinessName;
		[NullAllowed, Export ("recipientBusinessName", ArgumentSemantic.Strong)]
		string RecipientBusinessName { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable number;
		[NullAllowed, Export ("number", ArgumentSemantic.Strong)]
		string Number { get; set; }

		// @property (nonatomic, strong) NSDecimalNumber * _Nullable lowerTotalAmount;
		[NullAllowed, Export ("lowerTotalAmount", ArgumentSemantic.Strong)]
		NSDecimalNumber LowerTotalAmount { get; set; }

		// @property (nonatomic, strong) NSDecimalNumber * _Nullable upperTotalAmount;
		[NullAllowed, Export ("upperTotalAmount", ArgumentSemantic.Strong)]
		NSDecimalNumber UpperTotalAmount { get; set; }

		// @property (nonatomic, strong) NSDate * _Nullable startInvoiceDate;
		[NullAllowed, Export ("startInvoiceDate", ArgumentSemantic.Strong)]
		NSDate StartInvoiceDate { get; set; }

		// @property (nonatomic, strong) NSDate * _Nullable endInvoiceDate;
		[NullAllowed, Export ("endInvoiceDate", ArgumentSemantic.Strong)]
		NSDate EndInvoiceDate { get; set; }

		// @property (nonatomic, strong) NSDate * _Nullable startDueDate;
		[NullAllowed, Export ("startDueDate", ArgumentSemantic.Strong)]
		NSDate StartDueDate { get; set; }

		// @property (nonatomic, strong) NSDate * _Nullable endDueDate;
		[NullAllowed, Export ("endDueDate", ArgumentSemantic.Strong)]
		NSDate EndDueDate { get; set; }

		// @property (nonatomic, strong) NSDate * _Nullable startPaymentDate;
		[NullAllowed, Export ("startPaymentDate", ArgumentSemantic.Strong)]
		NSDate StartPaymentDate { get; set; }

		// @property (nonatomic, strong) NSDate * _Nullable endPaymentDate;
		[NullAllowed, Export ("endPaymentDate", ArgumentSemantic.Strong)]
		NSDate EndPaymentDate { get; set; }

		// @property (nonatomic, strong) NSDate * _Nullable startCreationDate;
		[NullAllowed, Export ("startCreationDate", ArgumentSemantic.Strong)]
		NSDate StartCreationDate { get; set; }

		// @property (nonatomic, strong) NSDate * _Nullable endCreationDate;
		[NullAllowed, Export ("endCreationDate", ArgumentSemantic.Strong)]
		NSDate EndCreationDate { get; set; }

		// @property (assign, nonatomic) int startIndex;
		[Export ("startIndex")]
		int StartIndex { get; set; }

		// @property (assign, nonatomic) int pageSize;
		[Export ("pageSize")]
		int PageSize { get; set; }

		// @property (assign, nonatomic) BOOL totalCountRequired;
		[Export ("totalCountRequired")]
		bool TotalCountRequired { get; set; }

		// @property (assign, nonatomic) BOOL archived;
		[Export ("archived")]
		bool Archived { get; set; }

		// -(void)addStatus:(PPRetailInvoiceStatus)status;
		[Export ("addStatus:")]
		void AddStatus (PPRetailInvoiceStatus status);
	}

	// @interface PPRetailInvoiceShippingInfo : PPRetailObject
	[BaseType (typeof (PPRetailObject))]
	interface PPRetailInvoiceShippingInfo {
		// @property (nonatomic, strong) NSString * _Nullable email;
		[NullAllowed, Export ("email", ArgumentSemantic.Strong)]
		string Email { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable firstName;
		[NullAllowed, Export ("firstName", ArgumentSemantic.Strong)]
		string FirstName { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable lastName;
		[NullAllowed, Export ("lastName", ArgumentSemantic.Strong)]
		string LastName { get; set; }

		// @property (nonatomic, strong) PPRetailInvoiceAddress * _Nullable address;
		[NullAllowed, Export ("address", ArgumentSemantic.Strong)]
		PPRetailInvoiceAddress Address { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable businessName;
		[NullAllowed, Export ("businessName", ArgumentSemantic.Strong)]
		string BusinessName { get; set; }

		// -(BOOL)hasAnyValue;
		[Export ("hasAnyValue")]
		//[Verify (MethodToProperty)]
		bool HasAnyValue { get; }
	}

	// @interface PPRetailInvoiceTemplate : PPRetailInvoice
	[BaseType (typeof (PPRetailInvoice))]
	[DisableDefaultCtor]
	interface PPRetailInvoiceTemplate {
		// @property (assign, nonatomic) BOOL isDefault;
		[Export ("isDefault")]
		bool IsDefault { get; set; }

		// @property (assign, nonatomic) BOOL isCustom;
		[Export ("isCustom")]
		bool IsCustom { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable name;
		[NullAllowed, Export ("name", ArgumentSemantic.Strong)]
		string Name { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable unitOfMeasure;
		[NullAllowed, Export ("unitOfMeasure", ArgumentSemantic.Strong)]
		string UnitOfMeasure { get; set; }

		// @property (nonatomic, strong) PPRetailInvoiceTemplateSettings * _Nullable settings;
		[NullAllowed, Export ("settings", ArgumentSemantic.Strong)]
		PPRetailInvoiceTemplateSettings Settings { get; set; }

		// -(instancetype _Nullable)initWithCurrencyCode:(NSString * _Nullable)currencyCode;
		[Export ("initWithCurrencyCode:")]
		IntPtr Constructor ([NullAllowed] string currencyCode);

		// -(PPRetailInvoice * _Nullable)invoiceFromInvoice:(PPRetailInvoice * _Nullable)invoice;
		[Export ("invoiceFromInvoice:")]
		[return: NullAllowed]
		PPRetailInvoice InvoiceFromInvoice ([NullAllowed] PPRetailInvoice invoice);
	}

	// @interface PPRetailInvoiceTemplateSettings : PPRetailObject
	[BaseType (typeof (PPRetailObject))]
	interface PPRetailInvoiceTemplateSettings {
		// @property (assign, nonatomic) BOOL shipping;
		[Export ("shipping")]
		bool Shipping { get; set; }

		// @property (assign, nonatomic) BOOL discount;
		[Export ("discount")]
		bool Discount { get; set; }

		// @property (assign, nonatomic) BOOL custom;
		[Export ("custom")]
		bool Custom { get; set; }

		// @property (assign, nonatomic) BOOL itemsDiscount;
		[Export ("itemsDiscount")]
		bool ItemsDiscount { get; set; }

		// @property (assign, nonatomic) BOOL itemsTax;
		[Export ("itemsTax")]
		bool ItemsTax { get; set; }

		// @property (assign, nonatomic) BOOL itemsQuantity;
		[Export ("itemsQuantity")]
		bool ItemsQuantity { get; set; }

		// @property (assign, nonatomic) BOOL itemsDescription;
		[Export ("itemsDescription")]
		bool ItemsDescription { get; set; }

		// @property (assign, nonatomic) BOOL itemsDate;
		[Export ("itemsDate")]
		bool ItemsDate { get; set; }
	}

	// @interface PPRetailInvoiceTemplatesResponse : PPRetailObject
	[BaseType (typeof (PPRetailObject))]
	interface PPRetailInvoiceTemplatesResponse {
		// @property (nonatomic, strong) PPRetailInvoiceTemplate * _Nullable defaultTemplate;
		[NullAllowed, Export ("defaultTemplate", ArgumentSemantic.Strong)]
		PPRetailInvoiceTemplate DefaultTemplate { get; set; }

		// @property (nonatomic, strong) NSArray * _Nullable templates;
		[NullAllowed, Export ("templates", ArgumentSemantic.Strong)]
		//[Verify (StronglyTypedNSArray)]
		NSObject [] Templates { get; set; }
	}

	// @interface PPRetailInvoicingService : PPRetailObject
	[BaseType (typeof (PPRetailObject))]
	interface PPRetailInvoicingService {
		// +(void)getInvoices:(PPRetailInvoiceListRequest * _Nullable)params completionHandler:(PPRetailInvoicingServiceGetInvoicesHandler _Nullable)completionHandler;
		[Static]
		[Export ("getInvoices:completionHandler:")]
		void GetInvoices ([NullAllowed] PPRetailInvoiceListRequest @params, [NullAllowed] PPRetailInvoicingServiceGetInvoicesHandler completionHandler);

		// +(void)searchInvoices:(PPRetailInvoiceSearchRequest * _Nullable)params completionHandler:(PPRetailInvoicingServiceSearchInvoicesHandler _Nullable)completionHandler;
		[Static]
		[Export ("searchInvoices:completionHandler:")]
		void SearchInvoices ([NullAllowed] PPRetailInvoiceSearchRequest @params, [NullAllowed] PPRetailInvoicingServiceSearchInvoicesHandler completionHandler);

		// +(void)getInvoice:(NSString * _Nullable)invoiceID completionHandler:(PPRetailInvoicingServiceGetInvoiceHandler _Nullable)completionHandler;
		[Static]
		[Export ("getInvoice:completionHandler:")]
		void GetInvoice ([NullAllowed] string invoiceID, [NullAllowed] PPRetailInvoicingServiceGetInvoiceHandler completionHandler);

		// +(void)getNextInvoiceNumber:(PPRetailInvoicingServiceGetNextInvoiceNumberHandler _Nullable)completionHandler;
		[Static]
		[Export ("getNextInvoiceNumber:")]
		void GetNextInvoiceNumber ([NullAllowed] PPRetailInvoicingServiceGetNextInvoiceNumberHandler completionHandler);

		// +(void)getAccountSummary:(PPRetailInvoicingServiceGetAccountSummaryHandler _Nullable)completionHandler;
		[Static]
		[Export ("getAccountSummary:")]
		void GetAccountSummary ([NullAllowed] PPRetailInvoicingServiceGetAccountSummaryHandler completionHandler);

		// +(void)getTemplates:(PPRetailInvoicingServiceGetTemplatesHandler _Nullable)completionHandler;
		[Static]
		[Export ("getTemplates:")]
		void GetTemplates ([NullAllowed] PPRetailInvoicingServiceGetTemplatesHandler completionHandler);

		// +(void)uploadFile:(NSString * _Nullable)fileHandle contentType:(NSString * _Nullable)contentType completionHandler:(PPRetailInvoicingServiceUploadFileHandler _Nullable)completionHandler;
		[Static]
		[Export ("uploadFile:contentType:completionHandler:")]
		void UploadFile ([NullAllowed] string fileHandle, [NullAllowed] string contentType, [NullAllowed] PPRetailInvoicingServiceUploadFileHandler completionHandler);
	}

	// @interface PPRetailMagneticCard : PPRetailCard
	[BaseType (typeof (PPRetailCard))]
	interface PPRetailMagneticCard {
		// @property (nonatomic, strong) NSString * _Nullable pan;
		[NullAllowed, Export ("pan", ArgumentSemantic.Strong)]
		string Pan { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable expiration;
		[NullAllowed, Export ("expiration", ArgumentSemantic.Strong)]
		string Expiration { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable track1;
		[NullAllowed, Export ("track1", ArgumentSemantic.Strong)]
		string Track1 { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable track2;
		[NullAllowed, Export ("track2", ArgumentSemantic.Strong)]
		string Track2 { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable track3;
		[NullAllowed, Export ("track3", ArgumentSemantic.Strong)]
		string Track3 { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable firstName;
		[NullAllowed, Export ("firstName", ArgumentSemantic.Strong)]
		string FirstName { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable lastName;
		[NullAllowed, Export ("lastName", ArgumentSemantic.Strong)]
		string LastName { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable middleInitial;
		[NullAllowed, Export ("middleInitial", ArgumentSemantic.Strong)]
		string MiddleInitial { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable ksn;
		[NullAllowed, Export ("ksn", ArgumentSemantic.Strong)]
		string Ksn { get; set; }
	}

	// @interface PPRetailManuallyEnteredCard : PPRetailCard
	[BaseType (typeof (PPRetailCard))]
	interface PPRetailManuallyEnteredCard {
		// -(void)setCardNumber:(NSString * _Nullable)value;
		[Export ("setCardNumber:")]
		void SetCardNumber ([NullAllowed] string value);

		// -(NSString * _Nullable)getCardNumber;
		[NullAllowed, Export ("getCardNumber")]
		//[Verify (MethodToProperty)]
		string CardNumber { get; }

		// -(void)setCVV:(NSString * _Nullable)value;
		[Export ("setCVV:")]
		void SetCVV ([NullAllowed] string value);

		// -(NSString * _Nullable)getCVV;
		[NullAllowed, Export ("getCVV")]
		//[Verify (MethodToProperty)]
		string CVV { get; }

		// -(void)setPostalCode:(NSString * _Nullable)value;
		[Export ("setPostalCode:")]
		void SetPostalCode ([NullAllowed] string value);

		// -(NSString * _Nullable)getPostalCode;
		[NullAllowed, Export ("getPostalCode")]
		//[Verify (MethodToProperty)]
		string PostalCode { get; }

		// -(void)setExpiration:(NSString * _Nullable)date;
		[Export ("setExpiration:")]
		void SetExpiration ([NullAllowed] string date);

		// -(NSString * _Nullable)getExpiration;
		[NullAllowed, Export ("getExpiration")]
		//[Verify (MethodToProperty)]
		string Expiration { get; }
	}

	// @interface PPRetailMerchant : PPRetailObject
	[BaseType (typeof (PPRetailObject))]
	interface PPRetailMerchant {
		// @property (readonly, nonatomic, strong) NSString * _Nullable emailAddress;
		[NullAllowed, Export ("emailAddress", ArgumentSemantic.Strong)]
		string EmailAddress { get; }

		// @property (readonly, nonatomic, strong) NSString * _Nullable businessName;
		[NullAllowed, Export ("businessName", ArgumentSemantic.Strong)]
		string BusinessName { get; }

		// @property (readonly, nonatomic, strong) NSString * _Nullable currency;
		[NullAllowed, Export ("currency", ArgumentSemantic.Strong)]
		string Currency { get; }

		// @property (readonly, nonatomic, strong) NSString * _Nullable payerId;
		[NullAllowed, Export ("payerId", ArgumentSemantic.Strong)]
		string PayerId { get; }

		// @property (readonly, nonatomic, strong) PPRetailInvoiceAddress * _Nullable address;
		[NullAllowed, Export ("address", ArgumentSemantic.Strong)]
		PPRetailInvoiceAddress Address { get; }

		// @property (readonly, nonatomic, strong) NSString * _Nullable environment;
		[NullAllowed, Export ("environment", ArgumentSemantic.Strong)]
		string Environment { get; }

		// @property (nonatomic, strong) NSDecimalNumber * _Nullable signatureRequiredAbove;
		[NullAllowed, Export ("signatureRequiredAbove", ArgumentSemantic.Strong)]
		NSDecimalNumber SignatureRequiredAbove { get; set; }

		// @property (assign, nonatomic) BOOL isCertificationMode;
		[Export ("isCertificationMode")]
		bool IsCertificationMode { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable referrerCode;
		[NullAllowed, Export ("referrerCode", ArgumentSemantic.Strong)]
		string ReferrerCode { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable storeId;
		[NullAllowed, Export ("storeId", ArgumentSemantic.Strong)]
		string StoreId { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable softDescriptor;
		[NullAllowed, Export ("softDescriptor", ArgumentSemantic.Strong)]
		string SoftDescriptor { get; set; }

		// -(void)setTokenExpiredHandler:(PPRetailMerchantTokenExpirationHandlerHandler _Nullable)expirationHandler;
		[Export ("setTokenExpiredHandler:")]
		void SetTokenExpiredHandler ([NullAllowed] PPRetailMerchantTokenExpirationHandlerHandler expirationHandler);

		// -(void)forwardReceipt:(PPRetailRetailInvoice * _Nullable)invoice emailOrSms:(NSString * _Nullable)emailOrSms txNumber:(NSString * _Nullable)txNumber txType:(NSString * _Nullable)txType customerId:(NSString * _Nullable)customerId receiptPreferenceToken:(NSString * _Nullable)receiptPreferenceToken callback:(PPRetailMerchantReceiptForwardedHandler _Nullable)callback;
		[Export ("forwardReceipt:emailOrSms:txNumber:txType:customerId:receiptPreferenceToken:callback:")]
		void ForwardReceipt ([NullAllowed] PPRetailRetailInvoice invoice, [NullAllowed] string emailOrSms, [NullAllowed] string txNumber, [NullAllowed] string txType, [NullAllowed] string customerId, [NullAllowed] string receiptPreferenceToken, [NullAllowed] PPRetailMerchantReceiptForwardedHandler callback);
	}

	// @interface PPRetailMerchantManager : PPRetailObject
	[BaseType (typeof (PPRetailObject))]
	interface PPRetailMerchantManager {
		// -(PPRetailObject * _Nullable)getFakeMerchantData;
		[NullAllowed, Export ("getFakeMerchantData")]
		//[Verify (MethodToProperty)]
		PPRetailObject FakeMerchantData { get; }

		// -(PPRetailMerchant * _Nullable)getMerchant;
		[NullAllowed, Export ("getMerchant")]
		//[Verify (MethodToProperty)]
		PPRetailMerchant Merchant { get; }
	}

	// @interface PPRetailNetworkRequest : PPRetailObject
	[BaseType (typeof (PPRetailObject))]
	interface PPRetailNetworkRequest {
		// @property (nonatomic, strong) NSString * _Nullable url;
		[NullAllowed, Export ("url", ArgumentSemantic.Strong)]
		string Url { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable method;
		[NullAllowed, Export ("method", ArgumentSemantic.Strong)]
		string Method { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable format;
		[NullAllowed, Export ("format", ArgumentSemantic.Strong)]
		string Format { get; set; }

		// @property (nonatomic, strong) NSDictionary * _Nullable headers;
		[NullAllowed, Export ("headers", ArgumentSemantic.Strong)]
		NSDictionary Headers { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable body;
		[NullAllowed, Export ("body", ArgumentSemantic.Strong)]
		string Body { get; set; }

		// -(void)continueWithResponse:(PPRetailError * _Nullable)err didHandle:(BOOL)didHandle response:(PPRetailNetworkResponse * _Nullable)response;
		[Export ("continueWithResponse:didHandle:response:")]
		void ContinueWithResponse ([NullAllowed] PPRetailError err, bool didHandle, [NullAllowed] PPRetailNetworkResponse response);
	}

	// @interface PPRetailNetworkResponse : PPRetailObject
	[BaseType (typeof (PPRetailObject))]
	interface PPRetailNetworkResponse {
		// @property (nonatomic, strong) NSString * _Nullable statusCode;
		[NullAllowed, Export ("statusCode", ArgumentSemantic.Strong)]
		string StatusCode { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable format;
		[NullAllowed, Export ("format", ArgumentSemantic.Strong)]
		string Format { get; set; }

		// @property (nonatomic, strong) NSDictionary * _Nullable headers;
		[NullAllowed, Export ("headers", ArgumentSemantic.Strong)]
		NSDictionary Headers { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable body;
		[NullAllowed, Export ("body", ArgumentSemantic.Strong)]
		string Body { get; set; }
	}

	// @interface PPRetailOfflinePaymentInfo : PPRetailObject
	[BaseType (typeof (PPRetailObject))]
	interface PPRetailOfflinePaymentInfo {
		// @property (nonatomic, strong) NSDecimalNumber * _Nullable total;
		[NullAllowed, Export ("total", ArgumentSemantic.Strong)]
		NSDecimalNumber Total { get; set; }

		// @property (nonatomic, strong) NSArray * _Nullable statusList;
		[NullAllowed, Export ("statusList", ArgumentSemantic.Strong)]
		//[Verify (StronglyTypedNSArray)]
		NSObject [] StatusList { get; set; }
	}

	// @interface PPRetailOfflinePaymentStatus : PPRetailObject
	[BaseType (typeof (PPRetailObject))]
	interface PPRetailOfflinePaymentStatus {
		// @property (readonly, nonatomic, strong) NSString * _Nullable id;
		[NullAllowed, Export ("id", ArgumentSemantic.Strong)]
		string Id { get; }

		// @property (readonly, nonatomic, strong) NSDate * _Nullable createTime;
		[NullAllowed, Export ("createTime", ArgumentSemantic.Strong)]
		NSDate CreateTime { get; }

		// @property (readonly, nonatomic, strong) NSDecimalNumber * _Nullable amount;
		[NullAllowed, Export ("amount", ArgumentSemantic.Strong)]
		NSDecimalNumber Amount { get; }

		// @property (readonly, nonatomic, strong) NSArray * _Nullable cardIssuer;
		[NullAllowed, Export ("cardIssuer", ArgumentSemantic.Strong)]
		//[Verify (StronglyTypedNSArray)]
		NSObject [] CardIssuer { get; }

		// @property (readonly, assign, nonatomic) int retry;
		[Export ("retry")]
		int Retry { get; }

		// @property (readonly, assign, nonatomic) int replay;
		[Export ("replay")]
		int Replay { get; }

		// @property (readonly, assign, nonatomic) int errNo;
		[Export ("errNo")]
		int ErrNo { get; }

		// @property (readonly, nonatomic, strong) NSString * _Nullable errMessage;
		[NullAllowed, Export ("errMessage", ArgumentSemantic.Strong)]
		string ErrMessage { get; }

		// @property (readonly, assign, nonatomic) BOOL isDeclined;
		[Export ("isDeclined")]
		bool IsDeclined { get; }

		// @property (readonly, nonatomic, strong) NSDate * _Nullable expiry;
		[NullAllowed, Export ("expiry", ArgumentSemantic.Strong)]
		NSDate Expiry { get; }

		// @property (readonly, assign, nonatomic) PPRetailOfflineTransactionState state;
		[Export ("state", ArgumentSemantic.Assign)]
		PPRetailOfflineTransactionState State { get; }

		// @property (readonly, nonatomic, strong) NSString * _Nullable invoiceNumber;
		[NullAllowed, Export ("invoiceNumber", ArgumentSemantic.Strong)]
		string InvoiceNumber { get; }

		// @property (readonly, nonatomic, strong) NSString * _Nullable invoiceId;
		[NullAllowed, Export ("invoiceId", ArgumentSemantic.Strong)]
		string InvoiceId { get; }

		// @property (readonly, nonatomic, strong) NSString * _Nullable transactionNumber;
		[NullAllowed, Export ("transactionNumber", ArgumentSemantic.Strong)]
		string TransactionNumber { get; }

		// @property (readonly, nonatomic, strong) NSString * _Nullable latitude;
		[NullAllowed, Export ("latitude", ArgumentSemantic.Strong)]
		string Latitude { get; }

		// @property (readonly, nonatomic, strong) NSString * _Nullable longitude;
		[NullAllowed, Export ("longitude", ArgumentSemantic.Strong)]
		string Longitude { get; }

		// @property (readonly, assign, nonatomic) PPRetailTransactionBeginOptionsPaymentTypes paymentType;
		[Export ("paymentType", ArgumentSemantic.Assign)]
		PPRetailTransactionBeginOptionsPaymentTypes PaymentType { get; }

		// @property (readonly, nonatomic, strong) PPRetailCard * _Nullable card;
		[NullAllowed, Export ("card", ArgumentSemantic.Strong)]
		PPRetailCard Card { get; }

		// @property (readonly, nonatomic, strong) PPRetailRetailInvoice * _Nullable invoice;
		[NullAllowed, Export ("invoice", ArgumentSemantic.Strong)]
		PPRetailRetailInvoice Invoice { get; }
	}

	// @interface PPRetailRecord : PPRetailObject
	[BaseType (typeof (PPRetailObject))]
	interface PPRetailRecord {
		// @property (readonly, nonatomic, strong) PPRetailCard * _Nullable card;
		[NullAllowed, Export ("card", ArgumentSemantic.Strong)]
		PPRetailCard Card { get; }
	}

	// @interface PPRetailOfflineTransactionRecord : PPRetailRecord
	[BaseType (typeof (PPRetailRecord))]
	interface PPRetailOfflineTransactionRecord {
		// @property (readonly, nonatomic, strong) NSString * _Nullable id;
		[NullAllowed, Export ("id", ArgumentSemantic.Strong)]
		string Id { get; }

		// @property (readonly, assign, nonatomic) int amount;
		[Export ("amount")]
		int Amount { get; }

		// @property (readonly, nonatomic, strong) NSDate * _Nullable validUntil;
		[NullAllowed, Export ("validUntil", ArgumentSemantic.Strong)]
		NSDate ValidUntil { get; }

		// @property (readonly, nonatomic, strong) NSString * _Nullable invoiceNumber;
		[NullAllowed, Export ("invoiceNumber", ArgumentSemantic.Strong)]
		string InvoiceNumber { get; }
	}

	// @interface PPRetailPage : PPRetailObject
	[BaseType (typeof (PPRetailObject))]
	[DisableDefaultCtor]
	interface PPRetailPage {
		// @property (readonly, nonatomic, strong) NSString * _Nullable name;
		[NullAllowed, Export ("name", ArgumentSemantic.Strong)]
		string Name { get; }

		// @property (readonly, nonatomic, strong) NSString * _Nullable action;
		[NullAllowed, Export ("action", ArgumentSemantic.Strong)]
		string Action { get; }

		// @property (readonly, nonatomic, strong) PPRetailPage * _Nullable parent;
		[NullAllowed, Export ("parent", ArgumentSemantic.Strong)]
		PPRetailPage Parent { get; }

		// -(instancetype _Nullable)initWithId:(NSString * _Nullable)id parent:(PPRetailPage * _Nullable)parent;
		[Export ("initWithId:parent:")]
		IntPtr Constructor ([NullAllowed] string id, [NullAllowed] PPRetailPage parent);
	}

	// @interface PPRetailPayPalErrorInfo : PPRetailObject
	[BaseType (typeof (PPRetailObject))]
	interface PPRetailPayPalErrorInfo {
		// @property (nonatomic, strong) NSString * _Nullable message;
		[NullAllowed, Export ("message", ArgumentSemantic.Strong)]
		string Message { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable domain;
		[NullAllowed, Export ("domain", ArgumentSemantic.Strong)]
		string Domain { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable code;
		[NullAllowed, Export ("code", ArgumentSemantic.Strong)]
		string Code { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable debugId;
		[NullAllowed, Export ("debugId", ArgumentSemantic.Strong)]
		string DebugId { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable developerMessage;
		[NullAllowed, Export ("developerMessage", ArgumentSemantic.Strong)]
		string DeveloperMessage { get; set; }
	}

	// @interface PPRetailPayer : PPRetailObject
	[BaseType (typeof (PPRetailObject))]
	interface PPRetailPayer {
		// @property (readonly, nonatomic, strong) NSString * _Nullable customerId;
		[NullAllowed, Export ("customerId", ArgumentSemantic.Strong)]
		string CustomerId { get; }

		// @property (readonly, nonatomic, strong) NSString * _Nullable receiptPreferenceToken;
		[NullAllowed, Export ("receiptPreferenceToken", ArgumentSemantic.Strong)]
		string ReceiptPreferenceToken { get; }

		// @property (readonly, nonatomic, strong) NSString * _Nullable maskedEmail;
		[NullAllowed, Export ("maskedEmail", ArgumentSemantic.Strong)]
		string MaskedEmail { get; }

		// @property (readonly, nonatomic, strong) NSString * _Nullable maskedPhone;
		[NullAllowed, Export ("maskedPhone", ArgumentSemantic.Strong)]
		string MaskedPhone { get; }
	}

	// @interface PPRetailPaymentDevice : PPRetailObject
	[BaseType (typeof (PPRetailObject))]
	[DisableDefaultCtor]
	interface PPRetailPaymentDevice {
		// @property (readonly, nonatomic, strong) NSString * _Nullable id;
		[NullAllowed, Export ("id", ArgumentSemantic.Strong)]
		string Id { get; }

		// @property (nonatomic, strong) NSString * _Nullable address;
		[NullAllowed, Export ("address", ArgumentSemantic.Strong)]
		string Address { get; set; }

		// @property (readonly, nonatomic, strong) NSString * _Nullable name;
		[NullAllowed, Export ("name", ArgumentSemantic.Strong)]
		string Name { get; }

		// @property (readonly, assign, nonatomic) PPRetailReaderModel model;
		[Export ("model", ArgumentSemantic.Assign)]
		PPRetailReaderModel Model { get; }

		// @property (readonly, nonatomic, strong) NSString * _Nullable serialNumber;
		[NullAllowed, Export ("serialNumber", ArgumentSemantic.Strong)]
		string SerialNumber { get; }

		// @property (readonly, nonatomic, strong) PPRetailBatteryInfo * _Nullable lastKnownBatteryInfo;
		[NullAllowed, Export ("lastKnownBatteryInfo", ArgumentSemantic.Strong)]
		PPRetailBatteryInfo LastKnownBatteryInfo { get; }

		// @property (readonly, assign, nonatomic) BOOL activated;
		[Export ("activated")]
		bool Activated { get; }

		// @property (readonly, nonatomic, strong) NSArray * _Nullable formFactors;
		[NullAllowed, Export ("formFactors", ArgumentSemantic.Strong)]
		//[Verify (StronglyTypedNSArray)]
		NSObject [] FormFactors { get; }

		// @property (nonatomic, strong) PPRetailDeviceUpdate * _Nullable pendingUpdate;
		[NullAllowed, Export ("pendingUpdate", ArgumentSemantic.Strong)]
		PPRetailDeviceUpdate PendingUpdate { get; set; }

		// @property (readonly, assign, nonatomic) PPRetailreaderType type;
		[Export ("type", ArgumentSemantic.Assign)]
		PPRetailreaderType Type { get; }

		// @property (readonly, assign, nonatomic) PPRetailreaderConnectionType connectionType;
		[Export ("connectionType", ArgumentSemantic.Assign)]
		PPRetailreaderConnectionType ConnectionType { get; }

		// @property (readonly, assign, nonatomic) BOOL cardInSlot;
		[Export ("cardInSlot")]
		bool CardInSlot { get; }

		// @property (readonly, assign, nonatomic) BOOL isBlacklisted;
		[Export ("isBlacklisted")]
		bool IsBlacklisted { get; }

		// -(instancetype _Nullable)initWithUniqueId:(NSString * _Nullable)uniqueId native:(PPRetailObject * _Nullable)native app:(PPRetailObject * _Nullable)app connectionType:(PPRetailreaderConnectionType)connectionType hardwareAddress:(NSString * _Nullable)hardwareAddress;
		[Export ("initWithUniqueId:native:app:connectionType:hardwareAddress:")]
		IntPtr Constructor ([NullAllowed] string uniqueId, [NullAllowed] PPRetailObject native, [NullAllowed] PPRetailObject app, PPRetailreaderConnectionType connectionType, [NullAllowed] string hardwareAddress);

		// -(NSString * _Nullable)getManufacturer;
		[NullAllowed, Export ("getManufacturer")]
		//[Verify (MethodToProperty)]
		string Manufacturer { get; }

		// -(void)extractReaderLogs:(PPRetailPaymentDeviceDeviceLogsHandler _Nullable)callback;
		[Export ("extractReaderLogs:")]
		void ExtractReaderLogs ([NullAllowed] PPRetailPaymentDeviceDeviceLogsHandler callback);

		// -(BOOL)isFormFactorActive:(PPRetailFormFactor)formFactor;
		[Export ("isFormFactorActive:")]
		bool IsFormFactorActive (PPRetailFormFactor formFactor);

		// -(void)connect:(PPRetailPaymentDeviceConnectHandler _Nullable)callback;
		[Export ("connect:")]
		void Connect ([NullAllowed] PPRetailPaymentDeviceConnectHandler callback);

		// -(void)retrieveBatteryInfo:(PPRetailPaymentDeviceBatteryInfoHandler _Nullable)cb;
		[Export ("retrieveBatteryInfo:")]
		void RetrieveBatteryInfo ([NullAllowed] PPRetailPaymentDeviceBatteryInfoHandler cb);

		// -(void)disconnect:(PPRetailPaymentDeviceDisconnectHandler _Nullable)callback;
		[Export ("disconnect:")]
		void Disconnect ([NullAllowed] PPRetailPaymentDeviceDisconnectHandler callback);

		// -(NSDictionary * _Nullable)getVersionInfo;
		[NullAllowed, Export ("getVersionInfo")]
		//[Verify (MethodToProperty)]
		NSDictionary VersionInfo { get; }

		// -(BOOL)isConnected;
		[Export ("isConnected")]
		//[Verify (MethodToProperty)]
		bool IsConnected { get; }

		// -(PPRetailDeviceStatus * _Nullable)isReadyForTransaction;
		[NullAllowed, Export ("isReadyForTransaction")]
		//[Verify (MethodToProperty)]
		PPRetailDeviceStatus IsReadyForTransaction { get; }

		// -(BOOL)doesHaveCapability:(PPRetaildeviceCapabilityType)capability;
		[Export ("doesHaveCapability:")]
		bool DoesHaveCapability (PPRetaildeviceCapabilityType capability);

		// -(PPRetailConnectedSignal _Nullable)addConnectedListener:(PPRetailConnectedEvent _Nullable)listener;
		[Export ("addConnectedListener:")]
		[return: NullAllowed]
		NSObject AddConnectedListener ([NullAllowed] PPRetailConnectedEvent listener);

		// -(void)removeConnectedListener:(PPRetailConnectedSignal _Nullable)listenerToken;
		[Export ("removeConnectedListener:")]
		void RemoveConnectedListener ([NullAllowed] NSObject listenerToken);

		// -(PPRetailSelectedSignal _Nullable)addSelectedListener:(PPRetailSelectedEvent _Nullable)listener;
		[Export ("addSelectedListener:")]
		[return: NullAllowed]
		NSObject AddSelectedListener ([NullAllowed] PPRetailSelectedEvent listener);

		// -(void)removeSelectedListener:(PPRetailSelectedSignal _Nullable)listenerToken;
		[Export ("removeSelectedListener:")]
		void RemoveSelectedListener ([NullAllowed] NSObject listenerToken);

		// -(PPRetailConnectionErrorSignal _Nullable)addConnectionErrorListener:(PPRetailConnectionErrorEvent _Nullable)listener;
		[Export ("addConnectionErrorListener:")]
		[return: NullAllowed]
		NSObject AddConnectionErrorListener ([NullAllowed] PPRetailConnectionErrorEvent listener);

		// -(void)removeConnectionErrorListener:(PPRetailConnectionErrorSignal _Nullable)listenerToken;
		[Export ("removeConnectionErrorListener:")]
		void RemoveConnectionErrorListener ([NullAllowed] NSObject listenerToken);

		// -(PPRetailDisconnectedSignal _Nullable)addDisconnectedListener:(PPRetailDisconnectedEvent _Nullable)listener;
		[Export ("addDisconnectedListener:")]
		[return: NullAllowed]
		NSObject AddDisconnectedListener ([NullAllowed] PPRetailDisconnectedEvent listener);

		// -(void)removeDisconnectedListener:(PPRetailDisconnectedSignal _Nullable)listenerToken;
		[Export ("removeDisconnectedListener:")]
		void RemoveDisconnectedListener ([NullAllowed] NSObject listenerToken);

		// -(PPRetailUpdateRequiredSignal _Nullable)addUpdateRequiredListener:(PPRetailUpdateRequiredEvent _Nullable)listener;
		[Export ("addUpdateRequiredListener:")]
		[return: NullAllowed]
		NSObject AddUpdateRequiredListener ([NullAllowed] PPRetailUpdateRequiredEvent listener);

		// -(void)removeUpdateRequiredListener:(PPRetailUpdateRequiredSignal _Nullable)listenerToken;
		[Export ("removeUpdateRequiredListener:")]
		void RemoveUpdateRequiredListener ([NullAllowed] NSObject listenerToken);

		// -(PPRetailBatteryStatusUpdateSignal _Nullable)addBatteryStatusUpdateListener:(PPRetailBatteryStatusUpdateEvent _Nullable)listener;
		[Export ("addBatteryStatusUpdateListener:")]
		[return: NullAllowed]
		NSObject AddBatteryStatusUpdateListener ([NullAllowed] PPRetailBatteryStatusUpdateEvent listener);

		// -(void)removeBatteryStatusUpdateListener:(PPRetailBatteryStatusUpdateSignal _Nullable)listenerToken;
		[Export ("removeBatteryStatusUpdateListener:")]
		void RemoveBatteryStatusUpdateListener ([NullAllowed] NSObject listenerToken);

		// -(PPRetailCardRemovedSignal _Nullable)addCardRemovedListener:(PPRetailCardRemovedEvent _Nullable)listener;
		[Export ("addCardRemovedListener:")]
		[return: NullAllowed]
		NSObject AddCardRemovedListener ([NullAllowed] PPRetailCardRemovedEvent listener);

		// -(void)removeCardRemovedListener:(PPRetailCardRemovedSignal _Nullable)listenerToken;
		[Export ("removeCardRemovedListener:")]
		void RemoveCardRemovedListener ([NullAllowed] NSObject listenerToken);

		// -(PPRetailCardPresentedSignal _Nullable)addCardPresentedListener:(PPRetailCardPresentedEvent _Nullable)listener;
		[Export ("addCardPresentedListener:")]
		[return: NullAllowed]
		NSObject AddCardPresentedListener ([NullAllowed] PPRetailCardPresentedEvent listener);

		// -(void)removeCardPresentedListener:(PPRetailCardPresentedSignal _Nullable)listenerToken;
		[Export ("removeCardPresentedListener:")]
		void RemoveCardPresentedListener ([NullAllowed] NSObject listenerToken);

		// -(PPRetailBlacklistedSignal _Nullable)addBlacklistedListener:(PPRetailBlacklistedEvent _Nullable)listener;
		[Export ("addBlacklistedListener:")]
		[return: NullAllowed]
		NSObject AddBlacklistedListener ([NullAllowed] PPRetailBlacklistedEvent listener);

		// -(void)removeBlacklistedListener:(PPRetailBlacklistedSignal _Nullable)listenerToken;
		[Export ("removeBlacklistedListener:")]
		void RemoveBlacklistedListener ([NullAllowed] NSObject listenerToken);
	}

	// @interface PPRetailQRCRecord : PPRetailRecord
	[BaseType (typeof (PPRetailRecord))]
	interface PPRetailQRCRecord {
		// @property (readonly, nonatomic, strong) NSString * _Nullable transactionNumber;
		[NullAllowed, Export ("transactionNumber", ArgumentSemantic.Strong)]
		string TransactionNumber { get; }

		// @property (readonly, assign, nonatomic) PPRetailQRCStatus qrcStatus;
		[Export ("qrcStatus", ArgumentSemantic.Assign)]
		PPRetailQRCStatus QrcStatus { get; }

		// @property (readonly, nonatomic, strong) NSString * _Nullable invoiceId;
		[NullAllowed, Export ("invoiceId", ArgumentSemantic.Strong)]
		string InvoiceId { get; }

		// @property (readonly, nonatomic, strong) NSString * _Nullable sessionId;
		[NullAllowed, Export ("sessionId", ArgumentSemantic.Strong)]
		string SessionId { get; }

		// @property (assign, nonatomic) PPRetailInvoicePaymentMethod paymentMethod;
		[Export ("paymentMethod", ArgumentSemantic.Assign)]
		PPRetailInvoicePaymentMethod PaymentMethod { get; set; }

		// @property (readonly, nonatomic, strong) NSString * _Nullable responseCode;
		[NullAllowed, Export ("responseCode", ArgumentSemantic.Strong)]
		string ResponseCode { get; }

		// @property (readonly, nonatomic, strong) PPRetailPayer * _Nullable payer;
		[NullAllowed, Export ("payer", ArgumentSemantic.Strong)]
		PPRetailPayer Payer { get; }

		// @property (readonly, nonatomic, strong) NSString * _Nullable correlationId;
		[NullAllowed, Export ("correlationId", ArgumentSemantic.Strong)]
		string CorrelationId { get; }

		// @property (readonly, assign, nonatomic) PPRetailQRCContentType contentType;
		[Export ("contentType", ArgumentSemantic.Assign)]
		PPRetailQRCContentType ContentType { get; }

		// @property (readonly, nonatomic, strong) NSString * _Nullable content;
		[NullAllowed, Export ("content", ArgumentSemantic.Strong)]
		string Content { get; }
	}

	// @interface PPRetailReaderConfiguration : PPRetailObject
	[BaseType (typeof (PPRetailObject))]
	[DisableDefaultCtor]
	interface PPRetailReaderConfiguration {
		// @property (nonatomic, strong) NSArray * _Nullable name;
		[NullAllowed, Export ("name", ArgumentSemantic.Strong)]
		//[Verify (StronglyTypedNSArray)]
		NSObject [] Name { get; set; }

		// @property (nonatomic, strong) NSArray * _Nullable address;
		[NullAllowed, Export ("address", ArgumentSemantic.Strong)]
		//[Verify (StronglyTypedNSArray)]
		NSObject [] Address { get; set; }

		// @property (nonatomic, strong) NSArray * _Nullable manufacturer;
		[NullAllowed, Export ("manufacturer", ArgumentSemantic.Strong)]
		//[Verify (StronglyTypedNSArray)]
		NSObject [] Manufacturer { get; set; }

		// @property (nonatomic, strong) NSArray * _Nullable connectionType;
		[NullAllowed, Export ("connectionType", ArgumentSemantic.Strong)]
		//[Verify (StronglyTypedNSArray)]
		NSObject [] ConnectionType { get; set; }

		// @property (readonly, nonatomic, strong) NSArray * _Nullable manufacturerName;
		[NullAllowed, Export ("manufacturerName", ArgumentSemantic.Strong)]
		//[Verify (StronglyTypedNSArray)]
		NSObject [] ManufacturerName { get; }

		// @property (readonly, nonatomic, strong) NSArray * _Nullable connectionTypeValue;
		[NullAllowed, Export ("connectionTypeValue", ArgumentSemantic.Strong)]
		//[Verify (StronglyTypedNSArray)]
		NSObject [] ConnectionTypeValue { get; }

		// -(instancetype _Nullable)initWithManufacturer:(NSArray * _Nullable)manufacturer;
		[Export ("initWithManufacturer:")]
		//[Verify (StronglyTypedNSArray)]
		IntPtr Constructor ([NullAllowed] NSObject [] manufacturer);
	}

	// @interface PPRetailReceiptDestination : PPRetailObject
	[BaseType (typeof (PPRetailObject))]
	interface PPRetailReceiptDestination {
		// @property (assign, nonatomic) PPRetailReceiptDestinationType type;
		[Export ("type", ArgumentSemantic.Assign)]
		PPRetailReceiptDestinationType Type { get; set; }

		// @property (readonly, nonatomic, strong) NSString * _Nullable email;
		[NullAllowed, Export ("email", ArgumentSemantic.Strong)]
		string Email { get; }
	}

	// @interface PPRetailReceiptEmailEntryViewContent : PPRetailObject
	[BaseType (typeof (PPRetailObject))]
	interface PPRetailReceiptEmailEntryViewContent {
		// @property (nonatomic, strong) NSString * _Nullable title;
		[NullAllowed, Export ("title", ArgumentSemantic.Strong)]
		string Title { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable placeholder;
		[NullAllowed, Export ("placeholder", ArgumentSemantic.Strong)]
		string Placeholder { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable disclaimer;
		[NullAllowed, Export ("disclaimer", ArgumentSemantic.Strong)]
		string Disclaimer { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable sendButtonTitle;
		[NullAllowed, Export ("sendButtonTitle", ArgumentSemantic.Strong)]
		string SendButtonTitle { get; set; }
	}

	// @interface PPRetailReceiptOptionsViewContent : PPRetailObject
	[BaseType (typeof (PPRetailObject))]
	interface PPRetailReceiptOptionsViewContent {
		// @property (nonatomic, strong) NSString * _Nullable title;
		[NullAllowed, Export ("title", ArgumentSemantic.Strong)]
		string Title { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable message;
		[NullAllowed, Export ("message", ArgumentSemantic.Strong)]
		string Message { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable prompt;
		[NullAllowed, Export ("prompt", ArgumentSemantic.Strong)]
		string Prompt { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable titleIconFilename;
		[NullAllowed, Export ("titleIconFilename", ArgumentSemantic.Strong)]
		string TitleIconFilename { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable maskedEmail;
		[NullAllowed, Export ("maskedEmail", ArgumentSemantic.Strong)]
		string MaskedEmail { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable maskedPhone;
		[NullAllowed, Export ("maskedPhone", ArgumentSemantic.Strong)]
		string MaskedPhone { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable disclaimer;
		[NullAllowed, Export ("disclaimer", ArgumentSemantic.Strong)]
		string Disclaimer { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable emailButtonTitle;
		[NullAllowed, Export ("emailButtonTitle", ArgumentSemantic.Strong)]
		string EmailButtonTitle { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable smsButtonTitle;
		[NullAllowed, Export ("smsButtonTitle", ArgumentSemantic.Strong)]
		string SmsButtonTitle { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable noThanksButtonTitle;
		[NullAllowed, Export ("noThanksButtonTitle", ArgumentSemantic.Strong)]
		string NoThanksButtonTitle { get; set; }

		// @property (nonatomic, strong) NSArray * _Nullable additionalReceiptOptions;
		[NullAllowed, Export ("additionalReceiptOptions", ArgumentSemantic.Strong)]
		//[Verify (StronglyTypedNSArray)]
		NSObject [] AdditionalReceiptOptions { get; set; }
	}

	// @interface PPRetailReceiptSMSEntryViewContent : PPRetailObject
	[BaseType (typeof (PPRetailObject))]
	interface PPRetailReceiptSMSEntryViewContent {
		// @property (nonatomic, strong) NSString * _Nullable title;
		[NullAllowed, Export ("title", ArgumentSemantic.Strong)]
		string Title { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable placeholder;
		[NullAllowed, Export ("placeholder", ArgumentSemantic.Strong)]
		string Placeholder { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable disclaimer;
		[NullAllowed, Export ("disclaimer", ArgumentSemantic.Strong)]
		string Disclaimer { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable sendButtonTitle;
		[NullAllowed, Export ("sendButtonTitle", ArgumentSemantic.Strong)]
		string SendButtonTitle { get; set; }
	}

	// @interface PPRetailReceiptViewContent : PPRetailObject
	[BaseType (typeof (PPRetailObject))]
	interface PPRetailReceiptViewContent {
		// @property (nonatomic, strong) PPRetailReceiptOptionsViewContent * _Nullable receiptOptionsViewContent;
		[NullAllowed, Export ("receiptOptionsViewContent", ArgumentSemantic.Strong)]
		PPRetailReceiptOptionsViewContent ReceiptOptionsViewContent { get; set; }

		// @property (nonatomic, strong) PPRetailReceiptEmailEntryViewContent * _Nullable receiptEmailEntryViewContent;
		[NullAllowed, Export ("receiptEmailEntryViewContent", ArgumentSemantic.Strong)]
		PPRetailReceiptEmailEntryViewContent ReceiptEmailEntryViewContent { get; set; }

		// @property (nonatomic, strong) PPRetailReceiptSMSEntryViewContent * _Nullable receiptSMSEntryViewContent;
		[NullAllowed, Export ("receiptSMSEntryViewContent", ArgumentSemantic.Strong)]
		PPRetailReceiptSMSEntryViewContent ReceiptSMSEntryViewContent { get; set; }
	}

	// @interface PPRetailRetailInvoice : PPRetailInvoice
	[BaseType (typeof (PPRetailInvoice))]
	[DisableDefaultCtor]
	interface PPRetailRetailInvoice {
		// @property (nonatomic, strong) NSString * _Nullable name;
		[NullAllowed, Export ("name", ArgumentSemantic.Strong)]
		string Name { get; set; }

		// @property (nonatomic, strong) NSDecimalNumber * _Nullable total;
		[NullAllowed, Export ("total", ArgumentSemantic.Strong)]
		NSDecimalNumber Total { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable txnHandle;
		[NullAllowed, Export ("txnHandle", ArgumentSemantic.Strong)]
		string TxnHandle { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable countryCode;
		[NullAllowed, Export ("countryCode", ArgumentSemantic.Strong)]
		string CountryCode { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable storeId;
		[NullAllowed, Export ("storeId", ArgumentSemantic.Strong)]
		string StoreId { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable terminalId;
		[NullAllowed, Export ("terminalId", ArgumentSemantic.Strong)]
		string TerminalId { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable sellerId;
		[NullAllowed, Export ("sellerId", ArgumentSemantic.Strong)]
		string SellerId { get; set; }

		// @property (assign, nonatomic) PPRetailInvoiceStatus status;
		[Export ("status", ArgumentSemantic.Assign)]
		PPRetailInvoiceStatus Status { get; set; }

		// @property (nonatomic, strong) NSArray * _Nullable payments;
		[NullAllowed, Export ("payments", ArgumentSemantic.Strong)]
		//[Verify (StronglyTypedNSArray)]
		NSObject [] Payments { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable deviceName;
		[NullAllowed, Export ("deviceName", ArgumentSemantic.Strong)]
		string DeviceName { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable footer;
		[NullAllowed, Export ("footer", ArgumentSemantic.Strong)]
		string Footer { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable payPalId;
		[NullAllowed, Export ("payPalId", ArgumentSemantic.Strong)]
		string PayPalId { get; set; }

		// @property (assign, nonatomic) BOOL isCancelled;
		[Export ("isCancelled")]
		bool IsCancelled { get; set; }

		// @property (assign, nonatomic) BOOL isFailed;
		[Export ("isFailed")]
		bool IsFailed { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable referrerCode;
		[NullAllowed, Export ("referrerCode", ArgumentSemantic.Strong)]
		string ReferrerCode { get; set; }

		// -(instancetype _Nullable)initWithCurrencyCode:(NSString * _Nullable)currencyCode;
		[Export ("initWithCurrencyCode:")]
		IntPtr Constructor ([NullAllowed] string currencyCode);
	}

	// @interface PPRetailRetailInvoicePayment : PPRetailInvoicePayment
	[BaseType (typeof (PPRetailInvoicePayment))]
	interface PPRetailRetailInvoicePayment {
		// @property (nonatomic, strong) NSString * _Nullable transactionID;
		[NullAllowed, Export ("transactionID", ArgumentSemantic.Strong)]
		string TransactionID { get; set; }

		// @property (assign, nonatomic) PPRetailInvoicePaymentMethod method;
		[Export ("method", ArgumentSemantic.Assign)]
		PPRetailInvoicePaymentMethod Method { get; set; }
	}

	// @interface PPRetailSDK : PPRetailObject
	[BaseType (typeof (PPRetailObject))]
	interface PPRetailSDK {
		// @property (assign, nonatomic) PPRetailReceiptScreenOrientation receiptScreenOrientation;
		[Export ("receiptScreenOrientation", ArgumentSemantic.Assign)]
		PPRetailReceiptScreenOrientation ReceiptScreenOrientation { get; set; }

		// @property (readonly, nonatomic, strong) PPRetailBraintreeManager * _Nullable braintreeManager;
		[NullAllowed, Export ("braintreeManager", ArgumentSemantic.Strong)]
		PPRetailBraintreeManager BraintreeManager { get; }

		// @property (readonly, nonatomic, strong) PPRetailSimulationManager * _Nullable simulationManager;
		[NullAllowed, Export ("simulationManager", ArgumentSemantic.Strong)]
		PPRetailSimulationManager SimulationManager { get; }

		// @property (readonly, nonatomic, strong) PPRetailTransactionManager * _Nullable transactionManager;
		[NullAllowed, Export ("transactionManager", ArgumentSemantic.Strong)]
		PPRetailTransactionManager TransactionManager { get; }

		// @property (readonly, nonatomic, strong) PPRetailMerchantManager * _Nullable merchantManager;
		[NullAllowed, Export ("merchantManager", ArgumentSemantic.Strong)]
		PPRetailMerchantManager MerchantManager { get; }

		// @property (readonly, nonatomic, strong) PPRetailDeviceManager * _Nullable deviceManager;
		[NullAllowed, Export ("deviceManager", ArgumentSemantic.Strong)]
		PPRetailDeviceManager DeviceManager { get; }

		// -(void)logViaJs:(NSString * _Nullable)level component:(NSString * _Nullable)component message:(NSString * _Nullable)message extraData:(NSDictionary * _Nullable)extraData;
		[Export ("logViaJs:component:message:extraData:")]
		void LogViaJs ([NullAllowed] string level, [NullAllowed] string component, [NullAllowed] string message, [NullAllowed] NSDictionary extraData);

		// -(void)setUITheme:(PPRetailUITheme)theme;
		[Export ("setUITheme:")]
		void SetUITheme (PPRetailUITheme theme);

		// -(PPRetailUITheme)getUITheme;
		[Export ("getUITheme")]
		//[Verify (MethodToProperty)]
		PPRetailUITheme UITheme { get; }

		// -(void)setExecutingEnvironment:(PPRetailSdkEnvironmentInfo * _Nullable)sdkEnvInfo;
		[Export ("setExecutingEnvironment:")]
		void SetExecutingEnvironment ([NullAllowed] PPRetailSdkEnvironmentInfo sdkEnvInfo);

		// -(NSString * _Nullable)getSdkVersion;
		[NullAllowed, Export ("getSdkVersion")]
		//[Verify (MethodToProperty)]
		string SdkVersion { get; }

		// -(void)logout;
		[Export ("logout")]
		void Logout ();

		// -(void)setLogLevel:(PPRetaillogLevel)level;
		[Export ("setLogLevel:")]
		void SetLogLevel (PPRetaillogLevel level);

		// -(void)setNetworkInterceptor:(PPRetailSDKInterceptHandler _Nullable)interceptor;
		[Export ("setNetworkInterceptor:")]
		void SetNetworkInterceptor ([NullAllowed] PPRetailSDKInterceptHandler interceptor);

		// -(void)simulateDevice:(PPRetailDeviceSimulatorType)devices usecase:(PPRetailSimulatorUseCase)usecase jsonResponseData:(NSString * _Nullable)jsonResponseData;
		[Export ("simulateDevice:usecase:jsonResponseData:")]
		void SimulateDevice (PPRetailDeviceSimulatorType devices, PPRetailSimulatorUseCase usecase, [NullAllowed] string jsonResponseData);

		// -(PPRetailPageViewedSignal _Nullable)addPageViewedListener:(PPRetailPageViewedEvent _Nullable)listener;
		[Export ("addPageViewedListener:")]
		[return: NullAllowed]
		NSObject AddPageViewedListener ([NullAllowed] PPRetailPageViewedEvent listener);

		// -(void)removePageViewedListener:(PPRetailPageViewedSignal _Nullable)listenerToken;
		[Export ("removePageViewedListener:")]
		void RemovePageViewedListener ([NullAllowed] NSObject listenerToken);

		// -(PPRetailUntrustedNetworkSignal _Nullable)addUntrustedNetworkListener:(PPRetailUntrustedNetworkEvent _Nullable)listener;
		[Export ("addUntrustedNetworkListener:")]
		[return: NullAllowed]
		NSObject AddUntrustedNetworkListener ([NullAllowed] PPRetailUntrustedNetworkEvent listener);

		// -(void)removeUntrustedNetworkListener:(PPRetailUntrustedNetworkSignal _Nullable)listenerToken;
		[Export ("removeUntrustedNetworkListener:")]
		void RemoveUntrustedNetworkListener ([NullAllowed] NSObject listenerToken);
	}

	// @interface PPRetailSdkEnvironmentInfo : PPRetailObject
	[BaseType (typeof (PPRetailObject))]
	interface PPRetailSdkEnvironmentInfo {
		// @property (nonatomic, strong) NSString * _Nullable merchantId;
		[NullAllowed, Export ("merchantId", ArgumentSemantic.Strong)]
		string MerchantId { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable osName;
		[NullAllowed, Export ("osName", ArgumentSemantic.Strong)]
		string OsName { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable osVersion;
		[NullAllowed, Export ("osVersion", ArgumentSemantic.Strong)]
		string OsVersion { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable appId;
		[NullAllowed, Export ("appId", ArgumentSemantic.Strong)]
		string AppId { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable appName;
		[NullAllowed, Export ("appName", ArgumentSemantic.Strong)]
		string AppName { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable appVersion;
		[NullAllowed, Export ("appVersion", ArgumentSemantic.Strong)]
		string AppVersion { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable appBuild;
		[NullAllowed, Export ("appBuild", ArgumentSemantic.Strong)]
		string AppBuild { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable carrierCode;
		[NullAllowed, Export ("carrierCode", ArgumentSemantic.Strong)]
		string CarrierCode { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable currency;
		[NullAllowed, Export ("currency", ArgumentSemantic.Strong)]
		string Currency { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable environment;
		[NullAllowed, Export ("environment", ArgumentSemantic.Strong)]
		string Environment { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable deviceModel;
		[NullAllowed, Export ("deviceModel", ArgumentSemantic.Strong)]
		string DeviceModel { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable deviceManufacturer;
		[NullAllowed, Export ("deviceManufacturer", ArgumentSemantic.Strong)]
		string DeviceManufacturer { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable retailSDKVersion;
		[NullAllowed, Export ("retailSDKVersion", ArgumentSemantic.Strong)]
		string RetailSDKVersion { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable osAdId;
		[NullAllowed, Export ("osAdId", ArgumentSemantic.Strong)]
		string OsAdId { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable deviceId;
		[NullAllowed, Export ("deviceId", ArgumentSemantic.Strong)]
		string DeviceId { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable brand;
		[NullAllowed, Export ("brand", ArgumentSemantic.Strong)]
		string Brand { get; set; }
	}

	// @interface PPRetailSignatureReceiver : PPRetailObject
	[BaseType (typeof (PPRetailObject))]
	interface PPRetailSignatureReceiver {
		// @property (readonly, nonatomic, strong) PPRetailTransactionContext * _Nullable context;
		[NullAllowed, Export ("context", ArgumentSemantic.Strong)]
		PPRetailTransactionContext Context { get; }

		// -(void)continueWithSignature:(NSString * _Nullable)base64SignatureJpeg;
		[Export ("continueWithSignature:")]
		void ContinueWithSignature ([NullAllowed] string base64SignatureJpeg);

		// -(void)acquireSignature;
		[Export ("acquireSignature")]
		void AcquireSignature ();

		// -(void)cancel;
		[Export ("cancel")]
		void Cancel ();

		// -(PPRetailCancelledSignal _Nullable)addCancelledListener:(PPRetailCancelledEvent _Nullable)listener;
		[Export ("addCancelledListener:")]
		[return: NullAllowed]
		NSObject AddCancelledListener ([NullAllowed] PPRetailCancelledEvent listener);

		// -(void)removeCancelledListener:(PPRetailCancelledSignal _Nullable)listenerToken;
		[Export ("removeCancelledListener:")]
		void RemoveCancelledListener ([NullAllowed] NSObject listenerToken);
	}

	// @interface PPRetailSimulationManager : PPRetailObject
	[BaseType (typeof (PPRetailObject))]
	interface PPRetailSimulationManager {
		// -(void)enableFakeResponse;
		[Export ("enableFakeResponse")]
		void EnableFakeResponse ();

		// -(void)disableFakeResponse;
		[Export ("disableFakeResponse")]
		void DisableFakeResponse ();

		// -(void)simulateDevice:(PPRetailDeviceSimulatorType)devices usecase:(PPRetailSimulatorUseCase)usecase jsonResponseData:(NSString * _Nullable)jsonResponseData;
		[Export ("simulateDevice:usecase:jsonResponseData:")]
		void SimulateDevice (PPRetailDeviceSimulatorType devices, PPRetailSimulatorUseCase usecase, [NullAllowed] string jsonResponseData);
	}

	// @interface PPRetailSimulationOptions : PPRetailObject
	[BaseType (typeof (PPRetailObject))]
	interface PPRetailSimulationOptions {
		// @property (assign, nonatomic) BOOL enableDeviceSimulator;
		[Export ("enableDeviceSimulator")]
		bool EnableDeviceSimulator { get; set; }

		// @property (assign, nonatomic) BOOL enableServerSimulator;
		[Export ("enableServerSimulator")]
		bool EnableServerSimulator { get; set; }

		// @property (assign, nonatomic) BOOL enableMerchantSimulator;
		[Export ("enableMerchantSimulator")]
		bool EnableMerchantSimulator { get; set; }

		// @property (assign, nonatomic) PPRetailDeviceSimulatorType deviceSimulatorType;
		[Export ("deviceSimulatorType", ArgumentSemantic.Assign)]
		PPRetailDeviceSimulatorType DeviceSimulatorType { get; set; }

		// @property (assign, nonatomic) PPRetailSimulatorUseCase simulatorUseCase;
		[Export ("simulatorUseCase", ArgumentSemantic.Assign)]
		PPRetailSimulatorUseCase SimulatorUseCase { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable userResponseData;
		[NullAllowed, Export ("userResponseData", ArgumentSemantic.Strong)]
		string UserResponseData { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable tag;
		[NullAllowed, Export ("tag", ArgumentSemantic.Strong)]
		string Tag { get; set; }
	}

	// @interface PPRetailTokenExpirationHandler : PPRetailObject
	[BaseType (typeof (PPRetailObject))]
	interface PPRetailTokenExpirationHandler {
		// -(void)quit;
		[Export ("quit")]
		void Quit ();

		// -(void)continueWithNewToken:(NSString * _Nullable)accessToken;
		[Export ("continueWithNewToken:")]
		void ContinueWithNewToken ([NullAllowed] string accessToken);
	}

	// @interface PPRetailTransactionBeginOptions : PPRetailObject
	[BaseType (typeof (PPRetailObject))]
	interface PPRetailTransactionBeginOptions {
		// @property (assign, nonatomic) BOOL showPromptInCardReader;
		[Export ("showPromptInCardReader")]
		bool ShowPromptInCardReader { get; set; }

		// @property (assign, nonatomic) BOOL showPromptInApp;
		[Export ("showPromptInApp")]
		bool ShowPromptInApp { get; set; }

		// @property (nonatomic, strong) NSArray * _Nullable preferredFormFactors;
		[NullAllowed, Export ("preferredFormFactors", ArgumentSemantic.Strong)]
		//[Verify (StronglyTypedNSArray)]
		NSObject [] PreferredFormFactors { get; set; }

		// @property (assign, nonatomic) BOOL tippingOnReaderEnabled;
		[Export ("tippingOnReaderEnabled")]
		bool TippingOnReaderEnabled { get; set; }

		// @property (assign, nonatomic) BOOL quickChipEnabled;
		[Export ("quickChipEnabled")]
		bool QuickChipEnabled { get; set; }

		// @property (assign, nonatomic) PPRetailTransactionBeginOptionsPaymentTypes paymentType;
		[Export ("paymentType", ArgumentSemantic.Assign)]
		PPRetailTransactionBeginOptionsPaymentTypes PaymentType { get; set; }

		// @property (nonatomic, strong) PPRetailCard * _Nullable manualCard;
		[NullAllowed, Export ("manualCard", ArgumentSemantic.Strong)]
		PPRetailCard ManualCard { get; set; }

		// @property (nonatomic, strong) PPRetailDigitalCard * _Nullable digitalCard;
		[NullAllowed, Export ("digitalCard", ArgumentSemantic.Strong)]
		PPRetailDigitalCard DigitalCard { get; set; }

		// @property (assign, nonatomic) BOOL amountBasedTipping;
		[Export ("amountBasedTipping")]
		bool AmountBasedTipping { get; set; }

		// @property (assign, nonatomic) BOOL isAuthCapture;
		[Export ("isAuthCapture")]
		bool IsAuthCapture { get; set; }

		// @property (assign, nonatomic) PPRetailTransactionBeginOptionsVaultProvider vaultProvider;
		[Export ("vaultProvider", ArgumentSemantic.Assign)]
		PPRetailTransactionBeginOptionsVaultProvider VaultProvider { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable paypalOrderId;
		[NullAllowed, Export ("paypalOrderId", ArgumentSemantic.Strong)]
		string PaypalOrderId { get; set; }

		// @property (assign, nonatomic) PPRetailTransactionBeginOptionsVaultType vaultType;
		[Export ("vaultType", ArgumentSemantic.Assign)]
		PPRetailTransactionBeginOptionsVaultType VaultType { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable vaultCustomerId;
		[NullAllowed, Export ("vaultCustomerId", ArgumentSemantic.Strong)]
		string VaultCustomerId { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable tag;
		[NullAllowed, Export ("tag", ArgumentSemantic.Strong)]
		string Tag { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable qrcProvider;
		[NullAllowed, Export ("qrcProvider", ArgumentSemantic.Strong)]
		string QrcProvider { get; set; }

		// @property (assign, nonatomic) BOOL qrcPromptEnabled;
		[Export ("qrcPromptEnabled")]
		bool QrcPromptEnabled { get; set; }

		// @property (assign, nonatomic) BOOL signatureOnCardReader;
		[Export ("signatureOnCardReader")]
		bool SignatureOnCardReader { get; set; }

		// -(NSString * _Nullable)getAllTags;
		[NullAllowed, Export ("getAllTags")]
		//[Verify (MethodToProperty)]
		string AllTags { get; }

		// -(void)addTag:(NSString * _Nullable)newTag;
		[Export ("addTag:")]
		void AddTag ([NullAllowed] string newTag);

		// -(void)removeTag:(NSString * _Nullable)removeTag;
		[Export ("removeTag:")]
		void RemoveTag ([NullAllowed] string removeTag);
	}

	// @interface PPRetailTransactionContext : PPRetailObject
	[BaseType (typeof (PPRetailObject))]
	[DisableDefaultCtor]
	interface PPRetailTransactionContext {
		// @property (readonly, nonatomic, strong) PPRetailRetailInvoice * _Nullable invoice;
		[NullAllowed, Export ("invoice", ArgumentSemantic.Strong)]
		PPRetailRetailInvoice Invoice { get; }

		// @property (assign, nonatomic) PPRetailTransactionType type;
		[Export ("type", ArgumentSemantic.Assign)]
		PPRetailTransactionType Type { get; set; }

		// @property (readonly, assign, nonatomic) BOOL isSignatureRequired;
		[Export ("isSignatureRequired")]
		bool IsSignatureRequired { get; }

		// @property (nonatomic, strong) PPRetailDigitalCard * _Nullable digitalCard;
		[NullAllowed, Export ("digitalCard", ArgumentSemantic.Strong)]
		PPRetailDigitalCard DigitalCard { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable totalDisplayFooter;
		[NullAllowed, Export ("totalDisplayFooter", ArgumentSemantic.Strong)]
		string TotalDisplayFooter { get; set; }

		// -(instancetype _Nullable)initWithInvoice:(PPRetailRetailInvoice * _Nullable)invoice merchant:(PPRetailMerchant * _Nullable)merchant offlinePaymentEnabled:(BOOL)offlinePaymentEnabled;
		[Export ("initWithInvoice:merchant:offlinePaymentEnabled:")]
		IntPtr Constructor ([NullAllowed] PPRetailRetailInvoice invoice, [NullAllowed] PPRetailMerchant merchant, bool offlinePaymentEnabled);

		// -(PPRetailPaymentState)getPaymentState;
		[Export ("getPaymentState")]
		//[Verify (MethodToProperty)]
		PPRetailPaymentState PaymentState { get; }

		// -(PPRetailTippingState)getTippingState;
		[Export ("getTippingState")]
		//[Verify (MethodToProperty)]
		PPRetailTippingState TippingState { get; }

		// -(void)clearOnReaderTip;
		[Export ("clearOnReaderTip")]
		void ClearOnReaderTip ();

		// -(PPRetailTransactionContext * _Nullable)beginPayment:(PPRetailTransactionBeginOptions * _Nullable)paymentOptions;
		[Export ("beginPayment:")]
		[return: NullAllowed]
		PPRetailTransactionContext BeginPayment ([NullAllowed] PPRetailTransactionBeginOptions paymentOptions);

		// -(PPRetailTransactionContext * _Nullable)beginRefund:(BOOL)promptForCardOptions amount:(NSDecimalNumber * _Nullable)amount;
		[Export ("beginRefund:amount:")]
		[return: NullAllowed]
		PPRetailTransactionContext BeginRefund (bool promptForCardOptions, [NullAllowed] NSDecimalNumber amount);

		// -(PPRetailTransactionContext * _Nullable)beginRefund:(BOOL)promptForCardOptions amount:(NSDecimalNumber * _Nullable)amount refundTag:(NSString * _Nullable)refundTag;
		[Export ("beginRefund:amount:refundTag:")]
		[return: NullAllowed]
		PPRetailTransactionContext BeginRefund (bool promptForCardOptions, [NullAllowed] NSDecimalNumber amount, [NullAllowed] string refundTag);

		// -(BOOL)isRefund;
		[Export ("isRefund")]
		//[Verify (MethodToProperty)]
		bool IsRefund { get; }

		// -(void)deactivateFormFactors:(NSArray * _Nullable)formFactors callback:(PPRetailTransactionContextCompleteHandler _Nullable)callback;
		[Export ("deactivateFormFactors:callback:")]
		//[Verify (StronglyTypedNSArray)]
		void DeactivateFormFactors ([NullAllowed] NSObject [] formFactors, [NullAllowed] PPRetailTransactionContextCompleteHandler callback);

		// -(void)clear:(PPRetailTransactionContextCompleteHandler _Nullable)callback;
		[Export ("clear:")]
		void Clear ([NullAllowed] PPRetailTransactionContextCompleteHandler callback);

		// -(BOOL)isPaymentInRetryOrProgress;
		[Export ("isPaymentInRetryOrProgress")]
		//[Verify (MethodToProperty)]
		bool IsPaymentInRetryOrProgress { get; }

		// -(void)requestPaymentCancellation:(PPRetailTransactionContextCancellationHandlerHandler _Nullable)handler;
		[Export ("requestPaymentCancellation:")]
		void RequestPaymentCancellation ([NullAllowed] PPRetailTransactionContextCancellationHandlerHandler handler);

		// -(void)requestDigitalCardCancellation:(PPRetailTransactionContextVoidCompletedHandler _Nullable)voidCompletedHandler;
		[Export ("requestDigitalCardCancellation:")]
		void RequestDigitalCardCancellation ([NullAllowed] PPRetailTransactionContextVoidCompletedHandler voidCompletedHandler);

		// -(void)dropHandlers;
		[Export ("dropHandlers")]
		void DropHandlers ();

		// -(void)discardPresentedCard:(PPRetailCard * _Nullable)card;
		[Export ("discardPresentedCard:")]
		void DiscardPresentedCard ([NullAllowed] PPRetailCard card);

		// -(void)continueWithCard:(PPRetailCard * _Nullable)card tag:(NSString * _Nullable)tag;
		[Export ("continueWithCard:tag:")]
		void ContinueWithCard ([NullAllowed] PPRetailCard card, [NullAllowed] string tag);

		// -(void)continueWithDigitalCard:(PPRetailDigitalCard * _Nullable)digitalCard;
		[Export ("continueWithDigitalCard:")]
		void ContinueWithDigitalCard ([NullAllowed] PPRetailDigitalCard digitalCard);

		// -(void)continueWithCard:(PPRetailCard * _Nullable)card;
		[Export ("continueWithCard:")]
		void ContinueWithCard ([NullAllowed] PPRetailCard card);

		// -(void)startInvoiceSync;
		[Export ("startInvoiceSync")]
		void StartInvoiceSync ();

		// -(void)syncInvoiceOnce;
		[Export ("syncInvoiceOnce")]
		void SyncInvoiceOnce ();

		// -(void)continueWithCash;
		[Export ("continueWithCash")]
		void ContinueWithCash ();

		// -(void)continueWithQRC;
		[Export ("continueWithQRC")]
		void ContinueWithQRC ();

		// -(void)continueWithCheck;
		[Export ("continueWithCheck")]
		void ContinueWithCheck ();

		// -(void)setSignatureCollector:(PPRetailTransactionContextSignatureCollectorHandler _Nullable)collector;
		[Export ("setSignatureCollector:")]
		void SetSignatureCollector ([NullAllowed] PPRetailTransactionContextSignatureCollectorHandler collector);

		// -(void)setTokenExpiredHandler:(PPRetailTransactionContextTokenExpirationHandlerHandler _Nullable)expirationHandler;
		[Export ("setTokenExpiredHandler:")]
		void SetTokenExpiredHandler ([NullAllowed] PPRetailTransactionContextTokenExpirationHandlerHandler expirationHandler);

		// -(void)setCardInsertedHandler:(PPRetailTransactionContextCardInsertedHandlerHandler _Nullable)cardInsertedHandler;
		[Export ("setCardInsertedHandler:")]
		void SetCardInsertedHandler ([NullAllowed] PPRetailTransactionContextCardInsertedHandlerHandler cardInsertedHandler);

		// -(void)setCaptureHandler:(PPRetailTransactionContextOnAuthCompleteHandler _Nullable)captureHandler;
		[Export ("setCaptureHandler:")]
		void SetCaptureHandler ([NullAllowed] PPRetailTransactionContextOnAuthCompleteHandler captureHandler);

		// -(void)setCardPresentedHandler:(PPRetailTransactionContextCardPresentedHandler _Nullable)cardPresentedHandler;
		[Export ("setCardPresentedHandler:")]
		void SetCardPresentedHandler ([NullAllowed] PPRetailTransactionContextCardPresentedHandler cardPresentedHandler);

		// -(void)setQRCStatusHandler:(PPRetailTransactionContextOnQRCStatusHandler _Nullable)qrcStatusHandler;
		[Export ("setQRCStatusHandler:")]
		void SetQRCStatusHandler ([NullAllowed] PPRetailTransactionContextOnQRCStatusHandler qrcStatusHandler);

		// -(void)setCompletedHandler:(PPRetailTransactionContextTransactionCompletedHandler _Nullable)completedHandler;
		[Export ("setCompletedHandler:")]
		void SetCompletedHandler ([NullAllowed] PPRetailTransactionContextTransactionCompletedHandler completedHandler);

		// -(void)setVaultCompletedHandler:(PPRetailTransactionContextVaultCompletedHandler _Nullable)completedHandler;
		[Export ("setVaultCompletedHandler:")]
		void SetVaultCompletedHandler ([NullAllowed] PPRetailTransactionContextVaultCompletedHandler completedHandler);

		// -(void)setOfflineTransactionAdditionHandler:(PPRetailTransactionContextOfflineTransactionAddedHandler _Nullable)addedHandler;
		[Export ("setOfflineTransactionAdditionHandler:")]
		void SetOfflineTransactionAdditionHandler ([NullAllowed] PPRetailTransactionContextOfflineTransactionAddedHandler addedHandler);

		// -(void)setAdditionalReceiptOptions:(NSArray * _Nullable)additionalReceiptOptions receiptHandler:(PPRetailTransactionContextReceiptOptionHandlerHandler _Nullable)receiptHandler;
		[Export ("setAdditionalReceiptOptions:receiptHandler:")]
		//[Verify (StronglyTypedNSArray)]
		void SetAdditionalReceiptOptions ([NullAllowed] NSObject [] additionalReceiptOptions, [NullAllowed] PPRetailTransactionContextReceiptOptionHandlerHandler receiptHandler);

		// -(PPRetailContactlessReaderDeactivatedSignal _Nullable)addContactlessReaderDeactivatedListener:(PPRetailContactlessReaderDeactivatedEvent _Nullable)listener;
		[Export ("addContactlessReaderDeactivatedListener:")]
		[return: NullAllowed]
		NSObject AddContactlessReaderDeactivatedListener ([NullAllowed] PPRetailContactlessReaderDeactivatedEvent listener);

		// -(void)removeContactlessReaderDeactivatedListener:(PPRetailContactlessReaderDeactivatedSignal _Nullable)listenerToken;
		[Export ("removeContactlessReaderDeactivatedListener:")]
		void RemoveContactlessReaderDeactivatedListener ([NullAllowed] NSObject listenerToken);

		// -(PPRetailContactlessReaderActivatedSignal _Nullable)addContactlessReaderActivatedListener:(PPRetailContactlessReaderActivatedEvent _Nullable)listener;
		[Export ("addContactlessReaderActivatedListener:")]
		[return: NullAllowed]
		NSObject AddContactlessReaderActivatedListener ([NullAllowed] PPRetailContactlessReaderActivatedEvent listener);

		// -(void)removeContactlessReaderActivatedListener:(PPRetailContactlessReaderActivatedSignal _Nullable)listenerToken;
		[Export ("removeContactlessReaderActivatedListener:")]
		void RemoveContactlessReaderActivatedListener ([NullAllowed] NSObject listenerToken);

		// -(PPRetailPinEntrySignal _Nullable)addPinEntryListener:(PPRetailPinEntryEvent _Nullable)listener;
		[Export ("addPinEntryListener:")]
		[return: NullAllowed]
		NSObject AddPinEntryListener ([NullAllowed] PPRetailPinEntryEvent listener);

		// -(void)removePinEntryListener:(PPRetailPinEntrySignal _Nullable)listenerToken;
		[Export ("removePinEntryListener:")]
		void RemovePinEntryListener ([NullAllowed] NSObject listenerToken);

		// -(PPRetailWillPresentSignatureSignal _Nullable)addWillPresentSignatureListener:(PPRetailWillPresentSignatureEvent _Nullable)listener;
		[Export ("addWillPresentSignatureListener:")]
		[return: NullAllowed]
		NSObject AddWillPresentSignatureListener ([NullAllowed] PPRetailWillPresentSignatureEvent listener);

		// -(void)removeWillPresentSignatureListener:(PPRetailWillPresentSignatureSignal _Nullable)listenerToken;
		[Export ("removeWillPresentSignatureListener:")]
		void RemoveWillPresentSignatureListener ([NullAllowed] NSObject listenerToken);

		// -(PPRetailReaderTippingCompletedSignal _Nullable)addReaderTippingCompletedListener:(PPRetailReaderTippingCompletedEvent _Nullable)listener;
		[Export ("addReaderTippingCompletedListener:")]
		[return: NullAllowed]
		NSObject AddReaderTippingCompletedListener ([NullAllowed] PPRetailReaderTippingCompletedEvent listener);

		// -(void)removeReaderTippingCompletedListener:(PPRetailReaderTippingCompletedSignal _Nullable)listenerToken;
		[Export ("removeReaderTippingCompletedListener:")]
		void RemoveReaderTippingCompletedListener ([NullAllowed] NSObject listenerToken);

		// -(PPRetailDidCompleteSignatureSignal _Nullable)addDidCompleteSignatureListener:(PPRetailDidCompleteSignatureEvent _Nullable)listener;
		[Export ("addDidCompleteSignatureListener:")]
		[return: NullAllowed]
		NSObject AddDidCompleteSignatureListener ([NullAllowed] PPRetailDidCompleteSignatureEvent listener);

		// -(void)removeDidCompleteSignatureListener:(PPRetailDidCompleteSignatureSignal _Nullable)listenerToken;
		[Export ("removeDidCompleteSignatureListener:")]
		void RemoveDidCompleteSignatureListener ([NullAllowed] NSObject listenerToken);
	}

	// @interface PPRetailTransactionManager : PPRetailObject
	[BaseType (typeof (PPRetailObject))]
	interface PPRetailTransactionManager {
		// -(void)createTransaction:(PPRetailRetailInvoice * _Nullable)invoice callback:(PPRetailTransactionManagerTransactionHandler _Nullable)callback;
		[Export ("createTransaction:callback:")]
		void CreateTransaction ([NullAllowed] PPRetailRetailInvoice invoice, [NullAllowed] PPRetailTransactionManagerTransactionHandler callback);

		// -(void)createVaultTransaction:(PPRetailTransactionManagerTransactionHandler _Nullable)callback;
		[Export ("createVaultTransaction:")]
		void CreateVaultTransaction ([NullAllowed] PPRetailTransactionManagerTransactionHandler callback);

		// -(void)createRefundTransaction:(NSString * _Nullable)invoiceId transactionNumber:(NSString * _Nullable)transactionNumber paymentMethod:(PPRetailInvoicePaymentMethod)paymentMethod callback:(PPRetailTransactionManagerTransactionHandler _Nullable)callback;
		[Export ("createRefundTransaction:transactionNumber:paymentMethod:callback:")]
		void CreateRefundTransaction ([NullAllowed] string invoiceId, [NullAllowed] string transactionNumber, PPRetailInvoicePaymentMethod paymentMethod, [NullAllowed] PPRetailTransactionManagerTransactionHandler callback);

		// -(void)createCashOrCheckRefundTransaction:(NSString * _Nullable)invoiceId callback:(PPRetailTransactionManagerTransactionHandler _Nullable)callback;
		[Export ("createCashOrCheckRefundTransaction:callback:")]
		void CreateCashOrCheckRefundTransaction ([NullAllowed] string invoiceId, [NullAllowed] PPRetailTransactionManagerTransactionHandler callback);

		// -(void)createCardRefundTransaction:(NSString * _Nullable)invoiceId callback:(PPRetailTransactionManagerTransactionHandler _Nullable)callback;
		[Export ("createCardRefundTransaction:callback:")]
		void CreateCardRefundTransaction ([NullAllowed] string invoiceId, [NullAllowed] PPRetailTransactionManagerTransactionHandler callback);

		// -(void)startOfflinePayment:(PPRetailTransactionManagerOfflinePaymentStatusHandler _Nullable)callback;
		[Export ("startOfflinePayment:")]
		void StartOfflinePayment ([NullAllowed] PPRetailTransactionManagerOfflinePaymentStatusHandler callback);

		// -(BOOL)getOfflinePaymentEligibility;
		[Export ("getOfflinePaymentEligibility")]
		//[Verify (MethodToProperty)]
		bool OfflinePaymentEligibility { get; }

		// -(BOOL)getQRCEligibility;
		[Export ("getQRCEligibility")]
		//[Verify (MethodToProperty)]
		bool QRCEligibility { get; }

		// -(void)stopOfflinePayment:(PPRetailTransactionManagerOfflinePaymentStatusHandler _Nullable)callback;
		[Export ("stopOfflinePayment:")]
		void StopOfflinePayment ([NullAllowed] PPRetailTransactionManagerOfflinePaymentStatusHandler callback);

		// -(void)startReplayOfflineTxns:(PPRetailTransactionManagerOfflinePaymentStatusHandler _Nullable)callback;
		[Export ("startReplayOfflineTxns:")]
		void StartReplayOfflineTxns ([NullAllowed] PPRetailTransactionManagerOfflinePaymentStatusHandler callback);

		// -(void)stopReplayOfflineTxns:(PPRetailTransactionManagerOfflinePaymentStatusHandler _Nullable)callback;
		[Export ("stopReplayOfflineTxns:")]
		void StopReplayOfflineTxns ([NullAllowed] PPRetailTransactionManagerOfflinePaymentStatusHandler callback);

		// -(void)getOfflinePaymentStatus:(PPRetailTransactionManagerOfflinePaymentStatusHandler _Nullable)callback;
		[Export ("getOfflinePaymentStatus:")]
		void GetOfflinePaymentStatus ([NullAllowed] PPRetailTransactionManagerOfflinePaymentStatusHandler callback);

		// -(BOOL)getOfflinePaymentEnabled;
		[Export ("getOfflinePaymentEnabled")]
		//[Verify (MethodToProperty)]
		bool OfflinePaymentEnabled { get; }

		// -(NSArray * _Nullable)getSupportedQRCProviders;
		[NullAllowed, Export ("getSupportedQRCProviders")]
		//[Verify (MethodToProperty), Verify (StronglyTypedNSArray)]
		NSObject [] SupportedQRCProviders { get; }

		// -(PPRetailTransactionContext * _Nullable)getCurrentTransactionContext;
		[NullAllowed, Export ("getCurrentTransactionContext")]
		//[Verify (MethodToProperty)]
		PPRetailTransactionContext CurrentTransactionContext { get; }

		// -(void)retrieveAuthorization:(NSDate * _Nullable)startDateTime endDateTime:(NSDate * _Nullable)endDateTime pageSize:(int)pageSize status:(NSArray * _Nullable)status callback:(PPRetailTransactionManagerRetrieveAuthorizedTransactionsHandler _Nullable)callback;
		[Export ("retrieveAuthorization:endDateTime:pageSize:status:callback:")]
		//[Verify (StronglyTypedNSArray)]
		void RetrieveAuthorization ([NullAllowed] NSDate startDateTime, [NullAllowed] NSDate endDateTime, int pageSize, [NullAllowed] NSObject [] status, [NullAllowed] PPRetailTransactionManagerRetrieveAuthorizedTransactionsHandler callback);

		// -(void)retrieveAuthorizationUsingToken:(NSString * _Nullable)nextPageToken callback:(PPRetailTransactionManagerRetrieveAuthorizedTransactionsHandler _Nullable)callback;
		[Export ("retrieveAuthorizationUsingToken:callback:")]
		void RetrieveAuthorizationUsingToken ([NullAllowed] string nextPageToken, [NullAllowed] PPRetailTransactionManagerRetrieveAuthorizedTransactionsHandler callback);

		// -(void)voidAuthorization:(NSString * _Nullable)authorizationId callback:(PPRetailTransactionManagerVoidAuthorizationHandler _Nullable)callback;
		[Export ("voidAuthorization:callback:")]
		void VoidAuthorization ([NullAllowed] string authorizationId, [NullAllowed] PPRetailTransactionManagerVoidAuthorizationHandler callback);

		// -(void)captureAuthorization:(NSString * _Nullable)authorizationId invoiceId:(NSString * _Nullable)invoiceId totalAmount:(NSDecimalNumber * _Nullable)totalAmount gratuityAmount:(NSDecimalNumber * _Nullable)gratuityAmount currency:(NSString * _Nullable)currency callback:(PPRetailTransactionManagerCaptureAuthorizedTransactionHandler _Nullable)callback;
		[Export ("captureAuthorization:invoiceId:totalAmount:gratuityAmount:currency:callback:")]
		void CaptureAuthorization ([NullAllowed] string authorizationId, [NullAllowed] string invoiceId, [NullAllowed] NSDecimalNumber totalAmount, [NullAllowed] NSDecimalNumber gratuityAmount, [NullAllowed] string currency, [NullAllowed] PPRetailTransactionManagerCaptureAuthorizedTransactionHandler callback);

		// -(void)captureAuthorization:(NSString * _Nullable)authorizationId invoiceId:(NSString * _Nullable)invoiceId totalAmount:(NSDecimalNumber * _Nullable)totalAmount gratuityAmount:(NSDecimalNumber * _Nullable)gratuityAmount currency:(NSString * _Nullable)currency base64SignatureJpeg:(NSString * _Nullable)base64SignatureJpeg callback:(PPRetailTransactionManagerCaptureAuthorizedTransactionHandler _Nullable)callback;
		[Export ("captureAuthorization:invoiceId:totalAmount:gratuityAmount:currency:base64SignatureJpeg:callback:")]
		void CaptureAuthorization ([NullAllowed] string authorizationId, [NullAllowed] string invoiceId, [NullAllowed] NSDecimalNumber totalAmount, [NullAllowed] NSDecimalNumber gratuityAmount, [NullAllowed] string currency, [NullAllowed] string base64SignatureJpeg, [NullAllowed] PPRetailTransactionManagerCaptureAuthorizedTransactionHandler callback);
	}

	// @interface PPRetailTransactionRecord : PPRetailRecord
	[BaseType (typeof (PPRetailRecord))]
	interface PPRetailTransactionRecord {
		// @property (readonly, nonatomic, strong) NSString * _Nullable transactionNumber;
		[NullAllowed, Export ("transactionNumber", ArgumentSemantic.Strong)]
		string TransactionNumber { get; }

		// @property (readonly, nonatomic, strong) NSString * _Nullable invoiceId;
		[NullAllowed, Export ("invoiceId", ArgumentSemantic.Strong)]
		string InvoiceId { get; }

		// @property (assign, nonatomic) PPRetailInvoicePaymentMethod paymentMethod;
		[Export ("paymentMethod", ArgumentSemantic.Assign)]
		PPRetailInvoicePaymentMethod PaymentMethod { get; set; }

		// @property (readonly, nonatomic, strong) NSString * _Nullable authCode;
		[NullAllowed, Export ("authCode", ArgumentSemantic.Strong)]
		string AuthCode { get; }

		// @property (readonly, nonatomic, strong) NSString * _Nullable paymentAction;
		[NullAllowed, Export ("paymentAction", ArgumentSemantic.Strong)]
		string PaymentAction { get; }

		// @property (readonly, nonatomic, strong) NSString * _Nullable transactionHandle;
		[NullAllowed, Export ("transactionHandle", ArgumentSemantic.Strong)]
		string TransactionHandle { get; }

		// @property (readonly, nonatomic, strong) NSString * _Nullable responseCode;
		[NullAllowed, Export ("responseCode", ArgumentSemantic.Strong)]
		string ResponseCode { get; }

		// @property (readonly, nonatomic, strong) PPRetailDigitalCardInfo * _Nullable digitalCardInfo;
		[NullAllowed, Export ("digitalCardInfo", ArgumentSemantic.Strong)]
		PPRetailDigitalCardInfo DigitalCardInfo { get; }

		// @property (readonly, nonatomic, strong) PPRetailPayer * _Nullable payer;
		[NullAllowed, Export ("payer", ArgumentSemantic.Strong)]
		PPRetailPayer Payer { get; }

		// @property (readonly, nonatomic, strong) NSString * _Nullable correlationId;
		[NullAllowed, Export ("correlationId", ArgumentSemantic.Strong)]
		string CorrelationId { get; }

		// @property (readonly, nonatomic, strong) PPRetailReceiptDestination * _Nullable receiptDestination;
		[NullAllowed, Export ("receiptDestination", ArgumentSemantic.Strong)]
		PPRetailReceiptDestination ReceiptDestination { get; }

		// @property (readonly, nonatomic, strong) NSString * _Nullable captureId;
		[NullAllowed, Export ("captureId", ArgumentSemantic.Strong)]
		string CaptureId { get; }
	}

	// @interface PPRetailVaultRecord : PPRetailRecord
	[BaseType (typeof (PPRetailRecord))]
	interface PPRetailVaultRecord {
		// @property (readonly, nonatomic, strong) NSString * _Nullable vaultId;
		[NullAllowed, Export ("vaultId", ArgumentSemantic.Strong)]
		string VaultId { get; }
	}

	//[Static]
	//[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants {
		// extern double PayPalRetailSDKVersionNumber;
		[Field ("PayPalRetailSDKVersionNumber", "__Internal")]
		double PayPalRetailSDKVersionNumber { get; }

		// extern const unsigned char [] PayPalRetailSDKVersionString;
		[Field ("PayPalRetailSDKVersionString", "__Internal")]
		NSString PayPalRetailSDKVersionString { get; }
	}

	// typedef void (^PPRetailMerchantHandler)(PPRetailError *, PPRetailMerchant *);
	delegate void PPRetailMerchantHandler (PPRetailError arg0, PPRetailMerchant arg1);

	//[Static]
	//[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants {
		// extern NSString *const kAudioReaderPluggedIn;
		[Field ("kAudioReaderPluggedIn", "__Internal")]
		NSString kAudioReaderPluggedIn { get; }

		// extern NSString *const kAudioReaderPluggedOut;
		[Field ("kAudioReaderPluggedOut", "__Internal")]
		NSString kAudioReaderPluggedOut { get; }

		// extern NSString *const kAudioReaderSwipeDidFail;
		[Field ("kAudioReaderSwipeDidFail", "__Internal")]
		NSString kAudioReaderSwipeDidFail { get; }

		// extern NSString *const kAudioReaderSwipeDetected;
		[Field ("kAudioReaderSwipeDetected", "__Internal")]
		NSString kAudioReaderSwipeDetected { get; }

		// extern NSString *const kReceiptOptionsFinishedLoading;
		[Field ("kReceiptOptionsFinishedLoading", "__Internal")]
		NSString kReceiptOptionsFinishedLoading { get; }
	}

	// typedef void (^PPRetailDeviceDiscoveredEvent)(PPRetailPaymentDevice *);
	//delegate void PPRetailDeviceDiscoveredEvent (PPRetailPaymentDevice arg0);

	//// typedef void (^PPRetailUntrustedNetworkEvent)(PPRetailError *);
	//delegate void PPRetailUntrustedNetworkEvent (PPRetailError arg0);

	//// typedef void (^PPRetailMerchantHandler)(PPRetailError *, PPRetailMerchant *);
	//delegate void PPRetailMerchantHandler (PPRetailError arg0, PPRetailMerchant arg1);

	// @protocol PPHRetailSDKAppDelegate <NSObject>
	[Protocol, Model]
	[BaseType (typeof (NSObject))]
	interface PPHRetailSDKAppDelegate {
		// @required -(UINavigationController *)getCurrentNavigationController;
		[Abstract]
		[Export ("getCurrentNavigationController")]
		//[Verify (MethodToProperty)]
		UINavigationController CurrentNavigationController { get; }

		// @optional -(void)readerConnectionViewDismissed;
		[Export ("readerConnectionViewDismissed")]
		void ReaderConnectionViewDismissed ();

		// @optional -(void)lastActiveReaderConnected;
		[Export ("lastActiveReaderConnected")]
		void LastActiveReaderConnected ();
	}

	// @interface PayPalRetailSDK : NSObject
	[BaseType (typeof (NSObject))]
	interface PayPalRetailSDK {
		// +(UINavigationController *)getCurrentNavigationController;
		[Static]
		[Export ("getCurrentNavigationController")]
		//[Verify (MethodToProperty)]
		UINavigationController CurrentNavigationController { get; }

		// +(void)setRetailSDKAppDelegate:(id<PPHRetailSDKAppDelegate>)delegate;
		[Static]
		[Export ("setRetailSDKAppDelegate:")]
		void SetRetailSDKAppDelegate (PPHRetailSDKAppDelegate @delegate);

		// +(void)addLoggingService:(id)logingService;
		[Static]
		[Export ("addLoggingService:")]
		void AddLoggingService (NSObject logingService);

		// +(PPRetailError *)initializeSDK;
		[Static]
		[Export ("initializeSDK")]
		//[Verify (MethodToProperty)]
		PPRetailError InitializeSDK ();

		// +(BOOL)checkIfSwiperIsEligibleForMerchant;
		[Static]
		[Export ("checkIfSwiperIsEligibleForMerchant")]
		//[Verify (MethodToProperty)]
		bool CheckIfSwiperIsEligibleForMerchant { get; }

		// +(void)shutdownSDK;
		[Static]
		[Export ("shutdownSDK")]
		void ShutdownSDK ();

		// +(PPRetailError *)initializeMerchant:(NSString *)merchantToken repository:(NSString *)repository completionHandler:(PPRetailMerchantHandler)handler;
		[Static]
		[Export ("initializeMerchant:repository:completionHandler:")]
		PPRetailError InitializeMerchant (string merchantToken, string repository, PPRetailMerchantHandler handler);

		// +(PPRetailError *)initializeFakeMerchant:(PPRetailMerchantHandler)handler;
		[Static]
		[Export ("initializeFakeMerchant:")]
		PPRetailError InitializeFakeMerchant (PPRetailMerchantHandler handler);

		// +(PPRetailError *)initializeMerchantOffline:(PPRetailMerchantHandler)handler;
		[Static]
		[Export ("initializeMerchantOffline:")]
		PPRetailError InitializeMerchantOffline (PPRetailMerchantHandler handler);

		// +(void)initializeMerchantWithCredentials:(SdkCredential *)credentials completionHandler:(PPRetailMerchantHandler)handler;
		[Static]
		[Export ("initializeMerchantWithCredentials:completionHandler:")]
		void InitializeMerchantWithCredentials (SdkCredential credentials, PPRetailMerchantHandler handler);

		// +(PPRetailTransactionContext *)createTransaction:(PPRetailInvoice *)invoice __attribute__((deprecated("Deprecated since v2.0.0. Use transactionManager")));
		[Static]
		[Export ("createTransaction:")]
		PPRetailTransactionContext CreateTransaction (PPRetailInvoice invoice);

		// +(PPRetailDeviceDiscoveredSignal)addDeviceDiscoveredListener:(PPRetailDeviceDiscoveredEvent)listener;
		[Static]
		[Export ("addDeviceDiscoveredListener:")]
		NSObject AddDeviceDiscoveredListener (PPRetailDeviceDiscoveredEvent listener);

		// +(void)removeDeviceDiscoveredListener:(PPRetailDeviceDiscoveredSignal)listenerToken;
		[Static]
		[Export ("removeDeviceDiscoveredListener:")]
		void RemoveDeviceDiscoveredListener (NSObject listenerToken);

		// +(PPRetailUntrustedNetworkSignal)addUntrustedNetworkListener:(PPRetailUntrustedNetworkEvent)listener;
		[Static]
		[Export ("addUntrustedNetworkListener:")]
		NSObject AddUntrustedNetworkListener (PPRetailUntrustedNetworkEvent listener);

		// +(void)removeUntrustedNetworkListener:(PPRetailUntrustedNetworkSignal)listenerToken;
		[Static]
		[Export ("removeUntrustedNetworkListener:")]
		void RemoveUntrustedNetworkListener (NSObject listenerToken);

		// +(void)captureAuthorizedTransaction:(NSString * _Nullable)authorizationId invoiceId:(NSString * _Nullable)invoiceId totalAmount:(NSDecimalNumber * _Nullable)totalAmount gratuityAmount:(NSDecimalNumber * _Nullable)gratuityAmount currency:(NSString * _Nullable)currency callback:(PPRetailTransactionManagerCaptureAuthorizedTransactionHandler _Nullable)callback;
		[Static]
		[Export ("captureAuthorizedTransaction:invoiceId:totalAmount:gratuityAmount:currency:callback:")]
		void CaptureAuthorizedTransaction ([NullAllowed] string authorizationId, [NullAllowed] string invoiceId, [NullAllowed] NSDecimalNumber totalAmount, [NullAllowed] NSDecimalNumber gratuityAmount, [NullAllowed] string currency, [NullAllowed] PPRetailTransactionManagerCaptureAuthorizedTransactionHandler callback);

		// +(void)retrieveAuthorizedTransactions:(NSDate * _Nullable)startDateTime endDateTime:(NSDate * _Nullable)endDateTime pageSize:(int)pageSize status:(NSArray * _Nullable)status callback:(PPRetailTransactionManagerRetrieveAuthorizedTransactionsHandler _Nullable)callback;
		[Static]
		[Export ("retrieveAuthorizedTransactions:endDateTime:pageSize:status:callback:")]
		//[Verify (StronglyTypedNSArray)]
		void RetrieveAuthorizedTransactions ([NullAllowed] NSDate startDateTime, [NullAllowed] NSDate endDateTime, int pageSize, [NullAllowed] NSObject [] status, [NullAllowed] PPRetailTransactionManagerRetrieveAuthorizedTransactionsHandler callback);

		// +(void)initializePPHRetailMerchant:(PPHRetailMerchant *)merchant deviceId:(NSUUID *)deviceId completionHandler:(PPRetailMerchantHandler)handler;
		[Static]
		[Export ("initializePPHRetailMerchant:deviceId:completionHandler:")]
		void InitializePPHRetailMerchant (PPHRetailMerchant merchant, NSUuid deviceId, PPRetailMerchantHandler handler);

		// +(void)initializeFakePPHRetailMerchant:(PPHRetailMerchant *)merchant completionHandler:(PPRetailMerchantHandler)handler;
		[Static]
		[Export ("initializeFakePPHRetailMerchant:completionHandler:")]
		void InitializeFakePPHRetailMerchant (PPHRetailMerchant merchant, PPRetailMerchantHandler handler);

		// +(void)connectToLastActiveReader;
		[Static]
		[Export ("connectToLastActiveReader")]
		void ConnectToLastActiveReader ();

		// +(void)startWatchingAudio;
		[Static]
		[Export ("startWatchingAudio")]
		void StartWatchingAudio ();

		// +(void)endCardReaderDiscovery;
		[Static]
		[Export ("endCardReaderDiscovery")]
		void EndCardReaderDiscovery ();

		// +(PPRetailDeviceManager *)deviceManager;
		[Static]
		[Export ("deviceManager")]
		//[Verify (MethodToProperty)]
		PPRetailDeviceManager DeviceManager { get; }

		// +(PPRetailTransactionManager *)transactionManager;
		[Static]
		[Export ("transactionManager")]
		//[Verify (MethodToProperty)]
		PPRetailTransactionManager TransactionManager { get; }

		// +(PPRetailBraintreeManager *)braintreeManager;
		[Static]
		[Export ("braintreeManager")]
		//[Verify (MethodToProperty)]
		PPRetailBraintreeManager BraintreeManager { get; }

		// +(void)logout;
		[Static]
		[Export ("logout")]
		void Logout ();

		// +(NSString *)getMerchantCountryCode;
		[Static]
		[Export ("getMerchantCountryCode")]
		//[Verify (MethodToProperty)]
		string MerchantCountryCode { get; }

		// +(NSString *)localizedStringNamed:(NSString *)name withDefault:(NSString *)defaultValue forTable:(NSString *)table;
		[Static]
		[Export ("localizedStringNamed:withDefault:forTable:")]
		string LocalizedStringNamed (string name, string defaultValue, string table);

		// +(void)sendReceiptWithUI:(UINavigationController *)navigationController invoice:(PPRetailRetailInvoice *)invoice isEmail:(BOOL)isEmail callback:(void (^)(PPRetailError *, NSDictionary *))callback;
		[Static]
		[Export ("sendReceiptWithUI:invoice:isEmail:callback:")]
		void SendReceiptWithUI (UINavigationController navigationController, PPRetailRetailInvoice invoice, bool isEmail, Action<PPRetailError, NSDictionary> callback);

		// +(void)logViaSDK:(NSString *)logLevel component:(NSString *)component message:(NSString *)message;
		[Static]
		[Export ("logViaSDK:component:message:")]
		void LogViaSDK (string logLevel, string component, string message);

		// +(void)setUITheme:(PPRetailUITheme)theme;
		[Static]
		[Export ("setUITheme:")]
		void SetUITheme (PPRetailUITheme theme);

		// +(PPRetailUITheme)getUITheme;
		[Static]
		[Export ("getUITheme")]
		//[Verify (MethodToProperty)]
		PPRetailUITheme UITheme { get; }

		// +(void)setReceiptScreenOrientation:(PPRetailReceiptScreenOrientation)orientation;
		[Static]
		[Export ("setReceiptScreenOrientation:")]
		void SetReceiptScreenOrientation (PPRetailReceiptScreenOrientation orientation);

		// +(PPRetailReceiptScreenOrientation)getReceiptScreenOrientation;
		[Static]
		[Export ("getReceiptScreenOrientation")]
		//[Verify (MethodToProperty)]
		PPRetailReceiptScreenOrientation ReceiptScreenOrientation { get; }

		// +(NSString *)getSdkVersion;
		[Static]
		[Export ("getSdkVersion")]
		//[Verify (MethodToProperty)]
		string SdkVersion { get; }

		// +(BOOL)isLightTheme;
		[Static]
		[Export ("isLightTheme")]
		//[Verify (MethodToProperty)]
		bool IsLightTheme { get; }
	}

}