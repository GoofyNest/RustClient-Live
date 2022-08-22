internal struct MarketEligibilityResponse_t : ICallbackData // TypeDefIndex: 5305
{	internal bool Allowed; // 0x0
	internal MarketNotAllowedReasonFlags NotAllowedReason; // 0x4
	internal uint TAllowedAtTime; // 0x8
	internal int CdaySteamGuardRequiredDays; // 0xC
	internal int CdayNewDeviceCooldown; // 0x10
	public static int _datasize; // 0x0

	public int DataSize { get; }
	public CallbackType CallbackType { get; }


	public int get_DataSize() { }

	public CallbackType get_CallbackType() { }

	private static void .cctor() { }

}

