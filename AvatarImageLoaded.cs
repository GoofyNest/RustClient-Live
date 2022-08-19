internal struct AvatarImageLoaded_t : ICallbackData // TypeDefIndex: 5311
{	// Fields
	internal ulong SteamID; // 0x0
	internal int Image; // 0x8
	internal int Wide; // 0xC
	internal int Tall; // 0x10
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1E43D0 Offset: 0x1E37D0 VA: 0x1801E43D0 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1E43C0 Offset: 0x1E37C0 VA: 0x1801E43C0 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x1365A80 Offset: 0x1364E80 VA: 0x181365A80
	private static void .cctor() { }

}

