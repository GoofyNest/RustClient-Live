internal enum RemoteStoragePublishedFileVisibility // TypeDefIndex: 5152
{	// Fields
	public int value__; // 0x0
	public const RemoteStoragePublishedFileVisibility Public = 0;
	public const RemoteStoragePublishedFileVisibility FriendsOnly = 1;
	public const RemoteStoragePublishedFileVisibility Private = 2;
	public const RemoteStoragePublishedFileVisibility Unlisted = 3;

}

internal struct RemoteStorageFileShareResult_t : ICallbackData // TypeDefIndex: 5361
{	// Fields
	internal Result Result; // 0x0
	internal ulong File; // 0x8
	internal byte[] Filename; // 0x10
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1D67F0 Offset: 0x1D5BF0 VA: 0x1801D67F0 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1D67E0 Offset: 0x1D5BE0 VA: 0x1801D67E0 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x12887B0 Offset: 0x1287BB0 VA: 0x1812887B0
	private static void .cctor() { }

}

internal struct RemoteStoragePublishFileResult_t : ICallbackData // TypeDefIndex: 5362
{	// Fields
	internal Result Result; // 0x0
	internal PublishedFileId PublishedFileId; // 0x8
	internal bool UserNeedsToAcceptWorkshopLegalAgreement; // 0x10
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1D7300 Offset: 0x1D6700 VA: 0x1801D7300 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1D72F0 Offset: 0x1D66F0 VA: 0x1801D72F0 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x1288B70 Offset: 0x1287F70 VA: 0x181288B70
	private static void .cctor() { }

}

internal struct RemoteStorageDeletePublishedFileResult_t : ICallbackData // TypeDefIndex: 5363
{	// Fields
	internal Result Result; // 0x0
	internal PublishedFileId PublishedFileId; // 0x8
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1D3000 Offset: 0x1D2400 VA: 0x1801D3000 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1D2FF0 Offset: 0x1D23F0 VA: 0x1801D2FF0 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x12882B0 Offset: 0x12876B0 VA: 0x1812882B0
	private static void .cctor() { }

}

internal struct RemoteStorageEnumerateUserPublishedFilesResult_t : ICallbackData // TypeDefIndex: 5364
{	// Fields
	internal Result Result; // 0x0
	internal int ResultsReturned; // 0x4
	internal int TotalResultCount; // 0x8
	internal PublishedFileId[] GPublishedFileId; // 0x10
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1D4050 Offset: 0x1D3450 VA: 0x1801D4050 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1D4040 Offset: 0x1D3440 VA: 0x1801D4040 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x1288490 Offset: 0x1287890 VA: 0x181288490
	private static void .cctor() { }

}

internal struct RemoteStorageSubscribePublishedFileResult_t : ICallbackData // TypeDefIndex: 5365
{	// Fields
	internal Result Result; // 0x0
	internal PublishedFileId PublishedFileId; // 0x8
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1D75A0 Offset: 0x1D69A0 VA: 0x1801D75A0 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1D7590 Offset: 0x1D6990 VA: 0x1801D7590 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x1288F50 Offset: 0x1288350 VA: 0x181288F50
	private static void .cctor() { }

}

internal struct RemoteStorageEnumerateUserSubscribedFilesResult_t : ICallbackData // TypeDefIndex: 5366
{	// Fields
	internal Result Result; // 0x0
	internal int ResultsReturned; // 0x4
	internal int TotalResultCount; // 0x8
	internal PublishedFileId[] GPublishedFileId; // 0x10
	internal uint[] GRTimeSubscribed; // 0x18
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1D4C00 Offset: 0x1D4000 VA: 0x1801D4C00 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1D4BF0 Offset: 0x1D3FF0 VA: 0x1801D4BF0 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x12885D0 Offset: 0x12879D0 VA: 0x1812885D0
	private static void .cctor() { }

}

internal struct RemoteStorageUnsubscribePublishedFileResult_t : ICallbackData // TypeDefIndex: 5367
{	// Fields
	internal Result Result; // 0x0
	internal PublishedFileId PublishedFileId; // 0x8
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1D7610 Offset: 0x1D6A10 VA: 0x1801D7610 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1D7600 Offset: 0x1D6A00 VA: 0x1801D7600 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x1288FF0 Offset: 0x12883F0 VA: 0x181288FF0
	private static void .cctor() { }

}

internal struct RemoteStorageUpdatePublishedFileResult_t : ICallbackData // TypeDefIndex: 5368
{	// Fields
	internal Result Result; // 0x0
	internal PublishedFileId PublishedFileId; // 0x8
	internal bool UserNeedsToAcceptWorkshopLegalAgreement; // 0x10
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1D7680 Offset: 0x1D6A80 VA: 0x1801D7680 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1D7670 Offset: 0x1D6A70 VA: 0x1801D7670 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x1289090 Offset: 0x1288490 VA: 0x181289090
	private static void .cctor() { }

}

internal struct RemoteStorageDownloadUGCResult_t : ICallbackData // TypeDefIndex: 5369
{	// Fields
	internal Result Result; // 0x0
	internal ulong File; // 0x8
	internal AppId AppID; // 0x10
	internal int SizeInBytes; // 0x14
	internal byte[] PchFileName; // 0x18
	internal ulong SteamIDOwner; // 0x20
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1D3070 Offset: 0x1D2470 VA: 0x1801D3070 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1D3060 Offset: 0x1D2460 VA: 0x1801D3060 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x1288350 Offset: 0x1287750 VA: 0x181288350
	private static void .cctor() { }

}

internal struct RemoteStorageGetPublishedFileDetailsResult_t : ICallbackData // TypeDefIndex: 5370
{	// Fields
	internal Result Result; // 0x0
	internal PublishedFileId PublishedFileId; // 0x8
	internal AppId CreatorAppID; // 0x10
	internal AppId ConsumerAppID; // 0x14
	internal byte[] Title; // 0x18
	internal byte[] Description; // 0x20
	internal ulong File; // 0x28
	internal ulong PreviewFile; // 0x30
	internal ulong SteamIDOwner; // 0x38
	internal uint TimeCreated; // 0x40
	internal uint TimeUpdated; // 0x44
	internal RemoteStoragePublishedFileVisibility Visibility; // 0x48
	internal bool Banned; // 0x4C
	internal byte[] Tags; // 0x50
	internal bool TagsTruncated; // 0x58
	internal byte[] PchFileName; // 0x60
	internal int FileSize; // 0x68
	internal int PreviewFileSize; // 0x6C
	internal byte[] URL; // 0x70
	internal WorkshopFileType FileType; // 0x78
	internal bool AcceptedForUse; // 0x7C
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1D6A40 Offset: 0x1D5E40 VA: 0x1801D6A40 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1D6A30 Offset: 0x1D5E30 VA: 0x1801D6A30 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x12888F0 Offset: 0x1287CF0 VA: 0x1812888F0
	private static void .cctor() { }

}

internal struct RemoteStorageEnumerateWorkshopFilesResult_t : ICallbackData // TypeDefIndex: 5371
{	// Fields
	internal Result Result; // 0x0
	internal int ResultsReturned; // 0x4
	internal int TotalResultCount; // 0x8
	internal PublishedFileId[] GPublishedFileId; // 0x10
	internal float[] GScore; // 0x18
	internal AppId AppId; // 0x20
	internal uint StartIndex; // 0x24
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1D59A0 Offset: 0x1D4DA0 VA: 0x1801D59A0 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1D5990 Offset: 0x1D4D90 VA: 0x1801D5990 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x1288670 Offset: 0x1287A70 VA: 0x181288670
	private static void .cctor() { }

}

internal struct RemoteStorageGetPublishedItemVoteDetailsResult_t : ICallbackData // TypeDefIndex: 5372
{	// Fields
	internal Result Result; // 0x0
	internal PublishedFileId PublishedFileId; // 0x8
	internal int VotesFor; // 0x10
	internal int VotesAgainst; // 0x14
	internal int Reports; // 0x18
	internal float FScore; // 0x1C
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1D71B0 Offset: 0x1D65B0 VA: 0x1801D71B0 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1D71A0 Offset: 0x1D65A0 VA: 0x1801D71A0 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x1288990 Offset: 0x1287D90 VA: 0x181288990
	private static void .cctor() { }

}

internal struct RemoteStoragePublishedFileSubscribed_t : ICallbackData // TypeDefIndex: 5373
{	// Fields
	internal PublishedFileId PublishedFileId; // 0x0
	internal AppId AppID; // 0x8
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1D73E0 Offset: 0x1D67E0 VA: 0x1801D73E0 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1D73D0 Offset: 0x1D67D0 VA: 0x1801D73D0 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x1288CB0 Offset: 0x12880B0 VA: 0x181288CB0
	private static void .cctor() { }

}

internal struct RemoteStoragePublishedFileUnsubscribed_t : ICallbackData // TypeDefIndex: 5374
{	// Fields
	internal PublishedFileId PublishedFileId; // 0x0
	internal AppId AppID; // 0x8
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1D7450 Offset: 0x1D6850 VA: 0x1801D7450 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1D7440 Offset: 0x1D6840 VA: 0x1801D7440 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x1288D60 Offset: 0x1288160 VA: 0x181288D60
	private static void .cctor() { }

}

internal struct RemoteStoragePublishedFileDeleted_t : ICallbackData // TypeDefIndex: 5375
{	// Fields
	internal PublishedFileId PublishedFileId; // 0x0
	internal AppId AppID; // 0x8
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1D7370 Offset: 0x1D6770 VA: 0x1801D7370 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1D7360 Offset: 0x1D6760 VA: 0x1801D7360 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x1288C10 Offset: 0x1288010 VA: 0x181288C10
	private static void .cctor() { }

}

internal struct RemoteStorageUpdateUserPublishedItemVoteResult_t : ICallbackData // TypeDefIndex: 5376
{	// Fields
	internal Result Result; // 0x0
	internal PublishedFileId PublishedFileId; // 0x8
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1D76F0 Offset: 0x1D6AF0 VA: 0x1801D76F0 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1D76E0 Offset: 0x1D6AE0 VA: 0x1801D76E0 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x1289130 Offset: 0x1288530 VA: 0x181289130
	private static void .cctor() { }

}

internal struct RemoteStorageUserVoteDetails_t : ICallbackData // TypeDefIndex: 5377
{	// Fields
	internal Result Result; // 0x0
	internal PublishedFileId PublishedFileId; // 0x8
	internal WorkshopVote Vote; // 0x10
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1D7760 Offset: 0x1D6B60 VA: 0x1801D7760 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1D7750 Offset: 0x1D6B50 VA: 0x1801D7750 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x12891D0 Offset: 0x12885D0 VA: 0x1812891D0
	private static void .cctor() { }

}

internal struct RemoteStorageEnumerateUserSharedWorkshopFilesResult_t : ICallbackData // TypeDefIndex: 5378
{	// Fields
	internal Result Result; // 0x0
	internal int ResultsReturned; // 0x4
	internal int TotalResultCount; // 0x8
	internal PublishedFileId[] GPublishedFileId; // 0x10
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1D47F0 Offset: 0x1D3BF0 VA: 0x1801D47F0 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1D47E0 Offset: 0x1D3BE0 VA: 0x1801D47E0 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x1288530 Offset: 0x1287930 VA: 0x181288530
	private static void .cctor() { }

}

internal struct RemoteStorageSetUserPublishedFileActionResult_t : ICallbackData // TypeDefIndex: 5379
{	// Fields
	internal Result Result; // 0x0
	internal PublishedFileId PublishedFileId; // 0x8
	internal WorkshopFileAction Action; // 0x10
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1D7530 Offset: 0x1D6930 VA: 0x1801D7530 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1D7520 Offset: 0x1D6920 VA: 0x1801D7520 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x1288EB0 Offset: 0x12882B0 VA: 0x181288EB0
	private static void .cctor() { }

}

internal struct RemoteStorageEnumeratePublishedFilesByUserActionResult_t : ICallbackData // TypeDefIndex: 5380
{	// Fields
	internal Result Result; // 0x0
	internal WorkshopFileAction Action; // 0x4
	internal int ResultsReturned; // 0x8
	internal int TotalResultCount; // 0xC
	internal PublishedFileId[] GPublishedFileId; // 0x10
	internal uint[] GRTimeUpdated; // 0x18
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1D3290 Offset: 0x1D2690 VA: 0x1801D3290 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1D3280 Offset: 0x1D2680 VA: 0x1801D3280 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x12883F0 Offset: 0x12877F0 VA: 0x1812883F0
	private static void .cctor() { }

}

internal struct RemoteStoragePublishFileProgress_t : ICallbackData // TypeDefIndex: 5381
{	// Fields
	internal double DPercentFile; // 0x0
	internal bool Preview; // 0x8
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1D7290 Offset: 0x1D6690 VA: 0x1801D7290 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1D7280 Offset: 0x1D6680 VA: 0x1801D7280 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x1288AD0 Offset: 0x1287ED0 VA: 0x181288AD0
	private static void .cctor() { }

}

internal struct RemoteStoragePublishedFileUpdated_t : ICallbackData // TypeDefIndex: 5382
{	// Fields
	internal PublishedFileId PublishedFileId; // 0x0
	internal AppId AppID; // 0x8
	internal ulong Unused; // 0x10
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1D74C0 Offset: 0x1D68C0 VA: 0x1801D74C0 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1D74B0 Offset: 0x1D68B0 VA: 0x1801D74B0 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x1288E10 Offset: 0x1288210 VA: 0x181288E10
	private static void .cctor() { }

}

internal struct RemoteStorageFileWriteAsyncComplete_t : ICallbackData // TypeDefIndex: 5383
{	// Fields
	internal Result Result; // 0x0
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1D69D0 Offset: 0x1D5DD0 VA: 0x1801D69D0 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1D69C0 Offset: 0x1D5DC0 VA: 0x1801D69C0 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x1288850 Offset: 0x1287C50 VA: 0x181288850
	private static void .cctor() { }

}

internal struct RemoteStorageFileReadAsyncComplete_t : ICallbackData // TypeDefIndex: 5384
{	// Fields
	internal ulong FileReadAsync; // 0x0
	internal Result Result; // 0x8
	internal uint Offset; // 0xC
	internal uint Read; // 0x10
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1D6780 Offset: 0x1D5B80 VA: 0x1801D6780 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1D6770 Offset: 0x1D5B70 VA: 0x1801D6770 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x1288710 Offset: 0x1287B10 VA: 0x181288710
	private static void .cctor() { }

}

internal struct RemoteStorageLocalFileChange_t : ICallbackData // TypeDefIndex: 5385
{	// Fields
	public static int _datasize; // 0x2B0AA90

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1D7220 Offset: 0x1D6620 VA: 0x1801D7220 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1D7210 Offset: 0x1D6610 VA: 0x1801D7210 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x1288A30 Offset: 0x1287E30 VA: 0x181288A30
	private static void .cctor() { }

}

