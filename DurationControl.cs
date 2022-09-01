internal struct DurationControl_t : ICallbackData // TypeDefIndex: 5307
{
	internal Result Result; 
	internal AppId Appid; 
	internal bool Applicable; 
	internal int CsecsLast5h; 
	internal DurationControlProgress Progress; 
	internal DurationControlNotification Otification; 
	internal int CsecsToday; 
	internal int CsecsRemaining; 
	public static int _datasize; 

	public int DataSize { get; }
	public CallbackType CallbackType { get; }


	public int get_DataSize() { }

	public CallbackType get_CallbackType() { }

	private static void .cctor() { }

}

public struct DurationControl // TypeDefIndex: 5550
{
	internal DurationControl_t _inner; 

}

