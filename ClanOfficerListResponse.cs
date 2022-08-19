internal struct ClanOfficerListResponse_t : ICallbackData // TypeDefIndex: 5312
{	// Fields
	internal ulong SteamIDClan; // 0x0
	internal int COfficers; // 0x8
	internal byte Success; // 0xC
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1E4520 Offset: 0x1E3920 VA: 0x1801E4520 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1E4510 Offset: 0x1E3910 VA: 0x1801E4510 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x1368C90 Offset: 0x1368090 VA: 0x181368C90
	private static void .cctor() { }

}

