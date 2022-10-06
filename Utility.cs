internal class Utility // TypeDefIndex: 4722
{
	[DebuggerBrowsableAttribute] 
	[CompilerGeneratedAttribute] 
	private static Action<bool> GraphicsResourcesRecreate; 
	[DebuggerBrowsableAttribute] 
	[CompilerGeneratedAttribute] 
	private static Action EngineUpdate; 
	[DebuggerBrowsableAttribute] 
	[CompilerGeneratedAttribute] 
	private static Action FlushPendingResources; 
	private static ProfilerMarker s_MarkerRaiseEngineUpdate; 


	[RequiredByNativeCodeAttribute] 
	internal static void RaiseGraphicsResourcesRecreate(bool recreate) { }

	[RequiredByNativeCodeAttribute] 
	internal static void RaiseEngineUpdate() { }

	[RequiredByNativeCodeAttribute] 
	internal static void RaiseFlushPendingResources() { }

	private static void .cctor() { }

}

public class Utility.GPUBuffer<T> // TypeDefIndex: 4723
{
	private IntPtr buffer; 

}

public static class Utility // TypeDefIndex: 5276
{
	private static readonly byte[] readBuffer; 


	[ExtensionAttribute] 
	internal static T ToType<T>(IntPtr ptr) { }
	/* GenericInstMethod :
	|
	|-Utility.ToType<ActiveBeaconsUpdated_t>
	|
	|-Utility.ToType<AvailableBeaconLocationsUpdated_t>
	|
	|-Utility.ToType<ClientGameServerDeny_t>
	|
	|-Utility.ToType<DownloadItemResult_t>
	|
	|-Utility.ToType<DurationControl_t>
	|
	|-Utility.ToType<FriendRichPresenceUpdate_t>
	|
	|-Utility.ToType<GameConnectedClanChatMsg_t>
	|
	|-Utility.ToType<GameConnectedFriendChatMsg_t>
	|
	|-Utility.ToType<GameLobbyJoinRequested_t>
	|
	|-Utility.ToType<GameOverlayActivated_t>
	|
	|-Utility.ToType<GameRichPresenceJoinRequested_t>
	|
	|-Utility.ToType<GameServerChangeRequested_t>
	|
	|-Utility.ToType<GameWebCallback_t>
	|
	|-Utility.ToType<GamepadTextInputDismissed_t>
	|
	|-Utility.ToType<GetAuthSessionTicketResponse_t>
	|
	|-Utility.ToType<IPCountry_t>
	|
	|-Utility.ToType<ItemInstalled_t>
	|
	|-Utility.ToType<LicensesUpdated_t>
	|
	|-Utility.ToType<LobbyChatMsg_t>
	|
	|-Utility.ToType<LobbyChatUpdate_t>
	|
	|-Utility.ToType<LobbyCreated_t>
	|
	|-Utility.ToType<LobbyDataUpdate_t>
	|
	|-Utility.ToType<LobbyEnter_t>
	|
	|-Utility.ToType<LobbyGameCreated_t>
	|
	|-Utility.ToType<LobbyInvite_t>
	|
	|-Utility.ToType<LowBatteryPower_t>
	|
	|-Utility.ToType<MicroTxnAuthorizationResponse_t>
	|
	|-Utility.ToType<OverlayBrowserProtocolNavigation_t>
	|
	|-Utility.ToType<P2PSessionConnectFail_t>
	|
	|-Utility.ToType<P2PSessionRequest_t>
	|
	|-Utility.ToType<PersonaStateChange_t>
	|
	|-Utility.ToType<PlaybackStatusHasChanged_t>
	|
	|-Utility.ToType<RemoteStoragePublishedFileSubscribed_t>
	|
	|-Utility.ToType<RemoteStoragePublishedFileUnsubscribed_t>
	|
	|-Utility.ToType<ScreenshotReady_t>
	|
	|-Utility.ToType<ScreenshotRequested_t>
	|
	|-Utility.ToType<SteamAPICallCompleted_t>
	|
	|-Utility.ToType<SteamInventoryDefinitionUpdate_t>
	|
	|-Utility.ToType<SteamInventoryFullUpdate_t>
	|
	|-Utility.ToType<SteamNetConnectionStatusChangedCallback_t>
	|
	|-Utility.ToType<SteamNetworkingFakeIPResult_t>
	|
	|-Utility.ToType<SteamParentalSettingsChanged_t>
	|
	|-Utility.ToType<SteamRelayNetworkStatus_t>
	|
	|-Utility.ToType<SteamRemotePlaySessionConnected_t>
	|
	|-Utility.ToType<SteamRemotePlaySessionDisconnected_t>
	|
	|-Utility.ToType<SteamServerConnectFailure_t>
	|
	|-Utility.ToType<SteamServersConnected_t>
	|
	|-Utility.ToType<SteamServersDisconnected_t>
	|
	|-Utility.ToType<SteamShutdown_t>
	|
	|-Utility.ToType<UserAchievementIconFetched_t>
	|
	|-Utility.ToType<UserAchievementStored_t>
	|
	|-Utility.ToType<UserStatsReceived_t>
	|
	|-Utility.ToType<UserStatsStored_t>
	|
	|-Utility.ToType<UserStatsUnloaded_t>
	|
	|-Utility.ToType<ValidateAuthTicketResponse_t>
	|
	|-Utility.ToType<VolumeHasChanged_t>
	|
	|-Utility.ToType<gameserveritem_t>
	|
	|-Utility.ToType<object>
	*/

	[ExtensionAttribute] 
	internal static object ToType(IntPtr ptr, Type t) { }

	internal static uint Swap(uint x) { }

	[ExtensionAttribute] 
	public static uint IpToInt32(IPAddress ipAddress) { }

	public static IPAddress Int32ToIp(uint ipAddress) { }

	public static string FormatPrice(string currency, double price) { }

	[ExtensionAttribute] 
	public static string ReadNullTerminatedUTF8String(BinaryReader br) { }

	private static void .cctor() { }

}

