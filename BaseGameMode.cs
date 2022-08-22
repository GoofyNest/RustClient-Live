public class BaseGameMode : BaseEntity // TypeDefIndex: 8517
{	private GameMode gameModeScores; // 0x168
	public string[] scoreColumns; // 0x170
	public const BaseEntity.Flags Flag_Warmup = 128;
	public const BaseEntity.Flags Flag_GameOver = 256;
	public const BaseEntity.Flags Flag_WaitingForPlayers = 512;
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private static Action<BaseGameMode> GameModeChanged; // 0x0
	public string shortname; // 0x178
	public float matchDuration; // 0x180
	public float warmupDuration; // 0x184
	public float timeBetweenMatches; // 0x188
	public int minPlayersToStart; // 0x18C
	public bool useCustomSpawns; // 0x190
	public string victoryScoreName; // 0x198
	public string teamScoreName; // 0x1A0
	public int numScoreForVictory; // 0x1A8
	public string gamemodeTitle; // 0x1B0
	public SoundDefinition[] warmupMusics; // 0x1B8
	public SoundDefinition[] lossMusics; // 0x1C0
	public SoundDefinition[] winMusics; // 0x1C8
	private float warmupStartTime; // 0x1D0
	private float matchStartTime; // 0x1D4
	private float matchEndTime; // 0x1D8
	public string[] gameModeTags; // 0x1E0
	public BasePlayer.CameraMode deathCameraMode; // 0x1E8
	public bool permanent; // 0x1EC
	public bool limitTeamAuths; // 0x1ED
	public bool allowSleeping; // 0x1EE
	public bool allowWounding; // 0x1EF
	public bool allowBleeding; // 0x1F0
	public bool allowTemperature; // 0x1F1
	public bool quickRespawn; // 0x1F2
	public float respawnDelayOverride; // 0x1F4
	public float startHealthOverride; // 0x1F8
	public float autoHealDelay; // 0x1FC
	public float autoHealDuration; // 0x200
	public bool hasKillFeed; // 0x204
	public static BaseGameMode clActiveGameMode; // 0x8
	public static List<BaseGameMode> clGameModeManifest; // 0x10
	public PlayerInventoryProperties[] loadouts; // 0x208
	[TooltipAttribute] // RVA: 0xA2530 Offset: 0xA1930 VA: 0x1800A2530
	public bool useStaticLoadoutPerPlayer; // 0x210
	public bool topUpMagazines; // 0x211
	public bool sendKillNotifications; // 0x212
	public BaseGameMode.GameModeTeam[] teams; // 0x218
	private bool wasInWarmup; // 0x220
	private bool wasMatchOver; // 0x221
	private bool wasMatchActive; // 0x222


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

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public static void add_GameModeChanged(Action<BaseGameMode> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
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

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void RPC_ScoreSplash(BaseEntity.RPCMessage msg) { }

	public void .ctor() { }

	private static void .cctor() { }

}

public class BaseGameMode.GameModeTeam // TypeDefIndex: 8518
{	public string name; // 0x10
	public PlayerInventoryProperties[] teamloadouts; // 0x18


	public void .ctor() { }

}

