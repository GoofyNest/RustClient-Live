internal static class SteamAPI // TypeDefIndex: 5111
{
	internal static bool Init() { }

	internal static void Shutdown() { }

	internal static HSteamPipe GetHSteamPipe() { }

}

internal static class SteamAPI.Native // TypeDefIndex: 5112
{
	public static extern bool SteamAPI_Init() { }

	public static extern void SteamAPI_Shutdown() { }

	public static extern HSteamPipe SteamAPI_GetHSteamPipe() { }

}

internal enum SteamItemFlags // TypeDefIndex: 5167
{	public int value__; // 0x0
	public const SteamItemFlags NoTrade = 1;
	public const SteamItemFlags Removed = 256;
	public const SteamItemFlags Consumed = 512;

}

public enum SteamNetworkingAvailability // TypeDefIndex: 5168
{	public int value__; // 0x0
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
{	internal static ISteamApps Internal { get; }
	public static string GameLanguage { get; }
	public static string CurrentBetaName { get; }
	public static int BuildId { get; }


	internal static ISteamApps get_Internal() { }

	internal override void InitializeInterface(bool server) { }

	public static string get_GameLanguage() { }

	public static bool IsSubscribedToApp(AppId appid) { }

	public static bool IsDlcInstalled(AppId appid) { }

	public static string get_CurrentBetaName() { }

	public static int get_BuildId() { }

	public void .ctor() { }

}

public static class SteamClient // TypeDefIndex: 5184
{	private static bool initialized; // 0x0
	private static readonly List<SteamClass> openInterfaces; // 0x8
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private static AppId <AppId>k__BackingField; // 0x10

	public static bool IsValid { get; }
	public static bool IsLoggedOn { get; }
	public static SteamId SteamId { get; }
	public static string Name { get; }
	public static AppId AppId { get; set; }


	public static void Init(uint appid, bool asyncCallbacks = True) { }

	internal static void AddInterface<T>() { }
	/* GenericInstMethod :
	|
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

	internal static void ShutdownInterfaces() { }

	public static bool get_IsValid() { }

	public static void Shutdown() { }

	internal static void Cleanup() { }

	public static void RunCallbacks() { }

	public static bool get_IsLoggedOn() { }

	public static SteamId get_SteamId() { }

	public static string get_Name() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public static AppId get_AppId() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	internal static void set_AppId(AppId value) { }

	private static void .cctor() { }

}

public class SteamFriends : SteamClientClass<SteamFriends> // TypeDefIndex: 5185
{	private static Dictionary<string, string> richPresence; // 0x0
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

	internal static ISteamFriends Internal { get; }


	internal static ISteamFriends get_Internal() { }

	internal override void InitializeInterface(bool server) { }

	internal void InstallEvents() { }

	private static void OnFriendChatMessage(GameConnectedFriendChatMsg_t data) { }

	private static void OnGameConnectedClanChatMessage(GameConnectedClanChatMsg_t data) { }

	[IteratorStateMachineAttribute] // RVA: 0x8DFF0 Offset: 0x8D3F0 VA: 0x18008DFF0
	private static IEnumerable<Friend> GetFriendsWithFlag(FriendFlags flag) { }

	public static IEnumerable<Friend> GetFriends() { }

	public static void OpenUserOverlay(SteamId id, string type) { }

	public static void OpenStoreOverlay(AppId id, OverlayToStoreFlag overlayToStoreFlag = 0) { }

	public static void OpenWebOverlay(string url, bool modal = False) { }

	public static void SetPlayedWith(SteamId steamid) { }

	public static bool RequestUserInformation(SteamId steamid, bool nameonly = True) { }

	[AsyncStateMachineAttribute] // RVA: 0x8E070 Offset: 0x8D470 VA: 0x18008E070
	internal static Task CacheUserInformationAsync(SteamId steamid, bool nameonly) { }

	[AsyncStateMachineAttribute] // RVA: 0x8E360 Offset: 0x8D760 VA: 0x18008E360
	public static Task<Nullable<Image>> GetMediumAvatarAsync(SteamId steamid) { }

	public static string GetRichPresence(string key) { }

	public static bool SetRichPresence(string key, string value) { }

	public static void ClearRichPresence() { }

	public void .ctor() { }

}

private sealed class SteamFriends.<>c // TypeDefIndex: 5186
{	public static readonly SteamFriends.<>c <>9; // 0x0
	public static Action<PersonaStateChange_t> <>9__4_0; // 0x8
	public static Action<GameRichPresenceJoinRequested_t> <>9__4_1; // 0x10
	public static Action<GameOverlayActivated_t> <>9__4_2; // 0x18
	public static Action<GameServerChangeRequested_t> <>9__4_3; // 0x20
	public static Action<GameLobbyJoinRequested_t> <>9__4_4; // 0x28
	public static Action<FriendRichPresenceUpdate_t> <>9__4_5; // 0x30
	public static Action<OverlayBrowserProtocolNavigation_t> <>9__4_6; // 0x38


	private static void .cctor() { }

	public void .ctor() { }

	internal void <InstallEvents>b__4_0(PersonaStateChange_t x) { }

	internal void <InstallEvents>b__4_1(GameRichPresenceJoinRequested_t x) { }

	internal void <InstallEvents>b__4_2(GameOverlayActivated_t x) { }

	internal void <InstallEvents>b__4_3(GameServerChangeRequested_t x) { }

	internal void <InstallEvents>b__4_4(GameLobbyJoinRequested_t x) { }

	internal void <InstallEvents>b__4_5(FriendRichPresenceUpdate_t x) { }

	internal void <InstallEvents>b__4_6(OverlayBrowserProtocolNavigation_t x) { }

}

private sealed class SteamFriends.<GetFriendsWithFlag>d__34 : IEnumerable<Friend>, IEnumerable, IEnumerator<Friend>, IEnumerator, IDisposable // TypeDefIndex: 5187
{	private int <>1__state; // 0x10
	private Friend <>2__current; // 0x18
	private int <>l__initialThreadId; // 0x20
	private FriendFlags flag; // 0x24
	public FriendFlags <>3__flag; // 0x28
	private int <i>5__2; // 0x2C

	private Friend System.Collections.Generic.IEnumerator<Steamworks.Friend>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }


	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void System.IDisposable.Dispose() { }

	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Friend System.Collections.Generic.IEnumerator<Steamworks.Friend>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private IEnumerator<Friend> System.Collections.Generic.IEnumerable<Steamworks.Friend>.GetEnumerator() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

private struct SteamFriends.<CacheUserInformationAsync>d__51 : IAsyncStateMachine // TypeDefIndex: 5188
{	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder <>t__builder; // 0x8
	public SteamId steamid; // 0x20
	public bool nameonly; // 0x28
	private TaskAwaiter <>u__1; // 0x30


	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

private struct SteamFriends.<GetMediumAvatarAsync>d__53 : IAsyncStateMachine // TypeDefIndex: 5189
{	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder<Nullable<Image>> <>t__builder; // 0x8
	public SteamId steamid; // 0x20
	private TaskAwaiter <>u__1; // 0x28


	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

public class SteamInput : SteamClientClass<SteamInput> // TypeDefIndex: 5190
{	private static readonly InputHandle_t[] queryArray; // 0x0
	internal static Dictionary<string, InputDigitalActionHandle_t> DigitalHandles; // 0x8
	internal static Dictionary<string, InputAnalogActionHandle_t> AnalogHandles; // 0x10
	internal static Dictionary<string, InputActionSetHandle_t> ActionSets; // 0x18


	internal override void InitializeInterface(bool server) { }

	public void .ctor() { }

	private static void .cctor() { }

}

public class SteamInventory : SteamSharedClass<SteamInventory> // TypeDefIndex: 5191
{	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
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

	internal static ISteamInventory Internal { get; }
	public static string Currency { get; set; }
	public static InventoryItem[] Items { get; set; }
	public static InventoryDef[] Definitions { get; set; }


	internal static ISteamInventory get_Internal() { }

	internal override void InitializeInterface(bool server) { }

	internal static void InstallEvents(bool server) { }

	private static void InventoryUpdated(SteamInventoryFullUpdate_t x) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public static void add_OnInventoryUpdated(Action<InventoryResult> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public static void remove_OnInventoryUpdated(Action<InventoryResult> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public static void add_OnDefinitionsUpdated(Action value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public static void remove_OnDefinitionsUpdated(Action value) { }

	private static void LoadDefinitions() { }

	public static void LoadItemDefinitions() { }

	public static InventoryDef FindDefinition(InventoryDefId defId) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public static string get_Currency() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	internal static void set_Currency(string value) { }

	[AsyncStateMachineAttribute] // RVA: 0x8F8D0 Offset: 0x8ECD0 VA: 0x18008F8D0
	public static Task<InventoryDef[]> GetDefinitionsWithPricesAsync() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public static InventoryItem[] get_Items() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	internal static void set_Items(InventoryItem[] value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public static InventoryDef[] get_Definitions() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	internal static void set_Definitions(InventoryDef[] value) { }

	internal static InventoryDef[] GetDefinitions() { }

	public static bool GetAllItems() { }

	[AsyncStateMachineAttribute] // RVA: 0x8FEC0 Offset: 0x8F2C0 VA: 0x18008FEC0
	public static Task<Nullable<InventoryResult>> GetAllItemsAsync() { }

	[AsyncStateMachineAttribute] // RVA: 0x8FFC0 Offset: 0x8F3C0 VA: 0x18008FFC0
	public static Task<Nullable<InventoryResult>> CraftItemAsync(InventoryItem[] list, InventoryDef target) { }

	[AsyncStateMachineAttribute] // RVA: 0x900F0 Offset: 0x8F4F0 VA: 0x1800900F0
	public static Task<Nullable<InventoryResult>> CraftItemAsync(InventoryItem.Amount[] list, InventoryDef target) { }

	[AsyncStateMachineAttribute] // RVA: 0x90210 Offset: 0x8F610 VA: 0x180090210
	public static Task<Nullable<InventoryResult>> GrantPromoItemsAsync() { }

	[AsyncStateMachineAttribute] // RVA: 0x90380 Offset: 0x8F780 VA: 0x180090380
	public static Task<Nullable<InventoryResult>> TriggerItemDropAsync(InventoryDefId id) { }

	[AsyncStateMachineAttribute] // RVA: 0x905A0 Offset: 0x8F9A0 VA: 0x1800905A0
	public static Task<Nullable<InventoryPurchaseResult>> StartPurchaseAsync(InventoryDef[] items) { }

	public void .ctor() { }

}

private sealed class SteamInventory.<>c // TypeDefIndex: 5192
{	public static readonly SteamInventory.<>c <>9; // 0x0
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


	private static void .cctor() { }

	public void .ctor() { }

	internal void <InstallEvents>b__3_0(SteamInventoryFullUpdate_t x) { }

	internal void <InstallEvents>b__3_1(SteamInventoryDefinitionUpdate_t x) { }

	internal InventoryDef <GetDefinitionsWithPricesAsync>b__19_0(InventoryDefId x) { }

	internal InventoryDef <GetDefinitions>b__29_0(InventoryDefId x) { }

	internal InventoryItemId <CraftItemAsync>b__33_0(InventoryItem x) { }

	internal uint <CraftItemAsync>b__33_1(InventoryItem x) { }

	internal InventoryItemId <CraftItemAsync>b__34_0(InventoryItem.Amount x) { }

	internal uint <CraftItemAsync>b__34_1(InventoryItem.Amount x) { }

	internal InventoryDefId <StartPurchaseAsync>b__39_0(InventoryDef x) { }

	internal InventoryDefId <StartPurchaseAsync>b__39_1(IGrouping<InventoryDefId, InventoryDef> x) { }

	internal uint <StartPurchaseAsync>b__39_2(IGrouping<InventoryDefId, InventoryDef> x) { }

}

private struct SteamInventory.<GetDefinitionsWithPricesAsync>d__19 : IAsyncStateMachine // TypeDefIndex: 5193
{	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder<InventoryDef[]> <>t__builder; // 0x8
	private CallResult<SteamInventoryRequestPricesResult_t> <>u__1; // 0x20


	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

private struct SteamInventory.<GetAllItemsAsync>d__31 : IAsyncStateMachine // TypeDefIndex: 5194
{	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder<Nullable<InventoryResult>> <>t__builder; // 0x8
	private TaskAwaiter<Nullable<InventoryResult>> <>u__1; // 0x20


	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

private struct SteamInventory.<CraftItemAsync>d__33 : IAsyncStateMachine // TypeDefIndex: 5195
{	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder<Nullable<InventoryResult>> <>t__builder; // 0x8
	public InventoryDef target; // 0x20
	public InventoryItem[] list; // 0x28
	private TaskAwaiter<Nullable<InventoryResult>> <>u__1; // 0x30


	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

private struct SteamInventory.<CraftItemAsync>d__34 : IAsyncStateMachine // TypeDefIndex: 5196
{	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder<Nullable<InventoryResult>> <>t__builder; // 0x8
	public InventoryDef target; // 0x20
	public InventoryItem.Amount[] list; // 0x28
	private TaskAwaiter<Nullable<InventoryResult>> <>u__1; // 0x30


	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

private struct SteamInventory.<GrantPromoItemsAsync>d__36 : IAsyncStateMachine // TypeDefIndex: 5197
{	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder<Nullable<InventoryResult>> <>t__builder; // 0x8
	private TaskAwaiter<Nullable<InventoryResult>> <>u__1; // 0x20


	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

private struct SteamInventory.<TriggerItemDropAsync>d__37 : IAsyncStateMachine // TypeDefIndex: 5198
{	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder<Nullable<InventoryResult>> <>t__builder; // 0x8
	public InventoryDefId id; // 0x20
	private TaskAwaiter<Nullable<InventoryResult>> <>u__1; // 0x28


	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

private struct SteamInventory.<StartPurchaseAsync>d__39 : IAsyncStateMachine // TypeDefIndex: 5199
{	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder<Nullable<InventoryPurchaseResult>> <>t__builder; // 0x8
	public InventoryDef[] items; // 0x20
	private CallResult<SteamInventoryStartPurchaseResult_t> <>u__1; // 0x28


	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

public class SteamMatchmaking : SteamClientClass<SteamMatchmaking> // TypeDefIndex: 5200
{	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
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

	internal static ISteamMatchmaking Internal { get; }


	internal static ISteamMatchmaking get_Internal() { }

	internal override void InitializeInterface(bool server) { }

	internal static void InstallEvents() { }

	private static void OnLobbyChatMessageRecievedAPI(LobbyChatMsg_t callback) { }

	[IteratorStateMachineAttribute] // RVA: 0x93030 Offset: 0x92430 VA: 0x180093030
	public static IEnumerable<ServerInfo> GetFavoriteServers() { }

	public void .ctor() { }

}

private sealed class SteamMatchmaking.<>c // TypeDefIndex: 5201
{	public static readonly SteamMatchmaking.<>c <>9; // 0x0
	public static Action<LobbyInvite_t> <>9__5_0; // 0x8
	public static Action<LobbyEnter_t> <>9__5_1; // 0x10
	public static Action<LobbyCreated_t> <>9__5_2; // 0x18
	public static Action<LobbyGameCreated_t> <>9__5_3; // 0x20
	public static Action<LobbyDataUpdate_t> <>9__5_4; // 0x28
	public static Action<LobbyChatUpdate_t> <>9__5_5; // 0x30


	private static void .cctor() { }

	public void .ctor() { }

	internal void <InstallEvents>b__5_0(LobbyInvite_t x) { }

	internal void <InstallEvents>b__5_1(LobbyEnter_t x) { }

	internal void <InstallEvents>b__5_2(LobbyCreated_t x) { }

	internal void <InstallEvents>b__5_3(LobbyGameCreated_t x) { }

	internal void <InstallEvents>b__5_4(LobbyDataUpdate_t x) { }

	internal void <InstallEvents>b__5_5(LobbyChatUpdate_t x) { }

}

private sealed class SteamMatchmaking.<GetFavoriteServers>d__47 : IEnumerable<ServerInfo>, IEnumerable, IEnumerator<ServerInfo>, IEnumerator, IDisposable // TypeDefIndex: 5202
{	private int <>1__state; // 0x10
	private ServerInfo <>2__current; // 0x18
	private int <>l__initialThreadId; // 0x90
	private int <count>5__2; // 0x94
	private int <i>5__3; // 0x98

	private ServerInfo System.Collections.Generic.IEnumerator<Steamworks.Data.ServerInfo>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }


	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void System.IDisposable.Dispose() { }

	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private ServerInfo System.Collections.Generic.IEnumerator<Steamworks.Data.ServerInfo>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private IEnumerator<ServerInfo> System.Collections.Generic.IEnumerable<Steamworks.Data.ServerInfo>.GetEnumerator() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

internal class SteamMatchmakingServers : SteamClientClass<SteamMatchmakingServers> // TypeDefIndex: 5203
{	internal static ISteamMatchmakingServers Internal { get; }


	internal static ISteamMatchmakingServers get_Internal() { }

	internal override void InitializeInterface(bool server) { }

	public void .ctor() { }

}

public class SteamMusic : SteamClientClass<SteamMusic> // TypeDefIndex: 5204
{	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private static Action OnPlaybackChanged; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private static Action<float> OnVolumeChanged; // 0x8


	internal override void InitializeInterface(bool server) { }

	internal static void InstallEvents() { }

	public void .ctor() { }

}

private sealed class SteamMusic.<>c // TypeDefIndex: 5205
{	public static readonly SteamMusic.<>c <>9; // 0x0
	public static Action<PlaybackStatusHasChanged_t> <>9__3_0; // 0x8
	public static Action<VolumeHasChanged_t> <>9__3_1; // 0x10


	private static void .cctor() { }

	public void .ctor() { }

	internal void <InstallEvents>b__3_0(PlaybackStatusHasChanged_t x) { }

	internal void <InstallEvents>b__3_1(VolumeHasChanged_t x) { }

}

public class SteamNetworking : SteamSharedClass<SteamNetworking> // TypeDefIndex: 5206
{	public static Action<SteamId> OnP2PSessionRequest; // 0x0
	public static Action<SteamId, P2PSessionError> OnP2PConnectionFailed; // 0x8


	internal override void InitializeInterface(bool server) { }

	internal static void InstallEvents(bool server) { }

	public void .ctor() { }

}

private sealed class SteamNetworking.<>c // TypeDefIndex: 5207
{	public static readonly SteamNetworking.<>c <>9; // 0x0
	public static Action<P2PSessionRequest_t> <>9__3_0; // 0x8
	public static Action<P2PSessionConnectFail_t> <>9__3_1; // 0x10


	private static void .cctor() { }

	public void .ctor() { }

	internal void <InstallEvents>b__3_0(P2PSessionRequest_t x) { }

	internal void <InstallEvents>b__3_1(P2PSessionConnectFail_t x) { }

}

public class SteamNetworkingSockets : SteamSharedClass<SteamNetworkingSockets> // TypeDefIndex: 5208
{	private static readonly Dictionary<uint, SocketManager> SocketInterfaces; // 0x0
	private static readonly Dictionary<uint, ConnectionManager> ConnectionInterfaces; // 0x8
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private static Action<Connection, ConnectionInfo> OnConnectionStatusChanged; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private static Action<NetAddress> OnFakeIPResult; // 0x18

	internal static ISteamNetworkingSockets Internal { get; }
	public static NetIdentity Identity { get; }


	internal static ISteamNetworkingSockets get_Internal() { }

	public static NetIdentity get_Identity() { }

	internal override void InitializeInterface(bool server) { }

	internal static SocketManager GetSocketManager(uint id) { }

	internal static void SetSocketManager(uint id, SocketManager manager) { }

	internal static ConnectionManager GetConnectionManager(uint id) { }

	internal static void SetConnectionManager(uint id, ConnectionManager manager) { }

	internal void InstallEvents(bool server) { }

	private static void ConnectionStatusChanged(SteamNetConnectionStatusChangedCallback_t data) { }

	private static void FakeIPResult(SteamNetworkingFakeIPResult_t data) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public static void add_OnFakeIPResult(Action<NetAddress> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public static void remove_OnFakeIPResult(Action<NetAddress> value) { }

	public static SocketManager CreateNormalSocket(NetAddress address, ISocketManager intrface) { }

	public static ConnectionManager ConnectNormal(NetAddress address, IConnectionManager iface) { }

	public static Result GetFakeIP(int fakePortIndex, out NetAddress address) { }

	public static SocketManager CreateRelaySocketFakeIP(int fakePortIndex, ISocketManager intrface) { }

	public void .ctor() { }

	private static void .cctor() { }

}

public class SteamNetworkingUtils : SteamSharedClass<SteamNetworkingUtils> // TypeDefIndex: 5209
{	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private static Action<NetDebugOutput, string> OnDebugOutput; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private static SteamNetworkingAvailability <Status>k__BackingField; // 0x8
	private static NetDebugOutput _debugLevel; // 0xC
	private static NetDebugFunc _debugFunc; // 0x10
	private static ConcurrentQueue<SteamNetworkingUtils.DebugMessage> debugMessages; // 0x18

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


	internal static ISteamNetworkingUtils get_Internal() { }

	internal override void InitializeInterface(bool server) { }

	private static void InstallCallbacks(bool server) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public static void add_OnDebugOutput(Action<NetDebugOutput, string> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public static void remove_OnDebugOutput(Action<NetDebugOutput, string> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public static SteamNetworkingAvailability get_Status() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private static void set_Status(SteamNetworkingAvailability value) { }

	public static void InitRelayNetworkAccess() { }

	public static int get_ConnectionTimeout() { }

	public static void set_ConnectionTimeout(int value) { }

	public static void set_SendBufferSize(int value) { }

	public static void set_AllowWithoutAuth(int value) { }

	public static void set_Unencrypted(int value) { }

	public static int get_DebugLevelAckRTT() { }

	public static void set_DebugLevelAckRTT(int value) { }

	public static int get_DebugLevelPacketDecode() { }

	public static void set_DebugLevelPacketDecode(int value) { }

	public static int get_DebugLevelMessage() { }

	public static void set_DebugLevelMessage(int value) { }

	public static int get_DebugLevelPacketGaps() { }

	public static void set_DebugLevelPacketGaps(int value) { }

	public static int get_DebugLevelP2PRendezvous() { }

	public static void set_DebugLevelP2PRendezvous(int value) { }

	public static int get_DebugLevelSDRRelayPings() { }

	public static void set_DebugLevelSDRRelayPings(int value) { }

	public static NetDebugOutput get_DebugLevel() { }

	public static void set_DebugLevel(NetDebugOutput value) { }

	[MonoPInvokeCallbackAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private static void OnDebugMessage(NetDebugOutput nType, IntPtr str) { }

	internal static void LogDebugMessage(NetDebugOutput type, string message) { }

	internal static void OutputDebugMessages() { }

	internal static NetMsg* AllocateMessage() { }

	internal static bool SetConfigInt(NetConfig type, int value) { }

	internal static int GetConfigInt(NetConfig type) { }

	public void .ctor() { }

	private static void .cctor() { }

}

private struct SteamNetworkingUtils.DebugMessage // TypeDefIndex: 5210
{	public NetDebugOutput Type; // 0x0
	public string Msg; // 0x8

}

private sealed class SteamNetworkingUtils.<>c // TypeDefIndex: 5211
{	public static readonly SteamNetworkingUtils.<>c <>9; // 0x0
	public static Action<SteamRelayNetworkStatus_t> <>9__3_0; // 0x8


	private static void .cctor() { }

	public void .ctor() { }

	internal void <InstallCallbacks>b__3_0(SteamRelayNetworkStatus_t x) { }

}

public class SteamParental : SteamSharedClass<SteamParental> // TypeDefIndex: 5212
{	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private static Action OnSettingsChanged; // 0x2B0AA90


	internal override void InitializeInterface(bool server) { }

	internal static void InstallEvents(bool server) { }

	public void .ctor() { }

}

private sealed class SteamParental.<>c // TypeDefIndex: 5213
{	public static readonly SteamParental.<>c <>9; // 0x0
	public static Action<SteamParentalSettingsChanged_t> <>9__3_0; // 0x8


	private static void .cctor() { }

	public void .ctor() { }

	internal void <InstallEvents>b__3_0(SteamParentalSettingsChanged_t x) { }

}

public class SteamParties : SteamClientClass<SteamParties> // TypeDefIndex: 5214
{	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private static Action OnBeaconLocationsUpdated; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private static Action OnActiveBeaconsUpdated; // 0x8


	internal override void InitializeInterface(bool server) { }

	internal void InstallEvents(bool server) { }

	public void .ctor() { }

}

private sealed class SteamParties.<>c // TypeDefIndex: 5215
{	public static readonly SteamParties.<>c <>9; // 0x0
	public static Action<AvailableBeaconLocationsUpdated_t> <>9__3_0; // 0x8
	public static Action<ActiveBeaconsUpdated_t> <>9__3_1; // 0x10


	private static void .cctor() { }

	public void .ctor() { }

	internal void <InstallEvents>b__3_0(AvailableBeaconLocationsUpdated_t x) { }

	internal void <InstallEvents>b__3_1(ActiveBeaconsUpdated_t x) { }

}

public class SteamRemotePlay : SteamClientClass<SteamRemotePlay> // TypeDefIndex: 5216
{	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private static Action<RemotePlaySession> OnSessionConnected; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private static Action<RemotePlaySession> OnSessionDisconnected; // 0x8


	internal override void InitializeInterface(bool server) { }

	internal void InstallEvents(bool server) { }

	public void .ctor() { }

}

private sealed class SteamRemotePlay.<>c // TypeDefIndex: 5217
{	public static readonly SteamRemotePlay.<>c <>9; // 0x0
	public static Action<SteamRemotePlaySessionConnected_t> <>9__3_0; // 0x8
	public static Action<SteamRemotePlaySessionDisconnected_t> <>9__3_1; // 0x10


	private static void .cctor() { }

	public void .ctor() { }

	internal void <InstallEvents>b__3_0(SteamRemotePlaySessionConnected_t x) { }

	internal void <InstallEvents>b__3_1(SteamRemotePlaySessionDisconnected_t x) { }

}

public class SteamRemoteStorage : SteamClientClass<SteamRemoteStorage> // TypeDefIndex: 5218
{
	internal override void InitializeInterface(bool server) { }

	public void .ctor() { }

}

public class SteamScreenshots : SteamClientClass<SteamScreenshots> // TypeDefIndex: 5219
{	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private static Action OnScreenshotRequested; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private static Action<Screenshot> OnScreenshotReady; // 0x8
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private static Action<Result> OnScreenshotFailed; // 0x10

	internal static ISteamScreenshots Internal { get; }


	internal static ISteamScreenshots get_Internal() { }

	internal override void InitializeInterface(bool server) { }

	internal static void InstallEvents() { }

	public static void TriggerScreenshot() { }

	public void .ctor() { }

}

private sealed class SteamScreenshots.<>c // TypeDefIndex: 5220
{	public static readonly SteamScreenshots.<>c <>9; // 0x0
	public static Action<ScreenshotRequested_t> <>9__3_0; // 0x8
	public static Action<ScreenshotReady_t> <>9__3_1; // 0x10


	private static void .cctor() { }

	public void .ctor() { }

	internal void <InstallEvents>b__3_0(ScreenshotRequested_t x) { }

	internal void <InstallEvents>b__3_1(ScreenshotReady_t x) { }

}

public class SteamUGC : SteamSharedClass<SteamUGC> // TypeDefIndex: 5221
{	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private static Action<Result> OnDownloadItemResult; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private static Action<AppId, PublishedFileId> OnItemSubscribed; // 0x8
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private static Action<AppId, PublishedFileId> OnItemUnsubscribed; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private static Action<AppId, PublishedFileId> OnItemInstalled; // 0x18

	internal static ISteamUGC Internal { get; }


	internal static ISteamUGC get_Internal() { }

	internal override void InitializeInterface(bool server) { }

	internal static void InstallEvents(bool server) { }

	public static bool Download(PublishedFileId fileId, bool highPriority = False) { }

	[AsyncStateMachineAttribute] // RVA: 0x94AF0 Offset: 0x93EF0 VA: 0x180094AF0
	public static Task<Nullable<Item>> QueryFileAsync(PublishedFileId fileId) { }

	public void .ctor() { }

}

private sealed class SteamUGC.<>c // TypeDefIndex: 5222
{	public static readonly SteamUGC.<>c <>9; // 0x0
	public static Action<DownloadItemResult_t> <>9__3_0; // 0x8
	public static Action<RemoteStoragePublishedFileSubscribed_t> <>9__3_1; // 0x10
	public static Action<RemoteStoragePublishedFileUnsubscribed_t> <>9__3_2; // 0x18
	public static Action<ItemInstalled_t> <>9__3_3; // 0x20


	private static void .cctor() { }

	public void .ctor() { }

	internal void <InstallEvents>b__3_0(DownloadItemResult_t x) { }

	internal void <InstallEvents>b__3_1(RemoteStoragePublishedFileSubscribed_t x) { }

	internal void <InstallEvents>b__3_2(RemoteStoragePublishedFileUnsubscribed_t x) { }

	internal void <InstallEvents>b__3_3(ItemInstalled_t x) { }

}

private struct SteamUGC.<QueryFileAsync>d__19 : IAsyncStateMachine // TypeDefIndex: 5223
{	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder<Nullable<Item>> <>t__builder; // 0x8
	public PublishedFileId fileId; // 0x20
	private TaskAwaiter<Nullable<ResultPage>> <>u__1; // 0x28


	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

public class SteamUser : SteamClientClass<SteamUser> // TypeDefIndex: 5224
{	private static Dictionary<string, string> richPresence; // 0x0
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

	internal static ISteamUser Internal { get; }
	public static bool VoiceRecord { get; set; }
	public static bool HasVoiceData { get; }
	public static uint SampleRate { get; set; }
	public static uint OptimalSampleRate { get; }
	public static bool IsTwoFactorEnabled { get; }


	internal static ISteamUser get_Internal() { }

	internal override void InitializeInterface(bool server) { }

	internal static void InstallEvents() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	internal static void add_OnGetAuthSessionTicketResponse(Action<GetAuthSessionTicketResponse_t> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	internal static void remove_OnGetAuthSessionTicketResponse(Action<GetAuthSessionTicketResponse_t> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public static void add_OnMicroTxnAuthorizationResponse(Action<AppId, ulong, bool> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public static void remove_OnMicroTxnAuthorizationResponse(Action<AppId, ulong, bool> value) { }

	public static bool get_VoiceRecord() { }

	public static void set_VoiceRecord(bool value) { }

	public static bool get_HasVoiceData() { }

	public static byte[] ReadVoiceDataBytes() { }

	public static uint get_SampleRate() { }

	public static void set_SampleRate(uint value) { }

	public static uint get_OptimalSampleRate() { }

	public static int DecompressVoice(byte[] from, Stream output) { }

	public static AuthTicket GetAuthSessionTicket() { }

	[AsyncStateMachineAttribute] // RVA: 0x95760 Offset: 0x94B60 VA: 0x180095760
	public static Task<AuthTicket> GetAuthSessionTicketAsync(double timeoutSeconds = 10) { }

	public static bool get_IsTwoFactorEnabled() { }

	[AsyncStateMachineAttribute] // RVA: 0x95860 Offset: 0x94C60 VA: 0x180095860
	public static Task<byte[]> RequestEncryptedAppTicketAsync() { }

	public void .ctor() { }

	private static void .cctor() { }

}

private sealed class SteamUser.<>c // TypeDefIndex: 5225
{	public static readonly SteamUser.<>c <>9; // 0x0
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


	private static void .cctor() { }

	public void .ctor() { }

	internal void <InstallEvents>b__4_0(SteamServersConnected_t x) { }

	internal void <InstallEvents>b__4_1(SteamServerConnectFailure_t x) { }

	internal void <InstallEvents>b__4_2(SteamServersDisconnected_t x) { }

	internal void <InstallEvents>b__4_3(ClientGameServerDeny_t x) { }

	internal void <InstallEvents>b__4_4(LicensesUpdated_t x) { }

	internal void <InstallEvents>b__4_5(ValidateAuthTicketResponse_t x) { }

	internal void <InstallEvents>b__4_6(MicroTxnAuthorizationResponse_t x) { }

	internal void <InstallEvents>b__4_7(GameWebCallback_t x) { }

	internal void <InstallEvents>b__4_8(GetAuthSessionTicketResponse_t x) { }

	internal void <InstallEvents>b__4_9(DurationControl_t x) { }

}

private sealed class SteamUser.<>c__DisplayClass54_0 // TypeDefIndex: 5226
{	public AuthTicket ticket; // 0x10
	public Result result; // 0x18


	public void .ctor() { }

	internal void <GetAuthSessionTicketAsync>g__f|0(GetAuthSessionTicketResponse_t t) { }

}

private struct SteamUser.<GetAuthSessionTicketAsync>d__54 : IAsyncStateMachine // TypeDefIndex: 5227
{	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder<AuthTicket> <>t__builder; // 0x8
	public double timeoutSeconds; // 0x20
	private SteamUser.<>c__DisplayClass54_0 <>8__1; // 0x28
	private Stopwatch <stopwatch>5__2; // 0x30
	private TaskAwaiter <>u__1; // 0x38


	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

private struct SteamUser.<RequestEncryptedAppTicketAsync>d__71 : IAsyncStateMachine // TypeDefIndex: 5228
{	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder<byte[]> <>t__builder; // 0x8
	private CallResult<EncryptedAppTicketResponse_t> <>u__1; // 0x20


	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

public class SteamUserStats : SteamClientClass<SteamUserStats> // TypeDefIndex: 5229
{	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
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

	internal static ISteamUserStats Internal { get; }
	internal static bool StatsRecieved { set; }
	public static IEnumerable<Achievement> Achievements { get; }


	internal static ISteamUserStats get_Internal() { }

	internal override void InitializeInterface(bool server) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	internal static void set_StatsRecieved(bool value) { }

	internal static void InstallEvents() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public static void add_OnAchievementProgress(Action<Achievement, int, int> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public static void remove_OnAchievementProgress(Action<Achievement, int, int> value) { }

	[IteratorStateMachineAttribute] // RVA: 0x96510 Offset: 0x95910 VA: 0x180096510
	public static IEnumerable<Achievement> get_Achievements() { }

	public static bool StoreStats() { }

	public static bool RequestCurrentStats() { }

	public static bool SetStat(string name, int value) { }

	public static bool SetStat(string name, float value) { }

	public static int GetStatInt(string name) { }

	public static float GetStatFloat(string name) { }

	public static bool ResetAll(bool includeAchievements) { }

	public void .ctor() { }

}

private sealed class SteamUserStats.<>c // TypeDefIndex: 5230
{	public static readonly SteamUserStats.<>c <>9; // 0x0
	public static Action<UserStatsReceived_t> <>9__7_0; // 0x8
	public static Action<UserStatsStored_t> <>9__7_1; // 0x10
	public static Action<UserAchievementStored_t> <>9__7_2; // 0x18
	public static Action<UserStatsUnloaded_t> <>9__7_3; // 0x20
	public static Action<UserAchievementIconFetched_t> <>9__7_4; // 0x28


	private static void .cctor() { }

	public void .ctor() { }

	internal void <InstallEvents>b__7_0(UserStatsReceived_t x) { }

	internal void <InstallEvents>b__7_1(UserStatsStored_t x) { }

	internal void <InstallEvents>b__7_2(UserAchievementStored_t x) { }

	internal void <InstallEvents>b__7_3(UserStatsUnloaded_t x) { }

	internal void <InstallEvents>b__7_4(UserAchievementIconFetched_t x) { }

}

private sealed class SteamUserStats.<get_Achievements>d__24 : IEnumerable<Achievement>, IEnumerable, IEnumerator<Achievement>, IEnumerator, IDisposable // TypeDefIndex: 5231
{	private int <>1__state; // 0x10
	private Achievement <>2__current; // 0x18
	private int <>l__initialThreadId; // 0x20
	private int <i>5__2; // 0x24

	private Achievement System.Collections.Generic.IEnumerator<Steamworks.Data.Achievement>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }


	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void System.IDisposable.Dispose() { }

	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Achievement System.Collections.Generic.IEnumerator<Steamworks.Data.Achievement>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private IEnumerator<Achievement> System.Collections.Generic.IEnumerable<Steamworks.Data.Achievement>.GetEnumerator() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

public class SteamUtils : SteamSharedClass<SteamUtils> // TypeDefIndex: 5232
{	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private static Action OnIpCountryChanged; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private static Action<int> OnLowBatteryPower; // 0x8
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private static Action OnSteamShutdown; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private static Action<bool> OnGamepadTextInputDismissed; // 0x18
	private static NotificationPosition overlayNotificationPosition; // 0x20

	internal static ISteamUtils Internal { get; }
	public static string IpCountry { get; }
	public static bool IsOverlayEnabled { get; }


	internal static ISteamUtils get_Internal() { }

	internal override void InitializeInterface(bool server) { }

	internal static void InstallEvents(bool server) { }

	private static void SteamClosed() { }

	public static string get_IpCountry() { }

	public static bool GetImageSize(int image, out uint width, out uint height) { }

	public static Nullable<Image> GetImage(int image) { }

	public static bool get_IsOverlayEnabled() { }

	public static bool InitFilterText() { }

	public static string FilterText(TextFilteringContext context, SteamId sourceSteamID, string inputMessage) { }

	public void .ctor() { }

	private static void .cctor() { }

}

private sealed class SteamUtils.<>c // TypeDefIndex: 5233
{	public static readonly SteamUtils.<>c <>9; // 0x0
	public static Action<IPCountry_t> <>9__3_0; // 0x8
	public static Action<LowBatteryPower_t> <>9__3_1; // 0x10
	public static Action<SteamShutdown_t> <>9__3_2; // 0x18
	public static Action<GamepadTextInputDismissed_t> <>9__3_3; // 0x20


	private static void .cctor() { }

	public void .ctor() { }

	internal void <InstallEvents>b__3_0(IPCountry_t x) { }

	internal void <InstallEvents>b__3_1(LowBatteryPower_t x) { }

	internal void <InstallEvents>b__3_2(SteamShutdown_t x) { }

	internal void <InstallEvents>b__3_3(GamepadTextInputDismissed_t x) { }

}

public class SteamVideo : SteamClientClass<SteamVideo> // TypeDefIndex: 5234
{
	internal override void InitializeInterface(bool server) { }

	internal static void InstallEvents() { }

	public void .ctor() { }

}

public struct SteamId // TypeDefIndex: 5252
{	public ulong Value; // 0x0

	public uint AccountId { get; }


	public static SteamId op_Implicit(ulong value) { }

	public static ulong op_Implicit(SteamId value) { }

	public override string ToString() { }

	public uint get_AccountId() { }

}

internal abstract class SteamInterface // TypeDefIndex: 5266
{	public IntPtr Self; // 0x10
	public IntPtr SelfGlobal; // 0x18
	public IntPtr SelfServer; // 0x20
	public IntPtr SelfClient; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private bool <IsServer>k__BackingField; // 0x30

	public bool IsValid { get; }
	public bool IsServer { get; set; }


	public virtual IntPtr GetUserInterfacePointer() { }

	public virtual IntPtr GetServerInterfacePointer() { }

	public virtual IntPtr GetGlobalInterfacePointer() { }

	public bool get_IsValid() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public bool get_IsServer() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void set_IsServer(bool value) { }

	internal void SetupInterface(bool gameServer) { }

	protected void .ctor() { }

}

public abstract class SteamClass // TypeDefIndex: 5267
{
	internal abstract void InitializeInterface(bool server);

	internal abstract void DestroyInterface(bool server);

	protected void .ctor() { }

}

public class SteamSharedClass<T> : SteamClass // TypeDefIndex: 5268
{	internal static SteamInterface InterfaceClient; // 0x0
	internal static SteamInterface InterfaceServer; // 0x0

	internal static SteamInterface Interface { get; }


	internal static SteamInterface get_Interface() { }
	/* GenericInstMethod :
	|
	|-SteamSharedClass<SteamApps>.get_Interface
	|-SteamSharedClass<SteamInventory>.get_Interface
	|-SteamSharedClass<SteamNetworkingSockets>.get_Interface
	|-SteamSharedClass<SteamNetworkingUtils>.get_Interface
	|-SteamSharedClass<SteamUGC>.get_Interface
	|-SteamSharedClass<SteamUtils>.get_Interface
	|-SteamSharedClass<object>.get_Interface
	*/

	internal override void InitializeInterface(bool server) { }
	/* GenericInstMethod :
	|
	|-SteamSharedClass<object>.InitializeInterface
	*/

	internal virtual void SetInterface(bool server, SteamInterface iface) { }
	/* GenericInstMethod :
	|
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

	internal override void DestroyInterface(bool server) { }
	/* GenericInstMethod :
	|
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

	public void .ctor() { }
	/* GenericInstMethod :
	|
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
{	internal static SteamInterface Interface; // 0x0


	internal override void InitializeInterface(bool server) { }
	/* GenericInstMethod :
	|
	|-SteamClientClass<object>.InitializeInterface
	*/

	internal virtual void SetInterface(bool server, SteamInterface iface) { }
	/* GenericInstMethod :
	|
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

	internal override void DestroyInterface(bool server) { }
	/* GenericInstMethod :
	|
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

	public void .ctor() { }
	/* GenericInstMethod :
	|
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
{	public SteamParamStringArray_t Value; // 0x0
	private IntPtr[] NativeStrings; // 0x10
	private IntPtr NativeArray; // 0x18


	public static SteamParamStringArray From(string[] array) { }

	public void Dispose() { }

}

internal struct SteamServersConnected_t : ICallbackData // TypeDefIndex: 5293
{	public static int _datasize; // 0x2B0AAB0

	public int DataSize { get; }
	public CallbackType CallbackType { get; }


	public int get_DataSize() { }

	public CallbackType get_CallbackType() { }

	private static void .cctor() { }

}

internal struct SteamServerConnectFailure_t : ICallbackData // TypeDefIndex: 5294
{	internal Result Result; // 0x0
	internal bool StillRetrying; // 0x4
	public static int _datasize; // 0x0

	public int DataSize { get; }
	public CallbackType CallbackType { get; }


	public int get_DataSize() { }

	public CallbackType get_CallbackType() { }

	private static void .cctor() { }

}

internal struct SteamServersDisconnected_t : ICallbackData // TypeDefIndex: 5295
{	internal Result Result; // 0x0
	public static int _datasize; // 0x0

	public int DataSize { get; }
	public CallbackType CallbackType { get; }


	public int get_DataSize() { }

	public CallbackType get_CallbackType() { }

	private static void .cctor() { }

}

internal struct SteamAPICallCompleted_t : ICallbackData // TypeDefIndex: 5329
{	internal ulong AsyncCall; // 0x0
	internal int Callback; // 0x8
	internal uint ParamCount; // 0xC
	public static int _datasize; // 0x0

	public int DataSize { get; }
	public CallbackType CallbackType { get; }


	public int get_DataSize() { }

	public CallbackType get_CallbackType() { }

	private static void .cctor() { }

}

internal struct SteamShutdown_t : ICallbackData // TypeDefIndex: 5330
{	public static int _datasize; // 0x12BA0

	public int DataSize { get; }
	public CallbackType CallbackType { get; }


	public int get_DataSize() { }

	public CallbackType get_CallbackType() { }

	private static void .cctor() { }

}

internal struct SteamInputDeviceConnected_t : ICallbackData // TypeDefIndex: 5427
{	internal ulong ConnectedDeviceHandle; // 0x0
	public static int _datasize; // 0x0

	public int DataSize { get; }
	public CallbackType CallbackType { get; }


	public int get_DataSize() { }

	public CallbackType get_CallbackType() { }

	private static void .cctor() { }

}

internal struct SteamInputDeviceDisconnected_t : ICallbackData // TypeDefIndex: 5428
{	internal ulong DisconnectedDeviceHandle; // 0x0
	public static int _datasize; // 0x0

	public int DataSize { get; }
	public CallbackType CallbackType { get; }


	public int get_DataSize() { }

	public CallbackType get_CallbackType() { }

	private static void .cctor() { }

}

internal struct SteamInputConfigurationLoaded_t : ICallbackData // TypeDefIndex: 5429
{	internal AppId AppID; // 0x0
	internal ulong DeviceHandle; // 0x4
	internal ulong MappingCreator; // 0xC
	internal uint MajorRevision; // 0x14
	internal uint MinorRevision; // 0x18
	internal bool UsesSteamInputAPI; // 0x1C
	internal bool UsesGamepadAPI; // 0x1D
	public static int _datasize; // 0x0

	public int DataSize { get; }
	public CallbackType CallbackType { get; }


	public int get_DataSize() { }

	public CallbackType get_CallbackType() { }

	private static void .cctor() { }

}

internal struct SteamUGCQueryCompleted_t : ICallbackData // TypeDefIndex: 5430
{	internal ulong Handle; // 0x0
	internal Result Result; // 0x8
	internal uint NumResultsReturned; // 0xC
	internal uint TotalMatchingResults; // 0x10
	internal bool CachedData; // 0x14
	internal byte[] NextCursor; // 0x18
	public static int _datasize; // 0x0

	public int DataSize { get; }
	public CallbackType CallbackType { get; }


	public int get_DataSize() { }

	public CallbackType get_CallbackType() { }

	private static void .cctor() { }

}

internal struct SteamUGCRequestUGCDetailsResult_t : ICallbackData // TypeDefIndex: 5431
{	internal SteamUGCDetails_t Details; // 0x0
	internal bool CachedData; // 0x88
	public static int _datasize; // 0x0

	public int DataSize { get; }
	public CallbackType CallbackType { get; }


	public int get_DataSize() { }

	public CallbackType get_CallbackType() { }

	private static void .cctor() { }

}

internal struct SteamAppInstalled_t : ICallbackData // TypeDefIndex: 5449
{	internal AppId AppID; // 0x0
	internal int InstallFolderIndex; // 0x4
	public static int _datasize; // 0x0

	public int DataSize { get; }
	public CallbackType CallbackType { get; }


	public int get_DataSize() { }

	public CallbackType get_CallbackType() { }

	private static void .cctor() { }

}

internal struct SteamAppUninstalled_t : ICallbackData // TypeDefIndex: 5450
{	internal AppId AppID; // 0x0
	internal int InstallFolderIndex; // 0x4
	public static int _datasize; // 0x0

	public int DataSize { get; }
	public CallbackType CallbackType { get; }


	public int get_DataSize() { }

	public CallbackType get_CallbackType() { }

	private static void .cctor() { }

}

internal struct SteamInventoryResultReady_t : ICallbackData // TypeDefIndex: 5474
{	internal int Handle; // 0x0
	internal Result Result; // 0x4
	public static int _datasize; // 0x0

	public int DataSize { get; }
	public CallbackType CallbackType { get; }


	public int get_DataSize() { }

	public CallbackType get_CallbackType() { }

	private static void .cctor() { }

}

internal struct SteamInventoryFullUpdate_t : ICallbackData // TypeDefIndex: 5475
{	internal int Handle; // 0x0
	public static int _datasize; // 0x0

	public int DataSize { get; }
	public CallbackType CallbackType { get; }


	public int get_DataSize() { }

	public CallbackType get_CallbackType() { }

	private static void .cctor() { }

}

internal struct SteamInventoryDefinitionUpdate_t : ICallbackData // TypeDefIndex: 5476
{	public static int _datasize; // 0x2B0AAB0

	public int DataSize { get; }
	public CallbackType CallbackType { get; }


	public int get_DataSize() { }

	public CallbackType get_CallbackType() { }

	private static void .cctor() { }

}

internal struct SteamInventoryEligiblePromoItemDefIDs_t : ICallbackData // TypeDefIndex: 5477
{	internal Result Result; // 0x0
	internal ulong SteamID; // 0x4
	internal int UmEligiblePromoItemDefs; // 0xC
	internal bool CachedData; // 0x10
	public static int _datasize; // 0x0

	public int DataSize { get; }
	public CallbackType CallbackType { get; }


	public int get_DataSize() { }

	public CallbackType get_CallbackType() { }

	private static void .cctor() { }

}

internal struct SteamInventoryStartPurchaseResult_t : ICallbackData // TypeDefIndex: 5478
{	internal Result Result; // 0x0
	internal ulong OrderID; // 0x8
	internal ulong TransID; // 0x10
	public static int _datasize; // 0x0

	public int DataSize { get; }
	public CallbackType CallbackType { get; }


	public int get_DataSize() { }

	public CallbackType get_CallbackType() { }

	private static void .cctor() { }

}

internal struct SteamInventoryRequestPricesResult_t : ICallbackData // TypeDefIndex: 5479
{	internal Result Result; // 0x0
	internal byte[] Currency; // 0x8
	public static int _datasize; // 0x0

	public int DataSize { get; }
	public CallbackType CallbackType { get; }


	internal string CurrencyUTF8() { }

	public int get_DataSize() { }

	public CallbackType get_CallbackType() { }

	private static void .cctor() { }

}

internal struct SteamParentalSettingsChanged_t : ICallbackData // TypeDefIndex: 5482
{	public static int _datasize; // 0x12E30

	public int DataSize { get; }
	public CallbackType CallbackType { get; }


	public int get_DataSize() { }

	public CallbackType get_CallbackType() { }

	private static void .cctor() { }

}

internal struct SteamRemotePlaySessionConnected_t : ICallbackData // TypeDefIndex: 5483
{	internal uint SessionID; // 0x0
	public static int _datasize; // 0x0

	public int DataSize { get; }
	public CallbackType CallbackType { get; }


	public int get_DataSize() { }

	public CallbackType get_CallbackType() { }

	private static void .cctor() { }

}

internal struct SteamRemotePlaySessionDisconnected_t : ICallbackData // TypeDefIndex: 5484
{	internal uint SessionID; // 0x0
	public static int _datasize; // 0x0

	public int DataSize { get; }
	public CallbackType CallbackType { get; }


	public int get_DataSize() { }

	public CallbackType get_CallbackType() { }

	private static void .cctor() { }

}

internal struct SteamNetworkingMessagesSessionRequest_t : ICallbackData // TypeDefIndex: 5485
{	internal NetIdentity DentityRemote; // 0x0
	public static int _datasize; // 0x0

	public int DataSize { get; }
	public CallbackType CallbackType { get; }


	public int get_DataSize() { }

	public CallbackType get_CallbackType() { }

	private static void .cctor() { }

}

internal struct SteamNetworkingMessagesSessionFailed_t : ICallbackData // TypeDefIndex: 5486
{	internal ConnectionInfo Nfo; // 0x0
	public static int _datasize; // 0x0

	public int DataSize { get; }
	public CallbackType CallbackType { get; }


	public int get_DataSize() { }

	public CallbackType get_CallbackType() { }

	private static void .cctor() { }

}

internal struct SteamNetConnectionStatusChangedCallback_t : ICallbackData // TypeDefIndex: 5487
{	internal Connection Conn; // 0x0
	internal ConnectionInfo Nfo; // 0x8
	internal ConnectionState OldState; // 0x2C0
	public static int _datasize; // 0x0

	public int DataSize { get; }
	public CallbackType CallbackType { get; }


	public int get_DataSize() { }

	public CallbackType get_CallbackType() { }

	private static void .cctor() { }

}

internal struct SteamNetAuthenticationStatus_t : ICallbackData // TypeDefIndex: 5488
{	internal SteamNetworkingAvailability Avail; // 0x0
	internal byte[] DebugMsg; // 0x8
	public static int _datasize; // 0x0

	public int DataSize { get; }
	public CallbackType CallbackType { get; }


	public int get_DataSize() { }

	public CallbackType get_CallbackType() { }

	private static void .cctor() { }

}

internal struct SteamRelayNetworkStatus_t : ICallbackData // TypeDefIndex: 5489
{	internal SteamNetworkingAvailability Avail; // 0x0
	internal int PingMeasurementInProgress; // 0x4
	internal SteamNetworkingAvailability AvailNetworkConfig; // 0x8
	internal SteamNetworkingAvailability AvailAnyRelay; // 0xC
	internal byte[] DebugMsg; // 0x10
	public static int _datasize; // 0x0

	public int DataSize { get; }
	public CallbackType CallbackType { get; }


	public int get_DataSize() { }

	public CallbackType get_CallbackType() { }

	private static void .cctor() { }

}

internal struct SteamNetworkingFakeIPResult_t : ICallbackData // TypeDefIndex: 5502
{	internal Result Result; // 0x0
	internal NetIdentity Dentity; // 0x4
	internal uint IP; // 0x8C
	internal ushort[] Ports; // 0x90
	public static int _datasize; // 0x0

	public int DataSize { get; }
	public CallbackType CallbackType { get; }


	public int get_DataSize() { }

	public CallbackType get_CallbackType() { }

	private static void .cctor() { }

}

internal struct SteamParamStringArray_t // TypeDefIndex: 5514
{	internal IntPtr Strings; // 0x0
	internal int NumStrings; // 0x8

}

internal struct SteamUGCDetails_t // TypeDefIndex: 5515
{	internal PublishedFileId PublishedFileId; // 0x0
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


	internal string TitleUTF8() { }

	internal string DescriptionUTF8() { }

	internal string TagsUTF8() { }

}

internal struct SteamItemDetails_t // TypeDefIndex: 5516
{	internal InventoryItemId ItemId; // 0x0
	internal InventoryDefId Definition; // 0x8
	internal ushort Quantity; // 0xC
	internal ushort Flags; // 0xE

}

internal struct SteamAPICall_t : IEquatable<SteamAPICall_t>, IComparable<SteamAPICall_t> // TypeDefIndex: 5518
{	public ulong Value; // 0x0


	public static SteamAPICall_t op_Implicit(ulong value) { }

	public override string ToString() { }

	public override int GetHashCode() { }

	public override bool Equals(object p) { }

	public bool Equals(SteamAPICall_t p) { }

	public int CompareTo(SteamAPICall_t other) { }

}

internal struct SteamInventoryResult_t : IEquatable<SteamInventoryResult_t>, IComparable<SteamInventoryResult_t> // TypeDefIndex: 5539
{	public int Value; // 0x0


	public static SteamInventoryResult_t op_Implicit(int value) { }

	public override string ToString() { }

	public override int GetHashCode() { }

	public override bool Equals(object p) { }

	public bool Equals(SteamInventoryResult_t p) { }

	public int CompareTo(SteamInventoryResult_t other) { }

}

internal struct SteamInventoryUpdateHandle_t : IEquatable<SteamInventoryUpdateHandle_t>, IComparable<SteamInventoryUpdateHandle_t> // TypeDefIndex: 5540
{	public ulong Value; // 0x0


	public static SteamInventoryUpdateHandle_t op_Implicit(ulong value) { }

	public override string ToString() { }

	public override int GetHashCode() { }

	public override bool Equals(object p) { }

	public bool Equals(SteamInventoryUpdateHandle_t p) { }

	public int CompareTo(SteamInventoryUpdateHandle_t other) { }

}

internal struct SteamNetworkingPOPID : IEquatable<SteamNetworkingPOPID>, IComparable<SteamNetworkingPOPID> // TypeDefIndex: 5542
{	public uint Value; // 0x0


	public static SteamNetworkingPOPID op_Implicit(uint value) { }

	public override string ToString() { }

	public override int GetHashCode() { }

	public override bool Equals(object p) { }

	public bool Equals(SteamNetworkingPOPID p) { }

	public int CompareTo(SteamNetworkingPOPID other) { }

}

public class SteamAchievement : IAchievement // TypeDefIndex: 5710
{
public class SteamAchievement : IAchievement // TypeDefIndex: 5710
	private Achievement _achievement; // 0x10

	public string Key { get; }
	public bool IsUnlocked { get; }


	public string get_Key() { }

	public bool get_IsUnlocked() { }

	internal void .ctor(Achievement achievement) { }

	public void Unlock() { }

}

public class SteamAuthTicket : IAuthTicket, IDisposable // TypeDefIndex: 5711
{	private readonly AuthTicket _ticket; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private readonly string <Token>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private readonly byte[] <Data>k__BackingField; // 0x20

	public string Token { get; }
	public byte[] Data { get; }


	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public string get_Token() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public byte[] get_Data() { }

	internal void .ctor(AuthTicket ticket) { }

	public void Dispose() { }

}

public class SteamDownloadableContent : IDownloadableContent // TypeDefIndex: 5712
{	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private readonly int <AppId>k__BackingField; // 0x10

	public int AppId { get; }
	public bool IsInstalled { get; }


	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public int get_AppId() { }

	public bool get_IsInstalled() { }

	public void .ctor(int appId) { }

}

public class SteamInventory : IPlayerInventory, IDisposable // TypeDefIndex: 5713
{	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private readonly InventoryResult <Value>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private readonly IReadOnlyList<IPlayerItem> <Items>k__BackingField; // 0x18

	public InventoryResult Value { get; }
	public IReadOnlyList<IPlayerItem> Items { get; }


	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public InventoryResult get_Value() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public IReadOnlyList<IPlayerItem> get_Items() { }

	internal void .ctor(InventoryResult inventory) { }

	public void Dispose() { }

	public bool BelongsTo(ulong userId) { }

	public byte[] Serialize() { }

}

private sealed class SteamInventory.<>c // TypeDefIndex: 5714
{	public static readonly SteamInventory.<>c <>9; // 0x0
	public static Func<InventoryItem, SteamItem> <>9__6_0; // 0x8


	private static void .cctor() { }

	public void .ctor() { }

	internal SteamItem <.ctor>b__6_0(InventoryItem i) { }

}

public class SteamItem : IPlayerItem // TypeDefIndex: 5715
{	public InventoryItem Value; // 0x10

	public int DefinitionId { get; }
	public int Quantity { get; }
	public DateTimeOffset Acquired { get; }
	public ulong WorkshopId { get; }
	public string ItemShortName { get; }


	public void .ctor(InventoryItem item) { }

	public int get_DefinitionId() { }

	public int get_Quantity() { }

	public DateTimeOffset get_Acquired() { }

	public ulong get_WorkshopId() { }

	public string get_ItemShortName() { }

}

public class SteamItemDefinition : IPlayerItemDefinition, IEquatable<IPlayerItemDefinition> // TypeDefIndex: 5716
{	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private readonly InventoryDef <Value>k__BackingField; // 0x10

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


	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public InventoryDef get_Value() { }

	internal void .ctor(InventoryDef value) { }

	public int get_DefinitionId() { }

	public string get_Name() { }

	public string get_Description() { }

	public string get_Type() { }

	public string get_IconUrl() { }

	public int get_LocalPrice() { }

	public string get_LocalPriceFormatted() { }

	public string get_PriceCategory() { }

	public bool get_IsGenerator() { }

	public bool get_IsMarketable() { }

	public string get_StoreTags() { }

	public string get_ItemShortName() { }

	public ulong get_WorkshopId() { }

	public ulong get_WorkshopDownload() { }

	public IEnumerable<PlayerItemRecipe> GetRecipesContainingThis() { }

	private static PlayerItemRecipe SteamToPlatformRecipe(InventoryRecipe recipe) { }

	public bool Equals(IPlayerItemDefinition other) { }

	public override bool Equals(object obj) { }

	public override int GetHashCode() { }

}

private sealed class SteamItemDefinition.<>c // TypeDefIndex: 5717
{	public static readonly SteamItemDefinition.<>c <>9; // 0x0
	public static Func<InventoryRecipe.Ingredient, PlayerItemRecipe.Ingredient> <>9__33_0; // 0x8


	private static void .cctor() { }

	public void .ctor() { }

	internal PlayerItemRecipe.Ingredient <SteamToPlatformRecipe>b__33_0(InventoryRecipe.Ingredient i) { }

}

public class SteamPlatform : IPlatformService // TypeDefIndex: 5718
{	private readonly AvatarCache _avatars; // 0x10
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


	[AsyncStateMachineAttribute] // RVA: 0xCAE60 Offset: 0xCA260 VA: 0x1800CAE60
	private static void LoadAvatarFromSteamAsync(ulong userId, Texture2D texture) { }

	public Texture2D GetAvatarTexture(ulong userId) { }

	public IDownloadableContent GetDownloadableContent(int appId) { }

	public IWorkshopContent GetWorkshopContent(ulong workshopId) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public IReadOnlyList<IPlayerItemDefinition> get_ItemDefinitions() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void set_ItemDefinitions(IReadOnlyList<IPlayerItemDefinition> value) { }

	public void RefreshItemDefinitions() { }

	public IPlayerItemDefinition GetItemDefinition(int definitionId) { }

	private void OnDefinitionsUpdated() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public IReadOnlyList<IPlayerItem> get_Items() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void set_Items(IReadOnlyList<IPlayerItem> value) { }

	public void RefreshItems() { }

	[AsyncStateMachineAttribute] // RVA: 0xCB250 Offset: 0xCA650 VA: 0x1800CB250
	public Task<IPlayerInventory> RefreshAndGetItems() { }

	[AsyncStateMachineAttribute] // RVA: 0xCB460 Offset: 0xCA860 VA: 0x1800CB460
	public Task<IPlayerInventory> CraftItem(IEnumerable<IPlayerItem> inputs, IPlayerItemDefinition output) { }

	[AsyncStateMachineAttribute] // RVA: 0xCB770 Offset: 0xCAB70 VA: 0x1800CB770
	public Task<List<IPlayerItemDefinition>> GetItemDefinitionsWithPrices() { }

	public string FormatPrice(int price) { }

	private void OnInventoryUpdated(InventoryResult result) { }

	private void ConfiscatedItems() { }

	[AsyncStateMachineAttribute] // RVA: 0xCB9F0 Offset: 0xCADF0 VA: 0x1800CB9F0
	private Task InventoryDropAsync() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public ulong get_UserId() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void set_UserId(ulong value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public string get_UserName() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void set_UserName(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public string get_Country() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void set_Country(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public string get_Language() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void set_Language(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public string get_Version() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void set_Version(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public string get_Branch() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void set_Branch(string value) { }

	public IAuthTicket GetAuthSessionTicket() { }

	[AsyncStateMachineAttribute] // RVA: 0xCC840 Offset: 0xCBC40 VA: 0x1800CC840
	public Task<IAuthTicket> GetAuthSessionTicketAsync() { }

	public IEnumerable<IPlayerInfo> get_Friends() { }

	public IPlayerInfo GetPlayerInformation(ulong userId) { }

	[AsyncStateMachineAttribute] // RVA: 0xCCA50 Offset: 0xCBE50 VA: 0x1800CCA50
	public Task<IPlayerInfo> GetPlayerInformationAsync(ulong userId) { }

	private SteamPlayer GetOrAddPlayer(ulong userId) { }

	public string FilterChat(ulong userId, string message) { }

	public string FilterName(ulong userId, string message) { }

	public string FilterGeneric(string message) { }

	public void ClearRichPresence() { }

	public string GetRichPresence(string key) { }

	public void SetRichPresence(string key, string value) { }

	public IServerQuery CreateServerQuery(ServerQuerySet querySet) { }

	public IServerQuery CreateServerQuery(IEnumerable<string> endpoints) { }

	public void AddServerToHistory(ServerInfo server) { }

	public void RemoveServerFromHistory(ServerInfo server) { }

	public IReadOnlyList<ServerInfo> get_FavoriteServers() { }

	public void AddServerToFavorites(ServerInfo server) { }

	public void RemoveServerFromFavorites(ServerInfo server) { }

	internal static ServerInfo ToPlatformServer(ServerInfo info) { }

	internal static ServerInfo ToSteamServer(ServerInfo server) { }

	public IAchievement GetAchievement(string key) { }

	public void RequestCurrentStats() { }

	public long GetGlobalStatInt(string key) { }

	public long GetPlayerStatInt(string key) { }

	public void SetPlayerStatInt(string key, long value) { }

	public double GetGlobalStatFloat(string key) { }

	public double GetPlayerStatFloat(string key) { }

	public void SetPlayerStatFloat(string key, double value) { }

	public uint get_OptimalSampleRate() { }

	public bool get_VoiceRecord() { }

	public void set_VoiceRecord(bool value) { }

	public bool get_HasVoiceData() { }

	public byte[] GetCompressedVoiceData() { }

	public int DecompressVoiceData(byte[] data, MemoryStream outputStream) { }

	public bool get_IsValid() { }

	public bool Initialize(IPlatformHooks hooks) { }

	public void Shutdown() { }

	public void Update() { }

	private static AuthResponse RemapAuthResponse(AuthResponse response) { }

	private static void DebugPrintSteamCallback(CallbackType type, string content, bool isServer) { }

	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private SteamPlayer <get_Friends>b__55_0(Friend f) { }

}

private struct SteamPlatform.<LoadAvatarFromSteamAsync>d__1 : IAsyncStateMachine // TypeDefIndex: 5719
{	public int <>1__state; // 0x0
	public AsyncVoidMethodBuilder <>t__builder; // 0x8
	public ulong userId; // 0x28
	public Texture2D texture; // 0x30
	private TaskAwaiter<Nullable<Image>> <>u__1; // 0x38


	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

private sealed class SteamPlatform.<>c // TypeDefIndex: 5720
{	public static readonly SteamPlatform.<>c <>9; // 0x0
	public static Func<InventoryDef, SteamItemDefinition> <>9__13_0; // 0x8
	public static Func<SteamItem, InventoryItem> <>9__20_0; // 0x10
	public static Func<InventoryDef, IPlayerItemDefinition> <>9__21_0; // 0x18
	public static Action<Exception> <>9__97_0; // 0x20


	private static void .cctor() { }

	public void .ctor() { }

	internal SteamItemDefinition <OnDefinitionsUpdated>b__13_0(InventoryDef d) { }

	internal InventoryItem <CraftItem>b__20_0(SteamItem i) { }

	internal IPlayerItemDefinition <GetItemDefinitionsWithPrices>b__21_0(InventoryDef d) { }

	internal void <Initialize>b__97_0(Exception e) { }

}

private struct SteamPlatform.<RefreshAndGetItems>d__19 : IAsyncStateMachine // TypeDefIndex: 5721
{	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder<IPlayerInventory> <>t__builder; // 0x8
	private TaskAwaiter<Nullable<InventoryResult>> <>u__1; // 0x20


	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

private struct SteamPlatform.<CraftItem>d__20 : IAsyncStateMachine // TypeDefIndex: 5722
{	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder<IPlayerInventory> <>t__builder; // 0x8
	public IEnumerable<IPlayerItem> inputs; // 0x20
	public IPlayerItemDefinition output; // 0x28
	private TaskAwaiter<Nullable<InventoryResult>> <>u__1; // 0x30


	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

private struct SteamPlatform.<GetItemDefinitionsWithPrices>d__21 : IAsyncStateMachine // TypeDefIndex: 5723
{	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder<List<IPlayerItemDefinition>> <>t__builder; // 0x8
	private TaskAwaiter<InventoryDef[]> <>u__1; // 0x20


	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

private struct SteamPlatform.<InventoryDropAsync>d__26 : IAsyncStateMachine // TypeDefIndex: 5724
{	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder <>t__builder; // 0x8
	private TaskAwaiter <>u__1; // 0x20
	private TaskAwaiter<Nullable<InventoryResult>> <>u__2; // 0x28


	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

private struct SteamPlatform.<GetAuthSessionTicketAsync>d__53 : IAsyncStateMachine // TypeDefIndex: 5725
{	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder<IAuthTicket> <>t__builder; // 0x8
	private TaskAwaiter<AuthTicket> <>u__1; // 0x20


	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

private struct SteamPlatform.<GetPlayerInformationAsync>d__57 : IAsyncStateMachine // TypeDefIndex: 5726
{	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder<IPlayerInfo> <>t__builder; // 0x8
	public SteamPlatform <>4__this; // 0x20
	public ulong userId; // 0x28
	private SteamPlayer <player>5__2; // 0x30
	private TaskAwaiter <>u__1; // 0x38


	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

public class SteamPlayer : IPlayerInfo // TypeDefIndex: 5727
{	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private readonly Friend <Value>k__BackingField; // 0x10

	public Friend Value { get; }
	public ulong UserId { get; }
	public string UserName { get; }
	public bool IsOnline { get; }
	public bool IsMe { get; }
	public bool IsFriend { get; }
	public bool IsPlayingThisGame { get; }
	public string ServerEndpoint { get; }


	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public Friend get_Value() { }

	public ulong get_UserId() { }

	public string get_UserName() { }

	public bool get_IsOnline() { }

	public bool get_IsMe() { }

	public bool get_IsFriend() { }

	public bool get_IsPlayingThisGame() { }

	public string get_ServerEndpoint() { }

	public void .ctor(Friend value) { }

}

public class SteamServerQuery : IServerQuery, IDisposable // TypeDefIndex: 5728
{	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private readonly ServerQuerySet <QuerySet>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Base <Query>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private readonly IReadOnlyList<ServerInfo> <Servers>k__BackingField; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Action<ServerInfo> OnServerFound; // 0x28

	public ServerQuerySet QuerySet { get; }
	public Base Query { get; set; }
	public IReadOnlyList<ServerInfo> Servers { get; }


	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public ServerQuerySet get_QuerySet() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public Base get_Query() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void set_Query(Base value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public IReadOnlyList<ServerInfo> get_Servers() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void add_OnServerFound(Action<ServerInfo> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void remove_OnServerFound(Action<ServerInfo> value) { }

	public void .ctor(ServerQuerySet set, Base query) { }

	public void Dispose() { }

	public void AddFilter(string key, string value) { }

	public Task RunQueryAsync(double timeoutInSeconds) { }

}

private sealed class SteamServerQuery.<>c__DisplayClass13_0 // TypeDefIndex: 5729
{	public List<ServerInfo> serverList; // 0x10
	public SteamServerQuery <>4__this; // 0x18


	public void .ctor() { }

	internal void <.ctor>b__0() { }

}

public static class SteamUtil // TypeDefIndex: 5730
{	private static string _betaNameFull; // 0x0
	private static string _betaNameType; // 0x8

	public static string betaName { get; }
	public static string betaBranch { get; }


	public static string get_betaName() { }

	public static string get_betaBranch() { }

	private static string GetBetaName(bool full) { }

	private static void .cctor() { }

}

public class SteamWorkshopContent : IWorkshopContent // TypeDefIndex: 5731
{	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private readonly Item <Value>k__BackingField; // 0x10

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


	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public Item get_Value() { }

	public ulong get_WorkshopId() { }

	public string get_Title() { }

	public string get_Description() { }

	public IEnumerable<string> get_Tags() { }

	public string get_Url() { }

	public string get_PreviewImageUrl() { }

	public ulong get_OwnerId() { }

	public IPlayerInfo get_Owner() { }

	public bool get_IsInstalled() { }

	public bool get_IsDownloadPending() { }

	public bool get_IsDownloading() { }

	public string get_Directory() { }

	public void .ctor(Item item) { }

	public bool Download() { }

}

public static class SteamNetworking // TypeDefIndex: 7362
{
[ConsoleSystem.Factory] // RVA: 0x80B80 Offset: 0x7FF80 VA: 0x180080B80
public static class SteamNetworking // TypeDefIndex: 7362
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


	public static SendType ToSteamSendType(SendMethod method, Priority priority) { }

	public static ushort ToSteamLaneIndexServer(SendMethod method, Priority priority, sbyte channel) { }

	public static ushort ToSteamLaneIndexClient(SendMethod method, Priority priority, sbyte channel) { }

	public static void InitRelayNetworkAccess() { }

	public static void SetDebugFunction() { }

	private static void SteamNetworkingUtils_OnDebugOutput(NetDebugOutput type, string str) { }

	[ClientVar] // RVA: 0x93490 Offset: 0x92890 VA: 0x180093490
	[ServerVar] // RVA: 0x93490 Offset: 0x92890 VA: 0x180093490
	public static string steamstatus() { }

	[ClientVar] // RVA: 0x93490 Offset: 0x92890 VA: 0x180093490
	[ServerVar] // RVA: 0x93490 Offset: 0x92890 VA: 0x180093490
	public static void steamrelayinit() { }

	public static int get_steamnetdebug() { }

	public static void set_steamnetdebug(int value) { }

	public static int get_steamnetdebug_ackrtt() { }

	public static void set_steamnetdebug_ackrtt(int value) { }

	public static int get_steamnetdebug_packetdecode() { }

	public static void set_steamnetdebug_packetdecode(int value) { }

	public static int get_steamnetdebug_message() { }

	public static void set_steamnetdebug_message(int value) { }

	public static int get_steamnetdebug_packetgaps() { }

	public static void set_steamnetdebug_packetgaps(int value) { }

	public static int get_steamnetdebug_p2prendezvous() { }

	public static void set_steamnetdebug_p2prendezvous(int value) { }

	public static int get_steamnetdebug_sdrrelaypings() { }

	public static void set_steamnetdebug_sdrrelaypings(int value) { }

	public static int get_steamconnectiontimeout() { }

	public static void set_steamconnectiontimeout(int value) { }

}

public class SteamNetworking.Client : Client, IConnectionManager // TypeDefIndex: 7363
{	private ConnectionManager manager; // 0x70
	private const int bufferSize = 32;


	public override bool IsConnected() { }

	public override bool Connect(string strURL, int port) { }

	public override void Cycle() { }

	public override void Disconnect(string reason, bool sendReasonToServer) { }

	public override void Send(SendInfo sendinfo, MemoryStream data) { }

	private void Steamworks.IConnectionManager.OnConnecting(ConnectionInfo info) { }

	private void Steamworks.IConnectionManager.OnConnected(ConnectionInfo info) { }

	private void Steamworks.IConnectionManager.OnDisconnected(ConnectionInfo info) { }

	private void Steamworks.IConnectionManager.OnMessage(IntPtr data, int datasize, long messageNum, long recvTime, int channel) { }

	public override string GetDebug(Connection connection) { }

	public override int GetLastPing() { }

	public override ulong GetStat(Connection connection, BaseNetwork.StatTypeLong type) { }

	public void .ctor() { }

}

public class SteamNetworking.Server : Server, ISocketManager // TypeDefIndex: 7364
{	private SocketManager manager; // 0x68
	private bool relay; // 0x70
	private const int bufferSize = 32;
	private int[] lanePriorities; // 0x78
	private ushort[] laneWeights; // 0x80

	public override string ProtocolId { get; }


	public override string get_ProtocolId() { }

	public void .ctor(bool enableSteamDatagramRelay) { }

	public override bool IsConnected() { }

	public override bool Start() { }

	public override void Stop(string shutdownMsg) { }

	public override void Disconnect(Connection cn) { }

	public override void Kick(Connection cn, string message, bool logfile) { }

	public override void Cycle() { }

	public override void SendUnconnected(uint netAddr, ushort netPort, byte[] data, int size) { }

	public override void Send(SendInfo sendinfo, MemoryStream data) { }

	private void Send(SendInfo sendinfo, MemoryStream data, Connection connection) { }

	public void OnConnecting(Connection cn, ConnectionInfo info) { }

	public void OnConnected(Connection cn, ConnectionInfo info) { }

	public void OnDisconnected(Connection cn, ConnectionInfo info) { }

	public void OnMessage(Connection cn, NetIdentity identity, IntPtr data, int size, long messageNum, long recvTime, int channel) { }

	public override string GetDebug(Connection connection) { }

	public override int GetAveragePing(Connection connection) { }

	public override ulong GetStat(Connection connection, BaseNetwork.StatTypeLong type) { }

}

private sealed class SteamNetworking.Server.<>c // TypeDefIndex: 7365
{	public static readonly SteamNetworking.Server.<>c <>9; // 0x0
	public static Action<NetAddress> <>9__9_0; // 0x8


	private static void .cctor() { }

	public void .ctor() { }

	internal void <Start>b__9_0(NetAddress fakeAddressCallback) { }

}

public class SteamInventory : EntityComponent<BasePlayer> // TypeDefIndex: 8653
{	private IPlayerItem[] Items; // 0x20


	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	public bool HasItem(int itemid) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void ClientUpdateSteamInventory(BaseEntity.RPCMessage msg) { }

	public void ClientUpdate(IPlayerInventory result) { }

	public void .ctor() { }

}

public class SteamInventoryGen : MonoBehaviour // TypeDefIndex: 9323
{
	public void .ctor() { }

}

public class SteamDLCItem : ScriptableObject // TypeDefIndex: 10760
{	public int id; // 0x18
	public Translate.Phrase dlcName; // 0x20
	public int dlcAppID; // 0x28
	public bool bypassLicenseCheck; // 0x2C


	public bool IsInstalled() { }

	public bool CanUse(BasePlayer player) { }

	public void .ctor() { }

}

public class SteamInventoryCategory : ScriptableObject // TypeDefIndex: 10761
{	[HeaderAttribute] // RVA: 0x7AAD0 Offset: 0x79ED0 VA: 0x18007AAD0
	public bool canBeSoldToOtherUsers; // 0x18
	public bool canBeTradedWithOtherUsers; // 0x19
	public bool isCommodity; // 0x1A
	public SteamInventoryCategory.Price price; // 0x1C
	public SteamInventoryCategory.DropChance dropChance; // 0x20
	public bool CanBeInCrates; // 0x24


	public void .ctor() { }

}

public enum SteamInventoryCategory.Price // TypeDefIndex: 10762
{	public int value__; // 0x0
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
{	public int value__; // 0x0
	public const SteamInventoryCategory.DropChance NeverDrop = 0;
	public const SteamInventoryCategory.DropChance VeryRare = 1;
	public const SteamInventoryCategory.DropChance Rare = 2;
	public const SteamInventoryCategory.DropChance Common = 3;
	public const SteamInventoryCategory.DropChance VeryCommon = 4;
	public const SteamInventoryCategory.DropChance ExtremelyRare = 5;

}

public class SteamInventoryItem : ScriptableObject // TypeDefIndex: 10764
{	public int id; // 0x18
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

	public ItemDefinition itemDefinition { get; }


	public ItemDefinition get_itemDefinition() { }

	public virtual bool HasUnlocked(ulong playerId) { }

	public void .ctor() { }

}

public enum SteamInventoryItem.Category // TypeDefIndex: 10765
{	public int value__; // 0x0
	public const SteamInventoryItem.Category None = 0;
	public const SteamInventoryItem.Category Clothing = 1;
	public const SteamInventoryItem.Category Weapon = 2;
	public const SteamInventoryItem.Category Decoration = 3;
	public const SteamInventoryItem.Category Crate = 4;
	public const SteamInventoryItem.Category Resource = 5;

}

public enum SteamInventoryItem.SubCategory // TypeDefIndex: 10766
{	public int value__; // 0x0
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
{
	public Texture GetAvatarTexture(ulong steamid) { }

	public string GetUserName(ulong steamid) { }

	public static void SetPlayerPresence(SteamClientWrapper.RichPresenceState state) { }

	public static void ClearPlayerPresence() { }

	private static string GetLocalizationKey(SteamClientWrapper.RichPresenceState state) { }

	public static void Init() { }

	protected override void Awake() { }

	public void Update() { }

	public void OnDisable() { }

	public void .ctor() { }

}

public enum SteamClientWrapper.RichPresenceState // TypeDefIndex: 10777
{	public int value__; // 0x0
	public const SteamClientWrapper.RichPresenceState MainMenu = 0;
	public const SteamClientWrapper.RichPresenceState Wilderness = 1;
	public const SteamClientWrapper.RichPresenceState Monument = 2;

}

public static class SteamNewsSource // TypeDefIndex: 11128
{	public static SteamNewsSource.Story[] Stories; // 0x2520


	[IteratorStateMachineAttribute] // RVA: 0x98EF0 Offset: 0x982F0 VA: 0x180098EF0
	public static IEnumerator GetStories() { }

}

public struct SteamNewsSource.Story // TypeDefIndex: 11129
{	public string name; // 0x0
	public string url; // 0x8
	public int date; // 0x10
	public string text; // 0x18
	public string author; // 0x20

}

private sealed class SteamNewsSource.<GetStories>d__2 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 11130
{	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	private WWW <www>5__2; // 0x20

	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }


	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void System.IDisposable.Dispose() { }

	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private object System.Collections.IEnumerator.get_Current() { }

}

public class SteamFriendsList : MonoBehaviour // TypeDefIndex: 11217
{	public RectTransform targetPanel; // 0x18
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


	private void OnEnable() { }

	public void Refresh() { }

	public void AddPlayer(IPlayerInfo f) { }

	public int Priority(IPlayerInfo f) { }

	public void FilterSearch(string name) { }

	public void AddToPanel(IEnumerable<IPlayerInfo> list, int count = -1) { }

	private void FriendSelected(ulong steamid, string steamName) { }

	public static void JustSeen(ulong steamid) { }

	public void .ctor() { }

	private static void .cctor() { }

}

public class SteamFriendsList.onFriendSelectedEvent : UnityEvent<ulong, string> // TypeDefIndex: 11218
{
	public void .ctor() { }

}

private sealed class SteamFriendsList.<>c__DisplayClass15_0 // TypeDefIndex: 11219
{	public IPlayerInfo f; // 0x10


	public void .ctor() { }

	internal bool <AddPlayer>b__0(IPlayerInfo x) { }

}

private sealed class SteamFriendsList.<>c__DisplayClass16_0 // TypeDefIndex: 11220
{	public IPlayerInfo f; // 0x10


	public void .ctor() { }

	internal bool <Priority>b__0(PlayerTeam.TeamMember p) { }

}

private sealed class SteamFriendsList.<>c__DisplayClass17_0 // TypeDefIndex: 11221
{	public string name; // 0x10


	public void .ctor() { }

	internal bool <FilterSearch>b__0(IPlayerInfo x) { }

}

private sealed class SteamFriendsList.<>c__DisplayClass18_0 // TypeDefIndex: 11222
{	public IPlayerInfo player; // 0x10
	public SteamFriendsList <>4__this; // 0x18


	public void .ctor() { }

}

private sealed class SteamFriendsList.<>c__DisplayClass18_1 // TypeDefIndex: 11223
{	public ulong steamid; // 0x10
	public SteamFriendsList.<>c__DisplayClass18_0 CS$<>8__locals1; // 0x18


	public void .ctor() { }

	internal void <AddToPanel>b__1() { }

}

private sealed class SteamFriendsList.<>c // TypeDefIndex: 11224
{	public static readonly SteamFriendsList.<>c <>9; // 0x0
	public static Func<IPlayerInfo, string> <>9__18_0; // 0x8


	private static void .cctor() { }

	public void .ctor() { }

	internal string <AddToPanel>b__18_0(IPlayerInfo x) { }

}

public class SteamUserButton : MonoBehaviour // TypeDefIndex: 11225
{	public RustText steamName; // 0x18
	public RustText steamInfo; // 0x20
	public RawImage avatar; // 0x28
	public Color textColorInGame; // 0x30
	public Color textColorOnline; // 0x40
	public Color textColorNormal; // 0x50
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private ulong <SteamId>k__BackingField; // 0x60
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private string <Username>k__BackingField; // 0x68

	public ulong SteamId { get; set; }
	public string Username { get; set; }


	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public ulong get_SteamId() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void set_SteamId(ulong value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public string get_Username() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void set_Username(string value) { }

	[AsyncStateMachineAttribute] // RVA: 0xA2290 Offset: 0xA1690 VA: 0x1800A2290
	public void UpdateFromUser(ulong steamid, bool isInThisGame, bool isOnline, bool hideSteamId) { }

	public void .ctor() { }

}

private struct SteamUserButton.<UpdateFromUser>d__14 : IAsyncStateMachine // TypeDefIndex: 11226
{	public int <>1__state; // 0x0
	public AsyncVoidMethodBuilder <>t__builder; // 0x8
	public SteamUserButton <>4__this; // 0x28
	public ulong steamid; // 0x30
	public bool hideSteamId; // 0x38
	public bool isInThisGame; // 0x39
	public bool isOnline; // 0x3A
	private TaskAwaiter<IPlayerInfo> <>u__1; // 0x40


	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

public class Steam // TypeDefIndex: 11960
{
	[ClientVar] // RVA: 0x71070 Offset: 0x70470 VA: 0x180071070
	public static object achievements() { }

	[ClientVar] // RVA: 0x71070 Offset: 0x70470 VA: 0x180071070
	public static void ResetStats() { }

	public void .ctor() { }

}

private sealed class Steam.<>c // TypeDefIndex: 11961
{	public static readonly Steam.<>c <>9; // 0x0
	public static Func<Achievement, <>f__AnonymousType0<string, string, bool>> <>9__0_0; // 0x8


	private static void .cctor() { }

	public void .ctor() { }

	internal <>f__AnonymousType0<string, string, bool> <achievements>b__0_0(Achievement x) { }

}

public class SteamInventoryCrafting : MonoBehaviour // TypeDefIndex: 12046
{	public GameObject Container; // 0x18
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

	public IPlayerItemDefinition ResultItem { get; set; }
	public Coroutine MarketCoroutine { get; set; }


	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public IPlayerItemDefinition get_ResultItem() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void set_ResultItem(IPlayerItemDefinition value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public Coroutine get_MarketCoroutine() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void set_MarketCoroutine(Coroutine value) { }

	public void OnEnable() { }

	private void FillCraftingContainer() { }

	public void Update() { }

	private void UpdateImpl(bool force) { }

	private void OnChanged(SteamInventoryItem[] items) { }

	private void UpdateInfoText(int length, IPlayerItemDefinition definition, Nullable<double> totalValue) { }

	[AsyncStateMachineAttribute] // RVA: 0xD1600 Offset: 0xD0A00 VA: 0x1800D1600
	private Task<SteamInventoryCrafting.MarketPrice> GetMarketPrice(IPlayerItemDefinition definition) { }

	[AsyncStateMachineAttribute] // RVA: 0xD16E0 Offset: 0xD0AE0 VA: 0x1800D16E0
	private Task<SteamInventoryCrafting.MarketPrice> GetMarketPriceImpl(IPlayerItemDefinition definition) { }

	[IteratorStateMachineAttribute] // RVA: 0xD1920 Offset: 0xD0D20 VA: 0x1800D1920
	private IEnumerator LoadMarketPrice(IPlayerItemDefinition definition) { }

	public void DoExchange() { }

	[AsyncStateMachineAttribute] // RVA: 0xD1A70 Offset: 0xD0E70 VA: 0x1800D1A70
	private Task ExchangeItems(SteamInventoryItem[] selected) { }

	public void OnRefreshed(IReadOnlyCollection<IPlayerItem> items) { }

	public void OnManualRefresh() { }

	public void .ctor() { }

	private static void .cctor() { }

}

public class SteamInventoryCrafting.MarketPrice // TypeDefIndex: 12047
{	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private bool <success>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private ulong <volume>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private string <lowest_price>k__BackingField; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private double <lowest_price_value>k__BackingField; // 0x28

	public bool success { get; set; }
	public ulong volume { get; set; }
	public string lowest_price { get; set; }
	public double lowest_price_value { get; set; }


	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public bool get_success() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void set_success(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public ulong get_volume() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void set_volume(ulong value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public string get_lowest_price() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void set_lowest_price(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public double get_lowest_price_value() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void set_lowest_price_value(double value) { }

	public void .ctor() { }

}

private sealed class SteamInventoryCrafting.<>c__DisplayClass20_0 // TypeDefIndex: 12048
{	public IPlayerItemDefinition x; // 0x10
	public SteamInventoryCrafting <>4__this; // 0x18


	public void .ctor() { }

	internal void <FillCraftingContainer>b__1() { }

}

private sealed class SteamInventoryCrafting.<>c // TypeDefIndex: 12049
{	public static readonly SteamInventoryCrafting.<>c <>9; // 0x0
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


	private static void .cctor() { }

	public void .ctor() { }

	internal bool <FillCraftingContainer>b__20_0(IPlayerItemDefinition x) { }

	internal bool <UpdateImpl>b__22_0(Toggle x) { }

	internal SteamInventoryItem <UpdateImpl>b__22_1(Toggle x) { }

	internal bool <OnChanged>b__23_0(SteamInventoryItem x) { }

	internal bool <OnChanged>b__23_1(SteamInventoryItem x) { }

	internal bool <OnChanged>b__23_2(SteamInventoryItem x) { }

	internal bool <OnChanged>b__23_3(SteamInventoryItem x) { }

	internal bool <OnChanged>b__23_4(SteamInventoryItem x) { }

	internal IEnumerable<PlayerItemRecipe> <OnChanged>b__23_5(SteamInventoryItem x) { }

	internal IPlayerItemDefinition <OnChanged>b__23_6(PlayerItemRecipe x) { }

	internal bool <DoExchange>b__32_0(Toggle x) { }

	internal SteamInventoryItem <DoExchange>b__32_1(Toggle x) { }

	internal bool <OnRefreshed>b__34_0(IPlayerItem x) { }

	internal int <OnRefreshed>b__34_1(IPlayerItem x) { }

	internal bool <OnRefreshed>b__34_2(IPlayerItem x) { }

	internal int <OnRefreshed>b__34_3(IPlayerItem x) { }

	internal bool <OnRefreshed>b__34_4(IPlayerItem x) { }

	internal int <OnRefreshed>b__34_5(IPlayerItem x) { }

}

private sealed class SteamInventoryCrafting.<>c__DisplayClass23_0 // TypeDefIndex: 12050
{	public IPlayerItemDefinition itemType; // 0x10


	public void .ctor() { }

	internal bool <OnChanged>b__7(SteamInventoryItem x) { }

}

private struct SteamInventoryCrafting.<GetMarketPrice>d__29 : IAsyncStateMachine // TypeDefIndex: 12051
{	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder<SteamInventoryCrafting.MarketPrice> <>t__builder; // 0x8
	public SteamInventoryCrafting <>4__this; // 0x20
	public IPlayerItemDefinition definition; // 0x28
	private TaskAwaiter<SteamInventoryCrafting.MarketPrice> <>u__1; // 0x30


	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

private struct SteamInventoryCrafting.<GetMarketPriceImpl>d__30 : IAsyncStateMachine // TypeDefIndex: 12052
{	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder<SteamInventoryCrafting.MarketPrice> <>t__builder; // 0x8
	public IPlayerItemDefinition definition; // 0x20
	public SteamInventoryCrafting <>4__this; // 0x28
	private TaskAwaiter<string> <>u__1; // 0x30


	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

private sealed class SteamInventoryCrafting.<>c__DisplayClass31_0 // TypeDefIndex: 12053
{	public Task<SteamInventoryCrafting.MarketPrice> task; // 0x10


	public void .ctor() { }

	internal bool <LoadMarketPrice>b__0() { }

}

private sealed class SteamInventoryCrafting.<LoadMarketPrice>d__31 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 12054
{	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public SteamInventoryCrafting <>4__this; // 0x20
	public IPlayerItemDefinition definition; // 0x28
	private SteamInventoryCrafting.<>c__DisplayClass31_0 <>8__1; // 0x30

	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }


	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void System.IDisposable.Dispose() { }

	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private object System.Collections.IEnumerator.get_Current() { }

}

private sealed class SteamInventoryCrafting.<>c__DisplayClass33_0 // TypeDefIndex: 12055
{	public SteamInventoryItem[] selected; // 0x10


	public void .ctor() { }

	internal bool <ExchangeItems>b__0(IPlayerItem x) { }

}

private sealed class SteamInventoryCrafting.<>c__DisplayClass33_1 // TypeDefIndex: 12056
{	public IPlayerItemDefinition targetItem; // 0x10


	public void .ctor() { }

	internal Task<IPlayerInventory> <ExchangeItems>b__1(SteamInventoryItem x) { }

}

private struct SteamInventoryCrafting.<ExchangeItems>d__33 : IAsyncStateMachine // TypeDefIndex: 12057
{	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder <>t__builder; // 0x8
	public SteamInventoryItem[] selected; // 0x20
	public SteamInventoryCrafting <>4__this; // 0x28
	private SteamInventoryCrafting.<>c__DisplayClass33_0 <>8__1; // 0x30
	private SteamInventoryCrafting.<>c__DisplayClass33_1 <>8__2; // 0x38
	private IPlayerInventory <result>5__2; // 0x40
	private TaskAwaiter<IPlayerInventory> <>u__1; // 0x48
	private TaskAwaiter <>u__2; // 0x50
	private TaskAwaiter<IPlayerInventory[]> <>u__3; // 0x58


	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

public class SteamInventoryCrateOpen : MonoBehaviour // TypeDefIndex: 12058
{	public TextMeshProUGUI Name; // 0x18
	public TextMeshProUGUI Requirements; // 0x20
	public TextMeshProUGUI Label; // 0x28
	public HttpImage IconImage; // 0x30
	public GameObject ErrorPanel; // 0x38
	public TextMeshProUGUI ErrorText; // 0x40
	public GameObject CraftButton; // 0x48
	public GameObject ProgressPanel; // 0x50
	public SteamInventoryNewItem NewItemModal; // 0x58
	private InventoryRecipe Recipe; // 0x60


	public void Open(int ItemDefinition) { }

	public void DoCraft() { }

	[AsyncStateMachineAttribute] // RVA: 0xD5AD0 Offset: 0xD4ED0 VA: 0x1800D5AD0
	private Task DoCraftAsync() { }

	public void Close() { }

	public void .ctor() { }

}

private sealed class SteamInventoryCrateOpen.<>c__DisplayClass10_0 // TypeDefIndex: 12059
{	public InventoryRecipe.Ingredient i; // 0x10


	public void .ctor() { }

	internal bool <Open>b__1(InventoryItem x) { }

}

private sealed class SteamInventoryCrateOpen.<>c // TypeDefIndex: 12060
{	public static readonly SteamInventoryCrateOpen.<>c <>9; // 0x0
	public static Func<InventoryRecipe.Ingredient, string> <>9__10_0; // 0x8
	public static Func<InventoryItem, int> <>9__10_2; // 0x10
	public static Func<InventoryItem, int> <>9__12_1; // 0x18


	private static void .cctor() { }

	public void .ctor() { }

	internal string <Open>b__10_0(InventoryRecipe.Ingredient x) { }

	internal int <Open>b__10_2(InventoryItem x) { }

	internal int <DoCraftAsync>b__12_1(InventoryItem x) { }

}

private sealed class SteamInventoryCrateOpen.<>c__DisplayClass12_0 // TypeDefIndex: 12061
{	public List<InventoryItem.Amount> items; // 0x10


	public void .ctor() { }

	internal bool <DoCraftAsync>b__2(InventoryItem x) { }

}

private sealed class SteamInventoryCrateOpen.<>c__DisplayClass12_1 // TypeDefIndex: 12062
{	public InventoryRecipe.Ingredient i; // 0x10


	public void .ctor() { }

	internal bool <DoCraftAsync>b__0(InventoryItem x) { }

}

private sealed class SteamInventoryCrateOpen.<>c__DisplayClass12_2 // TypeDefIndex: 12063
{	public InventoryItem x; // 0x10


	public void .ctor() { }

	internal bool <DoCraftAsync>b__3(InventoryItem.Amount y) { }

}

private struct SteamInventoryCrateOpen.<DoCraftAsync>d__12 : IAsyncStateMachine // TypeDefIndex: 12064
{	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder <>t__builder; // 0x8
	public SteamInventoryCrateOpen <>4__this; // 0x20
	private SteamInventoryCrateOpen.<>c__DisplayClass12_0 <>8__1; // 0x28
	private Nullable<InventoryResult> <result>5__2; // 0x30
	private TaskAwaiter<Nullable<InventoryResult>> <>u__1; // 0x40
	private TaskAwaiter <>u__2; // 0x48


	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

public class SteamInventoryIcon : MonoBehaviour // TypeDefIndex: 12065
{
	public void Setup(IPlayerItem item, ItemSkinDirectory.Skin skin) { }

	internal void Setup(IPlayerItem item) { }

	public void .ctor() { }

}

public class SteamInventoryItem : MonoBehaviour // TypeDefIndex: 12066
{	public IPlayerItem Item; // 0x18
	public HttpImage Image; // 0x20


	public bool Setup(IPlayerItem item) { }

	public void .ctor() { }

}

public class SteamInventoryManager : SingletonComponent<SteamInventoryManager> // TypeDefIndex: 12067
{	public GameObject inventoryItemPrefab; // 0x18
	public GameObject inventoryCanvas; // 0x20
	public GameObject missingItems; // 0x28
	public SteamInventoryCrafting CraftControl; // 0x30
	public List<GameObject> items; // 0x38
	public GameObject LoadingOverlay; // 0x40


	protected override void Awake() { }

	public void ManualRefresh() { }

	[AsyncStateMachineAttribute] // RVA: 0xD6060 Offset: 0xD5460 VA: 0x1800D6060
	public Task Refresh() { }

	[AsyncStateMachineAttribute] // RVA: 0xD61C0 Offset: 0xD55C0 VA: 0x1800D61C0
	private Task FixStacks(IReadOnlyCollection<IPlayerItem> steamitems) { }

	public void .ctor() { }

}

private sealed class SteamInventoryManager.<>c // TypeDefIndex: 12068
{	public static readonly SteamInventoryManager.<>c <>9; // 0x0
	public static Func<IPlayerItem, DateTimeOffset> <>9__8_0; // 0x8
	public static Func<InventoryItem, bool> <>9__9_0; // 0x10
	public static Func<InventoryItem, bool> <>9__9_1; // 0x18
	public static Func<InventoryItem, bool> <>9__9_2; // 0x20
	public static Func<InventoryItem, InventoryDefId> <>9__9_3; // 0x28


	private static void .cctor() { }

	public void .ctor() { }

	internal DateTimeOffset <Refresh>b__8_0(IPlayerItem x) { }

	internal bool <FixStacks>b__9_0(InventoryItem x) { }

	internal bool <FixStacks>b__9_1(InventoryItem x) { }

	internal bool <FixStacks>b__9_2(InventoryItem x) { }

	internal InventoryDefId <FixStacks>b__9_3(InventoryItem x) { }

}

private struct SteamInventoryManager.<Refresh>d__8 : IAsyncStateMachine // TypeDefIndex: 12069
{	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder <>t__builder; // 0x8
	public SteamInventoryManager <>4__this; // 0x20
	private IReadOnlyList<IPlayerItem> <steamitems>5__2; // 0x28
	private int <itemIndex>5__3; // 0x30
	private TaskAwaiter<IPlayerInventory> <>u__1; // 0x38
	private IEnumerator<IPlayerItem> <>7__wrap3; // 0x40
	private IPlayerItem <item>5__5; // 0x48
	private TaskAwaiter <>u__2; // 0x50


	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

private struct SteamInventoryManager.<FixStacks>d__9 : IAsyncStateMachine // TypeDefIndex: 12070
{	public int <>1__state; // 0x0
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


	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

public class SteamInventoryNewItem : MonoBehaviour // TypeDefIndex: 12071
{
	[AsyncStateMachineAttribute] // RVA: 0xD6680 Offset: 0xD5A80 VA: 0x1800D6680
	public Task Open(IPlayerItem item) { }

	public void .ctor() { }

}

private struct SteamInventoryNewItem.<Open>d__0 : IAsyncStateMachine // TypeDefIndex: 12072
{	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder <>t__builder; // 0x8
	public SteamInventoryNewItem <>4__this; // 0x20
	public IPlayerItem item; // 0x28
	private TaskAwaiter <>u__1; // 0x30


	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

