internal struct GetUserItemVoteResult_t : ICallbackData // TypeDefIndex: 5439
{
	internal PublishedFileId PublishedFileId; 
	internal Result Result; 
	internal bool VotedUp; 
	internal bool VotedDown; 
	internal bool VoteSkipped; 
	public static int _datasize; 

	public int DataSize { get; }
	public CallbackType CallbackType { get; }


	public int get_DataSize() { }

	public CallbackType get_CallbackType() { }

	private static void .cctor() { }

}

