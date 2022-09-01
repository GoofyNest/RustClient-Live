internal struct AvatarImageLoaded_t : ICallbackData // TypeDefIndex: 5312
{
	internal ulong SteamID; 
	internal int Image; 
	internal int Wide; 
	internal int Tall; 
	public static int _datasize; 

	public int DataSize { get; }
	public CallbackType CallbackType { get; }


	public int get_DataSize() { }

	public CallbackType get_CallbackType() { }

	private static void .cctor() { }

}

