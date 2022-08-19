internal struct UserFavoriteItemsListChanged_t : ICallbackData // TypeDefIndex: 5436
{	// Fields
	internal PublishedFileId PublishedFileId; // 0x0
	internal Result Result; // 0x8
	internal bool WasAddRequest; // 0xC
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1DC570 Offset: 0x1DB970 VA: 0x1801DC570 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1DC560 Offset: 0x1DB960 VA: 0x1801DC560 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x128C6E0 Offset: 0x128BAE0 VA: 0x18128C6E0
	private static void .cctor() { }

}

