internal struct LobbyEnter_t : ICallbackData // TypeDefIndex: 5337
{	// Fields
	internal ulong SteamIDLobby; // 0x0
	internal uint GfChatPermissions; // 0x8
	internal bool Locked; // 0xC
	internal uint EChatRoomEnterResponse; // 0x10
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1EB420 Offset: 0x1EA820 VA: 0x1801EB420 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1EB410 Offset: 0x1EA810 VA: 0x1801EB410 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x136E460 Offset: 0x136D860 VA: 0x18136E460
	private static void .cctor() { }

}

