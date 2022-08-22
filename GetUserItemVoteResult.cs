internal struct GetUserItemVoteResult_t : ICallbackData // TypeDefIndex: 5438
{	internal PublishedFileId PublishedFileId; // 0x0
	internal Result Result; // 0x8
	internal bool VotedUp; // 0xC
	internal bool VotedDown; // 0xD
	internal bool VoteSkipped; // 0xE
	public static int _datasize; // 0x0

	public int DataSize { get; }
	public CallbackType CallbackType { get; }


	public int get_DataSize() { }

	public CallbackType get_CallbackType() { }

	private static void .cctor() { }

}

