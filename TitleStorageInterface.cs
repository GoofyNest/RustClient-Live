public sealed class TitleStorageInterface : Handle // TypeDefIndex: 8429
{
	public const int CopyfilemetadataatindexoptionsApiLatest = 1;
	public const int CopyfilemetadatabyfilenameoptionsApiLatest = 1;
	public const int DeletecacheoptionsApiLatest = 1;
	public const int FilemetadataApiLatest = 2;
	public const int FilenameMaxLengthBytes = 64;
	public const int GetfilemetadatacountoptionsApiLatest = 1;
	public const int QueryfilelistoptionsApiLatest = 1;
	public const int QueryfileoptionsApiLatest = 1;
	public const int ReadfileoptionsApiLatest = 1;


	public void .ctor() { }

	public void .ctor(IntPtr innerHandle) { }

	public Result CopyFileMetadataAtIndex(ref CopyFileMetadataAtIndexOptions options, out Nullable<FileMetadata> outMetadata) { }

	public Result CopyFileMetadataByFilename(ref CopyFileMetadataByFilenameOptions options, out Nullable<FileMetadata> outMetadata) { }

	public Result DeleteCache(ref DeleteCacheOptions options, object clientData, OnDeleteCacheCompleteCallback completionCallback) { }

	public uint GetFileMetadataCount(ref GetFileMetadataCountOptions options) { }

	public void QueryFile(ref QueryFileOptions options, object clientData, OnQueryFileCompleteCallback completionCallback) { }

	public void QueryFileList(ref QueryFileListOptions options, object clientData, OnQueryFileListCompleteCallback completionCallback) { }

	public TitleStorageFileTransferRequest ReadFile(ref ReadFileOptions options, object clientData, OnReadFileCompleteCallback completionCallback) { }

	[MonoPInvokeCallbackAttribute]
	internal static void OnDeleteCacheCompleteCallbackInternalImplementation(ref DeleteCacheCallbackInfoInternal data) { }

	[MonoPInvokeCallbackAttribute]
	internal static void OnFileTransferProgressCallbackInternalImplementation(ref FileTransferProgressCallbackInfoInternal data) { }

	[MonoPInvokeCallbackAttribute]
	internal static void OnQueryFileCompleteCallbackInternalImplementation(ref QueryFileCallbackInfoInternal data) { }

	[MonoPInvokeCallbackAttribute]
	internal static void OnQueryFileListCompleteCallbackInternalImplementation(ref QueryFileListCallbackInfoInternal data) { }

	[MonoPInvokeCallbackAttribute]
	internal static void OnReadFileCompleteCallbackInternalImplementation(ref ReadFileCallbackInfoInternal data) { }

	[MonoPInvokeCallbackAttribute]
	internal static ReadResult OnReadFileDataCallbackInternalImplementation(ref ReadFileDataCallbackInfoInternal data) { }

}

