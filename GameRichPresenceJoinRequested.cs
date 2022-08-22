internal struct GameRichPresenceJoinRequested_t : ICallbackData // TypeDefIndex: 5314
{	internal ulong SteamIDFriend; // 0x0
	internal byte[] Connect; // 0x8
	public static int _datasize; // 0x0

	public int DataSize { get; }
	public CallbackType CallbackType { get; }


	internal string ConnectUTF8() { }

	public int get_DataSize() { }

	public CallbackType get_CallbackType() { }

	private static void .cctor() { }

}

