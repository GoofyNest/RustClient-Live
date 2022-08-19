internal struct SearchForGameProgressCallback_t : ICallbackData // TypeDefIndex: 5347
{	// Fields
	internal ulong LSearchID; // 0x0
	internal Result Result; // 0x8
	internal ulong LobbyID; // 0xC
	internal ulong SteamIDEndedSearch; // 0x14
	internal int SecondsRemainingEstimate; // 0x1C
	internal int CPlayersSearching; // 0x20
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1D7C50 Offset: 0x1D7050 VA: 0x1801D7C50 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1D7C40 Offset: 0x1D7040 VA: 0x1801D7C40 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x1289790 Offset: 0x1288B90 VA: 0x181289790
	private static void .cctor() { }

}

