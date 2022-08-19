internal class ISteamUGC : SteamInterface // TypeDefIndex: 5130
{	// Methods

	// RVA: 0xDD3400 Offset: 0xDD2800 VA: 0x180DD3400
	internal void .ctor(bool IsGameServer) { }

	// RVA: 0xDD4E80 Offset: 0xDD4280 VA: 0x180DD4E80
	internal static extern IntPtr SteamAPI_SteamUGC_v016() { }

	// RVA: 0xDD4E80 Offset: 0xDD4280 VA: 0x180DD4E80 Slot: 4
	public override IntPtr GetUserInterfacePointer() { }

	// RVA: 0xDD4E10 Offset: 0xDD4210 VA: 0x180DD4E10
	internal static extern IntPtr SteamAPI_SteamGameServerUGC_v016() { }

	// RVA: 0xDD4E10 Offset: 0xDD4210 VA: 0x180DD4E10 Slot: 5
	public override IntPtr GetServerInterfacePointer() { }

	// RVA: 0xDD6660 Offset: 0xDD5A60 VA: 0x180DD6660
	private static extern UGCQueryHandle_t _CreateQueryUserUGCRequest(IntPtr self, AccountID_t unAccountID, UserUGCList eListType, UgcType eMatchingUGCType, UserUGCListSortOrder eSortOrder, AppId nCreatorAppID, AppId nConsumerAppID, uint unPage) { }

	// RVA: 0xDD3D00 Offset: 0xDD3100 VA: 0x180DD3D00
	internal UGCQueryHandle_t CreateQueryUserUGCRequest(AccountID_t unAccountID, UserUGCList eListType, UgcType eMatchingUGCType, UserUGCListSortOrder eSortOrder, AppId nCreatorAppID, AppId nConsumerAppID, uint unPage) { }

	// RVA: 0xDD6500 Offset: 0xDD5900 VA: 0x180DD6500
	private static extern UGCQueryHandle_t _CreateQueryAllUGCRequest(IntPtr self, UGCQuery eQueryType, UgcType eMatchingeMatchingUGCTypeFileType, AppId nCreatorAppID, AppId nConsumerAppID, uint unPage) { }

	// RVA: 0xDD3BA0 Offset: 0xDD2FA0 VA: 0x180DD3BA0
	internal UGCQueryHandle_t CreateQueryAllUGCRequest(UGCQuery eQueryType, UgcType eMatchingeMatchingUGCTypeFileType, AppId nCreatorAppID, AppId nConsumerAppID, uint unPage) { }

	// RVA: 0xDD65C0 Offset: 0xDD59C0 VA: 0x180DD65C0
	private static extern UGCQueryHandle_t _CreateQueryUGCDetailsRequest(IntPtr self, [In] [Out] PublishedFileId[] pvecPublishedFileID, uint unNumPublishedFileIDs) { }

	// RVA: 0xDD3C60 Offset: 0xDD3060 VA: 0x180DD3C60
	internal UGCQueryHandle_t CreateQueryUGCDetailsRequest([In] [Out] PublishedFileId[] pvecPublishedFileID, uint unNumPublishedFileIDs) { }

	// RVA: 0xDD72C0 Offset: 0xDD66C0 VA: 0x180DD72C0
	private static extern SteamAPICall_t _SendQueryUGCRequest(IntPtr self, UGCQueryHandle_t handle) { }

	// RVA: 0xDD5040 Offset: 0xDD4440 VA: 0x180DD5040
	internal CallResult<SteamUGCQueryCompleted_t> SendQueryUGCRequest(UGCQueryHandle_t handle) { }

	// RVA: 0xDD6F30 Offset: 0xDD6330 VA: 0x180DD6F30
	private static extern bool _GetQueryUGCResult(IntPtr self, UGCQueryHandle_t handle, uint index, ref SteamUGCDetails_t pDetails) { }

	// RVA: 0xDD4D30 Offset: 0xDD4130 VA: 0x180DD4D30
	internal bool GetQueryUGCResult(UGCQueryHandle_t handle, uint index, ref SteamUGCDetails_t pDetails) { }

	// RVA: 0xDD6E70 Offset: 0xDD6270 VA: 0x180DD6E70
	private static extern bool _GetQueryUGCPreviewURL(IntPtr self, UGCQueryHandle_t handle, uint index, IntPtr pchURL, uint cchURLSize) { }

	// RVA: 0xDD4B30 Offset: 0xDD3F30 VA: 0x180DD4B30
	internal bool GetQueryUGCPreviewURL(UGCQueryHandle_t handle, uint index, out string pchURL) { }

	// RVA: 0xDD6C70 Offset: 0xDD6070 VA: 0x180DD6C70
	private static extern bool _GetQueryUGCMetadata(IntPtr self, UGCQueryHandle_t handle, uint index, IntPtr pchMetadata, uint cchMetadatasize) { }

	// RVA: 0xDD47F0 Offset: 0xDD3BF0 VA: 0x180DD47F0
	internal bool GetQueryUGCMetadata(UGCQueryHandle_t handle, uint index, out string pchMetadata) { }

	// RVA: 0xDD6AD0 Offset: 0xDD5ED0 VA: 0x180DD6AD0
	private static extern bool _GetQueryUGCChildren(IntPtr self, UGCQueryHandle_t handle, uint index, [In] [Out] PublishedFileId[] pvecPublishedFileID, uint cMaxEntries) { }

	// RVA: 0xDD4480 Offset: 0xDD3880 VA: 0x180DD4480
	internal bool GetQueryUGCChildren(UGCQueryHandle_t handle, uint index, [In] [Out] PublishedFileId[] pvecPublishedFileID, uint cMaxEntries) { }

	// RVA: 0xDD70C0 Offset: 0xDD64C0 VA: 0x180DD70C0
	private static extern bool _GetQueryUGCStatistic(IntPtr self, UGCQueryHandle_t handle, uint index, ItemStatistic eStatType, ref ulong pStatValue) { }

	// RVA: 0xDD4D50 Offset: 0xDD4150 VA: 0x180DD4D50
	internal bool GetQueryUGCStatistic(UGCQueryHandle_t handle, uint index, ItemStatistic eStatType, ref ulong pStatValue) { }

	// RVA: 0xDD6D30 Offset: 0xDD6130 VA: 0x180DD6D30
	private static extern uint _GetQueryUGCNumAdditionalPreviews(IntPtr self, UGCQueryHandle_t handle, uint index) { }

	// RVA: 0xDD49F0 Offset: 0xDD3DF0 VA: 0x180DD49F0
	internal uint GetQueryUGCNumAdditionalPreviews(UGCQueryHandle_t handle, uint index) { }

	// RVA: 0xDD69E0 Offset: 0xDD5DE0 VA: 0x180DD69E0
	private static extern bool _GetQueryUGCAdditionalPreview(IntPtr self, UGCQueryHandle_t handle, uint index, uint previewIndex, IntPtr pchURLOrVideoID, uint cchURLSize, IntPtr pchOriginalFileName, uint cchOriginalFileNameSize, ref ItemPreviewType pPreviewType) { }

	// RVA: 0xDD41C0 Offset: 0xDD35C0 VA: 0x180DD41C0
	internal bool GetQueryUGCAdditionalPreview(UGCQueryHandle_t handle, uint index, uint previewIndex, out string pchURLOrVideoID, out string pchOriginalFileName, ref ItemPreviewType pPreviewType) { }

	// RVA: 0xDD6DD0 Offset: 0xDD61D0 VA: 0x180DD6DD0
	private static extern uint _GetQueryUGCNumKeyValueTags(IntPtr self, UGCQueryHandle_t handle, uint index) { }

	// RVA: 0xDD4A90 Offset: 0xDD3E90 VA: 0x180DD4A90
	internal uint GetQueryUGCNumKeyValueTags(UGCQueryHandle_t handle, uint index) { }

	// RVA: 0xDD6B90 Offset: 0xDD5F90 VA: 0x180DD6B90
	private static extern bool _GetQueryUGCKeyValueTag(IntPtr self, UGCQueryHandle_t handle, uint index, uint keyValueTagIndex, IntPtr pchKey, uint cchKeySize, IntPtr pchValue, uint cchValueSize) { }

	// RVA: 0xDD4540 Offset: 0xDD3940 VA: 0x180DD4540
	internal bool GetQueryUGCKeyValueTag(UGCQueryHandle_t handle, uint index, uint keyValueTagIndex, out string pchKey, out string pchValue) { }

	// RVA: 0xDD7180 Offset: 0xDD6580 VA: 0x180DD7180
	private static extern bool _ReleaseQueryUGCRequest(IntPtr self, UGCQueryHandle_t handle) { }

	// RVA: 0xDD4EF0 Offset: 0xDD42F0 VA: 0x180DD4EF0
	internal bool ReleaseQueryUGCRequest(UGCQueryHandle_t handle) { }

	// RVA: 0xDD63B0 Offset: 0xDD57B0 VA: 0x180DD63B0
	private static extern bool _AddRequiredTag(IntPtr self, UGCQueryHandle_t handle, string pTagName) { }

	// RVA: 0xDD39E0 Offset: 0xDD2DE0 VA: 0x180DD39E0
	internal bool AddRequiredTag(UGCQueryHandle_t handle, string pTagName) { }

	// RVA: 0xDD6140 Offset: 0xDD5540 VA: 0x180DD6140
	private static extern bool _AddExcludedTag(IntPtr self, UGCQueryHandle_t handle, string pTagName) { }

	// RVA: 0xDD3760 Offset: 0xDD2B60 VA: 0x180DD3760
	internal bool AddExcludedTag(UGCQueryHandle_t handle, string pTagName) { }

	// RVA: 0xDD7DB0 Offset: 0xDD71B0 VA: 0x180DD7DB0
	private static extern bool _SetReturnOnlyIDs(IntPtr self, UGCQueryHandle_t handle, bool bReturnOnlyIDs) { }

	// RVA: 0xDD5BF0 Offset: 0xDD4FF0 VA: 0x180DD5BF0
	internal bool SetReturnOnlyIDs(UGCQueryHandle_t handle, bool bReturnOnlyIDs) { }

	// RVA: 0xDD7BD0 Offset: 0xDD6FD0 VA: 0x180DD7BD0
	private static extern bool _SetReturnKeyValueTags(IntPtr self, UGCQueryHandle_t handle, bool bReturnKeyValueTags) { }

	// RVA: 0xDD5A10 Offset: 0xDD4E10 VA: 0x180DD5A10
	internal bool SetReturnKeyValueTags(UGCQueryHandle_t handle, bool bReturnKeyValueTags) { }

	// RVA: 0xDD7C70 Offset: 0xDD7070 VA: 0x180DD7C70
	private static extern bool _SetReturnLongDescription(IntPtr self, UGCQueryHandle_t handle, bool bReturnLongDescription) { }

	// RVA: 0xDD5AB0 Offset: 0xDD4EB0 VA: 0x180DD5AB0
	internal bool SetReturnLongDescription(UGCQueryHandle_t handle, bool bReturnLongDescription) { }

	// RVA: 0xDD7D10 Offset: 0xDD7110 VA: 0x180DD7D10
	private static extern bool _SetReturnMetadata(IntPtr self, UGCQueryHandle_t handle, bool bReturnMetadata) { }

	// RVA: 0xDD5B50 Offset: 0xDD4F50 VA: 0x180DD5B50
	internal bool SetReturnMetadata(UGCQueryHandle_t handle, bool bReturnMetadata) { }

	// RVA: 0xDD7B30 Offset: 0xDD6F30 VA: 0x180DD7B30
	private static extern bool _SetReturnChildren(IntPtr self, UGCQueryHandle_t handle, bool bReturnChildren) { }

	// RVA: 0xDD5970 Offset: 0xDD4D70 VA: 0x180DD5970
	internal bool SetReturnChildren(UGCQueryHandle_t handle, bool bReturnChildren) { }

	// RVA: 0xDD7A90 Offset: 0xDD6E90 VA: 0x180DD7A90
	private static extern bool _SetReturnAdditionalPreviews(IntPtr self, UGCQueryHandle_t handle, bool bReturnAdditionalPreviews) { }

	// RVA: 0xDD58D0 Offset: 0xDD4CD0 VA: 0x180DD58D0
	internal bool SetReturnAdditionalPreviews(UGCQueryHandle_t handle, bool bReturnAdditionalPreviews) { }

	// RVA: 0xDD7EF0 Offset: 0xDD72F0 VA: 0x180DD7EF0
	private static extern bool _SetReturnTotalOnly(IntPtr self, UGCQueryHandle_t handle, bool bReturnTotalOnly) { }

	// RVA: 0xDD5D30 Offset: 0xDD5130 VA: 0x180DD5D30
	internal bool SetReturnTotalOnly(UGCQueryHandle_t handle, bool bReturnTotalOnly) { }

	// RVA: 0xDD7E50 Offset: 0xDD7250 VA: 0x180DD7E50
	private static extern bool _SetReturnPlaytimeStats(IntPtr self, UGCQueryHandle_t handle, uint unDays) { }

	// RVA: 0xDD5C90 Offset: 0xDD5090 VA: 0x180DD5C90
	internal bool SetReturnPlaytimeStats(UGCQueryHandle_t handle, uint unDays) { }

	// RVA: 0xDD7350 Offset: 0xDD6750 VA: 0x180DD7350
	private static extern bool _SetAllowCachedResponse(IntPtr self, UGCQueryHandle_t handle, uint unMaxAgeSeconds) { }

	// RVA: 0xDD5130 Offset: 0xDD4530 VA: 0x180DD5130
	internal bool SetAllowCachedResponse(UGCQueryHandle_t handle, uint unMaxAgeSeconds) { }

	// RVA: 0xDD7950 Offset: 0xDD6D50 VA: 0x180DD7950
	private static extern bool _SetMatchAnyTag(IntPtr self, UGCQueryHandle_t handle, bool bMatchAnyTag) { }

	// RVA: 0xDD5790 Offset: 0xDD4B90 VA: 0x180DD5790
	internal bool SetMatchAnyTag(UGCQueryHandle_t handle, bool bMatchAnyTag) { }

	// RVA: 0xDD7F90 Offset: 0xDD7390 VA: 0x180DD7F90
	private static extern bool _SetSearchText(IntPtr self, UGCQueryHandle_t handle, string pSearchText) { }

	// RVA: 0xDD5DD0 Offset: 0xDD51D0 VA: 0x180DD5DD0
	internal bool SetSearchText(UGCQueryHandle_t handle, string pSearchText) { }

	// RVA: 0xDD79F0 Offset: 0xDD6DF0 VA: 0x180DD79F0
	private static extern bool _SetRankedByTrendDays(IntPtr self, UGCQueryHandle_t handle, uint unDays) { }

	// RVA: 0xDD5830 Offset: 0xDD4C30 VA: 0x180DD5830
	internal bool SetRankedByTrendDays(UGCQueryHandle_t handle, uint unDays) { }

	// RVA: 0xDD62D0 Offset: 0xDD56D0 VA: 0x180DD62D0
	private static extern bool _AddRequiredKeyValueTag(IntPtr self, UGCQueryHandle_t handle, string pKey, string pValue) { }

	// RVA: 0xDD3900 Offset: 0xDD2D00 VA: 0x180DD3900
	internal bool AddRequiredKeyValueTag(UGCQueryHandle_t handle, string pKey, string pValue) { }

	// RVA: 0xDD6460 Offset: 0xDD5860 VA: 0x180DD6460
	private static extern SteamAPICall_t _CreateItem(IntPtr self, AppId nConsumerAppId, WorkshopFileType eFileType) { }

	// RVA: 0xDD3AA0 Offset: 0xDD2EA0 VA: 0x180DD3AA0
	internal CallResult<CreateItemResult_t> CreateItem(AppId nConsumerAppId, WorkshopFileType eFileType) { }

	// RVA: 0xDD80E0 Offset: 0xDD74E0 VA: 0x180DD80E0
	private static extern UGCUpdateHandle_t _StartItemUpdate(IntPtr self, AppId nConsumerAppId, PublishedFileId nPublishedFileID) { }

	// RVA: 0xDD5F90 Offset: 0xDD5390 VA: 0x180DD5F90
	internal UGCUpdateHandle_t StartItemUpdate(AppId nConsumerAppId, PublishedFileId nPublishedFileID) { }

	// RVA: 0xDD7750 Offset: 0xDD6B50 VA: 0x180DD7750
	private static extern bool _SetItemTitle(IntPtr self, UGCUpdateHandle_t handle, string pchTitle) { }

	// RVA: 0xDD5570 Offset: 0xDD4970 VA: 0x180DD5570
	internal bool SetItemTitle(UGCUpdateHandle_t handle, string pchTitle) { }

	// RVA: 0xDD74A0 Offset: 0xDD68A0 VA: 0x180DD74A0
	private static extern bool _SetItemDescription(IntPtr self, UGCUpdateHandle_t handle, string pchDescription) { }

	// RVA: 0xDD5290 Offset: 0xDD4690 VA: 0x180DD5290
	internal bool SetItemDescription(UGCUpdateHandle_t handle, string pchDescription) { }

	// RVA: 0xDD7800 Offset: 0xDD6C00 VA: 0x180DD7800
	private static extern bool _SetItemUpdateLanguage(IntPtr self, UGCUpdateHandle_t handle, string pchLanguage) { }

	// RVA: 0xDD5630 Offset: 0xDD4A30 VA: 0x180DD5630
	internal bool SetItemUpdateLanguage(UGCUpdateHandle_t handle, string pchLanguage) { }

	// RVA: 0xDD7550 Offset: 0xDD6950 VA: 0x180DD7550
	private static extern bool _SetItemMetadata(IntPtr self, UGCUpdateHandle_t handle, string pchMetaData) { }

	// RVA: 0xDD5350 Offset: 0xDD4750 VA: 0x180DD5350
	internal bool SetItemMetadata(UGCUpdateHandle_t handle, string pchMetaData) { }

	// RVA: 0xDD78B0 Offset: 0xDD6CB0 VA: 0x180DD78B0
	private static extern bool _SetItemVisibility(IntPtr self, UGCUpdateHandle_t handle, RemoteStoragePublishedFileVisibility eVisibility) { }

	// RVA: 0xDD56F0 Offset: 0xDD4AF0 VA: 0x180DD56F0
	internal bool SetItemVisibility(UGCUpdateHandle_t handle, RemoteStoragePublishedFileVisibility eVisibility) { }

	// RVA: 0xDD76B0 Offset: 0xDD6AB0 VA: 0x180DD76B0
	private static extern bool _SetItemTags(IntPtr self, UGCUpdateHandle_t updateHandle, ref SteamParamStringArray_t pTags) { }

	// RVA: 0xDD54D0 Offset: 0xDD48D0 VA: 0x180DD54D0
	internal bool SetItemTags(UGCUpdateHandle_t updateHandle, ref SteamParamStringArray_t pTags) { }

	// RVA: 0xDD73F0 Offset: 0xDD67F0 VA: 0x180DD73F0
	private static extern bool _SetItemContent(IntPtr self, UGCUpdateHandle_t handle, string pszContentFolder) { }

	// RVA: 0xDD51D0 Offset: 0xDD45D0 VA: 0x180DD51D0
	internal bool SetItemContent(UGCUpdateHandle_t handle, string pszContentFolder) { }

	// RVA: 0xDD7600 Offset: 0xDD6A00 VA: 0x180DD7600
	private static extern bool _SetItemPreview(IntPtr self, UGCUpdateHandle_t handle, string pszPreviewFile) { }

	// RVA: 0xDD5410 Offset: 0xDD4810 VA: 0x180DD5410
	internal bool SetItemPreview(UGCUpdateHandle_t handle, string pszPreviewFile) { }

	// RVA: 0xDD7210 Offset: 0xDD6610 VA: 0x180DD7210
	private static extern bool _RemoveItemKeyValueTags(IntPtr self, UGCUpdateHandle_t handle, string pchKey) { }

	// RVA: 0xDD4F80 Offset: 0xDD4380 VA: 0x180DD4F80
	internal bool RemoveItemKeyValueTags(UGCUpdateHandle_t handle, string pchKey) { }

	// RVA: 0xDD61F0 Offset: 0xDD55F0 VA: 0x180DD61F0
	private static extern bool _AddItemKeyValueTag(IntPtr self, UGCUpdateHandle_t handle, string pchKey, string pchValue) { }

	// RVA: 0xDD3820 Offset: 0xDD2C20 VA: 0x180DD3820
	internal bool AddItemKeyValueTag(UGCUpdateHandle_t handle, string pchKey, string pchValue) { }

	// RVA: 0xDD8180 Offset: 0xDD7580 VA: 0x180DD8180
	private static extern SteamAPICall_t _SubmitItemUpdate(IntPtr self, UGCUpdateHandle_t handle, string pchChangeNote) { }

	// RVA: 0xDD6030 Offset: 0xDD5430 VA: 0x180DD6030
	internal CallResult<SubmitItemUpdateResult_t> SubmitItemUpdate(UGCUpdateHandle_t handle, string pchChangeNote) { }

	// RVA: 0xDD6930 Offset: 0xDD5D30 VA: 0x180DD6930
	private static extern ItemUpdateStatus _GetItemUpdateProgress(IntPtr self, UGCUpdateHandle_t handle, ref ulong punBytesProcessed, ref ulong punBytesTotal) { }

	// RVA: 0xDD4110 Offset: 0xDD3510 VA: 0x180DD4110
	internal ItemUpdateStatus GetItemUpdateProgress(UGCUpdateHandle_t handle, ref ulong punBytesProcessed, ref ulong punBytesTotal) { }

	// RVA: 0xDD8040 Offset: 0xDD7440 VA: 0x180DD8040
	private static extern SteamAPICall_t _SetUserItemVote(IntPtr self, PublishedFileId nPublishedFileID, bool bVoteUp) { }

	// RVA: 0xDD5E90 Offset: 0xDD5290 VA: 0x180DD5E90
	internal CallResult<SetUserItemVoteResult_t> SetUserItemVote(PublishedFileId nPublishedFileID, bool bVoteUp) { }

	// RVA: 0xDD68A0 Offset: 0xDD5CA0 VA: 0x180DD68A0
	private static extern uint _GetItemState(IntPtr self, PublishedFileId nPublishedFileID) { }

	// RVA: 0xDD4080 Offset: 0xDD3480 VA: 0x180DD4080
	internal uint GetItemState(PublishedFileId nPublishedFileID) { }

	// RVA: 0xDD67D0 Offset: 0xDD5BD0 VA: 0x180DD67D0
	private static extern bool _GetItemInstallInfo(IntPtr self, PublishedFileId nPublishedFileID, ref ulong punSizeOnDisk, IntPtr pchFolder, uint cchFolderSize, ref uint punTimeStamp) { }

	// RVA: 0xDD3E70 Offset: 0xDD3270 VA: 0x180DD3E70
	internal bool GetItemInstallInfo(PublishedFileId nPublishedFileID, ref ulong punSizeOnDisk, out string pchFolder, ref uint punTimeStamp) { }

	// RVA: 0xDD6730 Offset: 0xDD5B30 VA: 0x180DD6730
	private static extern bool _DownloadItem(IntPtr self, PublishedFileId nPublishedFileID, bool bHighPriority) { }

	// RVA: 0xDD3DD0 Offset: 0xDD31D0 VA: 0x180DD3DD0
	internal bool DownloadItem(PublishedFileId nPublishedFileID, bool bHighPriority) { }

}

