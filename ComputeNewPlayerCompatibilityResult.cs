internal struct ComputeNewPlayerCompatibilityResult_t : ICallbackData // TypeDefIndex: 5499
{	internal Result Result; // 0x0
	internal int CPlayersThatDontLikeCandidate; // 0x4
	internal int CPlayersThatCandidateDoesntLike; // 0x8
	internal int CClanPlayersThatDontLikeCandidate; // 0xC
	internal ulong SteamIDCandidate; // 0x10
	public static int _datasize; // 0x0

	public int DataSize { get; }
	public CallbackType CallbackType { get; }


	public int get_DataSize() { }

	public CallbackType get_CallbackType() { }

	private static void .cctor() { }

}

