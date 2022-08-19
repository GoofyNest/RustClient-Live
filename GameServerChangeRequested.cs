internal struct GameServerChangeRequested_t : ICallbackData // TypeDefIndex: 5309
{	// Fields
	internal byte[] Server; // 0x0
	internal byte[] Password; // 0x8
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1E7C70 Offset: 0x1E7070 VA: 0x1801E7C70
	internal string ServerUTF8() { }

	// RVA: 0x1E7BF0 Offset: 0x1E6FF0 VA: 0x1801E7BF0
	internal string PasswordUTF8() { }

	// RVA: 0x1E7D00 Offset: 0x1E7100 VA: 0x1801E7D00 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1E7CF0 Offset: 0x1E70F0 VA: 0x1801E7CF0 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x136BEA0 Offset: 0x136B2A0 VA: 0x18136BEA0
	private static void .cctor() { }

}

