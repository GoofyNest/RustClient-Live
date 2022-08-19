internal struct LobbyGameCreated_t : ICallbackData // TypeDefIndex: 5341
{	// Fields
	internal ulong SteamIDLobby; // 0x0
	internal ulong SteamIDGameServer; // 0x8
	internal uint IP; // 0x10
	internal ushort Port; // 0x14
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1EB490 Offset: 0x1EA890 VA: 0x1801EB490 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1EB480 Offset: 0x1EA880 VA: 0x1801EB480 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x136E510 Offset: 0x136D910 VA: 0x18136E510
	private static void .cctor() { }

}

