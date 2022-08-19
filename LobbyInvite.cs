internal struct LobbyInvite_t : ICallbackData // TypeDefIndex: 5336
{	// Fields
	internal ulong SteamIDUser; // 0x0
	internal ulong SteamIDLobby; // 0x8
	internal ulong GameID; // 0x10
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1EB500 Offset: 0x1EA900 VA: 0x1801EB500 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1EB4F0 Offset: 0x1EA8F0 VA: 0x1801EB4F0 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x136E5C0 Offset: 0x136D9C0 VA: 0x18136E5C0
	private static void .cctor() { }

}

