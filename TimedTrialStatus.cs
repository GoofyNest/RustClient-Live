internal struct TimedTrialStatus_t : ICallbackData // TypeDefIndex: 5411
{
	internal AppId AppID;
	internal bool IsOffline;
	internal uint SecondsAllowed;
	internal uint SecondsPlayed;
	public static int _datasize;

	public int DataSize { get; }
	public CallbackType CallbackType { get; }


	public int get_DataSize() { }

	public CallbackType get_CallbackType() { }

	private static void .cctor() { }

}

