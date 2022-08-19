internal struct LowBatteryPower_t : ICallbackData // TypeDefIndex: 5328
{	// Fields
	internal byte MinutesBatteryLeft; // 0x0
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1EB650 Offset: 0x1EAA50 VA: 0x1801EB650 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1EB640 Offset: 0x1EAA40 VA: 0x1801EB640 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x136E7C0 Offset: 0x136DBC0 VA: 0x18136E7C0
	private static void .cctor() { }

}

