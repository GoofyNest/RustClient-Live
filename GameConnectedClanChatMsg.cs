internal struct GameConnectedClanChatMsg_t : ICallbackData // TypeDefIndex: 5315
{
	internal ulong SteamIDClanChat; 
	internal ulong SteamIDUser; 
	internal int MessageID; 
	public static int _datasize; 

	public int DataSize { get; }
	public CallbackType CallbackType { get; }


	public int get_DataSize() { }

	public CallbackType get_CallbackType() { }

	private static void .cctor() { }

}

