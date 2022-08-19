internal struct GameConnectedChatLeave_t : ICallbackData // TypeDefIndex: 5317
{	// Fields
	internal ulong SteamIDClanChat; // 0x0
	internal ulong SteamIDUser; // 0x8
	internal bool Kicked; // 0x10
	internal bool Dropped; // 0x11
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1E7790 Offset: 0x1E6B90 VA: 0x1801E7790 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1E7780 Offset: 0x1E6B80 VA: 0x1801E7780 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x136B910 Offset: 0x136AD10 VA: 0x18136B910
	private static void .cctor() { }

}

