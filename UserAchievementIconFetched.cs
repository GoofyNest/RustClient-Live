internal struct UserAchievementIconFetched_t : ICallbackData // TypeDefIndex: 5394
{	// Fields
	internal GameId GameID; // 0x0
	internal byte[] AchievementName; // 0x8
	internal bool Achieved; // 0x10
	internal int IconHandle; // 0x14
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1DB330 Offset: 0x1DA730 VA: 0x1801DB330
	internal string AchievementNameUTF8() { }

	// RVA: 0x1DB3C0 Offset: 0x1DA7C0 VA: 0x1801DB3C0 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1DB3B0 Offset: 0x1DA7B0 VA: 0x1801DB3B0 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x128C500 Offset: 0x128B900 VA: 0x18128C500
	private static void .cctor() { }

}

