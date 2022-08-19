internal struct GSClientDeny_t : ICallbackData // TypeDefIndex: 5491
{	// Fields
	internal ulong SteamID; // 0x0
	internal DenyReason DenyReason; // 0x8
	internal byte[] OptionalText; // 0x10
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1E6BA0 Offset: 0x1E5FA0 VA: 0x1801E6BA0 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1E6B90 Offset: 0x1E5F90 VA: 0x1801E6B90 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x136B370 Offset: 0x136A770 VA: 0x18136B370
	private static void .cctor() { }

}

