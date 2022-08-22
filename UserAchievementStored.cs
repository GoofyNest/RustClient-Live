internal struct UserAchievementStored_t : ICallbackData // TypeDefIndex: 5388
{	internal ulong GameID; // 0x0
	internal bool GroupAchievement; // 0x8
	internal byte[] AchievementName; // 0x10
	internal uint CurProgress; // 0x18
	internal uint MaxProgress; // 0x1C
	public static int _datasize; // 0x0

	public int DataSize { get; }
	public CallbackType CallbackType { get; }


	internal string AchievementNameUTF8() { }

	public int get_DataSize() { }

	public CallbackType get_CallbackType() { }

	private static void .cctor() { }

}

