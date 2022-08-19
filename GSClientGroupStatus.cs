internal struct GSClientGroupStatus_t : ICallbackData // TypeDefIndex: 5496
{	// Fields
	internal ulong SteamIDUser; // 0x0
	internal ulong SteamIDGroup; // 0x8
	internal bool Member; // 0x10
	internal bool Officer; // 0x11
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1E7410 Offset: 0x1E6810 VA: 0x1801E7410 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1E7400 Offset: 0x1E6800 VA: 0x1801E7400 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x136B410 Offset: 0x136A810 VA: 0x18136B410
	private static void .cctor() { }

}

