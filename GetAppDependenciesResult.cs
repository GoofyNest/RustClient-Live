internal struct GetAppDependenciesResult_t : ICallbackData // TypeDefIndex: 5445
{	// Fields
	internal Result Result; // 0x0
	internal PublishedFileId PublishedFileId; // 0x8
	internal AppId[] GAppIDs; // 0x10
	internal uint NumAppDependencies; // 0x18
	internal uint TotalNumAppDependencies; // 0x1C
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1E8B70 Offset: 0x1E7F70 VA: 0x1801E8B70 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1E8B60 Offset: 0x1E7F60 VA: 0x1801E8B60 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x136C130 Offset: 0x136B530 VA: 0x18136C130
	private static void .cctor() { }

}

