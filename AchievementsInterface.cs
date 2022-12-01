public sealed class AchievementsInterface : Handle // TypeDefIndex: 9890
{
	public const int AchievementUnlocktimeUndefined = -1;
	public const int AddnotifyachievementsunlockedApiLatest = 1;
	public const int Addnotifyachievementsunlockedv2ApiLatest = 2;
	public const int Copyachievementdefinitionv2ByachievementidApiLatest = 2;
	public const int Copyachievementdefinitionv2ByindexApiLatest = 2;
	public const int CopydefinitionbyachievementidApiLatest = 1;
	public const int CopydefinitionbyindexApiLatest = 1;
	public const int Copydefinitionv2ByachievementidApiLatest = 2;
	public const int Copydefinitionv2ByindexApiLatest = 2;
	public const int CopyplayerachievementbyachievementidApiLatest = 2;
	public const int CopyplayerachievementbyindexApiLatest = 2;
	public const int CopyunlockedachievementbyachievementidApiLatest = 1;
	public const int CopyunlockedachievementbyindexApiLatest = 1;
	public const int DefinitionApiLatest = 1;
	public const int Definitionv2ApiLatest = 2;
	public const int GetachievementdefinitioncountApiLatest = 1;
	public const int GetplayerachievementcountApiLatest = 1;
	public const int GetunlockedachievementcountApiLatest = 1;
	public const int PlayerachievementApiLatest = 2;
	public const int PlayerstatinfoApiLatest = 1;
	public const int QuerydefinitionsApiLatest = 3;
	public const int QueryplayerachievementsApiLatest = 2;
	public const int StatthresholdApiLatest = 1;
	public const int StatthresholdsApiLatest = 1;
	public const int UnlockachievementsApiLatest = 1;
	public const int UnlockedachievementApiLatest = 1;


	public void .ctor() { }

	public void .ctor(IntPtr innerHandle) { }

	public ulong AddNotifyAchievementsUnlocked(ref AddNotifyAchievementsUnlockedOptions options, object clientData, OnAchievementsUnlockedCallback notificationFn) { }

	public ulong AddNotifyAchievementsUnlockedV2(ref AddNotifyAchievementsUnlockedV2Options options, object clientData, OnAchievementsUnlockedCallbackV2 notificationFn) { }

	public Result CopyAchievementDefinitionByAchievementId(ref CopyAchievementDefinitionByAchievementIdOptions options, out Nullable<Definition> outDefinition) { }

	public Result CopyAchievementDefinitionByIndex(ref CopyAchievementDefinitionByIndexOptions options, out Nullable<Definition> outDefinition) { }

	public Result CopyAchievementDefinitionV2ByAchievementId(ref CopyAchievementDefinitionV2ByAchievementIdOptions options, out Nullable<DefinitionV2> outDefinition) { }

	public Result CopyAchievementDefinitionV2ByIndex(ref CopyAchievementDefinitionV2ByIndexOptions options, out Nullable<DefinitionV2> outDefinition) { }

	public Result CopyPlayerAchievementByAchievementId(ref CopyPlayerAchievementByAchievementIdOptions options, out Nullable<PlayerAchievement> outAchievement) { }

	public Result CopyPlayerAchievementByIndex(ref CopyPlayerAchievementByIndexOptions options, out Nullable<PlayerAchievement> outAchievement) { }

	public Result CopyUnlockedAchievementByAchievementId(ref CopyUnlockedAchievementByAchievementIdOptions options, out Nullable<UnlockedAchievement> outAchievement) { }

	public Result CopyUnlockedAchievementByIndex(ref CopyUnlockedAchievementByIndexOptions options, out Nullable<UnlockedAchievement> outAchievement) { }

	public uint GetAchievementDefinitionCount(ref GetAchievementDefinitionCountOptions options) { }

	public uint GetPlayerAchievementCount(ref GetPlayerAchievementCountOptions options) { }

	public uint GetUnlockedAchievementCount(ref GetUnlockedAchievementCountOptions options) { }

	public void QueryDefinitions(ref QueryDefinitionsOptions options, object clientData, OnQueryDefinitionsCompleteCallback completionDelegate) { }

	public void QueryPlayerAchievements(ref QueryPlayerAchievementsOptions options, object clientData, OnQueryPlayerAchievementsCompleteCallback completionDelegate) { }

	public void RemoveNotifyAchievementsUnlocked(ulong inId) { }

	public void UnlockAchievements(ref UnlockAchievementsOptions options, object clientData, OnUnlockAchievementsCompleteCallback completionDelegate) { }

	[MonoPInvokeCallbackAttribute]
	internal static void OnAchievementsUnlockedCallbackInternalImplementation(ref OnAchievementsUnlockedCallbackInfoInternal data) { }

	[MonoPInvokeCallbackAttribute]
	internal static void OnAchievementsUnlockedCallbackV2InternalImplementation(ref OnAchievementsUnlockedCallbackV2InfoInternal data) { }

	[MonoPInvokeCallbackAttribute]
	internal static void OnQueryDefinitionsCompleteCallbackInternalImplementation(ref OnQueryDefinitionsCompleteCallbackInfoInternal data) { }

	[MonoPInvokeCallbackAttribute]
	internal static void OnQueryPlayerAchievementsCompleteCallbackInternalImplementation(ref OnQueryPlayerAchievementsCompleteCallbackInfoInternal data) { }

	[MonoPInvokeCallbackAttribute]
	internal static void OnUnlockAchievementsCompleteCallbackInternalImplementation(ref OnUnlockAchievementsCompleteCallbackInfoInternal data) { }

}

