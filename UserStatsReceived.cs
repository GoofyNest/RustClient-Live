internal struct UserStatsReceived_t : ICallbackData // TypeDefIndex: 5386
{	internal ulong GameID; // 0x0
	internal Result Result; // 0x8
	internal ulong SteamIDUser; // 0xC
	public static int _datasize; // 0x0

	public int DataSize { get; }
	public CallbackType CallbackType { get; }


	public int get_DataSize() { }

	public CallbackType get_CallbackType() { }

	private static void .cctor() { }

}

