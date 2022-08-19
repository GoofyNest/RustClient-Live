internal struct GetVideoURLResult_t : ICallbackData // TypeDefIndex: 5480
{	// Fields
	internal Result Result; // 0x0
	internal AppId VideoAppID; // 0x4
	internal byte[] URL; // 0x8
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1E90F0 Offset: 0x1E84F0 VA: 0x1801E90F0 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1E90E0 Offset: 0x1E84E0 VA: 0x1801E90E0 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x136C3C0 Offset: 0x136B7C0 VA: 0x18136C3C0
	private static void .cctor() { }

}

