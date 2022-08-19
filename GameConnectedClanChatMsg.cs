internal struct GameConnectedClanChatMsg_t : ICallbackData // TypeDefIndex: 5315
{	// Fields
	internal ulong SteamIDClanChat; // 0x0
	internal ulong SteamIDUser; // 0x8
	internal int MessageID; // 0x10
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1E7800 Offset: 0x1E6C00 VA: 0x1801E7800 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1E77F0 Offset: 0x1E6BF0 VA: 0x1801E77F0 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x136B9B0 Offset: 0x136ADB0 VA: 0x18136B9B0
	private static void .cctor() { }

}

