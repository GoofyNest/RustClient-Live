internal struct LobbyEnter_t : ICallbackData // TypeDefIndex: 5343
{
	internal ulong SteamIDLobby; 
	internal uint GfChatPermissions; 
	internal bool Locked; 
	internal uint EChatRoomEnterResponse; 
	public static int _datasize; 

	public int DataSize { get; }
	public CallbackType CallbackType { get; }


	public int get_DataSize() { }

	public CallbackType get_CallbackType() { }

	private static void .cctor() { }

}

