internal struct GSClientAchievementStatus_t : ICallbackData // TypeDefIndex: 5493
{	// Fields
	internal ulong SteamID; // 0x0
	internal byte[] PchAchievement; // 0x8
	internal bool Unlocked; // 0x10
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1E62C0 Offset: 0x1E56C0 VA: 0x1801E62C0 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1E62B0 Offset: 0x1E56B0 VA: 0x1801E62B0 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x136B230 Offset: 0x136A630 VA: 0x18136B230
	private static void .cctor() { }

}

