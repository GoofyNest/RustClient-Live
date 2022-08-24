internal struct ValidateAuthTicketResponse_t : ICallbackData // TypeDefIndex: 5299
{
	internal ulong SteamID; 
	internal AuthResponse AuthSessionResponse; 
	internal ulong OwnerSteamID; 
	public static int _datasize; 

	public int DataSize { get; }
	public CallbackType CallbackType { get; }


	public int get_DataSize() { }

	public CallbackType get_CallbackType() { }

	private static void .cctor() { }

}

