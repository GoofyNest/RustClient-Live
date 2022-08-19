internal struct GSClientKick_t : ICallbackData // TypeDefIndex: 5492
{	// Fields
	internal ulong SteamID; // 0x0
	internal DenyReason DenyReason; // 0x8
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1E7480 Offset: 0x1E6880 VA: 0x1801E7480 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1E7470 Offset: 0x1E6870 VA: 0x1801E7470 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x136B4B0 Offset: 0x136A8B0 VA: 0x18136B4B0
	private static void .cctor() { }

}

