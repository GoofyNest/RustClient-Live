internal struct GSStatsReceived_t : ICallbackData // TypeDefIndex: 5500
{	// Fields
	internal Result Result; // 0x0
	internal ulong SteamIDUser; // 0x4
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1E7640 Offset: 0x1E6A40 VA: 0x1801E7640 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1E7630 Offset: 0x1E6A30 VA: 0x1801E7630 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x136B730 Offset: 0x136AB30 VA: 0x18136B730
	private static void .cctor() { }

}

