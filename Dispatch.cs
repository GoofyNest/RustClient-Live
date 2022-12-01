public static class Dispatch // TypeDefIndex: 5110
{
	public static Action<CallbackType, string, bool> OnDebugCallback;
	public static Action<Exception> OnException;
	[CompilerGeneratedAttribute]
	private static HSteamPipe <ClientPipe>k__BackingField;
	[CompilerGeneratedAttribute]
	private static HSteamPipe <ServerPipe>k__BackingField;
	private static bool runningFrame;
	private static List<Action<IntPtr>> actionsToCall;
	private static Dictionary<ulong, Dispatch.ResultCallback> ResultCallbacks;
	private static Dictionary<CallbackType, List<Dispatch.Callback>> Callbacks;

	internal static HSteamPipe ClientPipe { get; set; }
	internal static HSteamPipe ServerPipe { get; }


	internal static extern void SteamAPI_ManualDispatch_Init() { }

	internal static extern void SteamAPI_ManualDispatch_RunFrame(HSteamPipe pipe) { }

	internal static extern bool SteamAPI_ManualDispatch_GetNextCallback(HSteamPipe pipe, ref Dispatch.CallbackMsg_t msg) { }

	internal static extern bool SteamAPI_ManualDispatch_FreeLastCallback(HSteamPipe pipe) { }

	[CompilerGeneratedAttribute]
	internal static HSteamPipe get_ClientPipe() { }

	[CompilerGeneratedAttribute]
	internal static void set_ClientPipe(HSteamPipe value) { }

	[CompilerGeneratedAttribute]
	internal static HSteamPipe get_ServerPipe() { }

	internal static void Init() { }

	internal static void Frame(HSteamPipe pipe) { }

	private static void ProcessCallback(Dispatch.CallbackMsg_t msg, bool isServer) { }

	internal static string CallbackToString(CallbackType type, IntPtr data, int expectedsize) { }

	private static void ProcessResult(Dispatch.CallbackMsg_t msg) { }

	[AsyncStateMachineAttribute]
	internal static void LoopClientAsync() { }

	internal static void OnCallComplete<T>(SteamAPICall_t call, Action continuation, bool server) { }
	/* GenericInstMethod :
	|
	|-Dispatch.OnCallComplete<CreateItemResult_t>
	|
	|-Dispatch.OnCallComplete<EncryptedAppTicketResponse_t>
	|
	|-Dispatch.OnCallComplete<SetUserItemVoteResult_t>
	|
	|-Dispatch.OnCallComplete<SteamInventoryRequestPricesResult_t>
	|
	|-Dispatch.OnCallComplete<SteamInventoryStartPurchaseResult_t>
	|
	|-Dispatch.OnCallComplete<SteamUGCQueryCompleted_t>
	|
	|-Dispatch.OnCallComplete<SubmitItemUpdateResult_t>
	*/

	internal static void Install<T>(Action<T> p, bool server = False) { }
	/* GenericInstMethod :
	|
	|-Dispatch.Install<ActiveBeaconsUpdated_t>
	|
	|-Dispatch.Install<AvailableBeaconLocationsUpdated_t>
	|
	|-Dispatch.Install<ClientGameServerDeny_t>
	|
	|-Dispatch.Install<DownloadItemResult_t>
	|
	|-Dispatch.Install<DurationControl_t>
	|
	|-Dispatch.Install<FriendRichPresenceUpdate_t>
	|
	|-Dispatch.Install<GameConnectedClanChatMsg_t>
	|
	|-Dispatch.Install<GameConnectedFriendChatMsg_t>
	|
	|-Dispatch.Install<GameLobbyJoinRequested_t>
	|
	|-Dispatch.Install<GameOverlayActivated_t>
	|
	|-Dispatch.Install<GameRichPresenceJoinRequested_t>
	|
	|-Dispatch.Install<GameServerChangeRequested_t>
	|
	|-Dispatch.Install<GameWebCallback_t>
	|
	|-Dispatch.Install<GamepadTextInputDismissed_t>
	|
	|-Dispatch.Install<GetAuthSessionTicketResponse_t>
	|
	|-Dispatch.Install<IPCountry_t>
	|
	|-Dispatch.Install<ItemInstalled_t>
	|
	|-Dispatch.Install<LicensesUpdated_t>
	|
	|-Dispatch.Install<LobbyChatMsg_t>
	|
	|-Dispatch.Install<LobbyChatUpdate_t>
	|
	|-Dispatch.Install<LobbyCreated_t>
	|
	|-Dispatch.Install<LobbyDataUpdate_t>
	|
	|-Dispatch.Install<LobbyEnter_t>
	|
	|-Dispatch.Install<LobbyGameCreated_t>
	|
	|-Dispatch.Install<LobbyInvite_t>
	|
	|-Dispatch.Install<LowBatteryPower_t>
	|
	|-Dispatch.Install<MicroTxnAuthorizationResponse_t>
	|
	|-Dispatch.Install<OverlayBrowserProtocolNavigation_t>
	|
	|-Dispatch.Install<P2PSessionConnectFail_t>
	|
	|-Dispatch.Install<P2PSessionRequest_t>
	|
	|-Dispatch.Install<PersonaStateChange_t>
	|
	|-Dispatch.Install<PlaybackStatusHasChanged_t>
	|
	|-Dispatch.Install<RemoteStoragePublishedFileSubscribed_t>
	|
	|-Dispatch.Install<RemoteStoragePublishedFileUnsubscribed_t>
	|
	|-Dispatch.Install<ScreenshotReady_t>
	|
	|-Dispatch.Install<ScreenshotRequested_t>
	|
	|-Dispatch.Install<SteamInventoryDefinitionUpdate_t>
	|
	|-Dispatch.Install<SteamInventoryFullUpdate_t>
	|
	|-Dispatch.Install<SteamNetConnectionStatusChangedCallback_t>
	|
	|-Dispatch.Install<SteamNetworkingFakeIPResult_t>
	|
	|-Dispatch.Install<SteamParentalSettingsChanged_t>
	|
	|-Dispatch.Install<SteamRelayNetworkStatus_t>
	|
	|-Dispatch.Install<SteamRemotePlaySessionConnected_t>
	|
	|-Dispatch.Install<SteamRemotePlaySessionDisconnected_t>
	|
	|-Dispatch.Install<SteamServerConnectFailure_t>
	|
	|-Dispatch.Install<SteamServersConnected_t>
	|
	|-Dispatch.Install<SteamServersDisconnected_t>
	|
	|-Dispatch.Install<SteamShutdown_t>
	|
	|-Dispatch.Install<UserAchievementIconFetched_t>
	|
	|-Dispatch.Install<UserAchievementStored_t>
	|
	|-Dispatch.Install<UserStatsReceived_t>
	|
	|-Dispatch.Install<UserStatsStored_t>
	|
	|-Dispatch.Install<UserStatsUnloaded_t>
	|
	|-Dispatch.Install<ValidateAuthTicketResponse_t>
	|
	|-Dispatch.Install<VolumeHasChanged_t>
	|
	|-Dispatch.Install<object>
	*/

	internal static void ShutdownClient() { }

	private static void .cctor() { }

}

internal struct Dispatch.CallbackMsg_t // TypeDefIndex: 5111
{
	public HSteamUser m_hSteamUser;
	public CallbackType Type;
	public IntPtr Data;
	public int DataSize;

}

private struct Dispatch.ResultCallback // TypeDefIndex: 5112
{
	public Action continuation;
	public bool server;

}

private struct Dispatch.Callback // TypeDefIndex: 5113
{
	public Action<IntPtr> action;
	public bool server;

}

private sealed class Dispatch.<>c // TypeDefIndex: 5114
{
	public static readonly Dispatch.<>c <>9;
	public static Func<FieldInfo, int> <>9__20_0;
	public static Predicate<Dispatch.Callback> <>9__31_3;
	public static Func<KeyValuePair<ulong, Dispatch.ResultCallback>, bool> <>9__31_0;
	public static Func<KeyValuePair<ulong, Dispatch.ResultCallback>, ulong> <>9__31_1;
	public static Func<KeyValuePair<ulong, Dispatch.ResultCallback>, Dispatch.ResultCallback> <>9__31_2;


	private static void .cctor() { }

	public void .ctor() { }

	internal int <CallbackToString>

	internal bool <ShutdownClient>

	internal bool <ShutdownClient>

	internal ulong <ShutdownClient>

	internal Dispatch.ResultCallback <ShutdownClient>

}

private struct Dispatch.<LoopClientAsync>d__22 : IAsyncStateMachine // TypeDefIndex: 5115
{
	public int <>1__state;
	public AsyncVoidMethodBuilder <>t__builder;
	private TaskAwaiter <>u__1;


	private void MoveNext() { }

	[DebuggerHiddenAttribute]
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

private sealed class Dispatch.<>c__DisplayClass29_0<T> // TypeDefIndex: 5116
{
	public Action<T> p;


	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-Dispatch.<>c
	|-Dispatch.<>c
	|-Dispatch.<>c
	|-Dispatch.<>c
	|-Dispatch.<>c
	|-Dispatch.<>c
	|-Dispatch.<>c
	|-Dispatch.<>c
	|-Dispatch.<>c
	|-Dispatch.<>c
	|-Dispatch.<>c
	|-Dispatch.<>c
	|-Dispatch.<>c
	|-Dispatch.<>c
	|-Dispatch.<>c
	|-Dispatch.<>c
	|-Dispatch.<>c
	|-Dispatch.<>c
	|-Dispatch.<>c
	|-Dispatch.<>c
	|-Dispatch.<>c
	|-Dispatch.<>c
	|-Dispatch.<>c
	|-Dispatch.<>c
	|-Dispatch.<>c
	|-Dispatch.<>c
	|-Dispatch.<>c
	|-Dispatch.<>c
	|-Dispatch.<>c
	|-Dispatch.<>c
	|-Dispatch.<>c
	|-Dispatch.<>c
	|-Dispatch.<>c
	|-Dispatch.<>c
	|-Dispatch.<>c
	|-Dispatch.<>c
	|-Dispatch.<>c
	|-Dispatch.<>c
	|-Dispatch.<>c
	|-Dispatch.<>c
	|-Dispatch.<>c
	|-Dispatch.<>c
	|-Dispatch.<>c
	|-Dispatch.<>c
	|-Dispatch.<>c
	|-Dispatch.<>c
	|-Dispatch.<>c
	|-Dispatch.<>c
	|-Dispatch.<>c
	|-Dispatch.<>c
	|-Dispatch.<>c
	|-Dispatch.<>c
	|-Dispatch.<>c
	|-Dispatch.<>c
	|-Dispatch.<>c
	|-Dispatch.<>c
	*/

	internal void <Install>
	/* GenericInstMethod :
	|
	|-Dispatch.<>c
	|
	|-Dispatch.<>c
	|
	|-Dispatch.<>c
	|
	|-Dispatch.<>c
	|
	|-Dispatch.<>c
	|
	|-Dispatch.<>c
	|
	|-Dispatch.<>c
	|
	|-Dispatch.<>c
	|
	|-Dispatch.<>c
	|
	|-Dispatch.<>c
	|
	|-Dispatch.<>c
	|
	|-Dispatch.<>c
	|
	|-Dispatch.<>c
	|
	|-Dispatch.<>c
	|
	|-Dispatch.<>c
	|
	|-Dispatch.<>c
	|
	|-Dispatch.<>c
	|
	|-Dispatch.<>c
	|
	|-Dispatch.<>c
	|
	|-Dispatch.<>c
	|
	|-Dispatch.<>c
	|
	|-Dispatch.<>c
	|
	|-Dispatch.<>c
	|
	|-Dispatch.<>c
	|
	|-Dispatch.<>c
	|
	|-Dispatch.<>c
	|
	|-Dispatch.<>c
	|
	|-Dispatch.<>c
	|
	|-Dispatch.<>c
	|
	|-Dispatch.<>c
	|
	|-Dispatch.<>c
	|
	|-Dispatch.<>c
	|
	|-Dispatch.<>c
	|
	|-Dispatch.<>c
	|
	|-Dispatch.<>c
	|
	|-Dispatch.<>c
	|
	|-Dispatch.<>c
	|
	|-Dispatch.<>c
	|
	|-Dispatch.<>c
	|
	|-Dispatch.<>c
	|
	|-Dispatch.<>c
	|
	|-Dispatch.<>c
	|
	|-Dispatch.<>c
	|
	|-Dispatch.<>c
	|
	|-Dispatch.<>c
	|
	|-Dispatch.<>c
	|
	|-Dispatch.<>c
	|
	|-Dispatch.<>c
	|
	|-Dispatch.<>c
	|
	|-Dispatch.<>c
	|
	|-Dispatch.<>c
	|
	|-Dispatch.<>c
	|
	|-Dispatch.<>c
	|
	|-Dispatch.<>c
	|
	|-Dispatch.<>c
	|
	|-Dispatch.<>c
	*/

}

