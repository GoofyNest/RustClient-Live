internal struct LobbyKicked_t : ICallbackData // TypeDefIndex: 5343
{	// Fields
	internal ulong SteamIDLobby; // 0x0
	internal ulong SteamIDAdmin; // 0x8
	internal byte KickedDueToDisconnect; // 0x10
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1EB570 Offset: 0x1EA970 VA: 0x1801EB570 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1EB560 Offset: 0x1EA960 VA: 0x1801EB560 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x136E670 Offset: 0x136DA70 VA: 0x18136E670
	private static void .cctor() { }

}

