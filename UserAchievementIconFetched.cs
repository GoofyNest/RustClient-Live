internal struct UserAchievementIconFetched_t : ICallbackData // TypeDefIndex: 5395
{
	internal GameId GameID; 
	internal byte[] AchievementName; 
	internal bool Achieved; 
	internal int IconHandle; 
	public static int _datasize; 

	public int DataSize { get; }
	public CallbackType CallbackType { get; }


	internal string AchievementNameUTF8() { }

	public int get_DataSize() { }

	public CallbackType get_CallbackType() { }

	private static void .cctor() { }

}

