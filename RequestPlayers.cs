internal struct RequestPlayersForGameProgressCallback_t : ICallbackData // TypeDefIndex: 5350
{
	internal Result Result; 
	internal ulong LSearchID; 
	public static int _datasize; 

	public int DataSize { get; }
	public CallbackType CallbackType { get; }


	public int get_DataSize() { }

	public CallbackType get_CallbackType() { }

	private static void .cctor() { }

}

internal struct RequestPlayersForGameResultCallback_t : ICallbackData // TypeDefIndex: 5351
{
	internal Result Result; 
	internal ulong LSearchID; 
	internal ulong SteamIDPlayerFound; 
	internal ulong SteamIDLobby; 
	internal RequestPlayersForGameResultCallback_t.PlayerAcceptState_t PlayerAcceptState; 
	internal int PlayerIndex; 
	internal int TotalPlayersFound; 
	internal int TotalPlayersAcceptedGame; 
	internal int SuggestedTeamIndex; 
	internal ulong LUniqueGameID; 
	public static int _datasize; 

	public int DataSize { get; }
	public CallbackType CallbackType { get; }


	public int get_DataSize() { }

	public CallbackType get_CallbackType() { }

	private static void .cctor() { }

}

internal enum RequestPlayersForGameResultCallback_t.PlayerAcceptState_t // TypeDefIndex: 5352
{
	public int value__; 
	public const RequestPlayersForGameResultCallback_t.PlayerAcceptState_t Unknown = 0;
	public const RequestPlayersForGameResultCallback_t.PlayerAcceptState_t PlayerAccepted = 1;
	public const RequestPlayersForGameResultCallback_t.PlayerAcceptState_t PlayerDeclined = 2;

}

internal struct RequestPlayersForGameFinalResultCallback_t : ICallbackData // TypeDefIndex: 5353
{
	internal Result Result; 
	internal ulong LSearchID; 
	internal ulong LUniqueGameID; 
	public static int _datasize; 

	public int DataSize { get; }
	public CallbackType CallbackType { get; }


	public int get_DataSize() { }

	public CallbackType get_CallbackType() { }

	private static void .cctor() { }

}

