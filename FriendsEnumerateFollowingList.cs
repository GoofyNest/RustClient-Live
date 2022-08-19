internal struct FriendsEnumerateFollowingList_t : ICallbackData // TypeDefIndex: 5323
{	// Fields
	internal Result Result; // 0x0
	internal ulong[] GSteamID; // 0x8
	internal int ResultsReturned; // 0x10
	internal int TotalResultCount; // 0x14
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1E5980 Offset: 0x1E4D80 VA: 0x1801E5980 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1E5970 Offset: 0x1E4D70 VA: 0x1801E5970 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x136B040 Offset: 0x136A440 VA: 0x18136B040
	private static void .cctor() { }

}

