internal struct FriendsGetFollowerCount_t : ICallbackData // TypeDefIndex: 5321
{
	internal Result Result; 
	internal ulong SteamID; 
	internal int Count; 
	public static int _datasize; 

	public int DataSize { get; }
	public CallbackType CallbackType { get; }


	public int get_DataSize() { }

	public CallbackType get_CallbackType() { }

	private static void .cctor() { }

}

