internal struct WorkshopEULAStatus_t : ICallbackData // TypeDefIndex: 5448
{	// Fields
	internal Result Result; // 0x0
	internal AppId AppID; // 0x4
	internal uint Version; // 0x8
	internal uint TAction; // 0xC
	internal bool Accepted; // 0x10
	internal bool NeedsAction; // 0x11
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1DC880 Offset: 0x1DBC80 VA: 0x1801DC880 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1DC870 Offset: 0x1DBC70 VA: 0x1801DC870 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x128CB90 Offset: 0x128BF90 VA: 0x18128CB90
	private static void .cctor() { }

}

