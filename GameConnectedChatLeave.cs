internal struct GameConnectedChatLeave_t : ICallbackData // TypeDefIndex: 5321
{
	internal ulong SteamIDClanChat; 
	internal ulong SteamIDUser; 
	internal bool Kicked; 
	internal bool Dropped; 
	public static int _datasize; 

	public int DataSize { get; }
	public CallbackType CallbackType { get; }


	public int get_DataSize() { }

	public CallbackType get_CallbackType() { }

	private static void .cctor() { }

}

