internal struct MarketEligibilityResponse_t : ICallbackData // TypeDefIndex: 5305
{	// Fields
	internal bool Allowed; // 0x0
	internal MarketNotAllowedReasonFlags NotAllowedReason; // 0x4
	internal uint TAllowedAtTime; // 0x8
	internal int CdaySteamGuardRequiredDays; // 0xC
	internal int CdayNewDeviceCooldown; // 0x10
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1EB6C0 Offset: 0x1EAAC0 VA: 0x1801EB6C0 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1EB6B0 Offset: 0x1EAAB0 VA: 0x1801EB6B0 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x136E870 Offset: 0x136DC70 VA: 0x18136E870
	private static void .cctor() { }

}

