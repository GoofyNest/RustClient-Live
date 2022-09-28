public sealed class LeaderboardsInterface : Handle // TypeDefIndex: 9257
{
	public const int CopyleaderboarddefinitionbyindexApiLatest = 1;
	public const int CopyleaderboarddefinitionbyleaderboardidApiLatest = 1;
	public const int CopyleaderboardrecordbyindexApiLatest = 2;
	public const int CopyleaderboardrecordbyuseridApiLatest = 2;
	public const int CopyleaderboarduserscorebyindexApiLatest = 1;
	public const int CopyleaderboarduserscorebyuseridApiLatest = 1;
	public const int DefinitionApiLatest = 1;
	public const int GetleaderboarddefinitioncountApiLatest = 1;
	public const int GetleaderboardrecordcountApiLatest = 1;
	public const int GetleaderboarduserscorecountApiLatest = 1;
	public const int LeaderboardrecordApiLatest = 2;
	public const int LeaderboarduserscoreApiLatest = 1;
	public const int QueryleaderboarddefinitionsApiLatest = 2;
	public const int QueryleaderboardranksApiLatest = 2;
	public const int QueryleaderboarduserscoresApiLatest = 2;
	public const int TimeUndefined = -1;
	public const int UserscoresquerystatinfoApiLatest = 1;


	public void .ctor() { }

	public void .ctor(IntPtr innerHandle) { }

	public Result CopyLeaderboardDefinitionByIndex(ref CopyLeaderboardDefinitionByIndexOptions options, out Nullable<Definition> outLeaderboardDefinition) { }

	public Result CopyLeaderboardDefinitionByLeaderboardId(ref CopyLeaderboardDefinitionByLeaderboardIdOptions options, out Nullable<Definition> outLeaderboardDefinition) { }

	public Result CopyLeaderboardRecordByIndex(ref CopyLeaderboardRecordByIndexOptions options, out Nullable<LeaderboardRecord> outLeaderboardRecord) { }

	public Result CopyLeaderboardRecordByUserId(ref CopyLeaderboardRecordByUserIdOptions options, out Nullable<LeaderboardRecord> outLeaderboardRecord) { }

	public Result CopyLeaderboardUserScoreByIndex(ref CopyLeaderboardUserScoreByIndexOptions options, out Nullable<LeaderboardUserScore> outLeaderboardUserScore) { }

	public Result CopyLeaderboardUserScoreByUserId(ref CopyLeaderboardUserScoreByUserIdOptions options, out Nullable<LeaderboardUserScore> outLeaderboardUserScore) { }

	public uint GetLeaderboardDefinitionCount(ref GetLeaderboardDefinitionCountOptions options) { }

	public uint GetLeaderboardRecordCount(ref GetLeaderboardRecordCountOptions options) { }

	public uint GetLeaderboardUserScoreCount(ref GetLeaderboardUserScoreCountOptions options) { }

	public void QueryLeaderboardDefinitions(ref QueryLeaderboardDefinitionsOptions options, object clientData, OnQueryLeaderboardDefinitionsCompleteCallback completionDelegate) { }

	public void QueryLeaderboardRanks(ref QueryLeaderboardRanksOptions options, object clientData, OnQueryLeaderboardRanksCompleteCallback completionDelegate) { }

	public void QueryLeaderboardUserScores(ref QueryLeaderboardUserScoresOptions options, object clientData, OnQueryLeaderboardUserScoresCompleteCallback completionDelegate) { }

	[MonoPInvokeCallbackAttribute] 
	internal static void OnQueryLeaderboardDefinitionsCompleteCallbackInternalImplementation(ref OnQueryLeaderboardDefinitionsCompleteCallbackInfoInternal data) { }

	[MonoPInvokeCallbackAttribute] 
	internal static void OnQueryLeaderboardRanksCompleteCallbackInternalImplementation(ref OnQueryLeaderboardRanksCompleteCallbackInfoInternal data) { }

	[MonoPInvokeCallbackAttribute] 
	internal static void OnQueryLeaderboardUserScoresCompleteCallbackInternalImplementation(ref OnQueryLeaderboardUserScoresCompleteCallbackInfoInternal data) { }

}

