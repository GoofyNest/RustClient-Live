internal struct FriendsIsFollowing_t : ICallbackData // TypeDefIndex: 5322
{	internal Result Result; // 0x0
	internal ulong SteamID; // 0x4
	internal bool IsFollowing; // 0xC
	public static int _datasize; // 0x0

	public int DataSize { get; }
	public CallbackType CallbackType { get; }


	public int get_DataSize() { }

	public CallbackType get_CallbackType() { }

	private static void .cctor() { }

}

