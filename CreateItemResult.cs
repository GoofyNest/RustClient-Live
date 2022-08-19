internal struct CreateItemResult_t : ICallbackData // TypeDefIndex: 5432
{	// Fields
	internal Result Result; // 0x0
	internal PublishedFileId PublishedFileId; // 0x8
	internal bool UserNeedsToAcceptWorkshopLegalAgreement; // 0x10
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1E50E0 Offset: 0x1E44E0 VA: 0x1801E50E0 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1E50D0 Offset: 0x1E44D0 VA: 0x1801E50D0 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x1369F40 Offset: 0x1369340 VA: 0x181369F40
	private static void .cctor() { }

}

