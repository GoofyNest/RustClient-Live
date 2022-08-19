internal struct UserAchievementStored_t : ICallbackData // TypeDefIndex: 5388
{	// Fields
	internal ulong GameID; // 0x0
	internal bool GroupAchievement; // 0x8
	internal byte[] AchievementName; // 0x10
	internal uint CurProgress; // 0x18
	internal uint MaxProgress; // 0x1C
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1DBC40 Offset: 0x1DB040 VA: 0x1801DBC40
	internal string AchievementNameUTF8() { }

	// RVA: 0x1DBCD0 Offset: 0x1DB0D0 VA: 0x1801DBCD0 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1DBCC0 Offset: 0x1DB0C0 VA: 0x1801DBCC0 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x128C630 Offset: 0x128BA30 VA: 0x18128C630
	private static void .cctor() { }

}

