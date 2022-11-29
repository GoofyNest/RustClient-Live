internal struct PersonaStateChange_t : ICallbackData // TypeDefIndex: 5313
{
	internal ulong SteamID; 
	internal int ChangeFlags; 
	public static int _datasize; 

	public int DataSize { get; }
	public CallbackType CallbackType { get; }


	public int get_DataSize() { }

	public CallbackType get_CallbackType() { }

	private static void .cctor() { }

}

