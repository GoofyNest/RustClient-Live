internal struct GetVideoURLResult_t : ICallbackData // TypeDefIndex: 5488
{
	internal Result Result;
	internal AppId VideoAppID;
	internal byte[] URL;
	public static int _datasize;

	public int DataSize { get; }
	public CallbackType CallbackType { get; }


	public int get_DataSize() { }

	public CallbackType get_CallbackType() { }

	private static void .cctor() { }

}

