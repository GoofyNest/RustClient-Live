internal struct P2PSessionConnectFail_t : ICallbackData // TypeDefIndex: 5405
{	internal ulong SteamIDRemote; // 0x0
	internal byte P2PSessionError; // 0x8
	public static int _datasize; // 0x0

	public int DataSize { get; }
	public CallbackType CallbackType { get; }


	public int get_DataSize() { }

	public CallbackType get_CallbackType() { }

	private static void .cctor() { }

}

