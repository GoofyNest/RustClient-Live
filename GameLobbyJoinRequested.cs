internal struct GameLobbyJoinRequested_t : ICallbackData // TypeDefIndex: 5310
{	// Fields
	internal ulong SteamIDLobby; // 0x0
	internal ulong SteamIDFriend; // 0x8
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1E78E0 Offset: 0x1E6CE0 VA: 0x1801E78E0 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1E78D0 Offset: 0x1E6CD0 VA: 0x1801E78D0 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x136BB10 Offset: 0x136AF10 VA: 0x18136BB10
	private static void .cctor() { }

}

