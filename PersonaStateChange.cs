internal struct PersonaStateChange_t : ICallbackData // TypeDefIndex: 5307
{	// Fields
	internal ulong SteamID; // 0x0
	internal int ChangeFlags; // 0x8
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1EC410 Offset: 0x1EB810 VA: 0x1801EC410 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1EC400 Offset: 0x1EB800 VA: 0x1801EC400 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x1370060 Offset: 0x136F460 VA: 0x181370060
	private static void .cctor() { }

}

