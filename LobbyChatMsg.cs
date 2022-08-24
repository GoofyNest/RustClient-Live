internal struct LobbyChatMsg_t : ICallbackData // TypeDefIndex: 5340
{
	internal ulong SteamIDLobby; 
	internal ulong SteamIDUser; 
	internal byte ChatEntryType; 
	internal uint ChatID; 
	public static int _datasize; 

	public int DataSize { get; }
	public CallbackType CallbackType { get; }


	public int get_DataSize() { }

	public CallbackType get_CallbackType() { }

	private static void .cctor() { }

}

