internal struct RequestPlayersForGameProgressCallback_t : ICallbackData // TypeDefIndex: 5349
{	internal Result Result; // 0x0
	internal ulong LSearchID; // 0x8
	public static int _datasize; // 0x0

	public int DataSize { get; }
	public CallbackType CallbackType { get; }


	public int get_DataSize() { }

	public CallbackType get_CallbackType() { }

	private static void .cctor() { }

}

internal struct RequestPlayersForGameResultCallback_t : ICallbackData // TypeDefIndex: 5350
{	internal Result Result; // 0x0
	internal ulong LSearchID; // 0x4
	internal ulong SteamIDPlayerFound; // 0xC
	internal ulong SteamIDLobby; // 0x14
	internal RequestPlayersForGameResultCallback_t.PlayerAcceptState_t PlayerAcceptState; // 0x1C
	internal int PlayerIndex; // 0x20
	internal int TotalPlayersFound; // 0x24
	internal int TotalPlayersAcceptedGame; // 0x28
	internal int SuggestedTeamIndex; // 0x2C
	internal ulong LUniqueGameID; // 0x30
	public static int _datasize; // 0x0

	public int DataSize { get; }
	public CallbackType CallbackType { get; }


	public int get_DataSize() { }

	public CallbackType get_CallbackType() { }

	private static void .cctor() { }

}

internal enum RequestPlayersForGameResultCallback_t.PlayerAcceptState_t // TypeDefIndex: 5351
{	public int value__; // 0x0
	public const RequestPlayersForGameResultCallback_t.PlayerAcceptState_t Unknown = 0;
	public const RequestPlayersForGameResultCallback_t.PlayerAcceptState_t PlayerAccepted = 1;
	public const RequestPlayersForGameResultCallback_t.PlayerAcceptState_t PlayerDeclined = 2;

}

internal struct RequestPlayersForGameFinalResultCallback_t : ICallbackData // TypeDefIndex: 5352
{	internal Result Result; // 0x0
	internal ulong LSearchID; // 0x8
	internal ulong LUniqueGameID; // 0x10
	public static int _datasize; // 0x0

	public int DataSize { get; }
	public CallbackType CallbackType { get; }


	public int get_DataSize() { }

	public CallbackType get_CallbackType() { }

	private static void .cctor() { }

}

