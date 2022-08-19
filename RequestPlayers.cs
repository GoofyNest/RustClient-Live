internal struct RequestPlayersForGameProgressCallback_t : ICallbackData // TypeDefIndex: 5349
{	// Fields
	internal Result Result; // 0x0
	internal ulong LSearchID; // 0x8
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1D7920 Offset: 0x1D6D20 VA: 0x1801D7920 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1D7910 Offset: 0x1D6D10 VA: 0x1801D7910 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x1289450 Offset: 0x1288850 VA: 0x181289450
	private static void .cctor() { }

}

internal struct RequestPlayersForGameResultCallback_t : ICallbackData // TypeDefIndex: 5350
{	// Fields
	internal Result Result; // 0x0
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

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1D7990 Offset: 0x1D6D90 VA: 0x1801D7990 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1D7980 Offset: 0x1D6D80 VA: 0x1801D7980 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x12894F0 Offset: 0x12888F0 VA: 0x1812894F0
	private static void .cctor() { }

}

internal enum RequestPlayersForGameResultCallback_t.PlayerAcceptState_t // TypeDefIndex: 5351
{	// Fields
	public int value__; // 0x0
	public const RequestPlayersForGameResultCallback_t.PlayerAcceptState_t Unknown = 0;
	public const RequestPlayersForGameResultCallback_t.PlayerAcceptState_t PlayerAccepted = 1;
	public const RequestPlayersForGameResultCallback_t.PlayerAcceptState_t PlayerDeclined = 2;

}

internal struct RequestPlayersForGameFinalResultCallback_t : ICallbackData // TypeDefIndex: 5352
{	// Fields
	internal Result Result; // 0x0
	internal ulong LSearchID; // 0x8
	internal ulong LUniqueGameID; // 0x10
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1D78B0 Offset: 0x1D6CB0 VA: 0x1801D78B0 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1D78A0 Offset: 0x1D6CA0 VA: 0x1801D78A0 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x12893B0 Offset: 0x12887B0 VA: 0x1812893B0
	private static void .cctor() { }

}

