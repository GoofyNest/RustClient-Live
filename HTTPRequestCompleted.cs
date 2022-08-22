internal struct HTTPRequestCompleted_t : ICallbackData // TypeDefIndex: 5424
{	internal uint Request; // 0x0
	internal ulong ContextValue; // 0x8
	internal bool RequestSuccessful; // 0x10
	internal HTTPStatusCode StatusCode; // 0x14
	internal uint BodySize; // 0x18
	public static int _datasize; // 0x0

	public int DataSize { get; }
	public CallbackType CallbackType { get; }


	public int get_DataSize() { }

	public CallbackType get_CallbackType() { }

	private static void .cctor() { }

}

