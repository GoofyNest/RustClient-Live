internal struct LobbyChatUpdate_t : ICallbackData // TypeDefIndex: 5339
{	// Fields
	internal ulong SteamIDLobby; // 0x0
	internal ulong SteamIDUserChanged; // 0x8
	internal ulong SteamIDMakingChange; // 0x10
	internal uint GfChatMemberStateChange; // 0x18
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1EB2D0 Offset: 0x1EA6D0 VA: 0x1801EB2D0 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1EB2C0 Offset: 0x1EA6C0 VA: 0x1801EB2C0 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x136E250 Offset: 0x136D650 VA: 0x18136E250
	private static void .cctor() { }

}

