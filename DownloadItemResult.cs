internal struct DownloadItemResult_t : ICallbackData // TypeDefIndex: 5435
{	// Fields
	internal AppId AppID; // 0x0
	internal PublishedFileId PublishedFileId; // 0x8
	internal Result Result; // 0x10
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1E5310 Offset: 0x1E4710 VA: 0x1801E5310 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1E5300 Offset: 0x1E4700 VA: 0x1801E5300 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x136AA60 Offset: 0x1369E60 VA: 0x18136AA60
	private static void .cctor() { }

}

