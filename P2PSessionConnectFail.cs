internal struct P2PSessionConnectFail_t : ICallbackData // TypeDefIndex: 5413
{
	internal ulong SteamIDRemote;
	internal byte P2PSessionError;
	public static int _datasize;

	public int DataSize { get; }
	public CallbackType CallbackType { get; }


	public int get_DataSize() { }

	public CallbackType get_CallbackType() { }

	private static void .cctor() { }

}

