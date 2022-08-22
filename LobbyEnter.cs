internal struct LobbyEnter_t : ICallbackData // TypeDefIndex: 5337
{	internal ulong SteamIDLobby; // 0x0
	internal uint GfChatPermissions; // 0x8
	internal bool Locked; // 0xC
	internal uint EChatRoomEnterResponse; // 0x10
	public static int _datasize; // 0x0

	public int DataSize { get; }
	public CallbackType CallbackType { get; }


	public int get_DataSize() { }

	public CallbackType get_CallbackType() { }

	private static void .cctor() { }

}

