internal struct SearchForGameResultCallback_t : ICallbackData // TypeDefIndex: 5348
{	// Fields
	internal ulong LSearchID; // 0x0
	internal Result Result; // 0x8
	internal int CountPlayersInGame; // 0xC
	internal int CountAcceptedGame; // 0x10
	internal ulong SteamIDHost; // 0x14
	internal bool FinalCallback; // 0x1C
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1D7CC0 Offset: 0x1D70C0 VA: 0x1801D7CC0 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1D7CB0 Offset: 0x1D70B0 VA: 0x1801D7CB0 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x1289830 Offset: 0x1288C30 VA: 0x181289830
	private static void .cctor() { }

}

