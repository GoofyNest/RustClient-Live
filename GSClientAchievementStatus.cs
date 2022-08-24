internal struct GSClientAchievementStatus_t : ICallbackData // TypeDefIndex: 5493
{
	internal ulong SteamID; 
	internal byte[] PchAchievement; 
	internal bool Unlocked; 
	public static int _datasize; 

	public int DataSize { get; }
	public CallbackType CallbackType { get; }


	public int get_DataSize() { }

	public CallbackType get_CallbackType() { }

	private static void .cctor() { }

}

