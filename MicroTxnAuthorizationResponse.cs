internal struct MicroTxnAuthorizationResponse_t : ICallbackData // TypeDefIndex: 5300
{	internal uint AppID; // 0x0
	internal ulong OrderID; // 0x8
	internal byte Authorized; // 0x10
	public static int _datasize; // 0x0

	public int DataSize { get; }
	public CallbackType CallbackType { get; }


	public int get_DataSize() { }

	public CallbackType get_CallbackType() { }

	private static void .cctor() { }

}

