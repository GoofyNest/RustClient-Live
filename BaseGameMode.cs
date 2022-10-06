public class BaseGameMode : BaseEntity // TypeDefIndex: 10223
{
	private GameMode gameModeScores; 
	public string[] scoreColumns; 
	[HeaderAttribute] 
	public bool globalChat; 
	public bool localChat; 
	public bool teamSystem; 
	public bool safeZone; 
	public bool ingameMap; 
	public bool compass; 
	public bool contactSystem; 
	public bool crawling; 
	public bool rustPlus; 
	public bool wipeBpsOnProtocol; 
	public int maximumSleepingBags; 
	public bool returnValidCombatlog; 
	public bool missionSystem; 
	public bool mlrs; 
	public const BaseEntity.Flags Flag_Warmup = 128;
	public const BaseEntity.Flags Flag_GameOver = 256;
	public const BaseEntity.Flags Flag_WaitingForPlayers = 512;
	[HeaderAttribute] 
	public Translate.Phrase[] addedFeatures; 
	public Translate.Phrase[] removedFeatures; 
	public Translate.Phrase[] changedFeatures; 
	public List<string> convars; 
	[CompilerGeneratedAttribute] 
	private static Action<BaseGameMode> GameModeChanged; 
	public string shortname; 
	public float matchDuration; 
	public float warmupDuration; 
	public float timeBetweenMatches; 
	public int minPlayersToStart; 
	public bool useCustomSpawns; 
	public string victoryScoreName; 
	public string teamScoreName; 
	public int numScoreForVictory; 
	public string gamemodeTitle; 
	public SoundDefinition[] warmupMusics; 
	public SoundDefinition[] lossMusics; 
	public SoundDefinition[] winMusics; 
	private float warmupStartTime; 
	private float matchStartTime; 
	private float matchEndTime; 
	public List<string> gameModeTags; 
	public BasePlayer.CameraMode deathCameraMode; 
	public bool permanent; 
	public bool limitTeamAuths; 
	public bool allowSleeping; 
	public bool allowWounding; 
	public bool allowBleeding; 
	public bool allowTemperature; 
	public bool quickRespawn; 
	public float respawnDelayOverride; 
	public float startHealthOverride; 
	public float autoHealDelay; 
	public float autoHealDuration; 
	public bool hasKillFeed; 
	public static BaseGameMode clActiveGameMode; 
	public static List<BaseGameMode> clGameModeManifest; 
	public PlayerInventoryProperties[] loadouts; 
	[TooltipAttribute] 
	public bool useStaticLoadoutPerPlayer; 
	public bool topUpMagazines; 
	public bool sendKillNotifications; 
	public BaseGameMode.GameModeTeam[] teams; 
	private bool wasInWarmup; 
	private bool wasMatchOver; 
	private bool wasMatchActive; 


	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	public GameMode GetGameScores() { }

	public int ScoreColumnIndex(string scoreName) { }

	public void InitScores() { }

	public void CopyGameModeScores(GameMode from, GameMode to) { }

	public GameMode.PlayerScore GetPlayerScoreForPlayer(BasePlayer player) { }

	public int GetScoreIndexByName(string name) { }

	public virtual bool IsDraw() { }

	public virtual string GetWinnerName() { }

	public virtual int GetPlayerTeamPosition(BasePlayer player) { }

	public virtual int GetPlayerRank(BasePlayer player) { }

	public int GetWinningTeamIndex() { }

	public virtual bool DidPlayerWin(BasePlayer player) { }

	public bool IsTeamGame() { }

	public bool KeepScores() { }

	public int GetMaxBeds(BasePlayer player) { }

	protected virtual void SetupTags() { }

	public virtual BaseGameMode.ResearchCostResult GetScrapCostForResearch(ItemDefinition item, ResearchTable.ResearchType researchType) { }

	protected void OnCreated_Vanilla() { }

	[CompilerGeneratedAttribute] 
	public static void add_GameModeChanged(Action<BaseGameMode> value) { }

	[CompilerGeneratedAttribute] 
	public static void remove_GameModeChanged(Action<BaseGameMode> value) { }

	public bool HasAnyGameModeTag(string[] tags) { }

	public bool HasGameModeTag(string tag) { }

	public bool AllowsSleeping() { }

	public bool HasLoadouts() { }

	public int GetNumTeams() { }

	public int GetTeamScore(int teamIndex) { }

	public static void SetActiveGameMode(BaseGameMode newActive, bool serverside) { }

	public static BaseGameMode GetActiveGameMode(bool serverside) { }

	public override void Load(BaseNetworkable.LoadInfo info) { }

	public virtual bool InWarmup() { }

	public virtual bool IsWaitingForPlayers() { }

	public virtual bool IsMatchOver() { }

	public virtual bool IsMatchActive() { }

	public override void InitShared() { }

	public override void DestroyShared() { }

	protected virtual void OnCreated() { }

	public void DelayedRespawn() { }

	public void DoRespawn() { }

	public override void PostNetworkUpdate() { }

	protected virtual void ClientWarmupStart() { }

	protected virtual void ClientMatchEnd() { }

	protected virtual void ClientMatchStart() { }

	public virtual SoundDefinition GetWarmupMusic() { }

	public virtual SoundDefinition GetMatchEndMusic() { }

	public float TimeUntilWarmupEnds() { }

	public float TimeUntilMatchResets() { }

	public float TimeUntilMatchEnds() { }

	[BaseEntity.RPC_Client] 
	public void RPC_ScoreSplash(BaseEntity.RPCMessage msg) { }

	public void .ctor() { }

	private static void .cctor() { }

}

public struct BaseGameMode.ResearchCostResult // TypeDefIndex: 10224
{
	public Nullable<float> Scale; 
	public Nullable<int> Amount; 

}

public class BaseGameMode.GameModeTeam // TypeDefIndex: 10225
{
	public string name; 
	public PlayerInventoryProperties[] teamloadouts; 


	public void .ctor() { }

}

