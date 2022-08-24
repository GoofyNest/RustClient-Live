internal struct GSClientGroupStatus_t : ICallbackData // TypeDefIndex: 5496
{
	internal ulong SteamIDUser; 
	internal ulong SteamIDGroup; 
	internal bool Member; 
	internal bool Officer; 
	public static int _datasize; 

	public int DataSize { get; }
	public CallbackType CallbackType { get; }


	public int get_DataSize() { }

	public CallbackType get_CallbackType() { }

	private static void .cctor() { }

}

