internal struct FriendsIsFollowing_t : ICallbackData // TypeDefIndex: 5328
{
	internal Result Result;
	internal ulong SteamID;
	internal bool IsFollowing;
	public static int _datasize;

	public int DataSize { get; }
	public CallbackType CallbackType { get; }


	public int get_DataSize() { }

	public CallbackType get_CallbackType() { }

	private static void .cctor() { }

}

