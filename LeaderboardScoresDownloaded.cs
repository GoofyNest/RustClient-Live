internal struct LeaderboardScoresDownloaded_t : ICallbackData // TypeDefIndex: 5394
{
	internal ulong SteamLeaderboard; 
	internal ulong SteamLeaderboardEntries; 
	internal int CEntryCount; 
	public static int _datasize; 

	public int DataSize { get; }
	public CallbackType CallbackType { get; }


	public int get_DataSize() { }

	public CallbackType get_CallbackType() { }

	private static void .cctor() { }

}

