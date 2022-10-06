internal struct UserStatsReceived_t : ICallbackData // TypeDefIndex: 5390
{
	internal ulong GameID; 
	internal Result Result; 
	internal ulong SteamIDUser; 
	public static int _datasize; 

	public int DataSize { get; }
	public CallbackType CallbackType { get; }


	public int get_DataSize() { }

	public CallbackType get_CallbackType() { }

	private static void .cctor() { }

}

