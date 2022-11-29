internal struct SearchForGameProgressCallback_t : ICallbackData // TypeDefIndex: 5353
{
	internal ulong LSearchID; 
	internal Result Result; 
	internal ulong LobbyID; 
	internal ulong SteamIDEndedSearch; 
	internal int SecondsRemainingEstimate; 
	internal int CPlayersSearching; 
	public static int _datasize; 

	public int DataSize { get; }
	public CallbackType CallbackType { get; }


	public int get_DataSize() { }

	public CallbackType get_CallbackType() { }

	private static void .cctor() { }

}

