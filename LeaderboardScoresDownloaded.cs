internal struct LeaderboardScoresDownloaded_t : ICallbackData // TypeDefIndex: 5390
{	internal ulong SteamLeaderboard; // 0x0
	internal ulong SteamLeaderboardEntries; // 0x8
	internal int CEntryCount; // 0x10
	public static int _datasize; // 0x0

	public int DataSize { get; }
	public CallbackType CallbackType { get; }


	public int get_DataSize() { }

	public CallbackType get_CallbackType() { }

	private static void .cctor() { }

}

