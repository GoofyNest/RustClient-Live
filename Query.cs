public struct Query // TypeDefIndex: 5279
{	// Fields
	private UgcType matchingType; // 0x0
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

	// Properties
	public static Query All { get; }

	// Methods

	// RVA: 0x224900 Offset: 0x223D00 VA: 0x180224900
	public void .ctor(UgcType type) { }

	// RVA: 0x19D1C50 Offset: 0x19D1050 VA: 0x1819D1C50
	public static Query get_All() { }

	// RVA: 0x2245D0 Offset: 0x2239D0 VA: 0x1802245D0
	public Query RankedByPublicationDate() { }

	// RVA: 0x224570 Offset: 0x223970 VA: 0x180224570
	public Query RankedByAcceptanceDate() { }

	// RVA: 0x224630 Offset: 0x223A30 VA: 0x180224630
	public Query RankedByTrend() { }

	// RVA: 0x2244A0 Offset: 0x2238A0 VA: 0x1802244A0
	internal Query LimitUser(SteamId steamid) { }

	// RVA: 0x224690 Offset: 0x223A90 VA: 0x180224690
	public Query WhereUserPublished(SteamId user) { }

	// RVA: 0x224720 Offset: 0x223B20 VA: 0x180224720
	public Query WithFileId(PublishedFileId[] files) { }

	[AsyncStateMachineAttribute] // RVA: 0x9F540 Offset: 0x9E940 VA: 0x18009F540
	// RVA: 0x224490 Offset: 0x223890 VA: 0x180224490
	public Task<Nullable<ResultPage>> GetPageAsync(int page) { }

	// RVA: 0x224840 Offset: 0x223C40 VA: 0x180224840
	public Query WithTrendDays(int days) { }

	// RVA: 0x2244C0 Offset: 0x2238C0 VA: 0x1802244C0
	public Query MatchAllTags() { }

	// RVA: 0x224740 Offset: 0x223B40 VA: 0x180224740
	public Query WithTag(string tag) { }

	// RVA: 0x224470 Offset: 0x223870 VA: 0x180224470
	private void ApplyConstraints(UGCQueryHandle_t handle) { }

	// RVA: 0x224480 Offset: 0x223880 VA: 0x180224480
	private void ApplyReturns(UGCQueryHandle_t handle) { }

}

private struct Query.<GetPageAsync>d__76 : IAsyncStateMachine // TypeDefIndex: 5280
{	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder<Nullable<ResultPage>> <>t__builder; // 0x8
	public int page; // 0x20
	public Query <>4__this; // 0x28
	private CallResult<SteamUGCQueryCompleted_t> <>u__1; // 0xB8

	// Methods

	// RVA: 0x224CA0 Offset: 0x2240A0 VA: 0x180224CA0 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x224CB0 Offset: 0x2240B0 VA: 0x180224CB0 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

