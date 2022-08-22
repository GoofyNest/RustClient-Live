internal struct UserAchievementIconFetched_t : ICallbackData // TypeDefIndex: 5394
{	internal GameId GameID; // 0x0
	internal byte[] AchievementName; // 0x8
	internal bool Achieved; // 0x10
	internal int IconHandle; // 0x14
	public static int _datasize; // 0x0

	public int DataSize { get; }
	public CallbackType CallbackType { get; }


	internal string AchievementNameUTF8() { }

	public int get_DataSize() { }

	public CallbackType get_CallbackType() { }

	private static void .cctor() { }

}

