internal class GAState // TypeDefIndex: 5670
{	private static readonly GAState _instance; // 0x0
	private string _userId; // 0x10
	private string _identifier; // 0x18
	private bool _initialized; // 0x20
	private long _sessionStart; // 0x28
	private int _sessionNum; // 0x30
	private int _transactionNum; // 0x34
	private string _sessionId; // 0x38
	private string _currentCustomDimension01; // 0x40
	private string _currentCustomDimension02; // 0x48
	private string _currentCustomDimension03; // 0x50
	private string _gameKey; // 0x58
	private string _gameSecret; // 0x60
	private string[] _availableCustomDimensions01; // 0x68
	private string[] _availableCustomDimensions02; // 0x70
	private string[] _availableCustomDimensions03; // 0x78
	private string[] _availableResourceCurrencies; // 0x80
	private string[] _availableResourceItemTypes; // 0x88
	private string _build; // 0x90
	private bool _isEventSubmissionEnabled; // 0x98
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private bool <Enabled>k__BackingField; // 0x99
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private string <FacebookId>k__BackingField; // 0xA0
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private string <Gender>k__BackingField; // 0xA8
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private int <BirthYear>k__BackingField; // 0xB0
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private JSONNode <SdkConfigCached>k__BackingField; // 0xB8
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private bool <InitAuthorized>k__BackingField; // 0xC0
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private long <ClientServerTimeOffset>k__BackingField; // 0xC8
	private string _defaultUserId; // 0xD0
	private Dictionary<string, int> progressionTries; // 0xD8
	private JSONNode sdkConfigDefault; // 0xE0
	private JSONNode sdkConfig; // 0xE8
	private JSONNode sdkConfigCached; // 0xF0
	private JSONNode configurations; // 0xF8
	private bool commandCenterIsReady; // 0x100
	private readonly List<ICommandCenterListener> commandCenterListeners; // 0x108
	private readonly object configurationsLock; // 0x110

	private static GAState Instance { get; }
	private static string UserId { get; set; }
	public static string Identifier { get; set; }
	public static bool Initialized { get; set; }
	public static long SessionStart { get; set; }
	public static int SessionNum { get; set; }
	public static int TransactionNum { get; set; }
	public static string SessionId { get; set; }
	public static string CurrentCustomDimension01 { get; set; }
	public static string CurrentCustomDimension02 { get; set; }
	public static string CurrentCustomDimension03 { get; set; }
	public static string GameKey { get; set; }
	public static string GameSecret { get; set; }
	public static string[] AvailableCustomDimensions01 { get; }
	public static string[] AvailableCustomDimensions02 { get; }
	public static string[] AvailableCustomDimensions03 { get; }
	public static string Build { get; set; }
	public static bool IsEventSubmissionEnabled { get; }
	private bool Enabled { get; set; }
	private string FacebookId { get; set; }
	private string Gender { get; set; }
	private int BirthYear { get; set; }
	private JSONNode SdkConfigCached { set; }
	private bool InitAuthorized { get; set; }
	private long ClientServerTimeOffset { get; set; }
	private string DefaultUserId { get; set; }
	private static JSONNode SdkConfig { get; }


	private static GAState get_Instance() { }

	private static string get_UserId() { }

	public static void set_UserId(string value) { }

	public static string get_Identifier() { }

	private static void set_Identifier(string value) { }

	public static bool get_Initialized() { }

	private static void set_Initialized(bool value) { }

	public static long get_SessionStart() { }

	private static void set_SessionStart(long value) { }

	public static int get_SessionNum() { }

	private static void set_SessionNum(int value) { }

	public static int get_TransactionNum() { }

	private static void set_TransactionNum(int value) { }

	public static string get_SessionId() { }

	private static void set_SessionId(string value) { }

	public static string get_CurrentCustomDimension01() { }

	private static void set_CurrentCustomDimension01(string value) { }

	public static string get_CurrentCustomDimension02() { }

	private static void set_CurrentCustomDimension02(string value) { }

	public static string get_CurrentCustomDimension03() { }

	private static void set_CurrentCustomDimension03(string value) { }

	public static string get_GameKey() { }

	private static void set_GameKey(string value) { }

	public static string get_GameSecret() { }

	private static void set_GameSecret(string value) { }

	public static string[] get_AvailableCustomDimensions01() { }

	public static string[] get_AvailableCustomDimensions02() { }

	public static string[] get_AvailableCustomDimensions03() { }

	public static string get_Build() { }

	public static void set_Build(string value) { }

	public static bool get_IsEventSubmissionEnabled() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private bool get_Enabled() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void set_Enabled(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private string get_FacebookId() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void set_FacebookId(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private string get_Gender() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void set_Gender(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private int get_BirthYear() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void set_BirthYear(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void set_SdkConfigCached(JSONNode value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private bool get_InitAuthorized() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void set_InitAuthorized(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private long get_ClientServerTimeOffset() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void set_ClientServerTimeOffset(long value) { }

	private string get_DefaultUserId() { }

	private void set_DefaultUserId(string value) { }

	private static JSONNode get_SdkConfig() { }

	private void .ctor() { }

	protected override void Finalize() { }

	public static bool IsEnabled() { }

	public static void SetCustomDimension01(string dimension) { }

	public static void SetCustomDimension02(string dimension) { }

	public static void SetCustomDimension03(string dimension) { }

	public static void IncrementSessionNum() { }

	public static void IncrementTransactionNum() { }

	public static bool HasAvailableCustomDimensions01(string dimension1) { }

	public static bool HasAvailableCustomDimensions02(string dimension2) { }

	public static bool HasAvailableCustomDimensions03(string dimension3) { }

	public static void SetKeys(string gameKey, string gameSecret) { }

	public static void InternalInitialize() { }

	public static void EndSessionAndStopQueue(bool endThread) { }

	public static JSONObject GetEventAnnotations() { }

	public static JSONObject GetInitAnnotations() { }

	public static long GetClientTsAdjusted() { }

	public static bool SessionIsStarted() { }

	public static JSONObject ValidateAndCleanCustomFields(IDictionary<string, object> fields) { }

	private static void CacheIdentifier() { }

	private static void EnsurePersistedStates() { }

	private static void StartNewSession() { }

	public static void StartNewSession(EGAHTTPApiResponse initResponse, JSONObject initResponseDict) { }

	private static void ValidateAndFixCurrentDimensions() { }

	private static long CalculateServerTimeOffset(long serverTs) { }

	private static void PopulateConfigurations(JSONNode sdkConfig) { }

	private static void .cctor() { }

}

