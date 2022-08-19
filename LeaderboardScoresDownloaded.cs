internal struct LeaderboardScoresDownloaded_t : ICallbackData // TypeDefIndex: 5390
{	// Fields
	internal ulong SteamLeaderboard; // 0x0
	internal ulong SteamLeaderboardEntries; // 0x8
	internal int CEntryCount; // 0x10
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1EB110 Offset: 0x1EA510 VA: 0x1801EB110 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1EB100 Offset: 0x1EA500 VA: 0x1801EB100 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x136DFB0 Offset: 0x136D3B0 VA: 0x18136DFB0
	private static void .cctor() { }

}

