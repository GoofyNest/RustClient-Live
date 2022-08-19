internal struct SubmitPlayerResultResultCallback_t : ICallbackData // TypeDefIndex: 5353
{	// Fields
	internal Result Result; // 0x0
	internal ulong UllUniqueGameID; // 0x4
	internal ulong SteamIDPlayer; // 0xC
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1DAF60 Offset: 0x1DA360 VA: 0x1801DAF60 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1DAF50 Offset: 0x1DA350 VA: 0x1801DAF50 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x128BB60 Offset: 0x128AF60 VA: 0x18128BB60
	private static void .cctor() { }

}

