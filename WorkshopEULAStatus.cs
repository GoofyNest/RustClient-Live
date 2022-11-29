internal struct WorkshopEULAStatus_t : ICallbackData // TypeDefIndex: 5454
{
	internal Result Result; 
	internal AppId AppID; 
	internal uint Version; 
	internal uint TAction; 
	internal bool Accepted; 
	internal bool NeedsAction; 
	public static int _datasize; 

	public int DataSize { get; }
	public CallbackType CallbackType { get; }


	public int get_DataSize() { }

	public CallbackType get_CallbackType() { }

	private static void .cctor() { }

}

