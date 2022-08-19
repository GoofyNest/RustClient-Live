internal struct LeaderboardFindResult_t : ICallbackData // TypeDefIndex: 5389
{	// Fields
	internal ulong SteamLeaderboard; // 0x0
	internal byte LeaderboardFound; // 0x8
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1EB030 Offset: 0x1EA430 VA: 0x1801EB030 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1EB020 Offset: 0x1EA420 VA: 0x1801EB020 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x136DE70 Offset: 0x136D270 VA: 0x18136DE70
	private static void .cctor() { }

}

