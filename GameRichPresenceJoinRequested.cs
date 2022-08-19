internal struct GameRichPresenceJoinRequested_t : ICallbackData // TypeDefIndex: 5314
{	// Fields
	internal ulong SteamIDFriend; // 0x0
	internal byte[] Connect; // 0x8
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1E79B0 Offset: 0x1E6DB0 VA: 0x1801E79B0
	internal string ConnectUTF8() { }

	// RVA: 0x1E7A40 Offset: 0x1E6E40 VA: 0x1801E7A40 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1E7A30 Offset: 0x1E6E30 VA: 0x1801E7A30 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x136BCF0 Offset: 0x136B0F0 VA: 0x18136BCF0
	private static void .cctor() { }

}

