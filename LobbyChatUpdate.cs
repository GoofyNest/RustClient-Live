internal struct LobbyChatUpdate_t : ICallbackData // TypeDefIndex: 5339
{	internal ulong SteamIDLobby; // 0x0
	internal ulong SteamIDUserChanged; // 0x8
	internal ulong SteamIDMakingChange; // 0x10
	internal uint GfChatMemberStateChange; // 0x18
	public static int _datasize; // 0x0

	public int DataSize { get; }
	public CallbackType CallbackType { get; }


	public int get_DataSize() { }

	public CallbackType get_CallbackType() { }

	private static void .cctor() { }

}

