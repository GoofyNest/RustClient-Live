internal struct UserAchievementStored_t : ICallbackData // TypeDefIndex: 5396
{
	internal ulong GameID;
	internal bool GroupAchievement;
	internal byte[] AchievementName;
	internal uint CurProgress;
	internal uint MaxProgress;
	public static int _datasize;

	public int DataSize { get; }
	public CallbackType CallbackType { get; }


	internal string AchievementNameUTF8() { }

	public int get_DataSize() { }

	public CallbackType get_CallbackType() { }

	private static void .cctor() { }

}

