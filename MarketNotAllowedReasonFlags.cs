internal enum MarketNotAllowedReasonFlags // TypeDefIndex: 5146
{
	public int value__; 
	public const MarketNotAllowedReasonFlags None = 0;
	public const MarketNotAllowedReasonFlags TemporaryFailure = 1;
	public const MarketNotAllowedReasonFlags AccountDisabled = 2;
	public const MarketNotAllowedReasonFlags AccountLockedDown = 4;
	public const MarketNotAllowedReasonFlags AccountLimited = 8;
	public const MarketNotAllowedReasonFlags TradeBanned = 16;
	public const MarketNotAllowedReasonFlags AccountNotTrusted = 32;
	public const MarketNotAllowedReasonFlags SteamGuardNotEnabled = 64;
	public const MarketNotAllowedReasonFlags SteamGuardOnlyRecentlyEnabled = 128;
	public const MarketNotAllowedReasonFlags RecentPasswordReset = 256;
	public const MarketNotAllowedReasonFlags NewPaymentMethod = 512;
	public const MarketNotAllowedReasonFlags InvalidCookie = 1024;
	public const MarketNotAllowedReasonFlags UsingNewDevice = 2048;
	public const MarketNotAllowedReasonFlags RecentSelfRefund = 4096;
	public const MarketNotAllowedReasonFlags NewPaymentMethodCannotBeVerified = 8192;
	public const MarketNotAllowedReasonFlags NoRecentPurchases = 16384;
	public const MarketNotAllowedReasonFlags AcceptedWalletGift = 32768;

}

