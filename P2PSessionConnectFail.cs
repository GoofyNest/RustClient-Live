internal struct P2PSessionConnectFail_t : ICallbackData // TypeDefIndex: 5405
{	// Fields
	internal ulong SteamIDRemote; // 0x0
	internal byte P2PSessionError; // 0x8
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1EC250 Offset: 0x1EB650 VA: 0x1801EC250 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1EC240 Offset: 0x1EB640 VA: 0x1801EC240 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x136FE60 Offset: 0x136F260 VA: 0x18136FE60
	private static void .cctor() { }

}

