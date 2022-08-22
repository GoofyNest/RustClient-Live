internal struct HTTPRequestDataReceived_t : ICallbackData // TypeDefIndex: 5426
{	internal uint Request; // 0x0
	internal ulong ContextValue; // 0x8
	internal uint COffset; // 0x10
	internal uint CBytesReceived; // 0x14
	public static int _datasize; // 0x0

	public int DataSize { get; }
	public CallbackType CallbackType { get; }


	public int get_DataSize() { }

	public CallbackType get_CallbackType() { }

	private static void .cctor() { }

}

