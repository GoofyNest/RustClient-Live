internal struct TimedTrialStatus_t : ICallbackData // TypeDefIndex: 5403
{	// Fields
	internal AppId AppID; // 0x0
	internal bool IsOffline; // 0x4
	internal uint SecondsAllowed; // 0x8
	internal uint SecondsPlayed; // 0xC
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1DAFD0 Offset: 0x1DA3D0 VA: 0x1801DAFD0 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1DAFC0 Offset: 0x1DA3C0 VA: 0x1801DAFC0 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x128BC00 Offset: 0x128B000 VA: 0x18128BC00
	private static void .cctor() { }

}

