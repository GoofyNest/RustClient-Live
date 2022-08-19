internal struct FriendsGetFollowerCount_t : ICallbackData // TypeDefIndex: 5321
{	// Fields
	internal Result Result; // 0x0
	internal ulong SteamID; // 0x4
	internal int Count; // 0xC
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1E6130 Offset: 0x1E5530 VA: 0x1801E6130 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1E6120 Offset: 0x1E5520 VA: 0x1801E6120 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x136B0E0 Offset: 0x136A4E0 VA: 0x18136B0E0
	private static void .cctor() { }

}

