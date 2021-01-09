using System;
using ObjCRuntime;

namespace PayPalHere
{
	[Native]
	public enum PPRetailInvoiceStatus : ulong
	{
		New = 0,
		Draft = 1,
		Sent = 2,
		Paid = 3,
		MarkedAsPaid = 4,
		Cancelled = 5,
		Refunded = 6,
		PartiallyRefunded = 7,
		MarkedAsRefunded = 8,
		PartiallyPaid = 9,
		Unpaid = 10,
		PaymentPending = 11,
		Scheduled = 12,
		Unknown = 13
	}

	[Native]
	public enum PPRetailInvoicePaymentType : ulong
	{
		None = 0,
		External = 1,
		Paypal = 2
	}

	[Native]
	public enum PPRetailInvoicePaymentMethod : ulong
	{
		None = 0,
		BankTransfer = 1,
		Cash = 2,
		Check = 3,
		CreditCard = 4,
		DebitCard = 5,
		Paypal = 6,
		WireTransfer = 7,
		Other = 8
	}

	[Native]
	public enum PPRetailInvoiceAction : ulong
	{
		None = 0,
		Delete = 1,
		Send = 2,
		Remind = 3,
		RecordPayment = 4,
		RecordRefund = 5,
		Copy = 6,
		Edit = 7,
		Call = 8,
		Cancel = 9,
		More = 10,
		Share = 11,
		ViewHistory = 12,
		ViewInvoice = 13,
		QRCode = 14
	}

	[Native]
	public enum PPRetailInvoicePaymentTermPaymentTerms : ulong
	{
		NoPaymentTerms = 0,
		DueOnReceipt = 1,
		Net10 = 2,
		Net15 = 3,
		Net30 = 4,
		Net45 = 5,
		Net60 = 6,
		Net90 = 7
	}

	[Native]
	public enum PPRetaillogLevel : ulong
	{
		developer = 1,
		debug = 2,
		info = 3,
		track = 4,
		warn = 5,
		error = 6,
		quiet = 7
	}

	[Native]
	public enum PPRetailUITheme : ulong
	{
		light = 0,
		blue = 1
	}

	[Native]
	public enum PPRetailReceiptScreenOrientation : ulong
	{
		Sensor = 0,
		Portrait = 1,
		Landscape = 2
	}

	[Native]
	public enum PPRetailTransactionBeginOptionsPaymentTypes : ulong
	{
		card = 0,
		keyIn = 1,
		cash = 2,
		check = 3,
		digitalCard = 4,
		qrc = 5
	}

	[Native]
	public enum PPRetailTransactionBeginOptionsVaultType : ulong
	{
		PayOnly = 0,
		VaultOnly = 1,
		PayAndVault = 2
	}

	[Native]
	public enum PPRetailTransactionBeginOptionsVaultProvider : ulong
	{
		PPRetailTransactionBeginOptionsVaultProviderBraulongree = 0
	}

	[Native]
	public enum PPRetailTransactionBeginOptionsQRCProvider : ulong
	{
		Paypal = 0,
		Venmo = 1
	}

	[Native]
	public enum PPRetailReceiptDestinationType : ulong
	{
		none = 0,
		email = 1,
		text = 2
	}

	[Native]
	public enum PPRetailPaymentState : ulong
	{
		idle = 0,
		inProgress = 1,
		retry = 2,
		complete = 3
	}

	[Native]
	public enum PPRetailTippingState : ulong
	{
		notStarted = 0,
		inProgress = 1,
		complete = 2
	}

	[Native]
	public enum PPRetailCompletionInvocationState : ulong
	{
		notInvoked = 0,
		invoked = 1,
		complete = 2
	}

	[Native]
	public enum PPRetailAuthStatus : ulong
	{
		pending = 0,
		canceled = 1
	}

	[Native]
	public enum PPRetailOfflineTransactionState : ulong
	{
		Deleted = 0,
		Completed = 1,
		Failed = 2,
		Active = 3,
		Declined = 4
	}

	[Native]
	public enum PPRetailQRCContentType : ulong
	{
		Url = 0,
		Text = 1
	}

	[Native]
	public enum PPRetailQRCStatus : ulong
	{
		draft = 0,
		url_created = 1,
		session_created = 2,
		scanned = 3,
		awaiting_user_input = 4,
		processing = 5,
		success = 6,
		failed = 7,
		cancelled = 8,
		aborted = 9,
		declined = 10,
		cancelled_by_merchant = 11
	}

	[Native]
	public enum PPRetailbatteryStatus : ulong
	{
		unknown = 0,
		draining = 1,
		drained = 2,
		charging = 3,
		charged = 4
	}

	[Native]
	public enum PPRetaildeviceCapabilityType : ulong
	{
		none = 0,
		display = 1,
		keyboard = 2,
		secureEntry = 3,
		contactless = 4
	}

	[Native]
	public enum PPRetailCardStatus : ulong
	{
		None = 0,
		NonEmvCard = 1,
		EmvCard = 3
	}

	[Native]
	public enum PPRetailCardIssuer : ulong
	{
		Unknown = 0,
		Visa = 1,
		MasterCard = 2,
		Maestro = 3,
		Amex = 4,
		Discover = 5,
		PayPal = 6
	}

	[Native]
	public enum PPRetailFormFactor : ulong
	{
		None = 0,
		MagneticCardSwipe = 1,
		Chip = 2,
		EmvCertifiedContactless = 3,
		SecureManualEntry = 4,
		ManualCardEntry = 5,
		DigitalCard = 6
	}

	[Native]
	public enum PPRetailTransactionType : ulong
	{
		Sale = 0,
		Auth = 1,
		Refund = 2,
		PartialRefund = 3,
		Vault = 4,
		Redemption = 5
	}

	[Native]
	public enum PPRetailreaderType : ulong
	{
		Unknown = 0,
		Magstripe = 1,
		Emv = 2
	}

	[Native]
	public enum PPRetailreaderConnectionType : ulong
	{
		unknown = 0,
		audioJack = 1,
		bluetooth = 2,
		dockPort = 3,
		usb = 4,
		network = 5
	}

	[Native]
	public enum PPRetailReaderModel : ulong
	{
		Unknown = 0,
		Swiper = 1,
		M003 = 2,
		M010 = 3,
		Moby3000 = 4,
		Rp450 = 5,
		E285 = 6,
		P400 = 7,
		Verifone = 8
	}

	[Native]
	public enum PPRetaildeviceManufacturer : ulong
	{
		miura = 0,
		ingenico = 1,
		bbpos = 2,
		roam = 3,
		verifone = 4
	}

	[Native]
	public enum PPRetailDeviceSimulatorType : ulong
	{
		Swiper = 0,
		Miura = 1,
		Ingenico = 2
	}

	[Native]
	public enum PPRetailSimulatorUseCase : ulong
	{
		Chip = 0,
		Swipe = 1,
		FbSwipe = 2,
		Contactless = 3
	}

}