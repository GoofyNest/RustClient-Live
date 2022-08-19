internal static class Defines // TypeDefIndex: 5503
{	// Fields
	internal static readonly AppId k_uAppIdInvalid; // 0x0
	internal static readonly DepotId_t k_uDepotIdInvalid; // 0x4
	internal static readonly SteamAPICall_t k_uAPICallInvalid; // 0x8
	internal static readonly PartyBeaconID_t k_ulPartyBeaconIdInvalid; // 0x10
	internal static readonly HAuthTicket k_HAuthTicketInvalid; // 0x18
	internal static readonly uint k_unSteamAccountIDMask; // 0x1C
	internal static readonly uint k_unSteamAccountInstanceMask; // 0x20
	internal static readonly uint k_unSteamUserDefaultInstance; // 0x24
	internal static readonly int k_cchGameExtraInfoMax; // 0x28
	internal static readonly int k_cchMaxFriendsGroupName; // 0x2C
	internal static readonly int k_cFriendsGroupLimit; // 0x30
	internal static readonly FriendsGroupID_t k_FriendsGroupID_Invalid; // 0x34
	internal static readonly int k_cEnumerateFollowersMax; // 0x38
	internal static readonly uint k_cubChatMetadataMax; // 0x3C
	internal static readonly int k_cbMaxGameServerGameDir; // 0x40
	internal static readonly int k_cbMaxGameServerMapName; // 0x44
	internal static readonly int k_cbMaxGameServerGameDescription; // 0x48
	internal static readonly int k_cbMaxGameServerName; // 0x4C
	internal static readonly int k_cbMaxGameServerTags; // 0x50
	internal static readonly int k_cbMaxGameServerGameData; // 0x54
	internal static readonly int HSERVERQUERY_INVALID; // 0x58
	internal static readonly uint k_unFavoriteFlagNone; // 0x5C
	internal static readonly uint k_unFavoriteFlagFavorite; // 0x60
	internal static readonly uint k_unFavoriteFlagHistory; // 0x64
	internal static readonly uint k_unMaxCloudFileChunkSize; // 0x68
	internal static readonly PublishedFileId k_PublishedFileIdInvalid; // 0x70
	internal static readonly UGCHandle_t k_UGCHandleInvalid; // 0x78
	internal static readonly PublishedFileUpdateHandle_t k_PublishedFileUpdateHandleInvalid; // 0x80
	internal static readonly UGCFileWriteStreamHandle_t k_UGCFileStreamHandleInvalid; // 0x88
	internal static readonly uint k_cchPublishedDocumentTitleMax; // 0x90
	internal static readonly uint k_cchPublishedDocumentDescriptionMax; // 0x94
	internal static readonly uint k_cchPublishedDocumentChangeDescriptionMax; // 0x98
	internal static readonly uint k_unEnumeratePublishedFilesMaxResults; // 0x9C
	internal static readonly uint k_cchTagListMax; // 0xA0
	internal static readonly uint k_cchFilenameMax; // 0xA4
	internal static readonly uint k_cchPublishedFileURLMax; // 0xA8
	internal static readonly int k_cubAppProofOfPurchaseKeyMax; // 0xAC
	internal static readonly uint k_nScreenshotMaxTaggedUsers; // 0xB0
	internal static readonly uint k_nScreenshotMaxTaggedPublishedFiles; // 0xB4
	internal static readonly int k_cubUFSTagTypeMax; // 0xB8
	internal static readonly int k_cubUFSTagValueMax; // 0xBC
	internal static readonly int k_ScreenshotThumbWidth; // 0xC0
	internal static readonly UGCQueryHandle_t k_UGCQueryHandleInvalid; // 0xC8
	internal static readonly UGCUpdateHandle_t k_UGCUpdateHandleInvalid; // 0xD0
	internal static readonly uint kNumUGCResultsPerPage; // 0xD8
	internal static readonly uint k_cchDeveloperMetadataMax; // 0xDC
	internal static readonly uint INVALID_HTMLBROWSER; // 0xE0
	internal static readonly InventoryItemId k_SteamItemInstanceIDInvalid; // 0xE8
	internal static readonly SteamInventoryResult_t k_SteamInventoryResultInvalid; // 0xF0
	internal static readonly SteamInventoryUpdateHandle_t k_SteamInventoryUpdateHandleInvalid; // 0xF8
	internal static readonly Connection k_HSteamNetConnection_Invalid; // 0x100
	internal static readonly Socket k_HSteamListenSocket_Invalid; // 0x104
	internal static readonly HSteamNetPollGroup k_HSteamNetPollGroup_Invalid; // 0x108
	internal static readonly int k_cchMaxSteamNetworkingErrMsg; // 0x10C
	internal static readonly int k_cchSteamNetworkingMaxConnectionCloseReason; // 0x110
	internal static readonly int k_cchSteamNetworkingMaxConnectionDescription; // 0x114
	internal static readonly int k_cchSteamNetworkingMaxConnectionAppName; // 0x118
	internal static readonly int k_nSteamNetworkConnectionInfoFlags_Unauthenticated; // 0x11C
	internal static readonly int k_nSteamNetworkConnectionInfoFlags_Unencrypted; // 0x120
	internal static readonly int k_nSteamNetworkConnectionInfoFlags_LoopbackBuffers; // 0x124
	internal static readonly int k_nSteamNetworkConnectionInfoFlags_Fast; // 0x128
	internal static readonly int k_nSteamNetworkConnectionInfoFlags_Relayed; // 0x12C
	internal static readonly int k_nSteamNetworkConnectionInfoFlags_DualWifi; // 0x130
	internal static readonly int k_cbMaxSteamNetworkingSocketsMessageSizeSend; // 0x134
	internal static readonly int k_nSteamNetworkingSend_Unreliable; // 0x138
	internal static readonly int k_nSteamNetworkingSend_NoNagle; // 0x13C
	internal static readonly int k_nSteamNetworkingSend_UnreliableNoNagle; // 0x140
	internal static readonly int k_nSteamNetworkingSend_NoDelay; // 0x144
	internal static readonly int k_nSteamNetworkingSend_UnreliableNoDelay; // 0x148
	internal static readonly int k_nSteamNetworkingSend_Reliable; // 0x14C
	internal static readonly int k_nSteamNetworkingSend_ReliableNoNagle; // 0x150
	internal static readonly int k_nSteamNetworkingSend_UseCurrentThread; // 0x154
	internal static readonly int k_nSteamNetworkingSend_AutoRestartBrokenSession; // 0x158
	internal static readonly int k_cchMaxSteamNetworkingPingLocationString; // 0x15C
	internal static readonly int k_nSteamNetworkingPing_Failed; // 0x160
	internal static readonly int k_nSteamNetworkingPing_Unknown; // 0x164
	internal static readonly int k_nSteamNetworkingConfig_P2P_Transport_ICE_Enable_Default; // 0x168
	internal static readonly int k_nSteamNetworkingConfig_P2P_Transport_ICE_Enable_Disable; // 0x16C
	internal static readonly int k_nSteamNetworkingConfig_P2P_Transport_ICE_Enable_Relay; // 0x170
	internal static readonly int k_nSteamNetworkingConfig_P2P_Transport_ICE_Enable_Private; // 0x174
	internal static readonly int k_nSteamNetworkingConfig_P2P_Transport_ICE_Enable_Public; // 0x178
	internal static readonly int k_nSteamNetworkingConfig_P2P_Transport_ICE_Enable_All; // 0x17C
	internal static readonly SteamNetworkingPOPID k_SteamDatagramPOPID_dev; // 0x180
	internal static readonly ushort STEAMGAMESERVER_QUERY_PORT_SHARED; // 0x184
	internal static readonly ushort MASTERSERVERUPDATERPORT_USEGAMESOCKETSHARE; // 0x186
	internal static readonly uint k_cbSteamDatagramMaxSerializedTicket; // 0x188
	internal static readonly uint k_cbMaxSteamDatagramGameCoordinatorServerLoginAppData; // 0x18C
	internal static readonly uint k_cbMaxSteamDatagramGameCoordinatorServerLoginSerialized; // 0x190
	internal static readonly int k_cbSteamNetworkingSocketsFakeUDPPortRecommendedMTU; // 0x194
	internal static readonly int k_cbSteamNetworkingSocketsFakeUDPPortMaxMessageSize; // 0x198

	// Methods

	// RVA: 0x1369FF0 Offset: 0x13693F0 VA: 0x181369FF0
	private static void .cctor() { }

}

public static class Defines // TypeDefIndex: 6640
{
// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=2048 // TypeDefIndex: 6637

// Namespace: 
internal class <Module> // TypeDefIndex: 6638

// Namespace: 
internal class <Module> // TypeDefIndex: 6639

// Namespace: Rust.Demo
public static class Defines // TypeDefIndex: 6640
	// Fields
	public const string Ident = "RUST DEMO FORMAT";

}

public class Defines // TypeDefIndex: 6677
{	// Fields
	public const byte lowestUserPacket = 140;
	public const int packetHeaderSize = 1;

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

}

public static class Defines // TypeDefIndex: 12031
{	// Fields
	public static uint appID; // 0x1F8C0
	public const string resourceFolder = "assets/bundled";

	// Methods

	// RVA: 0x4B9AF0 Offset: 0x4B8EF0 VA: 0x1804B9AF0
	private static void .cctor() { }

}

public static class Defines.Connection // TypeDefIndex: 12032
{	// Fields
	public const byte mode_steam = 228;

}

public static class Defines.Tags // TypeDefIndex: 12033
{	// Fields
	public const string NotPlayerUsable = "Not Player Usable";

}

