internal struct LeaderboardScoreUploaded_t : ICallbackData // TypeDefIndex: 5397
{
	internal byte Success; 
	internal ulong SteamLeaderboard; 
	internal int Score; 
	internal byte ScoreChanged; 
	internal int GlobalRankNew; 
	internal int GlobalRankPrevious; 
	public static int _datasize; 

	public int DataSize { get; }
	public CallbackType CallbackType { get; }


	public int get_DataSize() { }

	public CallbackType get_CallbackType() { }

	private static void .cctor() { }

}

