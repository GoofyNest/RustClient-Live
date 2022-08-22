internal struct GSReputation_t : ICallbackData // TypeDefIndex: 5497
{	internal Result Result; // 0x0
	internal uint ReputationScore; // 0x4
	internal bool Banned; // 0x8
	internal uint BannedIP; // 0xC
	internal ushort BannedPort; // 0x10
	internal ulong BannedGameID; // 0x18
	internal uint BanExpires; // 0x20
	public static int _datasize; // 0x0

	public int DataSize { get; }
	public CallbackType CallbackType { get; }


	public int get_DataSize() { }

	public CallbackType get_CallbackType() { }

	private static void .cctor() { }

}

