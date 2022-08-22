internal struct GetVideoURLResult_t : ICallbackData // TypeDefIndex: 5480
{	internal Result Result; // 0x0
	internal AppId VideoAppID; // 0x4
	internal byte[] URL; // 0x8
	public static int _datasize; // 0x0

	public int DataSize { get; }
	public CallbackType CallbackType { get; }


	public int get_DataSize() { }

	public CallbackType get_CallbackType() { }

	private static void .cctor() { }

}

