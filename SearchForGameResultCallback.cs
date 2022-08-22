internal struct SearchForGameResultCallback_t : ICallbackData // TypeDefIndex: 5348
{	internal ulong LSearchID; // 0x0
	internal Result Result; // 0x8
	internal int CountPlayersInGame; // 0xC
	internal int CountAcceptedGame; // 0x10
	internal ulong SteamIDHost; // 0x14
	internal bool FinalCallback; // 0x1C
	public static int _datasize; // 0x0

	public int DataSize { get; }
	public CallbackType CallbackType { get; }


	public int get_DataSize() { }

	public CallbackType get_CallbackType() { }

	private static void .cctor() { }

}

