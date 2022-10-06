public struct Query // TypeDefIndex: 5283
{
	private UgcType matchingType; 
	private UGCQuery queryType; 
	private AppId consumerApp; 
	private AppId creatorApp; 
	private string searchText; 
	private Nullable<SteamId> steamid; 
	private UserUGCList userType; 
	private UserUGCListSortOrder userSort; 
	private PublishedFileId[] Files; 
	private Nullable<int> maxCacheAge; 
	private string language; 
	private Nullable<int> trendDays; 
	private List<string> requiredTags; 
	private Nullable<bool> matchAnyTag; 
	private List<string> excludedTags; 
	private Dictionary<string, string> requiredKv; 
	private Nullable<bool> WantsReturnOnlyIDs; 
	private Nullable<bool> WantsReturnKeyValueTags; 
	private Nullable<bool> WantsReturnLongDescription; 
	private Nullable<bool> WantsReturnMetadata; 
	private Nullable<bool> WantsReturnChildren; 
	private Nullable<bool> WantsReturnAdditionalPreviews; 
	private Nullable<bool> WantsReturnTotalOnly; 
	private Nullable<uint> WantsReturnPlaytimeStats; 
	private Nullable<bool> WantsDefaultStats; 

	public static Query All { get; }


	public void .ctor(UgcType type) { }

	public static Query get_All() { }

	public Query RankedByPublicationDate() { }

	public Query RankedByAcceptanceDate() { }

	public Query RankedByTrend() { }

	internal Query LimitUser(SteamId steamid) { }

	public Query WhereUserPublished(SteamId user) { }

	public Query WithFileId(PublishedFileId[] files) { }

	[AsyncStateMachineAttribute] 
	public Task<Nullable<ResultPage>> GetPageAsync(int page) { }

	public Query WithTrendDays(int days) { }

	public Query MatchAllTags() { }

	public Query WithTag(string tag) { }

	private void ApplyConstraints(UGCQueryHandle_t handle) { }

	private void ApplyReturns(UGCQueryHandle_t handle) { }

}

private struct Query.<GetPageAsync>d__76 : IAsyncStateMachine // TypeDefIndex: 5284
{
	public int <>1__state; 
	public AsyncTaskMethodBuilder<Nullable<ResultPage>> <>t__builder; 
	public int page; 
	public Query <>4__this; 
	private CallResult<SteamUGCQueryCompleted_t> <>u__1; 


	private void MoveNext() { }

	[DebuggerHiddenAttribute] 
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

