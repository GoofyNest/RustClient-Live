internal struct DownloadItemResult_t : ICallbackData // TypeDefIndex: 5435
{	internal AppId AppID; // 0x0
	internal PublishedFileId PublishedFileId; // 0x8
	internal Result Result; // 0x10
	public static int _datasize; // 0x0

	public int DataSize { get; }
	public CallbackType CallbackType { get; }


	public int get_DataSize() { }

	public CallbackType get_CallbackType() { }

	private static void .cctor() { }

}

