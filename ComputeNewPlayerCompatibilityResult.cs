internal struct ComputeNewPlayerCompatibilityResult_t : ICallbackData // TypeDefIndex: 5499
{	// Fields
	internal Result Result; // 0x0
	internal int CPlayersThatDontLikeCandidate; // 0x4
	internal int CPlayersThatCandidateDoesntLike; // 0x8
	internal int CClanPlayersThatDontLikeCandidate; // 0xC
	internal ulong SteamIDCandidate; // 0x10
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1E4600 Offset: 0x1E3A00 VA: 0x1801E4600 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1E45F0 Offset: 0x1E39F0 VA: 0x1801E45F0 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x1368DE0 Offset: 0x13681E0 VA: 0x181368DE0
	private static void .cctor() { }

}

