internal struct GSGameplayStats_t : ICallbackData // TypeDefIndex: 5495
{
	internal Result Result; 
	internal int Rank; 
	internal uint TotalConnects; 
	internal uint TotalMinutesPlayed; 
	public static int _datasize; 

	public int DataSize { get; }
	public CallbackType CallbackType { get; }


	public int get_DataSize() { }

	public CallbackType get_CallbackType() { }

	private static void .cctor() { }

}

