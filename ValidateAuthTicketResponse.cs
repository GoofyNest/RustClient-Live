internal struct ValidateAuthTicketResponse_t : ICallbackData // TypeDefIndex: 5299
{	internal ulong SteamID; // 0x0
	internal AuthResponse AuthSessionResponse; // 0x8
	internal ulong OwnerSteamID; // 0xC
	public static int _datasize; // 0x0

	public int DataSize { get; }
	public CallbackType CallbackType { get; }


	public int get_DataSize() { }

	public CallbackType get_CallbackType() { }

	private static void .cctor() { }

}

