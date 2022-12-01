internal struct HTTPRequestDataReceived_t : ICallbackData // TypeDefIndex: 5434
{
	internal uint Request;
	internal ulong ContextValue;
	internal uint COffset;
	internal uint CBytesReceived;
	public static int _datasize;

	public int DataSize { get; }
	public CallbackType CallbackType { get; }


	public int get_DataSize() { }

	public CallbackType get_CallbackType() { }

	private static void .cctor() { }

}

