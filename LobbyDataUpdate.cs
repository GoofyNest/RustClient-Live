internal struct LobbyDataUpdate_t : ICallbackData // TypeDefIndex: 5338
{	// Fields
	internal ulong SteamIDLobby; // 0x0
	internal ulong SteamIDMember; // 0x8
	internal byte Success; // 0x10
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1EB3B0 Offset: 0x1EA7B0 VA: 0x1801EB3B0 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1EB3A0 Offset: 0x1EA7A0 VA: 0x1801EB3A0 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x136E3B0 Offset: 0x136D7B0 VA: 0x18136E3B0
	private static void .cctor() { }

}

