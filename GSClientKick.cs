internal struct GSClientKick_t : ICallbackData // TypeDefIndex: 5500
{
	internal ulong SteamID;
	internal DenyReason DenyReason;
	public static int _datasize;

	public int DataSize { get; }
	public CallbackType CallbackType { get; }


	public int get_DataSize() { }

	public CallbackType get_CallbackType() { }

	private static void .cctor() { }

}

