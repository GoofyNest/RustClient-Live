internal struct SearchForGameResultCallback_t : ICallbackData // TypeDefIndex: 5349
{
	internal ulong LSearchID; 
	internal Result Result; 
	internal int CountPlayersInGame; 
	internal int CountAcceptedGame; 
	internal ulong SteamIDHost; 
	internal bool FinalCallback; 
	public static int _datasize; 

	public int DataSize { get; }
	public CallbackType CallbackType { get; }


	public int get_DataSize() { }

	public CallbackType get_CallbackType() { }

	private static void .cctor() { }

}

