internal struct MicroTxnAuthorizationResponse_t : ICallbackData // TypeDefIndex: 5300
{	// Fields
	internal uint AppID; // 0x0
	internal ulong OrderID; // 0x8
	internal byte Authorized; // 0x10
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1EB7C0 Offset: 0x1EABC0 VA: 0x1801EB7C0 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1EB7B0 Offset: 0x1EABB0 VA: 0x1801EB7B0 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x136E910 Offset: 0x136DD10 VA: 0x18136E910
	private static void .cctor() { }

}

