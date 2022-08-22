internal struct LeaderboardScoreUploaded_t : ICallbackData // TypeDefIndex: 5391
{	internal byte Success; // 0x0
	internal ulong SteamLeaderboard; // 0x8
	internal int Score; // 0x10
	internal byte ScoreChanged; // 0x14
	internal int GlobalRankNew; // 0x18
	internal int GlobalRankPrevious; // 0x1C
	public static int _datasize; // 0x0

	public int DataSize { get; }
	public CallbackType CallbackType { get; }


	public int get_DataSize() { }

	public CallbackType get_CallbackType() { }

	private static void .cctor() { }

}

