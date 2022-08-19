public class BaseGameMode : BaseEntity // TypeDefIndex: 8517
{	// Fields
	private GameMode gameModeScores; // 0x168
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

	// Methods

	// RVA: 0xA1C9D0 Offset: 0xA1BDD0 VA: 0x180A1C9D0 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0xA1B2D0 Offset: 0xA1A6D0 VA: 0x180A1B2D0
	public GameMode GetGameScores() { }

	// RVA: 0xA1D1E0 Offset: 0xA1C5E0 VA: 0x180A1D1E0
	public int ScoreColumnIndex(string scoreName) { }

	// RVA: 0xA1C060 Offset: 0xA1B460 VA: 0x180A1C060
	public void InitScores() { }

	// RVA: 0xA1A850 Offset: 0xA19C50 VA: 0x180A1A850
	public void CopyGameModeScores(GameMode from, GameMode to) { }

	// RVA: 0xA1B640 Offset: 0xA1AA40 VA: 0x180A1B640
	public GameMode.PlayerScore GetPlayerScoreForPlayer(BasePlayer player) { }

	// RVA: 0xA1B8D0 Offset: 0xA1ACD0 VA: 0x180A1B8D0
	public int GetScoreIndexByName(string name) { }

	// RVA: 0xA1C5E0 Offset: 0xA1B9E0 VA: 0x180A1C5E0 Slot: 131
	public virtual bool IsDraw() { }

	// RVA: 0xA1BAB0 Offset: 0xA1AEB0 VA: 0x180A1BAB0 Slot: 132
	public virtual string GetWinnerName() { }

	// RVA: 0x513D80 Offset: 0x513180 VA: 0x180513D80 Slot: 133
	public virtual int GetPlayerTeamPosition(BasePlayer player) { }

	// RVA: 0xA1B430 Offset: 0xA1A830 VA: 0x180A1B430 Slot: 134
	public virtual int GetPlayerRank(BasePlayer player) { }

	// RVA: 0xA1BD60 Offset: 0xA1B160 VA: 0x180A1BD60
	public int GetWinningTeamIndex() { }

	// RVA: 0xA1AF80 Offset: 0xA1A380 VA: 0x180A1AF80 Slot: 135
	public virtual bool DidPlayerWin(BasePlayer player) { }

	// RVA: 0xA1C8A0 Offset: 0xA1BCA0 VA: 0x180A1C8A0
	public bool IsTeamGame() { }

	// RVA: 0xA1C8D0 Offset: 0xA1BCD0 VA: 0x180A1C8D0
	public bool KeepScores() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xA1D820 Offset: 0xA1CC20 VA: 0x180A1D820
	public static void add_GameModeChanged(Action<BaseGameMode> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xA1D910 Offset: 0xA1CD10 VA: 0x180A1D910
	public static void remove_GameModeChanged(Action<BaseGameMode> value) { }

	// RVA: 0xA1BE60 Offset: 0xA1B260 VA: 0x180A1BE60
	public bool HasAnyGameModeTag(string[] tags) { }

	// RVA: 0xA1BF30 Offset: 0xA1B330 VA: 0x180A1BF30
	public bool HasGameModeTag(string tag) { }

	// RVA: 0xA1A640 Offset: 0xA19A40 VA: 0x180A1A640
	public bool AllowsSleeping() { }

	// RVA: 0xA1BFE0 Offset: 0xA1B3E0 VA: 0x180A1BFE0
	public bool HasLoadouts() { }

	// RVA: 0xA1B400 Offset: 0xA1A800 VA: 0x180A1B400
	public int GetNumTeams() { }

	// RVA: 0xA1B9E0 Offset: 0xA1ADE0 VA: 0x180A1B9E0
	public int GetTeamScore(int teamIndex) { }

	// RVA: 0xA1D290 Offset: 0xA1C690 VA: 0x180A1D290
	public static void SetActiveGameMode(BaseGameMode newActive, bool serverside) { }

	// RVA: 0xA1B270 Offset: 0xA1A670 VA: 0x180A1B270
	public static BaseGameMode GetActiveGameMode(bool serverside) { }

	// RVA: 0xA1C900 Offset: 0xA1BD00 VA: 0x180A1C900 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x4989F0 Offset: 0x497DF0 VA: 0x1804989F0 Slot: 136
	public virtual bool InWarmup() { }

	// RVA: 0x5264E0 Offset: 0x5258E0 VA: 0x1805264E0 Slot: 137
	public virtual bool IsWaitingForPlayers() { }

	// RVA: 0x593220 Offset: 0x592620 VA: 0x180593220 Slot: 138
	public virtual bool IsMatchOver() { }

	// RVA: 0xA1C830 Offset: 0xA1BC30 VA: 0x180A1C830 Slot: 139
	public virtual bool IsMatchActive() { }

	// RVA: 0xA1C2C0 Offset: 0xA1B6C0 VA: 0x180A1C2C0 Slot: 28
	public override void InitShared() { }

	// RVA: 0xA1AE70 Offset: 0xA1A270 VA: 0x180A1AE70 Slot: 31
	public override void DestroyShared() { }

	// RVA: 0xA1C960 Offset: 0xA1BD60 VA: 0x180A1C960 Slot: 140
	protected virtual void OnCreated() { }

	// RVA: 0xA1AE00 Offset: 0xA1A200 VA: 0x180A1AE00
	public void DelayedRespawn() { }

	// RVA: 0xA1B160 Offset: 0xA1A560 VA: 0x180A1B160
	public void DoRespawn() { }

	// RVA: 0xA1CEF0 Offset: 0xA1C2F0 VA: 0x180A1CEF0 Slot: 16
	public override void PostNetworkUpdate() { }

	// RVA: 0xA1A760 Offset: 0xA19B60 VA: 0x180A1A760 Slot: 141
	protected virtual void ClientWarmupStart() { }

	// RVA: 0xA1A650 Offset: 0xA19A50 VA: 0x180A1A650 Slot: 142
	protected virtual void ClientMatchEnd() { }

	// RVA: 0xA1A740 Offset: 0xA19B40 VA: 0x180A1A740 Slot: 143
	protected virtual void ClientMatchStart() { }

	// RVA: 0xA1BA50 Offset: 0xA1AE50 VA: 0x180A1BA50 Slot: 144
	public virtual SoundDefinition GetWarmupMusic() { }

	// RVA: 0xA1B2E0 Offset: 0xA1A6E0 VA: 0x180A1B2E0 Slot: 145
	public virtual SoundDefinition GetMatchEndMusic() { }

	// RVA: 0xA1D5B0 Offset: 0xA1C9B0 VA: 0x180A1D5B0
	public float TimeUntilWarmupEnds() { }

	// RVA: 0xA1D4E0 Offset: 0xA1C8E0 VA: 0x180A1D4E0
	public float TimeUntilMatchResets() { }

	// RVA: 0xA1D410 Offset: 0xA1C810 VA: 0x180A1D410
	public float TimeUntilMatchEnds() { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xA1D0B0 Offset: 0xA1C4B0 VA: 0x180A1D0B0
	public void RPC_ScoreSplash(BaseEntity.RPCMessage msg) { }

	// RVA: 0xA1D710 Offset: 0xA1CB10 VA: 0x180A1D710
	public void .ctor() { }

	// RVA: 0xA1D680 Offset: 0xA1CA80 VA: 0x180A1D680
	private static void .cctor() { }

}

public class BaseGameMode.GameModeTeam // TypeDefIndex: 8518
{	// Fields
	public string name; // 0x10
	public PlayerInventoryProperties[] teamloadouts; // 0x18

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

}

