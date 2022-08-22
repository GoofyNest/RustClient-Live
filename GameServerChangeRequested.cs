internal struct GameServerChangeRequested_t : ICallbackData // TypeDefIndex: 5309
{	internal byte[] Server; // 0x0
	internal byte[] Password; // 0x8
	public static int _datasize; // 0x0

	public int DataSize { get; }
	public CallbackType CallbackType { get; }


	internal string ServerUTF8() { }

	internal string PasswordUTF8() { }

	public int get_DataSize() { }

	public CallbackType get_CallbackType() { }

	private static void .cctor() { }

}

