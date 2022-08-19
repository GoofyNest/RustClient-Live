internal struct LobbyChatMsg_t : ICallbackData // TypeDefIndex: 5340
{	// Fields
	internal ulong SteamIDLobby; // 0x0
	internal ulong SteamIDUser; // 0x8
	internal byte ChatEntryType; // 0x10
	internal uint ChatID; // 0x14
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1EB260 Offset: 0x1EA660 VA: 0x1801EB260 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1EB250 Offset: 0x1EA650 VA: 0x1801EB250 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x136E1A0 Offset: 0x136D5A0 VA: 0x18136E1A0
	private static void .cctor() { }

}

