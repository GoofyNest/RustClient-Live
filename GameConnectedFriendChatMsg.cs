internal struct GameConnectedFriendChatMsg_t : ICallbackData // TypeDefIndex: 5320
{	// Fields
	internal ulong SteamIDUser; // 0x0
	internal int MessageID; // 0x8
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1E7870 Offset: 0x1E6C70 VA: 0x1801E7870 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1E7860 Offset: 0x1E6C60 VA: 0x1801E7860 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x136BA60 Offset: 0x136AE60 VA: 0x18136BA60
	private static void .cctor() { }

}

