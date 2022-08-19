internal struct JoinPartyCallback_t : ICallbackData // TypeDefIndex: 5355
{	// Fields
	internal Result Result; // 0x0
	internal ulong BeaconID; // 0x8
	internal ulong SteamIDBeaconOwner; // 0x10
	internal byte[] ConnectString; // 0x18
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1EAE60 Offset: 0x1EA260 VA: 0x1801EAE60 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1EAE50 Offset: 0x1EA250 VA: 0x1801EAE50 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x136DDD0 Offset: 0x136D1D0 VA: 0x18136DDD0
	private static void .cctor() { }

}

