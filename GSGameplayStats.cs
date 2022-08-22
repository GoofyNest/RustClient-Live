internal struct GSGameplayStats_t : ICallbackData // TypeDefIndex: 5495
{	internal Result Result; // 0x0
	internal int Rank; // 0x4
	internal uint TotalConnects; // 0x8
	internal uint TotalMinutesPlayed; // 0xC
	public static int _datasize; // 0x0

	public int DataSize { get; }
	public CallbackType CallbackType { get; }


	public int get_DataSize() { }

	public CallbackType get_CallbackType() { }

	private static void .cctor() { }

}

