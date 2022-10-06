internal struct GameLobbyJoinRequested_t : ICallbackData // TypeDefIndex: 5314
{
	internal ulong SteamIDLobby; 
	internal ulong SteamIDFriend; 
	public static int _datasize; 

	public int DataSize { get; }
	public CallbackType CallbackType { get; }


	public int get_DataSize() { }

	public CallbackType get_CallbackType() { }

	private static void .cctor() { }

}

