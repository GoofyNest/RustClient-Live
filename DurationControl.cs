internal struct DurationControl_t : ICallbackData // TypeDefIndex: 5306
{	internal Result Result; // 0x0
	internal AppId Appid; // 0x4
	internal bool Applicable; // 0x8
	internal int CsecsLast5h; // 0xC
	internal DurationControlProgress Progress; // 0x10
	internal DurationControlNotification Otification; // 0x14
	internal int CsecsToday; // 0x18
	internal int CsecsRemaining; // 0x1C
	public static int _datasize; // 0x0

	public int DataSize { get; }
	public CallbackType CallbackType { get; }


	public int get_DataSize() { }

	public CallbackType get_CallbackType() { }

	private static void .cctor() { }

}

public struct DurationControl // TypeDefIndex: 5549
{	internal DurationControl_t _inner; // 0x0

}

