internal struct ValidateAuthTicketResponse_t : ICallbackData // TypeDefIndex: 5299
{	// Fields
	internal ulong SteamID; // 0x0
	internal AuthResponse AuthSessionResponse; // 0x8
	internal ulong OwnerSteamID; // 0xC
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1DC7A0 Offset: 0x1DBBA0 VA: 0x1801DC7A0 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1DC790 Offset: 0x1DBB90 VA: 0x1801DC790 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x128CA30 Offset: 0x128BE30 VA: 0x18128CA30
	private static void .cctor() { }

}

