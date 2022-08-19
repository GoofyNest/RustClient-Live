internal struct LeaderboardScoreUploaded_t : ICallbackData // TypeDefIndex: 5391
{	// Fields
	internal byte Success; // 0x0
	internal ulong SteamLeaderboard; // 0x8
	internal int Score; // 0x10
	internal byte ScoreChanged; // 0x14
	internal int GlobalRankNew; // 0x18
	internal int GlobalRankPrevious; // 0x1C
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1EB0A0 Offset: 0x1EA4A0 VA: 0x1801EB0A0 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1EB090 Offset: 0x1EA490 VA: 0x1801EB090 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x136DF10 Offset: 0x136D310 VA: 0x18136DF10
	private static void .cctor() { }

}

