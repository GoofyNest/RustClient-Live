internal struct GameServerChangeRequested_t : ICallbackData // TypeDefIndex: 5310
{
	internal byte[] Server; 
	internal byte[] Password; 
	public static int _datasize; 

	public int DataSize { get; }
	public CallbackType CallbackType { get; }


	internal string ServerUTF8() { }

	internal string PasswordUTF8() { }

	public int get_DataSize() { }

	public CallbackType get_CallbackType() { }

	private static void .cctor() { }

}

