internal struct LobbyGameCreated_t : ICallbackData // TypeDefIndex: 5347
{
	internal ulong SteamIDLobby; 
	internal ulong SteamIDGameServer; 
	internal uint IP; 
	internal ushort Port; 
	public static int _datasize; 

	public int DataSize { get; }
	public CallbackType CallbackType { get; }


	public int get_DataSize() { }

	public CallbackType get_CallbackType() { }

	private static void .cctor() { }

}

