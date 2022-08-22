internal struct FavoritesListChanged_t : ICallbackData // TypeDefIndex: 5335
{	internal uint IP; // 0x0
	internal uint QueryPort; // 0x4
	internal uint ConnPort; // 0x8
	internal uint AppID; // 0xC
	internal uint Flags; // 0x10
	internal bool Add; // 0x14
	internal uint AccountId; // 0x18
	public static int _datasize; // 0x0

	public int DataSize { get; }
	public CallbackType CallbackType { get; }


	public int get_DataSize() { }

	public CallbackType get_CallbackType() { }

	private static void .cctor() { }

}

