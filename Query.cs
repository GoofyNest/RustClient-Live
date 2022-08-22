public struct Query // TypeDefIndex: 5279
{	private UgcType matchingType; // 0x0
	private UGCQuery queryType; // 0x4
	private AppId consumerApp; // 0x8
	private AppId creatorApp; // 0xC
	private string searchText; // 0x10
	private Nullable<SteamId> steamid; // 0x18
	private UserUGCList userType; // 0x28
	private UserUGCListSortOrder userSort; // 0x2C
	private PublishedFileId[] Files; // 0x30
	private Nullable<int> maxCacheAge; // 0x38
	private string language; // 0x40
	private Nullable<int> trendDays; // 0x48
	private List<string> requiredTags; // 0x50
	private Nullable<bool> matchAnyTag; // 0x58
	private List<string> excludedTags; // 0x60
	private Dictionary<string, string> requiredKv; // 0x68
	private Nullable<bool> WantsReturnOnlyIDs; // 0x70
	private Nullable<bool> WantsReturnKeyValueTags; // 0x72
	private Nullable<bool> WantsReturnLongDescription; // 0x74
	private Nullable<bool> WantsReturnMetadata; // 0x76
	private Nullable<bool> WantsReturnChildren; // 0x78
	private Nullable<bool> WantsReturnAdditionalPreviews; // 0x7A
	private Nullable<bool> WantsReturnTotalOnly; // 0x7C
	private Nullable<uint> WantsReturnPlaytimeStats; // 0x80
	private Nullable<bool> WantsDefaultStats; // 0x88

	public static Query All { get; }


	public void .ctor(UgcType type) { }

	public static Query get_All() { }

	public Query RankedByPublicationDate() { }

	public Query RankedByAcceptanceDate() { }

	public Query RankedByTrend() { }

	internal Query LimitUser(SteamId steamid) { }

	public Query WhereUserPublished(SteamId user) { }

	public Query WithFileId(PublishedFileId[] files) { }

	[AsyncStateMachineAttribute] // RVA: 0x9F540 Offset: 0x9E940 VA: 0x18009F540
	public Task<Nullable<ResultPage>> GetPageAsync(int page) { }

	public Query WithTrendDays(int days) { }

	public Query MatchAllTags() { }

	public Query WithTag(string tag) { }

	private void ApplyConstraints(UGCQueryHandle_t handle) { }

	private void ApplyReturns(UGCQueryHandle_t handle) { }

}

private struct Query.<GetPageAsync>d__76 : IAsyncStateMachine // TypeDefIndex: 5280
{	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder<Nullable<ResultPage>> <>t__builder; // 0x8
	public int page; // 0x20
	public Query <>4__this; // 0x28
	private CallResult<SteamUGCQueryCompleted_t> <>u__1; // 0xB8


	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

