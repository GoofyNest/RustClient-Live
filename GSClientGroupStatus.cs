internal struct GSClientGroupStatus_t : ICallbackData // TypeDefIndex: 5496
{	internal ulong SteamIDUser; // 0x0
	internal ulong SteamIDGroup; // 0x8
	internal bool Member; // 0x10
	internal bool Officer; // 0x11
	public static int _datasize; // 0x0

	public int DataSize { get; }
	public CallbackType CallbackType { get; }


	public int get_DataSize() { }

	public CallbackType get_CallbackType() { }

	private static void .cctor() { }

}

