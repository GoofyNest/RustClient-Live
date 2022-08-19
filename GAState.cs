internal class GAState // TypeDefIndex: 5670
{	// Fields
	private static readonly GAState _instance; // 0x0
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

	// Properties
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

	// Methods

	// RVA: 0x13BABA0 Offset: 0x13B9FA0 VA: 0x1813BABA0
	private static GAState get_Instance() { }

	// RVA: 0x13BB3A0 Offset: 0x13BA7A0 VA: 0x1813BB3A0
	private static string get_UserId() { }

	// RVA: 0x13BBE20 Offset: 0x13BB220 VA: 0x1813BBE20
	public static void set_UserId(string value) { }

	// RVA: 0x13BAA40 Offset: 0x13B9E40 VA: 0x1813BAA40
	public static string get_Identifier() { }

	// RVA: 0x13BB9E0 Offset: 0x13BADE0 VA: 0x1813BB9E0
	private static void set_Identifier(string value) { }

	// RVA: 0x13BAAF0 Offset: 0x13B9EF0 VA: 0x1813BAAF0
	public static bool get_Initialized() { }

	// RVA: 0x13BBAA0 Offset: 0x13BAEA0 VA: 0x1813BBAA0
	private static void set_Initialized(bool value) { }

	// RVA: 0x13BB240 Offset: 0x13BA640 VA: 0x1813BB240
	public static long get_SessionStart() { }

	// RVA: 0x13BBCC0 Offset: 0x13BB0C0 VA: 0x1813BBCC0
	private static void set_SessionStart(long value) { }

	// RVA: 0x13BB190 Offset: 0x13BA590 VA: 0x1813BB190
	public static int get_SessionNum() { }

	// RVA: 0x13BBC10 Offset: 0x13BB010 VA: 0x1813BBC10
	private static void set_SessionNum(int value) { }

	// RVA: 0x13BB2F0 Offset: 0x13BA6F0 VA: 0x1813BB2F0
	public static int get_TransactionNum() { }

	// RVA: 0x13BBD70 Offset: 0x13BB170 VA: 0x1813BBD70
	private static void set_TransactionNum(int value) { }

	// RVA: 0x13BB0E0 Offset: 0x13BA4E0 VA: 0x1813BB0E0
	public static string get_SessionId() { }

	// RVA: 0x13BBB50 Offset: 0x13BAF50 VA: 0x1813BBB50
	private static void set_SessionId(string value) { }

	// RVA: 0x13BA610 Offset: 0x13B9A10 VA: 0x1813BA610
	public static string get_CurrentCustomDimension01() { }

	// RVA: 0x13BB520 Offset: 0x13BA920 VA: 0x1813BB520
	private static void set_CurrentCustomDimension01(string value) { }

	// RVA: 0x13BA6C0 Offset: 0x13B9AC0 VA: 0x1813BA6C0
	public static string get_CurrentCustomDimension02() { }

	// RVA: 0x13BB5E0 Offset: 0x13BA9E0 VA: 0x1813BB5E0
	private static void set_CurrentCustomDimension02(string value) { }

	// RVA: 0x13BA770 Offset: 0x13B9B70 VA: 0x1813BA770
	public static string get_CurrentCustomDimension03() { }

	// RVA: 0x13BB6A0 Offset: 0x13BAAA0 VA: 0x1813BB6A0
	private static void set_CurrentCustomDimension03(string value) { }

	// RVA: 0x13BA8E0 Offset: 0x13B9CE0 VA: 0x1813BA8E0
	public static string get_GameKey() { }

	// RVA: 0x13BB860 Offset: 0x13BAC60 VA: 0x1813BB860
	private static void set_GameKey(string value) { }

	// RVA: 0x13BA990 Offset: 0x13B9D90 VA: 0x1813BA990
	public static string get_GameSecret() { }

	// RVA: 0x13BB920 Offset: 0x13BAD20 VA: 0x1813BB920
	private static void set_GameSecret(string value) { }

	// RVA: 0x13BA350 Offset: 0x13B9750 VA: 0x1813BA350
	public static string[] get_AvailableCustomDimensions01() { }

	// RVA: 0x13BA400 Offset: 0x13B9800 VA: 0x1813BA400
	public static string[] get_AvailableCustomDimensions02() { }

	// RVA: 0x13BA4B0 Offset: 0x13B98B0 VA: 0x1813BA4B0
	public static string[] get_AvailableCustomDimensions03() { }

	// RVA: 0x13BA560 Offset: 0x13B9960 VA: 0x1813BA560
	public static string get_Build() { }

	// RVA: 0x13BB450 Offset: 0x13BA850 VA: 0x1813BB450
	public static void set_Build(string value) { }

	// RVA: 0x13BAC60 Offset: 0x13BA060 VA: 0x1813BAC60
	public static bool get_IsEventSubmissionEnabled() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x13BA8D0 Offset: 0x13B9CD0 VA: 0x1813BA8D0
	private bool get_Enabled() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x13BB850 Offset: 0x13BAC50 VA: 0x1813BB850
	private void set_Enabled(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x58DBC0 Offset: 0x58CFC0 VA: 0x18058DBC0
	private string get_FacebookId() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x58DC50 Offset: 0x58D050 VA: 0x18058DC50
	private void set_FacebookId(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x9321E0 Offset: 0x9315E0 VA: 0x1809321E0
	private string get_Gender() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xC53340 Offset: 0xC52740 VA: 0x180C53340
	private void set_Gender(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x2F95B0 Offset: 0x2F89B0 VA: 0x1802F95B0
	private int get_BirthYear() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x2F95C0 Offset: 0x2F89C0 VA: 0x1802F95C0
	private void set_BirthYear(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xA2BE10 Offset: 0xA2B210 VA: 0x180A2BE10
	private void set_SdkConfigCached(JSONNode value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x588350 Offset: 0x587750 VA: 0x180588350
	private bool get_InitAuthorized() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x588360 Offset: 0x587760 VA: 0x180588360
	private void set_InitAuthorized(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xD9B0A0 Offset: 0xD9A4A0 VA: 0x180D9B0A0
	private long get_ClientServerTimeOffset() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x13BB510 Offset: 0x13BA910 VA: 0x1813BB510
	private void set_ClientServerTimeOffset(long value) { }

	// RVA: 0x13BA820 Offset: 0x13B9C20 VA: 0x1813BA820
	private string get_DefaultUserId() { }

	// RVA: 0x13BB760 Offset: 0x13BAB60 VA: 0x1813BB760
	private void set_DefaultUserId(string value) { }

	// RVA: 0x13BAD10 Offset: 0x13BA110 VA: 0x1813BAD10
	private static JSONNode get_SdkConfig() { }

	// RVA: 0x13BA000 Offset: 0x13B9400 VA: 0x1813BA000
	private void .ctor() { }

	// RVA: 0x13B51E0 Offset: 0x13B45E0 VA: 0x1813B51E0 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x13B6C20 Offset: 0x13B6020 VA: 0x1813B6C20
	public static bool IsEnabled() { }

	// RVA: 0x13B79B0 Offset: 0x13B6DB0 VA: 0x1813B79B0
	public static void SetCustomDimension01(string dimension) { }

	// RVA: 0x13B7AA0 Offset: 0x13B6EA0 VA: 0x1813B7AA0
	public static void SetCustomDimension02(string dimension) { }

	// RVA: 0x13B7B90 Offset: 0x13B6F90 VA: 0x1813B7B90
	public static void SetCustomDimension03(string dimension) { }

	// RVA: 0x13B6860 Offset: 0x13B5C60 VA: 0x1813B6860
	public static void IncrementSessionNum() { }

	// RVA: 0x13B68C0 Offset: 0x13B5CC0 VA: 0x1813B68C0
	public static void IncrementTransactionNum() { }

	// RVA: 0x13B63B0 Offset: 0x13B57B0 VA: 0x1813B63B0
	public static bool HasAvailableCustomDimensions01(string dimension1) { }

	// RVA: 0x13B6540 Offset: 0x13B5940 VA: 0x1813B6540
	public static bool HasAvailableCustomDimensions02(string dimension2) { }

	// RVA: 0x13B66D0 Offset: 0x13B5AD0 VA: 0x1813B66D0
	public static bool HasAvailableCustomDimensions03(string dimension3) { }

	// RVA: 0x13B7C80 Offset: 0x13B7080 VA: 0x1813B7C80
	public static void SetKeys(string gameKey, string gameSecret) { }

	// RVA: 0x13B6920 Offset: 0x13B5D20 VA: 0x1813B6920
	public static void InternalInitialize() { }

	// RVA: 0x13B3B70 Offset: 0x13B2F70 VA: 0x1813B3B70
	public static void EndSessionAndStopQueue(bool endThread) { }

	// RVA: 0x13B53B0 Offset: 0x13B47B0 VA: 0x1813B53B0
	public static JSONObject GetEventAnnotations() { }

	// RVA: 0x13B60A0 Offset: 0x13B54A0 VA: 0x1813B60A0
	public static JSONObject GetInitAnnotations() { }

	// RVA: 0x13B52B0 Offset: 0x13B46B0 VA: 0x1813B52B0
	public static long GetClientTsAdjusted() { }

	// RVA: 0x13B7960 Offset: 0x13B6D60 VA: 0x1813B7960
	public static bool SessionIsStarted() { }

	// RVA: 0x13B8AC0 Offset: 0x13B7EC0 VA: 0x1813B8AC0
	public static JSONObject ValidateAndCleanCustomFields(IDictionary<string, object> fields) { }

	// RVA: 0x13B3940 Offset: 0x13B2D40 VA: 0x1813B3940
	private static void CacheIdentifier() { }

	// RVA: 0x13B3D60 Offset: 0x13B3160 VA: 0x1813B3D60
	private static void EnsurePersistedStates() { }

	// RVA: 0x13B7E30 Offset: 0x13B7230 VA: 0x1813B7E30
	private static void StartNewSession() { }

	// RVA: 0x13B7F50 Offset: 0x13B7350 VA: 0x1813B7F50
	public static void StartNewSession(EGAHTTPApiResponse initResponse, JSONObject initResponseDict) { }

	// RVA: 0x13B9D80 Offset: 0x13B9180 VA: 0x1813B9D80
	private static void ValidateAndFixCurrentDimensions() { }

	// RVA: 0x13B3B10 Offset: 0x13B2F10 VA: 0x1813B3B10
	private static long CalculateServerTimeOffset(long serverTs) { }

	// RVA: 0x13B6CD0 Offset: 0x13B60D0 VA: 0x1813B6CD0
	private static void PopulateConfigurations(JSONNode sdkConfig) { }

	// RVA: 0x13B9FA0 Offset: 0x13B93A0 VA: 0x1813B9FA0
	private static void .cctor() { }

}

