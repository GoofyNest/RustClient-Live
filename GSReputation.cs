internal struct GSReputation_t : ICallbackData // TypeDefIndex: 5497
{
	internal Result Result; 
	internal uint ReputationScore; 
	internal bool Banned; 
	internal uint BannedIP; 
	internal ushort BannedPort; 
	internal ulong BannedGameID; 
	internal uint BanExpires; 
	public static int _datasize; 

	public int DataSize { get; }
	public CallbackType CallbackType { get; }


	public int get_DataSize() { }

	public CallbackType get_CallbackType() { }

	private static void .cctor() { }

}

