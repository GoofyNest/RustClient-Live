internal struct HTTPRequestDataReceived_t : ICallbackData // TypeDefIndex: 5426
{	// Fields
	internal uint Request; // 0x0
	internal ulong ContextValue; // 0x8
	internal uint COffset; // 0x10
	internal uint CBytesReceived; // 0x14
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1EA640 Offset: 0x1E9A40 VA: 0x1801EA640 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1EA630 Offset: 0x1E9A30 VA: 0x1801EA630 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x136D4C0 Offset: 0x136C8C0 VA: 0x18136D4C0
	private static void .cctor() { }

}

