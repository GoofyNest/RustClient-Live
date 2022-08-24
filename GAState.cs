internal class GAState // TypeDefIndex: 5670
{
	private static readonly GAState _instance; 
	private string _userId; 
	private string _identifier; 
	private bool _initialized; 
	private long _sessionStart; 
	private int _sessionNum; 
	private int _transactionNum; 
	private string _sessionId; 
	private string _currentCustomDimension01; 
	private string _currentCustomDimension02; 
	private string _currentCustomDimension03; 
	private string _gameKey; 
	private string _gameSecret; 
	private string[] _availableCustomDimensions01; 
	private string[] _availableCustomDimensions02; 
	private string[] _availableCustomDimensions03; 
	private string[] _availableResourceCurrencies; 
	private string[] _availableResourceItemTypes; 
	private string _build; 
	private bool _isEventSubmissionEnabled; 
	[CompilerGeneratedAttribute] 
	private bool <Enabled>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private string <FacebookId>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private string <Gender>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private int <BirthYear>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private JSONNode <SdkConfigCached>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private bool <InitAuthorized>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private long <ClientServerTimeOffset>k__BackingField; 
	private string _defaultUserId; 
	private Dictionary<string, int> progressionTries; 
	private JSONNode sdkConfigDefault; 
	private JSONNode sdkConfig; 
	private JSONNode sdkConfigCached; 
	private JSONNode configurations; 
	private bool commandCenterIsReady; 
	private readonly List<ICommandCenterListener> commandCenterListeners; 
	private readonly object configurationsLock; 

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

	[CompilerGeneratedAttribute] 
private bool get_Enabled() { }

	[CompilerGeneratedAttribute] 
private void set_Enabled(bool value) { }

	[CompilerGeneratedAttribute] 
private string get_FacebookId() { }

	[CompilerGeneratedAttribute] 
private void set_FacebookId(string value) { }

	[CompilerGeneratedAttribute] 
private string get_Gender() { }

	[CompilerGeneratedAttribute] 
private void set_Gender(string value) { }

	[CompilerGeneratedAttribute] 
private int get_BirthYear() { }

	[CompilerGeneratedAttribute] 
private void set_BirthYear(int value) { }

	[CompilerGeneratedAttribute] 
private void set_SdkConfigCached(JSONNode value) { }

	[CompilerGeneratedAttribute] 
private bool get_InitAuthorized() { }

	[CompilerGeneratedAttribute] 
private void set_InitAuthorized(bool value) { }

	[CompilerGeneratedAttribute] 
private long get_ClientServerTimeOffset() { }

	[CompilerGeneratedAttribute] 
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

