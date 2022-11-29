internal struct LobbyKicked_t : ICallbackData // TypeDefIndex: 5349
{
	internal ulong SteamIDLobby; 
	internal ulong SteamIDAdmin; 
	internal byte KickedDueToDisconnect; 
	public static int _datasize; 

	public int DataSize { get; }
	public CallbackType CallbackType { get; }


	public int get_DataSize() { }

	public CallbackType get_CallbackType() { }

	private static void .cctor() { }

}

