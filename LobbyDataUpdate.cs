internal struct LobbyDataUpdate_t : ICallbackData // TypeDefIndex: 5346
{
	internal ulong SteamIDLobby;
	internal ulong SteamIDMember;
	internal byte Success;
	public static int _datasize;

	public int DataSize { get; }
	public CallbackType CallbackType { get; }


	public int get_DataSize() { }

	public CallbackType get_CallbackType() { }

	private static void .cctor() { }

}

