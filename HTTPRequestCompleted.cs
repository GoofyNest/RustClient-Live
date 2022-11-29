internal struct HTTPRequestCompleted_t : ICallbackData // TypeDefIndex: 5430
{
	internal uint Request; 
	internal ulong ContextValue; 
	internal bool RequestSuccessful; 
	internal HTTPStatusCode StatusCode; 
	internal uint BodySize; 
	public static int _datasize; 

	public int DataSize { get; }
	public CallbackType CallbackType { get; }


	public int get_DataSize() { }

	public CallbackType get_CallbackType() { }

	private static void .cctor() { }

}

