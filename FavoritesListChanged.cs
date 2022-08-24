internal struct FavoritesListChanged_t : ICallbackData // TypeDefIndex: 5335
{
	internal uint IP; 
	internal uint QueryPort; 
	internal uint ConnPort; 
	internal uint AppID; 
	internal uint Flags; 
	internal bool Add; 
	internal uint AccountId; 
	public static int _datasize; 

	public int DataSize { get; }
	public CallbackType CallbackType { get; }


	public int get_DataSize() { }

	public CallbackType get_CallbackType() { }

	private static void .cctor() { }

}

