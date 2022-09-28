public sealed class SessionSearch : Handle // TypeDefIndex: 8539
{
	public const int SessionsearchCopysearchresultbyindexApiLatest = 1;
	public const int SessionsearchFindApiLatest = 2;
	public const int SessionsearchGetsearchresultcountApiLatest = 1;
	public const int SessionsearchRemoveparameterApiLatest = 1;
	public const int SessionsearchSetmaxsearchresultsApiLatest = 1;
	public const int SessionsearchSetparameterApiLatest = 1;
	public const int SessionsearchSetsessionidApiLatest = 1;
	public const int SessionsearchSettargetuseridApiLatest = 1;


	public void .ctor() { }

	public void .ctor(IntPtr innerHandle) { }

	public Result CopySearchResultByIndex(ref SessionSearchCopySearchResultByIndexOptions options, out SessionDetails outSessionHandle) { }

	public void Find(ref SessionSearchFindOptions options, object clientData, SessionSearchOnFindCallback completionDelegate) { }

	public uint GetSearchResultCount(ref SessionSearchGetSearchResultCountOptions options) { }

	public void Release() { }

	public Result RemoveParameter(ref SessionSearchRemoveParameterOptions options) { }

	public Result SetMaxResults(ref SessionSearchSetMaxResultsOptions options) { }

	public Result SetParameter(ref SessionSearchSetParameterOptions options) { }

	public Result SetSessionId(ref SessionSearchSetSessionIdOptions options) { }

	public Result SetTargetUserId(ref SessionSearchSetTargetUserIdOptions options) { }

	[MonoPInvokeCallbackAttribute] 
	internal static void OnFindCallbackInternalImplementation(ref SessionSearchFindCallbackInfoInternal data) { }

}

