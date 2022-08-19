internal struct GSReputation_t : ICallbackData // TypeDefIndex: 5497
{	// Fields
	internal Result Result; // 0x0
	internal uint ReputationScore; // 0x4
	internal bool Banned; // 0x8
	internal uint BannedIP; // 0xC
	internal ushort BannedPort; // 0x10
	internal ulong BannedGameID; // 0x18
	internal uint BanExpires; // 0x20
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1E75D0 Offset: 0x1E69D0 VA: 0x1801E75D0 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1E75C0 Offset: 0x1E69C0 VA: 0x1801E75C0 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x136B690 Offset: 0x136AA90 VA: 0x18136B690
	private static void .cctor() { }

}

