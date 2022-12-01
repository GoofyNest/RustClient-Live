internal enum RemoteStoragePublishedFileVisibility // TypeDefIndex: 5158
{
	public int value__;
	public const RemoteStoragePublishedFileVisibility Public = 0;
	public const RemoteStoragePublishedFileVisibility FriendsOnly = 1;
	public const RemoteStoragePublishedFileVisibility Private = 2;
	public const RemoteStoragePublishedFileVisibility Unlisted = 3;

}

internal struct RemoteStorageFileShareResult_t : ICallbackData // TypeDefIndex: 5369
{
	internal Result Result;
	internal ulong File;
	internal byte[] Filename;
	public static int _datasize;

	public int DataSize { get; }
	public CallbackType CallbackType { get; }


	public int get_DataSize() { }

	public CallbackType get_CallbackType() { }

	private static void .cctor() { }

}

internal struct RemoteStoragePublishFileResult_t : ICallbackData // TypeDefIndex: 5370
{
	internal Result Result;
	internal PublishedFileId PublishedFileId;
	internal bool UserNeedsToAcceptWorkshopLegalAgreement;
	public static int _datasize;

	public int DataSize { get; }
	public CallbackType CallbackType { get; }


	public int get_DataSize() { }

	public CallbackType get_CallbackType() { }

	private static void .cctor() { }

}

internal struct RemoteStorageDeletePublishedFileResult_t : ICallbackData // TypeDefIndex: 5371
{
	internal Result Result;
	internal PublishedFileId PublishedFileId;
	public static int _datasize;

	public int DataSize { get; }
	public CallbackType CallbackType { get; }


	public int get_DataSize() { }

	public CallbackType get_CallbackType() { }

	private static void .cctor() { }

}

internal struct RemoteStorageEnumerateUserPublishedFilesResult_t : ICallbackData // TypeDefIndex: 5372
{
	internal Result Result;
	internal int ResultsReturned;
	internal int TotalResultCount;
	internal PublishedFileId[] GPublishedFileId;
	public static int _datasize;

	public int DataSize { get; }
	public CallbackType CallbackType { get; }


	public int get_DataSize() { }

	public CallbackType get_CallbackType() { }

	private static void .cctor() { }

}

internal struct RemoteStorageSubscribePublishedFileResult_t : ICallbackData // TypeDefIndex: 5373
{
	internal Result Result;
	internal PublishedFileId PublishedFileId;
	public static int _datasize;

	public int DataSize { get; }
	public CallbackType CallbackType { get; }


	public int get_DataSize() { }

	public CallbackType get_CallbackType() { }

	private static void .cctor() { }

}

internal struct RemoteStorageEnumerateUserSubscribedFilesResult_t : ICallbackData // TypeDefIndex: 5374
{
	internal Result Result;
	internal int ResultsReturned;
	internal int TotalResultCount;
	internal PublishedFileId[] GPublishedFileId;
	internal uint[] GRTimeSubscribed;
	public static int _datasize;

	public int DataSize { get; }
	public CallbackType CallbackType { get; }


	public int get_DataSize() { }

	public CallbackType get_CallbackType() { }

	private static void .cctor() { }

}

internal struct RemoteStorageUnsubscribePublishedFileResult_t : ICallbackData // TypeDefIndex: 5375
{
	internal Result Result;
	internal PublishedFileId PublishedFileId;
	public static int _datasize;

	public int DataSize { get; }
	public CallbackType CallbackType { get; }


	public int get_DataSize() { }

	public CallbackType get_CallbackType() { }

	private static void .cctor() { }

}

internal struct RemoteStorageUpdatePublishedFileResult_t : ICallbackData // TypeDefIndex: 5376
{
	internal Result Result;
	internal PublishedFileId PublishedFileId;
	internal bool UserNeedsToAcceptWorkshopLegalAgreement;
	public static int _datasize;

	public int DataSize { get; }
	public CallbackType CallbackType { get; }


	public int get_DataSize() { }

	public CallbackType get_CallbackType() { }

	private static void .cctor() { }

}

internal struct RemoteStorageDownloadUGCResult_t : ICallbackData // TypeDefIndex: 5377
{
	internal Result Result;
	internal ulong File;
	internal AppId AppID;
	internal int SizeInBytes;
	internal byte[] PchFileName;
	internal ulong SteamIDOwner;
	public static int _datasize;

	public int DataSize { get; }
	public CallbackType CallbackType { get; }


	public int get_DataSize() { }

	public CallbackType get_CallbackType() { }

	private static void .cctor() { }

}

internal struct RemoteStorageGetPublishedFileDetailsResult_t : ICallbackData // TypeDefIndex: 5378
{
	internal Result Result;
	internal PublishedFileId PublishedFileId;
	internal AppId CreatorAppID;
	internal AppId ConsumerAppID;
	internal byte[] Title;
	internal byte[] Description;
	internal ulong File;
	internal ulong PreviewFile;
	internal ulong SteamIDOwner;
	internal uint TimeCreated;
	internal uint TimeUpdated;
	internal RemoteStoragePublishedFileVisibility Visibility;
	internal bool Banned;
	internal byte[] Tags;
	internal bool TagsTruncated;
	internal byte[] PchFileName;
	internal int FileSize;
	internal int PreviewFileSize;
	internal byte[] URL;
	internal WorkshopFileType FileType;
	internal bool AcceptedForUse;
	public static int _datasize;

	public int DataSize { get; }
	public CallbackType CallbackType { get; }


	public int get_DataSize() { }

	public CallbackType get_CallbackType() { }

	private static void .cctor() { }

}

internal struct RemoteStorageEnumerateWorkshopFilesResult_t : ICallbackData // TypeDefIndex: 5379
{
	internal Result Result;
	internal int ResultsReturned;
	internal int TotalResultCount;
	internal PublishedFileId[] GPublishedFileId;
	internal float[] GScore;
	internal AppId AppId;
	internal uint StartIndex;
	public static int _datasize;

	public int DataSize { get; }
	public CallbackType CallbackType { get; }


	public int get_DataSize() { }

	public CallbackType get_CallbackType() { }

	private static void .cctor() { }

}

internal struct RemoteStorageGetPublishedItemVoteDetailsResult_t : ICallbackData // TypeDefIndex: 5380
{
	internal Result Result;
	internal PublishedFileId PublishedFileId;
	internal int VotesFor;
	internal int VotesAgainst;
	internal int Reports;
	internal float FScore;
	public static int _datasize;

	public int DataSize { get; }
	public CallbackType CallbackType { get; }


	public int get_DataSize() { }

	public CallbackType get_CallbackType() { }

	private static void .cctor() { }

}

internal struct RemoteStoragePublishedFileSubscribed_t : ICallbackData // TypeDefIndex: 5381
{
	internal PublishedFileId PublishedFileId;
	internal AppId AppID;
	public static int _datasize;

	public int DataSize { get; }
	public CallbackType CallbackType { get; }


	public int get_DataSize() { }

	public CallbackType get_CallbackType() { }

	private static void .cctor() { }

}

internal struct RemoteStoragePublishedFileUnsubscribed_t : ICallbackData // TypeDefIndex: 5382
{
	internal PublishedFileId PublishedFileId;
	internal AppId AppID;
	public static int _datasize;

	public int DataSize { get; }
	public CallbackType CallbackType { get; }


	public int get_DataSize() { }

	public CallbackType get_CallbackType() { }

	private static void .cctor() { }

}

internal struct RemoteStoragePublishedFileDeleted_t : ICallbackData // TypeDefIndex: 5383
{
	internal PublishedFileId PublishedFileId;
	internal AppId AppID;
	public static int _datasize;

	public int DataSize { get; }
	public CallbackType CallbackType { get; }


	public int get_DataSize() { }

	public CallbackType get_CallbackType() { }

	private static void .cctor() { }

}

internal struct RemoteStorageUpdateUserPublishedItemVoteResult_t : ICallbackData // TypeDefIndex: 5384
{
	internal Result Result;
	internal PublishedFileId PublishedFileId;
	public static int _datasize;

	public int DataSize { get; }
	public CallbackType CallbackType { get; }


	public int get_DataSize() { }

	public CallbackType get_CallbackType() { }

	private static void .cctor() { }

}

internal struct RemoteStorageUserVoteDetails_t : ICallbackData // TypeDefIndex: 5385
{
	internal Result Result;
	internal PublishedFileId PublishedFileId;
	internal WorkshopVote Vote;
	public static int _datasize;

	public int DataSize { get; }
	public CallbackType CallbackType { get; }


	public int get_DataSize() { }

	public CallbackType get_CallbackType() { }

	private static void .cctor() { }

}

internal struct RemoteStorageEnumerateUserSharedWorkshopFilesResult_t : ICallbackData // TypeDefIndex: 5386
{
	internal Result Result;
	internal int ResultsReturned;
	internal int TotalResultCount;
	internal PublishedFileId[] GPublishedFileId;
	public static int _datasize;

	public int DataSize { get; }
	public CallbackType CallbackType { get; }


	public int get_DataSize() { }

	public CallbackType get_CallbackType() { }

	private static void .cctor() { }

}

internal struct RemoteStorageSetUserPublishedFileActionResult_t : ICallbackData // TypeDefIndex: 5387
{
	internal Result Result;
	internal PublishedFileId PublishedFileId;
	internal WorkshopFileAction Action;
	public static int _datasize;

	public int DataSize { get; }
	public CallbackType CallbackType { get; }


	public int get_DataSize() { }

	public CallbackType get_CallbackType() { }

	private static void .cctor() { }

}

internal struct RemoteStorageEnumeratePublishedFilesByUserActionResult_t : ICallbackData // TypeDefIndex: 5388
{
	internal Result Result;
	internal WorkshopFileAction Action;
	internal int ResultsReturned;
	internal int TotalResultCount;
	internal PublishedFileId[] GPublishedFileId;
	internal uint[] GRTimeUpdated;
	public static int _datasize;

	public int DataSize { get; }
	public CallbackType CallbackType { get; }


	public int get_DataSize() { }

	public CallbackType get_CallbackType() { }

	private static void .cctor() { }

}

internal struct RemoteStoragePublishFileProgress_t : ICallbackData // TypeDefIndex: 5389
{
	internal double DPercentFile;
	internal bool Preview;
	public static int _datasize;

	public int DataSize { get; }
	public CallbackType CallbackType { get; }


	public int get_DataSize() { }

	public CallbackType get_CallbackType() { }

	private static void .cctor() { }

}

internal struct RemoteStoragePublishedFileUpdated_t : ICallbackData // TypeDefIndex: 5390
{
	internal PublishedFileId PublishedFileId;
	internal AppId AppID;
	internal ulong Unused;
	public static int _datasize;

	public int DataSize { get; }
	public CallbackType CallbackType { get; }


	public int get_DataSize() { }

	public CallbackType get_CallbackType() { }

	private static void .cctor() { }

}

internal struct RemoteStorageFileWriteAsyncComplete_t : ICallbackData // TypeDefIndex: 5391
{
	internal Result Result;
	public static int _datasize;

	public int DataSize { get; }
	public CallbackType CallbackType { get; }


	public int get_DataSize() { }

	public CallbackType get_CallbackType() { }

	private static void .cctor() { }

}

internal struct RemoteStorageFileReadAsyncComplete_t : ICallbackData // TypeDefIndex: 5392
{
	internal ulong FileReadAsync;
	internal Result Result;
	internal uint Offset;
	internal uint Read;
	public static int _datasize;

	public int DataSize { get; }
	public CallbackType CallbackType { get; }


	public int get_DataSize() { }

	public CallbackType get_CallbackType() { }

	private static void .cctor() { }

}

internal struct RemoteStorageLocalFileChange_t : ICallbackData // TypeDefIndex: 5393
{
	public static int _datasize;

	public int DataSize { get; }
	public CallbackType CallbackType { get; }


	public int get_DataSize() { }

	public CallbackType get_CallbackType() { }

	private static void .cctor() { }

}

