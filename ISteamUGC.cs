internal class ISteamUGC : SteamInterface // TypeDefIndex: 5136
{

	internal void .ctor(bool IsGameServer) { }

	internal static extern IntPtr SteamAPI_SteamUGC_v016() { }

	public override IntPtr GetUserInterfacePointer() { }

	internal static extern IntPtr SteamAPI_SteamGameServerUGC_v016() { }

	public override IntPtr GetServerInterfacePointer() { }

	private static extern UGCQueryHandle_t _CreateQueryUserUGCRequest(IntPtr self, AccountID_t unAccountID, UserUGCList eListType, UgcType eMatchingUGCType, UserUGCListSortOrder eSortOrder, AppId nCreatorAppID, AppId nConsumerAppID, uint unPage) { }

	internal UGCQueryHandle_t CreateQueryUserUGCRequest(AccountID_t unAccountID, UserUGCList eListType, UgcType eMatchingUGCType, UserUGCListSortOrder eSortOrder, AppId nCreatorAppID, AppId nConsumerAppID, uint unPage) { }

	private static extern UGCQueryHandle_t _CreateQueryAllUGCRequest(IntPtr self, UGCQuery eQueryType, UgcType eMatchingeMatchingUGCTypeFileType, AppId nCreatorAppID, AppId nConsumerAppID, uint unPage) { }

	internal UGCQueryHandle_t CreateQueryAllUGCRequest(UGCQuery eQueryType, UgcType eMatchingeMatchingUGCTypeFileType, AppId nCreatorAppID, AppId nConsumerAppID, uint unPage) { }

	private static extern UGCQueryHandle_t _CreateQueryUGCDetailsRequest(IntPtr self, [In] [Out] PublishedFileId[] pvecPublishedFileID, uint unNumPublishedFileIDs) { }

	internal UGCQueryHandle_t CreateQueryUGCDetailsRequest([In] [Out] PublishedFileId[] pvecPublishedFileID, uint unNumPublishedFileIDs) { }

	private static extern SteamAPICall_t _SendQueryUGCRequest(IntPtr self, UGCQueryHandle_t handle) { }

	internal CallResult<SteamUGCQueryCompleted_t> SendQueryUGCRequest(UGCQueryHandle_t handle) { }

	private static extern bool _GetQueryUGCResult(IntPtr self, UGCQueryHandle_t handle, uint index, ref SteamUGCDetails_t pDetails) { }

	internal bool GetQueryUGCResult(UGCQueryHandle_t handle, uint index, ref SteamUGCDetails_t pDetails) { }

	private static extern bool _GetQueryUGCPreviewURL(IntPtr self, UGCQueryHandle_t handle, uint index, IntPtr pchURL, uint cchURLSize) { }

	internal bool GetQueryUGCPreviewURL(UGCQueryHandle_t handle, uint index, out string pchURL) { }

	private static extern bool _GetQueryUGCMetadata(IntPtr self, UGCQueryHandle_t handle, uint index, IntPtr pchMetadata, uint cchMetadatasize) { }

	internal bool GetQueryUGCMetadata(UGCQueryHandle_t handle, uint index, out string pchMetadata) { }

	private static extern bool _GetQueryUGCChildren(IntPtr self, UGCQueryHandle_t handle, uint index, [In] [Out] PublishedFileId[] pvecPublishedFileID, uint cMaxEntries) { }

	internal bool GetQueryUGCChildren(UGCQueryHandle_t handle, uint index, [In] [Out] PublishedFileId[] pvecPublishedFileID, uint cMaxEntries) { }

	private static extern bool _GetQueryUGCStatistic(IntPtr self, UGCQueryHandle_t handle, uint index, ItemStatistic eStatType, ref ulong pStatValue) { }

	internal bool GetQueryUGCStatistic(UGCQueryHandle_t handle, uint index, ItemStatistic eStatType, ref ulong pStatValue) { }

	private static extern uint _GetQueryUGCNumAdditionalPreviews(IntPtr self, UGCQueryHandle_t handle, uint index) { }

	internal uint GetQueryUGCNumAdditionalPreviews(UGCQueryHandle_t handle, uint index) { }

	private static extern bool _GetQueryUGCAdditionalPreview(IntPtr self, UGCQueryHandle_t handle, uint index, uint previewIndex, IntPtr pchURLOrVideoID, uint cchURLSize, IntPtr pchOriginalFileName, uint cchOriginalFileNameSize, ref ItemPreviewType pPreviewType) { }

	internal bool GetQueryUGCAdditionalPreview(UGCQueryHandle_t handle, uint index, uint previewIndex, out string pchURLOrVideoID, out string pchOriginalFileName, ref ItemPreviewType pPreviewType) { }

	private static extern uint _GetQueryUGCNumKeyValueTags(IntPtr self, UGCQueryHandle_t handle, uint index) { }

	internal uint GetQueryUGCNumKeyValueTags(UGCQueryHandle_t handle, uint index) { }

	private static extern bool _GetQueryUGCKeyValueTag(IntPtr self, UGCQueryHandle_t handle, uint index, uint keyValueTagIndex, IntPtr pchKey, uint cchKeySize, IntPtr pchValue, uint cchValueSize) { }

	internal bool GetQueryUGCKeyValueTag(UGCQueryHandle_t handle, uint index, uint keyValueTagIndex, out string pchKey, out string pchValue) { }

	private static extern bool _ReleaseQueryUGCRequest(IntPtr self, UGCQueryHandle_t handle) { }

	internal bool ReleaseQueryUGCRequest(UGCQueryHandle_t handle) { }

	private static extern bool _AddRequiredTag(IntPtr self, UGCQueryHandle_t handle, string pTagName) { }

	internal bool AddRequiredTag(UGCQueryHandle_t handle, string pTagName) { }

	private static extern bool _AddExcludedTag(IntPtr self, UGCQueryHandle_t handle, string pTagName) { }

	internal bool AddExcludedTag(UGCQueryHandle_t handle, string pTagName) { }

	private static extern bool _SetReturnOnlyIDs(IntPtr self, UGCQueryHandle_t handle, bool bReturnOnlyIDs) { }

	internal bool SetReturnOnlyIDs(UGCQueryHandle_t handle, bool bReturnOnlyIDs) { }

	private static extern bool _SetReturnKeyValueTags(IntPtr self, UGCQueryHandle_t handle, bool bReturnKeyValueTags) { }

	internal bool SetReturnKeyValueTags(UGCQueryHandle_t handle, bool bReturnKeyValueTags) { }

	private static extern bool _SetReturnLongDescription(IntPtr self, UGCQueryHandle_t handle, bool bReturnLongDescription) { }

	internal bool SetReturnLongDescription(UGCQueryHandle_t handle, bool bReturnLongDescription) { }

	private static extern bool _SetReturnMetadata(IntPtr self, UGCQueryHandle_t handle, bool bReturnMetadata) { }

	internal bool SetReturnMetadata(UGCQueryHandle_t handle, bool bReturnMetadata) { }

	private static extern bool _SetReturnChildren(IntPtr self, UGCQueryHandle_t handle, bool bReturnChildren) { }

	internal bool SetReturnChildren(UGCQueryHandle_t handle, bool bReturnChildren) { }

	private static extern bool _SetReturnAdditionalPreviews(IntPtr self, UGCQueryHandle_t handle, bool bReturnAdditionalPreviews) { }

	internal bool SetReturnAdditionalPreviews(UGCQueryHandle_t handle, bool bReturnAdditionalPreviews) { }

	private static extern bool _SetReturnTotalOnly(IntPtr self, UGCQueryHandle_t handle, bool bReturnTotalOnly) { }

	internal bool SetReturnTotalOnly(UGCQueryHandle_t handle, bool bReturnTotalOnly) { }

	private static extern bool _SetReturnPlaytimeStats(IntPtr self, UGCQueryHandle_t handle, uint unDays) { }

	internal bool SetReturnPlaytimeStats(UGCQueryHandle_t handle, uint unDays) { }

	private static extern bool _SetAllowCachedResponse(IntPtr self, UGCQueryHandle_t handle, uint unMaxAgeSeconds) { }

	internal bool SetAllowCachedResponse(UGCQueryHandle_t handle, uint unMaxAgeSeconds) { }

	private static extern bool _SetMatchAnyTag(IntPtr self, UGCQueryHandle_t handle, bool bMatchAnyTag) { }

	internal bool SetMatchAnyTag(UGCQueryHandle_t handle, bool bMatchAnyTag) { }

	private static extern bool _SetSearchText(IntPtr self, UGCQueryHandle_t handle, string pSearchText) { }

	internal bool SetSearchText(UGCQueryHandle_t handle, string pSearchText) { }

	private static extern bool _SetRankedByTrendDays(IntPtr self, UGCQueryHandle_t handle, uint unDays) { }

	internal bool SetRankedByTrendDays(UGCQueryHandle_t handle, uint unDays) { }

	private static extern bool _AddRequiredKeyValueTag(IntPtr self, UGCQueryHandle_t handle, string pKey, string pValue) { }

	internal bool AddRequiredKeyValueTag(UGCQueryHandle_t handle, string pKey, string pValue) { }

	private static extern SteamAPICall_t _CreateItem(IntPtr self, AppId nConsumerAppId, WorkshopFileType eFileType) { }

	internal CallResult<CreateItemResult_t> CreateItem(AppId nConsumerAppId, WorkshopFileType eFileType) { }

	private static extern UGCUpdateHandle_t _StartItemUpdate(IntPtr self, AppId nConsumerAppId, PublishedFileId nPublishedFileID) { }

	internal UGCUpdateHandle_t StartItemUpdate(AppId nConsumerAppId, PublishedFileId nPublishedFileID) { }

	private static extern bool _SetItemTitle(IntPtr self, UGCUpdateHandle_t handle, string pchTitle) { }

	internal bool SetItemTitle(UGCUpdateHandle_t handle, string pchTitle) { }

	private static extern bool _SetItemDescription(IntPtr self, UGCUpdateHandle_t handle, string pchDescription) { }

	internal bool SetItemDescription(UGCUpdateHandle_t handle, string pchDescription) { }

	private static extern bool _SetItemUpdateLanguage(IntPtr self, UGCUpdateHandle_t handle, string pchLanguage) { }

	internal bool SetItemUpdateLanguage(UGCUpdateHandle_t handle, string pchLanguage) { }

	private static extern bool _SetItemMetadata(IntPtr self, UGCUpdateHandle_t handle, string pchMetaData) { }

	internal bool SetItemMetadata(UGCUpdateHandle_t handle, string pchMetaData) { }

	private static extern bool _SetItemVisibility(IntPtr self, UGCUpdateHandle_t handle, RemoteStoragePublishedFileVisibility eVisibility) { }

	internal bool SetItemVisibility(UGCUpdateHandle_t handle, RemoteStoragePublishedFileVisibility eVisibility) { }

	private static extern bool _SetItemTags(IntPtr self, UGCUpdateHandle_t updateHandle, ref SteamParamStringArray_t pTags) { }

	internal bool SetItemTags(UGCUpdateHandle_t updateHandle, ref SteamParamStringArray_t pTags) { }

	private static extern bool _SetItemContent(IntPtr self, UGCUpdateHandle_t handle, string pszContentFolder) { }

	internal bool SetItemContent(UGCUpdateHandle_t handle, string pszContentFolder) { }

	private static extern bool _SetItemPreview(IntPtr self, UGCUpdateHandle_t handle, string pszPreviewFile) { }

	internal bool SetItemPreview(UGCUpdateHandle_t handle, string pszPreviewFile) { }

	private static extern bool _RemoveItemKeyValueTags(IntPtr self, UGCUpdateHandle_t handle, string pchKey) { }

	internal bool RemoveItemKeyValueTags(UGCUpdateHandle_t handle, string pchKey) { }

	private static extern bool _AddItemKeyValueTag(IntPtr self, UGCUpdateHandle_t handle, string pchKey, string pchValue) { }

	internal bool AddItemKeyValueTag(UGCUpdateHandle_t handle, string pchKey, string pchValue) { }

	private static extern SteamAPICall_t _SubmitItemUpdate(IntPtr self, UGCUpdateHandle_t handle, string pchChangeNote) { }

	internal CallResult<SubmitItemUpdateResult_t> SubmitItemUpdate(UGCUpdateHandle_t handle, string pchChangeNote) { }

	private static extern ItemUpdateStatus _GetItemUpdateProgress(IntPtr self, UGCUpdateHandle_t handle, ref ulong punBytesProcessed, ref ulong punBytesTotal) { }

	internal ItemUpdateStatus GetItemUpdateProgress(UGCUpdateHandle_t handle, ref ulong punBytesProcessed, ref ulong punBytesTotal) { }

	private static extern SteamAPICall_t _SetUserItemVote(IntPtr self, PublishedFileId nPublishedFileID, bool bVoteUp) { }

	internal CallResult<SetUserItemVoteResult_t> SetUserItemVote(PublishedFileId nPublishedFileID, bool bVoteUp) { }

	private static extern uint _GetItemState(IntPtr self, PublishedFileId nPublishedFileID) { }

	internal uint GetItemState(PublishedFileId nPublishedFileID) { }

	private static extern bool _GetItemInstallInfo(IntPtr self, PublishedFileId nPublishedFileID, ref ulong punSizeOnDisk, IntPtr pchFolder, uint cchFolderSize, ref uint punTimeStamp) { }

	internal bool GetItemInstallInfo(PublishedFileId nPublishedFileID, ref ulong punSizeOnDisk, out string pchFolder, ref uint punTimeStamp) { }

	private static extern bool _DownloadItem(IntPtr self, PublishedFileId nPublishedFileID, bool bHighPriority) { }

	internal bool DownloadItem(PublishedFileId nPublishedFileID, bool bHighPriority) { }

}

