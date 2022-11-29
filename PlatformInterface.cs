public sealed class PlatformInterface : Handle // TypeDefIndex: 9860
{
	public const int AndroidInitializeoptionssysteminitializeoptionsApiLatest = 2;
	public const int CountrycodeMaxBufferLen = 5;
	public const int CountrycodeMaxLength = 4;
	public const int GetdesktopcrossplaystatusApiLatest = 1;
	public const int InitializeApiLatest = 4;
	public const int InitializeThreadaffinityApiLatest = 2;
	public const int LocalecodeMaxBufferLen = 10;
	public const int LocalecodeMaxLength = 9;
	public const int OptionsApiLatest = 12;
	public const int RtcoptionsApiLatest = 1;
	public const int WindowsRtcoptionsplatformspecificoptionsApiLatest = 1;


	public static Result Initialize(ref AndroidInitializeOptions options) { }

	public void .ctor() { }

	public void .ctor(IntPtr innerHandle) { }

	public Result CheckForLauncherAndRestart() { }

	public static PlatformInterface Create(ref Options options) { }

	public AchievementsInterface GetAchievementsInterface() { }

	public Result GetActiveCountryCode(EpicAccountId localUserId, out Utf8String outBuffer) { }

	public Result GetActiveLocaleCode(EpicAccountId localUserId, out Utf8String outBuffer) { }

	public AntiCheatClientInterface GetAntiCheatClientInterface() { }

	public AntiCheatServerInterface GetAntiCheatServerInterface() { }

	public ApplicationStatus GetApplicationStatus() { }

	public AuthInterface GetAuthInterface() { }

	public ConnectInterface GetConnectInterface() { }

	public CustomInvitesInterface GetCustomInvitesInterface() { }

	public Result GetDesktopCrossplayStatus(ref GetDesktopCrossplayStatusOptions options, out GetDesktopCrossplayStatusInfo outDesktopCrossplayStatusInfo) { }

	public EcomInterface GetEcomInterface() { }

	public FriendsInterface GetFriendsInterface() { }

	public KWSInterface GetKWSInterface() { }

	public LeaderboardsInterface GetLeaderboardsInterface() { }

	public LobbyInterface GetLobbyInterface() { }

	public MetricsInterface GetMetricsInterface() { }

	public ModsInterface GetModsInterface() { }

	public NetworkStatus GetNetworkStatus() { }

	public Result GetOverrideCountryCode(out Utf8String outBuffer) { }

	public Result GetOverrideLocaleCode(out Utf8String outBuffer) { }

	public P2PInterface GetP2PInterface() { }

	public PlayerDataStorageInterface GetPlayerDataStorageInterface() { }

	public PresenceInterface GetPresenceInterface() { }

	public ProgressionSnapshotInterface GetProgressionSnapshotInterface() { }

	public RTCAdminInterface GetRTCAdminInterface() { }

	public RTCInterface GetRTCInterface() { }

	public ReportsInterface GetReportsInterface() { }

	public SanctionsInterface GetSanctionsInterface() { }

	public SessionsInterface GetSessionsInterface() { }

	public StatsInterface GetStatsInterface() { }

	public TitleStorageInterface GetTitleStorageInterface() { }

	public UIInterface GetUIInterface() { }

	public UserInfoInterface GetUserInfoInterface() { }

	public static Result Initialize(ref InitializeOptions options) { }

	public void Release() { }

	public Result SetApplicationStatus(ApplicationStatus newStatus) { }

	public Result SetNetworkStatus(NetworkStatus newStatus) { }

	public Result SetOverrideCountryCode(Utf8String newCountryCode) { }

	public Result SetOverrideLocaleCode(Utf8String newLocaleCode) { }

	public static Result Shutdown() { }

	public void Tick() { }

	public static PlatformInterface Create(ref WindowsOptions options) { }

}

