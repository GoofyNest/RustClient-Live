internal struct GetUserItemVoteResult_t : ICallbackData // TypeDefIndex: 5438
{	// Fields
	internal PublishedFileId PublishedFileId; // 0x0
	internal Result Result; // 0x8
	internal bool VotedUp; // 0xC
	internal bool VotedDown; // 0xD
	internal bool VoteSkipped; // 0xE
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1E9080 Offset: 0x1E8480 VA: 0x1801E9080 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1E9070 Offset: 0x1E8470 VA: 0x1801E9070 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x136C320 Offset: 0x136B720 VA: 0x18136C320
	private static void .cctor() { }

}

