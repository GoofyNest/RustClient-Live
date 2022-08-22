public static class Dispatch // TypeDefIndex: 5104
{	public static Action<CallbackType, string, bool> OnDebugCallback; // 0x0
	public static Action<Exception> OnException; // 0x8
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private static HSteamPipe <ClientPipe>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private static HSteamPipe <ServerPipe>k__BackingField; // 0x14
	private static bool runningFrame; // 0x18
	private static List<Action<IntPtr>> actionsToCall; // 0x20
	private static Dictionary<ulong, Dispatch.ResultCallback> ResultCallbacks; // 0x28
	private static Dictionary<CallbackType, List<Dispatch.Callback>> Callbacks; // 0x30

	internal static HSteamPipe ClientPipe { get; set; }
	internal static HSteamPipe ServerPipe { get; }


	internal static extern void SteamAPI_ManualDispatch_Init() { }

	internal static extern void SteamAPI_ManualDispatch_RunFrame(HSteamPipe pipe) { }

	internal static extern bool SteamAPI_ManualDispatch_GetNextCallback(HSteamPipe pipe, ref Dispatch.CallbackMsg_t msg) { }

	internal static extern bool SteamAPI_ManualDispatch_FreeLastCallback(HSteamPipe pipe) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	internal static HSteamPipe get_ClientPipe() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	internal static void set_ClientPipe(HSteamPipe value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	internal static HSteamPipe get_ServerPipe() { }

	internal static void Init() { }

	internal static void Frame(HSteamPipe pipe) { }

	private static void ProcessCallback(Dispatch.CallbackMsg_t msg, bool isServer) { }

	internal static string CallbackToString(CallbackType type, IntPtr data, int expectedsize) { }

	private static void ProcessResult(Dispatch.CallbackMsg_t msg) { }

	[AsyncStateMachineAttribute] // RVA: 0x8B230 Offset: 0x8A630 VA: 0x18008B230
	internal static void LoopClientAsync() { }

	internal static void OnCallComplete<T>(SteamAPICall_t call, Action continuation, bool server) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCF4C50 Offset: 0xCF4050 VA: 0x180CF4C50
	|-Dispatch.OnCallComplete<CreateItemResult_t>
	|
	|-RVA: 0xCF4D20 Offset: 0xCF4120 VA: 0x180CF4D20
	|-Dispatch.OnCallComplete<EncryptedAppTicketResponse_t>
	|
	|-RVA: 0xCF4DF0 Offset: 0xCF41F0 VA: 0x180CF4DF0
	|-Dispatch.OnCallComplete<SetUserItemVoteResult_t>
	|
	|-RVA: 0xCF4EC0 Offset: 0xCF42C0 VA: 0x180CF4EC0
	|-Dispatch.OnCallComplete<SteamInventoryRequestPricesResult_t>
	|
	|-RVA: 0xCF4F90 Offset: 0xCF4390 VA: 0x180CF4F90
	|-Dispatch.OnCallComplete<SteamInventoryStartPurchaseResult_t>
	|
	|-RVA: 0xCF5060 Offset: 0xCF4460 VA: 0x180CF5060
	|-Dispatch.OnCallComplete<SteamUGCQueryCompleted_t>
	|
	|-RVA: 0xCF5130 Offset: 0xCF4530 VA: 0x180CF5130
	|-Dispatch.OnCallComplete<SubmitItemUpdateResult_t>
	*/

	internal static void Install<T>(Action<T> p, bool server = False) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCEDB80 Offset: 0xCECF80 VA: 0x180CEDB80
	|-Dispatch.Install<ActiveBeaconsUpdated_t>
	|
	|-RVA: 0xCEDD80 Offset: 0xCED180 VA: 0x180CEDD80
	|-Dispatch.Install<AvailableBeaconLocationsUpdated_t>
	|
	|-RVA: 0xCEDF80 Offset: 0xCED380 VA: 0x180CEDF80
	|-Dispatch.Install<ClientGameServerDeny_t>
	|
	|-RVA: 0xCEE180 Offset: 0xCED580 VA: 0x180CEE180
	|-Dispatch.Install<DownloadItemResult_t>
	|
	|-RVA: 0xCEE3A0 Offset: 0xCED7A0 VA: 0x180CEE3A0
	|-Dispatch.Install<DurationControl_t>
	|
	|-RVA: 0xCEE5C0 Offset: 0xCED9C0 VA: 0x180CEE5C0
	|-Dispatch.Install<FriendRichPresenceUpdate_t>
	|
	|-RVA: 0xCEE7C0 Offset: 0xCEDBC0 VA: 0x180CEE7C0
	|-Dispatch.Install<GameConnectedClanChatMsg_t>
	|
	|-RVA: 0xCEE9E0 Offset: 0xCEDDE0 VA: 0x180CEE9E0
	|-Dispatch.Install<GameConnectedFriendChatMsg_t>
	|
	|-RVA: 0xCEEBE0 Offset: 0xCEDFE0 VA: 0x180CEEBE0
	|-Dispatch.Install<GameLobbyJoinRequested_t>
	|
	|-RVA: 0xCEEDE0 Offset: 0xCEE1E0 VA: 0x180CEEDE0
	|-Dispatch.Install<GameOverlayActivated_t>
	|
	|-RVA: 0xCEEFE0 Offset: 0xCEE3E0 VA: 0x180CEEFE0
	|-Dispatch.Install<GameRichPresenceJoinRequested_t>
	|
	|-RVA: 0xCEF1E0 Offset: 0xCEE5E0 VA: 0x180CEF1E0
	|-Dispatch.Install<GameServerChangeRequested_t>
	|
	|-RVA: 0xCEF3E0 Offset: 0xCEE7E0 VA: 0x180CEF3E0
	|-Dispatch.Install<GameWebCallback_t>
	|
	|-RVA: 0xCEF5E0 Offset: 0xCEE9E0 VA: 0x180CEF5E0
	|-Dispatch.Install<GamepadTextInputDismissed_t>
	|
	|-RVA: 0xCEF7E0 Offset: 0xCEEBE0 VA: 0x180CEF7E0
	|-Dispatch.Install<GetAuthSessionTicketResponse_t>
	|
	|-RVA: 0xCEF9E0 Offset: 0xCEEDE0 VA: 0x180CEF9E0
	|-Dispatch.Install<IPCountry_t>
	|
	|-RVA: 0xCEFBE0 Offset: 0xCEEFE0 VA: 0x180CEFBE0
	|-Dispatch.Install<ItemInstalled_t>
	|
	|-RVA: 0xCEFDE0 Offset: 0xCEF1E0 VA: 0x180CEFDE0
	|-Dispatch.Install<LicensesUpdated_t>
	|
	|-RVA: 0xCEFFE0 Offset: 0xCEF3E0 VA: 0x180CEFFE0
	|-Dispatch.Install<LobbyChatMsg_t>
	|
	|-RVA: 0xCF0200 Offset: 0xCEF600 VA: 0x180CF0200
	|-Dispatch.Install<LobbyChatUpdate_t>
	|
	|-RVA: 0xCF0420 Offset: 0xCEF820 VA: 0x180CF0420
	|-Dispatch.Install<LobbyCreated_t>
	|
	|-RVA: 0xCF0620 Offset: 0xCEFA20 VA: 0x180CF0620
	|-Dispatch.Install<LobbyDataUpdate_t>
	|
	|-RVA: 0xCF0840 Offset: 0xCEFC40 VA: 0x180CF0840
	|-Dispatch.Install<LobbyEnter_t>
	|
	|-RVA: 0xCF0A60 Offset: 0xCEFE60 VA: 0x180CF0A60
	|-Dispatch.Install<LobbyGameCreated_t>
	|
	|-RVA: 0xCF0C80 Offset: 0xCF0080 VA: 0x180CF0C80
	|-Dispatch.Install<LobbyInvite_t>
	|
	|-RVA: 0xCF0EA0 Offset: 0xCF02A0 VA: 0x180CF0EA0
	|-Dispatch.Install<LowBatteryPower_t>
	|
	|-RVA: 0xCF10A0 Offset: 0xCF04A0 VA: 0x180CF10A0
	|-Dispatch.Install<MicroTxnAuthorizationResponse_t>
	|
	|-RVA: 0xCF12C0 Offset: 0xCF06C0 VA: 0x180CF12C0
	|-Dispatch.Install<OverlayBrowserProtocolNavigation_t>
	|
	|-RVA: 0xCF14C0 Offset: 0xCF08C0 VA: 0x180CF14C0
	|-Dispatch.Install<P2PSessionConnectFail_t>
	|
	|-RVA: 0xCF16C0 Offset: 0xCF0AC0 VA: 0x180CF16C0
	|-Dispatch.Install<P2PSessionRequest_t>
	|
	|-RVA: 0xCF18C0 Offset: 0xCF0CC0 VA: 0x180CF18C0
	|-Dispatch.Install<PersonaStateChange_t>
	|
	|-RVA: 0xCF1AC0 Offset: 0xCF0EC0 VA: 0x180CF1AC0
	|-Dispatch.Install<PlaybackStatusHasChanged_t>
	|
	|-RVA: 0xCF1CC0 Offset: 0xCF10C0 VA: 0x180CF1CC0
	|-Dispatch.Install<RemoteStoragePublishedFileSubscribed_t>
	|
	|-RVA: 0xCF1EC0 Offset: 0xCF12C0 VA: 0x180CF1EC0
	|-Dispatch.Install<RemoteStoragePublishedFileUnsubscribed_t>
	|
	|-RVA: 0xCF2160 Offset: 0xCF1560 VA: 0x180CF2160
	|-Dispatch.Install<ScreenshotReady_t>
	|
	|-RVA: 0xCF2360 Offset: 0xCF1760 VA: 0x180CF2360
	|-Dispatch.Install<ScreenshotRequested_t>
	|
	|-RVA: 0xCF2560 Offset: 0xCF1960 VA: 0x180CF2560
	|-Dispatch.Install<SteamInventoryDefinitionUpdate_t>
	|
	|-RVA: 0xCF2760 Offset: 0xCF1B60 VA: 0x180CF2760
	|-Dispatch.Install<SteamInventoryFullUpdate_t>
	|
	|-RVA: 0xCF2960 Offset: 0xCF1D60 VA: 0x180CF2960
	|-Dispatch.Install<SteamNetConnectionStatusChangedCallback_t>
	|
	|-RVA: 0xCF2B80 Offset: 0xCF1F80 VA: 0x180CF2B80
	|-Dispatch.Install<SteamNetworkingFakeIPResult_t>
	|
	|-RVA: 0xCF2DB0 Offset: 0xCF21B0 VA: 0x180CF2DB0
	|-Dispatch.Install<SteamParentalSettingsChanged_t>
	|
	|-RVA: 0xCF2FB0 Offset: 0xCF23B0 VA: 0x180CF2FB0
	|-Dispatch.Install<SteamRelayNetworkStatus_t>
	|
	|-RVA: 0xCF31D0 Offset: 0xCF25D0 VA: 0x180CF31D0
	|-Dispatch.Install<SteamRemotePlaySessionConnected_t>
	|
	|-RVA: 0xCF33D0 Offset: 0xCF27D0 VA: 0x180CF33D0
	|-Dispatch.Install<SteamRemotePlaySessionDisconnected_t>
	|
	|-RVA: 0xCF35D0 Offset: 0xCF29D0 VA: 0x180CF35D0
	|-Dispatch.Install<SteamServerConnectFailure_t>
	|
	|-RVA: 0xCF37D0 Offset: 0xCF2BD0 VA: 0x180CF37D0
	|-Dispatch.Install<SteamServersConnected_t>
	|
	|-RVA: 0xCF39D0 Offset: 0xCF2DD0 VA: 0x180CF39D0
	|-Dispatch.Install<SteamServersDisconnected_t>
	|
	|-RVA: 0xCF3BD0 Offset: 0xCF2FD0 VA: 0x180CF3BD0
	|-Dispatch.Install<SteamShutdown_t>
	|
	|-RVA: 0xCF3DD0 Offset: 0xCF31D0 VA: 0x180CF3DD0
	|-Dispatch.Install<UserAchievementIconFetched_t>
	|
	|-RVA: 0xCF3FF0 Offset: 0xCF33F0 VA: 0x180CF3FF0
	|-Dispatch.Install<UserAchievementStored_t>
	|
	|-RVA: 0xCF4210 Offset: 0xCF3610 VA: 0x180CF4210
	|-Dispatch.Install<UserStatsReceived_t>
	|
	|-RVA: 0xCF4430 Offset: 0xCF3830 VA: 0x180CF4430
	|-Dispatch.Install<UserStatsStored_t>
	|
	|-RVA: 0xCF4630 Offset: 0xCF3A30 VA: 0x180CF4630
	|-Dispatch.Install<UserStatsUnloaded_t>
	|
	|-RVA: 0xCF4830 Offset: 0xCF3C30 VA: 0x180CF4830
	|-Dispatch.Install<ValidateAuthTicketResponse_t>
	|
	|-RVA: 0xCF4A50 Offset: 0xCF3E50 VA: 0x180CF4A50
	|-Dispatch.Install<VolumeHasChanged_t>
	|
	|-RVA: 0xCF20C0 Offset: 0xCF14C0 VA: 0x180CF20C0
	|-Dispatch.Install<object>
	*/

	internal static void ShutdownClient() { }

	private static void .cctor() { }

}

internal struct Dispatch.CallbackMsg_t // TypeDefIndex: 5105
{	public HSteamUser m_hSteamUser; // 0x0
	public CallbackType Type; // 0x4
	public IntPtr Data; // 0x8
	public int DataSize; // 0x10

}

private struct Dispatch.ResultCallback // TypeDefIndex: 5106
{	public Action continuation; // 0x0
	public bool server; // 0x8

}

private struct Dispatch.Callback // TypeDefIndex: 5107
{	public Action<IntPtr> action; // 0x0
	public bool server; // 0x8

}

private sealed class Dispatch.<>c // TypeDefIndex: 5108
{	public static readonly Dispatch.<>c <>9; // 0x0
	public static Func<FieldInfo, int> <>9__20_0; // 0x8
	public static Predicate<Dispatch.Callback> <>9__31_3; // 0x10
	public static Func<KeyValuePair<ulong, Dispatch.ResultCallback>, bool> <>9__31_0; // 0x18
	public static Func<KeyValuePair<ulong, Dispatch.ResultCallback>, ulong> <>9__31_1; // 0x20
	public static Func<KeyValuePair<ulong, Dispatch.ResultCallback>, Dispatch.ResultCallback> <>9__31_2; // 0x28


	private static void .cctor() { }

	public void .ctor() { }

	internal int <CallbackToString>b__20_0(FieldInfo x) { }

	internal bool <ShutdownClient>b__31_3(Dispatch.Callback x) { }

	internal bool <ShutdownClient>b__31_0(KeyValuePair<ulong, Dispatch.ResultCallback> x) { }

	internal ulong <ShutdownClient>b__31_1(KeyValuePair<ulong, Dispatch.ResultCallback> x) { }

	internal Dispatch.ResultCallback <ShutdownClient>b__31_2(KeyValuePair<ulong, Dispatch.ResultCallback> x) { }

}

private struct Dispatch.<LoopClientAsync>d__22 : IAsyncStateMachine // TypeDefIndex: 5109
{	public int <>1__state; // 0x0
	public AsyncVoidMethodBuilder <>t__builder; // 0x8
	private TaskAwaiter <>u__1; // 0x28


	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

private sealed class Dispatch.<>c__DisplayClass29_0<T> // TypeDefIndex: 5110
{	public Action<T> p; // 0x0


	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD55DC0 Offset: 0xD551C0 VA: 0x180D55DC0
	|-Dispatch.<>c__DisplayClass29_0<ActiveBeaconsUpdated_t>..ctor
	|-Dispatch.<>c__DisplayClass29_0<AvailableBeaconLocationsUpdated_t>..ctor
	|-Dispatch.<>c__DisplayClass29_0<ClientGameServerDeny_t>..ctor
	|-Dispatch.<>c__DisplayClass29_0<DownloadItemResult_t>..ctor
	|-Dispatch.<>c__DisplayClass29_0<DurationControl_t>..ctor
	|-Dispatch.<>c__DisplayClass29_0<FriendRichPresenceUpdate_t>..ctor
	|-Dispatch.<>c__DisplayClass29_0<GameConnectedClanChatMsg_t>..ctor
	|-Dispatch.<>c__DisplayClass29_0<GameConnectedFriendChatMsg_t>..ctor
	|-Dispatch.<>c__DisplayClass29_0<GameLobbyJoinRequested_t>..ctor
	|-Dispatch.<>c__DisplayClass29_0<GameOverlayActivated_t>..ctor
	|-Dispatch.<>c__DisplayClass29_0<GameRichPresenceJoinRequested_t>..ctor
	|-Dispatch.<>c__DisplayClass29_0<GameServerChangeRequested_t>..ctor
	|-Dispatch.<>c__DisplayClass29_0<GameWebCallback_t>..ctor
	|-Dispatch.<>c__DisplayClass29_0<GamepadTextInputDismissed_t>..ctor
	|-Dispatch.<>c__DisplayClass29_0<GetAuthSessionTicketResponse_t>..ctor
	|-Dispatch.<>c__DisplayClass29_0<IPCountry_t>..ctor
	|-Dispatch.<>c__DisplayClass29_0<ItemInstalled_t>..ctor
	|-Dispatch.<>c__DisplayClass29_0<LicensesUpdated_t>..ctor
	|-Dispatch.<>c__DisplayClass29_0<LobbyChatMsg_t>..ctor
	|-Dispatch.<>c__DisplayClass29_0<LobbyChatUpdate_t>..ctor
	|-Dispatch.<>c__DisplayClass29_0<LobbyCreated_t>..ctor
	|-Dispatch.<>c__DisplayClass29_0<LobbyDataUpdate_t>..ctor
	|-Dispatch.<>c__DisplayClass29_0<LobbyEnter_t>..ctor
	|-Dispatch.<>c__DisplayClass29_0<LobbyGameCreated_t>..ctor
	|-Dispatch.<>c__DisplayClass29_0<LobbyInvite_t>..ctor
	|-Dispatch.<>c__DisplayClass29_0<LowBatteryPower_t>..ctor
	|-Dispatch.<>c__DisplayClass29_0<MicroTxnAuthorizationResponse_t>..ctor
	|-Dispatch.<>c__DisplayClass29_0<OverlayBrowserProtocolNavigation_t>..ctor
	|-Dispatch.<>c__DisplayClass29_0<P2PSessionConnectFail_t>..ctor
	|-Dispatch.<>c__DisplayClass29_0<P2PSessionRequest_t>..ctor
	|-Dispatch.<>c__DisplayClass29_0<PersonaStateChange_t>..ctor
	|-Dispatch.<>c__DisplayClass29_0<PlaybackStatusHasChanged_t>..ctor
	|-Dispatch.<>c__DisplayClass29_0<RemoteStoragePublishedFileSubscribed_t>..ctor
	|-Dispatch.<>c__DisplayClass29_0<RemoteStoragePublishedFileUnsubscribed_t>..ctor
	|-Dispatch.<>c__DisplayClass29_0<ScreenshotReady_t>..ctor
	|-Dispatch.<>c__DisplayClass29_0<ScreenshotRequested_t>..ctor
	|-Dispatch.<>c__DisplayClass29_0<SteamInventoryDefinitionUpdate_t>..ctor
	|-Dispatch.<>c__DisplayClass29_0<SteamInventoryFullUpdate_t>..ctor
	|-Dispatch.<>c__DisplayClass29_0<SteamNetConnectionStatusChangedCallback_t>..ctor
	|-Dispatch.<>c__DisplayClass29_0<SteamNetworkingFakeIPResult_t>..ctor
	|-Dispatch.<>c__DisplayClass29_0<SteamParentalSettingsChanged_t>..ctor
	|-Dispatch.<>c__DisplayClass29_0<SteamRelayNetworkStatus_t>..ctor
	|-Dispatch.<>c__DisplayClass29_0<SteamRemotePlaySessionConnected_t>..ctor
	|-Dispatch.<>c__DisplayClass29_0<SteamRemotePlaySessionDisconnected_t>..ctor
	|-Dispatch.<>c__DisplayClass29_0<SteamServerConnectFailure_t>..ctor
	|-Dispatch.<>c__DisplayClass29_0<SteamServersConnected_t>..ctor
	|-Dispatch.<>c__DisplayClass29_0<SteamServersDisconnected_t>..ctor
	|-Dispatch.<>c__DisplayClass29_0<SteamShutdown_t>..ctor
	|-Dispatch.<>c__DisplayClass29_0<UserAchievementIconFetched_t>..ctor
	|-Dispatch.<>c__DisplayClass29_0<UserAchievementStored_t>..ctor
	|-Dispatch.<>c__DisplayClass29_0<UserStatsReceived_t>..ctor
	|-Dispatch.<>c__DisplayClass29_0<UserStatsStored_t>..ctor
	|-Dispatch.<>c__DisplayClass29_0<UserStatsUnloaded_t>..ctor
	|-Dispatch.<>c__DisplayClass29_0<ValidateAuthTicketResponse_t>..ctor
	|-Dispatch.<>c__DisplayClass29_0<VolumeHasChanged_t>..ctor
	|-Dispatch.<>c__DisplayClass29_0<object>..ctor
	*/

	internal void <Install>b__0(IntPtr x) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A422E0 Offset: 0x1A416E0 VA: 0x181A422E0
	|-Dispatch.<>c__DisplayClass29_0<ActiveBeaconsUpdated_t>.<Install>b__0
	|
	|-RVA: 0x1A43C20 Offset: 0x1A43020 VA: 0x181A43C20
	|-Dispatch.<>c__DisplayClass29_0<AvailableBeaconLocationsUpdated_t>.<Install>b__0
	|
	|-RVA: 0x1A429D0 Offset: 0x1A41DD0 VA: 0x181A429D0
	|-Dispatch.<>c__DisplayClass29_0<ClientGameServerDeny_t>.<Install>b__0
	|
	|-RVA: 0x1A44370 Offset: 0x1A43770 VA: 0x181A44370
	|-Dispatch.<>c__DisplayClass29_0<DownloadItemResult_t>.<Install>b__0
	|
	|-RVA: 0x1A42010 Offset: 0x1A41410 VA: 0x181A42010
	|-Dispatch.<>c__DisplayClass29_0<DurationControl_t>.<Install>b__0
	|
	|-RVA: 0x1A42510 Offset: 0x1A41910 VA: 0x181A42510
	|-Dispatch.<>c__DisplayClass29_0<FriendRichPresenceUpdate_t>.<Install>b__0
	|
	|-RVA: 0x1A43F70 Offset: 0x1A43370 VA: 0x181A43F70
	|-Dispatch.<>c__DisplayClass29_0<GameConnectedClanChatMsg_t>.<Install>b__0
	|
	|-RVA: 0x1A42B40 Offset: 0x1A41F40 VA: 0x181A42B40
	|-Dispatch.<>c__DisplayClass29_0<GameConnectedFriendChatMsg_t>.<Install>b__0
	|
	|-RVA: 0x1A420D0 Offset: 0x1A414D0 VA: 0x181A420D0
	|-Dispatch.<>c__DisplayClass29_0<GameLobbyJoinRequested_t>.<Install>b__0
	|
	|-RVA: 0x1A43D70 Offset: 0x1A43170 VA: 0x181A43D70
	|-Dispatch.<>c__DisplayClass29_0<GameOverlayActivated_t>.<Install>b__0
	|
	|-RVA: 0x1A444F0 Offset: 0x1A438F0 VA: 0x181A444F0
	|-Dispatch.<>c__DisplayClass29_0<GameRichPresenceJoinRequested_t>.<Install>b__0
	|
	|-RVA: 0x1A42670 Offset: 0x1A41A70 VA: 0x181A42670
	|-Dispatch.<>c__DisplayClass29_0<GameServerChangeRequested_t>.<Install>b__0
	|
	|-RVA: 0x1A442D0 Offset: 0x1A436D0 VA: 0x181A442D0
	|-Dispatch.<>c__DisplayClass29_0<GameWebCallback_t>.<Install>b__0
	|
	|-RVA: 0x1A43E10 Offset: 0x1A43210 VA: 0x181A43E10
	|-Dispatch.<>c__DisplayClass29_0<GamepadTextInputDismissed_t>.<Install>b__0
	|
	|-RVA: 0x1A44030 Offset: 0x1A43430 VA: 0x181A44030
	|-Dispatch.<>c__DisplayClass29_0<GetAuthSessionTicketResponse_t>.<Install>b__0
	|
	|-RVA: 0x1A43410 Offset: 0x1A42810 VA: 0x181A43410
	|-Dispatch.<>c__DisplayClass29_0<IPCountry_t>.<Install>b__0
	|
	|-RVA: 0x1A43800 Offset: 0x1A42C00 VA: 0x181A43800
	|-Dispatch.<>c__DisplayClass29_0<ItemInstalled_t>.<Install>b__0
	|
	|-RVA: 0x1A44640 Offset: 0x1A43A40 VA: 0x181A44640
	|-Dispatch.<>c__DisplayClass29_0<LicensesUpdated_t>.<Install>b__0
	|
	|-RVA: 0x1A432B0 Offset: 0x1A426B0 VA: 0x181A432B0
	|-Dispatch.<>c__DisplayClass29_0<LobbyChatMsg_t>.<Install>b__0
	|
	|-RVA: 0x1A43740 Offset: 0x1A42B40 VA: 0x181A43740
	|-Dispatch.<>c__DisplayClass29_0<LobbyChatUpdate_t>.<Install>b__0
	|
	|-RVA: 0x1A42DF0 Offset: 0x1A421F0 VA: 0x181A42DF0
	|-Dispatch.<>c__DisplayClass29_0<LobbyCreated_t>.<Install>b__0
	|
	|-RVA: 0x1A42450 Offset: 0x1A41850 VA: 0x181A42450
	|-Dispatch.<>c__DisplayClass29_0<LobbyDataUpdate_t>.<Install>b__0
	|
	|-RVA: 0x1A43B60 Offset: 0x1A42F60 VA: 0x181A43B60
	|-Dispatch.<>c__DisplayClass29_0<LobbyEnter_t>.<Install>b__0
	|
	|-RVA: 0x1A42A80 Offset: 0x1A41E80 VA: 0x181A42A80
	|-Dispatch.<>c__DisplayClass29_0<LobbyGameCreated_t>.<Install>b__0
	|
	|-RVA: 0x1A42390 Offset: 0x1A41790 VA: 0x181A42390
	|-Dispatch.<>c__DisplayClass29_0<LobbyInvite_t>.<Install>b__0
	|
	|-RVA: 0x1A43CD0 Offset: 0x1A430D0 VA: 0x181A43CD0
	|-Dispatch.<>c__DisplayClass29_0<LowBatteryPower_t>.<Install>b__0
	|
	|-RVA: 0x1A431F0 Offset: 0x1A425F0 VA: 0x181A431F0
	|-Dispatch.<>c__DisplayClass29_0<MicroTxnAuthorizationResponse_t>.<Install>b__0
	|
	|-RVA: 0x1A440D0 Offset: 0x1A434D0 VA: 0x181A440D0
	|-Dispatch.<>c__DisplayClass29_0<OverlayBrowserProtocolNavigation_t>.<Install>b__0
	|
	|-RVA: 0x1A42D40 Offset: 0x1A42140 VA: 0x181A42D40
	|-Dispatch.<>c__DisplayClass29_0<P2PSessionConnectFail_t>.<Install>b__0
	|
	|-RVA: 0x1A435F0 Offset: 0x1A429F0 VA: 0x181A435F0
	|-Dispatch.<>c__DisplayClass29_0<P2PSessionRequest_t>.<Install>b__0
	|
	|-RVA: 0x1A43950 Offset: 0x1A42D50 VA: 0x181A43950
	|-Dispatch.<>c__DisplayClass29_0<PersonaStateChange_t>.<Install>b__0
	|
	|-RVA: 0x1A43690 Offset: 0x1A42A90 VA: 0x181A43690
	|-Dispatch.<>c__DisplayClass29_0<PlaybackStatusHasChanged_t>.<Install>b__0
	|
	|-RVA: 0x1A42720 Offset: 0x1A41B20 VA: 0x181A42720
	|-Dispatch.<>c__DisplayClass29_0<RemoteStoragePublishedFileSubscribed_t>.<Install>b__0
	|
	|-RVA: 0x1A42EA0 Offset: 0x1A422A0 VA: 0x181A42EA0
	|-Dispatch.<>c__DisplayClass29_0<RemoteStoragePublishedFileUnsubscribed_t>.<Install>b__0
	|
	|-RVA: 0x1A438B0 Offset: 0x1A42CB0 VA: 0x181A438B0
	|-Dispatch.<>c__DisplayClass29_0<ScreenshotReady_t>.<Install>b__0
	|
	|-RVA: 0x1A42F50 Offset: 0x1A42350 VA: 0x181A42F50
	|-Dispatch.<>c__DisplayClass29_0<ScreenshotRequested_t>.<Install>b__0
	|
	|-RVA: 0x1A43AB0 Offset: 0x1A42EB0 VA: 0x181A43AB0
	|-Dispatch.<>c__DisplayClass29_0<SteamInventoryDefinitionUpdate_t>.<Install>b__0
	|
	|-RVA: 0x1A43000 Offset: 0x1A42400 VA: 0x181A43000
	|-Dispatch.<>c__DisplayClass29_0<SteamInventoryFullUpdate_t>.<Install>b__0
	|
	|-RVA: 0x1A42890 Offset: 0x1A41C90 VA: 0x181A42890
	|-Dispatch.<>c__DisplayClass29_0<SteamNetConnectionStatusChangedCallback_t>.<Install>b__0
	|
	|-RVA: 0x1A434C0 Offset: 0x1A428C0 VA: 0x181A434C0
	|-Dispatch.<>c__DisplayClass29_0<SteamNetworkingFakeIPResult_t>.<Install>b__0
	|
	|-RVA: 0x1A41F60 Offset: 0x1A41360 VA: 0x181A41F60
	|-Dispatch.<>c__DisplayClass29_0<SteamParentalSettingsChanged_t>.<Install>b__0
	|
	|-RVA: 0x1A42180 Offset: 0x1A41580 VA: 0x181A42180
	|-Dispatch.<>c__DisplayClass29_0<SteamRelayNetworkStatus_t>.<Install>b__0
	|
	|-RVA: 0x1A445A0 Offset: 0x1A439A0 VA: 0x181A445A0
	|-Dispatch.<>c__DisplayClass29_0<SteamRemotePlaySessionConnected_t>.<Install>b__0
	|
	|-RVA: 0x1A43150 Offset: 0x1A42550 VA: 0x181A43150
	|-Dispatch.<>c__DisplayClass29_0<SteamRemotePlaySessionDisconnected_t>.<Install>b__0
	|
	|-RVA: 0x1A42240 Offset: 0x1A41640 VA: 0x181A42240
	|-Dispatch.<>c__DisplayClass29_0<SteamServerConnectFailure_t>.<Install>b__0
	|
	|-RVA: 0x1A43A00 Offset: 0x1A42E00 VA: 0x181A43A00
	|-Dispatch.<>c__DisplayClass29_0<SteamServersConnected_t>.<Install>b__0
	|
	|-RVA: 0x1A42BF0 Offset: 0x1A41FF0 VA: 0x181A42BF0
	|-Dispatch.<>c__DisplayClass29_0<SteamServersDisconnected_t>.<Install>b__0
	|
	|-RVA: 0x1A430A0 Offset: 0x1A424A0 VA: 0x181A430A0
	|-Dispatch.<>c__DisplayClass29_0<SteamShutdown_t>.<Install>b__0
	|
	|-RVA: 0x1A44170 Offset: 0x1A43570 VA: 0x181A44170
	|-Dispatch.<>c__DisplayClass29_0<UserAchievementIconFetched_t>.<Install>b__0
	|
	|-RVA: 0x1A44430 Offset: 0x1A43830 VA: 0x181A44430
	|-Dispatch.<>c__DisplayClass29_0<UserAchievementStored_t>.<Install>b__0
	|
	|-RVA: 0x1A427D0 Offset: 0x1A41BD0 VA: 0x181A427D0
	|-Dispatch.<>c__DisplayClass29_0<UserStatsReceived_t>.<Install>b__0
	|
	|-RVA: 0x1A42C90 Offset: 0x1A42090 VA: 0x181A42C90
	|-Dispatch.<>c__DisplayClass29_0<UserStatsStored_t>.<Install>b__0
	|
	|-RVA: 0x1A44230 Offset: 0x1A43630 VA: 0x181A44230
	|-Dispatch.<>c__DisplayClass29_0<UserStatsUnloaded_t>.<Install>b__0
	|
	|-RVA: 0x1A43EB0 Offset: 0x1A432B0 VA: 0x181A43EB0
	|-Dispatch.<>c__DisplayClass29_0<ValidateAuthTicketResponse_t>.<Install>b__0
	|
	|-RVA: 0x1A425C0 Offset: 0x1A419C0 VA: 0x181A425C0
	|-Dispatch.<>c__DisplayClass29_0<VolumeHasChanged_t>.<Install>b__0
	|
	|-RVA: 0x1A43370 Offset: 0x1A42770 VA: 0x181A43370
	|-Dispatch.<>c__DisplayClass29_0<object>.<Install>b__0
	*/

}

