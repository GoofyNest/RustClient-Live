internal struct FriendsIsFollowing_t : ICallbackData // TypeDefIndex: 5322
{	// Fields
	internal Result Result; // 0x0
	internal ulong SteamID; // 0x4
	internal bool IsFollowing; // 0xC
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1E6250 Offset: 0x1E5650 VA: 0x1801E6250 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1E6240 Offset: 0x1E5640 VA: 0x1801E6240 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x136B190 Offset: 0x136A590 VA: 0x18136B190
	private static void .cctor() { }

}

