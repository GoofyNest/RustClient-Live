internal static class SteamAPI // TypeDefIndex: 5111
{	// Methods

	// RVA: 0xDDD6B0 Offset: 0xDDCAB0 VA: 0x180DDD6B0
	internal static bool Init() { }

	// RVA: 0xDDD720 Offset: 0xDDCB20 VA: 0x180DDD720
	internal static void Shutdown() { }

	// RVA: 0xDDD640 Offset: 0xDDCA40 VA: 0x180DDD640
	internal static HSteamPipe GetHSteamPipe() { }

}

internal static class SteamAPI.Native // TypeDefIndex: 5112
{	// Methods

	// RVA: 0xDDD6B0 Offset: 0xDDCAB0 VA: 0x180DDD6B0
	public static extern bool SteamAPI_Init() { }

	// RVA: 0xDDD720 Offset: 0xDDCB20 VA: 0x180DDD720
	public static extern void SteamAPI_Shutdown() { }

	// RVA: 0xDDD640 Offset: 0xDDCA40 VA: 0x180DDD640
	public static extern HSteamPipe SteamAPI_GetHSteamPipe() { }

}

internal enum SteamItemFlags // TypeDefIndex: 5167
{	// Fields
	public int value__; // 0x0
	public const SteamItemFlags NoTrade = 1;
	public const SteamItemFlags Removed = 256;
	public const SteamItemFlags Consumed = 512;

}

public enum SteamNetworkingAvailability // TypeDefIndex: 5168
{	// Fields
	public int value__; // 0x0
	public const SteamNetworkingAvailability CannotTry = -102;
	public const SteamNetworkingAvailability Failed = -101;
	public const SteamNetworkingAvailability Previously = -100;
	public const SteamNetworkingAvailability Retrying = -10;
	public const SteamNetworkingAvailability NeverTried = 1;
	public const SteamNetworkingAvailability Waiting = 2;
	public const SteamNetworkingAvailability Attempting = 3;
	public const SteamNetworkingAvailability Current = 100;
	public const SteamNetworkingAvailability Unknown = 0;
	public const SteamNetworkingAvailability Force32bit = 2147483647;

}

public class SteamApps : SteamSharedClass<SteamApps> // TypeDefIndex: 5183
{	// Properties
	internal static ISteamApps Internal { get; }
	public static string GameLanguage { get; }
	public static string CurrentBetaName { get; }
	public static int BuildId { get; }

	// Methods

	// RVA: 0xDDF5C0 Offset: 0xDDE9C0 VA: 0x180DDF5C0
	internal static ISteamApps get_Internal() { }

	// RVA: 0xDDF3C0 Offset: 0xDDE7C0 VA: 0x180DDF3C0 Slot: 4
	internal override void InitializeInterface(bool server) { }

	// RVA: 0xDDF590 Offset: 0xDDE990 VA: 0x180DDF590
	public static string get_GameLanguage() { }

	// RVA: 0xDDF490 Offset: 0xDDE890 VA: 0x180DDF490
	public static bool IsSubscribedToApp(AppId appid) { }

	// RVA: 0xDDF440 Offset: 0xDDE840 VA: 0x180DDF440
	public static bool IsDlcInstalled(AppId appid) { }

	// RVA: 0xDDF550 Offset: 0xDDE950 VA: 0x180DDF550
	public static string get_CurrentBetaName() { }

	// RVA: 0xDDF520 Offset: 0xDDE920 VA: 0x180DDF520
	public static int get_BuildId() { }

	// RVA: 0xDDF4E0 Offset: 0xDDE8E0 VA: 0x180DDF4E0
	public void .ctor() { }

}

public static class SteamClient // TypeDefIndex: 5184
{	// Fields
	private static bool initialized; // 0x0
	private static readonly List<SteamClass> openInterfaces; // 0x8
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private static AppId <AppId>k__BackingField; // 0x10

	// Properties
	public static bool IsValid { get; }
	public static bool IsLoggedOn { get; }
	public static SteamId SteamId { get; }
	public static string Name { get; }
	public static AppId AppId { get; set; }

	// Methods

	// RVA: 0xDDF6D0 Offset: 0xDDEAD0 VA: 0x180DDF6D0
	public static void Init(uint appid, bool asyncCallbacks = True) { }

	// RVA: -1 Offset: -1
	internal static void AddInterface<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCFA620 Offset: 0xCF9A20 VA: 0x180CFA620
	|-SteamClient.AddInterface<SteamApps>
	|-SteamClient.AddInterface<SteamFriends>
	|-SteamClient.AddInterface<SteamInput>
	|-SteamClient.AddInterface<SteamInventory>
	|-SteamClient.AddInterface<SteamMatchmaking>
	|-SteamClient.AddInterface<SteamMatchmakingServers>
	|-SteamClient.AddInterface<SteamMusic>
	|-SteamClient.AddInterface<SteamNetworking>
	|-SteamClient.AddInterface<SteamNetworkingSockets>
	|-SteamClient.AddInterface<SteamNetworkingUtils>
	|-SteamClient.AddInterface<SteamParental>
	|-SteamClient.AddInterface<SteamParties>
	|-SteamClient.AddInterface<SteamRemotePlay>
	|-SteamClient.AddInterface<SteamRemoteStorage>
	|-SteamClient.AddInterface<SteamScreenshots>
	|-SteamClient.AddInterface<SteamUGC>
	|-SteamClient.AddInterface<SteamUser>
	|-SteamClient.AddInterface<SteamUserStats>
	|-SteamClient.AddInterface<SteamUtils>
	|-SteamClient.AddInterface<SteamVideo>
	|-SteamClient.AddInterface<object>
	*/

	// RVA: 0xDDFC10 Offset: 0xDDF010 VA: 0x180DDFC10
	internal static void ShutdownInterfaces() { }

	// RVA: 0xDE0140 Offset: 0xDDF540 VA: 0x180DE0140
	public static bool get_IsValid() { }

	// RVA: 0xDDFDA0 Offset: 0xDDF1A0 VA: 0x180DDFDA0
	public static void Shutdown() { }

	// RVA: 0xDDF640 Offset: 0xDDEA40 VA: 0x180DDF640
	internal static void Cleanup() { }

	// RVA: 0xDDFAD0 Offset: 0xDDEED0 VA: 0x180DDFAD0
	public static void RunCallbacks() { }

	// RVA: 0xDE0060 Offset: 0xDDF460 VA: 0x180DE0060
	public static bool get_IsLoggedOn() { }

	// RVA: 0xDE01D0 Offset: 0xDDF5D0 VA: 0x180DE01D0
	public static SteamId get_SteamId() { }

	// RVA: 0xDE01A0 Offset: 0xDDF5A0 VA: 0x180DE01A0
	public static string get_Name() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xDDFFA0 Offset: 0xDDF3A0 VA: 0x180DDFFA0
	public static AppId get_AppId() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xDE02A0 Offset: 0xDDF6A0 VA: 0x180DE02A0
	internal static void set_AppId(AppId value) { }

	// RVA: 0xDDFF30 Offset: 0xDDF330 VA: 0x180DDFF30
	private static void .cctor() { }

}

public class SteamFriends : SteamClientClass<SteamFriends> // TypeDefIndex: 5185
{	// Fields
	private static Dictionary<string, string> richPresence; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private static Action<Friend, string, string> OnChatMessage; // 0x8
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private static Action<Friend, string, string> OnClanChatMessage; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private static Action<Friend> OnPersonaStateChange; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private static Action<Friend, string> OnGameRichPresenceJoinRequested; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private static Action<bool> OnGameOverlayActivated; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private static Action<string, string> OnGameServerChangeRequested; // 0x30
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private static Action<Lobby, SteamId> OnGameLobbyJoinRequested; // 0x38
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private static Action<Friend> OnFriendRichPresenceUpdate; // 0x40
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private static Action<string> OnOverlayBrowserProtocol; // 0x48

	// Properties
	internal static ISteamFriends Internal { get; }

	// Methods

	// RVA: 0xDE1540 Offset: 0xDE0940 VA: 0x180DE1540
	internal static ISteamFriends get_Internal() { }

	// RVA: 0xDE0650 Offset: 0xDDFA50 VA: 0x180DE0650 Slot: 4
	internal override void InitializeInterface(bool server) { }

	// RVA: 0xDE0710 Offset: 0xDDFB10 VA: 0x180DE0710
	internal void InstallEvents() { }

	// RVA: 0xDE0D60 Offset: 0xDE0160 VA: 0x180DE0D60
	private static void OnFriendChatMessage(GameConnectedFriendChatMsg_t data) { }

	// RVA: 0xDE1010 Offset: 0xDE0410 VA: 0x180DE1010
	private static void OnGameConnectedClanChatMessage(GameConnectedClanChatMsg_t data) { }

	[IteratorStateMachineAttribute] // RVA: 0x8DFF0 Offset: 0x8D3F0 VA: 0x18008DFF0
	// RVA: 0xDE0440 Offset: 0xDDF840 VA: 0x180DE0440
	private static IEnumerable<Friend> GetFriendsWithFlag(FriendFlags flag) { }

	// RVA: 0xDE04B0 Offset: 0xDDF8B0 VA: 0x180DE04B0
	public static IEnumerable<Friend> GetFriends() { }

	// RVA: 0xDE1360 Offset: 0xDE0760 VA: 0x180DE1360
	public static void OpenUserOverlay(SteamId id, string type) { }

	// RVA: 0xDE1310 Offset: 0xDE0710 VA: 0x180DE1310
	public static void OpenStoreOverlay(AppId id, OverlayToStoreFlag overlayToStoreFlag = 0) { }

	// RVA: 0xDE13A0 Offset: 0xDE07A0 VA: 0x180DE13A0
	public static void OpenWebOverlay(string url, bool modal = False) { }

	// RVA: 0xDE1420 Offset: 0xDE0820 VA: 0x180DE1420
	public static void SetPlayedWith(SteamId steamid) { }

	// RVA: 0xDE13E0 Offset: 0xDE07E0 VA: 0x180DE13E0
	public static bool RequestUserInformation(SteamId steamid, bool nameonly = True) { }

	[AsyncStateMachineAttribute] // RVA: 0x8E070 Offset: 0x8D470 VA: 0x18008E070
	// RVA: 0xDE0300 Offset: 0xDDF700 VA: 0x180DE0300
	internal static Task CacheUserInformationAsync(SteamId steamid, bool nameonly) { }

	[AsyncStateMachineAttribute] // RVA: 0x8E360 Offset: 0x8D760 VA: 0x18008E360
	// RVA: 0xDE0510 Offset: 0xDDF910 VA: 0x180DE0510
	public static Task<Nullable<Image>> GetMediumAvatarAsync(SteamId steamid) { }

	// RVA: 0xDE05D0 Offset: 0xDDF9D0 VA: 0x180DE05D0
	public static string GetRichPresence(string key) { }

	// RVA: 0xDE1450 Offset: 0xDE0850 VA: 0x180DE1450
	public static bool SetRichPresence(string key, string value) { }

	// RVA: 0xDE03D0 Offset: 0xDDF7D0 VA: 0x180DE03D0
	public static void ClearRichPresence() { }

	// RVA: 0xDE1500 Offset: 0xDE0900 VA: 0x180DE1500
	public void .ctor() { }

}

private sealed class SteamFriends.<>c // TypeDefIndex: 5186
{	// Fields
	public static readonly SteamFriends.<>c <>9; // 0x0
	public static Action<PersonaStateChange_t> <>9__4_0; // 0x8
	public static Action<GameRichPresenceJoinRequested_t> <>9__4_1; // 0x10
	public static Action<GameOverlayActivated_t> <>9__4_2; // 0x18
	public static Action<GameServerChangeRequested_t> <>9__4_3; // 0x20
	public static Action<GameLobbyJoinRequested_t> <>9__4_4; // 0x28
	public static Action<FriendRichPresenceUpdate_t> <>9__4_5; // 0x30
	public static Action<OverlayBrowserProtocolNavigation_t> <>9__4_6; // 0x38

	// Methods

	// RVA: 0xDEB2A0 Offset: 0xDEA6A0 VA: 0x180DEB2A0
	private static void .cctor() { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0xDEA730 Offset: 0xDE9B30 VA: 0x180DEA730
	internal void <InstallEvents>b__4_0(PersonaStateChange_t x) { }

	// RVA: 0xDEA790 Offset: 0xDE9B90 VA: 0x180DEA790
	internal void <InstallEvents>b__4_1(GameRichPresenceJoinRequested_t x) { }

	// RVA: 0xDEA810 Offset: 0xDE9C10 VA: 0x180DEA810
	internal void <InstallEvents>b__4_2(GameOverlayActivated_t x) { }

	// RVA: 0xDEA870 Offset: 0xDE9C70 VA: 0x180DEA870
	internal void <InstallEvents>b__4_3(GameServerChangeRequested_t x) { }

	// RVA: 0xDEA8F0 Offset: 0xDE9CF0 VA: 0x180DEA8F0
	internal void <InstallEvents>b__4_4(GameLobbyJoinRequested_t x) { }

	// RVA: 0xDEA980 Offset: 0xDE9D80 VA: 0x180DEA980
	internal void <InstallEvents>b__4_5(FriendRichPresenceUpdate_t x) { }

	// RVA: 0xDEA9E0 Offset: 0xDE9DE0 VA: 0x180DEA9E0
	internal void <InstallEvents>b__4_6(OverlayBrowserProtocolNavigation_t x) { }

}

private sealed class SteamFriends.<GetFriendsWithFlag>d__34 : IEnumerable<Friend>, IEnumerable, IEnumerator<Friend>, IEnumerator, IDisposable // TypeDefIndex: 5187
{	// Fields
	private int <>1__state; // 0x10
	private Friend <>2__current; // 0x18
	private int <>l__initialThreadId; // 0x20
	private FriendFlags flag; // 0x24
	public FriendFlags <>3__flag; // 0x28
	private int <i>5__2; // 0x2C

	// Properties
	private Friend System.Collections.Generic.IEnumerator<Steamworks.Friend>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xD824F0 Offset: 0xD818F0 VA: 0x180D824F0
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 7
	private void System.IDisposable.Dispose() { }

	// RVA: 0xDE71F0 Offset: 0xDE65F0 VA: 0x180DE71F0 Slot: 8
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710 Slot: 6
	private Friend System.Collections.Generic.IEnumerator<Steamworks.Friend>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xDE7330 Offset: 0xDE6730 VA: 0x180DE7330 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xDE7380 Offset: 0xDE6780 VA: 0x180DE7380 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xDE7290 Offset: 0xDE6690 VA: 0x180DE7290 Slot: 4
	private IEnumerator<Friend> System.Collections.Generic.IEnumerable<Steamworks.Friend>.GetEnumerator() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xDE7290 Offset: 0xDE6690 VA: 0x180DE7290 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

private struct SteamFriends.<CacheUserInformationAsync>d__51 : IAsyncStateMachine // TypeDefIndex: 5188
{	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder <>t__builder; // 0x8
	public SteamId steamid; // 0x20
	public bool nameonly; // 0x28
	private TaskAwaiter <>u__1; // 0x30

	// Methods

	// RVA: 0x1230C0 Offset: 0x1224C0 VA: 0x1801230C0 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xF2060 Offset: 0xF1460 VA: 0x1800F2060 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

private struct SteamFriends.<GetMediumAvatarAsync>d__53 : IAsyncStateMachine // TypeDefIndex: 5189
{	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder<Nullable<Image>> <>t__builder; // 0x8
	public SteamId steamid; // 0x20
	private TaskAwaiter <>u__1; // 0x28

	// Methods

	// RVA: 0x123370 Offset: 0x122770 VA: 0x180123370 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x123380 Offset: 0x122780 VA: 0x180123380 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

public class SteamInput : SteamClientClass<SteamInput> // TypeDefIndex: 5190
{	// Fields
	private static readonly InputHandle_t[] queryArray; // 0x0
	internal static Dictionary<string, InputDigitalActionHandle_t> DigitalHandles; // 0x8
	internal static Dictionary<string, InputAnalogActionHandle_t> AnalogHandles; // 0x10
	internal static Dictionary<string, InputActionSetHandle_t> ActionSets; // 0x18

	// Methods

	// RVA: 0xDE15F0 Offset: 0xDE09F0 VA: 0x180DE15F0 Slot: 4
	internal override void InitializeInterface(bool server) { }

	// RVA: 0xDE1780 Offset: 0xDE0B80 VA: 0x180DE1780
	public void .ctor() { }

	// RVA: 0xDE1670 Offset: 0xDE0A70 VA: 0x180DE1670
	private static void .cctor() { }

}

public class SteamInventory : SteamSharedClass<SteamInventory> // TypeDefIndex: 5191
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private static Action<InventoryResult> OnInventoryUpdated; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private static Action OnDefinitionsUpdated; // 0x8
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private static string <Currency>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private static InventoryItem[] <Items>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private static InventoryDef[] <Definitions>k__BackingField; // 0x20
	private static Dictionary<int, InventoryDef> _defMap; // 0x28

	// Properties
	internal static ISteamInventory Internal { get; }
	public static string Currency { get; set; }
	public static InventoryItem[] Items { get; set; }
	public static InventoryDef[] Definitions { get; set; }

	// Methods

	// RVA: 0xDE2A50 Offset: 0xDE1E50 VA: 0x180DE2A50
	internal static ISteamInventory get_Internal() { }

	// RVA: 0xDE2000 Offset: 0xDE1400 VA: 0x180DE2000 Slot: 4
	internal override void InitializeInterface(bool server) { }

	// RVA: 0xDE2090 Offset: 0xDE1490 VA: 0x180DE2090
	internal static void InstallEvents(bool server) { }

	// RVA: 0xDE2280 Offset: 0xDE1680 VA: 0x180DE2280
	private static void InventoryUpdated(SteamInventoryFullUpdate_t x) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xDE2920 Offset: 0xDE1D20 VA: 0x180DE2920
	public static void add_OnInventoryUpdated(Action<InventoryResult> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xDE2BC0 Offset: 0xDE1FC0 VA: 0x180DE2BC0
	public static void remove_OnInventoryUpdated(Action<InventoryResult> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xDE2870 Offset: 0xDE1C70 VA: 0x180DE2870
	public static void add_OnDefinitionsUpdated(Action value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xDE2B10 Offset: 0xDE1F10 VA: 0x180DE2B10
	public static void remove_OnDefinitionsUpdated(Action value) { }

	// RVA: 0xDE2340 Offset: 0xDE1740 VA: 0x180DE2340
	private static void LoadDefinitions() { }

	// RVA: 0xDE2630 Offset: 0xDE1A30 VA: 0x180DE2630
	public static void LoadItemDefinitions() { }

	// RVA: 0xDE1B50 Offset: 0xDE0F50 VA: 0x180DE1B50
	public static InventoryDef FindDefinition(InventoryDefId defId) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xDE29D0 Offset: 0xDE1DD0 VA: 0x180DE29D0
	public static string get_Currency() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xDE2C70 Offset: 0xDE2070 VA: 0x180DE2C70
	internal static void set_Currency(string value) { }

	[AsyncStateMachineAttribute] // RVA: 0x8F8D0 Offset: 0x8ECD0 VA: 0x18008F8D0
	// RVA: 0xDE1D00 Offset: 0xDE1100 VA: 0x180DE1D00
	public static Task<InventoryDef[]> GetDefinitionsWithPricesAsync() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xDE2AD0 Offset: 0xDE1ED0 VA: 0x180DE2AD0
	public static InventoryItem[] get_Items() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xDE2D10 Offset: 0xDE2110 VA: 0x180DE2D10
	internal static void set_Items(InventoryItem[] value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xDE2A10 Offset: 0xDE1E10 VA: 0x180DE2A10
	public static InventoryDef[] get_Definitions() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xDE2CC0 Offset: 0xDE20C0 VA: 0x180DE2CC0
	internal static void set_Definitions(InventoryDef[] value) { }

	// RVA: 0xDE1DC0 Offset: 0xDE11C0 VA: 0x180DE1DC0
	internal static InventoryDef[] GetDefinitions() { }

	// RVA: 0xDE1C80 Offset: 0xDE1080 VA: 0x180DE1C80
	public static bool GetAllItems() { }

	[AsyncStateMachineAttribute] // RVA: 0x8FEC0 Offset: 0x8F2C0 VA: 0x18008FEC0
	// RVA: 0xDE1BD0 Offset: 0xDE0FD0 VA: 0x180DE1BD0
	public static Task<Nullable<InventoryResult>> GetAllItemsAsync() { }

	[AsyncStateMachineAttribute] // RVA: 0x8FFC0 Offset: 0x8F3C0 VA: 0x18008FFC0
	// RVA: 0xDE1950 Offset: 0xDE0D50 VA: 0x180DE1950
	public static Task<Nullable<InventoryResult>> CraftItemAsync(InventoryItem[] list, InventoryDef target) { }

	[AsyncStateMachineAttribute] // RVA: 0x900F0 Offset: 0x8F4F0 VA: 0x1800900F0
	// RVA: 0xDE1A50 Offset: 0xDE0E50 VA: 0x180DE1A50
	public static Task<Nullable<InventoryResult>> CraftItemAsync(InventoryItem.Amount[] list, InventoryDef target) { }

	[AsyncStateMachineAttribute] // RVA: 0x90210 Offset: 0x8F610 VA: 0x180090210
	// RVA: 0xDE1F50 Offset: 0xDE1350 VA: 0x180DE1F50
	public static Task<Nullable<InventoryResult>> GrantPromoItemsAsync() { }

	[AsyncStateMachineAttribute] // RVA: 0x90380 Offset: 0x8F780 VA: 0x180090380
	// RVA: 0xDE2770 Offset: 0xDE1B70 VA: 0x180DE2770
	public static Task<Nullable<InventoryResult>> TriggerItemDropAsync(InventoryDefId id) { }

	[AsyncStateMachineAttribute] // RVA: 0x905A0 Offset: 0x8F9A0 VA: 0x1800905A0
	// RVA: 0xDE2690 Offset: 0xDE1A90 VA: 0x180DE2690
	public static Task<Nullable<InventoryPurchaseResult>> StartPurchaseAsync(InventoryDef[] items) { }

	// RVA: 0xDE2830 Offset: 0xDE1C30 VA: 0x180DE2830
	public void .ctor() { }

}

private sealed class SteamInventory.<>c // TypeDefIndex: 5192
{	// Fields
	public static readonly SteamInventory.<>c <>9; // 0x0
	public static Action<SteamInventoryFullUpdate_t> <>9__3_0; // 0x8
	public static Action<SteamInventoryDefinitionUpdate_t> <>9__3_1; // 0x10
	public static Func<InventoryDefId, InventoryDef> <>9__19_0; // 0x18
	public static Func<InventoryDefId, InventoryDef> <>9__29_0; // 0x20
	public static Func<InventoryItem, InventoryItemId> <>9__33_0; // 0x28
	public static Func<InventoryItem, uint> <>9__33_1; // 0x30
	public static Func<InventoryItem.Amount, InventoryItemId> <>9__34_0; // 0x38
	public static Func<InventoryItem.Amount, uint> <>9__34_1; // 0x40
	public static Func<InventoryDef, InventoryDefId> <>9__39_0; // 0x48
	public static Func<IGrouping<InventoryDefId, InventoryDef>, InventoryDefId> <>9__39_1; // 0x50
	public static Func<IGrouping<InventoryDefId, InventoryDef>, uint> <>9__39_2; // 0x58

	// Methods

	// RVA: 0xDEB420 Offset: 0xDEA820 VA: 0x180DEB420
	private static void .cctor() { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0xDEA4E0 Offset: 0xDE98E0 VA: 0x180DEA4E0
	internal void <InstallEvents>b__3_0(SteamInventoryFullUpdate_t x) { }

	// RVA: 0xDEA650 Offset: 0xDE9A50 VA: 0x180DEA650
	internal void <InstallEvents>b__3_1(SteamInventoryDefinitionUpdate_t x) { }

	// RVA: 0xDEA300 Offset: 0xDE9700 VA: 0x180DEA300
	internal InventoryDef <GetDefinitionsWithPricesAsync>b__19_0(InventoryDefId x) { }

	// RVA: 0xDEA2A0 Offset: 0xDE96A0 VA: 0x180DEA2A0
	internal InventoryDef <GetDefinitions>b__29_0(InventoryDefId x) { }

	// RVA: 0x81E4B0 Offset: 0x81D8B0 VA: 0x18081E4B0
	internal InventoryItemId <CraftItemAsync>b__33_0(InventoryItem x) { }

	// RVA: 0x5CB140 Offset: 0x5CA540 VA: 0x1805CB140
	internal uint <CraftItemAsync>b__33_1(InventoryItem x) { }

	// RVA: 0x81E4B0 Offset: 0x81D8B0 VA: 0x18081E4B0
	internal InventoryItemId <CraftItemAsync>b__34_0(InventoryItem.Amount x) { }

	// RVA: 0xDEA230 Offset: 0xDE9630 VA: 0x180DEA230
	internal uint <CraftItemAsync>b__34_1(InventoryItem.Amount x) { }

	// RVA: 0x7B2BC0 Offset: 0x7B1FC0 VA: 0x1807B2BC0
	internal InventoryDefId <StartPurchaseAsync>b__39_0(InventoryDef x) { }

	// RVA: 0xDEAFE0 Offset: 0xDEA3E0 VA: 0x180DEAFE0
	internal InventoryDefId <StartPurchaseAsync>b__39_1(IGrouping<InventoryDefId, InventoryDef> x) { }

	// RVA: 0xDEB090 Offset: 0xDEA490 VA: 0x180DEB090
	internal uint <StartPurchaseAsync>b__39_2(IGrouping<InventoryDefId, InventoryDef> x) { }

}

private struct SteamInventory.<GetDefinitionsWithPricesAsync>d__19 : IAsyncStateMachine // TypeDefIndex: 5193
{	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder<InventoryDef[]> <>t__builder; // 0x8
	private CallResult<SteamInventoryRequestPricesResult_t> <>u__1; // 0x20

	// Methods

	// RVA: 0x123310 Offset: 0x122710 VA: 0x180123310 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x123320 Offset: 0x122720 VA: 0x180123320 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

private struct SteamInventory.<GetAllItemsAsync>d__31 : IAsyncStateMachine // TypeDefIndex: 5194
{	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder<Nullable<InventoryResult>> <>t__builder; // 0x8
	private TaskAwaiter<Nullable<InventoryResult>> <>u__1; // 0x20

	// Methods

	// RVA: 0x1231F0 Offset: 0x1225F0 VA: 0x1801231F0 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x123200 Offset: 0x122600 VA: 0x180123200 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

private struct SteamInventory.<CraftItemAsync>d__33 : IAsyncStateMachine // TypeDefIndex: 5195
{	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder<Nullable<InventoryResult>> <>t__builder; // 0x8
	public InventoryDef target; // 0x20
	public InventoryItem[] list; // 0x28
	private TaskAwaiter<Nullable<InventoryResult>> <>u__1; // 0x30

	// Methods

	// RVA: 0x123130 Offset: 0x122530 VA: 0x180123130 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x123140 Offset: 0x122540 VA: 0x180123140 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

private struct SteamInventory.<CraftItemAsync>d__34 : IAsyncStateMachine // TypeDefIndex: 5196
{	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder<Nullable<InventoryResult>> <>t__builder; // 0x8
	public InventoryDef target; // 0x20
	public InventoryItem.Amount[] list; // 0x28
	private TaskAwaiter<Nullable<InventoryResult>> <>u__1; // 0x30

	// Methods

	// RVA: 0x123190 Offset: 0x122590 VA: 0x180123190 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1231A0 Offset: 0x1225A0 VA: 0x1801231A0 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

private struct SteamInventory.<GrantPromoItemsAsync>d__36 : IAsyncStateMachine // TypeDefIndex: 5197
{	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder<Nullable<InventoryResult>> <>t__builder; // 0x8
	private TaskAwaiter<Nullable<InventoryResult>> <>u__1; // 0x20

	// Methods

	// RVA: 0x123490 Offset: 0x122890 VA: 0x180123490 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1234A0 Offset: 0x1228A0 VA: 0x1801234A0 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

private struct SteamInventory.<TriggerItemDropAsync>d__37 : IAsyncStateMachine // TypeDefIndex: 5198
{	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder<Nullable<InventoryResult>> <>t__builder; // 0x8
	public InventoryDefId id; // 0x20
	private TaskAwaiter<Nullable<InventoryResult>> <>u__1; // 0x28

	// Methods

	// RVA: 0x1236E0 Offset: 0x122AE0 VA: 0x1801236E0 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1236F0 Offset: 0x122AF0 VA: 0x1801236F0 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

private struct SteamInventory.<StartPurchaseAsync>d__39 : IAsyncStateMachine // TypeDefIndex: 5199
{	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder<Nullable<InventoryPurchaseResult>> <>t__builder; // 0x8
	public InventoryDef[] items; // 0x20
	private CallResult<SteamInventoryStartPurchaseResult_t> <>u__1; // 0x28

	// Methods

	// RVA: 0x123680 Offset: 0x122A80 VA: 0x180123680 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x123690 Offset: 0x122A90 VA: 0x180123690 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

public class SteamMatchmaking : SteamClientClass<SteamMatchmaking> // TypeDefIndex: 5200
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private static Action<Friend, Lobby> OnLobbyInvite; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private static Action<Lobby> OnLobbyEntered; // 0x8
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private static Action<Result, Lobby> OnLobbyCreated; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private static Action<Lobby, uint, ushort, SteamId> OnLobbyGameCreated; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private static Action<Lobby> OnLobbyDataChanged; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private static Action<Lobby, Friend> OnLobbyMemberDataChanged; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private static Action<Lobby, Friend> OnLobbyMemberJoined; // 0x30
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private static Action<Lobby, Friend> OnLobbyMemberLeave; // 0x38
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private static Action<Lobby, Friend> OnLobbyMemberDisconnected; // 0x40
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private static Action<Lobby, Friend, Friend> OnLobbyMemberKicked; // 0x48
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private static Action<Lobby, Friend, Friend> OnLobbyMemberBanned; // 0x50
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private static Action<Lobby, Friend, string> OnChatMessage; // 0x58

	// Properties
	internal static ISteamMatchmaking Internal { get; }

	// Methods

	// RVA: 0xDE36C0 Offset: 0xDE2AC0 VA: 0x180DE36C0
	internal static ISteamMatchmaking get_Internal() { }

	// RVA: 0xDE2E80 Offset: 0xDE2280 VA: 0x180DE2E80 Slot: 4
	internal override void InitializeInterface(bool server) { }

	// RVA: 0xDE2F00 Offset: 0xDE2300 VA: 0x180DE2F00
	internal static void InstallEvents() { }

	// RVA: 0xDE3450 Offset: 0xDE2850 VA: 0x180DE3450
	private static void OnLobbyChatMessageRecievedAPI(LobbyChatMsg_t callback) { }

	[IteratorStateMachineAttribute] // RVA: 0x93030 Offset: 0x92430 VA: 0x180093030
	// RVA: 0xDE2E20 Offset: 0xDE2220 VA: 0x180DE2E20
	public static IEnumerable<ServerInfo> GetFavoriteServers() { }

	// RVA: 0xDE3680 Offset: 0xDE2A80 VA: 0x180DE3680
	public void .ctor() { }

}

private sealed class SteamMatchmaking.<>c // TypeDefIndex: 5201
{	// Fields
	public static readonly SteamMatchmaking.<>c <>9; // 0x0
	public static Action<LobbyInvite_t> <>9__5_0; // 0x8
	public static Action<LobbyEnter_t> <>9__5_1; // 0x10
	public static Action<LobbyCreated_t> <>9__5_2; // 0x18
	public static Action<LobbyGameCreated_t> <>9__5_3; // 0x20
	public static Action<LobbyDataUpdate_t> <>9__5_4; // 0x28
	public static Action<LobbyChatUpdate_t> <>9__5_5; // 0x30

	// Methods

	// RVA: 0xDEB480 Offset: 0xDEA880 VA: 0x180DEB480
	private static void .cctor() { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0xDEAA40 Offset: 0xDE9E40 VA: 0x180DEAA40
	internal void <InstallEvents>b__5_0(LobbyInvite_t x) { }

	// RVA: 0xDEAAD0 Offset: 0xDE9ED0 VA: 0x180DEAAD0
	internal void <InstallEvents>b__5_1(LobbyEnter_t x) { }

	// RVA: 0xDEAB50 Offset: 0xDE9F50 VA: 0x180DEAB50
	internal void <InstallEvents>b__5_2(LobbyCreated_t x) { }

	// RVA: 0xDEABE0 Offset: 0xDE9FE0 VA: 0x180DEABE0
	internal void <InstallEvents>b__5_3(LobbyGameCreated_t x) { }

	// RVA: 0xDEACB0 Offset: 0xDEA0B0 VA: 0x180DEACB0
	internal void <InstallEvents>b__5_4(LobbyDataUpdate_t x) { }

	// RVA: 0xDEADA0 Offset: 0xDEA1A0 VA: 0x180DEADA0
	internal void <InstallEvents>b__5_5(LobbyChatUpdate_t x) { }

}

private sealed class SteamMatchmaking.<GetFavoriteServers>d__47 : IEnumerable<ServerInfo>, IEnumerable, IEnumerator<ServerInfo>, IEnumerator, IDisposable // TypeDefIndex: 5202
{	// Fields
	private int <>1__state; // 0x10
	private ServerInfo <>2__current; // 0x18
	private int <>l__initialThreadId; // 0x90
	private int <count>5__2; // 0x94
	private int <i>5__3; // 0x98

	// Properties
	private ServerInfo System.Collections.Generic.IEnumerator<Steamworks.Data.ServerInfo>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xDE71B0 Offset: 0xDE65B0 VA: 0x180DE71B0
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 7
	private void System.IDisposable.Dispose() { }

	// RVA: 0xDE6E30 Offset: 0xDE6230 VA: 0x180DE6E30 Slot: 8
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xDE7070 Offset: 0xDE6470 VA: 0x180DE7070 Slot: 6
	private ServerInfo System.Collections.Generic.IEnumerator<Steamworks.Data.ServerInfo>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xDE70C0 Offset: 0xDE64C0 VA: 0x180DE70C0 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xDE7110 Offset: 0xDE6510 VA: 0x180DE7110 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xDE6FE0 Offset: 0xDE63E0 VA: 0x180DE6FE0 Slot: 4
	private IEnumerator<ServerInfo> System.Collections.Generic.IEnumerable<Steamworks.Data.ServerInfo>.GetEnumerator() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xDE6FE0 Offset: 0xDE63E0 VA: 0x180DE6FE0 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

internal class SteamMatchmakingServers : SteamClientClass<SteamMatchmakingServers> // TypeDefIndex: 5203
{	// Properties
	internal static ISteamMatchmakingServers Internal { get; }

	// Methods

	// RVA: 0xDD2680 Offset: 0xDD1A80 VA: 0x180DD2680
	internal static ISteamMatchmakingServers get_Internal() { }

	// RVA: 0xDE2D60 Offset: 0xDE2160 VA: 0x180DE2D60 Slot: 4
	internal override void InitializeInterface(bool server) { }

	// RVA: 0xDE2DE0 Offset: 0xDE21E0 VA: 0x180DE2DE0
	public void .ctor() { }

}

public class SteamMusic : SteamClientClass<SteamMusic> // TypeDefIndex: 5204
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private static Action OnPlaybackChanged; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private static Action<float> OnVolumeChanged; // 0x8

	// Methods

	// RVA: 0xDE3750 Offset: 0xDE2B50 VA: 0x180DE3750 Slot: 4
	internal override void InitializeInterface(bool server) { }

	// RVA: 0xDE37D0 Offset: 0xDE2BD0 VA: 0x180DE37D0
	internal static void InstallEvents() { }

	// RVA: 0xDE39A0 Offset: 0xDE2DA0 VA: 0x180DE39A0
	public void .ctor() { }

}

private sealed class SteamMusic.<>c // TypeDefIndex: 5205
{	// Fields
	public static readonly SteamMusic.<>c <>9; // 0x0
	public static Action<PlaybackStatusHasChanged_t> <>9__3_0; // 0x8
	public static Action<VolumeHasChanged_t> <>9__3_1; // 0x10

	// Methods

	// RVA: 0xDEB240 Offset: 0xDEA640 VA: 0x180DEB240
	private static void .cctor() { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0xDEA5A0 Offset: 0xDE99A0 VA: 0x180DEA5A0
	internal void <InstallEvents>b__3_0(PlaybackStatusHasChanged_t x) { }

	// RVA: 0xDEA6D0 Offset: 0xDE9AD0 VA: 0x180DEA6D0
	internal void <InstallEvents>b__3_1(VolumeHasChanged_t x) { }

}

public class SteamNetworking : SteamSharedClass<SteamNetworking> // TypeDefIndex: 5206
{	// Fields
	public static Action<SteamId> OnP2PSessionRequest; // 0x0
	public static Action<SteamId, P2PSessionError> OnP2PConnectionFailed; // 0x8

	// Methods

	// RVA: 0xDE5280 Offset: 0xDE4680 VA: 0x180DE5280 Slot: 4
	internal override void InitializeInterface(bool server) { }

	// RVA: 0xDE5310 Offset: 0xDE4710 VA: 0x180DE5310
	internal static void InstallEvents(bool server) { }

	// RVA: 0xDE54F0 Offset: 0xDE48F0 VA: 0x180DE54F0
	public void .ctor() { }

}

private sealed class SteamNetworking.<>c // TypeDefIndex: 5207
{	// Fields
	public static readonly SteamNetworking.<>c <>9; // 0x0
	public static Action<P2PSessionRequest_t> <>9__3_0; // 0x8
	public static Action<P2PSessionConnectFail_t> <>9__3_1; // 0x10

	// Methods

	// RVA: 0xDEB4E0 Offset: 0xDEA8E0 VA: 0x180DEB4E0
	private static void .cctor() { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0xDEA5F0 Offset: 0xDE99F0 VA: 0x180DEA5F0
	internal void <InstallEvents>b__3_0(P2PSessionRequest_t x) { }

	// RVA: 0xDEA660 Offset: 0xDE9A60 VA: 0x180DEA660
	internal void <InstallEvents>b__3_1(P2PSessionConnectFail_t x) { }

}

public class SteamNetworkingSockets : SteamSharedClass<SteamNetworkingSockets> // TypeDefIndex: 5208
{	// Fields
	private static readonly Dictionary<uint, SocketManager> SocketInterfaces; // 0x0
	private static readonly Dictionary<uint, ConnectionManager> ConnectionInterfaces; // 0x8
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private static Action<Connection, ConnectionInfo> OnConnectionStatusChanged; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private static Action<NetAddress> OnFakeIPResult; // 0x18

	// Properties
	internal static ISteamNetworkingSockets Internal { get; }
	public static NetIdentity Identity { get; }

	// Methods

	// RVA: 0xDE5100 Offset: 0xDE4500 VA: 0x180DE5100
	internal static ISteamNetworkingSockets get_Internal() { }

	// RVA: 0xDE5060 Offset: 0xDE4460 VA: 0x180DE5060
	public static NetIdentity get_Identity() { }

	// RVA: 0xDE4B00 Offset: 0xDE3F00 VA: 0x180DE4B00 Slot: 4
	internal override void InitializeInterface(bool server) { }

	// RVA: 0xDE4A00 Offset: 0xDE3E00 VA: 0x180DE4A00
	internal static SocketManager GetSocketManager(uint id) { }

	// RVA: 0xDE4DC0 Offset: 0xDE41C0 VA: 0x180DE4DC0
	internal static void SetSocketManager(uint id, SocketManager manager) { }

	// RVA: 0xDE47D0 Offset: 0xDE3BD0 VA: 0x180DE47D0
	internal static ConnectionManager GetConnectionManager(uint id) { }

	// RVA: 0xDE4D00 Offset: 0xDE4100 VA: 0x180DE4D00
	internal static void SetConnectionManager(uint id, ConnectionManager manager) { }

	// RVA: 0xDE4C30 Offset: 0xDE4030 VA: 0x180DE4C30
	internal void InstallEvents(bool server) { }

	// RVA: 0xDE3B60 Offset: 0xDE2F60 VA: 0x180DE3B60
	private static void ConnectionStatusChanged(SteamNetConnectionStatusChangedCallback_t data) { }

	// RVA: 0xDE4650 Offset: 0xDE3A50 VA: 0x180DE4650
	private static void FakeIPResult(SteamNetworkingFakeIPResult_t data) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xDE4F60 Offset: 0xDE4360 VA: 0x180DE4F60
	public static void add_OnFakeIPResult(Action<NetAddress> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xDE5180 Offset: 0xDE4580 VA: 0x180DE5180
	public static void remove_OnFakeIPResult(Action<NetAddress> value) { }

	// RVA: 0xDE43D0 Offset: 0xDE37D0 VA: 0x180DE43D0
	public static SocketManager CreateNormalSocket(NetAddress address, ISocketManager intrface) { }

	// RVA: 0xDE39E0 Offset: 0xDE2DE0 VA: 0x180DE39E0
	public static ConnectionManager ConnectNormal(NetAddress address, IConnectionManager iface) { }

	// RVA: 0xDE48A0 Offset: 0xDE3CA0 VA: 0x180DE48A0
	public static Result GetFakeIP(int fakePortIndex, out NetAddress address) { }

	// RVA: 0xDE4510 Offset: 0xDE3910 VA: 0x180DE4510
	public static SocketManager CreateRelaySocketFakeIP(int fakePortIndex, ISocketManager intrface) { }

	// RVA: 0xDE4F20 Offset: 0xDE4320 VA: 0x180DE4F20
	public void .ctor() { }

	// RVA: 0xDE4E80 Offset: 0xDE4280 VA: 0x180DE4E80
	private static void .cctor() { }

}

public class SteamNetworkingUtils : SteamSharedClass<SteamNetworkingUtils> // TypeDefIndex: 5209
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private static Action<NetDebugOutput, string> OnDebugOutput; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private static SteamNetworkingAvailability <Status>k__BackingField; // 0x8
	private static NetDebugOutput _debugLevel; // 0xC
	private static NetDebugFunc _debugFunc; // 0x10
	private static ConcurrentQueue<SteamNetworkingUtils.DebugMessage> debugMessages; // 0x18

	// Properties
	internal static ISteamNetworkingUtils Internal { get; }
	public static SteamNetworkingAvailability Status { get; set; }
	public static int ConnectionTimeout { get; set; }
	public static int SendBufferSize { set; }
	public static int AllowWithoutAuth { set; }
	public static int Unencrypted { set; }
	public static int DebugLevelAckRTT { get; set; }
	public static int DebugLevelPacketDecode { get; set; }
	public static int DebugLevelMessage { get; set; }
	public static int DebugLevelPacketGaps { get; set; }
	public static int DebugLevelP2PRendezvous { get; set; }
	public static int DebugLevelSDRRelayPings { get; set; }
	public static NetDebugOutput DebugLevel { get; set; }

	// Methods

	// RVA: 0x19D2970 Offset: 0x19D1D70 VA: 0x1819D2970
	internal static ISteamNetworkingUtils get_Internal() { }

	// RVA: 0x19D1F20 Offset: 0x19D1320 VA: 0x1819D1F20 Slot: 4
	internal override void InitializeInterface(bool server) { }

	// RVA: 0x19D20B0 Offset: 0x19D14B0 VA: 0x1819D20B0
	private static void InstallCallbacks(bool server) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x19D25F0 Offset: 0x19D19F0 VA: 0x1819D25F0
	public static void add_OnDebugOutput(Action<NetDebugOutput, string> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x19D2A50 Offset: 0x19D1E50 VA: 0x1819D2A50
	public static void remove_OnDebugOutput(Action<NetDebugOutput, string> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x19D29F0 Offset: 0x19D1DF0 VA: 0x1819D29F0
	public static SteamNetworkingAvailability get_Status() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x19D2F80 Offset: 0x19D2380 VA: 0x1819D2F80
	private static void set_Status(SteamNetworkingAvailability value) { }

	// RVA: 0x19D1EC0 Offset: 0x19D12C0 VA: 0x1819D1EC0
	public static void InitRelayNetworkAccess() { }

	// RVA: 0x19D26E0 Offset: 0x19D1AE0 VA: 0x1819D26E0
	public static int get_ConnectionTimeout() { }

	// RVA: 0x19D2BA0 Offset: 0x19D1FA0 VA: 0x1819D2BA0
	public static void set_ConnectionTimeout(int value) { }

	// RVA: 0x19D2F20 Offset: 0x19D2320 VA: 0x1819D2F20
	public static void set_SendBufferSize(int value) { }

	// RVA: 0x19D2B40 Offset: 0x19D1F40 VA: 0x1819D2B40
	public static void set_AllowWithoutAuth(int value) { }

	// RVA: 0x19D2FE0 Offset: 0x19D23E0 VA: 0x1819D2FE0
	public static void set_Unencrypted(int value) { }

	// RVA: 0x19D2730 Offset: 0x19D1B30 VA: 0x1819D2730
	public static int get_DebugLevelAckRTT() { }

	// RVA: 0x19D2C00 Offset: 0x19D2000 VA: 0x1819D2C00
	public static void set_DebugLevelAckRTT(int value) { }

	// RVA: 0x19D2820 Offset: 0x19D1C20 VA: 0x1819D2820
	public static int get_DebugLevelPacketDecode() { }

	// RVA: 0x19D2D20 Offset: 0x19D2120 VA: 0x1819D2D20
	public static void set_DebugLevelPacketDecode(int value) { }

	// RVA: 0x19D2780 Offset: 0x19D1B80 VA: 0x1819D2780
	public static int get_DebugLevelMessage() { }

	// RVA: 0x19D2C60 Offset: 0x19D2060 VA: 0x1819D2C60
	public static void set_DebugLevelMessage(int value) { }

	// RVA: 0x19D2870 Offset: 0x19D1C70 VA: 0x1819D2870
	public static int get_DebugLevelPacketGaps() { }

	// RVA: 0x19D2D80 Offset: 0x19D2180 VA: 0x1819D2D80
	public static void set_DebugLevelPacketGaps(int value) { }

	// RVA: 0x19D27D0 Offset: 0x19D1BD0 VA: 0x1819D27D0
	public static int get_DebugLevelP2PRendezvous() { }

	// RVA: 0x19D2CC0 Offset: 0x19D20C0 VA: 0x1819D2CC0
	public static void set_DebugLevelP2PRendezvous(int value) { }

	// RVA: 0x19D28C0 Offset: 0x19D1CC0 VA: 0x1819D28C0
	public static int get_DebugLevelSDRRelayPings() { }

	// RVA: 0x19D2DE0 Offset: 0x19D21E0 VA: 0x1819D2DE0
	public static void set_DebugLevelSDRRelayPings(int value) { }

	// RVA: 0x19D2910 Offset: 0x19D1D10 VA: 0x1819D2910
	public static NetDebugOutput get_DebugLevel() { }

	// RVA: 0x19D2E40 Offset: 0x19D2240 VA: 0x1819D2E40
	public static void set_DebugLevel(NetDebugOutput value) { }

	[MonoPInvokeCallbackAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x19D2280 Offset: 0x19D1680 VA: 0x1819D2280
	private static void OnDebugMessage(NetDebugOutput nType, IntPtr str) { }

	// RVA: 0x19D21C0 Offset: 0x19D15C0 VA: 0x1819D21C0
	internal static void LogDebugMessage(NetDebugOutput type, string message) { }

	// RVA: 0x19D2370 Offset: 0x19D1770 VA: 0x1819D2370
	internal static void OutputDebugMessages() { }

	// RVA: 0x19D1D90 Offset: 0x19D1190 VA: 0x1819D1D90
	internal static NetMsg* AllocateMessage() { }

	// RVA: 0x19D24A0 Offset: 0x19D18A0 VA: 0x1819D24A0
	internal static bool SetConfigInt(NetConfig type, int value) { }

	// RVA: 0x19D1DF0 Offset: 0x19D11F0 VA: 0x1819D1DF0
	internal static int GetConfigInt(NetConfig type) { }

	// RVA: 0x19D25B0 Offset: 0x19D19B0 VA: 0x1819D25B0
	public void .ctor() { }

	// RVA: 0x19D2540 Offset: 0x19D1940 VA: 0x1819D2540
	private static void .cctor() { }

}

private struct SteamNetworkingUtils.DebugMessage // TypeDefIndex: 5210
{	// Fields
	public NetDebugOutput Type; // 0x0
	public string Msg; // 0x8

}

private sealed class SteamNetworkingUtils.<>c // TypeDefIndex: 5211
{	// Fields
	public static readonly SteamNetworkingUtils.<>c <>9; // 0x0
	public static Action<SteamRelayNetworkStatus_t> <>9__3_0; // 0x8

	// Methods

	// RVA: 0x19DAE50 Offset: 0x19DA250 VA: 0x1819DAE50
	private static void .cctor() { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x19D9C10 Offset: 0x19D9010 VA: 0x1819D9C10
	internal void <InstallCallbacks>b__3_0(SteamRelayNetworkStatus_t x) { }

}

public class SteamParental : SteamSharedClass<SteamParental> // TypeDefIndex: 5212
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private static Action OnSettingsChanged; // 0x2B0AA90

	// Methods

	// RVA: 0x19D3360 Offset: 0x19D2760 VA: 0x1819D3360 Slot: 4
	internal override void InitializeInterface(bool server) { }

	// RVA: 0x19D34D0 Offset: 0x19D28D0 VA: 0x1819D34D0
	internal static void InstallEvents(bool server) { }

	// RVA: 0x19D35E0 Offset: 0x19D29E0 VA: 0x1819D35E0
	public void .ctor() { }

}

private sealed class SteamParental.<>c // TypeDefIndex: 5213
{	// Fields
	public static readonly SteamParental.<>c <>9; // 0x0
	public static Action<SteamParentalSettingsChanged_t> <>9__3_0; // 0x8

	// Methods

	// RVA: 0x19DAEB0 Offset: 0x19DA2B0 VA: 0x1819DAEB0
	private static void .cctor() { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x19D9CC0 Offset: 0x19D90C0 VA: 0x1819D9CC0
	internal void <InstallEvents>b__3_0(SteamParentalSettingsChanged_t x) { }

}

public class SteamParties : SteamClientClass<SteamParties> // TypeDefIndex: 5214
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private static Action OnBeaconLocationsUpdated; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private static Action OnActiveBeaconsUpdated; // 0x8

	// Methods

	// RVA: 0x19D3620 Offset: 0x19D2A20 VA: 0x1819D3620 Slot: 4
	internal override void InitializeInterface(bool server) { }

	// RVA: 0x19D36B0 Offset: 0x19D2AB0 VA: 0x1819D36B0
	internal void InstallEvents(bool server) { }

	// RVA: 0x19D3890 Offset: 0x19D2C90 VA: 0x1819D3890
	public void .ctor() { }

}

private sealed class SteamParties.<>c // TypeDefIndex: 5215
{	// Fields
	public static readonly SteamParties.<>c <>9; // 0x0
	public static Action<AvailableBeaconLocationsUpdated_t> <>9__3_0; // 0x8
	public static Action<ActiveBeaconsUpdated_t> <>9__3_1; // 0x10

	// Methods

	// RVA: 0x19DAF10 Offset: 0x19DA310 VA: 0x1819DAF10
	private static void .cctor() { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x19D9D80 Offset: 0x19D9180 VA: 0x1819D9D80
	internal void <InstallEvents>b__3_0(AvailableBeaconLocationsUpdated_t x) { }

	// RVA: 0x19DA080 Offset: 0x19D9480 VA: 0x1819DA080
	internal void <InstallEvents>b__3_1(ActiveBeaconsUpdated_t x) { }

}

public class SteamRemotePlay : SteamClientClass<SteamRemotePlay> // TypeDefIndex: 5216
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private static Action<RemotePlaySession> OnSessionConnected; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private static Action<RemotePlaySession> OnSessionDisconnected; // 0x8

	// Methods

	// RVA: 0x19D38D0 Offset: 0x19D2CD0 VA: 0x1819D38D0 Slot: 4
	internal override void InitializeInterface(bool server) { }

	// RVA: 0x19D3960 Offset: 0x19D2D60 VA: 0x1819D3960
	internal void InstallEvents(bool server) { }

	// RVA: 0x19D3B40 Offset: 0x19D2F40 VA: 0x1819D3B40
	public void .ctor() { }

}

private sealed class SteamRemotePlay.<>c // TypeDefIndex: 5217
{	// Fields
	public static readonly SteamRemotePlay.<>c <>9; // 0x0
	public static Action<SteamRemotePlaySessionConnected_t> <>9__3_0; // 0x8
	public static Action<SteamRemotePlaySessionDisconnected_t> <>9__3_1; // 0x10

	// Methods

	// RVA: 0x19DAD30 Offset: 0x19DA130 VA: 0x1819DAD30
	private static void .cctor() { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x19D9D10 Offset: 0x19D9110 VA: 0x1819D9D10
	internal void <InstallEvents>b__3_0(SteamRemotePlaySessionConnected_t x) { }

	// RVA: 0x19D9F90 Offset: 0x19D9390 VA: 0x1819D9F90
	internal void <InstallEvents>b__3_1(SteamRemotePlaySessionDisconnected_t x) { }

}

public class SteamRemoteStorage : SteamClientClass<SteamRemoteStorage> // TypeDefIndex: 5218
{	// Methods

	// RVA: 0x19D3B80 Offset: 0x19D2F80 VA: 0x1819D3B80 Slot: 4
	internal override void InitializeInterface(bool server) { }

	// RVA: 0x19D3C00 Offset: 0x19D3000 VA: 0x1819D3C00
	public void .ctor() { }

}

public class SteamScreenshots : SteamClientClass<SteamScreenshots> // TypeDefIndex: 5219
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private static Action OnScreenshotRequested; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private static Action<Screenshot> OnScreenshotReady; // 0x8
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private static Action<Result> OnScreenshotFailed; // 0x10

	// Properties
	internal static ISteamScreenshots Internal { get; }

	// Methods

	// RVA: 0x19D3F60 Offset: 0x19D3360 VA: 0x1819D3F60
	internal static ISteamScreenshots get_Internal() { }

	// RVA: 0x19D3C40 Offset: 0x19D3040 VA: 0x1819D3C40 Slot: 4
	internal override void InitializeInterface(bool server) { }

	// RVA: 0x19D3CC0 Offset: 0x19D30C0 VA: 0x1819D3CC0
	internal static void InstallEvents() { }

	// RVA: 0x19D3E90 Offset: 0x19D3290 VA: 0x1819D3E90
	public static void TriggerScreenshot() { }

	// RVA: 0x19D3F20 Offset: 0x19D3320 VA: 0x1819D3F20
	public void .ctor() { }

}

private sealed class SteamScreenshots.<>c // TypeDefIndex: 5220
{	// Fields
	public static readonly SteamScreenshots.<>c <>9; // 0x0
	public static Action<ScreenshotRequested_t> <>9__3_0; // 0x8
	public static Action<ScreenshotReady_t> <>9__3_1; // 0x10

	// Methods

	// RVA: 0x19DADF0 Offset: 0x19DA1F0 VA: 0x1819DADF0
	private static void .cctor() { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x19D9E40 Offset: 0x19D9240 VA: 0x1819D9E40
	internal void <InstallEvents>b__3_0(ScreenshotRequested_t x) { }

	// RVA: 0x19D9EF0 Offset: 0x19D92F0 VA: 0x1819D9EF0
	internal void <InstallEvents>b__3_1(ScreenshotReady_t x) { }

}

public class SteamUGC : SteamSharedClass<SteamUGC> // TypeDefIndex: 5221
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private static Action<Result> OnDownloadItemResult; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private static Action<AppId, PublishedFileId> OnItemSubscribed; // 0x8
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private static Action<AppId, PublishedFileId> OnItemUnsubscribed; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private static Action<AppId, PublishedFileId> OnItemInstalled; // 0x18

	// Properties
	internal static ISteamUGC Internal { get; }

	// Methods

	// RVA: 0x19D4550 Offset: 0x19D3950 VA: 0x1819D4550
	internal static ISteamUGC get_Internal() { }

	// RVA: 0x19D4030 Offset: 0x19D3430 VA: 0x1819D4030 Slot: 4
	internal override void InitializeInterface(bool server) { }

	// RVA: 0x19D40C0 Offset: 0x19D34C0 VA: 0x1819D40C0
	internal static void InstallEvents(bool server) { }

	// RVA: 0x19D3FF0 Offset: 0x19D33F0 VA: 0x1819D3FF0
	public static bool Download(PublishedFileId fileId, bool highPriority = False) { }

	[AsyncStateMachineAttribute] // RVA: 0x94AF0 Offset: 0x93EF0 VA: 0x180094AF0
	// RVA: 0x19D4450 Offset: 0x19D3850 VA: 0x1819D4450
	public static Task<Nullable<Item>> QueryFileAsync(PublishedFileId fileId) { }

	// RVA: 0x19D4510 Offset: 0x19D3910 VA: 0x1819D4510
	public void .ctor() { }

}

private sealed class SteamUGC.<>c // TypeDefIndex: 5222
{	// Fields
	public static readonly SteamUGC.<>c <>9; // 0x0
	public static Action<DownloadItemResult_t> <>9__3_0; // 0x8
	public static Action<RemoteStoragePublishedFileSubscribed_t> <>9__3_1; // 0x10
	public static Action<RemoteStoragePublishedFileUnsubscribed_t> <>9__3_2; // 0x18
	public static Action<ItemInstalled_t> <>9__3_3; // 0x20

	// Methods

	// RVA: 0x19DAC10 Offset: 0x19DA010 VA: 0x1819DAC10
	private static void .cctor() { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x19D9E90 Offset: 0x19D9290 VA: 0x1819D9E90
	internal void <InstallEvents>b__3_0(DownloadItemResult_t x) { }

	// RVA: 0x19DA000 Offset: 0x19D9400 VA: 0x1819DA000
	internal void <InstallEvents>b__3_1(RemoteStoragePublishedFileSubscribed_t x) { }

	// RVA: 0x19DA220 Offset: 0x19D9620 VA: 0x1819DA220
	internal void <InstallEvents>b__3_2(RemoteStoragePublishedFileUnsubscribed_t x) { }

	// RVA: 0x19DA2A0 Offset: 0x19D96A0 VA: 0x1819DA2A0
	internal void <InstallEvents>b__3_3(ItemInstalled_t x) { }

}

private struct SteamUGC.<QueryFileAsync>d__19 : IAsyncStateMachine // TypeDefIndex: 5223
{	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder<Nullable<Item>> <>t__builder; // 0x8
	public PublishedFileId fileId; // 0x20
	private TaskAwaiter<Nullable<ResultPage>> <>u__1; // 0x28

	// Methods

	// RVA: 0x224D00 Offset: 0x224100 VA: 0x180224D00 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x224D10 Offset: 0x224110 VA: 0x180224D10 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

public class SteamUser : SteamClientClass<SteamUser> // TypeDefIndex: 5224
{	// Fields
	private static Dictionary<string, string> richPresence; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private static Action OnSteamServersConnected; // 0x8
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private static Action OnSteamServerConnectFailure; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private static Action OnSteamServersDisconnected; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private static Action OnClientGameServerDeny; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private static Action OnLicensesUpdated; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private static Action<SteamId, SteamId, AuthResponse> OnValidateAuthTicketResponse; // 0x30
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private static Action<GetAuthSessionTicketResponse_t> OnGetAuthSessionTicketResponse; // 0x38
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private static Action<AppId, ulong, bool> OnMicroTxnAuthorizationResponse; // 0x40
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private static Action<string> OnGameWebCallback; // 0x48
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private static Action<DurationControl> OnDurationControl; // 0x50
	private static bool _recordingVoice; // 0x58
	private static byte[] readBuffer; // 0x60
	private static uint sampleRate; // 0x68

	// Properties
	internal static ISteamUser Internal { get; }
	public static bool VoiceRecord { get; set; }
	public static bool HasVoiceData { get; }
	public static uint SampleRate { get; set; }
	public static uint OptimalSampleRate { get; }
	public static bool IsTwoFactorEnabled { get; }

	// Methods

	// RVA: 0x19D64C0 Offset: 0x19D58C0 VA: 0x1819D64C0
	internal static ISteamUser get_Internal() { }

	// RVA: 0x19D5330 Offset: 0x19D4730 VA: 0x1819D5330 Slot: 4
	internal override void InitializeInterface(bool server) { }

	// RVA: 0x19D55F0 Offset: 0x19D49F0 VA: 0x1819D55F0
	internal static void InstallEvents() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x19D6220 Offset: 0x19D5620 VA: 0x1819D6220
	internal static void add_OnGetAuthSessionTicketResponse(Action<GetAuthSessionTicketResponse_t> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x19D66D0 Offset: 0x19D5AD0 VA: 0x1819D66D0
	internal static void remove_OnGetAuthSessionTicketResponse(Action<GetAuthSessionTicketResponse_t> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x19D6320 Offset: 0x19D5720 VA: 0x1819D6320
	public static void add_OnMicroTxnAuthorizationResponse(Action<AppId, ulong, bool> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x19D67D0 Offset: 0x19D5BD0 VA: 0x1819D67D0
	public static void remove_OnMicroTxnAuthorizationResponse(Action<AppId, ulong, bool> value) { }

	// RVA: 0x19D6670 Offset: 0x19D5A70 VA: 0x1819D6670
	public static bool get_VoiceRecord() { }

	// RVA: 0x19D6A70 Offset: 0x19D5E70 VA: 0x1819D6A70
	public static void set_VoiceRecord(bool value) { }

	// RVA: 0x19D6420 Offset: 0x19D5820 VA: 0x1819D6420
	public static bool get_HasVoiceData() { }

	// RVA: 0x19D5E40 Offset: 0x19D5240 VA: 0x1819D5E40
	public static byte[] ReadVoiceDataBytes() { }

	// RVA: 0x19D6610 Offset: 0x19D5A10 VA: 0x1819D6610
	public static uint get_SampleRate() { }

	// RVA: 0x19D68D0 Offset: 0x19D5CD0 VA: 0x1819D68D0
	public static void set_SampleRate(uint value) { }

	// RVA: 0x19D65B0 Offset: 0x19D59B0 VA: 0x1819D65B0
	public static uint get_OptimalSampleRate() { }

	// RVA: 0x19D4F20 Offset: 0x19D4320 VA: 0x1819D4F20
	public static int DecompressVoice(byte[] from, Stream output) { }

	// RVA: 0x19D51D0 Offset: 0x19D45D0 VA: 0x1819D51D0
	public static AuthTicket GetAuthSessionTicket() { }

	[AsyncStateMachineAttribute] // RVA: 0x95760 Offset: 0x94B60 VA: 0x180095760
	// RVA: 0x19D50F0 Offset: 0x19D44F0 VA: 0x1819D50F0
	public static Task<AuthTicket> GetAuthSessionTicketAsync(double timeoutSeconds = 10) { }

	// RVA: 0x19D6550 Offset: 0x19D5950 VA: 0x1819D6550
	public static bool get_IsTwoFactorEnabled() { }

	[AsyncStateMachineAttribute] // RVA: 0x95860 Offset: 0x94C60 VA: 0x180095860
	// RVA: 0x19D60B0 Offset: 0x19D54B0 VA: 0x1819D60B0
	public static Task<byte[]> RequestEncryptedAppTicketAsync() { }

	// RVA: 0x19D61E0 Offset: 0x19D55E0 VA: 0x1819D61E0
	public void .ctor() { }

	// RVA: 0x19D6170 Offset: 0x19D5570 VA: 0x1819D6170
	private static void .cctor() { }

}

private sealed class SteamUser.<>c // TypeDefIndex: 5225
{	// Fields
	public static readonly SteamUser.<>c <>9; // 0x0
	public static Action<SteamServersConnected_t> <>9__4_0; // 0x8
	public static Action<SteamServerConnectFailure_t> <>9__4_1; // 0x10
	public static Action<SteamServersDisconnected_t> <>9__4_2; // 0x18
	public static Action<ClientGameServerDeny_t> <>9__4_3; // 0x20
	public static Action<LicensesUpdated_t> <>9__4_4; // 0x28
	public static Action<ValidateAuthTicketResponse_t> <>9__4_5; // 0x30
	public static Action<MicroTxnAuthorizationResponse_t> <>9__4_6; // 0x38
	public static Action<GameWebCallback_t> <>9__4_7; // 0x40
	public static Action<GetAuthSessionTicketResponse_t> <>9__4_8; // 0x48
	public static Action<DurationControl_t> <>9__4_9; // 0x50

	// Methods

	// RVA: 0x19DACD0 Offset: 0x19DA0D0 VA: 0x1819DACD0
	private static void .cctor() { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x19DA3A0 Offset: 0x19D97A0 VA: 0x1819DA3A0
	internal void <InstallEvents>b__4_0(SteamServersConnected_t x) { }

	// RVA: 0x19DA410 Offset: 0x19D9810 VA: 0x1819DA410
	internal void <InstallEvents>b__4_1(SteamServerConnectFailure_t x) { }

	// RVA: 0x19DA480 Offset: 0x19D9880 VA: 0x1819DA480
	internal void <InstallEvents>b__4_2(SteamServersDisconnected_t x) { }

	// RVA: 0x19DA4F0 Offset: 0x19D98F0 VA: 0x1819DA4F0
	internal void <InstallEvents>b__4_3(ClientGameServerDeny_t x) { }

	// RVA: 0x19DA560 Offset: 0x19D9960 VA: 0x1819DA560
	internal void <InstallEvents>b__4_4(LicensesUpdated_t x) { }

	// RVA: 0x19DA5D0 Offset: 0x19D99D0 VA: 0x1819DA5D0
	internal void <InstallEvents>b__4_5(ValidateAuthTicketResponse_t x) { }

	// RVA: 0x19DA6A0 Offset: 0x19D9AA0 VA: 0x1819DA6A0
	internal void <InstallEvents>b__4_6(MicroTxnAuthorizationResponse_t x) { }

	// RVA: 0x19DA760 Offset: 0x19D9B60 VA: 0x1819DA760
	internal void <InstallEvents>b__4_7(GameWebCallback_t x) { }

	// RVA: 0x19DA7F0 Offset: 0x19D9BF0 VA: 0x1819DA7F0
	internal void <InstallEvents>b__4_8(GetAuthSessionTicketResponse_t x) { }

	// RVA: 0x19DA870 Offset: 0x19D9C70 VA: 0x1819DA870
	internal void <InstallEvents>b__4_9(DurationControl_t x) { }

}

private sealed class SteamUser.<>c__DisplayClass54_0 // TypeDefIndex: 5226
{	// Fields
	public AuthTicket ticket; // 0x10
	public Result result; // 0x18

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x19DABE0 Offset: 0x19D9FE0 VA: 0x1819DABE0
	internal void <GetAuthSessionTicketAsync>g__f|0(GetAuthSessionTicketResponse_t t) { }

}

private struct SteamUser.<GetAuthSessionTicketAsync>d__54 : IAsyncStateMachine // TypeDefIndex: 5227
{	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder<AuthTicket> <>t__builder; // 0x8
	public double timeoutSeconds; // 0x20
	private SteamUser.<>c__DisplayClass54_0 <>8__1; // 0x28
	private Stopwatch <stopwatch>5__2; // 0x30
	private TaskAwaiter <>u__1; // 0x38

	// Methods

	// RVA: 0x224C40 Offset: 0x224040 VA: 0x180224C40 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x224C50 Offset: 0x224050 VA: 0x180224C50 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

private struct SteamUser.<RequestEncryptedAppTicketAsync>d__71 : IAsyncStateMachine // TypeDefIndex: 5228
{	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder<byte[]> <>t__builder; // 0x8
	private CallResult<EncryptedAppTicketResponse_t> <>u__1; // 0x20

	// Methods

	// RVA: 0x224D60 Offset: 0x224160 VA: 0x180224D60 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x224D70 Offset: 0x224170 VA: 0x180224D70 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

public class SteamUserStats : SteamClientClass<SteamUserStats> // TypeDefIndex: 5229
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private static bool <StatsRecieved>k__BackingField; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private static Action<string, int> OnAchievementIconFetched; // 0x8
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private static Action<SteamId, Result> OnUserStatsReceived; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private static Action<Result> OnUserStatsStored; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private static Action<Achievement, int, int> OnAchievementProgress; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private static Action<SteamId> OnUserStatsUnloaded; // 0x28

	// Properties
	internal static ISteamUserStats Internal { get; }
	internal static bool StatsRecieved { set; }
	public static IEnumerable<Achievement> Achievements { get; }

	// Methods

	// RVA: 0x19D4DA0 Offset: 0x19D41A0 VA: 0x1819D4DA0
	internal static ISteamUserStats get_Internal() { }

	// RVA: 0x19D4660 Offset: 0x19D3A60 VA: 0x1819D4660 Slot: 4
	internal override void InitializeInterface(bool server) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x19D4EE0 Offset: 0x19D42E0 VA: 0x1819D4EE0
	internal static void set_StatsRecieved(bool value) { }

	// RVA: 0x19D4700 Offset: 0x19D3B00 VA: 0x1819D4700
	internal static void InstallEvents() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x19D4C90 Offset: 0x19D4090 VA: 0x1819D4C90
	public static void add_OnAchievementProgress(Action<Achievement, int, int> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x19D4E30 Offset: 0x19D4230 VA: 0x1819D4E30
	public static void remove_OnAchievementProgress(Action<Achievement, int, int> value) { }

	[IteratorStateMachineAttribute] // RVA: 0x96510 Offset: 0x95910 VA: 0x180096510
	// RVA: 0x19D4D40 Offset: 0x19D4140 VA: 0x1819D4D40
	public static IEnumerable<Achievement> get_Achievements() { }

	// RVA: 0x19D4C20 Offset: 0x19D4020 VA: 0x1819D4C20
	public static bool StoreStats() { }

	// RVA: 0x19D4B40 Offset: 0x19D3F40 VA: 0x1819D4B40
	public static bool RequestCurrentStats() { }

	// RVA: 0x19D4BA0 Offset: 0x19D3FA0 VA: 0x1819D4BA0
	public static bool SetStat(string name, int value) { }

	// RVA: 0x19D4BE0 Offset: 0x19D3FE0 VA: 0x1819D4BE0
	public static bool SetStat(string name, float value) { }

	// RVA: 0x19D4620 Offset: 0x19D3A20 VA: 0x1819D4620
	public static int GetStatInt(string name) { }

	// RVA: 0x19D45D0 Offset: 0x19D39D0 VA: 0x1819D45D0
	public static float GetStatFloat(string name) { }

	// RVA: 0x19D4B70 Offset: 0x19D3F70 VA: 0x1819D4B70
	public static bool ResetAll(bool includeAchievements) { }

	// RVA: 0x19D4C50 Offset: 0x19D4050 VA: 0x1819D4C50
	public void .ctor() { }

}

private sealed class SteamUserStats.<>c // TypeDefIndex: 5230
{	// Fields
	public static readonly SteamUserStats.<>c <>9; // 0x0
	public static Action<UserStatsReceived_t> <>9__7_0; // 0x8
	public static Action<UserStatsStored_t> <>9__7_1; // 0x10
	public static Action<UserAchievementStored_t> <>9__7_2; // 0x18
	public static Action<UserStatsUnloaded_t> <>9__7_3; // 0x20
	public static Action<UserAchievementIconFetched_t> <>9__7_4; // 0x28

	// Methods

	// RVA: 0x19DAC70 Offset: 0x19DA070 VA: 0x1819DAC70
	private static void .cctor() { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x19DA900 Offset: 0x19D9D00 VA: 0x1819DA900
	internal void <InstallEvents>b__7_0(UserStatsReceived_t x) { }

	// RVA: 0x19DA9F0 Offset: 0x19D9DF0 VA: 0x1819DA9F0
	internal void <InstallEvents>b__7_1(UserStatsStored_t x) { }

	// RVA: 0x19DAA50 Offset: 0x19D9E50 VA: 0x1819DAA50
	internal void <InstallEvents>b__7_2(UserAchievementStored_t x) { }

	// RVA: 0x19DAAF0 Offset: 0x19D9EF0 VA: 0x1819DAAF0
	internal void <InstallEvents>b__7_3(UserStatsUnloaded_t x) { }

	// RVA: 0x19DAB60 Offset: 0x19D9F60 VA: 0x1819DAB60
	internal void <InstallEvents>b__7_4(UserAchievementIconFetched_t x) { }

}

private sealed class SteamUserStats.<get_Achievements>d__24 : IEnumerable<Achievement>, IEnumerable, IEnumerator<Achievement>, IEnumerator, IDisposable // TypeDefIndex: 5231
{	// Fields
	private int <>1__state; // 0x10
	private Achievement <>2__current; // 0x18
	private int <>l__initialThreadId; // 0x20
	private int <i>5__2; // 0x24

	// Properties
	private Achievement System.Collections.Generic.IEnumerator<Steamworks.Data.Achievement>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xD824F0 Offset: 0xD818F0 VA: 0x180D824F0
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 7
	private void System.IDisposable.Dispose() { }

	// RVA: 0x19DB170 Offset: 0x19DA570 VA: 0x1819DB170 Slot: 8
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710 Slot: 6
	private Achievement System.Collections.Generic.IEnumerator<Steamworks.Data.Achievement>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x19DB2C0 Offset: 0x19DA6C0 VA: 0x1819DB2C0 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x19DB310 Offset: 0x19DA710 VA: 0x1819DB310 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x19DB230 Offset: 0x19DA630 VA: 0x1819DB230 Slot: 4
	private IEnumerator<Achievement> System.Collections.Generic.IEnumerable<Steamworks.Data.Achievement>.GetEnumerator() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x19DB230 Offset: 0x19DA630 VA: 0x1819DB230 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

public class SteamUtils : SteamSharedClass<SteamUtils> // TypeDefIndex: 5232
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private static Action OnIpCountryChanged; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private static Action<int> OnLowBatteryPower; // 0x8
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private static Action OnSteamShutdown; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private static Action<bool> OnGamepadTextInputDismissed; // 0x18
	private static NotificationPosition overlayNotificationPosition; // 0x20

	// Properties
	internal static ISteamUtils Internal { get; }
	public static string IpCountry { get; }
	public static bool IsOverlayEnabled { get; }

	// Methods

	// RVA: 0x19D74E0 Offset: 0x19D68E0 VA: 0x1819D74E0
	internal static ISteamUtils get_Internal() { }

	// RVA: 0x19D6F90 Offset: 0x19D6390 VA: 0x1819D6F90 Slot: 4
	internal override void InitializeInterface(bool server) { }

	// RVA: 0x19D7040 Offset: 0x19D6440 VA: 0x1819D7040
	internal static void InstallEvents(bool server) { }

	// RVA: 0x19D73D0 Offset: 0x19D67D0 VA: 0x1819D73D0
	private static void SteamClosed() { }

	// RVA: 0x19D7560 Offset: 0x19D6960 VA: 0x1819D7560
	public static string get_IpCountry() { }

	// RVA: 0x19D6C50 Offset: 0x19D6050 VA: 0x1819D6C50
	public static bool GetImageSize(int image, out uint width, out uint height) { }

	// RVA: 0x19D6CF0 Offset: 0x19D60F0 VA: 0x1819D6CF0
	public static Nullable<Image> GetImage(int image) { }

	// RVA: 0x19D75C0 Offset: 0x19D69C0 VA: 0x1819D75C0
	public static bool get_IsOverlayEnabled() { }

	// RVA: 0x19D6F30 Offset: 0x19D6330 VA: 0x1819D6F30
	public static bool InitFilterText() { }

	// RVA: 0x19D6BA0 Offset: 0x19D5FA0 VA: 0x1819D6BA0
	public static string FilterText(TextFilteringContext context, SteamId sourceSteamID, string inputMessage) { }

	// RVA: 0x19D74A0 Offset: 0x19D68A0 VA: 0x1819D74A0
	public void .ctor() { }

	// RVA: 0x19D7460 Offset: 0x19D6860 VA: 0x1819D7460
	private static void .cctor() { }

}

private sealed class SteamUtils.<>c // TypeDefIndex: 5233
{	// Fields
	public static readonly SteamUtils.<>c <>9; // 0x0
	public static Action<IPCountry_t> <>9__3_0; // 0x8
	public static Action<LowBatteryPower_t> <>9__3_1; // 0x10
	public static Action<SteamShutdown_t> <>9__3_2; // 0x18
	public static Action<GamepadTextInputDismissed_t> <>9__3_3; // 0x20

	// Methods

	// RVA: 0x19DAD90 Offset: 0x19DA190 VA: 0x1819DAD90
	private static void .cctor() { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x19D9DD0 Offset: 0x19D91D0 VA: 0x1819D9DD0
	internal void <InstallEvents>b__3_0(IPCountry_t x) { }

	// RVA: 0x19DA0D0 Offset: 0x19D94D0 VA: 0x1819DA0D0
	internal void <InstallEvents>b__3_1(LowBatteryPower_t x) { }

	// RVA: 0x19DA150 Offset: 0x19D9550 VA: 0x1819DA150
	internal void <InstallEvents>b__3_2(SteamShutdown_t x) { }

	// RVA: 0x19DA320 Offset: 0x19D9720 VA: 0x1819DA320
	internal void <InstallEvents>b__3_3(GamepadTextInputDismissed_t x) { }

}

public class SteamVideo : SteamClientClass<SteamVideo> // TypeDefIndex: 5234
{	// Methods

	// RVA: 0x19D7620 Offset: 0x19D6A20 VA: 0x1819D7620 Slot: 4
	internal override void InitializeInterface(bool server) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0
	internal static void InstallEvents() { }

	// RVA: 0x19D76A0 Offset: 0x19D6AA0 VA: 0x1819D76A0
	public void .ctor() { }

}

public struct SteamId // TypeDefIndex: 5252
{	// Fields
	public ulong Value; // 0x0

	// Properties
	public uint AccountId { get; }

	// Methods

	// RVA: 0x4B0E80 Offset: 0x4B0280 VA: 0x1804B0E80
	public static SteamId op_Implicit(ulong value) { }

	// RVA: 0x4B0E80 Offset: 0x4B0280 VA: 0x1804B0E80
	public static ulong op_Implicit(SteamId value) { }

	// RVA: 0x123050 Offset: 0x122450 VA: 0x180123050 Slot: 3
	public override string ToString() { }

	// RVA: 0xF3850 Offset: 0xF2C50 VA: 0x1800F3850
	public uint get_AccountId() { }

}

internal abstract class SteamInterface // TypeDefIndex: 5266
{	// Fields
	public IntPtr Self; // 0x10
	public IntPtr SelfGlobal; // 0x18
	public IntPtr SelfServer; // 0x20
	public IntPtr SelfClient; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private bool <IsServer>k__BackingField; // 0x30

	// Properties
	public bool IsValid { get; }
	public bool IsServer { get; set; }

	// Methods

	// RVA: 0xDE1820 Offset: 0xDE0C20 VA: 0x180DE1820 Slot: 4
	public virtual IntPtr GetUserInterfacePointer() { }

	// RVA: 0xDE17F0 Offset: 0xDE0BF0 VA: 0x180DE17F0 Slot: 5
	public virtual IntPtr GetServerInterfacePointer() { }

	// RVA: 0xDE17C0 Offset: 0xDE0BC0 VA: 0x180DE17C0 Slot: 6
	public virtual IntPtr GetGlobalInterfacePointer() { }

	// RVA: 0xDE1910 Offset: 0xDE0D10 VA: 0x180DE1910
	public bool get_IsValid() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x8298F0 Offset: 0x828CF0 VA: 0x1808298F0
	public bool get_IsServer() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x829920 Offset: 0x828D20 VA: 0x180829920
	private void set_IsServer(bool value) { }

	// RVA: 0xDE1850 Offset: 0xDE0C50 VA: 0x180DE1850
	internal void SetupInterface(bool gameServer) { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	protected void .ctor() { }

}

public abstract class SteamClass // TypeDefIndex: 5267
{	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	internal abstract void InitializeInterface(bool server);

	// RVA: -1 Offset: -1 Slot: 5
	internal abstract void DestroyInterface(bool server);

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	protected void .ctor() { }

}

public class SteamSharedClass<T> : SteamClass // TypeDefIndex: 5268
{	// Fields
	internal static SteamInterface InterfaceClient; // 0x0
	internal static SteamInterface InterfaceServer; // 0x0

	// Properties
	internal static SteamInterface Interface { get; }

	// Methods

	// RVA: -1 Offset: -1
	internal static SteamInterface get_Interface() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A41EC0 Offset: 0x1A412C0 VA: 0x181A41EC0
	|-SteamSharedClass<SteamApps>.get_Interface
	|-SteamSharedClass<SteamInventory>.get_Interface
	|-SteamSharedClass<SteamNetworkingSockets>.get_Interface
	|-SteamSharedClass<SteamNetworkingUtils>.get_Interface
	|-SteamSharedClass<SteamUGC>.get_Interface
	|-SteamSharedClass<SteamUtils>.get_Interface
	|-SteamSharedClass<object>.get_Interface
	*/

	// RVA: -1 Offset: -1 Slot: 4
	internal override void InitializeInterface(bool server) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0
	|-SteamSharedClass<object>.InitializeInterface
	*/

	// RVA: -1 Offset: -1 Slot: 6
	internal virtual void SetInterface(bool server, SteamInterface iface) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A41E50 Offset: 0x1A41250 VA: 0x181A41E50
	|-SteamSharedClass<SteamApps>.SetInterface
	|-SteamSharedClass<SteamInventory>.SetInterface
	|-SteamSharedClass<SteamNetworking>.SetInterface
	|-SteamSharedClass<SteamNetworkingSockets>.SetInterface
	|-SteamSharedClass<SteamNetworkingUtils>.SetInterface
	|-SteamSharedClass<SteamParental>.SetInterface
	|-SteamSharedClass<SteamUGC>.SetInterface
	|-SteamSharedClass<SteamUtils>.SetInterface
	|-SteamSharedClass<object>.SetInterface
	*/

	// RVA: -1 Offset: -1 Slot: 5
	internal override void DestroyInterface(bool server) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A41DE0 Offset: 0x1A411E0 VA: 0x181A41DE0
	|-SteamSharedClass<SteamApps>.DestroyInterface
	|-SteamSharedClass<SteamInventory>.DestroyInterface
	|-SteamSharedClass<SteamNetworking>.DestroyInterface
	|-SteamSharedClass<SteamNetworkingSockets>.DestroyInterface
	|-SteamSharedClass<SteamNetworkingUtils>.DestroyInterface
	|-SteamSharedClass<SteamParental>.DestroyInterface
	|-SteamSharedClass<SteamUGC>.DestroyInterface
	|-SteamSharedClass<SteamUtils>.DestroyInterface
	|-SteamSharedClass<object>.DestroyInterface
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD4BD40 Offset: 0xD4B140 VA: 0x180D4BD40
	|-SteamSharedClass<SteamApps>..ctor
	|-SteamSharedClass<SteamInventory>..ctor
	|-SteamSharedClass<SteamNetworking>..ctor
	|-SteamSharedClass<SteamNetworkingSockets>..ctor
	|-SteamSharedClass<SteamNetworkingUtils>..ctor
	|-SteamSharedClass<SteamParental>..ctor
	|-SteamSharedClass<SteamUGC>..ctor
	|-SteamSharedClass<SteamUtils>..ctor
	|-SteamSharedClass<object>..ctor
	*/

}

public class SteamClientClass<T> : SteamClass // TypeDefIndex: 5269
{	// Fields
	internal static SteamInterface Interface; // 0x0

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	internal override void InitializeInterface(bool server) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0
	|-SteamClientClass<object>.InitializeInterface
	*/

	// RVA: -1 Offset: -1 Slot: 6
	internal virtual void SetInterface(bool server, SteamInterface iface) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A41D40 Offset: 0x1A41140 VA: 0x181A41D40
	|-SteamClientClass<SteamFriends>.SetInterface
	|-SteamClientClass<SteamInput>.SetInterface
	|-SteamClientClass<SteamMatchmaking>.SetInterface
	|-SteamClientClass<SteamMatchmakingServers>.SetInterface
	|-SteamClientClass<SteamMusic>.SetInterface
	|-SteamClientClass<SteamParties>.SetInterface
	|-SteamClientClass<SteamRemotePlay>.SetInterface
	|-SteamClientClass<SteamRemoteStorage>.SetInterface
	|-SteamClientClass<SteamScreenshots>.SetInterface
	|-SteamClientClass<SteamUser>.SetInterface
	|-SteamClientClass<SteamUserStats>.SetInterface
	|-SteamClientClass<SteamVideo>.SetInterface
	|-SteamClientClass<object>.SetInterface
	*/

	// RVA: -1 Offset: -1 Slot: 5
	internal override void DestroyInterface(bool server) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A41D00 Offset: 0x1A41100 VA: 0x181A41D00
	|-SteamClientClass<SteamFriends>.DestroyInterface
	|-SteamClientClass<SteamInput>.DestroyInterface
	|-SteamClientClass<SteamMatchmaking>.DestroyInterface
	|-SteamClientClass<SteamMatchmakingServers>.DestroyInterface
	|-SteamClientClass<SteamMusic>.DestroyInterface
	|-SteamClientClass<SteamParties>.DestroyInterface
	|-SteamClientClass<SteamRemotePlay>.DestroyInterface
	|-SteamClientClass<SteamRemoteStorage>.DestroyInterface
	|-SteamClientClass<SteamScreenshots>.DestroyInterface
	|-SteamClientClass<SteamUser>.DestroyInterface
	|-SteamClientClass<SteamUserStats>.DestroyInterface
	|-SteamClientClass<SteamVideo>.DestroyInterface
	|-SteamClientClass<object>.DestroyInterface
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD4BD40 Offset: 0xD4B140 VA: 0x180D4BD40
	|-SteamClientClass<SteamFriends>..ctor
	|-SteamClientClass<SteamInput>..ctor
	|-SteamClientClass<SteamMatchmaking>..ctor
	|-SteamClientClass<SteamMatchmakingServers>..ctor
	|-SteamClientClass<SteamMusic>..ctor
	|-SteamClientClass<SteamParties>..ctor
	|-SteamClientClass<SteamRemotePlay>..ctor
	|-SteamClientClass<SteamRemoteStorage>..ctor
	|-SteamClientClass<SteamScreenshots>..ctor
	|-SteamClientClass<SteamUser>..ctor
	|-SteamClientClass<SteamUserStats>..ctor
	|-SteamClientClass<SteamVideo>..ctor
	|-SteamClientClass<object>..ctor
	*/

}

internal struct SteamParamStringArray : IDisposable // TypeDefIndex: 5273
{	// Fields
	public SteamParamStringArray_t Value; // 0x0
	private IntPtr[] NativeStrings; // 0x10
	private IntPtr NativeArray; // 0x18

	// Methods

	// RVA: 0x19D3120 Offset: 0x19D2520 VA: 0x1819D3120
	public static SteamParamStringArray From(string[] array) { }

	// RVA: 0x224B60 Offset: 0x223F60 VA: 0x180224B60 Slot: 4
	public void Dispose() { }

}

internal struct SteamServersConnected_t : ICallbackData // TypeDefIndex: 5293
{	// Fields
	public static int _datasize; // 0x2B0AAB0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1D9F00 Offset: 0x1D9300 VA: 0x1801D9F00 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1D9EF0 Offset: 0x1D92F0 VA: 0x1801D9EF0 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x128B490 Offset: 0x128A890 VA: 0x18128B490
	private static void .cctor() { }

}

internal struct SteamServerConnectFailure_t : ICallbackData // TypeDefIndex: 5294
{	// Fields
	internal Result Result; // 0x0
	internal bool StillRetrying; // 0x4
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1D9E90 Offset: 0x1D9290 VA: 0x1801D9E90 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1D9E80 Offset: 0x1D9280 VA: 0x1801D9E80 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x128B3E0 Offset: 0x128A7E0 VA: 0x18128B3E0
	private static void .cctor() { }

}

internal struct SteamServersDisconnected_t : ICallbackData // TypeDefIndex: 5295
{	// Fields
	internal Result Result; // 0x0
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1D9F70 Offset: 0x1D9370 VA: 0x1801D9F70 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1D9F60 Offset: 0x1D9360 VA: 0x1801D9F60 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x128B540 Offset: 0x128A940 VA: 0x18128B540
	private static void .cctor() { }

}

internal struct SteamAPICallCompleted_t : ICallbackData // TypeDefIndex: 5329
{	// Fields
	internal ulong AsyncCall; // 0x0
	internal int Callback; // 0x8
	internal uint ParamCount; // 0xC
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1D8950 Offset: 0x1D7D50 VA: 0x1801D8950 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1D8940 Offset: 0x1D7D40 VA: 0x1801D8940 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x128A5A0 Offset: 0x12899A0 VA: 0x18128A5A0
	private static void .cctor() { }

}

internal struct SteamShutdown_t : ICallbackData // TypeDefIndex: 5330
{	// Fields
	public static int _datasize; // 0x12BA0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1D9FE0 Offset: 0x1D93E0 VA: 0x1801D9FE0 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1D9FD0 Offset: 0x1D93D0 VA: 0x1801D9FD0 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x128B5F0 Offset: 0x128A9F0 VA: 0x18128B5F0
	private static void .cctor() { }

}

internal struct SteamInputDeviceConnected_t : ICallbackData // TypeDefIndex: 5427
{	// Fields
	internal ulong ConnectedDeviceHandle; // 0x0
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1D8BB0 Offset: 0x1D7FB0 VA: 0x1801D8BB0 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1D8BA0 Offset: 0x1D7FA0 VA: 0x1801D8BA0 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x128A820 Offset: 0x1289C20 VA: 0x18128A820
	private static void .cctor() { }

}

internal struct SteamInputDeviceDisconnected_t : ICallbackData // TypeDefIndex: 5428
{	// Fields
	internal ulong DisconnectedDeviceHandle; // 0x0
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1D8C20 Offset: 0x1D8020 VA: 0x1801D8C20 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1D8C10 Offset: 0x1D8010 VA: 0x1801D8C10 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x128A8C0 Offset: 0x1289CC0 VA: 0x18128A8C0
	private static void .cctor() { }

}

internal struct SteamInputConfigurationLoaded_t : ICallbackData // TypeDefIndex: 5429
{	// Fields
	internal AppId AppID; // 0x0
	internal ulong DeviceHandle; // 0x4
	internal ulong MappingCreator; // 0xC
	internal uint MajorRevision; // 0x14
	internal uint MinorRevision; // 0x18
	internal bool UsesSteamInputAPI; // 0x1C
	internal bool UsesGamepadAPI; // 0x1D
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1D8B40 Offset: 0x1D7F40 VA: 0x1801D8B40 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1D8B30 Offset: 0x1D7F30 VA: 0x1801D8B30 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x128A780 Offset: 0x1289B80 VA: 0x18128A780
	private static void .cctor() { }

}

internal struct SteamUGCQueryCompleted_t : ICallbackData // TypeDefIndex: 5430
{	// Fields
	internal ulong Handle; // 0x0
	internal Result Result; // 0x8
	internal uint NumResultsReturned; // 0xC
	internal uint TotalMatchingResults; // 0x10
	internal bool CachedData; // 0x14
	internal byte[] NextCursor; // 0x18
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1DA920 Offset: 0x1D9D20 VA: 0x1801DA920 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1DA910 Offset: 0x1D9D10 VA: 0x1801DA910 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x128B820 Offset: 0x128AC20 VA: 0x18128B820
	private static void .cctor() { }

}

internal struct SteamUGCRequestUGCDetailsResult_t : ICallbackData // TypeDefIndex: 5431
{	// Fields
	internal SteamUGCDetails_t Details; // 0x0
	internal bool CachedData; // 0x88
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1DAB00 Offset: 0x1D9F00 VA: 0x1801DAB00 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1DAAF0 Offset: 0x1D9EF0 VA: 0x1801DAAF0 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x128B8D0 Offset: 0x128ACD0 VA: 0x18128B8D0
	private static void .cctor() { }

}

internal struct SteamAppInstalled_t : ICallbackData // TypeDefIndex: 5449
{	// Fields
	internal AppId AppID; // 0x0
	internal int InstallFolderIndex; // 0x4
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1D8A60 Offset: 0x1D7E60 VA: 0x1801D8A60 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1D8A50 Offset: 0x1D7E50 VA: 0x1801D8A50 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x128A640 Offset: 0x1289A40 VA: 0x18128A640
	private static void .cctor() { }

}

internal struct SteamAppUninstalled_t : ICallbackData // TypeDefIndex: 5450
{	// Fields
	internal AppId AppID; // 0x0
	internal int InstallFolderIndex; // 0x4
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1D8AD0 Offset: 0x1D7ED0 VA: 0x1801D8AD0 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1D8AC0 Offset: 0x1D7EC0 VA: 0x1801D8AC0 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x128A6E0 Offset: 0x1289AE0 VA: 0x18128A6E0
	private static void .cctor() { }

}

internal struct SteamInventoryResultReady_t : ICallbackData // TypeDefIndex: 5474
{	// Fields
	internal int Handle; // 0x0
	internal Result Result; // 0x4
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1D8FD0 Offset: 0x1D83D0 VA: 0x1801D8FD0 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1D8FC0 Offset: 0x1D83C0 VA: 0x1801D8FC0 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x128AC90 Offset: 0x128A090 VA: 0x18128AC90
	private static void .cctor() { }

}

internal struct SteamInventoryFullUpdate_t : ICallbackData // TypeDefIndex: 5475
{	// Fields
	internal int Handle; // 0x0
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1D8D70 Offset: 0x1D8170 VA: 0x1801D8D70 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1D8D60 Offset: 0x1D8160 VA: 0x1801D8D60 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x128AAB0 Offset: 0x1289EB0 VA: 0x18128AAB0
	private static void .cctor() { }

}

internal struct SteamInventoryDefinitionUpdate_t : ICallbackData // TypeDefIndex: 5476
{	// Fields
	public static int _datasize; // 0x2B0AAB0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1D8C90 Offset: 0x1D8090 VA: 0x1801D8C90 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1D8C80 Offset: 0x1D8080 VA: 0x1801D8C80 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x128A960 Offset: 0x1289D60 VA: 0x18128A960
	private static void .cctor() { }

}

internal struct SteamInventoryEligiblePromoItemDefIDs_t : ICallbackData // TypeDefIndex: 5477
{	// Fields
	internal Result Result; // 0x0
	internal ulong SteamID; // 0x4
	internal int UmEligiblePromoItemDefs; // 0xC
	internal bool CachedData; // 0x10
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1D8D00 Offset: 0x1D8100 VA: 0x1801D8D00 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1D8CF0 Offset: 0x1D80F0 VA: 0x1801D8CF0 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x128AA10 Offset: 0x1289E10 VA: 0x18128AA10
	private static void .cctor() { }

}

internal struct SteamInventoryStartPurchaseResult_t : ICallbackData // TypeDefIndex: 5478
{	// Fields
	internal Result Result; // 0x0
	internal ulong OrderID; // 0x8
	internal ulong TransID; // 0x10
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1D90D0 Offset: 0x1D84D0 VA: 0x1801D90D0 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1D90C0 Offset: 0x1D84C0 VA: 0x1801D90C0 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x128AD30 Offset: 0x128A130 VA: 0x18128AD30
	private static void .cctor() { }

}

internal struct SteamInventoryRequestPricesResult_t : ICallbackData // TypeDefIndex: 5479
{	// Fields
	internal Result Result; // 0x0
	internal byte[] Currency; // 0x8
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1D8DD0 Offset: 0x1D81D0 VA: 0x1801D8DD0
	internal string CurrencyUTF8() { }

	// RVA: 0x1D8E60 Offset: 0x1D8260 VA: 0x1801D8E60 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1D8E50 Offset: 0x1D8250 VA: 0x1801D8E50 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x128ABE0 Offset: 0x1289FE0 VA: 0x18128ABE0
	private static void .cctor() { }

}

internal struct SteamParentalSettingsChanged_t : ICallbackData // TypeDefIndex: 5482
{	// Fields
	public static int _datasize; // 0x12E30

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1D9B60 Offset: 0x1D8F60 VA: 0x1801D9B60 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1D9B50 Offset: 0x1D8F50 VA: 0x1801D9B50 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x128B120 Offset: 0x128A520 VA: 0x18128B120
	private static void .cctor() { }

}

internal struct SteamRemotePlaySessionConnected_t : ICallbackData // TypeDefIndex: 5483
{	// Fields
	internal uint SessionID; // 0x0
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1D9DB0 Offset: 0x1D91B0 VA: 0x1801D9DB0 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1D9DA0 Offset: 0x1D91A0 VA: 0x1801D9DA0 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x128B280 Offset: 0x128A680 VA: 0x18128B280
	private static void .cctor() { }

}

internal struct SteamRemotePlaySessionDisconnected_t : ICallbackData // TypeDefIndex: 5484
{	// Fields
	internal uint SessionID; // 0x0
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1D9E20 Offset: 0x1D9220 VA: 0x1801D9E20 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1D9E10 Offset: 0x1D9210 VA: 0x1801D9E10 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x128B330 Offset: 0x128A730 VA: 0x18128B330
	private static void .cctor() { }

}

internal struct SteamNetworkingMessagesSessionRequest_t : ICallbackData // TypeDefIndex: 5485
{	// Fields
	internal NetIdentity DentityRemote; // 0x0
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1D9A80 Offset: 0x1D8E80 VA: 0x1801D9A80 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1D9A70 Offset: 0x1D8E70 VA: 0x1801D9A70 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x128B080 Offset: 0x128A480 VA: 0x18128B080
	private static void .cctor() { }

}

internal struct SteamNetworkingMessagesSessionFailed_t : ICallbackData // TypeDefIndex: 5486
{	// Fields
	internal ConnectionInfo Nfo; // 0x0
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1D9880 Offset: 0x1D8C80 VA: 0x1801D9880 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1D9870 Offset: 0x1D8C70 VA: 0x1801D9870 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x128AFE0 Offset: 0x128A3E0 VA: 0x18128AFE0
	private static void .cctor() { }

}

internal struct SteamNetConnectionStatusChangedCallback_t : ICallbackData // TypeDefIndex: 5487
{	// Fields
	internal Connection Conn; // 0x0
	internal ConnectionInfo Nfo; // 0x8
	internal ConnectionState OldState; // 0x2C0
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1D9360 Offset: 0x1D8760 VA: 0x1801D9360 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1D9350 Offset: 0x1D8750 VA: 0x1801D9350 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x128AE80 Offset: 0x128A280 VA: 0x18128AE80
	private static void .cctor() { }

}

internal struct SteamNetAuthenticationStatus_t : ICallbackData // TypeDefIndex: 5488
{	// Fields
	internal SteamNetworkingAvailability Avail; // 0x0
	internal byte[] DebugMsg; // 0x8
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1D91B0 Offset: 0x1D85B0 VA: 0x1801D91B0 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1D91A0 Offset: 0x1D85A0 VA: 0x1801D91A0 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x128ADE0 Offset: 0x128A1E0 VA: 0x18128ADE0
	private static void .cctor() { }

}

internal struct SteamRelayNetworkStatus_t : ICallbackData // TypeDefIndex: 5489
{	// Fields
	internal SteamNetworkingAvailability Avail; // 0x0
	internal int PingMeasurementInProgress; // 0x4
	internal SteamNetworkingAvailability AvailNetworkConfig; // 0x8
	internal SteamNetworkingAvailability AvailAnyRelay; // 0xC
	internal byte[] DebugMsg; // 0x10
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1D9BD0 Offset: 0x1D8FD0 VA: 0x1801D9BD0 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1D9BC0 Offset: 0x1D8FC0 VA: 0x1801D9BC0 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x128B1D0 Offset: 0x128A5D0 VA: 0x18128B1D0
	private static void .cctor() { }

}

internal struct SteamNetworkingFakeIPResult_t : ICallbackData // TypeDefIndex: 5502
{	// Fields
	internal Result Result; // 0x0
	internal NetIdentity Dentity; // 0x4
	internal uint IP; // 0x8C
	internal ushort[] Ports; // 0x90
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1D95B0 Offset: 0x1D89B0 VA: 0x1801D95B0 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1D95A0 Offset: 0x1D89A0 VA: 0x1801D95A0 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x128AF30 Offset: 0x128A330 VA: 0x18128AF30
	private static void .cctor() { }

}

internal struct SteamParamStringArray_t // TypeDefIndex: 5514
{	// Fields
	internal IntPtr Strings; // 0x0
	internal int NumStrings; // 0x8

}

internal struct SteamUGCDetails_t // TypeDefIndex: 5515
{	// Fields
	internal PublishedFileId PublishedFileId; // 0x0
	internal Result Result; // 0x8
	internal WorkshopFileType FileType; // 0xC
	internal AppId CreatorAppID; // 0x10
	internal AppId ConsumerAppID; // 0x14
	internal byte[] Title; // 0x18
	internal byte[] Description; // 0x20
	internal ulong SteamIDOwner; // 0x28
	internal uint TimeCreated; // 0x30
	internal uint TimeUpdated; // 0x34
	internal uint TimeAddedToUserList; // 0x38
	internal RemoteStoragePublishedFileVisibility Visibility; // 0x3C
	internal bool Banned; // 0x40
	internal bool AcceptedForUse; // 0x41
	internal bool TagsTruncated; // 0x42
	internal byte[] Tags; // 0x48
	internal ulong File; // 0x50
	internal ulong PreviewFile; // 0x58
	internal byte[] PchFileName; // 0x60
	internal int FileSize; // 0x68
	internal int PreviewFileSize; // 0x6C
	internal byte[] URL; // 0x70
	internal uint VotesUp; // 0x78
	internal uint VotesDown; // 0x7C
	internal float Score; // 0x80
	internal uint NumChildren; // 0x84

	// Methods

	// RVA: 0x1DA140 Offset: 0x1D9540 VA: 0x1801DA140
	internal string TitleUTF8() { }

	// RVA: 0x1DA040 Offset: 0x1D9440 VA: 0x1801DA040
	internal string DescriptionUTF8() { }

	// RVA: 0x1DA0C0 Offset: 0x1D94C0 VA: 0x1801DA0C0
	internal string TagsUTF8() { }

}

internal struct SteamItemDetails_t // TypeDefIndex: 5516
{	// Fields
	internal InventoryItemId ItemId; // 0x0
	internal InventoryDefId Definition; // 0x8
	internal ushort Quantity; // 0xC
	internal ushort Flags; // 0xE

}

internal struct SteamAPICall_t : IEquatable<SteamAPICall_t>, IComparable<SteamAPICall_t> // TypeDefIndex: 5518
{	// Fields
	public ulong Value; // 0x0

	// Methods

	// RVA: 0x4B0E80 Offset: 0x4B0280 VA: 0x1804B0E80
	public static SteamAPICall_t op_Implicit(ulong value) { }

	// RVA: 0x123050 Offset: 0x122450 VA: 0x180123050 Slot: 3
	public override string ToString() { }

	// RVA: 0x1D8A40 Offset: 0x1D7E40 VA: 0x1801D8A40 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1D89D0 Offset: 0x1D7DD0 VA: 0x1801D89D0 Slot: 0
	public override bool Equals(object p) { }

	// RVA: 0x1D89C0 Offset: 0x1D7DC0 VA: 0x1801D89C0 Slot: 4
	public bool Equals(SteamAPICall_t p) { }

	// RVA: 0x1D89B0 Offset: 0x1D7DB0 VA: 0x1801D89B0 Slot: 5
	public int CompareTo(SteamAPICall_t other) { }

}

internal struct SteamInventoryResult_t : IEquatable<SteamInventoryResult_t>, IComparable<SteamInventoryResult_t> // TypeDefIndex: 5539
{	// Fields
	public int Value; // 0x0

	// Methods

	// RVA: 0x6BFDB0 Offset: 0x6BF1B0 VA: 0x1806BFDB0
	public static SteamInventoryResult_t op_Implicit(int value) { }

	// RVA: 0x1D90B0 Offset: 0x1D84B0 VA: 0x1801D90B0 Slot: 3
	public override string ToString() { }

	// RVA: 0x14C360 Offset: 0x14B760 VA: 0x18014C360 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1D9040 Offset: 0x1D8440 VA: 0x1801D9040 Slot: 0
	public override bool Equals(object p) { }

	// RVA: 0x1D7B40 Offset: 0x1D6F40 VA: 0x1801D7B40 Slot: 4
	public bool Equals(SteamInventoryResult_t p) { }

	// RVA: 0x1D9030 Offset: 0x1D8430 VA: 0x1801D9030 Slot: 5
	public int CompareTo(SteamInventoryResult_t other) { }

}

internal struct SteamInventoryUpdateHandle_t : IEquatable<SteamInventoryUpdateHandle_t>, IComparable<SteamInventoryUpdateHandle_t> // TypeDefIndex: 5540
{	// Fields
	public ulong Value; // 0x0

	// Methods

	// RVA: 0x4B0E80 Offset: 0x4B0280 VA: 0x1804B0E80
	public static SteamInventoryUpdateHandle_t op_Implicit(ulong value) { }

	// RVA: 0x123050 Offset: 0x122450 VA: 0x180123050 Slot: 3
	public override string ToString() { }

	// RVA: 0x1D8A40 Offset: 0x1D7E40 VA: 0x1801D8A40 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1D9130 Offset: 0x1D8530 VA: 0x1801D9130 Slot: 0
	public override bool Equals(object p) { }

	// RVA: 0x1D89C0 Offset: 0x1D7DC0 VA: 0x1801D89C0 Slot: 4
	public bool Equals(SteamInventoryUpdateHandle_t p) { }

	// RVA: 0x1D89B0 Offset: 0x1D7DB0 VA: 0x1801D89B0 Slot: 5
	public int CompareTo(SteamInventoryUpdateHandle_t other) { }

}

internal struct SteamNetworkingPOPID : IEquatable<SteamNetworkingPOPID>, IComparable<SteamNetworkingPOPID> // TypeDefIndex: 5542
{	// Fields
	public uint Value; // 0x0

	// Methods

	// RVA: 0x6BFDB0 Offset: 0x6BF1B0 VA: 0x1806BFDB0
	public static SteamNetworkingPOPID op_Implicit(uint value) { }

	// RVA: 0x1D7B50 Offset: 0x1D6F50 VA: 0x1801D7B50 Slot: 3
	public override string ToString() { }

	// RVA: 0x14C360 Offset: 0x14B760 VA: 0x18014C360 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1D9AE0 Offset: 0x1D8EE0 VA: 0x1801D9AE0 Slot: 0
	public override bool Equals(object p) { }

	// RVA: 0x1D7B40 Offset: 0x1D6F40 VA: 0x1801D7B40 Slot: 4
	public bool Equals(SteamNetworkingPOPID p) { }

	// RVA: 0x1D7AC0 Offset: 0x1D6EC0 VA: 0x1801D7AC0 Slot: 5
	public int CompareTo(SteamNetworkingPOPID other) { }

}

public class SteamAchievement : IAchievement // TypeDefIndex: 5710
{
// Namespace: Rust.Platform.Steam
public class SteamAchievement : IAchievement // TypeDefIndex: 5710
	// Fields
	private Achievement _achievement; // 0x10

	// Properties
	public string Key { get; }
	public bool IsUnlocked { get; }

	// Methods

	// RVA: 0x21E53F0 Offset: 0x21E47F0 VA: 0x1821E53F0 Slot: 4
	public string get_Key() { }

	// RVA: 0x21E53E0 Offset: 0x21E47E0 VA: 0x1821E53E0 Slot: 5
	public bool get_IsUnlocked() { }

	// RVA: 0x21E53B0 Offset: 0x21E47B0 VA: 0x1821E53B0
	internal void .ctor(Achievement achievement) { }

	// RVA: 0x21E53A0 Offset: 0x21E47A0 VA: 0x1821E53A0 Slot: 6
	public void Unlock() { }

}

public class SteamAuthTicket : IAuthTicket, IDisposable // TypeDefIndex: 5711
{	// Fields
	private readonly AuthTicket _ticket; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private readonly string <Token>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private readonly byte[] <Data>k__BackingField; // 0x20

	// Properties
	public string Token { get; }
	public byte[] Data { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710 Slot: 4
	public string get_Token() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497E00 Offset: 0x497200 VA: 0x180497E00 Slot: 5
	public byte[] get_Data() { }

	// RVA: 0x21E5420 Offset: 0x21E4820 VA: 0x1821E5420
	internal void .ctor(AuthTicket ticket) { }

	// RVA: 0x21E5400 Offset: 0x21E4800 VA: 0x1821E5400 Slot: 6
	public void Dispose() { }

}

public class SteamDownloadableContent : IDownloadableContent // TypeDefIndex: 5712
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private readonly int <AppId>k__BackingField; // 0x10

	// Properties
	public int AppId { get; }
	public bool IsInstalled { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x36A480 Offset: 0x369880 VA: 0x18036A480 Slot: 4
	public int get_AppId() { }

	// RVA: 0x21E5530 Offset: 0x21E4930 VA: 0x1821E5530 Slot: 5
	public bool get_IsInstalled() { }

	// RVA: 0x497770 Offset: 0x496B70 VA: 0x180497770
	public void .ctor(int appId) { }

}

public class SteamInventory : IPlayerInventory, IDisposable // TypeDefIndex: 5713
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private readonly InventoryResult <Value>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private readonly IReadOnlyList<IPlayerItem> <Items>k__BackingField; // 0x18

	// Properties
	public InventoryResult Value { get; }
	public IReadOnlyList<IPlayerItem> Items { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4B9460 Offset: 0x4B8860 VA: 0x1804B9460
	public InventoryResult get_Value() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710 Slot: 5
	public IReadOnlyList<IPlayerItem> get_Items() { }

	// RVA: 0x21E55C0 Offset: 0x21E49C0 VA: 0x1821E55C0
	internal void .ctor(InventoryResult inventory) { }

	// RVA: 0x21E5580 Offset: 0x21E4980 VA: 0x1821E5580 Slot: 7
	public void Dispose() { }

	// RVA: 0x21E5550 Offset: 0x21E4950 VA: 0x1821E5550 Slot: 4
	public bool BelongsTo(ulong userId) { }

	// RVA: 0x21E55A0 Offset: 0x21E49A0 VA: 0x1821E55A0 Slot: 6
	public byte[] Serialize() { }

}

private sealed class SteamInventory.<>c // TypeDefIndex: 5714
{	// Fields
	public static readonly SteamInventory.<>c <>9; // 0x0
	public static Func<InventoryItem, SteamItem> <>9__6_0; // 0x8

	// Methods

	// RVA: 0x21EB7E0 Offset: 0x21EABE0 VA: 0x1821EB7E0
	private static void .cctor() { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x21EB3D0 Offset: 0x21EA7D0 VA: 0x1821EB3D0
	internal SteamItem <.ctor>b__6_0(InventoryItem i) { }

}

public class SteamItem : IPlayerItem // TypeDefIndex: 5715
{	// Fields
	public InventoryItem Value; // 0x10

	// Properties
	public int DefinitionId { get; }
	public int Quantity { get; }
	public DateTimeOffset Acquired { get; }
	public ulong WorkshopId { get; }
	public string ItemShortName { get; }

	// Methods

	// RVA: 0x21E5D60 Offset: 0x21E5160 VA: 0x1821E5D60
	public void .ctor(InventoryItem item) { }

	// RVA: 0x4BE200 Offset: 0x4BD600 VA: 0x1804BE200 Slot: 4
	public int get_DefinitionId() { }

	// RVA: 0x12F5030 Offset: 0x12F4430 VA: 0x1812F5030 Slot: 5
	public int get_Quantity() { }

	// RVA: 0x21E5DA0 Offset: 0x21E51A0 VA: 0x1821E5DA0 Slot: 6
	public DateTimeOffset get_Acquired() { }

	// RVA: 0x21E5EA0 Offset: 0x21E52A0 VA: 0x1821E5EA0 Slot: 7
	public ulong get_WorkshopId() { }

	// RVA: 0x21E5E30 Offset: 0x21E5230 VA: 0x1821E5E30 Slot: 8
	public string get_ItemShortName() { }

}

public class SteamItemDefinition : IPlayerItemDefinition, IEquatable<IPlayerItemDefinition> // TypeDefIndex: 5716
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private readonly InventoryDef <Value>k__BackingField; // 0x10

	// Properties
	public InventoryDef Value { get; }
	public int DefinitionId { get; }
	public string Name { get; }
	public string Description { get; }
	public string Type { get; }
	public string IconUrl { get; }
	public int LocalPrice { get; }
	public string LocalPriceFormatted { get; }
	public string PriceCategory { get; }
	public bool IsGenerator { get; }
	public bool IsMarketable { get; }
	public string StoreTags { get; }
	public string ItemShortName { get; }
	public ulong WorkshopId { get; }
	public ulong WorkshopDownload { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4B9460 Offset: 0x4B8860 VA: 0x1804B9460
	public InventoryDef get_Value() { }

	// RVA: 0x6C0000 Offset: 0x6BF400 VA: 0x1806C0000
	internal void .ctor(InventoryDef value) { }

	// RVA: 0x21E5AE0 Offset: 0x21E4EE0 VA: 0x1821E5AE0 Slot: 4
	public int get_DefinitionId() { }

	// RVA: 0x21E5C10 Offset: 0x21E5010 VA: 0x1821E5C10 Slot: 5
	public string get_Name() { }

	// RVA: 0x21E5B00 Offset: 0x21E4F00 VA: 0x1821E5B00 Slot: 6
	public string get_Description() { }

	// RVA: 0x21E5CA0 Offset: 0x21E50A0 VA: 0x1821E5CA0 Slot: 7
	public string get_Type() { }

	// RVA: 0x21E5B20 Offset: 0x21E4F20 VA: 0x1821E5B20 Slot: 8
	public string get_IconUrl() { }

	// RVA: 0x21E5BF0 Offset: 0x21E4FF0 VA: 0x1821E5BF0 Slot: 9
	public int get_LocalPrice() { }

	// RVA: 0x21E5BD0 Offset: 0x21E4FD0 VA: 0x1821E5BD0 Slot: 10
	public string get_LocalPriceFormatted() { }

	// RVA: 0x21E5C30 Offset: 0x21E5030 VA: 0x1821E5C30 Slot: 11
	public string get_PriceCategory() { }

	// RVA: 0x21E5B40 Offset: 0x21E4F40 VA: 0x1821E5B40 Slot: 12
	public bool get_IsGenerator() { }

	// RVA: 0x21E5B60 Offset: 0x21E4F60 VA: 0x1821E5B60 Slot: 13
	public bool get_IsMarketable() { }

	// RVA: 0x21E5C50 Offset: 0x21E5050 VA: 0x1821E5C50 Slot: 14
	public string get_StoreTags() { }

	// RVA: 0x21E5B80 Offset: 0x21E4F80 VA: 0x1821E5B80 Slot: 15
	public string get_ItemShortName() { }

	// RVA: 0x21E5D10 Offset: 0x21E5110 VA: 0x1821E5D10 Slot: 16
	public ulong get_WorkshopId() { }

	// RVA: 0x21E5CC0 Offset: 0x21E50C0 VA: 0x1821E5CC0 Slot: 17
	public ulong get_WorkshopDownload() { }

	// RVA: 0x21E58F0 Offset: 0x21E4CF0 VA: 0x1821E58F0 Slot: 18
	public IEnumerable<PlayerItemRecipe> GetRecipesContainingThis() { }

	// RVA: 0x21E5980 Offset: 0x21E4D80 VA: 0x1821E5980
	private static PlayerItemRecipe SteamToPlatformRecipe(InventoryRecipe recipe) { }

	// RVA: 0x158B410 Offset: 0x158A810 VA: 0x18158B410 Slot: 19
	public bool Equals(IPlayerItemDefinition other) { }

	// RVA: 0x21E5730 Offset: 0x21E4B30 VA: 0x1821E5730 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x21E58A0 Offset: 0x21E4CA0 VA: 0x1821E58A0 Slot: 2
	public override int GetHashCode() { }

}

private sealed class SteamItemDefinition.<>c // TypeDefIndex: 5717
{	// Fields
	public static readonly SteamItemDefinition.<>c <>9; // 0x0
	public static Func<InventoryRecipe.Ingredient, PlayerItemRecipe.Ingredient> <>9__33_0; // 0x8

	// Methods

	// RVA: 0x21EB8A0 Offset: 0x21EACA0 VA: 0x1821EB8A0
	private static void .cctor() { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x21EB390 Offset: 0x21EA790 VA: 0x1821EB390
	internal PlayerItemRecipe.Ingredient <SteamToPlatformRecipe>b__33_0(InventoryRecipe.Ingredient i) { }

}

public class SteamPlatform : IPlatformService // TypeDefIndex: 5718
{	// Fields
	private readonly AvatarCache _avatars; // 0x10
	private readonly Dictionary<int, SteamDownloadableContent> _dlcCache; // 0x18
	private readonly Dictionary<ulong, SteamWorkshopContent> _workshopCache; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private IReadOnlyList<IPlayerItemDefinition> <ItemDefinitions>k__BackingField; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private IReadOnlyList<IPlayerItem> <Items>k__BackingField; // 0x30
	private bool confiscatedLoop; // 0x38
	private readonly Dictionary<ulong, SteamPlayer> _playerCache; // 0x40
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private ulong <UserId>k__BackingField; // 0x48
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private string <UserName>k__BackingField; // 0x50
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private string <Country>k__BackingField; // 0x58
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private string <Language>k__BackingField; // 0x60
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private string <Version>k__BackingField; // 0x68
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private string <Branch>k__BackingField; // 0x70
	private readonly Dictionary<string, SteamAchievement> _achievements; // 0x78
	private IPlatformHooks _hooks; // 0x80
	private bool _initialized; // 0x88

	// Properties
	public IReadOnlyList<IPlayerItemDefinition> ItemDefinitions { get; set; }
	public IReadOnlyList<IPlayerItem> Items { get; set; }
	public ulong UserId { get; set; }
	public string UserName { get; set; }
	public string Country { get; set; }
	public string Language { get; set; }
	public string Version { get; set; }
	public string Branch { get; set; }
	public IEnumerable<IPlayerInfo> Friends { get; }
	public IReadOnlyList<ServerInfo> FavoriteServers { get; }
	public uint OptimalSampleRate { get; }
	public bool VoiceRecord { get; set; }
	public bool HasVoiceData { get; }
	public bool IsValid { get; }

	// Methods

	[AsyncStateMachineAttribute] // RVA: 0xCAE60 Offset: 0xCA260 VA: 0x1800CAE60
	// RVA: 0x21E7C80 Offset: 0x21E7080 VA: 0x1821E7C80
	private static void LoadAvatarFromSteamAsync(ulong userId, Texture2D texture) { }

	// RVA: 0x21E6BC0 Offset: 0x21E5FC0 VA: 0x1821E6BC0 Slot: 19
	public Texture2D GetAvatarTexture(ulong userId) { }

	// RVA: 0x21E6C30 Offset: 0x21E6030 VA: 0x1821E6C30 Slot: 45
	public IDownloadableContent GetDownloadableContent(int appId) { }

	// RVA: 0x21E7300 Offset: 0x21E6700 VA: 0x1821E7300 Slot: 46
	public IWorkshopContent GetWorkshopContent(ulong workshopId) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x7CE230 Offset: 0x7CD630 VA: 0x1807CE230 Slot: 36
	public IReadOnlyList<IPlayerItemDefinition> get_ItemDefinitions() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x7CE240 Offset: 0x7CD640 VA: 0x1807CE240
	private void set_ItemDefinitions(IReadOnlyList<IPlayerItemDefinition> value) { }

	// RVA: 0x3634F0 Offset: 0x3628F0 VA: 0x1803634F0 Slot: 37
	public void RefreshItemDefinitions() { }

	// RVA: 0x21E6D70 Offset: 0x21E6170 VA: 0x1821E6D70 Slot: 38
	public IPlayerItemDefinition GetItemDefinition(int definitionId) { }

	// RVA: 0x21E7D60 Offset: 0x21E7160 VA: 0x1821E7D60
	private void OnDefinitionsUpdated() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4A2EE0 Offset: 0x4A22E0 VA: 0x1804A2EE0 Slot: 39
	public IReadOnlyList<IPlayerItem> get_Items() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4A2F10 Offset: 0x4A2310 VA: 0x1804A2F10
	private void set_Items(IReadOnlyList<IPlayerItem> value) { }

	// RVA: 0x21E80B0 Offset: 0x21E74B0 VA: 0x1821E80B0 Slot: 40
	public void RefreshItems() { }

	[AsyncStateMachineAttribute] // RVA: 0xCB250 Offset: 0xCA650 VA: 0x1800CB250
	// RVA: 0x21E7FE0 Offset: 0x21E73E0 VA: 0x1821E7FE0 Slot: 41
	public Task<IPlayerInventory> RefreshAndGetItems() { }

	[AsyncStateMachineAttribute] // RVA: 0xCB460 Offset: 0xCA860 VA: 0x1800CB460
	// RVA: 0x21E6330 Offset: 0x21E5730 VA: 0x1821E6330 Slot: 42
	public Task<IPlayerInventory> CraftItem(IEnumerable<IPlayerItem> inputs, IPlayerItemDefinition output) { }

	[AsyncStateMachineAttribute] // RVA: 0xCB770 Offset: 0xCAB70 VA: 0x1800CB770
	// RVA: 0x21E6FA0 Offset: 0x21E63A0 VA: 0x1821E6FA0 Slot: 43
	public Task<List<IPlayerItemDefinition>> GetItemDefinitionsWithPrices() { }

	// RVA: 0x21E68D0 Offset: 0x21E5CD0 VA: 0x1821E68D0 Slot: 44
	public string FormatPrice(int price) { }

	// RVA: 0x21E7ED0 Offset: 0x21E72D0 VA: 0x1821E7ED0
	private void OnInventoryUpdated(InventoryResult result) { }

	// RVA: 0x21E6130 Offset: 0x21E5530 VA: 0x1821E6130
	private void ConfiscatedItems() { }

	[AsyncStateMachineAttribute] // RVA: 0xCB9F0 Offset: 0xCADF0 VA: 0x1800CB9F0
	// RVA: 0x21E7BB0 Offset: 0x21E6FB0 VA: 0x1821E7BB0
	private Task InventoryDropAsync() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x5DCCA0 Offset: 0x5DC0A0 VA: 0x1805DCCA0 Slot: 8
	public ulong get_UserId() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xEE12D0 Offset: 0xEE06D0 VA: 0x180EE12D0
	private void set_UserId(ulong value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4CC350 Offset: 0x4CB750 VA: 0x1804CC350 Slot: 9
	public string get_UserName() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4CC370 Offset: 0x4CB770 VA: 0x1804CC370
	private void set_UserName(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4CC340 Offset: 0x4CB740 VA: 0x1804CC340 Slot: 10
	public string get_Country() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4CC360 Offset: 0x4CB760 VA: 0x1804CC360
	private void set_Country(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x54FB60 Offset: 0x54EF60 VA: 0x18054FB60 Slot: 11
	public string get_Language() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x54FB70 Offset: 0x54EF70 VA: 0x18054FB70
	private void set_Language(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x5334F0 Offset: 0x5328F0 VA: 0x1805334F0 Slot: 12
	public string get_Version() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x5336F0 Offset: 0x532AF0 VA: 0x1805336F0
	private void set_Version(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x58DC30 Offset: 0x58D030 VA: 0x18058DC30 Slot: 13
	public string get_Branch() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x58DCC0 Offset: 0x58D0C0 VA: 0x18058DCC0
	private void set_Branch(string value) { }

	// RVA: 0x21E6B30 Offset: 0x21E5F30 VA: 0x1821E6B30 Slot: 14
	public IAuthTicket GetAuthSessionTicket() { }

	[AsyncStateMachineAttribute] // RVA: 0xCC840 Offset: 0xCBC40 VA: 0x1800CC840
	// RVA: 0x21E6A60 Offset: 0x21E5E60 VA: 0x1821E6A60 Slot: 15
	public Task<IAuthTicket> GetAuthSessionTicketAsync() { }

	// RVA: 0x21E88C0 Offset: 0x21E7CC0 VA: 0x1821E88C0 Slot: 16
	public IEnumerable<IPlayerInfo> get_Friends() { }

	// RVA: 0x21E7270 Offset: 0x21E6670 VA: 0x1821E7270 Slot: 17
	public IPlayerInfo GetPlayerInformation(ulong userId) { }

	[AsyncStateMachineAttribute] // RVA: 0xCCA50 Offset: 0xCBE50 VA: 0x1800CCA50
	// RVA: 0x21E7150 Offset: 0x21E6550 VA: 0x1821E7150 Slot: 18
	public Task<IPlayerInfo> GetPlayerInformationAsync(ulong userId) { }

	// RVA: 0x21E7070 Offset: 0x21E6470 VA: 0x1821E7070
	private SteamPlayer GetOrAddPlayer(ulong userId) { }

	// RVA: 0x21E6760 Offset: 0x21E5B60 VA: 0x1821E6760 Slot: 27
	public string FilterChat(ulong userId, string message) { }

	// RVA: 0x21E6850 Offset: 0x21E5C50 VA: 0x1821E6850 Slot: 28
	public string FilterName(ulong userId, string message) { }

	// RVA: 0x21E67E0 Offset: 0x21E5BE0 VA: 0x1821E67E0 Slot: 29
	public string FilterGeneric(string message) { }

	// RVA: 0x21E6120 Offset: 0x21E5520 VA: 0x1821E6120 Slot: 47
	public void ClearRichPresence() { }

	// RVA: 0x21E72F0 Offset: 0x21E66F0 VA: 0x1821E72F0 Slot: 48
	public string GetRichPresence(string key) { }

	// RVA: 0x21E8340 Offset: 0x21E7740 VA: 0x1821E8340 Slot: 49
	public void SetRichPresence(string key, string value) { }

	// RVA: 0x21E6450 Offset: 0x21E5850 VA: 0x1821E6450 Slot: 20
	public IServerQuery CreateServerQuery(ServerQuerySet querySet) { }

	// RVA: 0x21E65B0 Offset: 0x21E59B0 VA: 0x1821E65B0 Slot: 21
	public IServerQuery CreateServerQuery(IEnumerable<string> endpoints) { }

	// RVA: 0x21E6020 Offset: 0x21E5420 VA: 0x1821E6020 Slot: 22
	public void AddServerToHistory(ServerInfo server) { }

	// RVA: 0x21E8200 Offset: 0x21E7600 VA: 0x1821E8200 Slot: 23
	public void RemoveServerFromHistory(ServerInfo server) { }

	// RVA: 0x21E8830 Offset: 0x21E7C30 VA: 0x1821E8830 Slot: 24
	public IReadOnlyList<ServerInfo> get_FavoriteServers() { }

	// RVA: 0x21E5F20 Offset: 0x21E5320 VA: 0x1821E5F20 Slot: 25
	public void AddServerToFavorites(ServerInfo server) { }

	// RVA: 0x21E8100 Offset: 0x21E7500 VA: 0x1821E8100 Slot: 26
	public void RemoveServerFromFavorites(ServerInfo server) { }

	// RVA: 0x21E8500 Offset: 0x21E7900 VA: 0x1821E8500
	internal static ServerInfo ToPlatformServer(ServerInfo info) { }

	// RVA: 0x21E85B0 Offset: 0x21E79B0 VA: 0x1821E85B0
	internal static ServerInfo ToSteamServer(ServerInfo server) { }

	// RVA: 0x21E6970 Offset: 0x21E5D70 VA: 0x1821E6970 Slot: 50
	public IAchievement GetAchievement(string key) { }

	// RVA: 0x21E8300 Offset: 0x21E7700 VA: 0x1821E8300 Slot: 51
	public void RequestCurrentStats() { }

	// RVA: 0x21E6D30 Offset: 0x21E6130 VA: 0x1821E6D30 Slot: 52
	public long GetGlobalStatInt(string key) { }

	// RVA: 0x21E72D0 Offset: 0x21E66D0 VA: 0x1821E72D0 Slot: 53
	public long GetPlayerStatInt(string key) { }

	// RVA: 0x21E8330 Offset: 0x21E7730 VA: 0x1821E8330 Slot: 54
	public void SetPlayerStatInt(string key, long value) { }

	// RVA: 0x21E6CF0 Offset: 0x21E60F0 VA: 0x1821E6CF0 Slot: 55
	public double GetGlobalStatFloat(string key) { }

	// RVA: 0x21E72B0 Offset: 0x21E66B0 VA: 0x1821E72B0 Slot: 56
	public double GetPlayerStatFloat(string key) { }

	// RVA: 0x21E8310 Offset: 0x21E7710 VA: 0x1821E8310 Slot: 57
	public void SetPlayerStatFloat(string key, double value) { }

	// RVA: 0x21E8A30 Offset: 0x21E7E30 VA: 0x1821E8A30 Slot: 30
	public uint get_OptimalSampleRate() { }

	// RVA: 0x21E8A80 Offset: 0x21E7E80 VA: 0x1821E8A80 Slot: 31
	public bool get_VoiceRecord() { }

	// RVA: 0x21E8B20 Offset: 0x21E7F20 VA: 0x1821E8B20 Slot: 32
	public void set_VoiceRecord(bool value) { }

	// RVA: 0x21E8940 Offset: 0x21E7D40 VA: 0x1821E8940 Slot: 33
	public bool get_HasVoiceData() { }

	// RVA: 0x21E6BE0 Offset: 0x21E5FE0 VA: 0x1821E6BE0 Slot: 34
	public byte[] GetCompressedVoiceData() { }

	// RVA: 0x21E66F0 Offset: 0x21E5AF0 VA: 0x1821E66F0 Slot: 35
	public int DecompressVoiceData(byte[] data, MemoryStream outputStream) { }

	// RVA: 0x21E8990 Offset: 0x21E7D90 VA: 0x1821E8990 Slot: 7
	public bool get_IsValid() { }

	// RVA: 0x21E7540 Offset: 0x21E6940 VA: 0x1821E7540 Slot: 4
	public bool Initialize(IPlatformHooks hooks) { }

	// RVA: 0x21E8360 Offset: 0x21E7760 VA: 0x1821E8360 Slot: 5
	public void Shutdown() { }

	// RVA: 0x21E8620 Offset: 0x21E7A20 VA: 0x1821E8620 Slot: 6
	public void Update() { }

	// RVA: 0x21E80C0 Offset: 0x21E74C0 VA: 0x1821E80C0
	private static AuthResponse RemapAuthResponse(AuthResponse response) { }

	// RVA: 0x21E6630 Offset: 0x21E5A30 VA: 0x1821E6630
	private static void DebugPrintSteamCallback(CallbackType type, string content, bool isServer) { }

	// RVA: 0x21E86E0 Offset: 0x21E7AE0 VA: 0x1821E86E0
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x21E8610 Offset: 0x21E7A10 VA: 0x1821E8610
	private SteamPlayer <get_Friends>b__55_0(Friend f) { }

}

private struct SteamPlatform.<LoadAvatarFromSteamAsync>d__1 : IAsyncStateMachine // TypeDefIndex: 5719
{	// Fields
	public int <>1__state; // 0x0
	public AsyncVoidMethodBuilder <>t__builder; // 0x8
	public ulong userId; // 0x28
	public Texture2D texture; // 0x30
	private TaskAwaiter<Nullable<Image>> <>u__1; // 0x38

	// Methods

	// RVA: 0x237030 Offset: 0x236430 VA: 0x180237030 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xF1420 Offset: 0xF0820 VA: 0x1800F1420 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

private sealed class SteamPlatform.<>c // TypeDefIndex: 5720
{	// Fields
	public static readonly SteamPlatform.<>c <>9; // 0x0
	public static Func<InventoryDef, SteamItemDefinition> <>9__13_0; // 0x8
	public static Func<SteamItem, InventoryItem> <>9__20_0; // 0x10
	public static Func<InventoryDef, IPlayerItemDefinition> <>9__21_0; // 0x18
	public static Action<Exception> <>9__97_0; // 0x20

	// Methods

	// RVA: 0x21EB840 Offset: 0x21EAC40 VA: 0x1821EB840
	private static void .cctor() { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x21EB330 Offset: 0x21EA730 VA: 0x1821EB330
	internal SteamItemDefinition <OnDefinitionsUpdated>b__13_0(InventoryDef d) { }

	// RVA: 0x21EB240 Offset: 0x21EA640 VA: 0x1821EB240
	internal InventoryItem <CraftItem>b__20_0(SteamItem i) { }

	// RVA: 0x21EB270 Offset: 0x21EA670 VA: 0x1821EB270
	internal IPlayerItemDefinition <GetItemDefinitionsWithPrices>b__21_0(InventoryDef d) { }

	// RVA: 0x21EB2D0 Offset: 0x21EA6D0 VA: 0x1821EB2D0
	internal void <Initialize>b__97_0(Exception e) { }

}

private struct SteamPlatform.<RefreshAndGetItems>d__19 : IAsyncStateMachine // TypeDefIndex: 5721
{	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder<IPlayerInventory> <>t__builder; // 0x8
	private TaskAwaiter<Nullable<InventoryResult>> <>u__1; // 0x20

	// Methods

	// RVA: 0x237040 Offset: 0x236440 VA: 0x180237040 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x237050 Offset: 0x236450 VA: 0x180237050 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

private struct SteamPlatform.<CraftItem>d__20 : IAsyncStateMachine // TypeDefIndex: 5722
{	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder<IPlayerInventory> <>t__builder; // 0x8
	public IEnumerable<IPlayerItem> inputs; // 0x20
	public IPlayerItemDefinition output; // 0x28
	private TaskAwaiter<Nullable<InventoryResult>> <>u__1; // 0x30

	// Methods

	// RVA: 0x236EA0 Offset: 0x2362A0 VA: 0x180236EA0 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x236EB0 Offset: 0x2362B0 VA: 0x180236EB0 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

private struct SteamPlatform.<GetItemDefinitionsWithPrices>d__21 : IAsyncStateMachine // TypeDefIndex: 5723
{	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder<List<IPlayerItemDefinition>> <>t__builder; // 0x8
	private TaskAwaiter<InventoryDef[]> <>u__1; // 0x20

	// Methods

	// RVA: 0x236F60 Offset: 0x236360 VA: 0x180236F60 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x236F70 Offset: 0x236370 VA: 0x180236F70 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

private struct SteamPlatform.<InventoryDropAsync>d__26 : IAsyncStateMachine // TypeDefIndex: 5724
{	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder <>t__builder; // 0x8
	private TaskAwaiter <>u__1; // 0x20
	private TaskAwaiter<Nullable<InventoryResult>> <>u__2; // 0x28

	// Methods

	// RVA: 0x237020 Offset: 0x236420 VA: 0x180237020 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xF2060 Offset: 0xF1460 VA: 0x1800F2060 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

private struct SteamPlatform.<GetAuthSessionTicketAsync>d__53 : IAsyncStateMachine // TypeDefIndex: 5725
{	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder<IAuthTicket> <>t__builder; // 0x8
	private TaskAwaiter<AuthTicket> <>u__1; // 0x20

	// Methods

	// RVA: 0x236F00 Offset: 0x236300 VA: 0x180236F00 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x236F10 Offset: 0x236310 VA: 0x180236F10 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

private struct SteamPlatform.<GetPlayerInformationAsync>d__57 : IAsyncStateMachine // TypeDefIndex: 5726
{	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder<IPlayerInfo> <>t__builder; // 0x8
	public SteamPlatform <>4__this; // 0x20
	public ulong userId; // 0x28
	private SteamPlayer <player>5__2; // 0x30
	private TaskAwaiter <>u__1; // 0x38

	// Methods

	// RVA: 0x236FC0 Offset: 0x2363C0 VA: 0x180236FC0 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x236FD0 Offset: 0x2363D0 VA: 0x180236FD0 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

public class SteamPlayer : IPlayerInfo // TypeDefIndex: 5727
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private readonly Friend <Value>k__BackingField; // 0x10

	// Properties
	public Friend Value { get; }
	public ulong UserId { get; }
	public string UserName { get; }
	public bool IsOnline { get; }
	public bool IsMe { get; }
	public bool IsFriend { get; }
	public bool IsPlayingThisGame { get; }
	public string ServerEndpoint { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4B9460 Offset: 0x4B8860 VA: 0x1804B9460
	public Friend get_Value() { }

	// RVA: 0x4B9460 Offset: 0x4B8860 VA: 0x1804B9460 Slot: 4
	public ulong get_UserId() { }

	// RVA: 0x21E8D80 Offset: 0x21E8180 VA: 0x1821E8D80 Slot: 5
	public string get_UserName() { }

	// RVA: 0x21E8BC0 Offset: 0x21E7FC0 VA: 0x1821E8BC0 Slot: 6
	public bool get_IsOnline() { }

	// RVA: 0x21E8BA0 Offset: 0x21E7FA0 VA: 0x1821E8BA0 Slot: 7
	public bool get_IsMe() { }

	// RVA: 0x21E8B80 Offset: 0x21E7F80 VA: 0x1821E8B80 Slot: 8
	public bool get_IsFriend() { }

	// RVA: 0x21E8BE0 Offset: 0x21E7FE0 VA: 0x1821E8BE0 Slot: 9
	public bool get_IsPlayingThisGame() { }

	// RVA: 0x21E8C00 Offset: 0x21E8000 VA: 0x1821E8C00 Slot: 10
	public string get_ServerEndpoint() { }

	// RVA: 0x139A570 Offset: 0x1399970 VA: 0x18139A570
	public void .ctor(Friend value) { }

}

public class SteamServerQuery : IServerQuery, IDisposable // TypeDefIndex: 5728
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private readonly ServerQuerySet <QuerySet>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Base <Query>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private readonly IReadOnlyList<ServerInfo> <Servers>k__BackingField; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Action<ServerInfo> OnServerFound; // 0x28

	// Properties
	public ServerQuerySet QuerySet { get; }
	public Base Query { get; set; }
	public IReadOnlyList<ServerInfo> Servers { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x36A480 Offset: 0x369880 VA: 0x18036A480 Slot: 4
	public ServerQuerySet get_QuerySet() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710
	public Base get_Query() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4D0180 Offset: 0x4CF580 VA: 0x1804D0180
	private void set_Query(Base value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497E00 Offset: 0x497200 VA: 0x180497E00 Slot: 5
	public IReadOnlyList<ServerInfo> get_Servers() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x21E9020 Offset: 0x21E8420 VA: 0x1821E9020 Slot: 6
	public void add_OnServerFound(Action<ServerInfo> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x21E90C0 Offset: 0x21E84C0 VA: 0x1821E90C0 Slot: 7
	public void remove_OnServerFound(Action<ServerInfo> value) { }

	// RVA: 0x21E8EC0 Offset: 0x21E82C0 VA: 0x1821E8EC0
	public void .ctor(ServerQuerySet set, Base query) { }

	// RVA: 0x21E8DC0 Offset: 0x21E81C0 VA: 0x1821E8DC0 Slot: 10
	public void Dispose() { }

	// RVA: 0x21E8DA0 Offset: 0x21E81A0 VA: 0x1821E8DA0 Slot: 8
	public void AddFilter(string key, string value) { }

	// RVA: 0x21E8E90 Offset: 0x21E8290 VA: 0x1821E8E90 Slot: 9
	public Task RunQueryAsync(double timeoutInSeconds) { }

}

private sealed class SteamServerQuery.<>c__DisplayClass13_0 // TypeDefIndex: 5729
{	// Fields
	public List<ServerInfo> serverList; // 0x10
	public SteamServerQuery <>4__this; // 0x18

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x21EB440 Offset: 0x21EA840 VA: 0x1821EB440
	internal void <.ctor>b__0() { }

}

public static class SteamUtil // TypeDefIndex: 5730
{	// Fields
	private static string _betaNameFull; // 0x0
	private static string _betaNameType; // 0x8

	// Properties
	public static string betaName { get; }
	public static string betaBranch { get; }

	// Methods

	// RVA: 0x21E95F0 Offset: 0x21E89F0 VA: 0x1821E95F0
	public static string get_betaName() { }

	// RVA: 0x21E95A0 Offset: 0x21E89A0 VA: 0x1821E95A0
	public static string get_betaBranch() { }

	// RVA: 0x21E9160 Offset: 0x21E8560 VA: 0x1821E9160
	private static string GetBetaName(bool full) { }

	// RVA: 0x21E9530 Offset: 0x21E8930 VA: 0x1821E9530
	private static void .cctor() { }

}

public class SteamWorkshopContent : IWorkshopContent // TypeDefIndex: 5731
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private readonly Item <Value>k__BackingField; // 0x10

	// Properties
	public Item Value { get; }
	public ulong WorkshopId { get; }
	public string Title { get; }
	public string Description { get; }
	public IEnumerable<string> Tags { get; }
	public string Url { get; }
	public string PreviewImageUrl { get; }
	public ulong OwnerId { get; }
	public IPlayerInfo Owner { get; }
	public bool IsInstalled { get; }
	public bool IsDownloadPending { get; }
	public bool IsDownloading { get; }
	public string Directory { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x21E9F70 Offset: 0x21E9370 VA: 0x1821E9F70
	public Item get_Value() { }

	// RVA: 0x21EA000 Offset: 0x21E9400 VA: 0x1821EA000 Slot: 4
	public ulong get_WorkshopId() { }

	// RVA: 0x21E9E10 Offset: 0x21E9210 VA: 0x1821E9E10 Slot: 5
	public string get_Title() { }

	// RVA: 0x21E97A0 Offset: 0x21E8BA0 VA: 0x1821E97A0 Slot: 6
	public string get_Description() { }

	// RVA: 0x21E9D60 Offset: 0x21E9160 VA: 0x1821E9D60 Slot: 7
	public IEnumerable<string> get_Tags() { }

	// RVA: 0x21E9EC0 Offset: 0x21E92C0 VA: 0x1821E9EC0 Slot: 8
	public string get_Url() { }

	// RVA: 0x21E9CB0 Offset: 0x21E90B0 VA: 0x1821E9CB0 Slot: 9
	public string get_PreviewImageUrl() { }

	// RVA: 0x21E9B10 Offset: 0x21E8F10 VA: 0x1821E9B10 Slot: 10
	public ulong get_OwnerId() { }

	// RVA: 0x21E9BC0 Offset: 0x21E8FC0 VA: 0x1821E9BC0 Slot: 11
	public IPlayerInfo get_Owner() { }

	// RVA: 0x21E9A60 Offset: 0x21E8E60 VA: 0x1821E9A60 Slot: 12
	public bool get_IsInstalled() { }

	// RVA: 0x21E9900 Offset: 0x21E8D00 VA: 0x1821E9900 Slot: 13
	public bool get_IsDownloadPending() { }

	// RVA: 0x21E99B0 Offset: 0x21E8DB0 VA: 0x1821E99B0 Slot: 14
	public bool get_IsDownloading() { }

	// RVA: 0x21E9850 Offset: 0x21E8C50 VA: 0x1821E9850 Slot: 15
	public string get_Directory() { }

	// RVA: 0x21E96F0 Offset: 0x21E8AF0 VA: 0x1821E96F0
	public void .ctor(Item item) { }

	// RVA: 0x21E9640 Offset: 0x21E8A40 VA: 0x1821E9640 Slot: 16
	public bool Download() { }

}

public static class SteamNetworking // TypeDefIndex: 7362
{
// Namespace: Facepunch.Network
[ConsoleSystem.Factory] // RVA: 0x80B80 Offset: 0x7FF80 VA: 0x180080B80
public static class SteamNetworking // TypeDefIndex: 7362
	// Properties
	[ClientVar] // RVA: 0x9B370 Offset: 0x9A770 VA: 0x18009B370
	[ServerVar] // RVA: 0x9B370 Offset: 0x9A770 VA: 0x18009B370
	public static int steamnetdebug { get; set; }
	[ClientVar] // RVA: 0x93490 Offset: 0x92890 VA: 0x180093490
	[ServerVar] // RVA: 0x93490 Offset: 0x92890 VA: 0x180093490
	public static int steamnetdebug_ackrtt { get; set; }
	[ClientVar] // RVA: 0x93490 Offset: 0x92890 VA: 0x180093490
	[ServerVar] // RVA: 0x93490 Offset: 0x92890 VA: 0x180093490
	public static int steamnetdebug_packetdecode { get; set; }
	[ClientVar] // RVA: 0x93490 Offset: 0x92890 VA: 0x180093490
	[ServerVar] // RVA: 0x93490 Offset: 0x92890 VA: 0x180093490
	public static int steamnetdebug_message { get; set; }
	[ClientVar] // RVA: 0x93490 Offset: 0x92890 VA: 0x180093490
	[ServerVar] // RVA: 0x93490 Offset: 0x92890 VA: 0x180093490
	public static int steamnetdebug_packetgaps { get; set; }
	[ClientVar] // RVA: 0x93490 Offset: 0x92890 VA: 0x180093490
	[ServerVar] // RVA: 0x93490 Offset: 0x92890 VA: 0x180093490
	public static int steamnetdebug_p2prendezvous { get; set; }
	[ClientVar] // RVA: 0x93490 Offset: 0x92890 VA: 0x180093490
	[ServerVar] // RVA: 0x93490 Offset: 0x92890 VA: 0x180093490
	public static int steamnetdebug_sdrrelaypings { get; set; }
	[ClientVar] // RVA: 0x93490 Offset: 0x92890 VA: 0x180093490
	[ServerVar] // RVA: 0x93490 Offset: 0x92890 VA: 0x180093490
	public static int steamconnectiontimeout { get; set; }

	// Methods

	// RVA: 0x22D4CC0 Offset: 0x22D40C0 VA: 0x1822D4CC0
	public static SendType ToSteamSendType(SendMethod method, Priority priority) { }

	// RVA: 0x22D4CA0 Offset: 0x22D40A0 VA: 0x1822D4CA0
	public static ushort ToSteamLaneIndexServer(SendMethod method, Priority priority, sbyte channel) { }

	// RVA: 0x22D4C90 Offset: 0x22D4090 VA: 0x1822D4C90
	public static ushort ToSteamLaneIndexClient(SendMethod method, Priority priority, sbyte channel) { }

	// RVA: 0x22D4B30 Offset: 0x22D3F30 VA: 0x1822D4B30
	public static void InitRelayNetworkAccess() { }

	// RVA: 0x22D4B80 Offset: 0x22D3F80 VA: 0x1822D4B80
	public static void SetDebugFunction() { }

	// RVA: 0x22D4C00 Offset: 0x22D4000 VA: 0x1822D4C00
	private static void SteamNetworkingUtils_OnDebugOutput(NetDebugOutput type, string str) { }

	[ClientVar] // RVA: 0x93490 Offset: 0x92890 VA: 0x180093490
	[ServerVar] // RVA: 0x93490 Offset: 0x92890 VA: 0x180093490
	// RVA: 0x22D5250 Offset: 0x22D4650 VA: 0x1822D5250
	public static string steamstatus() { }

	[ClientVar] // RVA: 0x93490 Offset: 0x92890 VA: 0x180093490
	[ServerVar] // RVA: 0x93490 Offset: 0x92890 VA: 0x180093490
	// RVA: 0x22D4B30 Offset: 0x22D3F30 VA: 0x1822D4B30
	public static void steamrelayinit() { }

	// RVA: 0x22D4DA0 Offset: 0x22D41A0 VA: 0x1822D4DA0
	public static int get_steamnetdebug() { }

	// RVA: 0x22D5070 Offset: 0x22D4470 VA: 0x1822D5070
	public static void set_steamnetdebug(int value) { }

	// RVA: 0x22D4D50 Offset: 0x22D4150 VA: 0x1822D4D50
	public static int get_steamnetdebug_ackrtt() { }

	// RVA: 0x22D5020 Offset: 0x22D4420 VA: 0x1822D5020
	public static void set_steamnetdebug_ackrtt(int value) { }

	// RVA: 0x22D4EE0 Offset: 0x22D42E0 VA: 0x1822D4EE0
	public static int get_steamnetdebug_packetdecode() { }

	// RVA: 0x22D5160 Offset: 0x22D4560 VA: 0x1822D5160
	public static void set_steamnetdebug_packetdecode(int value) { }

	// RVA: 0x22D4E40 Offset: 0x22D4240 VA: 0x1822D4E40
	public static int get_steamnetdebug_message() { }

	// RVA: 0x22D50C0 Offset: 0x22D44C0 VA: 0x1822D50C0
	public static void set_steamnetdebug_message(int value) { }

	// RVA: 0x22D4F30 Offset: 0x22D4330 VA: 0x1822D4F30
	public static int get_steamnetdebug_packetgaps() { }

	// RVA: 0x22D51B0 Offset: 0x22D45B0 VA: 0x1822D51B0
	public static void set_steamnetdebug_packetgaps(int value) { }

	// RVA: 0x22D4E90 Offset: 0x22D4290 VA: 0x1822D4E90
	public static int get_steamnetdebug_p2prendezvous() { }

	// RVA: 0x22D5110 Offset: 0x22D4510 VA: 0x1822D5110
	public static void set_steamnetdebug_p2prendezvous(int value) { }

	// RVA: 0x22D4F80 Offset: 0x22D4380 VA: 0x1822D4F80
	public static int get_steamnetdebug_sdrrelaypings() { }

	// RVA: 0x22D5200 Offset: 0x22D4600 VA: 0x1822D5200
	public static void set_steamnetdebug_sdrrelaypings(int value) { }

	// RVA: 0x22D4D00 Offset: 0x22D4100 VA: 0x1822D4D00
	public static int get_steamconnectiontimeout() { }

	// RVA: 0x22D4FD0 Offset: 0x22D43D0 VA: 0x1822D4FD0
	public static void set_steamconnectiontimeout(int value) { }

}

public class SteamNetworking.Client : Client, IConnectionManager // TypeDefIndex: 7363
{	// Fields
	private ConnectionManager manager; // 0x70
	private const int bufferSize = 32;

	// Methods

	// RVA: 0x22C7350 Offset: 0x22C6750 VA: 0x1822C7350 Slot: 11
	public override bool IsConnected() { }

	// RVA: 0x22D2890 Offset: 0x22D1C90 VA: 0x1822D2890 Slot: 8
	public override bool Connect(string strURL, int port) { }

	// RVA: 0x22D29F0 Offset: 0x22D1DF0 VA: 0x1822D29F0 Slot: 9
	public override void Cycle() { }

	// RVA: 0x22D2B60 Offset: 0x22D1F60 VA: 0x1822D2B60 Slot: 10
	public override void Disconnect(string reason, bool sendReasonToServer) { }

	// RVA: 0x22D2F20 Offset: 0x22D2320 VA: 0x1822D2F20 Slot: 4
	public override void Send(SendInfo sendinfo, MemoryStream data) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 13
	private void Steamworks.IConnectionManager.OnConnecting(ConnectionInfo info) { }

	// RVA: 0x22D3030 Offset: 0x22D2430 VA: 0x1822D3030 Slot: 14
	private void Steamworks.IConnectionManager.OnConnected(ConnectionInfo info) { }

	// RVA: 0x22D3060 Offset: 0x22D2460 VA: 0x1822D3060 Slot: 15
	private void Steamworks.IConnectionManager.OnDisconnected(ConnectionInfo info) { }

	// RVA: 0x22D30E0 Offset: 0x22D24E0 VA: 0x1822D30E0 Slot: 16
	private void Steamworks.IConnectionManager.OnMessage(IntPtr data, int datasize, long messageNum, long recvTime, int channel) { }

	// RVA: 0x22D2CE0 Offset: 0x22D20E0 VA: 0x1822D2CE0 Slot: 5
	public override string GetDebug(Connection connection) { }

	// RVA: 0x22D2D60 Offset: 0x22D2160 VA: 0x1822D2D60 Slot: 12
	public override int GetLastPing() { }

	// RVA: 0x22D2DC0 Offset: 0x22D21C0 VA: 0x1822D2DC0 Slot: 6
	public override ulong GetStat(Connection connection, BaseNetwork.StatTypeLong type) { }

	// RVA: 0x22D36E0 Offset: 0x22D2AE0 VA: 0x1822D36E0
	public void .ctor() { }

}

public class SteamNetworking.Server : Server, ISocketManager // TypeDefIndex: 7364
{	// Fields
	private SocketManager manager; // 0x68
	private bool relay; // 0x70
	private const int bufferSize = 32;
	private int[] lanePriorities; // 0x78
	private ushort[] laneWeights; // 0x80

	// Properties
	public override string ProtocolId { get; }

	// Methods

	// RVA: 0x22D4B00 Offset: 0x22D3F00 VA: 0x1822D4B00 Slot: 8
	public override string get_ProtocolId() { }

	// RVA: 0x22D49E0 Offset: 0x22D3DE0 VA: 0x1822D49E0
	public void .ctor(bool enableSteamDatagramRelay) { }

	// RVA: 0xEE1BC0 Offset: 0xEE0FC0 VA: 0x180EE1BC0 Slot: 7
	public override bool IsConnected() { }

	// RVA: 0x22D4540 Offset: 0x22D3940 VA: 0x1822D4540 Slot: 10
	public override bool Start() { }

	// RVA: 0x22D4910 Offset: 0x22D3D10 VA: 0x1822D4910 Slot: 11
	public override void Stop(string shutdownMsg) { }

	// RVA: 0x22D38B0 Offset: 0x22D2CB0 VA: 0x1822D38B0 Slot: 13
	public override void Disconnect(Connection cn) { }

	// RVA: 0x22D3B90 Offset: 0x22D2F90 VA: 0x1822D3B90 Slot: 14
	public override void Kick(Connection cn, string message, bool logfile) { }

	// RVA: 0x22D3740 Offset: 0x22D2B40 VA: 0x1822D3740 Slot: 12
	public override void Cycle() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 18
	public override void SendUnconnected(uint netAddr, ushort netPort, byte[] data, int size) { }

	// RVA: 0x22D41F0 Offset: 0x22D35F0 VA: 0x1822D41F0 Slot: 4
	public override void Send(SendInfo sendinfo, MemoryStream data) { }

	// RVA: 0x22D43D0 Offset: 0x22D37D0 VA: 0x1822D43D0
	private void Send(SendInfo sendinfo, MemoryStream data, Connection connection) { }

	// RVA: 0x22D3EB0 Offset: 0x22D32B0 VA: 0x1822D3EB0 Slot: 19
	public void OnConnecting(Connection cn, ConnectionInfo info) { }

	// RVA: 0x22D3D80 Offset: 0x22D3180 VA: 0x1822D3D80 Slot: 20
	public void OnConnected(Connection cn, ConnectionInfo info) { }

	// RVA: 0x22D3ED0 Offset: 0x22D32D0 VA: 0x1822D3ED0 Slot: 21
	public void OnDisconnected(Connection cn, ConnectionInfo info) { }

	// RVA: 0x22D3F50 Offset: 0x22D3350 VA: 0x1822D3F50 Slot: 22
	public void OnMessage(Connection cn, NetIdentity identity, IntPtr data, int size, long messageNum, long recvTime, int channel) { }

	// RVA: 0x22D3990 Offset: 0x22D2D90 VA: 0x1822D3990 Slot: 5
	public override string GetDebug(Connection connection) { }

	// RVA: 0x22D3940 Offset: 0x22D2D40 VA: 0x1822D3940 Slot: 17
	public override int GetAveragePing(Connection connection) { }

	// RVA: 0x22D39F0 Offset: 0x22D2DF0 VA: 0x1822D39F0 Slot: 6
	public override ulong GetStat(Connection connection, BaseNetwork.StatTypeLong type) { }

}

private sealed class SteamNetworking.Server.<>c // TypeDefIndex: 7365
{	// Fields
	public static readonly SteamNetworking.Server.<>c <>9; // 0x0
	public static Action<NetAddress> <>9__9_0; // 0x8

	// Methods

	// RVA: 0x22D5540 Offset: 0x22D4940 VA: 0x1822D5540
	private static void .cctor() { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x22D54B0 Offset: 0x22D48B0 VA: 0x1822D54B0
	internal void <Start>b__9_0(NetAddress fakeAddressCallback) { }

}

public class SteamInventory : EntityComponent<BasePlayer> // TypeDefIndex: 8653
{	// Fields
	private IPlayerItem[] Items; // 0x20

	// Methods

	// RVA: 0x79A050 Offset: 0x799450 VA: 0x18079A050 Slot: 9
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x799F20 Offset: 0x799320 VA: 0x180799F20
	public bool HasItem(int itemid) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x799C70 Offset: 0x799070 VA: 0x180799C70
	private void ClientUpdateSteamInventory(BaseEntity.RPCMessage msg) { }

	// RVA: 0x799D10 Offset: 0x799110 VA: 0x180799D10
	public void ClientUpdate(IPlayerInventory result) { }

	// RVA: 0x79A510 Offset: 0x799910 VA: 0x18079A510
	public void .ctor() { }

}

public class SteamInventoryGen : MonoBehaviour // TypeDefIndex: 9323
{	// Methods

	// RVA: 0x2F91F0 Offset: 0x2F85F0 VA: 0x1802F91F0
	public void .ctor() { }

}

public class SteamDLCItem : ScriptableObject // TypeDefIndex: 10760
{	// Fields
	public int id; // 0x18
	public Translate.Phrase dlcName; // 0x20
	public int dlcAppID; // 0x28
	public bool bypassLicenseCheck; // 0x2C

	// Methods

	// RVA: 0xA89B10 Offset: 0xA88F10 VA: 0x180A89B10
	public bool IsInstalled() { }

	// RVA: 0xA89970 Offset: 0xA88D70 VA: 0x180A89970
	public bool CanUse(BasePlayer player) { }

	// RVA: 0x4C0870 Offset: 0x4BFC70 VA: 0x1804C0870
	public void .ctor() { }

}

public class SteamInventoryCategory : ScriptableObject // TypeDefIndex: 10761
{	// Fields
	[HeaderAttribute] // RVA: 0x7AAD0 Offset: 0x79ED0 VA: 0x18007AAD0
	public bool canBeSoldToOtherUsers; // 0x18
	public bool canBeTradedWithOtherUsers; // 0x19
	public bool isCommodity; // 0x1A
	public SteamInventoryCategory.Price price; // 0x1C
	public SteamInventoryCategory.DropChance dropChance; // 0x20
	public bool CanBeInCrates; // 0x24

	// Methods

	// RVA: 0x799BB0 Offset: 0x798FB0 VA: 0x180799BB0
	public void .ctor() { }

}

public enum SteamInventoryCategory.Price // TypeDefIndex: 10762
{	// Fields
	public int value__; // 0x0
	public const SteamInventoryCategory.Price CannotBuy = 0;
	public const SteamInventoryCategory.Price VLV25 = 1;
	public const SteamInventoryCategory.Price VLV50 = 2;
	public const SteamInventoryCategory.Price VLV75 = 3;
	public const SteamInventoryCategory.Price VLV100 = 4;
	public const SteamInventoryCategory.Price VLV150 = 5;
	public const SteamInventoryCategory.Price VLV200 = 6;
	public const SteamInventoryCategory.Price VLV250 = 7;
	public const SteamInventoryCategory.Price VLV300 = 8;
	public const SteamInventoryCategory.Price VLV350 = 9;
	public const SteamInventoryCategory.Price VLV400 = 10;
	public const SteamInventoryCategory.Price VLV450 = 11;
	public const SteamInventoryCategory.Price VLV500 = 12;
	public const SteamInventoryCategory.Price VLV550 = 13;
	public const SteamInventoryCategory.Price VLV600 = 14;
	public const SteamInventoryCategory.Price VLV650 = 15;
	public const SteamInventoryCategory.Price VLV700 = 16;
	public const SteamInventoryCategory.Price VLV750 = 17;
	public const SteamInventoryCategory.Price VLV800 = 18;
	public const SteamInventoryCategory.Price VLV850 = 19;
	public const SteamInventoryCategory.Price VLV900 = 20;
	public const SteamInventoryCategory.Price VLV950 = 21;
	public const SteamInventoryCategory.Price VLV1000 = 22;
	public const SteamInventoryCategory.Price VLV1100 = 23;
	public const SteamInventoryCategory.Price VLV1200 = 24;
	public const SteamInventoryCategory.Price VLV1300 = 25;
	public const SteamInventoryCategory.Price VLV1400 = 26;
	public const SteamInventoryCategory.Price VLV1500 = 27;
	public const SteamInventoryCategory.Price VLV1600 = 28;
	public const SteamInventoryCategory.Price VLV1700 = 29;
	public const SteamInventoryCategory.Price VLV1800 = 30;
	public const SteamInventoryCategory.Price VLV1900 = 31;
	public const SteamInventoryCategory.Price VLV2000 = 32;
	public const SteamInventoryCategory.Price VLV2500 = 33;
	public const SteamInventoryCategory.Price VLV3000 = 34;
	public const SteamInventoryCategory.Price VLV3500 = 35;
	public const SteamInventoryCategory.Price VLV4000 = 36;
	public const SteamInventoryCategory.Price VLV4500 = 37;
	public const SteamInventoryCategory.Price VLV5000 = 38;
	public const SteamInventoryCategory.Price VLV6000 = 39;
	public const SteamInventoryCategory.Price VLV7000 = 40;
	public const SteamInventoryCategory.Price VLV8000 = 41;
	public const SteamInventoryCategory.Price VLV9000 = 42;
	public const SteamInventoryCategory.Price VLV10000 = 43;

}

public enum SteamInventoryCategory.DropChance // TypeDefIndex: 10763
{	// Fields
	public int value__; // 0x0
	public const SteamInventoryCategory.DropChance NeverDrop = 0;
	public const SteamInventoryCategory.DropChance VeryRare = 1;
	public const SteamInventoryCategory.DropChance Rare = 2;
	public const SteamInventoryCategory.DropChance Common = 3;
	public const SteamInventoryCategory.DropChance VeryCommon = 4;
	public const SteamInventoryCategory.DropChance ExtremelyRare = 5;

}

public class SteamInventoryItem : ScriptableObject // TypeDefIndex: 10764
{	// Fields
	public int id; // 0x18
	public Sprite icon; // 0x20
	public Translate.Phrase displayName; // 0x28
	public Translate.Phrase displayDescription; // 0x30
	[HeaderAttribute] // RVA: 0x7AAD0 Offset: 0x79ED0 VA: 0x18007AAD0
	public SteamInventoryItem.Category category; // 0x38
	public SteamInventoryItem.SubCategory subcategory; // 0x3C
	public SteamInventoryCategory steamCategory; // 0x40
	public bool isLimitedTimeOffer; // 0x48
	[TooltipAttribute] // RVA: 0x7ADB0 Offset: 0x7A1B0 VA: 0x18007ADB0
	public bool PreventBreakingDown; // 0x49
	[HeaderAttribute] // RVA: 0x7B150 Offset: 0x7A550 VA: 0x18007B150
	public string itemname; // 0x50
	public ulong workshopID; // 0x58
	public SteamDLCItem DlcItem; // 0x60
	[TooltipAttribute] // RVA: 0x7B2D0 Offset: 0x7A6D0 VA: 0x18007B2D0
	public bool forceCraftableItemDesc; // 0x68

	// Properties
	public ItemDefinition itemDefinition { get; }

	// Methods

	// RVA: 0x799C60 Offset: 0x799060 VA: 0x180799C60
	public ItemDefinition get_itemDefinition() { }

	// RVA: 0x799BC0 Offset: 0x798FC0 VA: 0x180799BC0 Slot: 4
	public virtual bool HasUnlocked(ulong playerId) { }

	// RVA: 0x799C50 Offset: 0x799050 VA: 0x180799C50
	public void .ctor() { }

}

public enum SteamInventoryItem.Category // TypeDefIndex: 10765
{	// Fields
	public int value__; // 0x0
	public const SteamInventoryItem.Category None = 0;
	public const SteamInventoryItem.Category Clothing = 1;
	public const SteamInventoryItem.Category Weapon = 2;
	public const SteamInventoryItem.Category Decoration = 3;
	public const SteamInventoryItem.Category Crate = 4;
	public const SteamInventoryItem.Category Resource = 5;

}

public enum SteamInventoryItem.SubCategory // TypeDefIndex: 10766
{	// Fields
	public int value__; // 0x0
	public const SteamInventoryItem.SubCategory None = 0;
	public const SteamInventoryItem.SubCategory Shirt = 1;
	public const SteamInventoryItem.SubCategory Pants = 2;
	public const SteamInventoryItem.SubCategory Jacket = 3;
	public const SteamInventoryItem.SubCategory Hat = 4;
	public const SteamInventoryItem.SubCategory Mask = 5;
	public const SteamInventoryItem.SubCategory Footwear = 6;
	public const SteamInventoryItem.SubCategory Weapon = 7;
	public const SteamInventoryItem.SubCategory Misc = 8;
	public const SteamInventoryItem.SubCategory Crate = 9;
	public const SteamInventoryItem.SubCategory Resource = 10;
	public const SteamInventoryItem.SubCategory CrateUncraftable = 11;

}

public class SteamClientWrapper : SingletonComponent<SteamClientWrapper> // TypeDefIndex: 10776
{	// Methods

	// RVA: 0xA891B0 Offset: 0xA885B0 VA: 0x180A891B0
	public Texture GetAvatarTexture(ulong steamid) { }

	// RVA: 0xA893C0 Offset: 0xA887C0 VA: 0x180A893C0
	public string GetUserName(ulong steamid) { }

	// RVA: 0xA89630 Offset: 0xA88A30 VA: 0x180A89630
	public static void SetPlayerPresence(SteamClientWrapper.RichPresenceState state) { }

	// RVA: 0xA890D0 Offset: 0xA884D0 VA: 0x180A890D0
	public static void ClearPlayerPresence() { }

	// RVA: 0xA89300 Offset: 0xA88700 VA: 0x180A89300
	private static string GetLocalizationKey(SteamClientWrapper.RichPresenceState state) { }

	// RVA: 0xA894B0 Offset: 0xA888B0 VA: 0x180A894B0
	public static void Init() { }

	// RVA: 0xA89000 Offset: 0xA88400 VA: 0x180A89000 Slot: 6
	protected override void Awake() { }

	// RVA: 0xA898A0 Offset: 0xA88CA0 VA: 0x180A898A0
	public void Update() { }

	// RVA: 0xA895C0 Offset: 0xA889C0 VA: 0x180A895C0
	public void OnDisable() { }

	// RVA: 0xA89910 Offset: 0xA88D10 VA: 0x180A89910
	public void .ctor() { }

}

public enum SteamClientWrapper.RichPresenceState // TypeDefIndex: 10777
{	// Fields
	public int value__; // 0x0
	public const SteamClientWrapper.RichPresenceState MainMenu = 0;
	public const SteamClientWrapper.RichPresenceState Wilderness = 1;
	public const SteamClientWrapper.RichPresenceState Monument = 2;

}

public static class SteamNewsSource // TypeDefIndex: 11128
{	// Fields
	public static SteamNewsSource.Story[] Stories; // 0x2520

	// Methods

	[IteratorStateMachineAttribute] // RVA: 0x98EF0 Offset: 0x982F0 VA: 0x180098EF0
	// RVA: 0x79A550 Offset: 0x799950 VA: 0x18079A550
	public static IEnumerator GetStories() { }

}

public struct SteamNewsSource.Story // TypeDefIndex: 11129
{	// Fields
	public string name; // 0x0
	public string url; // 0x8
	public int date; // 0x10
	public string text; // 0x18
	public string author; // 0x20

}

private sealed class SteamNewsSource.<GetStories>d__2 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 11130
{	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	private WWW <www>5__2; // 0x20

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497770 Offset: 0x496B70 VA: 0x180497770
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x7B2660 Offset: 0x7B1A60 VA: 0x1807B2660 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x7B2B20 Offset: 0x7B1F20 VA: 0x1807B2B20 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

}

public class SteamFriendsList : MonoBehaviour // TypeDefIndex: 11217
{	// Fields
	public RectTransform targetPanel; // 0x18
	public SteamUserButton userButton; // 0x20
	public bool IncludeFriendsList; // 0x28
	public bool IncludeRecentlySeen; // 0x29
	public bool IncludeLastAttacker; // 0x2A
	public bool IncludeRecentlyPlayedWith; // 0x2B
	public bool ShowTeamFirst; // 0x2C
	public bool HideSteamIdsInStreamerMode; // 0x2D
	public bool RefreshOnEnable; // 0x2E
	public SteamFriendsList.onFriendSelectedEvent onFriendSelected; // 0x30
	public Func<ulong, bool> shouldShowPlayer; // 0x38
	private List<IPlayerInfo> playerList; // 0x40
	internal static List<ulong> SeenList; // 0x0

	// Methods

	// RVA: 0xA8A760 Offset: 0xA89B60 VA: 0x180A8A760
	private void OnEnable() { }

	// RVA: 0xA8AAB0 Offset: 0xA89EB0 VA: 0x180A8AAB0
	public void Refresh() { }

	// RVA: 0xA89C80 Offset: 0xA89080 VA: 0x180A89C80
	public void AddPlayer(IPlayerInfo f) { }

	// RVA: 0xA8A770 Offset: 0xA89B70 VA: 0x180A8A770
	public int Priority(IPlayerInfo f) { }

	// RVA: 0xA8A2D0 Offset: 0xA896D0 VA: 0x180A8A2D0
	public void FilterSearch(string name) { }

	// RVA: 0xA89D90 Offset: 0xA89190 VA: 0x180A89D90
	public void AddToPanel(IEnumerable<IPlayerInfo> list, int count = -1) { }

	// RVA: 0xA8A3B0 Offset: 0xA897B0 VA: 0x180A8A3B0
	private void FriendSelected(ulong steamid, string steamName) { }

	// RVA: 0xA8A420 Offset: 0xA89820 VA: 0x180A8A420
	public static void JustSeen(ulong steamid) { }

	// RVA: 0xA8B520 Offset: 0xA8A920 VA: 0x180A8B520
	public void .ctor() { }

	// RVA: 0xA8B4C0 Offset: 0xA8A8C0 VA: 0x180A8B4C0
	private static void .cctor() { }

}

public class SteamFriendsList.onFriendSelectedEvent : UnityEvent<ulong, string> // TypeDefIndex: 11218
{	// Methods

	// RVA: 0x7B3410 Offset: 0x7B2810 VA: 0x1807B3410
	public void .ctor() { }

}

private sealed class SteamFriendsList.<>c__DisplayClass15_0 // TypeDefIndex: 11219
{	// Fields
	public IPlayerInfo f; // 0x10

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x7B2BF0 Offset: 0x7B1FF0 VA: 0x1807B2BF0
	internal bool <AddPlayer>b__0(IPlayerInfo x) { }

}

private sealed class SteamFriendsList.<>c__DisplayClass16_0 // TypeDefIndex: 11220
{	// Fields
	public IPlayerInfo f; // 0x10

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x7B2C70 Offset: 0x7B2070 VA: 0x1807B2C70
	internal bool <Priority>b__0(PlayerTeam.TeamMember p) { }

}

private sealed class SteamFriendsList.<>c__DisplayClass17_0 // TypeDefIndex: 11221
{	// Fields
	public string name; // 0x10

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x7B2CE0 Offset: 0x7B20E0 VA: 0x1807B2CE0
	internal bool <FilterSearch>b__0(IPlayerInfo x) { }

}

private sealed class SteamFriendsList.<>c__DisplayClass18_0 // TypeDefIndex: 11222
{	// Fields
	public IPlayerInfo player; // 0x10
	public SteamFriendsList <>4__this; // 0x18

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

}

private sealed class SteamFriendsList.<>c__DisplayClass18_1 // TypeDefIndex: 11223
{	// Fields
	public ulong steamid; // 0x10
	public SteamFriendsList.<>c__DisplayClass18_0 CS$<>8__locals1; // 0x18

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x7B2DE0 Offset: 0x7B21E0 VA: 0x1807B2DE0
	internal void <AddToPanel>b__1() { }

}

private sealed class SteamFriendsList.<>c // TypeDefIndex: 11224
{	// Fields
	public static readonly SteamFriendsList.<>c <>9; // 0x0
	public static Func<IPlayerInfo, string> <>9__18_0; // 0x8

	// Methods

	// RVA: 0x7B2F70 Offset: 0x7B2370 VA: 0x1807B2F70
	private static void .cctor() { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x7B2B70 Offset: 0x7B1F70 VA: 0x1807B2B70
	internal string <AddToPanel>b__18_0(IPlayerInfo x) { }

}

public class SteamUserButton : MonoBehaviour // TypeDefIndex: 11225
{	// Fields
	public RustText steamName; // 0x18
	public RustText steamInfo; // 0x20
	public RawImage avatar; // 0x28
	public Color textColorInGame; // 0x30
	public Color textColorOnline; // 0x40
	public Color textColorNormal; // 0x50
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private ulong <SteamId>k__BackingField; // 0x60
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private string <Username>k__BackingField; // 0x68

	// Properties
	public ulong SteamId { get; set; }
	public string Username { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x54FB60 Offset: 0x54EF60 VA: 0x18054FB60
	public ulong get_SteamId() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x6E4670 Offset: 0x6E3A70 VA: 0x1806E4670
	private void set_SteamId(ulong value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x5334F0 Offset: 0x5328F0 VA: 0x1805334F0
	public string get_Username() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x5336F0 Offset: 0x532AF0 VA: 0x1805336F0
	private void set_Username(string value) { }

	[AsyncStateMachineAttribute] // RVA: 0xA2290 Offset: 0xA1690 VA: 0x1800A2290
	// RVA: 0x79A5A0 Offset: 0x7999A0 VA: 0x18079A5A0
	public void UpdateFromUser(ulong steamid, bool isInThisGame, bool isOnline, bool hideSteamId) { }

	// RVA: 0x2F91F0 Offset: 0x2F85F0 VA: 0x1802F91F0
	public void .ctor() { }

}

private struct SteamUserButton.<UpdateFromUser>d__14 : IAsyncStateMachine // TypeDefIndex: 11226
{	// Fields
	public int <>1__state; // 0x0
	public AsyncVoidMethodBuilder <>t__builder; // 0x8
	public SteamUserButton <>4__this; // 0x28
	public ulong steamid; // 0x30
	public bool hideSteamId; // 0x38
	public bool isInThisGame; // 0x39
	public bool isOnline; // 0x3A
	private TaskAwaiter<IPlayerInfo> <>u__1; // 0x40

	// Methods

	// RVA: 0xF6540 Offset: 0xF5940 VA: 0x1800F6540 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xF1420 Offset: 0xF0820 VA: 0x1800F1420 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

public class Steam // TypeDefIndex: 11960
{	// Methods

	[ClientVar] // RVA: 0x71070 Offset: 0x70470 VA: 0x180071070
	// RVA: 0x36A370 Offset: 0x369770 VA: 0x18036A370
	public static object achievements() { }

	[ClientVar] // RVA: 0x71070 Offset: 0x70470 VA: 0x180071070
	// RVA: 0x36A330 Offset: 0x369730 VA: 0x18036A330
	public static void ResetStats() { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

}

private sealed class Steam.<>c // TypeDefIndex: 11961
{	// Fields
	public static readonly Steam.<>c <>9; // 0x0
	public static Func<Achievement, <>f__AnonymousType0<string, string, bool>> <>9__0_0; // 0x8

	// Methods

	// RVA: 0x36BFE0 Offset: 0x36B3E0 VA: 0x18036BFE0
	private static void .cctor() { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x36BE40 Offset: 0x36B240 VA: 0x18036BE40
	internal <>f__AnonymousType0<string, string, bool> <achievements>b__0_0(Achievement x) { }

}

public class SteamInventoryCrafting : MonoBehaviour // TypeDefIndex: 12046
{	// Fields
	public GameObject Container; // 0x18
	public Button ConvertToItem; // 0x20
	public TextMeshProUGUI WoodAmount; // 0x28
	public TextMeshProUGUI ClothAmount; // 0x30
	public TextMeshProUGUI MetalAmount; // 0x38
	public int SelectedCount; // 0x40
	public TextMeshProUGUI InfoText; // 0x48
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private IPlayerItemDefinition <ResultItem>k__BackingField; // 0x50
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Coroutine <MarketCoroutine>k__BackingField; // 0x58
	public SteamInventoryCrateOpen CraftModal; // 0x60
	public GameObject CraftingContainer; // 0x68
	public GameObject CraftingButton; // 0x70
	public SteamInventoryNewItem NewItemModal; // 0x78
	private static readonly Regex priceRegex; // 0x0
	private readonly HttpClient httpClient; // 0x80
	private readonly Dictionary<int, Task<SteamInventoryCrafting.MarketPrice>> priceCache; // 0x88

	// Properties
	public IPlayerItemDefinition ResultItem { get; set; }
	public Coroutine MarketCoroutine { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4CC350 Offset: 0x4CB750 VA: 0x1804CC350
	public IPlayerItemDefinition get_ResultItem() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4CC370 Offset: 0x4CB770 VA: 0x1804CC370
	private void set_ResultItem(IPlayerItemDefinition value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4CC340 Offset: 0x4CB740 VA: 0x1804CC340
	public Coroutine get_MarketCoroutine() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4CC360 Offset: 0x4CB760 VA: 0x1804CC360
	private void set_MarketCoroutine(Coroutine value) { }

	// RVA: 0x4CB860 Offset: 0x4CAC60 VA: 0x1804CB860
	public void OnEnable() { }

	// RVA: 0x4CA5D0 Offset: 0x4C99D0 VA: 0x1804CA5D0
	private void FillCraftingContainer() { }

	// RVA: 0x4CC230 Offset: 0x4CB630 VA: 0x1804CC230
	public void Update() { }

	// RVA: 0x4CBE30 Offset: 0x4CB230 VA: 0x1804CBE30
	private void UpdateImpl(bool force) { }

	// RVA: 0x4CAD60 Offset: 0x4CA160 VA: 0x1804CAD60
	private void OnChanged(SteamInventoryItem[] items) { }

	// RVA: 0x4CC060 Offset: 0x4CB460 VA: 0x1804CC060
	private void UpdateInfoText(int length, IPlayerItemDefinition definition, Nullable<double> totalValue) { }

	[AsyncStateMachineAttribute] // RVA: 0xD1600 Offset: 0xD0A00 VA: 0x1800D1600
	// RVA: 0x4CABB0 Offset: 0x4C9FB0 VA: 0x1804CABB0
	private Task<SteamInventoryCrafting.MarketPrice> GetMarketPrice(IPlayerItemDefinition definition) { }

	[AsyncStateMachineAttribute] // RVA: 0xD16E0 Offset: 0xD0AE0 VA: 0x1800D16E0
	// RVA: 0x4CAA90 Offset: 0x4C9E90 VA: 0x1804CAA90
	private Task<SteamInventoryCrafting.MarketPrice> GetMarketPriceImpl(IPlayerItemDefinition definition) { }

	[IteratorStateMachineAttribute] // RVA: 0xD1920 Offset: 0xD0D20 VA: 0x1800D1920
	// RVA: 0x4CACD0 Offset: 0x4CA0D0 VA: 0x1804CACD0
	private IEnumerator LoadMarketPrice(IPlayerItemDefinition definition) { }

	// RVA: 0x4CA190 Offset: 0x4C9590 VA: 0x1804CA190
	public void DoExchange() { }

	[AsyncStateMachineAttribute] // RVA: 0xD1A70 Offset: 0xD0E70 VA: 0x1800D1A70
	// RVA: 0x4CA4B0 Offset: 0x4C98B0 VA: 0x1804CA4B0
	private Task ExchangeItems(SteamInventoryItem[] selected) { }

	// RVA: 0x4CB8F0 Offset: 0x4CACF0 VA: 0x1804CB8F0
	public void OnRefreshed(IReadOnlyCollection<IPlayerItem> items) { }

	// RVA: 0x4CB870 Offset: 0x4CAC70 VA: 0x1804CB870
	public void OnManualRefresh() { }

	// RVA: 0x4CC2A0 Offset: 0x4CB6A0 VA: 0x1804CC2A0
	public void .ctor() { }

	// RVA: 0x4CC240 Offset: 0x4CB640 VA: 0x1804CC240
	private static void .cctor() { }

}

public class SteamInventoryCrafting.MarketPrice // TypeDefIndex: 12047
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private bool <success>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private ulong <volume>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private string <lowest_price>k__BackingField; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private double <lowest_price_value>k__BackingField; // 0x28

	// Properties
	public bool success { get; set; }
	public ulong volume { get; set; }
	public string lowest_price { get; set; }
	public double lowest_price_value { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497E20 Offset: 0x497220 VA: 0x180497E20
	public bool get_success() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497E50 Offset: 0x497250 VA: 0x180497E50
	public void set_success(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710
	public ulong get_volume() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497E60 Offset: 0x497260 VA: 0x180497E60
	public void set_volume(ulong value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497E00 Offset: 0x497200 VA: 0x180497E00
	public string get_lowest_price() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497E30 Offset: 0x497230 VA: 0x180497E30
	public void set_lowest_price(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497E10 Offset: 0x497210 VA: 0x180497E10
	public double get_lowest_price_value() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497E40 Offset: 0x497240 VA: 0x180497E40
	public void set_lowest_price_value(double value) { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

}

private sealed class SteamInventoryCrafting.<>c__DisplayClass20_0 // TypeDefIndex: 12048
{	// Fields
	public IPlayerItemDefinition x; // 0x10
	public SteamInventoryCrafting <>4__this; // 0x18

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x4B0940 Offset: 0x4AFD40 VA: 0x1804B0940
	internal void <FillCraftingContainer>b__1() { }

}

private sealed class SteamInventoryCrafting.<>c // TypeDefIndex: 12049
{	// Fields
	public static readonly SteamInventoryCrafting.<>c <>9; // 0x0
	public static Func<IPlayerItemDefinition, bool> <>9__20_0; // 0x8
	public static Func<Toggle, bool> <>9__22_0; // 0x10
	public static Func<Toggle, SteamInventoryItem> <>9__22_1; // 0x18
	public static Func<SteamInventoryItem, bool> <>9__23_0; // 0x20
	public static Func<SteamInventoryItem, bool> <>9__23_1; // 0x28
	public static Func<SteamInventoryItem, bool> <>9__23_2; // 0x30
	public static Func<SteamInventoryItem, bool> <>9__23_3; // 0x38
	public static Func<SteamInventoryItem, bool> <>9__23_4; // 0x40
	public static Func<SteamInventoryItem, IEnumerable<PlayerItemRecipe>> <>9__23_5; // 0x48
	public static Func<PlayerItemRecipe, IPlayerItemDefinition> <>9__23_6; // 0x50
	public static Func<Toggle, bool> <>9__32_0; // 0x58
	public static Func<Toggle, SteamInventoryItem> <>9__32_1; // 0x60
	public static Func<IPlayerItem, bool> <>9__34_0; // 0x68
	public static Func<IPlayerItem, int> <>9__34_1; // 0x70
	public static Func<IPlayerItem, bool> <>9__34_2; // 0x78
	public static Func<IPlayerItem, int> <>9__34_3; // 0x80
	public static Func<IPlayerItem, bool> <>9__34_4; // 0x88
	public static Func<IPlayerItem, int> <>9__34_5; // 0x90

	// Methods

	// RVA: 0x4CF160 Offset: 0x4CE560 VA: 0x1804CF160
	private static void .cctor() { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x4CE540 Offset: 0x4CD940 VA: 0x1804CE540
	internal bool <FillCraftingContainer>b__20_0(IPlayerItemDefinition x) { }

	// RVA: 0x4CE4D0 Offset: 0x4CD8D0 VA: 0x1804CE4D0
	internal bool <UpdateImpl>b__22_0(Toggle x) { }

	// RVA: 0x4CEBB0 Offset: 0x4CDFB0 VA: 0x1804CEBB0
	internal SteamInventoryItem <UpdateImpl>b__22_1(Toggle x) { }

	// RVA: 0x4CE5A0 Offset: 0x4CD9A0 VA: 0x1804CE5A0
	internal bool <OnChanged>b__23_0(SteamInventoryItem x) { }

	// RVA: 0x4CE5D0 Offset: 0x4CD9D0 VA: 0x1804CE5D0
	internal bool <OnChanged>b__23_1(SteamInventoryItem x) { }

	// RVA: 0x4CE5A0 Offset: 0x4CD9A0 VA: 0x1804CE5A0
	internal bool <OnChanged>b__23_2(SteamInventoryItem x) { }

	// RVA: 0x4CE640 Offset: 0x4CDA40 VA: 0x1804CE640
	internal bool <OnChanged>b__23_3(SteamInventoryItem x) { }

	// RVA: 0x4CE5A0 Offset: 0x4CD9A0 VA: 0x1804CE5A0
	internal bool <OnChanged>b__23_4(SteamInventoryItem x) { }

	// RVA: 0x4CE6B0 Offset: 0x4CDAB0 VA: 0x1804CE6B0
	internal IEnumerable<PlayerItemRecipe> <OnChanged>b__23_5(SteamInventoryItem x) { }

	// RVA: 0x4CE710 Offset: 0x4CDB10 VA: 0x1804CE710
	internal IPlayerItemDefinition <OnChanged>b__23_6(PlayerItemRecipe x) { }

	// RVA: 0x4CE4D0 Offset: 0x4CD8D0 VA: 0x1804CE4D0
	internal bool <DoExchange>b__32_0(Toggle x) { }

	// RVA: 0x4CE4F0 Offset: 0x4CD8F0 VA: 0x1804CE4F0
	internal SteamInventoryItem <DoExchange>b__32_1(Toggle x) { }

	// RVA: 0x4CE780 Offset: 0x4CDB80 VA: 0x1804CE780
	internal bool <OnRefreshed>b__34_0(IPlayerItem x) { }

	// RVA: 0x4CE7D0 Offset: 0x4CDBD0 VA: 0x1804CE7D0
	internal int <OnRefreshed>b__34_1(IPlayerItem x) { }

	// RVA: 0x4CE820 Offset: 0x4CDC20 VA: 0x1804CE820
	internal bool <OnRefreshed>b__34_2(IPlayerItem x) { }

	// RVA: 0x4CE870 Offset: 0x4CDC70 VA: 0x1804CE870
	internal int <OnRefreshed>b__34_3(IPlayerItem x) { }

	// RVA: 0x4CE8C0 Offset: 0x4CDCC0 VA: 0x1804CE8C0
	internal bool <OnRefreshed>b__34_4(IPlayerItem x) { }

	// RVA: 0x4CE910 Offset: 0x4CDD10 VA: 0x1804CE910
	internal int <OnRefreshed>b__34_5(IPlayerItem x) { }

}

private sealed class SteamInventoryCrafting.<>c__DisplayClass23_0 // TypeDefIndex: 12050
{	// Fields
	public IPlayerItemDefinition itemType; // 0x10

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x4B09B0 Offset: 0x4AFDB0 VA: 0x1804B09B0
	internal bool <OnChanged>b__7(SteamInventoryItem x) { }

}

private struct SteamInventoryCrafting.<GetMarketPrice>d__29 : IAsyncStateMachine // TypeDefIndex: 12051
{	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder<SteamInventoryCrafting.MarketPrice> <>t__builder; // 0x8
	public SteamInventoryCrafting <>4__this; // 0x20
	public IPlayerItemDefinition definition; // 0x28
	private TaskAwaiter<SteamInventoryCrafting.MarketPrice> <>u__1; // 0x30

	// Methods

	// RVA: 0xF20F0 Offset: 0xF14F0 VA: 0x1800F20F0 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xF2100 Offset: 0xF1500 VA: 0x1800F2100 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

private struct SteamInventoryCrafting.<GetMarketPriceImpl>d__30 : IAsyncStateMachine // TypeDefIndex: 12052
{	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder<SteamInventoryCrafting.MarketPrice> <>t__builder; // 0x8
	public IPlayerItemDefinition definition; // 0x20
	public SteamInventoryCrafting <>4__this; // 0x28
	private TaskAwaiter<string> <>u__1; // 0x30

	// Methods

	// RVA: 0xF2090 Offset: 0xF1490 VA: 0x1800F2090 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xF20A0 Offset: 0xF14A0 VA: 0x1800F20A0 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

private sealed class SteamInventoryCrafting.<>c__DisplayClass31_0 // TypeDefIndex: 12053
{	// Fields
	public Task<SteamInventoryCrafting.MarketPrice> task; // 0x10

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x4B0AA0 Offset: 0x4AFEA0 VA: 0x1804B0AA0
	internal bool <LoadMarketPrice>b__0() { }

}

private sealed class SteamInventoryCrafting.<LoadMarketPrice>d__31 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 12054
{	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public SteamInventoryCrafting <>4__this; // 0x20
	public IPlayerItemDefinition definition; // 0x28
	private SteamInventoryCrafting.<>c__DisplayClass31_0 <>8__1; // 0x30

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497770 Offset: 0x496B70 VA: 0x180497770
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x4AEC10 Offset: 0x4AE010 VA: 0x1804AEC10 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4AEDF0 Offset: 0x4AE1F0 VA: 0x1804AEDF0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

}

private sealed class SteamInventoryCrafting.<>c__DisplayClass33_0 // TypeDefIndex: 12055
{	// Fields
	public SteamInventoryItem[] selected; // 0x10

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x4B0AC0 Offset: 0x4AFEC0 VA: 0x1804B0AC0
	internal bool <ExchangeItems>b__0(IPlayerItem x) { }

}

private sealed class SteamInventoryCrafting.<>c__DisplayClass33_1 // TypeDefIndex: 12056
{	// Fields
	public IPlayerItemDefinition targetItem; // 0x10

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x4B0B90 Offset: 0x4AFF90 VA: 0x1804B0B90
	internal Task<IPlayerInventory> <ExchangeItems>b__1(SteamInventoryItem x) { }

}

private struct SteamInventoryCrafting.<ExchangeItems>d__33 : IAsyncStateMachine // TypeDefIndex: 12057
{	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder <>t__builder; // 0x8
	public SteamInventoryItem[] selected; // 0x20
	public SteamInventoryCrafting <>4__this; // 0x28
	private SteamInventoryCrafting.<>c__DisplayClass33_0 <>8__1; // 0x30
	private SteamInventoryCrafting.<>c__DisplayClass33_1 <>8__2; // 0x38
	private IPlayerInventory <result>5__2; // 0x40
	private TaskAwaiter<IPlayerInventory> <>u__1; // 0x48
	private TaskAwaiter <>u__2; // 0x50
	private TaskAwaiter<IPlayerInventory[]> <>u__3; // 0x58

	// Methods

	// RVA: 0xF2070 Offset: 0xF1470 VA: 0x1800F2070 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xF2060 Offset: 0xF1460 VA: 0x1800F2060 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

public class SteamInventoryCrateOpen : MonoBehaviour // TypeDefIndex: 12058
{	// Fields
	public TextMeshProUGUI Name; // 0x18
	public TextMeshProUGUI Requirements; // 0x20
	public TextMeshProUGUI Label; // 0x28
	public HttpImage IconImage; // 0x30
	public GameObject ErrorPanel; // 0x38
	public TextMeshProUGUI ErrorText; // 0x40
	public GameObject CraftButton; // 0x48
	public GameObject ProgressPanel; // 0x50
	public SteamInventoryNewItem NewItemModal; // 0x58
	private InventoryRecipe Recipe; // 0x60

	// Methods

	// RVA: 0x4AA500 Offset: 0x4A9900 VA: 0x1804AA500
	public void Open(int ItemDefinition) { }

	// RVA: 0x4AA400 Offset: 0x4A9800 VA: 0x1804AA400
	public void DoCraft() { }

	[AsyncStateMachineAttribute] // RVA: 0xD5AD0 Offset: 0xD4ED0 VA: 0x1800D5AD0
	// RVA: 0x4AA400 Offset: 0x4A9800 VA: 0x1804AA400
	private Task DoCraftAsync() { }

	// RVA: 0x4AA3B0 Offset: 0x4A97B0 VA: 0x1804AA3B0
	public void Close() { }

	// RVA: 0x2F91F0 Offset: 0x2F85F0 VA: 0x1802F91F0
	public void .ctor() { }

}

private sealed class SteamInventoryCrateOpen.<>c__DisplayClass10_0 // TypeDefIndex: 12059
{	// Fields
	public InventoryRecipe.Ingredient i; // 0x10

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x4B0820 Offset: 0x4AFC20 VA: 0x1804B0820
	internal bool <Open>b__1(InventoryItem x) { }

}

private sealed class SteamInventoryCrateOpen.<>c // TypeDefIndex: 12060
{	// Fields
	public static readonly SteamInventoryCrateOpen.<>c <>9; // 0x0
	public static Func<InventoryRecipe.Ingredient, string> <>9__10_0; // 0x8
	public static Func<InventoryItem, int> <>9__10_2; // 0x10
	public static Func<InventoryItem, int> <>9__12_1; // 0x18

	// Methods

	// RVA: 0x4B0CB0 Offset: 0x4B00B0 VA: 0x1804B0CB0
	private static void .cctor() { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x4B06C0 Offset: 0x4AFAC0 VA: 0x1804B06C0
	internal string <Open>b__10_0(InventoryRecipe.Ingredient x) { }

	// RVA: 0x4B05F0 Offset: 0x4AF9F0 VA: 0x1804B05F0
	internal int <Open>b__10_2(InventoryItem x) { }

	// RVA: 0x4B05F0 Offset: 0x4AF9F0 VA: 0x1804B05F0
	internal int <DoCraftAsync>b__12_1(InventoryItem x) { }

}

private sealed class SteamInventoryCrateOpen.<>c__DisplayClass12_0 // TypeDefIndex: 12061
{	// Fields
	public List<InventoryItem.Amount> items; // 0x10

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x4B0850 Offset: 0x4AFC50 VA: 0x1804B0850
	internal bool <DoCraftAsync>b__2(InventoryItem x) { }

}

private sealed class SteamInventoryCrateOpen.<>c__DisplayClass12_1 // TypeDefIndex: 12062
{	// Fields
	public InventoryRecipe.Ingredient i; // 0x10

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x4B0820 Offset: 0x4AFC20 VA: 0x1804B0820
	internal bool <DoCraftAsync>b__0(InventoryItem x) { }

}

private sealed class SteamInventoryCrateOpen.<>c__DisplayClass12_2 // TypeDefIndex: 12063
{	// Fields
	public InventoryItem x; // 0x10

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x4B0920 Offset: 0x4AFD20 VA: 0x1804B0920
	internal bool <DoCraftAsync>b__3(InventoryItem.Amount y) { }

}

private struct SteamInventoryCrateOpen.<DoCraftAsync>d__12 : IAsyncStateMachine // TypeDefIndex: 12064
{	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder <>t__builder; // 0x8
	public SteamInventoryCrateOpen <>4__this; // 0x20
	private SteamInventoryCrateOpen.<>c__DisplayClass12_0 <>8__1; // 0x28
	private Nullable<InventoryResult> <result>5__2; // 0x30
	private TaskAwaiter<Nullable<InventoryResult>> <>u__1; // 0x40
	private TaskAwaiter <>u__2; // 0x48

	// Methods

	// RVA: 0xF2050 Offset: 0xF1450 VA: 0x1800F2050 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xF2060 Offset: 0xF1460 VA: 0x1800F2060 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

public class SteamInventoryIcon : MonoBehaviour // TypeDefIndex: 12065
{	// Methods

	// RVA: 0x4AAB80 Offset: 0x4A9F80 VA: 0x1804AAB80
	public void Setup(IPlayerItem item, ItemSkinDirectory.Skin skin) { }

	// RVA: 0x4AAC90 Offset: 0x4AA090 VA: 0x1804AAC90
	internal void Setup(IPlayerItem item) { }

	// RVA: 0x2F91F0 Offset: 0x2F85F0 VA: 0x1802F91F0
	public void .ctor() { }

}

public class SteamInventoryItem : MonoBehaviour // TypeDefIndex: 12066
{	// Fields
	public IPlayerItem Item; // 0x18
	public HttpImage Image; // 0x20

	// Methods

	// RVA: 0x4AAE40 Offset: 0x4AA240 VA: 0x1804AAE40
	public bool Setup(IPlayerItem item) { }

	// RVA: 0x2F91F0 Offset: 0x2F85F0 VA: 0x1802F91F0
	public void .ctor() { }

}

public class SteamInventoryManager : SingletonComponent<SteamInventoryManager> // TypeDefIndex: 12067
{	// Fields
	public GameObject inventoryItemPrefab; // 0x18
	public GameObject inventoryCanvas; // 0x20
	public GameObject missingItems; // 0x28
	public SteamInventoryCrafting CraftControl; // 0x30
	public List<GameObject> items; // 0x38
	public GameObject LoadingOverlay; // 0x40

	// Methods

	// RVA: 0x4AAF60 Offset: 0x4AA360 VA: 0x1804AAF60 Slot: 6
	protected override void Awake() { }

	// RVA: 0x4AB100 Offset: 0x4AA500 VA: 0x1804AB100
	public void ManualRefresh() { }

	[AsyncStateMachineAttribute] // RVA: 0xD6060 Offset: 0xD5460 VA: 0x1800D6060
	// RVA: 0x4AB280 Offset: 0x4AA680 VA: 0x1804AB280
	public Task Refresh() { }

	[AsyncStateMachineAttribute] // RVA: 0xD61C0 Offset: 0xD55C0 VA: 0x1800D61C0
	// RVA: 0x4AAFD0 Offset: 0x4AA3D0 VA: 0x1804AAFD0
	private Task FixStacks(IReadOnlyCollection<IPlayerItem> steamitems) { }

	// RVA: 0x4AB380 Offset: 0x4AA780 VA: 0x1804AB380
	public void .ctor() { }

}

private sealed class SteamInventoryManager.<>c // TypeDefIndex: 12068
{	// Fields
	public static readonly SteamInventoryManager.<>c <>9; // 0x0
	public static Func<IPlayerItem, DateTimeOffset> <>9__8_0; // 0x8
	public static Func<InventoryItem, bool> <>9__9_0; // 0x10
	public static Func<InventoryItem, bool> <>9__9_1; // 0x18
	public static Func<InventoryItem, bool> <>9__9_2; // 0x20
	public static Func<InventoryItem, InventoryDefId> <>9__9_3; // 0x28

	// Methods

	// RVA: 0x4B0D10 Offset: 0x4B0110 VA: 0x1804B0D10
	private static void .cctor() { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x4B0750 Offset: 0x4AFB50 VA: 0x1804B0750
	internal DateTimeOffset <Refresh>b__8_0(IPlayerItem x) { }

	// RVA: 0x4B0600 Offset: 0x4AFA00 VA: 0x1804B0600
	internal bool <FixStacks>b__9_0(InventoryItem x) { }

	// RVA: 0x4B0620 Offset: 0x4AFA20 VA: 0x1804B0620
	internal bool <FixStacks>b__9_1(InventoryItem x) { }

	// RVA: 0x4B0650 Offset: 0x4AFA50 VA: 0x1804B0650
	internal bool <FixStacks>b__9_2(InventoryItem x) { }

	// RVA: 0x4B06B0 Offset: 0x4AFAB0 VA: 0x1804B06B0
	internal InventoryDefId <FixStacks>b__9_3(InventoryItem x) { }

}

private struct SteamInventoryManager.<Refresh>d__8 : IAsyncStateMachine // TypeDefIndex: 12069
{	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder <>t__builder; // 0x8
	public SteamInventoryManager <>4__this; // 0x20
	private IReadOnlyList<IPlayerItem> <steamitems>5__2; // 0x28
	private int <itemIndex>5__3; // 0x30
	private TaskAwaiter<IPlayerInventory> <>u__1; // 0x38
	private IEnumerator<IPlayerItem> <>7__wrap3; // 0x40
	private IPlayerItem <item>5__5; // 0x48
	private TaskAwaiter <>u__2; // 0x50

	// Methods

	// RVA: 0xF2160 Offset: 0xF1560 VA: 0x1800F2160 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xF2060 Offset: 0xF1460 VA: 0x1800F2060 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

private struct SteamInventoryManager.<FixStacks>d__9 : IAsyncStateMachine // TypeDefIndex: 12070
{	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder <>t__builder; // 0x8
	public IReadOnlyCollection<IPlayerItem> steamitems; // 0x20
	public SteamInventoryManager <>4__this; // 0x28
	private bool <actionTaken>5__2; // 0x30
	private InventoryItem[] <>7__wrap2; // 0x38
	private int <>7__wrap3; // 0x40
	private TaskAwaiter<Nullable<InventoryResult>> <>u__1; // 0x48
	private TaskAwaiter <>u__2; // 0x50
	private IEnumerator<IGrouping<InventoryDefId, InventoryItem>> <>7__wrap4; // 0x58
	private IGrouping<InventoryDefId, InventoryItem> <group>5__6; // 0x60
	private IEnumerator<InventoryItem> <>7__wrap6; // 0x68

	// Methods

	// RVA: 0xF2080 Offset: 0xF1480 VA: 0x1800F2080 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xF2060 Offset: 0xF1460 VA: 0x1800F2060 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

public class SteamInventoryNewItem : MonoBehaviour // TypeDefIndex: 12071
{	// Methods

	[AsyncStateMachineAttribute] // RVA: 0xD6680 Offset: 0xD5A80 VA: 0x1800D6680
	// RVA: 0x4AB3E0 Offset: 0x4AA7E0 VA: 0x1804AB3E0
	public Task Open(IPlayerItem item) { }

	// RVA: 0x2F91F0 Offset: 0x2F85F0 VA: 0x1802F91F0
	public void .ctor() { }

}

private struct SteamInventoryNewItem.<Open>d__0 : IAsyncStateMachine // TypeDefIndex: 12072
{	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder <>t__builder; // 0x8
	public SteamInventoryNewItem <>4__this; // 0x20
	public IPlayerItem item; // 0x28
	private TaskAwaiter <>u__1; // 0x30

	// Methods

	// RVA: 0xF2150 Offset: 0xF1550 VA: 0x1800F2150 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xF2060 Offset: 0xF1460 VA: 0x1800F2060 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

