internal struct ComputeNewPlayerCompatibilityResult_t : ICallbackData // TypeDefIndex: 5499
{
	internal Result Result; 
	internal int CPlayersThatDontLikeCandidate; 
	internal int CPlayersThatCandidateDoesntLike; 
	internal int CClanPlayersThatDontLikeCandidate; 
	internal ulong SteamIDCandidate; 
	public static int _datasize; 

	public int DataSize { get; }
	public CallbackType CallbackType { get; }


	public int get_DataSize() { }

	public CallbackType get_CallbackType() { }

	private static void .cctor() { }

}

