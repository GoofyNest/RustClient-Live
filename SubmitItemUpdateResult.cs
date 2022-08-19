internal struct SubmitItemUpdateResult_t : ICallbackData // TypeDefIndex: 5433
{	// Fields
	internal Result Result; // 0x0
	internal bool UserNeedsToAcceptWorkshopLegalAgreement; // 0x4
	internal PublishedFileId PublishedFileId; // 0x8
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1DAEF0 Offset: 0x1DA2F0 VA: 0x1801DAEF0 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1DAEE0 Offset: 0x1DA2E0 VA: 0x1801DAEE0 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x128BAB0 Offset: 0x128AEB0 VA: 0x18128BAB0
	private static void .cctor() { }

}

