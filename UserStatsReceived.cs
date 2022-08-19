internal struct UserStatsReceived_t : ICallbackData // TypeDefIndex: 5386
{	// Fields
	internal ulong GameID; // 0x0
	internal Result Result; // 0x8
	internal ulong SteamIDUser; // 0xC
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1DC5E0 Offset: 0x1DB9E0 VA: 0x1801DC5E0 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1DC5D0 Offset: 0x1DB9D0 VA: 0x1801DC5D0 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x128C780 Offset: 0x128BB80 VA: 0x18128C780
	private static void .cctor() { }

}

