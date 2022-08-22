internal struct SearchForGameProgressCallback_t : ICallbackData // TypeDefIndex: 5347
{	internal ulong LSearchID; // 0x0
	internal Result Result; // 0x8
	internal ulong LobbyID; // 0xC
	internal ulong SteamIDEndedSearch; // 0x14
	internal int SecondsRemainingEstimate; // 0x1C
	internal int CPlayersSearching; // 0x20
	public static int _datasize; // 0x0

	public int DataSize { get; }
	public CallbackType CallbackType { get; }


	public int get_DataSize() { }

	public CallbackType get_CallbackType() { }

	private static void .cctor() { }

}

