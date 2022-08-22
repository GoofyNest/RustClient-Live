internal struct WorkshopEULAStatus_t : ICallbackData // TypeDefIndex: 5448
{	internal Result Result; // 0x0
	internal AppId AppID; // 0x4
	internal uint Version; // 0x8
	internal uint TAction; // 0xC
	internal bool Accepted; // 0x10
	internal bool NeedsAction; // 0x11
	public static int _datasize; // 0x0

	public int DataSize { get; }
	public CallbackType CallbackType { get; }


	public int get_DataSize() { }

	public CallbackType get_CallbackType() { }

	private static void .cctor() { }

}

