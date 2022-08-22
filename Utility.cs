internal class Utility // TypeDefIndex: 4719
{	[DebuggerBrowsableAttribute] // RVA: 0x70650 Offset: 0x6FA50 VA: 0x180070650
	[CompilerGeneratedAttribute] // RVA: 0x70650 Offset: 0x6FA50 VA: 0x180070650
	private static Action<bool> GraphicsResourcesRecreate; // 0x0
	[DebuggerBrowsableAttribute] // RVA: 0x70650 Offset: 0x6FA50 VA: 0x180070650
	[CompilerGeneratedAttribute] // RVA: 0x70650 Offset: 0x6FA50 VA: 0x180070650
	private static Action EngineUpdate; // 0x8
	[DebuggerBrowsableAttribute] // RVA: 0x70650 Offset: 0x6FA50 VA: 0x180070650
	[CompilerGeneratedAttribute] // RVA: 0x70650 Offset: 0x6FA50 VA: 0x180070650
	private static Action FlushPendingResources; // 0x10
	private static ProfilerMarker s_MarkerRaiseEngineUpdate; // 0x18


	[RequiredByNativeCodeAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	internal static void RaiseGraphicsResourcesRecreate(bool recreate) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	internal static void RaiseEngineUpdate() { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	internal static void RaiseFlushPendingResources() { }

	private static void .cctor() { }

}

public class Utility.GPUBuffer<T> // TypeDefIndex: 4720
{	private IntPtr buffer; // 0x0

}

public static class Utility // TypeDefIndex: 5272
{	private static readonly byte[] readBuffer; // 0x12B44


	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	internal static T ToType<T>(IntPtr ptr) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5EE080 Offset: 0x5ED480 VA: 0x1805EE080
	|-Utility.ToType<ActiveBeaconsUpdated_t>
	|
	|-RVA: 0x5EE190 Offset: 0x5ED590 VA: 0x1805EE190
	|-Utility.ToType<AvailableBeaconLocationsUpdated_t>
	|
	|-RVA: 0x5EE2A0 Offset: 0x5ED6A0 VA: 0x1805EE2A0
	|-Utility.ToType<ClientGameServerDeny_t>
	|
	|-RVA: 0x5EE3D0 Offset: 0x5ED7D0 VA: 0x1805EE3D0
	|-Utility.ToType<DownloadItemResult_t>
	|
	|-RVA: 0x5EE520 Offset: 0x5ED920 VA: 0x1805EE520
	|-Utility.ToType<DurationControl_t>
	|
	|-RVA: 0x5EE660 Offset: 0x5EDA60 VA: 0x1805EE660
	|-Utility.ToType<FriendRichPresenceUpdate_t>
	|
	|-RVA: 0x5EE790 Offset: 0x5EDB90 VA: 0x1805EE790
	|-Utility.ToType<GameConnectedClanChatMsg_t>
	|
	|-RVA: 0x5EE8D0 Offset: 0x5EDCD0 VA: 0x1805EE8D0
	|-Utility.ToType<GameConnectedFriendChatMsg_t>
	|
	|-RVA: 0x5EEA00 Offset: 0x5EDE00 VA: 0x1805EEA00
	|-Utility.ToType<GameLobbyJoinRequested_t>
	|
	|-RVA: 0x5EEB30 Offset: 0x5EDF30 VA: 0x1805EEB30
	|-Utility.ToType<GameOverlayActivated_t>
	|
	|-RVA: 0x5EEC40 Offset: 0x5EE040 VA: 0x1805EEC40
	|-Utility.ToType<GameRichPresenceJoinRequested_t>
	|
	|-RVA: 0x5EED70 Offset: 0x5EE170 VA: 0x1805EED70
	|-Utility.ToType<GameServerChangeRequested_t>
	|
	|-RVA: 0x5EEEA0 Offset: 0x5EE2A0 VA: 0x1805EEEA0
	|-Utility.ToType<GameWebCallback_t>
	|
	|-RVA: 0x5EEFB0 Offset: 0x5EE3B0 VA: 0x1805EEFB0
	|-Utility.ToType<GamepadTextInputDismissed_t>
	|
	|-RVA: 0x5EF0C0 Offset: 0x5EE4C0 VA: 0x1805EF0C0
	|-Utility.ToType<GetAuthSessionTicketResponse_t>
	|
	|-RVA: 0x5EF1D0 Offset: 0x5EE5D0 VA: 0x1805EF1D0
	|-Utility.ToType<IPCountry_t>
	|
	|-RVA: 0x5EF2E0 Offset: 0x5EE6E0 VA: 0x1805EF2E0
	|-Utility.ToType<ItemInstalled_t>
	|
	|-RVA: 0x5EF410 Offset: 0x5EE810 VA: 0x1805EF410
	|-Utility.ToType<LicensesUpdated_t>
	|
	|-RVA: 0x5EF520 Offset: 0x5EE920 VA: 0x1805EF520
	|-Utility.ToType<LobbyChatMsg_t>
	|
	|-RVA: 0x5EF670 Offset: 0x5EEA70 VA: 0x1805EF670
	|-Utility.ToType<LobbyChatUpdate_t>
	|
	|-RVA: 0x5EF7B0 Offset: 0x5EEBB0 VA: 0x1805EF7B0
	|-Utility.ToType<LobbyCreated_t>
	|
	|-RVA: 0x5EF8E0 Offset: 0x5EECE0 VA: 0x1805EF8E0
	|-Utility.ToType<LobbyDataUpdate_t>
	|
	|-RVA: 0x5EFA30 Offset: 0x5EEE30 VA: 0x1805EFA30
	|-Utility.ToType<LobbyEnter_t>
	|
	|-RVA: 0x5EFB80 Offset: 0x5EEF80 VA: 0x1805EFB80
	|-Utility.ToType<LobbyGameCreated_t>
	|
	|-RVA: 0x5EFCD0 Offset: 0x5EF0D0 VA: 0x1805EFCD0
	|-Utility.ToType<LobbyInvite_t>
	|
	|-RVA: 0x5EFE20 Offset: 0x5EF220 VA: 0x1805EFE20
	|-Utility.ToType<LowBatteryPower_t>
	|
	|-RVA: 0x5EFF30 Offset: 0x5EF330 VA: 0x1805EFF30
	|-Utility.ToType<MicroTxnAuthorizationResponse_t>
	|
	|-RVA: 0x5F0080 Offset: 0x5EF480 VA: 0x1805F0080
	|-Utility.ToType<OverlayBrowserProtocolNavigation_t>
	|
	|-RVA: 0x5F0190 Offset: 0x5EF590 VA: 0x1805F0190
	|-Utility.ToType<P2PSessionConnectFail_t>
	|
	|-RVA: 0x5F02C0 Offset: 0x5EF6C0 VA: 0x1805F02C0
	|-Utility.ToType<P2PSessionRequest_t>
	|
	|-RVA: 0x5F03D0 Offset: 0x5EF7D0 VA: 0x1805F03D0
	|-Utility.ToType<PersonaStateChange_t>
	|
	|-RVA: 0x5F0500 Offset: 0x5EF900 VA: 0x1805F0500
	|-Utility.ToType<PlaybackStatusHasChanged_t>
	|
	|-RVA: 0x5F0610 Offset: 0x5EFA10 VA: 0x1805F0610
	|-Utility.ToType<RemoteStoragePublishedFileSubscribed_t>
	|
	|-RVA: 0x5F0740 Offset: 0x5EFB40 VA: 0x1805F0740
	|-Utility.ToType<RemoteStoragePublishedFileUnsubscribed_t>
	|
	|-RVA: 0x5F0980 Offset: 0x5EFD80 VA: 0x1805F0980
	|-Utility.ToType<ScreenshotReady_t>
	|
	|-RVA: 0x5F0A90 Offset: 0x5EFE90 VA: 0x1805F0A90
	|-Utility.ToType<ScreenshotRequested_t>
	|
	|-RVA: 0x5F0BA0 Offset: 0x5EFFA0 VA: 0x1805F0BA0
	|-Utility.ToType<SteamAPICallCompleted_t>
	|
	|-RVA: 0x5F0CD0 Offset: 0x5F00D0 VA: 0x1805F0CD0
	|-Utility.ToType<SteamInventoryDefinitionUpdate_t>
	|
	|-RVA: 0x5F0DE0 Offset: 0x5F01E0 VA: 0x1805F0DE0
	|-Utility.ToType<SteamInventoryFullUpdate_t>
	|
	|-RVA: 0x5F0EF0 Offset: 0x5F02F0 VA: 0x1805F0EF0
	|-Utility.ToType<SteamNetConnectionStatusChangedCallback_t>
	|
	|-RVA: 0x5F1140 Offset: 0x5F0540 VA: 0x1805F1140
	|-Utility.ToType<SteamNetworkingFakeIPResult_t>
	|
	|-RVA: 0x5F1310 Offset: 0x5F0710 VA: 0x1805F1310
	|-Utility.ToType<SteamParentalSettingsChanged_t>
	|
	|-RVA: 0x5F1420 Offset: 0x5F0820 VA: 0x1805F1420
	|-Utility.ToType<SteamRelayNetworkStatus_t>
	|
	|-RVA: 0x5F1570 Offset: 0x5F0970 VA: 0x1805F1570
	|-Utility.ToType<SteamRemotePlaySessionConnected_t>
	|
	|-RVA: 0x5F1680 Offset: 0x5F0A80 VA: 0x1805F1680
	|-Utility.ToType<SteamRemotePlaySessionDisconnected_t>
	|
	|-RVA: 0x5F1790 Offset: 0x5F0B90 VA: 0x1805F1790
	|-Utility.ToType<SteamServerConnectFailure_t>
	|
	|-RVA: 0x5F18A0 Offset: 0x5F0CA0 VA: 0x1805F18A0
	|-Utility.ToType<SteamServersConnected_t>
	|
	|-RVA: 0x5F19B0 Offset: 0x5F0DB0 VA: 0x1805F19B0
	|-Utility.ToType<SteamServersDisconnected_t>
	|
	|-RVA: 0x5F1AC0 Offset: 0x5F0EC0 VA: 0x1805F1AC0
	|-Utility.ToType<SteamShutdown_t>
	|
	|-RVA: 0x5F1BD0 Offset: 0x5F0FD0 VA: 0x1805F1BD0
	|-Utility.ToType<UserAchievementIconFetched_t>
	|
	|-RVA: 0x5F1D20 Offset: 0x5F1120 VA: 0x1805F1D20
	|-Utility.ToType<UserAchievementStored_t>
	|
	|-RVA: 0x5F1E60 Offset: 0x5F1260 VA: 0x1805F1E60
	|-Utility.ToType<UserStatsReceived_t>
	|
	|-RVA: 0x5F1FA0 Offset: 0x5F13A0 VA: 0x1805F1FA0
	|-Utility.ToType<UserStatsStored_t>
	|
	|-RVA: 0x5F20D0 Offset: 0x5F14D0 VA: 0x1805F20D0
	|-Utility.ToType<UserStatsUnloaded_t>
	|
	|-RVA: 0x5F21E0 Offset: 0x5F15E0 VA: 0x1805F21E0
	|-Utility.ToType<ValidateAuthTicketResponse_t>
	|
	|-RVA: 0x5F2320 Offset: 0x5F1720 VA: 0x1805F2320
	|-Utility.ToType<VolumeHasChanged_t>
	|
	|-RVA: 0x5F2440 Offset: 0x5F1840 VA: 0x1805F2440
	|-Utility.ToType<gameserveritem_t>
	|
	|-RVA: 0x5F0870 Offset: 0x5EFC70 VA: 0x1805F0870
	|-Utility.ToType<object>
	*/

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	internal static object ToType(IntPtr ptr, Type t) { }

	internal static uint Swap(uint x) { }

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public static uint IpToInt32(IPAddress ipAddress) { }

	public static IPAddress Int32ToIp(uint ipAddress) { }

	public static string FormatPrice(string currency, double price) { }

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public static string ReadNullTerminatedUTF8String(BinaryReader br) { }

	private static void .cctor() { }

}

