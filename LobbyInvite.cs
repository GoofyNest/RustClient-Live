internal struct LobbyInvite_t : ICallbackData // TypeDefIndex: 5337
{
	internal ulong SteamIDUser; 
	internal ulong SteamIDLobby; 
	internal ulong GameID; 
	public static int _datasize; 

	public int DataSize { get; }
	public CallbackType CallbackType { get; }


	public int get_DataSize() { }

	public CallbackType get_CallbackType() { }

	private static void .cctor() { }

}

