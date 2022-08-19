internal struct HTTPRequestCompleted_t : ICallbackData // TypeDefIndex: 5424
{	// Fields
	internal uint Request; // 0x0
	internal ulong ContextValue; // 0x8
	internal bool RequestSuccessful; // 0x10
	internal HTTPStatusCode StatusCode; // 0x14
	internal uint BodySize; // 0x18
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1EA5D0 Offset: 0x1E99D0 VA: 0x1801EA5D0 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1EA5C0 Offset: 0x1E99C0 VA: 0x1801EA5C0 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x136D420 Offset: 0x136C820 VA: 0x18136D420
	private static void .cctor() { }

}

