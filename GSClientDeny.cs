internal struct GSClientDeny_t : ICallbackData // TypeDefIndex: 5491
{	internal ulong SteamID; // 0x0
	internal DenyReason DenyReason; // 0x8
	internal byte[] OptionalText; // 0x10
	public static int _datasize; // 0x0

	public int DataSize { get; }
	public CallbackType CallbackType { get; }


	public int get_DataSize() { }

	public CallbackType get_CallbackType() { }

	private static void .cctor() { }

}

