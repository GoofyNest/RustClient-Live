public sealed class LobbySearch : Handle // TypeDefIndex: 9185
{
	public const int LobbysearchCopysearchresultbyindexApiLatest = 1;
	public const int LobbysearchFindApiLatest = 1;
	public const int LobbysearchGetsearchresultcountApiLatest = 1;
	public const int LobbysearchRemoveparameterApiLatest = 1;
	public const int LobbysearchSetlobbyidApiLatest = 1;
	public const int LobbysearchSetmaxresultsApiLatest = 1;
	public const int LobbysearchSetparameterApiLatest = 1;
	public const int LobbysearchSettargetuseridApiLatest = 1;


	public void .ctor() { }

	public void .ctor(IntPtr innerHandle) { }

	public Result CopySearchResultByIndex(ref LobbySearchCopySearchResultByIndexOptions options, out LobbyDetails outLobbyDetailsHandle) { }

	public void Find(ref LobbySearchFindOptions options, object clientData, LobbySearchOnFindCallback completionDelegate) { }

	public uint GetSearchResultCount(ref LobbySearchGetSearchResultCountOptions options) { }

	public void Release() { }

	public Result RemoveParameter(ref LobbySearchRemoveParameterOptions options) { }

	public Result SetLobbyId(ref LobbySearchSetLobbyIdOptions options) { }

	public Result SetMaxResults(ref LobbySearchSetMaxResultsOptions options) { }

	public Result SetParameter(ref LobbySearchSetParameterOptions options) { }

	public Result SetTargetUserId(ref LobbySearchSetTargetUserIdOptions options) { }

	[MonoPInvokeCallbackAttribute]
	internal static void OnFindCallbackInternalImplementation(ref LobbySearchFindCallbackInfoInternal data) { }

}

