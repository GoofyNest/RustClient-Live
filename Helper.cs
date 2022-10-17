public sealed class Helper // TypeDefIndex: 8247
{
	private static Dictionary<long, Helper.Allocation> s_Allocations; 
	private static Dictionary<long, Helper.PinnedBuffer> s_PinnedBuffers; 
	private static Dictionary<IntPtr, Helper.DelegateHolder> s_Callbacks; 
	private static Dictionary<string, Helper.DelegateHolder> s_StaticCallbacks; 
	private static long s_LastClientDataId; 
	private static Dictionary<IntPtr, object> s_ClientDatas; 


	internal static void AddCallback(out IntPtr clientDataAddress, object clientData, Delegate publicDelegate, Delegate privateDelegate, Delegate[] structDelegates) { }

	private static void RemoveCallback(IntPtr clientDataAddress) { }

	internal static bool TryGetAndRemoveCallback<TCallbackInfoInternal, TCallback, TCallbackInfo>(ref TCallbackInfoInternal callbackInfoInternal, out TCallback callback, out TCallbackInfo callbackInfo) { }
	/* GenericInstMethod :
	|
	|-Helper.TryGetAndRemoveCallback<OnAchievementsUnlockedCallbackInfoInternal, OnAchievementsUnlockedCallback, OnAchievementsUnlockedCallbackInfo>
	|-Helper.TryGetAndRemoveCallback<OnAchievementsUnlockedCallbackInfoInternal, object, OnAchievementsUnlockedCallbackInfo>
	|
	|-Helper.TryGetAndRemoveCallback<OnAchievementsUnlockedCallbackV2InfoInternal, OnAchievementsUnlockedCallbackV2, OnAchievementsUnlockedCallbackV2Info>
	|-Helper.TryGetAndRemoveCallback<OnAchievementsUnlockedCallbackV2InfoInternal, object, OnAchievementsUnlockedCallbackV2Info>
	|
	|-Helper.TryGetAndRemoveCallback<OnQueryDefinitionsCompleteCallbackInfoInternal, OnQueryDefinitionsCompleteCallback, OnQueryDefinitionsCompleteCallbackInfo>
	|-Helper.TryGetAndRemoveCallback<OnQueryDefinitionsCompleteCallbackInfoInternal, object, OnQueryDefinitionsCompleteCallbackInfo>
	|
	|-Helper.TryGetAndRemoveCallback<OnQueryPlayerAchievementsCompleteCallbackInfoInternal, OnQueryPlayerAchievementsCompleteCallback, OnQueryPlayerAchievementsCompleteCallbackInfo>
	|-Helper.TryGetAndRemoveCallback<OnQueryPlayerAchievementsCompleteCallbackInfoInternal, object, OnQueryPlayerAchievementsCompleteCallbackInfo>
	|
	|-Helper.TryGetAndRemoveCallback<OnUnlockAchievementsCompleteCallbackInfoInternal, OnUnlockAchievementsCompleteCallback, OnUnlockAchievementsCompleteCallbackInfo>
	|-Helper.TryGetAndRemoveCallback<OnUnlockAchievementsCompleteCallbackInfoInternal, object, OnUnlockAchievementsCompleteCallbackInfo>
	|
	|-Helper.TryGetAndRemoveCallback<OnClientIntegrityViolatedCallbackInfoInternal, OnClientIntegrityViolatedCallback, OnClientIntegrityViolatedCallbackInfo>
	|-Helper.TryGetAndRemoveCallback<OnClientIntegrityViolatedCallbackInfoInternal, object, OnClientIntegrityViolatedCallbackInfo>
	|
	|-Helper.TryGetAndRemoveCallback<OnMessageToServerCallbackInfoInternal, OnMessageToServerCallback, OnMessageToServerCallbackInfo>
	|-Helper.TryGetAndRemoveCallback<OnMessageToServerCallbackInfoInternal, object, OnMessageToServerCallbackInfo>
	|
	|-Helper.TryGetAndRemoveCallback<OnClientActionRequiredCallbackInfoInternal, OnPeerActionRequiredCallback, OnClientActionRequiredCallbackInfo>
	|-Helper.TryGetAndRemoveCallback<OnClientActionRequiredCallbackInfoInternal, OnClientActionRequiredCallback, OnClientActionRequiredCallbackInfo>
	|-Helper.TryGetAndRemoveCallback<OnClientActionRequiredCallbackInfoInternal, object, OnClientActionRequiredCallbackInfo>
	|
	|-Helper.TryGetAndRemoveCallback<OnClientAuthStatusChangedCallbackInfoInternal, OnPeerAuthStatusChangedCallback, OnClientAuthStatusChangedCallbackInfo>
	|-Helper.TryGetAndRemoveCallback<OnClientAuthStatusChangedCallbackInfoInternal, OnClientAuthStatusChangedCallback, OnClientAuthStatusChangedCallbackInfo>
	|-Helper.TryGetAndRemoveCallback<OnClientAuthStatusChangedCallbackInfoInternal, object, OnClientAuthStatusChangedCallbackInfo>
	|
	|-Helper.TryGetAndRemoveCallback<OnMessageToClientCallbackInfoInternal, OnMessageToPeerCallback, OnMessageToClientCallbackInfo>
	|-Helper.TryGetAndRemoveCallback<OnMessageToClientCallbackInfoInternal, OnMessageToClientCallback, OnMessageToClientCallbackInfo>
	|-Helper.TryGetAndRemoveCallback<OnMessageToClientCallbackInfoInternal, object, OnMessageToClientCallbackInfo>
	|
	|-Helper.TryGetAndRemoveCallback<DeletePersistentAuthCallbackInfoInternal, OnDeletePersistentAuthCallback, DeletePersistentAuthCallbackInfo>
	|-Helper.TryGetAndRemoveCallback<DeletePersistentAuthCallbackInfoInternal, object, DeletePersistentAuthCallbackInfo>
	|
	|-Helper.TryGetAndRemoveCallback<LinkAccountCallbackInfoInternal, OnLinkAccountCallback, LinkAccountCallbackInfo>
	|-Helper.TryGetAndRemoveCallback<LinkAccountCallbackInfoInternal, object, LinkAccountCallbackInfo>
	|
	|-Helper.TryGetAndRemoveCallback<LoginCallbackInfoInternal, OnLoginCallback, LoginCallbackInfo>
	|-Helper.TryGetAndRemoveCallback<LoginCallbackInfoInternal, object, LoginCallbackInfo>
	|
	|-Helper.TryGetAndRemoveCallback<LoginStatusChangedCallbackInfoInternal, OnLoginStatusChangedCallback, LoginStatusChangedCallbackInfo>
	|-Helper.TryGetAndRemoveCallback<LoginStatusChangedCallbackInfoInternal, object, LoginStatusChangedCallbackInfo>
	|
	|-Helper.TryGetAndRemoveCallback<LogoutCallbackInfoInternal, OnLogoutCallback, LogoutCallbackInfo>
	|-Helper.TryGetAndRemoveCallback<LogoutCallbackInfoInternal, object, LogoutCallbackInfo>
	|
	|-Helper.TryGetAndRemoveCallback<QueryIdTokenCallbackInfoInternal, OnQueryIdTokenCallback, QueryIdTokenCallbackInfo>
	|-Helper.TryGetAndRemoveCallback<QueryIdTokenCallbackInfoInternal, object, QueryIdTokenCallbackInfo>
	|
	|-Helper.TryGetAndRemoveCallback<VerifyIdTokenCallbackInfoInternal, OnVerifyIdTokenCallback, VerifyIdTokenCallbackInfo>
	|-Helper.TryGetAndRemoveCallback<VerifyIdTokenCallbackInfoInternal, object, VerifyIdTokenCallbackInfo>
	|
	|-Helper.TryGetAndRemoveCallback<VerifyUserAuthCallbackInfoInternal, OnVerifyUserAuthCallback, VerifyUserAuthCallbackInfo>
	|-Helper.TryGetAndRemoveCallback<VerifyUserAuthCallbackInfoInternal, object, VerifyUserAuthCallbackInfo>
	|
	|-Helper.TryGetAndRemoveCallback<AuthExpirationCallbackInfoInternal, OnAuthExpirationCallback, AuthExpirationCallbackInfo>
	|-Helper.TryGetAndRemoveCallback<AuthExpirationCallbackInfoInternal, object, AuthExpirationCallbackInfo>
	|
	|-Helper.TryGetAndRemoveCallback<CreateDeviceIdCallbackInfoInternal, OnCreateDeviceIdCallback, CreateDeviceIdCallbackInfo>
	|-Helper.TryGetAndRemoveCallback<CreateDeviceIdCallbackInfoInternal, object, CreateDeviceIdCallbackInfo>
	|
	|-Helper.TryGetAndRemoveCallback<CreateUserCallbackInfoInternal, OnCreateUserCallback, CreateUserCallbackInfo>
	|-Helper.TryGetAndRemoveCallback<CreateUserCallbackInfoInternal, object, CreateUserCallbackInfo>
	|
	|-Helper.TryGetAndRemoveCallback<DeleteDeviceIdCallbackInfoInternal, OnDeleteDeviceIdCallback, DeleteDeviceIdCallbackInfo>
	|-Helper.TryGetAndRemoveCallback<DeleteDeviceIdCallbackInfoInternal, object, DeleteDeviceIdCallbackInfo>
	|
	|-Helper.TryGetAndRemoveCallback<LinkAccountCallbackInfoInternal, OnLinkAccountCallback, LinkAccountCallbackInfo>
	|-Helper.TryGetAndRemoveCallback<LinkAccountCallbackInfoInternal, object, LinkAccountCallbackInfo>
	|
	|-Helper.TryGetAndRemoveCallback<LoginCallbackInfoInternal, OnLoginCallback, LoginCallbackInfo>
	|-Helper.TryGetAndRemoveCallback<LoginCallbackInfoInternal, object, LoginCallbackInfo>
	|
	|-Helper.TryGetAndRemoveCallback<LoginStatusChangedCallbackInfoInternal, OnLoginStatusChangedCallback, LoginStatusChangedCallbackInfo>
	|-Helper.TryGetAndRemoveCallback<LoginStatusChangedCallbackInfoInternal, object, LoginStatusChangedCallbackInfo>
	|
	|-Helper.TryGetAndRemoveCallback<QueryExternalAccountMappingsCallbackInfoInternal, OnQueryExternalAccountMappingsCallback, QueryExternalAccountMappingsCallbackInfo>
	|-Helper.TryGetAndRemoveCallback<QueryExternalAccountMappingsCallbackInfoInternal, object, QueryExternalAccountMappingsCallbackInfo>
	|
	|-Helper.TryGetAndRemoveCallback<QueryProductUserIdMappingsCallbackInfoInternal, OnQueryProductUserIdMappingsCallback, QueryProductUserIdMappingsCallbackInfo>
	|-Helper.TryGetAndRemoveCallback<QueryProductUserIdMappingsCallbackInfoInternal, object, QueryProductUserIdMappingsCallbackInfo>
	|
	|-Helper.TryGetAndRemoveCallback<TransferDeviceIdAccountCallbackInfoInternal, OnTransferDeviceIdAccountCallback, TransferDeviceIdAccountCallbackInfo>
	|-Helper.TryGetAndRemoveCallback<TransferDeviceIdAccountCallbackInfoInternal, object, TransferDeviceIdAccountCallbackInfo>
	|
	|-Helper.TryGetAndRemoveCallback<UnlinkAccountCallbackInfoInternal, OnUnlinkAccountCallback, UnlinkAccountCallbackInfo>
	|-Helper.TryGetAndRemoveCallback<UnlinkAccountCallbackInfoInternal, object, UnlinkAccountCallbackInfo>
	|
	|-Helper.TryGetAndRemoveCallback<VerifyIdTokenCallbackInfoInternal, OnVerifyIdTokenCallback, VerifyIdTokenCallbackInfo>
	|-Helper.TryGetAndRemoveCallback<VerifyIdTokenCallbackInfoInternal, object, VerifyIdTokenCallbackInfo>
	|
	|-Helper.TryGetAndRemoveCallback<CustomInviteRejectedCallbackInfoInternal, OnCustomInviteRejectedCallback, CustomInviteRejectedCallbackInfo>
	|-Helper.TryGetAndRemoveCallback<CustomInviteRejectedCallbackInfoInternal, object, CustomInviteRejectedCallbackInfo>
	|
	|-Helper.TryGetAndRemoveCallback<OnCustomInviteAcceptedCallbackInfoInternal, OnCustomInviteAcceptedCallback, OnCustomInviteAcceptedCallbackInfo>
	|-Helper.TryGetAndRemoveCallback<OnCustomInviteAcceptedCallbackInfoInternal, object, OnCustomInviteAcceptedCallbackInfo>
	|
	|-Helper.TryGetAndRemoveCallback<OnCustomInviteReceivedCallbackInfoInternal, OnCustomInviteReceivedCallback, OnCustomInviteReceivedCallbackInfo>
	|-Helper.TryGetAndRemoveCallback<OnCustomInviteReceivedCallbackInfoInternal, object, OnCustomInviteReceivedCallbackInfo>
	|
	|-Helper.TryGetAndRemoveCallback<SendCustomInviteCallbackInfoInternal, OnSendCustomInviteCallback, SendCustomInviteCallbackInfo>
	|-Helper.TryGetAndRemoveCallback<SendCustomInviteCallbackInfoInternal, object, SendCustomInviteCallbackInfo>
	|
	|-Helper.TryGetAndRemoveCallback<CheckoutCallbackInfoInternal, OnCheckoutCallback, CheckoutCallbackInfo>
	|-Helper.TryGetAndRemoveCallback<CheckoutCallbackInfoInternal, object, CheckoutCallbackInfo>
	|
	|-Helper.TryGetAndRemoveCallback<QueryEntitlementsCallbackInfoInternal, OnQueryEntitlementsCallback, QueryEntitlementsCallbackInfo>
	|-Helper.TryGetAndRemoveCallback<QueryEntitlementsCallbackInfoInternal, object, QueryEntitlementsCallbackInfo>
	|
	|-Helper.TryGetAndRemoveCallback<QueryOffersCallbackInfoInternal, OnQueryOffersCallback, QueryOffersCallbackInfo>
	|-Helper.TryGetAndRemoveCallback<QueryOffersCallbackInfoInternal, object, QueryOffersCallbackInfo>
	|
	|-Helper.TryGetAndRemoveCallback<QueryOwnershipCallbackInfoInternal, OnQueryOwnershipCallback, QueryOwnershipCallbackInfo>
	|-Helper.TryGetAndRemoveCallback<QueryOwnershipCallbackInfoInternal, object, QueryOwnershipCallbackInfo>
	|
	|-Helper.TryGetAndRemoveCallback<QueryOwnershipTokenCallbackInfoInternal, OnQueryOwnershipTokenCallback, QueryOwnershipTokenCallbackInfo>
	|-Helper.TryGetAndRemoveCallback<QueryOwnershipTokenCallbackInfoInternal, object, QueryOwnershipTokenCallbackInfo>
	|
	|-Helper.TryGetAndRemoveCallback<RedeemEntitlementsCallbackInfoInternal, OnRedeemEntitlementsCallback, RedeemEntitlementsCallbackInfo>
	|-Helper.TryGetAndRemoveCallback<RedeemEntitlementsCallbackInfoInternal, object, RedeemEntitlementsCallbackInfo>
	|
	|-Helper.TryGetAndRemoveCallback<AcceptInviteCallbackInfoInternal, OnAcceptInviteCallback, AcceptInviteCallbackInfo>
	|-Helper.TryGetAndRemoveCallback<AcceptInviteCallbackInfoInternal, object, AcceptInviteCallbackInfo>
	|
	|-Helper.TryGetAndRemoveCallback<OnFriendsUpdateInfoInternal, OnFriendsUpdateCallback, OnFriendsUpdateInfo>
	|-Helper.TryGetAndRemoveCallback<OnFriendsUpdateInfoInternal, object, OnFriendsUpdateInfo>
	|
	|-Helper.TryGetAndRemoveCallback<QueryFriendsCallbackInfoInternal, OnQueryFriendsCallback, QueryFriendsCallbackInfo>
	|-Helper.TryGetAndRemoveCallback<QueryFriendsCallbackInfoInternal, object, QueryFriendsCallbackInfo>
	|
	|-Helper.TryGetAndRemoveCallback<RejectInviteCallbackInfoInternal, OnRejectInviteCallback, RejectInviteCallbackInfo>
	|-Helper.TryGetAndRemoveCallback<RejectInviteCallbackInfoInternal, object, RejectInviteCallbackInfo>
	|
	|-Helper.TryGetAndRemoveCallback<SendInviteCallbackInfoInternal, OnSendInviteCallback, SendInviteCallbackInfo>
	|-Helper.TryGetAndRemoveCallback<SendInviteCallbackInfoInternal, object, SendInviteCallbackInfo>
	|
	|-Helper.TryGetAndRemoveCallback<CreateUserCallbackInfoInternal, OnCreateUserCallback, CreateUserCallbackInfo>
	|-Helper.TryGetAndRemoveCallback<CreateUserCallbackInfoInternal, object, CreateUserCallbackInfo>
	|
	|-Helper.TryGetAndRemoveCallback<PermissionsUpdateReceivedCallbackInfoInternal, OnPermissionsUpdateReceivedCallback, PermissionsUpdateReceivedCallbackInfo>
	|-Helper.TryGetAndRemoveCallback<PermissionsUpdateReceivedCallbackInfoInternal, object, PermissionsUpdateReceivedCallbackInfo>
	|
	|-Helper.TryGetAndRemoveCallback<QueryAgeGateCallbackInfoInternal, OnQueryAgeGateCallback, QueryAgeGateCallbackInfo>
	|-Helper.TryGetAndRemoveCallback<QueryAgeGateCallbackInfoInternal, object, QueryAgeGateCallbackInfo>
	|
	|-Helper.TryGetAndRemoveCallback<QueryPermissionsCallbackInfoInternal, OnQueryPermissionsCallback, QueryPermissionsCallbackInfo>
	|-Helper.TryGetAndRemoveCallback<QueryPermissionsCallbackInfoInternal, object, QueryPermissionsCallbackInfo>
	|
	|-Helper.TryGetAndRemoveCallback<RequestPermissionsCallbackInfoInternal, OnRequestPermissionsCallback, RequestPermissionsCallbackInfo>
	|-Helper.TryGetAndRemoveCallback<RequestPermissionsCallbackInfoInternal, object, RequestPermissionsCallbackInfo>
	|
	|-Helper.TryGetAndRemoveCallback<UpdateParentEmailCallbackInfoInternal, OnUpdateParentEmailCallback, UpdateParentEmailCallbackInfo>
	|-Helper.TryGetAndRemoveCallback<UpdateParentEmailCallbackInfoInternal, object, UpdateParentEmailCallbackInfo>
	|
	|-Helper.TryGetAndRemoveCallback<OnQueryLeaderboardDefinitionsCompleteCallbackInfoInternal, OnQueryLeaderboardDefinitionsCompleteCallback, OnQueryLeaderboardDefinitionsCompleteCallbackInfo>
	|-Helper.TryGetAndRemoveCallback<OnQueryLeaderboardDefinitionsCompleteCallbackInfoInternal, object, OnQueryLeaderboardDefinitionsCompleteCallbackInfo>
	|
	|-Helper.TryGetAndRemoveCallback<OnQueryLeaderboardRanksCompleteCallbackInfoInternal, OnQueryLeaderboardRanksCompleteCallback, OnQueryLeaderboardRanksCompleteCallbackInfo>
	|-Helper.TryGetAndRemoveCallback<OnQueryLeaderboardRanksCompleteCallbackInfoInternal, object, OnQueryLeaderboardRanksCompleteCallbackInfo>
	|
	|-Helper.TryGetAndRemoveCallback<OnQueryLeaderboardUserScoresCompleteCallbackInfoInternal, OnQueryLeaderboardUserScoresCompleteCallback, OnQueryLeaderboardUserScoresCompleteCallbackInfo>
	|-Helper.TryGetAndRemoveCallback<OnQueryLeaderboardUserScoresCompleteCallbackInfoInternal, object, OnQueryLeaderboardUserScoresCompleteCallbackInfo>
	|
	|-Helper.TryGetAndRemoveCallback<CreateLobbyCallbackInfoInternal, OnCreateLobbyCallback, CreateLobbyCallbackInfo>
	|-Helper.TryGetAndRemoveCallback<CreateLobbyCallbackInfoInternal, object, CreateLobbyCallbackInfo>
	|
	|-Helper.TryGetAndRemoveCallback<DestroyLobbyCallbackInfoInternal, OnDestroyLobbyCallback, DestroyLobbyCallbackInfo>
	|-Helper.TryGetAndRemoveCallback<DestroyLobbyCallbackInfoInternal, object, DestroyLobbyCallbackInfo>
	|
	|-Helper.TryGetAndRemoveCallback<HardMuteMemberCallbackInfoInternal, OnHardMuteMemberCallback, HardMuteMemberCallbackInfo>
	|-Helper.TryGetAndRemoveCallback<HardMuteMemberCallbackInfoInternal, object, HardMuteMemberCallbackInfo>
	|
	|-Helper.TryGetAndRemoveCallback<JoinLobbyAcceptedCallbackInfoInternal, OnJoinLobbyAcceptedCallback, JoinLobbyAcceptedCallbackInfo>
	|-Helper.TryGetAndRemoveCallback<JoinLobbyAcceptedCallbackInfoInternal, object, JoinLobbyAcceptedCallbackInfo>
	|
	|-Helper.TryGetAndRemoveCallback<JoinLobbyByIdCallbackInfoInternal, OnJoinLobbyByIdCallback, JoinLobbyByIdCallbackInfo>
	|-Helper.TryGetAndRemoveCallback<JoinLobbyByIdCallbackInfoInternal, object, JoinLobbyByIdCallbackInfo>
	|
	|-Helper.TryGetAndRemoveCallback<JoinLobbyCallbackInfoInternal, OnJoinLobbyCallback, JoinLobbyCallbackInfo>
	|-Helper.TryGetAndRemoveCallback<JoinLobbyCallbackInfoInternal, object, JoinLobbyCallbackInfo>
	|
	|-Helper.TryGetAndRemoveCallback<KickMemberCallbackInfoInternal, OnKickMemberCallback, KickMemberCallbackInfo>
	|-Helper.TryGetAndRemoveCallback<KickMemberCallbackInfoInternal, object, KickMemberCallbackInfo>
	|
	|-Helper.TryGetAndRemoveCallback<LeaveLobbyCallbackInfoInternal, OnLeaveLobbyCallback, LeaveLobbyCallbackInfo>
	|-Helper.TryGetAndRemoveCallback<LeaveLobbyCallbackInfoInternal, object, LeaveLobbyCallbackInfo>
	|
	|-Helper.TryGetAndRemoveCallback<LobbyInviteAcceptedCallbackInfoInternal, OnLobbyInviteAcceptedCallback, LobbyInviteAcceptedCallbackInfo>
	|-Helper.TryGetAndRemoveCallback<LobbyInviteAcceptedCallbackInfoInternal, object, LobbyInviteAcceptedCallbackInfo>
	|
	|-Helper.TryGetAndRemoveCallback<LobbyInviteReceivedCallbackInfoInternal, OnLobbyInviteReceivedCallback, LobbyInviteReceivedCallbackInfo>
	|-Helper.TryGetAndRemoveCallback<LobbyInviteReceivedCallbackInfoInternal, object, LobbyInviteReceivedCallbackInfo>
	|
	|-Helper.TryGetAndRemoveCallback<LobbyInviteRejectedCallbackInfoInternal, OnLobbyInviteRejectedCallback, LobbyInviteRejectedCallbackInfo>
	|-Helper.TryGetAndRemoveCallback<LobbyInviteRejectedCallbackInfoInternal, object, LobbyInviteRejectedCallbackInfo>
	|
	|-Helper.TryGetAndRemoveCallback<LobbyMemberStatusReceivedCallbackInfoInternal, OnLobbyMemberStatusReceivedCallback, LobbyMemberStatusReceivedCallbackInfo>
	|-Helper.TryGetAndRemoveCallback<LobbyMemberStatusReceivedCallbackInfoInternal, object, LobbyMemberStatusReceivedCallbackInfo>
	|
	|-Helper.TryGetAndRemoveCallback<LobbyMemberUpdateReceivedCallbackInfoInternal, OnLobbyMemberUpdateReceivedCallback, LobbyMemberUpdateReceivedCallbackInfo>
	|-Helper.TryGetAndRemoveCallback<LobbyMemberUpdateReceivedCallbackInfoInternal, object, LobbyMemberUpdateReceivedCallbackInfo>
	|
	|-Helper.TryGetAndRemoveCallback<LobbySearchFindCallbackInfoInternal, LobbySearchOnFindCallback, LobbySearchFindCallbackInfo>
	|-Helper.TryGetAndRemoveCallback<LobbySearchFindCallbackInfoInternal, object, LobbySearchFindCallbackInfo>
	|
	|-Helper.TryGetAndRemoveCallback<LobbyUpdateReceivedCallbackInfoInternal, OnLobbyUpdateReceivedCallback, LobbyUpdateReceivedCallbackInfo>
	|-Helper.TryGetAndRemoveCallback<LobbyUpdateReceivedCallbackInfoInternal, object, LobbyUpdateReceivedCallbackInfo>
	|
	|-Helper.TryGetAndRemoveCallback<PromoteMemberCallbackInfoInternal, OnPromoteMemberCallback, PromoteMemberCallbackInfo>
	|-Helper.TryGetAndRemoveCallback<PromoteMemberCallbackInfoInternal, object, PromoteMemberCallbackInfo>
	|
	|-Helper.TryGetAndRemoveCallback<QueryInvitesCallbackInfoInternal, OnQueryInvitesCallback, QueryInvitesCallbackInfo>
	|-Helper.TryGetAndRemoveCallback<QueryInvitesCallbackInfoInternal, object, QueryInvitesCallbackInfo>
	|
	|-Helper.TryGetAndRemoveCallback<RTCRoomConnectionChangedCallbackInfoInternal, OnRTCRoomConnectionChangedCallback, RTCRoomConnectionChangedCallbackInfo>
	|-Helper.TryGetAndRemoveCallback<RTCRoomConnectionChangedCallbackInfoInternal, object, RTCRoomConnectionChangedCallbackInfo>
	|
	|-Helper.TryGetAndRemoveCallback<RejectInviteCallbackInfoInternal, OnRejectInviteCallback, RejectInviteCallbackInfo>
	|-Helper.TryGetAndRemoveCallback<RejectInviteCallbackInfoInternal, object, RejectInviteCallbackInfo>
	|
	|-Helper.TryGetAndRemoveCallback<SendInviteCallbackInfoInternal, OnSendInviteCallback, SendInviteCallbackInfo>
	|-Helper.TryGetAndRemoveCallback<SendInviteCallbackInfoInternal, object, SendInviteCallbackInfo>
	|
	|-Helper.TryGetAndRemoveCallback<SendLobbyNativeInviteRequestedCallbackInfoInternal, OnSendLobbyNativeInviteRequestedCallback, SendLobbyNativeInviteRequestedCallbackInfo>
	|-Helper.TryGetAndRemoveCallback<SendLobbyNativeInviteRequestedCallbackInfoInternal, object, SendLobbyNativeInviteRequestedCallbackInfo>
	|
	|-Helper.TryGetAndRemoveCallback<UpdateLobbyCallbackInfoInternal, OnUpdateLobbyCallback, UpdateLobbyCallbackInfo>
	|-Helper.TryGetAndRemoveCallback<UpdateLobbyCallbackInfoInternal, object, UpdateLobbyCallbackInfo>
	|
	|-Helper.TryGetAndRemoveCallback<EnumerateModsCallbackInfoInternal, OnEnumerateModsCallback, EnumerateModsCallbackInfo>
	|-Helper.TryGetAndRemoveCallback<EnumerateModsCallbackInfoInternal, object, EnumerateModsCallbackInfo>
	|
	|-Helper.TryGetAndRemoveCallback<InstallModCallbackInfoInternal, OnInstallModCallback, InstallModCallbackInfo>
	|-Helper.TryGetAndRemoveCallback<InstallModCallbackInfoInternal, object, InstallModCallbackInfo>
	|
	|-Helper.TryGetAndRemoveCallback<UninstallModCallbackInfoInternal, OnUninstallModCallback, UninstallModCallbackInfo>
	|-Helper.TryGetAndRemoveCallback<UninstallModCallbackInfoInternal, object, UninstallModCallbackInfo>
	|
	|-Helper.TryGetAndRemoveCallback<UpdateModCallbackInfoInternal, OnUpdateModCallback, UpdateModCallbackInfo>
	|-Helper.TryGetAndRemoveCallback<UpdateModCallbackInfoInternal, object, UpdateModCallbackInfo>
	|
	|-Helper.TryGetAndRemoveCallback<OnIncomingConnectionRequestInfoInternal, OnIncomingConnectionRequestCallback, OnIncomingConnectionRequestInfo>
	|-Helper.TryGetAndRemoveCallback<OnIncomingConnectionRequestInfoInternal, object, OnIncomingConnectionRequestInfo>
	|
	|-Helper.TryGetAndRemoveCallback<OnIncomingPacketQueueFullInfoInternal, OnIncomingPacketQueueFullCallback, OnIncomingPacketQueueFullInfo>
	|-Helper.TryGetAndRemoveCallback<OnIncomingPacketQueueFullInfoInternal, object, OnIncomingPacketQueueFullInfo>
	|
	|-Helper.TryGetAndRemoveCallback<OnPeerConnectionEstablishedInfoInternal, OnPeerConnectionEstablishedCallback, OnPeerConnectionEstablishedInfo>
	|-Helper.TryGetAndRemoveCallback<OnPeerConnectionEstablishedInfoInternal, object, OnPeerConnectionEstablishedInfo>
	|
	|-Helper.TryGetAndRemoveCallback<OnPeerConnectionInterruptedInfoInternal, OnPeerConnectionInterruptedCallback, OnPeerConnectionInterruptedInfo>
	|-Helper.TryGetAndRemoveCallback<OnPeerConnectionInterruptedInfoInternal, object, OnPeerConnectionInterruptedInfo>
	|
	|-Helper.TryGetAndRemoveCallback<OnQueryNATTypeCompleteInfoInternal, OnQueryNATTypeCompleteCallback, OnQueryNATTypeCompleteInfo>
	|-Helper.TryGetAndRemoveCallback<OnQueryNATTypeCompleteInfoInternal, object, OnQueryNATTypeCompleteInfo>
	|
	|-Helper.TryGetAndRemoveCallback<OnRemoteConnectionClosedInfoInternal, OnRemoteConnectionClosedCallback, OnRemoteConnectionClosedInfo>
	|-Helper.TryGetAndRemoveCallback<OnRemoteConnectionClosedInfoInternal, object, OnRemoteConnectionClosedInfo>
	|
	|-Helper.TryGetAndRemoveCallback<DeleteCacheCallbackInfoInternal, OnDeleteCacheCompleteCallback, DeleteCacheCallbackInfo>
	|-Helper.TryGetAndRemoveCallback<DeleteCacheCallbackInfoInternal, object, DeleteCacheCallbackInfo>
	|
	|-Helper.TryGetAndRemoveCallback<DeleteFileCallbackInfoInternal, OnDeleteFileCompleteCallback, DeleteFileCallbackInfo>
	|-Helper.TryGetAndRemoveCallback<DeleteFileCallbackInfoInternal, object, DeleteFileCallbackInfo>
	|
	|-Helper.TryGetAndRemoveCallback<DuplicateFileCallbackInfoInternal, OnDuplicateFileCompleteCallback, DuplicateFileCallbackInfo>
	|-Helper.TryGetAndRemoveCallback<DuplicateFileCallbackInfoInternal, object, DuplicateFileCallbackInfo>
	|
	|-Helper.TryGetAndRemoveCallback<QueryFileCallbackInfoInternal, OnQueryFileCompleteCallback, QueryFileCallbackInfo>
	|-Helper.TryGetAndRemoveCallback<QueryFileCallbackInfoInternal, object, QueryFileCallbackInfo>
	|
	|-Helper.TryGetAndRemoveCallback<QueryFileListCallbackInfoInternal, OnQueryFileListCompleteCallback, QueryFileListCallbackInfo>
	|-Helper.TryGetAndRemoveCallback<QueryFileListCallbackInfoInternal, object, QueryFileListCallbackInfo>
	|
	|-Helper.TryGetAndRemoveCallback<ReadFileCallbackInfoInternal, OnReadFileCompleteCallback, ReadFileCallbackInfo>
	|-Helper.TryGetAndRemoveCallback<ReadFileCallbackInfoInternal, object, ReadFileCallbackInfo>
	|
	|-Helper.TryGetAndRemoveCallback<WriteFileCallbackInfoInternal, OnWriteFileCompleteCallback, WriteFileCallbackInfo>
	|-Helper.TryGetAndRemoveCallback<WriteFileCallbackInfoInternal, object, WriteFileCallbackInfo>
	|
	|-Helper.TryGetAndRemoveCallback<JoinGameAcceptedCallbackInfoInternal, OnJoinGameAcceptedCallback, JoinGameAcceptedCallbackInfo>
	|-Helper.TryGetAndRemoveCallback<JoinGameAcceptedCallbackInfoInternal, object, JoinGameAcceptedCallbackInfo>
	|
	|-Helper.TryGetAndRemoveCallback<PresenceChangedCallbackInfoInternal, OnPresenceChangedCallback, PresenceChangedCallbackInfo>
	|-Helper.TryGetAndRemoveCallback<PresenceChangedCallbackInfoInternal, object, PresenceChangedCallbackInfo>
	|
	|-Helper.TryGetAndRemoveCallback<QueryPresenceCallbackInfoInternal, OnQueryPresenceCompleteCallback, QueryPresenceCallbackInfo>
	|-Helper.TryGetAndRemoveCallback<QueryPresenceCallbackInfoInternal, object, QueryPresenceCallbackInfo>
	|
	|-Helper.TryGetAndRemoveCallback<SetPresenceCallbackInfoInternal, SetPresenceCompleteCallback, SetPresenceCallbackInfo>
	|-Helper.TryGetAndRemoveCallback<SetPresenceCallbackInfoInternal, object, SetPresenceCallbackInfo>
	|
	|-Helper.TryGetAndRemoveCallback<DeleteSnapshotCallbackInfoInternal, OnDeleteSnapshotCallback, DeleteSnapshotCallbackInfo>
	|-Helper.TryGetAndRemoveCallback<DeleteSnapshotCallbackInfoInternal, object, DeleteSnapshotCallbackInfo>
	|
	|-Helper.TryGetAndRemoveCallback<SubmitSnapshotCallbackInfoInternal, OnSubmitSnapshotCallback, SubmitSnapshotCallbackInfo>
	|-Helper.TryGetAndRemoveCallback<SubmitSnapshotCallbackInfoInternal, object, SubmitSnapshotCallbackInfo>
	|
	|-Helper.TryGetAndRemoveCallback<BlockParticipantCallbackInfoInternal, OnBlockParticipantCallback, BlockParticipantCallbackInfo>
	|-Helper.TryGetAndRemoveCallback<BlockParticipantCallbackInfoInternal, object, BlockParticipantCallbackInfo>
	|
	|-Helper.TryGetAndRemoveCallback<DisconnectedCallbackInfoInternal, OnDisconnectedCallback, DisconnectedCallbackInfo>
	|-Helper.TryGetAndRemoveCallback<DisconnectedCallbackInfoInternal, object, DisconnectedCallbackInfo>
	|
	|-Helper.TryGetAndRemoveCallback<JoinRoomCallbackInfoInternal, OnJoinRoomCallback, JoinRoomCallbackInfo>
	|-Helper.TryGetAndRemoveCallback<JoinRoomCallbackInfoInternal, object, JoinRoomCallbackInfo>
	|
	|-Helper.TryGetAndRemoveCallback<LeaveRoomCallbackInfoInternal, OnLeaveRoomCallback, LeaveRoomCallbackInfo>
	|-Helper.TryGetAndRemoveCallback<LeaveRoomCallbackInfoInternal, object, LeaveRoomCallbackInfo>
	|
	|-Helper.TryGetAndRemoveCallback<ParticipantStatusChangedCallbackInfoInternal, OnParticipantStatusChangedCallback, ParticipantStatusChangedCallbackInfo>
	|-Helper.TryGetAndRemoveCallback<ParticipantStatusChangedCallbackInfoInternal, object, ParticipantStatusChangedCallbackInfo>
	|
	|-Helper.TryGetAndRemoveCallback<KickCompleteCallbackInfoInternal, OnKickCompleteCallback, KickCompleteCallbackInfo>
	|-Helper.TryGetAndRemoveCallback<KickCompleteCallbackInfoInternal, object, KickCompleteCallbackInfo>
	|
	|-Helper.TryGetAndRemoveCallback<QueryJoinRoomTokenCompleteCallbackInfoInternal, OnQueryJoinRoomTokenCompleteCallback, QueryJoinRoomTokenCompleteCallbackInfo>
	|-Helper.TryGetAndRemoveCallback<QueryJoinRoomTokenCompleteCallbackInfoInternal, object, QueryJoinRoomTokenCompleteCallbackInfo>
	|
	|-Helper.TryGetAndRemoveCallback<SetParticipantHardMuteCompleteCallbackInfoInternal, OnSetParticipantHardMuteCompleteCallback, SetParticipantHardMuteCompleteCallbackInfo>
	|-Helper.TryGetAndRemoveCallback<SetParticipantHardMuteCompleteCallbackInfoInternal, object, SetParticipantHardMuteCompleteCallbackInfo>
	|
	|-Helper.TryGetAndRemoveCallback<AudioBeforeRenderCallbackInfoInternal, OnAudioBeforeRenderCallback, AudioBeforeRenderCallbackInfo>
	|-Helper.TryGetAndRemoveCallback<AudioBeforeRenderCallbackInfoInternal, object, AudioBeforeRenderCallbackInfo>
	|
	|-Helper.TryGetAndRemoveCallback<AudioBeforeSendCallbackInfoInternal, OnAudioBeforeSendCallback, AudioBeforeSendCallbackInfo>
	|-Helper.TryGetAndRemoveCallback<AudioBeforeSendCallbackInfoInternal, object, AudioBeforeSendCallbackInfo>
	|
	|-Helper.TryGetAndRemoveCallback<AudioDevicesChangedCallbackInfoInternal, OnAudioDevicesChangedCallback, AudioDevicesChangedCallbackInfo>
	|-Helper.TryGetAndRemoveCallback<AudioDevicesChangedCallbackInfoInternal, object, AudioDevicesChangedCallbackInfo>
	|
	|-Helper.TryGetAndRemoveCallback<AudioInputStateCallbackInfoInternal, OnAudioInputStateCallback, AudioInputStateCallbackInfo>
	|-Helper.TryGetAndRemoveCallback<AudioInputStateCallbackInfoInternal, object, AudioInputStateCallbackInfo>
	|
	|-Helper.TryGetAndRemoveCallback<AudioOutputStateCallbackInfoInternal, OnAudioOutputStateCallback, AudioOutputStateCallbackInfo>
	|-Helper.TryGetAndRemoveCallback<AudioOutputStateCallbackInfoInternal, object, AudioOutputStateCallbackInfo>
	|
	|-Helper.TryGetAndRemoveCallback<ParticipantUpdatedCallbackInfoInternal, OnParticipantUpdatedCallback, ParticipantUpdatedCallbackInfo>
	|-Helper.TryGetAndRemoveCallback<ParticipantUpdatedCallbackInfoInternal, object, ParticipantUpdatedCallbackInfo>
	|
	|-Helper.TryGetAndRemoveCallback<UpdateParticipantVolumeCallbackInfoInternal, OnUpdateParticipantVolumeCallback, UpdateParticipantVolumeCallbackInfo>
	|-Helper.TryGetAndRemoveCallback<UpdateParticipantVolumeCallbackInfoInternal, object, UpdateParticipantVolumeCallbackInfo>
	|
	|-Helper.TryGetAndRemoveCallback<UpdateReceivingCallbackInfoInternal, OnUpdateReceivingCallback, UpdateReceivingCallbackInfo>
	|-Helper.TryGetAndRemoveCallback<UpdateReceivingCallbackInfoInternal, object, UpdateReceivingCallbackInfo>
	|
	|-Helper.TryGetAndRemoveCallback<UpdateReceivingVolumeCallbackInfoInternal, OnUpdateReceivingVolumeCallback, UpdateReceivingVolumeCallbackInfo>
	|-Helper.TryGetAndRemoveCallback<UpdateReceivingVolumeCallbackInfoInternal, object, UpdateReceivingVolumeCallbackInfo>
	|
	|-Helper.TryGetAndRemoveCallback<UpdateSendingCallbackInfoInternal, OnUpdateSendingCallback, UpdateSendingCallbackInfo>
	|-Helper.TryGetAndRemoveCallback<UpdateSendingCallbackInfoInternal, object, UpdateSendingCallbackInfo>
	|
	|-Helper.TryGetAndRemoveCallback<UpdateSendingVolumeCallbackInfoInternal, OnUpdateSendingVolumeCallback, UpdateSendingVolumeCallbackInfo>
	|-Helper.TryGetAndRemoveCallback<UpdateSendingVolumeCallbackInfoInternal, object, UpdateSendingVolumeCallbackInfo>
	|
	|-Helper.TryGetAndRemoveCallback<SendPlayerBehaviorReportCompleteCallbackInfoInternal, OnSendPlayerBehaviorReportCompleteCallback, SendPlayerBehaviorReportCompleteCallbackInfo>
	|-Helper.TryGetAndRemoveCallback<SendPlayerBehaviorReportCompleteCallbackInfoInternal, object, SendPlayerBehaviorReportCompleteCallbackInfo>
	|
	|-Helper.TryGetAndRemoveCallback<QueryActivePlayerSanctionsCallbackInfoInternal, OnQueryActivePlayerSanctionsCallback, QueryActivePlayerSanctionsCallbackInfo>
	|-Helper.TryGetAndRemoveCallback<QueryActivePlayerSanctionsCallbackInfoInternal, object, QueryActivePlayerSanctionsCallbackInfo>
	|
	|-Helper.TryGetAndRemoveCallback<DestroySessionCallbackInfoInternal, OnDestroySessionCallback, DestroySessionCallbackInfo>
	|-Helper.TryGetAndRemoveCallback<DestroySessionCallbackInfoInternal, object, DestroySessionCallbackInfo>
	|
	|-Helper.TryGetAndRemoveCallback<EndSessionCallbackInfoInternal, OnEndSessionCallback, EndSessionCallbackInfo>
	|-Helper.TryGetAndRemoveCallback<EndSessionCallbackInfoInternal, object, EndSessionCallbackInfo>
	|
	|-Helper.TryGetAndRemoveCallback<JoinSessionAcceptedCallbackInfoInternal, OnJoinSessionAcceptedCallback, JoinSessionAcceptedCallbackInfo>
	|-Helper.TryGetAndRemoveCallback<JoinSessionAcceptedCallbackInfoInternal, object, JoinSessionAcceptedCallbackInfo>
	|
	|-Helper.TryGetAndRemoveCallback<JoinSessionCallbackInfoInternal, OnJoinSessionCallback, JoinSessionCallbackInfo>
	|-Helper.TryGetAndRemoveCallback<JoinSessionCallbackInfoInternal, object, JoinSessionCallbackInfo>
	|
	|-Helper.TryGetAndRemoveCallback<QueryInvitesCallbackInfoInternal, OnQueryInvitesCallback, QueryInvitesCallbackInfo>
	|-Helper.TryGetAndRemoveCallback<QueryInvitesCallbackInfoInternal, object, QueryInvitesCallbackInfo>
	|
	|-Helper.TryGetAndRemoveCallback<RegisterPlayersCallbackInfoInternal, OnRegisterPlayersCallback, RegisterPlayersCallbackInfo>
	|-Helper.TryGetAndRemoveCallback<RegisterPlayersCallbackInfoInternal, object, RegisterPlayersCallbackInfo>
	|
	|-Helper.TryGetAndRemoveCallback<RejectInviteCallbackInfoInternal, OnRejectInviteCallback, RejectInviteCallbackInfo>
	|-Helper.TryGetAndRemoveCallback<RejectInviteCallbackInfoInternal, object, RejectInviteCallbackInfo>
	|
	|-Helper.TryGetAndRemoveCallback<SendInviteCallbackInfoInternal, OnSendInviteCallback, SendInviteCallbackInfo>
	|-Helper.TryGetAndRemoveCallback<SendInviteCallbackInfoInternal, object, SendInviteCallbackInfo>
	|
	|-Helper.TryGetAndRemoveCallback<SessionInviteAcceptedCallbackInfoInternal, OnSessionInviteAcceptedCallback, SessionInviteAcceptedCallbackInfo>
	|-Helper.TryGetAndRemoveCallback<SessionInviteAcceptedCallbackInfoInternal, object, SessionInviteAcceptedCallbackInfo>
	|
	|-Helper.TryGetAndRemoveCallback<SessionInviteReceivedCallbackInfoInternal, OnSessionInviteReceivedCallback, SessionInviteReceivedCallbackInfo>
	|-Helper.TryGetAndRemoveCallback<SessionInviteReceivedCallbackInfoInternal, object, SessionInviteReceivedCallbackInfo>
	|
	|-Helper.TryGetAndRemoveCallback<SessionSearchFindCallbackInfoInternal, SessionSearchOnFindCallback, SessionSearchFindCallbackInfo>
	|-Helper.TryGetAndRemoveCallback<SessionSearchFindCallbackInfoInternal, object, SessionSearchFindCallbackInfo>
	|
	|-Helper.TryGetAndRemoveCallback<StartSessionCallbackInfoInternal, OnStartSessionCallback, StartSessionCallbackInfo>
	|-Helper.TryGetAndRemoveCallback<StartSessionCallbackInfoInternal, object, StartSessionCallbackInfo>
	|
	|-Helper.TryGetAndRemoveCallback<UnregisterPlayersCallbackInfoInternal, OnUnregisterPlayersCallback, UnregisterPlayersCallbackInfo>
	|-Helper.TryGetAndRemoveCallback<UnregisterPlayersCallbackInfoInternal, object, UnregisterPlayersCallbackInfo>
	|
	|-Helper.TryGetAndRemoveCallback<UpdateSessionCallbackInfoInternal, OnUpdateSessionCallback, UpdateSessionCallbackInfo>
	|-Helper.TryGetAndRemoveCallback<UpdateSessionCallbackInfoInternal, object, UpdateSessionCallbackInfo>
	|
	|-Helper.TryGetAndRemoveCallback<IngestStatCompleteCallbackInfoInternal, OnIngestStatCompleteCallback, IngestStatCompleteCallbackInfo>
	|-Helper.TryGetAndRemoveCallback<IngestStatCompleteCallbackInfoInternal, object, IngestStatCompleteCallbackInfo>
	|
	|-Helper.TryGetAndRemoveCallback<OnQueryStatsCompleteCallbackInfoInternal, OnQueryStatsCompleteCallback, OnQueryStatsCompleteCallbackInfo>
	|-Helper.TryGetAndRemoveCallback<OnQueryStatsCompleteCallbackInfoInternal, object, OnQueryStatsCompleteCallbackInfo>
	|
	|-Helper.TryGetAndRemoveCallback<DeleteCacheCallbackInfoInternal, OnDeleteCacheCompleteCallback, DeleteCacheCallbackInfo>
	|-Helper.TryGetAndRemoveCallback<DeleteCacheCallbackInfoInternal, object, DeleteCacheCallbackInfo>
	|
	|-Helper.TryGetAndRemoveCallback<QueryFileCallbackInfoInternal, OnQueryFileCompleteCallback, QueryFileCallbackInfo>
	|-Helper.TryGetAndRemoveCallback<QueryFileCallbackInfoInternal, object, QueryFileCallbackInfo>
	|
	|-Helper.TryGetAndRemoveCallback<QueryFileListCallbackInfoInternal, OnQueryFileListCompleteCallback, QueryFileListCallbackInfo>
	|-Helper.TryGetAndRemoveCallback<QueryFileListCallbackInfoInternal, object, QueryFileListCallbackInfo>
	|
	|-Helper.TryGetAndRemoveCallback<ReadFileCallbackInfoInternal, OnReadFileCompleteCallback, ReadFileCallbackInfo>
	|-Helper.TryGetAndRemoveCallback<ReadFileCallbackInfoInternal, object, ReadFileCallbackInfo>
	|
	|-Helper.TryGetAndRemoveCallback<HideFriendsCallbackInfoInternal, OnHideFriendsCallback, HideFriendsCallbackInfo>
	|-Helper.TryGetAndRemoveCallback<HideFriendsCallbackInfoInternal, object, HideFriendsCallbackInfo>
	|
	|-Helper.TryGetAndRemoveCallback<OnDisplaySettingsUpdatedCallbackInfoInternal, OnDisplaySettingsUpdatedCallback, OnDisplaySettingsUpdatedCallbackInfo>
	|-Helper.TryGetAndRemoveCallback<OnDisplaySettingsUpdatedCallbackInfoInternal, object, OnDisplaySettingsUpdatedCallbackInfo>
	|
	|-Helper.TryGetAndRemoveCallback<OnShowBlockPlayerCallbackInfoInternal, OnShowBlockPlayerCallback, OnShowBlockPlayerCallbackInfo>
	|-Helper.TryGetAndRemoveCallback<OnShowBlockPlayerCallbackInfoInternal, object, OnShowBlockPlayerCallbackInfo>
	|
	|-Helper.TryGetAndRemoveCallback<OnShowReportPlayerCallbackInfoInternal, OnShowReportPlayerCallback, OnShowReportPlayerCallbackInfo>
	|-Helper.TryGetAndRemoveCallback<OnShowReportPlayerCallbackInfoInternal, object, OnShowReportPlayerCallbackInfo>
	|
	|-Helper.TryGetAndRemoveCallback<ShowFriendsCallbackInfoInternal, OnShowFriendsCallback, ShowFriendsCallbackInfo>
	|-Helper.TryGetAndRemoveCallback<ShowFriendsCallbackInfoInternal, object, ShowFriendsCallbackInfo>
	|
	|-Helper.TryGetAndRemoveCallback<QueryUserInfoByDisplayNameCallbackInfoInternal, OnQueryUserInfoByDisplayNameCallback, QueryUserInfoByDisplayNameCallbackInfo>
	|-Helper.TryGetAndRemoveCallback<QueryUserInfoByDisplayNameCallbackInfoInternal, object, QueryUserInfoByDisplayNameCallbackInfo>
	|
	|-Helper.TryGetAndRemoveCallback<QueryUserInfoByExternalAccountCallbackInfoInternal, OnQueryUserInfoByExternalAccountCallback, QueryUserInfoByExternalAccountCallbackInfo>
	|-Helper.TryGetAndRemoveCallback<QueryUserInfoByExternalAccountCallbackInfoInternal, object, QueryUserInfoByExternalAccountCallbackInfo>
	|
	|-Helper.TryGetAndRemoveCallback<QueryUserInfoCallbackInfoInternal, OnQueryUserInfoCallback, QueryUserInfoCallbackInfo>
	|-Helper.TryGetAndRemoveCallback<QueryUserInfoCallbackInfoInternal, object, QueryUserInfoCallbackInfo>
	*/

	internal static bool TryGetStructCallback<TCallbackInfoInternal, TCallback, TCallbackInfo>(ref TCallbackInfoInternal callbackInfoInternal, out TCallback callback, out TCallbackInfo callbackInfo) { }
	/* GenericInstMethod :
	|
	|-Helper.TryGetStructCallback<FileTransferProgressCallbackInfoInternal, OnFileTransferProgressCallback, FileTransferProgressCallbackInfo>
	|-Helper.TryGetStructCallback<FileTransferProgressCallbackInfoInternal, object, FileTransferProgressCallbackInfo>
	|
	|-Helper.TryGetStructCallback<ReadFileDataCallbackInfoInternal, OnReadFileDataCallback, ReadFileDataCallbackInfo>
	|-Helper.TryGetStructCallback<ReadFileDataCallbackInfoInternal, object, ReadFileDataCallbackInfo>
	|
	|-Helper.TryGetStructCallback<WriteFileDataCallbackInfoInternal, OnWriteFileDataCallback, WriteFileDataCallbackInfo>
	|-Helper.TryGetStructCallback<WriteFileDataCallbackInfoInternal, object, WriteFileDataCallbackInfo>
	|
	|-Helper.TryGetStructCallback<FileTransferProgressCallbackInfoInternal, OnFileTransferProgressCallback, FileTransferProgressCallbackInfo>
	|-Helper.TryGetStructCallback<FileTransferProgressCallbackInfoInternal, object, FileTransferProgressCallbackInfo>
	|
	|-Helper.TryGetStructCallback<ReadFileDataCallbackInfoInternal, OnReadFileDataCallback, ReadFileDataCallbackInfo>
	|-Helper.TryGetStructCallback<ReadFileDataCallbackInfoInternal, object, ReadFileDataCallbackInfo>
	*/

	internal static void RemoveCallbackByNotificationId(ulong notificationId) { }

	internal static void AddStaticCallback(string key, Delegate publicDelegate, Delegate privateDelegate) { }

	internal static bool TryGetStaticCallback<TCallback>(string key, out TCallback callback) { }
	/* GenericInstMethod :
	|
	|-Helper.TryGetStaticCallback<LogMessageFunc>
	|-Helper.TryGetStaticCallback<object>
	*/

	internal static void AssignNotificationIdToCallback(IntPtr clientDataAddress, ulong notificationId) { }

	private static IntPtr AddClientData(object clientData) { }

	private static void RemoveClientData(IntPtr clientDataAddress) { }

	private static object GetClientData(IntPtr clientDataAddress) { }

	private static void Convert<THandle>(IntPtr from, out THandle to) { }
	/* GenericInstMethod :
	|
	|-Helper.Convert<object>
	*/

	private static void Convert(Handle from, out IntPtr to) { }

	private static void Convert(byte[] from, out string to) { }

	private static void Convert(string from, out byte[] to, int fromLength) { }

	private static void Convert<TArray>(TArray[] from, out int to) { }
	/* GenericInstMethod :
	|
	|-Helper.Convert<PlayerStatInfo>
	|-Helper.Convert<StatThresholds>
	|-Helper.Convert<LogEventParamPair>
	|-Helper.Convert<RegisterEventParamDef>
	|-Helper.Convert<CheckoutEntry>
	|-Helper.Convert<ItemOwnership>
	|-Helper.Convert<UserScoresQueryStatInfo>
	|-Helper.Convert<ModIdentifier>
	|-Helper.Convert<DataRecord>
	|-Helper.Convert<PresenceModificationDataRecordId>
	|-Helper.Convert<ParticipantMetadata>
	|-Helper.Convert<IngestData>
	|-Helper.Convert<object>
	*/

	private static void Convert<TArray>(TArray[] from, out uint to) { }
	/* GenericInstMethod :
	|
	|-Helper.Convert<short>
	|-Helper.Convert<object>
	*/

	private static void Convert<TArray>(ArraySegment<TArray> from, out int to) { }
	/* GenericInstMethod :
	|
	|-Helper.Convert<object>
	*/

	private static void Convert<T>(ArraySegment<T> from, out uint to) { }
	/* GenericInstMethod :
	|
	|-Helper.Convert<byte>
	|-Helper.Convert<object>
	*/

	private static void Convert(int from, out bool to) { }

	private static void Convert(bool from, out int to) { }

	private static void Convert(Nullable<DateTimeOffset> from, out long to) { }

	private static void Convert(long from, out Nullable<DateTimeOffset> to) { }

	internal static void Get<TArray>(TArray[] from, out int to) { }
	/* GenericInstMethod :
	|
	|-Helper.Get<PlayerStatInfo>
	|
	|-Helper.Get<StatThresholds>
	|
	|-Helper.Get<LogEventParamPair>
	|
	|-Helper.Get<RegisterEventParamDef>
	|
	|-Helper.Get<CheckoutEntry>
	|
	|-Helper.Get<ItemOwnership>
	|
	|-Helper.Get<UserScoresQueryStatInfo>
	|
	|-Helper.Get<ModIdentifier>
	|
	|-Helper.Get<DataRecord>
	|
	|-Helper.Get<PresenceModificationDataRecordId>
	|
	|-Helper.Get<ParticipantMetadata>
	|
	|-Helper.Get<IngestData>
	|
	|-Helper.Get<object>
	*/

	internal static void Get<TArray>(TArray[] from, out uint to) { }
	/* GenericInstMethod :
	|
	|-Helper.Get<short>
	|
	|-Helper.Get<object>
	*/

	internal static void Get<TArray>(ArraySegment<TArray> from, out uint to) { }
	/* GenericInstMethod :
	|
	|-Helper.Get<byte>
	|
	|-Helper.Get<object>
	*/

	internal static void Get<TTo>(IntPtr from, out TTo to) { }
	/* GenericInstMethod :
	|
	|-Helper.Get<AchievementsInterface>
	|-Helper.Get<AntiCheatClientInterface>
	|-Helper.Get<AntiCheatServerInterface>
	|-Helper.Get<AuthInterface>
	|-Helper.Get<ConnectInterface>
	|-Helper.Get<ContinuanceToken>
	|-Helper.Get<CustomInvitesInterface>
	|-Helper.Get<EcomInterface>
	|-Helper.Get<Transaction>
	|-Helper.Get<EpicAccountId>
	|-Helper.Get<FriendsInterface>
	|-Helper.Get<IntegratedPlatformOptionsContainer>
	|-Helper.Get<KWSInterface>
	|-Helper.Get<LeaderboardsInterface>
	|-Helper.Get<LobbyDetails>
	|-Helper.Get<LobbyInterface>
	|-Helper.Get<LobbyModification>
	|-Helper.Get<LobbySearch>
	|-Helper.Get<MetricsInterface>
	|-Helper.Get<ModsInterface>
	|-Helper.Get<P2PInterface>
	|-Helper.Get<PlatformInterface>
	|-Helper.Get<PlayerDataStorageFileTransferRequest>
	|-Helper.Get<PlayerDataStorageInterface>
	|-Helper.Get<PresenceInterface>
	|-Helper.Get<PresenceModification>
	|-Helper.Get<ProductUserId>
	|-Helper.Get<ProgressionSnapshotInterface>
	|-Helper.Get<RTCInterface>
	|-Helper.Get<RTCAdminInterface>
	|-Helper.Get<RTCAudioInterface>
	|-Helper.Get<ReportsInterface>
	|-Helper.Get<SanctionsInterface>
	|-Helper.Get<ActiveSession>
	|-Helper.Get<SessionDetails>
	|-Helper.Get<SessionModification>
	|-Helper.Get<SessionSearch>
	|-Helper.Get<SessionsInterface>
	|-Helper.Get<StatsInterface>
	|-Helper.Get<TitleStorageFileTransferRequest>
	|-Helper.Get<TitleStorageInterface>
	|-Helper.Get<UIInterface>
	|-Helper.Get<UserInfoInterface>
	|-Helper.Get<object>
	*/

	internal static void Get<TFrom, TTo>(ref TFrom from, out TTo to) { }
	/* GenericInstMethod :
	|
	|-Helper.Get<LogEventParamPairParamValueInternal, LogEventParamPairParamValue>
	|
	|-Helper.Get<QuatInternal, Quat>
	|
	|-Helper.Get<Vec3fInternal, Vec3f>
	|
	|-Helper.Get<AttributeDataValueInternal, AttributeDataValue>
	|
	|-Helper.Get<LogMessageInternal, LogMessage>
	|
	|-Helper.Get<PacketQueueInfoInternal, PacketQueueInfo>
	|
	|-Helper.Get<SocketIdInternal, SocketId>
	|
	|-Helper.Get<GetDesktopCrossplayStatusInfoInternal, GetDesktopCrossplayStatusInfo>
	|
	|-Helper.Get<FileTransferProgressCallbackInfoInternal, FileTransferProgressCallbackInfo>
	|
	|-Helper.Get<ReadFileDataCallbackInfoInternal, ReadFileDataCallbackInfo>
	|
	|-Helper.Get<WriteFileDataCallbackInfoInternal, WriteFileDataCallbackInfo>
	|
	|-Helper.Get<AttributeDataValueInternal, AttributeDataValue>
	|
	|-Helper.Get<FileTransferProgressCallbackInfoInternal, FileTransferProgressCallbackInfo>
	|
	|-Helper.Get<ReadFileDataCallbackInfoInternal, ReadFileDataCallbackInfo>
	*/

	internal static void Get(int from, out bool to) { }

	internal static void Get(bool from, out int to) { }

	internal static void Get(long from, out Nullable<DateTimeOffset> to) { }

	internal static void Get<TTo>(IntPtr from, out TTo[] to, int arrayLength, bool isArrayItemAllocated) { }
	/* GenericInstMethod :
	|
	|-Helper.Get<object>
	*/

	internal static void Get<TTo>(IntPtr from, out TTo[] to, uint arrayLength, bool isArrayItemAllocated) { }
	/* GenericInstMethod :
	|
	|-Helper.Get<Utf8String>
	|-Helper.Get<object>
	*/

	internal static void Get<TTo>(IntPtr from, out TTo[] to, int arrayLength) { }
	/* GenericInstMethod :
	|
	|-Helper.Get<PlayerStatInfoInternal>
	|
	|-Helper.Get<StatThresholdsInternal>
	|
	|-Helper.Get<ItemOwnershipInternal>
	|
	|-Helper.Get<ModIdentifierInternal>
	|
	|-Helper.Get<DataRecordInternal>
	|
	|-Helper.Get<ParticipantMetadataInternal>
	|
	|-Helper.Get<object>
	*/

	internal static void Get<TTo>(IntPtr from, out TTo[] to, uint arrayLength) { }
	/* GenericInstMethod :
	|
	|-Helper.Get<short>
	|
	|-Helper.Get<object>
	*/

	internal static void Get(IntPtr from, out ArraySegment<byte> to, uint arrayLength) { }

	internal static void GetHandle<THandle>(IntPtr from, out THandle[] to, uint arrayLength) { }
	/* GenericInstMethod :
	|
	|-Helper.GetHandle<ProductUserId>
	|-Helper.GetHandle<object>
	*/

	internal static void Get<TFrom, TTo>(TFrom[] from, out TTo[] to) { }
	/* GenericInstMethod :
	|
	|-Helper.Get<PlayerStatInfoInternal, PlayerStatInfo>
	|
	|-Helper.Get<StatThresholdsInternal, StatThresholds>
	|
	|-Helper.Get<ItemOwnershipInternal, ItemOwnership>
	|
	|-Helper.Get<ModIdentifierInternal, ModIdentifier>
	|
	|-Helper.Get<DataRecordInternal, DataRecord>
	|
	|-Helper.Get<ParticipantMetadataInternal, ParticipantMetadata>
	*/

	internal static void Get<TFrom, TTo>(IntPtr from, out TTo[] to, int arrayLength) { }
	/* GenericInstMethod :
	|
	|-Helper.Get<PlayerStatInfoInternal, PlayerStatInfo>
	|
	|-Helper.Get<StatThresholdsInternal, StatThresholds>
	|
	|-Helper.Get<ItemOwnershipInternal, ItemOwnership>
	|
	|-Helper.Get<ModIdentifierInternal, ModIdentifier>
	|
	|-Helper.Get<DataRecordInternal, DataRecord>
	|
	|-Helper.Get<ParticipantMetadataInternal, ParticipantMetadata>
	*/

	internal static void Get<TFrom, TTo>(IntPtr from, out TTo[] to, uint arrayLength) { }
	/* GenericInstMethod :
	|
	|-Helper.Get<StatThresholdsInternal, StatThresholds>
	|
	|-Helper.Get<ItemOwnershipInternal, ItemOwnership>
	|
	|-Helper.Get<ParticipantMetadataInternal, ParticipantMetadata>
	*/

	internal static void Get<TTo>(IntPtr from, out Nullable<TTo> to) { }
	/* GenericInstMethod :
	|
	|-Helper.Get<DefinitionInternal>
	|
	|-Helper.Get<DefinitionV2Internal>
	|
	|-Helper.Get<PlayerAchievementInternal>
	|
	|-Helper.Get<UnlockedAchievementInternal>
	|
	|-Helper.Get<QuatInternal>
	|
	|-Helper.Get<Vec3fInternal>
	|
	|-Helper.Get<AccountFeatureRestrictedInfoInternal>
	|
	|-Helper.Get<IOSCredentialsSystemAuthCredentialsOptionsInternal>
	|
	|-Helper.Get<IdTokenInternal>
	|
	|-Helper.Get<PinGrantInfoInternal>
	|
	|-Helper.Get<TokenInternal>
	|
	|-Helper.Get<ExternalAccountInfoInternal>
	|
	|-Helper.Get<IdTokenInternal>
	|
	|-Helper.Get<CatalogItemInternal>
	|
	|-Helper.Get<CatalogOfferInternal>
	|
	|-Helper.Get<CatalogReleaseInternal>
	|
	|-Helper.Get<EntitlementInternal>
	|
	|-Helper.Get<KeyImageInfoInternal>
	|
	|-Helper.Get<PermissionStatusInternal>
	|
	|-Helper.Get<DefinitionInternal>
	|
	|-Helper.Get<LeaderboardRecordInternal>
	|
	|-Helper.Get<LeaderboardUserScoreInternal>
	|
	|-Helper.Get<AttributeDataInternal>
	|
	|-Helper.Get<AttributeInternal>
	|
	|-Helper.Get<LobbyDetailsInfoInternal>
	|
	|-Helper.Get<ModIdentifierInternal>
	|
	|-Helper.Get<ModInfoInternal>
	|
	|-Helper.Get<SocketIdInternal>
	|
	|-Helper.Get<WindowsRTCOptionsPlatformSpecificOptionsInternal>
	|
	|-Helper.Get<FileMetadataInternal>
	|
	|-Helper.Get<InfoInternal>
	|
	|-Helper.Get<UserTokenInternal>
	|
	|-Helper.Get<AudioBufferInternal>
	|
	|-Helper.Get<AudioInputDeviceInfoInternal>
	|
	|-Helper.Get<AudioOutputDeviceInfoInternal>
	|
	|-Helper.Get<PlayerSanctionInternal>
	|
	|-Helper.Get<ActiveSessionInfoInternal>
	|
	|-Helper.Get<AttributeDataInternal>
	|
	|-Helper.Get<SessionDetailsAttributeInternal>
	|
	|-Helper.Get<SessionDetailsInfoInternal>
	|
	|-Helper.Get<SessionDetailsSettingsInternal>
	|
	|-Helper.Get<StatInternal>
	|
	|-Helper.Get<FileMetadataInternal>
	|
	|-Helper.Get<ExternalUserInfoInternal>
	|
	|-Helper.Get<UserInfoDataInternal>
	|
	|-Helper.Get<IntPtr>
	*/

	internal static void Get(byte[] from, out string to) { }

	internal static void Get(IntPtr from, out object to) { }

	internal static void Get(IntPtr from, out Utf8String to) { }

	internal static void Get<T, TEnum>(T from, out T to, TEnum currentEnum, TEnum expectedEnum) { }
	/* GenericInstMethod :
	|
	|-Helper.Get<Quat, AntiCheatCommonEventParamType>
	|-Helper.Get<Quat, Int32Enum>
	|
	|-Helper.Get<Vec3f, AntiCheatCommonEventParamType>
	|-Helper.Get<Vec3f, Int32Enum>
	|
	|-Helper.Get<EpicAccountId, MetricsAccountIdType>
	|-Helper.Get<Utf8String, AntiCheatCommonEventParamType>
	|-Helper.Get<Utf8String, AttributeType>
	|-Helper.Get<Utf8String, MetricsAccountIdType>
	|-Helper.Get<object, Int32Enum>
	|
	|-Helper.Get<Nullable<bool>, AttributeType>
	|-Helper.Get<Nullable<bool>, Int32Enum>
	|
	|-Helper.Get<Nullable<double>, AttributeType>
	|-Helper.Get<Nullable<double>, Int32Enum>
	|
	|-Helper.Get<Nullable<int>, AntiCheatCommonEventParamType>
	|-Helper.Get<Nullable<int>, Int32Enum>
	|
	|-Helper.Get<Nullable<long>, AntiCheatCommonEventParamType>
	|-Helper.Get<Nullable<long>, AttributeType>
	|-Helper.Get<Nullable<long>, Int32Enum>
	|
	|-Helper.Get<Nullable<IntPtr>, AntiCheatCommonEventParamType>
	|-Helper.Get<Nullable<IntPtr>, Int32Enum>
	|
	|-Helper.Get<Nullable<uint>, AntiCheatCommonEventParamType>
	|-Helper.Get<Nullable<uint>, Int32Enum>
	|
	|-Helper.Get<Nullable<ulong>, AntiCheatCommonEventParamType>
	|-Helper.Get<Nullable<ulong>, Int32Enum>
	|
	|-Helper.Get<object, object>
	*/

	internal static void Get<TFrom, TTo, TEnum>(ref TFrom from, out TTo to, TEnum currentEnum, TEnum expectedEnum) { }
	/* GenericInstMethod :
	|
	|-Helper.Get<QuatInternal, Quat, AntiCheatCommonEventParamType>
	|-Helper.Get<QuatInternal, Quat, Int32Enum>
	|
	|-Helper.Get<Vec3fInternal, Vec3f, AntiCheatCommonEventParamType>
	|-Helper.Get<Vec3fInternal, Vec3f, Int32Enum>
	*/

	internal static void Get<TEnum>(int from, out Nullable<bool> to, TEnum currentEnum, TEnum expectedEnum) { }
	/* GenericInstMethod :
	|
	|-Helper.Get<AttributeType>
	|-Helper.Get<Int32Enum>
	|
	|-Helper.Get<object>
	*/

	internal static void Get<TFrom, TEnum>(TFrom from, out Nullable<TFrom> to, TEnum currentEnum, TEnum expectedEnum) { }
	/* GenericInstMethod :
	|
	|-Helper.Get<double, AttributeType>
	|-Helper.Get<double, Int32Enum>
	|
	|-Helper.Get<int, AntiCheatCommonEventParamType>
	|-Helper.Get<int, Int32Enum>
	|
	|-Helper.Get<long, AntiCheatCommonEventParamType>
	|-Helper.Get<long, AttributeType>
	|-Helper.Get<long, Int32Enum>
	|
	|-Helper.Get<uint, AntiCheatCommonEventParamType>
	|-Helper.Get<uint, Int32Enum>
	|
	|-Helper.Get<ulong, AntiCheatCommonEventParamType>
	|-Helper.Get<ulong, Int32Enum>
	*/

	internal static void Get<TFrom, TEnum>(IntPtr from, out TFrom to, TEnum currentEnum, TEnum expectedEnum) { }
	/* GenericInstMethod :
	|
	|-Helper.Get<EpicAccountId, MetricsAccountIdType>
	|-Helper.Get<object, Int32Enum>
	|
	|-Helper.Get<object, object>
	*/

	internal static void Get<TEnum>(IntPtr from, out Nullable<IntPtr> to, TEnum currentEnum, TEnum expectedEnum) { }
	/* GenericInstMethod :
	|
	|-Helper.Get<AntiCheatCommonEventParamType>
	|-Helper.Get<Int32Enum>
	|
	|-Helper.Get<object>
	*/

	internal static void Get<TEnum>(IntPtr from, out Utf8String to, TEnum currentEnum, TEnum expectedEnum) { }
	/* GenericInstMethod :
	|
	|-Helper.Get<AntiCheatCommonEventParamType>
	|-Helper.Get<AttributeType>
	|-Helper.Get<MetricsAccountIdType>
	|-Helper.Get<Int32Enum>
	|
	|-Helper.Get<object>
	*/

	internal static void Get<TFrom, TTo>(IntPtr from, out TTo to) { }

	internal static void Get<TFrom, TTo>(IntPtr from, out Nullable<TTo> to) { }
	/* GenericInstMethod :
	|
	|-Helper.Get<DefinitionInternal, Definition>
	|
	|-Helper.Get<DefinitionV2Internal, DefinitionV2>
	|
	|-Helper.Get<PlayerAchievementInternal, PlayerAchievement>
	|
	|-Helper.Get<UnlockedAchievementInternal, UnlockedAchievement>
	|
	|-Helper.Get<QuatInternal, Quat>
	|
	|-Helper.Get<Vec3fInternal, Vec3f>
	|
	|-Helper.Get<AccountFeatureRestrictedInfoInternal, AccountFeatureRestrictedInfo>
	|
	|-Helper.Get<IOSCredentialsSystemAuthCredentialsOptionsInternal, IOSCredentialsSystemAuthCredentialsOptions>
	|
	|-Helper.Get<IdTokenInternal, IdToken>
	|
	|-Helper.Get<PinGrantInfoInternal, PinGrantInfo>
	|
	|-Helper.Get<TokenInternal, Token>
	|
	|-Helper.Get<ExternalAccountInfoInternal, ExternalAccountInfo>
	|
	|-Helper.Get<IdTokenInternal, IdToken>
	|
	|-Helper.Get<CatalogItemInternal, CatalogItem>
	|
	|-Helper.Get<CatalogOfferInternal, CatalogOffer>
	|
	|-Helper.Get<CatalogReleaseInternal, CatalogRelease>
	|
	|-Helper.Get<EntitlementInternal, Entitlement>
	|
	|-Helper.Get<KeyImageInfoInternal, KeyImageInfo>
	|
	|-Helper.Get<PermissionStatusInternal, PermissionStatus>
	|
	|-Helper.Get<DefinitionInternal, Definition>
	|
	|-Helper.Get<LeaderboardRecordInternal, LeaderboardRecord>
	|
	|-Helper.Get<LeaderboardUserScoreInternal, LeaderboardUserScore>
	|
	|-Helper.Get<AttributeDataInternal, AttributeData>
	|
	|-Helper.Get<AttributeInternal, Attribute>
	|
	|-Helper.Get<LobbyDetailsInfoInternal, LobbyDetailsInfo>
	|
	|-Helper.Get<ModIdentifierInternal, ModIdentifier>
	|
	|-Helper.Get<ModInfoInternal, ModInfo>
	|
	|-Helper.Get<SocketIdInternal, SocketId>
	|
	|-Helper.Get<WindowsRTCOptionsPlatformSpecificOptionsInternal, WindowsRTCOptionsPlatformSpecificOptions>
	|
	|-Helper.Get<FileMetadataInternal, FileMetadata>
	|
	|-Helper.Get<InfoInternal, Info>
	|
	|-Helper.Get<UserTokenInternal, UserToken>
	|
	|-Helper.Get<AudioBufferInternal, AudioBuffer>
	|
	|-Helper.Get<AudioInputDeviceInfoInternal, AudioInputDeviceInfo>
	|
	|-Helper.Get<AudioOutputDeviceInfoInternal, AudioOutputDeviceInfo>
	|
	|-Helper.Get<PlayerSanctionInternal, PlayerSanction>
	|
	|-Helper.Get<ActiveSessionInfoInternal, ActiveSessionInfo>
	|
	|-Helper.Get<AttributeDataInternal, AttributeData>
	|
	|-Helper.Get<SessionDetailsAttributeInternal, SessionDetailsAttribute>
	|
	|-Helper.Get<SessionDetailsInfoInternal, SessionDetailsInfo>
	|
	|-Helper.Get<SessionDetailsSettingsInternal, SessionDetailsSettings>
	|
	|-Helper.Get<StatInternal, Stat>
	|
	|-Helper.Get<FileMetadataInternal, FileMetadata>
	|
	|-Helper.Get<ExternalUserInfoInternal, ExternalUserInfo>
	|
	|-Helper.Get<UserInfoDataInternal, UserInfoData>
	*/

	internal static void Get<TFrom, TTo>(ref TFrom from, out TTo to, out IntPtr clientDataAddress) { }
	/* GenericInstMethod :
	|
	|-Helper.Get<OnAchievementsUnlockedCallbackInfoInternal, OnAchievementsUnlockedCallbackInfo>
	|
	|-Helper.Get<OnAchievementsUnlockedCallbackV2InfoInternal, OnAchievementsUnlockedCallbackV2Info>
	|
	|-Helper.Get<OnQueryDefinitionsCompleteCallbackInfoInternal, OnQueryDefinitionsCompleteCallbackInfo>
	|
	|-Helper.Get<OnQueryPlayerAchievementsCompleteCallbackInfoInternal, OnQueryPlayerAchievementsCompleteCallbackInfo>
	|
	|-Helper.Get<OnUnlockAchievementsCompleteCallbackInfoInternal, OnUnlockAchievementsCompleteCallbackInfo>
	|
	|-Helper.Get<OnClientIntegrityViolatedCallbackInfoInternal, OnClientIntegrityViolatedCallbackInfo>
	|
	|-Helper.Get<OnMessageToServerCallbackInfoInternal, OnMessageToServerCallbackInfo>
	|
	|-Helper.Get<OnClientActionRequiredCallbackInfoInternal, OnClientActionRequiredCallbackInfo>
	|
	|-Helper.Get<OnClientAuthStatusChangedCallbackInfoInternal, OnClientAuthStatusChangedCallbackInfo>
	|
	|-Helper.Get<OnMessageToClientCallbackInfoInternal, OnMessageToClientCallbackInfo>
	|
	|-Helper.Get<DeletePersistentAuthCallbackInfoInternal, DeletePersistentAuthCallbackInfo>
	|
	|-Helper.Get<LinkAccountCallbackInfoInternal, LinkAccountCallbackInfo>
	|
	|-Helper.Get<LoginCallbackInfoInternal, LoginCallbackInfo>
	|
	|-Helper.Get<LoginStatusChangedCallbackInfoInternal, LoginStatusChangedCallbackInfo>
	|
	|-Helper.Get<LogoutCallbackInfoInternal, LogoutCallbackInfo>
	|
	|-Helper.Get<QueryIdTokenCallbackInfoInternal, QueryIdTokenCallbackInfo>
	|
	|-Helper.Get<VerifyIdTokenCallbackInfoInternal, VerifyIdTokenCallbackInfo>
	|
	|-Helper.Get<VerifyUserAuthCallbackInfoInternal, VerifyUserAuthCallbackInfo>
	|
	|-Helper.Get<AuthExpirationCallbackInfoInternal, AuthExpirationCallbackInfo>
	|
	|-Helper.Get<CreateDeviceIdCallbackInfoInternal, CreateDeviceIdCallbackInfo>
	|
	|-Helper.Get<CreateUserCallbackInfoInternal, CreateUserCallbackInfo>
	|
	|-Helper.Get<DeleteDeviceIdCallbackInfoInternal, DeleteDeviceIdCallbackInfo>
	|
	|-Helper.Get<LinkAccountCallbackInfoInternal, LinkAccountCallbackInfo>
	|
	|-Helper.Get<LoginCallbackInfoInternal, LoginCallbackInfo>
	|
	|-Helper.Get<LoginStatusChangedCallbackInfoInternal, LoginStatusChangedCallbackInfo>
	|
	|-Helper.Get<QueryExternalAccountMappingsCallbackInfoInternal, QueryExternalAccountMappingsCallbackInfo>
	|
	|-Helper.Get<QueryProductUserIdMappingsCallbackInfoInternal, QueryProductUserIdMappingsCallbackInfo>
	|
	|-Helper.Get<TransferDeviceIdAccountCallbackInfoInternal, TransferDeviceIdAccountCallbackInfo>
	|
	|-Helper.Get<UnlinkAccountCallbackInfoInternal, UnlinkAccountCallbackInfo>
	|
	|-Helper.Get<VerifyIdTokenCallbackInfoInternal, VerifyIdTokenCallbackInfo>
	|
	|-Helper.Get<CustomInviteRejectedCallbackInfoInternal, CustomInviteRejectedCallbackInfo>
	|
	|-Helper.Get<OnCustomInviteAcceptedCallbackInfoInternal, OnCustomInviteAcceptedCallbackInfo>
	|
	|-Helper.Get<OnCustomInviteReceivedCallbackInfoInternal, OnCustomInviteReceivedCallbackInfo>
	|
	|-Helper.Get<SendCustomInviteCallbackInfoInternal, SendCustomInviteCallbackInfo>
	|
	|-Helper.Get<CheckoutCallbackInfoInternal, CheckoutCallbackInfo>
	|
	|-Helper.Get<QueryEntitlementsCallbackInfoInternal, QueryEntitlementsCallbackInfo>
	|
	|-Helper.Get<QueryOffersCallbackInfoInternal, QueryOffersCallbackInfo>
	|
	|-Helper.Get<QueryOwnershipCallbackInfoInternal, QueryOwnershipCallbackInfo>
	|
	|-Helper.Get<QueryOwnershipTokenCallbackInfoInternal, QueryOwnershipTokenCallbackInfo>
	|
	|-Helper.Get<RedeemEntitlementsCallbackInfoInternal, RedeemEntitlementsCallbackInfo>
	|
	|-Helper.Get<AcceptInviteCallbackInfoInternal, AcceptInviteCallbackInfo>
	|
	|-Helper.Get<OnFriendsUpdateInfoInternal, OnFriendsUpdateInfo>
	|
	|-Helper.Get<QueryFriendsCallbackInfoInternal, QueryFriendsCallbackInfo>
	|
	|-Helper.Get<RejectInviteCallbackInfoInternal, RejectInviteCallbackInfo>
	|
	|-Helper.Get<SendInviteCallbackInfoInternal, SendInviteCallbackInfo>
	|
	|-Helper.Get<CreateUserCallbackInfoInternal, CreateUserCallbackInfo>
	|
	|-Helper.Get<PermissionsUpdateReceivedCallbackInfoInternal, PermissionsUpdateReceivedCallbackInfo>
	|
	|-Helper.Get<QueryAgeGateCallbackInfoInternal, QueryAgeGateCallbackInfo>
	|
	|-Helper.Get<QueryPermissionsCallbackInfoInternal, QueryPermissionsCallbackInfo>
	|
	|-Helper.Get<RequestPermissionsCallbackInfoInternal, RequestPermissionsCallbackInfo>
	|
	|-Helper.Get<UpdateParentEmailCallbackInfoInternal, UpdateParentEmailCallbackInfo>
	|
	|-Helper.Get<OnQueryLeaderboardDefinitionsCompleteCallbackInfoInternal, OnQueryLeaderboardDefinitionsCompleteCallbackInfo>
	|
	|-Helper.Get<OnQueryLeaderboardRanksCompleteCallbackInfoInternal, OnQueryLeaderboardRanksCompleteCallbackInfo>
	|
	|-Helper.Get<OnQueryLeaderboardUserScoresCompleteCallbackInfoInternal, OnQueryLeaderboardUserScoresCompleteCallbackInfo>
	|
	|-Helper.Get<CreateLobbyCallbackInfoInternal, CreateLobbyCallbackInfo>
	|
	|-Helper.Get<DestroyLobbyCallbackInfoInternal, DestroyLobbyCallbackInfo>
	|
	|-Helper.Get<HardMuteMemberCallbackInfoInternal, HardMuteMemberCallbackInfo>
	|
	|-Helper.Get<JoinLobbyAcceptedCallbackInfoInternal, JoinLobbyAcceptedCallbackInfo>
	|
	|-Helper.Get<JoinLobbyByIdCallbackInfoInternal, JoinLobbyByIdCallbackInfo>
	|
	|-Helper.Get<JoinLobbyCallbackInfoInternal, JoinLobbyCallbackInfo>
	|
	|-Helper.Get<KickMemberCallbackInfoInternal, KickMemberCallbackInfo>
	|
	|-Helper.Get<LeaveLobbyCallbackInfoInternal, LeaveLobbyCallbackInfo>
	|
	|-Helper.Get<LobbyInviteAcceptedCallbackInfoInternal, LobbyInviteAcceptedCallbackInfo>
	|
	|-Helper.Get<LobbyInviteReceivedCallbackInfoInternal, LobbyInviteReceivedCallbackInfo>
	|
	|-Helper.Get<LobbyInviteRejectedCallbackInfoInternal, LobbyInviteRejectedCallbackInfo>
	|
	|-Helper.Get<LobbyMemberStatusReceivedCallbackInfoInternal, LobbyMemberStatusReceivedCallbackInfo>
	|
	|-Helper.Get<LobbyMemberUpdateReceivedCallbackInfoInternal, LobbyMemberUpdateReceivedCallbackInfo>
	|
	|-Helper.Get<LobbySearchFindCallbackInfoInternal, LobbySearchFindCallbackInfo>
	|
	|-Helper.Get<LobbyUpdateReceivedCallbackInfoInternal, LobbyUpdateReceivedCallbackInfo>
	|
	|-Helper.Get<PromoteMemberCallbackInfoInternal, PromoteMemberCallbackInfo>
	|
	|-Helper.Get<QueryInvitesCallbackInfoInternal, QueryInvitesCallbackInfo>
	|
	|-Helper.Get<RTCRoomConnectionChangedCallbackInfoInternal, RTCRoomConnectionChangedCallbackInfo>
	|
	|-Helper.Get<RejectInviteCallbackInfoInternal, RejectInviteCallbackInfo>
	|
	|-Helper.Get<SendInviteCallbackInfoInternal, SendInviteCallbackInfo>
	|
	|-Helper.Get<SendLobbyNativeInviteRequestedCallbackInfoInternal, SendLobbyNativeInviteRequestedCallbackInfo>
	|
	|-Helper.Get<UpdateLobbyCallbackInfoInternal, UpdateLobbyCallbackInfo>
	|
	|-Helper.Get<EnumerateModsCallbackInfoInternal, EnumerateModsCallbackInfo>
	|
	|-Helper.Get<InstallModCallbackInfoInternal, InstallModCallbackInfo>
	|
	|-Helper.Get<UninstallModCallbackInfoInternal, UninstallModCallbackInfo>
	|
	|-Helper.Get<UpdateModCallbackInfoInternal, UpdateModCallbackInfo>
	|
	|-Helper.Get<OnIncomingConnectionRequestInfoInternal, OnIncomingConnectionRequestInfo>
	|
	|-Helper.Get<OnIncomingPacketQueueFullInfoInternal, OnIncomingPacketQueueFullInfo>
	|
	|-Helper.Get<OnPeerConnectionEstablishedInfoInternal, OnPeerConnectionEstablishedInfo>
	|
	|-Helper.Get<OnPeerConnectionInterruptedInfoInternal, OnPeerConnectionInterruptedInfo>
	|
	|-Helper.Get<OnQueryNATTypeCompleteInfoInternal, OnQueryNATTypeCompleteInfo>
	|
	|-Helper.Get<OnRemoteConnectionClosedInfoInternal, OnRemoteConnectionClosedInfo>
	|
	|-Helper.Get<DeleteCacheCallbackInfoInternal, DeleteCacheCallbackInfo>
	|
	|-Helper.Get<DeleteFileCallbackInfoInternal, DeleteFileCallbackInfo>
	|
	|-Helper.Get<DuplicateFileCallbackInfoInternal, DuplicateFileCallbackInfo>
	|
	|-Helper.Get<FileTransferProgressCallbackInfoInternal, FileTransferProgressCallbackInfo>
	|
	|-Helper.Get<QueryFileCallbackInfoInternal, QueryFileCallbackInfo>
	|
	|-Helper.Get<QueryFileListCallbackInfoInternal, QueryFileListCallbackInfo>
	|
	|-Helper.Get<ReadFileCallbackInfoInternal, ReadFileCallbackInfo>
	|
	|-Helper.Get<ReadFileDataCallbackInfoInternal, ReadFileDataCallbackInfo>
	|
	|-Helper.Get<WriteFileCallbackInfoInternal, WriteFileCallbackInfo>
	|
	|-Helper.Get<WriteFileDataCallbackInfoInternal, WriteFileDataCallbackInfo>
	|
	|-Helper.Get<JoinGameAcceptedCallbackInfoInternal, JoinGameAcceptedCallbackInfo>
	|
	|-Helper.Get<PresenceChangedCallbackInfoInternal, PresenceChangedCallbackInfo>
	|
	|-Helper.Get<QueryPresenceCallbackInfoInternal, QueryPresenceCallbackInfo>
	|
	|-Helper.Get<SetPresenceCallbackInfoInternal, SetPresenceCallbackInfo>
	|
	|-Helper.Get<DeleteSnapshotCallbackInfoInternal, DeleteSnapshotCallbackInfo>
	|
	|-Helper.Get<SubmitSnapshotCallbackInfoInternal, SubmitSnapshotCallbackInfo>
	|
	|-Helper.Get<BlockParticipantCallbackInfoInternal, BlockParticipantCallbackInfo>
	|
	|-Helper.Get<DisconnectedCallbackInfoInternal, DisconnectedCallbackInfo>
	|
	|-Helper.Get<JoinRoomCallbackInfoInternal, JoinRoomCallbackInfo>
	|
	|-Helper.Get<LeaveRoomCallbackInfoInternal, LeaveRoomCallbackInfo>
	|
	|-Helper.Get<ParticipantStatusChangedCallbackInfoInternal, ParticipantStatusChangedCallbackInfo>
	|
	|-Helper.Get<KickCompleteCallbackInfoInternal, KickCompleteCallbackInfo>
	|
	|-Helper.Get<QueryJoinRoomTokenCompleteCallbackInfoInternal, QueryJoinRoomTokenCompleteCallbackInfo>
	|
	|-Helper.Get<SetParticipantHardMuteCompleteCallbackInfoInternal, SetParticipantHardMuteCompleteCallbackInfo>
	|
	|-Helper.Get<AudioBeforeRenderCallbackInfoInternal, AudioBeforeRenderCallbackInfo>
	|
	|-Helper.Get<AudioBeforeSendCallbackInfoInternal, AudioBeforeSendCallbackInfo>
	|
	|-Helper.Get<AudioDevicesChangedCallbackInfoInternal, AudioDevicesChangedCallbackInfo>
	|
	|-Helper.Get<AudioInputStateCallbackInfoInternal, AudioInputStateCallbackInfo>
	|
	|-Helper.Get<AudioOutputStateCallbackInfoInternal, AudioOutputStateCallbackInfo>
	|
	|-Helper.Get<ParticipantUpdatedCallbackInfoInternal, ParticipantUpdatedCallbackInfo>
	|
	|-Helper.Get<UpdateParticipantVolumeCallbackInfoInternal, UpdateParticipantVolumeCallbackInfo>
	|
	|-Helper.Get<UpdateReceivingCallbackInfoInternal, UpdateReceivingCallbackInfo>
	|
	|-Helper.Get<UpdateReceivingVolumeCallbackInfoInternal, UpdateReceivingVolumeCallbackInfo>
	|
	|-Helper.Get<UpdateSendingCallbackInfoInternal, UpdateSendingCallbackInfo>
	|
	|-Helper.Get<UpdateSendingVolumeCallbackInfoInternal, UpdateSendingVolumeCallbackInfo>
	|
	|-Helper.Get<SendPlayerBehaviorReportCompleteCallbackInfoInternal, SendPlayerBehaviorReportCompleteCallbackInfo>
	|
	|-Helper.Get<QueryActivePlayerSanctionsCallbackInfoInternal, QueryActivePlayerSanctionsCallbackInfo>
	|
	|-Helper.Get<DestroySessionCallbackInfoInternal, DestroySessionCallbackInfo>
	|
	|-Helper.Get<EndSessionCallbackInfoInternal, EndSessionCallbackInfo>
	|
	|-Helper.Get<JoinSessionAcceptedCallbackInfoInternal, JoinSessionAcceptedCallbackInfo>
	|
	|-Helper.Get<JoinSessionCallbackInfoInternal, JoinSessionCallbackInfo>
	|
	|-Helper.Get<QueryInvitesCallbackInfoInternal, QueryInvitesCallbackInfo>
	|
	|-Helper.Get<RegisterPlayersCallbackInfoInternal, RegisterPlayersCallbackInfo>
	|
	|-Helper.Get<RejectInviteCallbackInfoInternal, RejectInviteCallbackInfo>
	|
	|-Helper.Get<SendInviteCallbackInfoInternal, SendInviteCallbackInfo>
	|
	|-Helper.Get<SessionInviteAcceptedCallbackInfoInternal, SessionInviteAcceptedCallbackInfo>
	|
	|-Helper.Get<SessionInviteReceivedCallbackInfoInternal, SessionInviteReceivedCallbackInfo>
	|
	|-Helper.Get<SessionSearchFindCallbackInfoInternal, SessionSearchFindCallbackInfo>
	|
	|-Helper.Get<StartSessionCallbackInfoInternal, StartSessionCallbackInfo>
	|
	|-Helper.Get<UnregisterPlayersCallbackInfoInternal, UnregisterPlayersCallbackInfo>
	|
	|-Helper.Get<UpdateSessionCallbackInfoInternal, UpdateSessionCallbackInfo>
	|
	|-Helper.Get<IngestStatCompleteCallbackInfoInternal, IngestStatCompleteCallbackInfo>
	|
	|-Helper.Get<OnQueryStatsCompleteCallbackInfoInternal, OnQueryStatsCompleteCallbackInfo>
	|
	|-Helper.Get<DeleteCacheCallbackInfoInternal, DeleteCacheCallbackInfo>
	|
	|-Helper.Get<FileTransferProgressCallbackInfoInternal, FileTransferProgressCallbackInfo>
	|
	|-Helper.Get<QueryFileCallbackInfoInternal, QueryFileCallbackInfo>
	|
	|-Helper.Get<QueryFileListCallbackInfoInternal, QueryFileListCallbackInfo>
	|
	|-Helper.Get<ReadFileCallbackInfoInternal, ReadFileCallbackInfo>
	|
	|-Helper.Get<ReadFileDataCallbackInfoInternal, ReadFileDataCallbackInfo>
	|
	|-Helper.Get<HideFriendsCallbackInfoInternal, HideFriendsCallbackInfo>
	|
	|-Helper.Get<OnDisplaySettingsUpdatedCallbackInfoInternal, OnDisplaySettingsUpdatedCallbackInfo>
	|
	|-Helper.Get<OnShowBlockPlayerCallbackInfoInternal, OnShowBlockPlayerCallbackInfo>
	|
	|-Helper.Get<OnShowReportPlayerCallbackInfoInternal, OnShowReportPlayerCallbackInfo>
	|
	|-Helper.Get<ShowFriendsCallbackInfoInternal, ShowFriendsCallbackInfo>
	|
	|-Helper.Get<QueryUserInfoByDisplayNameCallbackInfoInternal, QueryUserInfoByDisplayNameCallbackInfo>
	|
	|-Helper.Get<QueryUserInfoByExternalAccountCallbackInfoInternal, QueryUserInfoByExternalAccountCallbackInfo>
	|
	|-Helper.Get<QueryUserInfoCallbackInfoInternal, QueryUserInfoCallbackInfo>
	*/

	public static int GetAllocationCount() { }

	internal static void Copy(byte[] from, IntPtr to) { }

	internal static void Copy(ArraySegment<byte> from, IntPtr to) { }

	internal static void Dispose(ref IntPtr value) { }

	internal static void Dispose<TDisposable>(ref TDisposable disposable) { }
	/* GenericInstMethod :
	|
	|-Helper.Dispose<AddNotifyAchievementsUnlockedOptionsInternal>
	|
	|-Helper.Dispose<AddNotifyAchievementsUnlockedV2OptionsInternal>
	|
	|-Helper.Dispose<CopyAchievementDefinitionByAchievementIdOptionsInternal>
	|
	|-Helper.Dispose<CopyAchievementDefinitionByIndexOptionsInternal>
	|
	|-Helper.Dispose<CopyAchievementDefinitionV2ByAchievementIdOptionsInternal>
	|
	|-Helper.Dispose<CopyAchievementDefinitionV2ByIndexOptionsInternal>
	|
	|-Helper.Dispose<CopyPlayerAchievementByAchievementIdOptionsInternal>
	|
	|-Helper.Dispose<CopyPlayerAchievementByIndexOptionsInternal>
	|
	|-Helper.Dispose<CopyUnlockedAchievementByAchievementIdOptionsInternal>
	|
	|-Helper.Dispose<CopyUnlockedAchievementByIndexOptionsInternal>
	|
	|-Helper.Dispose<GetAchievementDefinitionCountOptionsInternal>
	|
	|-Helper.Dispose<GetPlayerAchievementCountOptionsInternal>
	|
	|-Helper.Dispose<GetUnlockedAchievementCountOptionsInternal>
	|
	|-Helper.Dispose<QueryDefinitionsOptionsInternal>
	|
	|-Helper.Dispose<QueryPlayerAchievementsOptionsInternal>
	|
	|-Helper.Dispose<UnlockAchievementsOptionsInternal>
	|
	|-Helper.Dispose<AddExternalIntegrityCatalogOptionsInternal>
	|
	|-Helper.Dispose<AddNotifyClientIntegrityViolatedOptionsInternal>
	|
	|-Helper.Dispose<AddNotifyMessageToPeerOptionsInternal>
	|
	|-Helper.Dispose<AddNotifyMessageToServerOptionsInternal>
	|
	|-Helper.Dispose<AddNotifyPeerActionRequiredOptionsInternal>
	|
	|-Helper.Dispose<AddNotifyPeerAuthStatusChangedOptionsInternal>
	|
	|-Helper.Dispose<BeginSessionOptionsInternal>
	|
	|-Helper.Dispose<EndSessionOptionsInternal>
	|
	|-Helper.Dispose<GetProtectMessageOutputLengthOptionsInternal>
	|
	|-Helper.Dispose<PollStatusOptionsInternal>
	|
	|-Helper.Dispose<ProtectMessageOptionsInternal>
	|
	|-Helper.Dispose<ReceiveMessageFromPeerOptionsInternal>
	|
	|-Helper.Dispose<ReceiveMessageFromServerOptionsInternal>
	|
	|-Helper.Dispose<RegisterPeerOptionsInternal>
	|
	|-Helper.Dispose<UnprotectMessageOptionsInternal>
	|
	|-Helper.Dispose<UnregisterPeerOptionsInternal>
	|
	|-Helper.Dispose<LogEventOptionsInternal>
	|
	|-Helper.Dispose<LogEventParamPairParamValueInternal>
	|
	|-Helper.Dispose<LogGameRoundEndOptionsInternal>
	|
	|-Helper.Dispose<LogGameRoundStartOptionsInternal>
	|
	|-Helper.Dispose<LogPlayerDespawnOptionsInternal>
	|
	|-Helper.Dispose<LogPlayerReviveOptionsInternal>
	|
	|-Helper.Dispose<LogPlayerSpawnOptionsInternal>
	|
	|-Helper.Dispose<LogPlayerTakeDamageOptionsInternal>
	|
	|-Helper.Dispose<LogPlayerTickOptionsInternal>
	|
	|-Helper.Dispose<LogPlayerUseAbilityOptionsInternal>
	|
	|-Helper.Dispose<LogPlayerUseWeaponOptionsInternal>
	|
	|-Helper.Dispose<QuatInternal>
	|
	|-Helper.Dispose<RegisterEventOptionsInternal>
	|
	|-Helper.Dispose<SetClientDetailsOptionsInternal>
	|
	|-Helper.Dispose<SetGameSessionIdOptionsInternal>
	|
	|-Helper.Dispose<Vec3fInternal>
	|
	|-Helper.Dispose<AddNotifyClientActionRequiredOptionsInternal>
	|
	|-Helper.Dispose<AddNotifyClientAuthStatusChangedOptionsInternal>
	|
	|-Helper.Dispose<AddNotifyMessageToClientOptionsInternal>
	|
	|-Helper.Dispose<BeginSessionOptionsInternal>
	|
	|-Helper.Dispose<EndSessionOptionsInternal>
	|
	|-Helper.Dispose<GetProtectMessageOutputLengthOptionsInternal>
	|
	|-Helper.Dispose<ProtectMessageOptionsInternal>
	|
	|-Helper.Dispose<ReceiveMessageFromClientOptionsInternal>
	|
	|-Helper.Dispose<RegisterClientOptionsInternal>
	|
	|-Helper.Dispose<SetClientNetworkStateOptionsInternal>
	|
	|-Helper.Dispose<UnprotectMessageOptionsInternal>
	|
	|-Helper.Dispose<UnregisterClientOptionsInternal>
	|
	|-Helper.Dispose<AddNotifyLoginStatusChangedOptionsInternal>
	|
	|-Helper.Dispose<CopyIdTokenOptionsInternal>
	|
	|-Helper.Dispose<CopyUserAuthTokenOptionsInternal>
	|
	|-Helper.Dispose<DeletePersistentAuthOptionsInternal>
	|
	|-Helper.Dispose<IOSLoginOptionsInternal>
	|
	|-Helper.Dispose<LinkAccountOptionsInternal>
	|
	|-Helper.Dispose<LoginOptionsInternal>
	|
	|-Helper.Dispose<LogoutOptionsInternal>
	|
	|-Helper.Dispose<QueryIdTokenOptionsInternal>
	|
	|-Helper.Dispose<VerifyIdTokenOptionsInternal>
	|
	|-Helper.Dispose<VerifyUserAuthOptionsInternal>
	|
	|-Helper.Dispose<AddNotifyAuthExpirationOptionsInternal>
	|
	|-Helper.Dispose<AddNotifyLoginStatusChangedOptionsInternal>
	|
	|-Helper.Dispose<CopyIdTokenOptionsInternal>
	|
	|-Helper.Dispose<CopyProductUserExternalAccountByAccountIdOptionsInternal>
	|
	|-Helper.Dispose<CopyProductUserExternalAccountByAccountTypeOptionsInternal>
	|
	|-Helper.Dispose<CopyProductUserExternalAccountByIndexOptionsInternal>
	|
	|-Helper.Dispose<CopyProductUserInfoOptionsInternal>
	|
	|-Helper.Dispose<CreateDeviceIdOptionsInternal>
	|
	|-Helper.Dispose<CreateUserOptionsInternal>
	|
	|-Helper.Dispose<DeleteDeviceIdOptionsInternal>
	|
	|-Helper.Dispose<GetExternalAccountMappingsOptionsInternal>
	|
	|-Helper.Dispose<GetProductUserExternalAccountCountOptionsInternal>
	|
	|-Helper.Dispose<GetProductUserIdMappingOptionsInternal>
	|
	|-Helper.Dispose<LinkAccountOptionsInternal>
	|
	|-Helper.Dispose<LoginOptionsInternal>
	|
	|-Helper.Dispose<QueryExternalAccountMappingsOptionsInternal>
	|
	|-Helper.Dispose<QueryProductUserIdMappingsOptionsInternal>
	|
	|-Helper.Dispose<TransferDeviceIdAccountOptionsInternal>
	|
	|-Helper.Dispose<UnlinkAccountOptionsInternal>
	|
	|-Helper.Dispose<VerifyIdTokenOptionsInternal>
	|
	|-Helper.Dispose<AddNotifyCustomInviteAcceptedOptionsInternal>
	|
	|-Helper.Dispose<AddNotifyCustomInviteReceivedOptionsInternal>
	|
	|-Helper.Dispose<AddNotifyCustomInviteRejectedOptionsInternal>
	|
	|-Helper.Dispose<FinalizeInviteOptionsInternal>
	|
	|-Helper.Dispose<SendCustomInviteOptionsInternal>
	|
	|-Helper.Dispose<SetCustomInviteOptionsInternal>
	|
	|-Helper.Dispose<CheckoutOptionsInternal>
	|
	|-Helper.Dispose<CopyEntitlementByIdOptionsInternal>
	|
	|-Helper.Dispose<CopyEntitlementByIndexOptionsInternal>
	|
	|-Helper.Dispose<CopyEntitlementByNameAndIndexOptionsInternal>
	|
	|-Helper.Dispose<CopyItemByIdOptionsInternal>
	|
	|-Helper.Dispose<CopyItemImageInfoByIndexOptionsInternal>
	|
	|-Helper.Dispose<CopyItemReleaseByIndexOptionsInternal>
	|
	|-Helper.Dispose<CopyLastRedeemedEntitlementByIndexOptionsInternal>
	|
	|-Helper.Dispose<CopyOfferByIdOptionsInternal>
	|
	|-Helper.Dispose<CopyOfferByIndexOptionsInternal>
	|
	|-Helper.Dispose<CopyOfferImageInfoByIndexOptionsInternal>
	|
	|-Helper.Dispose<CopyOfferItemByIndexOptionsInternal>
	|
	|-Helper.Dispose<CopyTransactionByIdOptionsInternal>
	|
	|-Helper.Dispose<CopyTransactionByIndexOptionsInternal>
	|
	|-Helper.Dispose<GetEntitlementsByNameCountOptionsInternal>
	|
	|-Helper.Dispose<GetEntitlementsCountOptionsInternal>
	|
	|-Helper.Dispose<GetItemImageInfoCountOptionsInternal>
	|
	|-Helper.Dispose<GetItemReleaseCountOptionsInternal>
	|
	|-Helper.Dispose<GetLastRedeemedEntitlementsCountOptionsInternal>
	|
	|-Helper.Dispose<GetOfferCountOptionsInternal>
	|
	|-Helper.Dispose<GetOfferImageInfoCountOptionsInternal>
	|
	|-Helper.Dispose<GetOfferItemCountOptionsInternal>
	|
	|-Helper.Dispose<GetTransactionCountOptionsInternal>
	|
	|-Helper.Dispose<QueryEntitlementsOptionsInternal>
	|
	|-Helper.Dispose<QueryOffersOptionsInternal>
	|
	|-Helper.Dispose<QueryOwnershipOptionsInternal>
	|
	|-Helper.Dispose<QueryOwnershipTokenOptionsInternal>
	|
	|-Helper.Dispose<RedeemEntitlementsOptionsInternal>
	|
	|-Helper.Dispose<TransactionCopyEntitlementByIndexOptionsInternal>
	|
	|-Helper.Dispose<TransactionGetEntitlementsCountOptionsInternal>
	|
	|-Helper.Dispose<AcceptInviteOptionsInternal>
	|
	|-Helper.Dispose<AddNotifyFriendsUpdateOptionsInternal>
	|
	|-Helper.Dispose<GetFriendAtIndexOptionsInternal>
	|
	|-Helper.Dispose<GetFriendsCountOptionsInternal>
	|
	|-Helper.Dispose<GetStatusOptionsInternal>
	|
	|-Helper.Dispose<QueryFriendsOptionsInternal>
	|
	|-Helper.Dispose<RejectInviteOptionsInternal>
	|
	|-Helper.Dispose<SendInviteOptionsInternal>
	|
	|-Helper.Dispose<CreateIntegratedPlatformOptionsContainerOptionsInternal>
	|
	|-Helper.Dispose<IntegratedPlatformOptionsContainerAddOptionsInternal>
	|
	|-Helper.Dispose<AddNotifyPermissionsUpdateReceivedOptionsInternal>
	|
	|-Helper.Dispose<CopyPermissionByIndexOptionsInternal>
	|
	|-Helper.Dispose<CreateUserOptionsInternal>
	|
	|-Helper.Dispose<GetPermissionByKeyOptionsInternal>
	|
	|-Helper.Dispose<GetPermissionsCountOptionsInternal>
	|
	|-Helper.Dispose<QueryAgeGateOptionsInternal>
	|
	|-Helper.Dispose<QueryPermissionsOptionsInternal>
	|
	|-Helper.Dispose<RequestPermissionsOptionsInternal>
	|
	|-Helper.Dispose<UpdateParentEmailOptionsInternal>
	|
	|-Helper.Dispose<CopyLeaderboardDefinitionByIndexOptionsInternal>
	|
	|-Helper.Dispose<CopyLeaderboardDefinitionByLeaderboardIdOptionsInternal>
	|
	|-Helper.Dispose<CopyLeaderboardRecordByIndexOptionsInternal>
	|
	|-Helper.Dispose<CopyLeaderboardRecordByUserIdOptionsInternal>
	|
	|-Helper.Dispose<CopyLeaderboardUserScoreByIndexOptionsInternal>
	|
	|-Helper.Dispose<CopyLeaderboardUserScoreByUserIdOptionsInternal>
	|
	|-Helper.Dispose<GetLeaderboardDefinitionCountOptionsInternal>
	|
	|-Helper.Dispose<GetLeaderboardRecordCountOptionsInternal>
	|
	|-Helper.Dispose<GetLeaderboardUserScoreCountOptionsInternal>
	|
	|-Helper.Dispose<QueryLeaderboardDefinitionsOptionsInternal>
	|
	|-Helper.Dispose<QueryLeaderboardRanksOptionsInternal>
	|
	|-Helper.Dispose<QueryLeaderboardUserScoresOptionsInternal>
	|
	|-Helper.Dispose<AddNotifyJoinLobbyAcceptedOptionsInternal>
	|
	|-Helper.Dispose<AddNotifyLobbyInviteAcceptedOptionsInternal>
	|
	|-Helper.Dispose<AddNotifyLobbyInviteReceivedOptionsInternal>
	|
	|-Helper.Dispose<AddNotifyLobbyInviteRejectedOptionsInternal>
	|
	|-Helper.Dispose<AddNotifyLobbyMemberStatusReceivedOptionsInternal>
	|
	|-Helper.Dispose<AddNotifyLobbyMemberUpdateReceivedOptionsInternal>
	|
	|-Helper.Dispose<AddNotifyLobbyUpdateReceivedOptionsInternal>
	|
	|-Helper.Dispose<AddNotifyRTCRoomConnectionChangedOptionsInternal>
	|
	|-Helper.Dispose<AddNotifySendLobbyNativeInviteRequestedOptionsInternal>
	|
	|-Helper.Dispose<AttributeDataValueInternal>
	|
	|-Helper.Dispose<CopyLobbyDetailsHandleByInviteIdOptionsInternal>
	|
	|-Helper.Dispose<CopyLobbyDetailsHandleByUiEventIdOptionsInternal>
	|
	|-Helper.Dispose<CopyLobbyDetailsHandleOptionsInternal>
	|
	|-Helper.Dispose<CreateLobbyOptionsInternal>
	|
	|-Helper.Dispose<CreateLobbySearchOptionsInternal>
	|
	|-Helper.Dispose<DestroyLobbyOptionsInternal>
	|
	|-Helper.Dispose<GetInviteCountOptionsInternal>
	|
	|-Helper.Dispose<GetInviteIdByIndexOptionsInternal>
	|
	|-Helper.Dispose<GetRTCRoomNameOptionsInternal>
	|
	|-Helper.Dispose<HardMuteMemberOptionsInternal>
	|
	|-Helper.Dispose<IsRTCRoomConnectedOptionsInternal>
	|
	|-Helper.Dispose<JoinLobbyByIdOptionsInternal>
	|
	|-Helper.Dispose<JoinLobbyOptionsInternal>
	|
	|-Helper.Dispose<KickMemberOptionsInternal>
	|
	|-Helper.Dispose<LeaveLobbyOptionsInternal>
	|
	|-Helper.Dispose<LobbyDetailsCopyAttributeByIndexOptionsInternal>
	|
	|-Helper.Dispose<LobbyDetailsCopyAttributeByKeyOptionsInternal>
	|
	|-Helper.Dispose<LobbyDetailsCopyInfoOptionsInternal>
	|
	|-Helper.Dispose<LobbyDetailsCopyMemberAttributeByIndexOptionsInternal>
	|
	|-Helper.Dispose<LobbyDetailsCopyMemberAttributeByKeyOptionsInternal>
	|
	|-Helper.Dispose<LobbyDetailsGetAttributeCountOptionsInternal>
	|
	|-Helper.Dispose<LobbyDetailsGetLobbyOwnerOptionsInternal>
	|
	|-Helper.Dispose<LobbyDetailsGetMemberAttributeCountOptionsInternal>
	|
	|-Helper.Dispose<LobbyDetailsGetMemberByIndexOptionsInternal>
	|
	|-Helper.Dispose<LobbyDetailsGetMemberCountOptionsInternal>
	|
	|-Helper.Dispose<LobbyModificationAddAttributeOptionsInternal>
	|
	|-Helper.Dispose<LobbyModificationAddMemberAttributeOptionsInternal>
	|
	|-Helper.Dispose<LobbyModificationRemoveAttributeOptionsInternal>
	|
	|-Helper.Dispose<LobbyModificationRemoveMemberAttributeOptionsInternal>
	|
	|-Helper.Dispose<LobbyModificationSetBucketIdOptionsInternal>
	|
	|-Helper.Dispose<LobbyModificationSetInvitesAllowedOptionsInternal>
	|
	|-Helper.Dispose<LobbyModificationSetMaxMembersOptionsInternal>
	|
	|-Helper.Dispose<LobbyModificationSetPermissionLevelOptionsInternal>
	|
	|-Helper.Dispose<LobbySearchCopySearchResultByIndexOptionsInternal>
	|
	|-Helper.Dispose<LobbySearchFindOptionsInternal>
	|
	|-Helper.Dispose<LobbySearchGetSearchResultCountOptionsInternal>
	|
	|-Helper.Dispose<LobbySearchRemoveParameterOptionsInternal>
	|
	|-Helper.Dispose<LobbySearchSetLobbyIdOptionsInternal>
	|
	|-Helper.Dispose<LobbySearchSetMaxResultsOptionsInternal>
	|
	|-Helper.Dispose<LobbySearchSetParameterOptionsInternal>
	|
	|-Helper.Dispose<LobbySearchSetTargetUserIdOptionsInternal>
	|
	|-Helper.Dispose<PromoteMemberOptionsInternal>
	|
	|-Helper.Dispose<QueryInvitesOptionsInternal>
	|
	|-Helper.Dispose<RejectInviteOptionsInternal>
	|
	|-Helper.Dispose<SendInviteOptionsInternal>
	|
	|-Helper.Dispose<UpdateLobbyModificationOptionsInternal>
	|
	|-Helper.Dispose<UpdateLobbyOptionsInternal>
	|
	|-Helper.Dispose<BeginPlayerSessionOptionsAccountIdInternal>
	|
	|-Helper.Dispose<BeginPlayerSessionOptionsInternal>
	|
	|-Helper.Dispose<EndPlayerSessionOptionsAccountIdInternal>
	|
	|-Helper.Dispose<EndPlayerSessionOptionsInternal>
	|
	|-Helper.Dispose<CopyModInfoOptionsInternal>
	|
	|-Helper.Dispose<EnumerateModsOptionsInternal>
	|
	|-Helper.Dispose<InstallModOptionsInternal>
	|
	|-Helper.Dispose<UninstallModOptionsInternal>
	|
	|-Helper.Dispose<UpdateModOptionsInternal>
	|
	|-Helper.Dispose<AcceptConnectionOptionsInternal>
	|
	|-Helper.Dispose<AddNotifyIncomingPacketQueueFullOptionsInternal>
	|
	|-Helper.Dispose<AddNotifyPeerConnectionClosedOptionsInternal>
	|
	|-Helper.Dispose<AddNotifyPeerConnectionEstablishedOptionsInternal>
	|
	|-Helper.Dispose<AddNotifyPeerConnectionInterruptedOptionsInternal>
	|
	|-Helper.Dispose<AddNotifyPeerConnectionRequestOptionsInternal>
	|
	|-Helper.Dispose<ClearPacketQueueOptionsInternal>
	|
	|-Helper.Dispose<CloseConnectionOptionsInternal>
	|
	|-Helper.Dispose<CloseConnectionsOptionsInternal>
	|
	|-Helper.Dispose<GetNATTypeOptionsInternal>
	|
	|-Helper.Dispose<GetNextReceivedPacketSizeOptionsInternal>
	|
	|-Helper.Dispose<GetPacketQueueInfoOptionsInternal>
	|
	|-Helper.Dispose<GetPortRangeOptionsInternal>
	|
	|-Helper.Dispose<GetRelayControlOptionsInternal>
	|
	|-Helper.Dispose<QueryNATTypeOptionsInternal>
	|
	|-Helper.Dispose<ReceivePacketOptionsInternal>
	|
	|-Helper.Dispose<SendPacketOptionsInternal>
	|
	|-Helper.Dispose<SetPacketQueueSizeOptionsInternal>
	|
	|-Helper.Dispose<SetPortRangeOptionsInternal>
	|
	|-Helper.Dispose<SetRelayControlOptionsInternal>
	|
	|-Helper.Dispose<AndroidInitializeOptionsInternal>
	|
	|-Helper.Dispose<ClientCredentialsInternal>
	|
	|-Helper.Dispose<GetDesktopCrossplayStatusOptionsInternal>
	|
	|-Helper.Dispose<InitializeOptionsInternal>
	|
	|-Helper.Dispose<OptionsInternal>
	|
	|-Helper.Dispose<WindowsOptionsInternal>
	|
	|-Helper.Dispose<CopyFileMetadataAtIndexOptionsInternal>
	|
	|-Helper.Dispose<CopyFileMetadataByFilenameOptionsInternal>
	|
	|-Helper.Dispose<DeleteCacheOptionsInternal>
	|
	|-Helper.Dispose<DeleteFileOptionsInternal>
	|
	|-Helper.Dispose<DuplicateFileOptionsInternal>
	|
	|-Helper.Dispose<GetFileMetadataCountOptionsInternal>
	|
	|-Helper.Dispose<QueryFileListOptionsInternal>
	|
	|-Helper.Dispose<QueryFileOptionsInternal>
	|
	|-Helper.Dispose<ReadFileOptionsInternal>
	|
	|-Helper.Dispose<WriteFileOptionsInternal>
	|
	|-Helper.Dispose<AddNotifyJoinGameAcceptedOptionsInternal>
	|
	|-Helper.Dispose<AddNotifyOnPresenceChangedOptionsInternal>
	|
	|-Helper.Dispose<CopyPresenceOptionsInternal>
	|
	|-Helper.Dispose<CreatePresenceModificationOptionsInternal>
	|
	|-Helper.Dispose<GetJoinInfoOptionsInternal>
	|
	|-Helper.Dispose<HasPresenceOptionsInternal>
	|
	|-Helper.Dispose<PresenceModificationDeleteDataOptionsInternal>
	|
	|-Helper.Dispose<PresenceModificationSetDataOptionsInternal>
	|
	|-Helper.Dispose<PresenceModificationSetJoinInfoOptionsInternal>
	|
	|-Helper.Dispose<PresenceModificationSetRawRichTextOptionsInternal>
	|
	|-Helper.Dispose<PresenceModificationSetStatusOptionsInternal>
	|
	|-Helper.Dispose<QueryPresenceOptionsInternal>
	|
	|-Helper.Dispose<SetPresenceOptionsInternal>
	|
	|-Helper.Dispose<AddProgressionOptionsInternal>
	|
	|-Helper.Dispose<BeginSnapshotOptionsInternal>
	|
	|-Helper.Dispose<DeleteSnapshotOptionsInternal>
	|
	|-Helper.Dispose<EndSnapshotOptionsInternal>
	|
	|-Helper.Dispose<SubmitSnapshotOptionsInternal>
	|
	|-Helper.Dispose<AddNotifyDisconnectedOptionsInternal>
	|
	|-Helper.Dispose<AddNotifyParticipantStatusChangedOptionsInternal>
	|
	|-Helper.Dispose<BlockParticipantOptionsInternal>
	|
	|-Helper.Dispose<JoinRoomOptionsInternal>
	|
	|-Helper.Dispose<LeaveRoomOptionsInternal>
	|
	|-Helper.Dispose<SetRoomSettingOptionsInternal>
	|
	|-Helper.Dispose<SetSettingOptionsInternal>
	|
	|-Helper.Dispose<CopyUserTokenByIndexOptionsInternal>
	|
	|-Helper.Dispose<CopyUserTokenByUserIdOptionsInternal>
	|
	|-Helper.Dispose<KickOptionsInternal>
	|
	|-Helper.Dispose<QueryJoinRoomTokenOptionsInternal>
	|
	|-Helper.Dispose<SetParticipantHardMuteOptionsInternal>
	|
	|-Helper.Dispose<AddNotifyAudioBeforeRenderOptionsInternal>
	|
	|-Helper.Dispose<AddNotifyAudioBeforeSendOptionsInternal>
	|
	|-Helper.Dispose<AddNotifyAudioDevicesChangedOptionsInternal>
	|
	|-Helper.Dispose<AddNotifyAudioInputStateOptionsInternal>
	|
	|-Helper.Dispose<AddNotifyAudioOutputStateOptionsInternal>
	|
	|-Helper.Dispose<AddNotifyParticipantUpdatedOptionsInternal>
	|
	|-Helper.Dispose<GetAudioInputDeviceByIndexOptionsInternal>
	|
	|-Helper.Dispose<GetAudioInputDevicesCountOptionsInternal>
	|
	|-Helper.Dispose<GetAudioOutputDeviceByIndexOptionsInternal>
	|
	|-Helper.Dispose<GetAudioOutputDevicesCountOptionsInternal>
	|
	|-Helper.Dispose<RegisterPlatformAudioUserOptionsInternal>
	|
	|-Helper.Dispose<SendAudioOptionsInternal>
	|
	|-Helper.Dispose<SetAudioInputSettingsOptionsInternal>
	|
	|-Helper.Dispose<SetAudioOutputSettingsOptionsInternal>
	|
	|-Helper.Dispose<UnregisterPlatformAudioUserOptionsInternal>
	|
	|-Helper.Dispose<UpdateParticipantVolumeOptionsInternal>
	|
	|-Helper.Dispose<UpdateReceivingOptionsInternal>
	|
	|-Helper.Dispose<UpdateReceivingVolumeOptionsInternal>
	|
	|-Helper.Dispose<UpdateSendingOptionsInternal>
	|
	|-Helper.Dispose<UpdateSendingVolumeOptionsInternal>
	|
	|-Helper.Dispose<SendPlayerBehaviorReportOptionsInternal>
	|
	|-Helper.Dispose<CopyPlayerSanctionByIndexOptionsInternal>
	|
	|-Helper.Dispose<GetPlayerSanctionCountOptionsInternal>
	|
	|-Helper.Dispose<QueryActivePlayerSanctionsOptionsInternal>
	|
	|-Helper.Dispose<ActiveSessionCopyInfoOptionsInternal>
	|
	|-Helper.Dispose<ActiveSessionGetRegisteredPlayerByIndexOptionsInternal>
	|
	|-Helper.Dispose<ActiveSessionGetRegisteredPlayerCountOptionsInternal>
	|
	|-Helper.Dispose<AddNotifyJoinSessionAcceptedOptionsInternal>
	|
	|-Helper.Dispose<AddNotifySessionInviteAcceptedOptionsInternal>
	|
	|-Helper.Dispose<AddNotifySessionInviteReceivedOptionsInternal>
	|
	|-Helper.Dispose<AttributeDataValueInternal>
	|
	|-Helper.Dispose<CopyActiveSessionHandleOptionsInternal>
	|
	|-Helper.Dispose<CopySessionHandleByInviteIdOptionsInternal>
	|
	|-Helper.Dispose<CopySessionHandleByUiEventIdOptionsInternal>
	|
	|-Helper.Dispose<CopySessionHandleForPresenceOptionsInternal>
	|
	|-Helper.Dispose<CreateSessionModificationOptionsInternal>
	|
	|-Helper.Dispose<CreateSessionSearchOptionsInternal>
	|
	|-Helper.Dispose<DestroySessionOptionsInternal>
	|
	|-Helper.Dispose<DumpSessionStateOptionsInternal>
	|
	|-Helper.Dispose<EndSessionOptionsInternal>
	|
	|-Helper.Dispose<GetInviteCountOptionsInternal>
	|
	|-Helper.Dispose<GetInviteIdByIndexOptionsInternal>
	|
	|-Helper.Dispose<IsUserInSessionOptionsInternal>
	|
	|-Helper.Dispose<JoinSessionOptionsInternal>
	|
	|-Helper.Dispose<QueryInvitesOptionsInternal>
	|
	|-Helper.Dispose<RegisterPlayersOptionsInternal>
	|
	|-Helper.Dispose<RejectInviteOptionsInternal>
	|
	|-Helper.Dispose<SendInviteOptionsInternal>
	|
	|-Helper.Dispose<SessionDetailsCopyInfoOptionsInternal>
	|
	|-Helper.Dispose<SessionDetailsCopySessionAttributeByIndexOptionsInternal>
	|
	|-Helper.Dispose<SessionDetailsCopySessionAttributeByKeyOptionsInternal>
	|
	|-Helper.Dispose<SessionDetailsGetSessionAttributeCountOptionsInternal>
	|
	|-Helper.Dispose<SessionModificationAddAttributeOptionsInternal>
	|
	|-Helper.Dispose<SessionModificationRemoveAttributeOptionsInternal>
	|
	|-Helper.Dispose<SessionModificationSetBucketIdOptionsInternal>
	|
	|-Helper.Dispose<SessionModificationSetHostAddressOptionsInternal>
	|
	|-Helper.Dispose<SessionModificationSetInvitesAllowedOptionsInternal>
	|
	|-Helper.Dispose<SessionModificationSetJoinInProgressAllowedOptionsInternal>
	|
	|-Helper.Dispose<SessionModificationSetMaxPlayersOptionsInternal>
	|
	|-Helper.Dispose<SessionModificationSetPermissionLevelOptionsInternal>
	|
	|-Helper.Dispose<SessionSearchCopySearchResultByIndexOptionsInternal>
	|
	|-Helper.Dispose<SessionSearchFindOptionsInternal>
	|
	|-Helper.Dispose<SessionSearchGetSearchResultCountOptionsInternal>
	|
	|-Helper.Dispose<SessionSearchRemoveParameterOptionsInternal>
	|
	|-Helper.Dispose<SessionSearchSetMaxResultsOptionsInternal>
	|
	|-Helper.Dispose<SessionSearchSetParameterOptionsInternal>
	|
	|-Helper.Dispose<SessionSearchSetSessionIdOptionsInternal>
	|
	|-Helper.Dispose<SessionSearchSetTargetUserIdOptionsInternal>
	|
	|-Helper.Dispose<StartSessionOptionsInternal>
	|
	|-Helper.Dispose<UnregisterPlayersOptionsInternal>
	|
	|-Helper.Dispose<UpdateSessionModificationOptionsInternal>
	|
	|-Helper.Dispose<UpdateSessionOptionsInternal>
	|
	|-Helper.Dispose<CopyStatByIndexOptionsInternal>
	|
	|-Helper.Dispose<CopyStatByNameOptionsInternal>
	|
	|-Helper.Dispose<GetStatCountOptionsInternal>
	|
	|-Helper.Dispose<IngestStatOptionsInternal>
	|
	|-Helper.Dispose<QueryStatsOptionsInternal>
	|
	|-Helper.Dispose<CopyFileMetadataAtIndexOptionsInternal>
	|
	|-Helper.Dispose<CopyFileMetadataByFilenameOptionsInternal>
	|
	|-Helper.Dispose<DeleteCacheOptionsInternal>
	|
	|-Helper.Dispose<GetFileMetadataCountOptionsInternal>
	|
	|-Helper.Dispose<QueryFileListOptionsInternal>
	|
	|-Helper.Dispose<QueryFileOptionsInternal>
	|
	|-Helper.Dispose<ReadFileOptionsInternal>
	|
	|-Helper.Dispose<AcknowledgeEventIdOptionsInternal>
	|
	|-Helper.Dispose<AddNotifyDisplaySettingsUpdatedOptionsInternal>
	|
	|-Helper.Dispose<GetFriendsExclusiveInputOptionsInternal>
	|
	|-Helper.Dispose<GetFriendsVisibleOptionsInternal>
	|
	|-Helper.Dispose<GetToggleFriendsKeyOptionsInternal>
	|
	|-Helper.Dispose<HideFriendsOptionsInternal>
	|
	|-Helper.Dispose<IsSocialOverlayPausedOptionsInternal>
	|
	|-Helper.Dispose<PauseSocialOverlayOptionsInternal>
	|
	|-Helper.Dispose<SetDisplayPreferenceOptionsInternal>
	|
	|-Helper.Dispose<SetToggleFriendsKeyOptionsInternal>
	|
	|-Helper.Dispose<ShowBlockPlayerOptionsInternal>
	|
	|-Helper.Dispose<ShowFriendsOptionsInternal>
	|
	|-Helper.Dispose<ShowReportPlayerOptionsInternal>
	|
	|-Helper.Dispose<CopyExternalUserInfoByAccountIdOptionsInternal>
	|
	|-Helper.Dispose<CopyExternalUserInfoByAccountTypeOptionsInternal>
	|
	|-Helper.Dispose<CopyExternalUserInfoByIndexOptionsInternal>
	|
	|-Helper.Dispose<CopyUserInfoOptionsInternal>
	|
	|-Helper.Dispose<GetExternalUserInfoCountOptionsInternal>
	|
	|-Helper.Dispose<QueryUserInfoByDisplayNameOptionsInternal>
	|
	|-Helper.Dispose<QueryUserInfoByExternalAccountOptionsInternal>
	|
	|-Helper.Dispose<QueryUserInfoOptionsInternal>
	|
	|-Helper.Dispose<IDisposable>
	|-Helper.Dispose<object>
	*/

	internal static void Dispose<TEnum>(ref IntPtr value, TEnum currentEnum, TEnum expectedEnum) { }
	/* GenericInstMethod :
	|
	|-Helper.Dispose<AntiCheatCommonEventParamType>
	|-Helper.Dispose<AttributeType>
	|-Helper.Dispose<MetricsAccountIdType>
	|-Helper.Dispose<Int32Enum>
	|
	|-Helper.Dispose<object>
	*/

	private static int GetAnsiStringLength(byte[] bytes) { }

	private static int GetAnsiStringLength(IntPtr address) { }

	internal static T GetDefault<T>() { }
	/* GenericInstMethod :
	|
	|-Helper.GetDefault<PlayerStatInfoInternal>
	|-Helper.GetDefault<StatThresholdsInternal>
	|-Helper.GetDefault<ItemOwnershipInternal>
	|-Helper.GetDefault<DataRecordInternal>
	|-Helper.GetDefault<ParticipantMetadataInternal>
	|-Helper.GetDefault<Nullable<AccountFeatureRestrictedInfoInternal>>
	|-Helper.GetDefault<Nullable<IOSCredentialsSystemAuthCredentialsOptionsInternal>>
	|-Helper.GetDefault<Nullable<IdToken>>
	|-Helper.GetDefault<Nullable<IdToken>>
	|-Helper.GetDefault<Nullable<PermissionStatus>>
	|-Helper.GetDefault<Nullable<LeaderboardUserScore>>
	|-Helper.GetDefault<Nullable<ModInfo>>
	|-Helper.GetDefault<Nullable<SocketIdInternal>>
	|-Helper.GetDefault<Nullable<WindowsRTCOptionsPlatformSpecificOptionsInternal>>
	|-Helper.GetDefault<Nullable<UserToken>>
	|-Helper.GetDefault<Nullable<AudioBuffer>>
	|
	|-Helper.GetDefault<AntiCheatClientViolationType>
	|-Helper.GetDefault<KWSPermissionStatus>
	|-Helper.GetDefault<NATType>
	|-Helper.GetDefault<RelayControl>
	|-Helper.GetDefault<GetDesktopCrossplayStatusInfoInternal>
	|-Helper.GetDefault<ReadResult>
	|-Helper.GetDefault<WriteResult>
	|-Helper.GetDefault<ReadResult>
	|-Helper.GetDefault<Utf8String>
	|-Helper.GetDefault<short>
	|-Helper.GetDefault<int>
	|-Helper.GetDefault<Int32Enum>
	|-Helper.GetDefault<Nullable<bool>>
	|-Helper.GetDefault<Nullable<int>>
	|-Helper.GetDefault<Nullable<uint>>
	|-Helper.GetDefault<object>
	|-Helper.GetDefault<ushort>
	|-Helper.GetDefault<uint>
	|
	|-Helper.GetDefault<Quat>
	|-Helper.GetDefault<SocketIdInternal>
	|-Helper.GetDefault<Nullable<Vec3f>>
	|-Helper.GetDefault<Nullable<Vec3fInternal>>
	|-Helper.GetDefault<Nullable<AccountFeatureRestrictedInfo>>
	|-Helper.GetDefault<Nullable<IOSCredentialsSystemAuthCredentialsOptions>>
	|-Helper.GetDefault<Nullable<SocketId>>
	|-Helper.GetDefault<Nullable<WindowsRTCOptionsPlatformSpecificOptions>>
	|-Helper.GetDefault<Nullable<double>>
	|-Helper.GetDefault<Nullable<long>>
	|-Helper.GetDefault<Nullable<IntPtr>>
	|-Helper.GetDefault<Nullable<ulong>>
	|
	|-Helper.GetDefault<Vec3f>
	|
	|-Helper.GetDefault<ModIdentifierInternal>
	|-Helper.GetDefault<PacketQueueInfoInternal>
	|-Helper.GetDefault<Nullable<PinGrantInfoInternal>>
	|-Helper.GetDefault<Nullable<CatalogReleaseInternal>>
	|-Helper.GetDefault<Nullable<Entitlement>>
	|-Helper.GetDefault<Nullable<ModIdentifier>>
	|-Helper.GetDefault<Nullable<FileMetadataInternal>>
	|-Helper.GetDefault<Nullable<PlayerSanctionInternal>>
	|-Helper.GetDefault<Nullable<ActiveSessionInfoInternal>>
	|-Helper.GetDefault<Nullable<SessionDetailsInfoInternal>>
	|-Helper.GetDefault<Nullable<SessionDetailsSettingsInternal>>
	|-Helper.GetDefault<Nullable<StatInternal>>
	|
	|-Helper.GetDefault<byte>
	|
	|-Helper.GetDefault<Nullable<Definition>>
	|-Helper.GetDefault<Nullable<DefinitionV2Internal>>
	|-Helper.GetDefault<Nullable<TokenInternal>>
	|-Helper.GetDefault<Nullable<CatalogItemInternal>>
	|-Helper.GetDefault<Nullable<ActiveSessionInfo>>
	|
	|-Helper.GetDefault<Nullable<DefinitionInternal>>
	|
	|-Helper.GetDefault<Nullable<DefinitionV2>>
	|-Helper.GetDefault<Nullable<PlayerAchievement>>
	|-Helper.GetDefault<Nullable<PlayerAchievementInternal>>
	|-Helper.GetDefault<Nullable<Token>>
	|-Helper.GetDefault<Nullable<CatalogItem>>
	|-Helper.GetDefault<Nullable<Attribute>>
	|-Helper.GetDefault<Nullable<InfoInternal>>
	|-Helper.GetDefault<Nullable<SessionDetailsAttribute>>
	|
	|-Helper.GetDefault<Nullable<UnlockedAchievement>>
	|-Helper.GetDefault<Nullable<PinGrantInfo>>
	|-Helper.GetDefault<Nullable<KeyImageInfoInternal>>
	|-Helper.GetDefault<Nullable<LeaderboardRecordInternal>>
	|-Helper.GetDefault<Nullable<AttributeDataInternal>>
	|-Helper.GetDefault<Nullable<AudioBufferInternal>>
	|-Helper.GetDefault<Nullable<PlayerSanction>>
	|-Helper.GetDefault<Nullable<AttributeDataInternal>>
	|-Helper.GetDefault<Nullable<FileMetadata>>
	|-Helper.GetDefault<Nullable<FileMetadataInternal>>
	|-Helper.GetDefault<Nullable<ExternalUserInfo>>
	|-Helper.GetDefault<Nullable<ExternalUserInfoInternal>>
	|
	|-Helper.GetDefault<Nullable<UnlockedAchievementInternal>>
	|-Helper.GetDefault<Nullable<IdTokenInternal>>
	|-Helper.GetDefault<Nullable<IdTokenInternal>>
	|-Helper.GetDefault<Nullable<CatalogRelease>>
	|-Helper.GetDefault<Nullable<KeyImageInfo>>
	|-Helper.GetDefault<Nullable<PermissionStatusInternal>>
	|-Helper.GetDefault<Nullable<LeaderboardRecord>>
	|-Helper.GetDefault<Nullable<LeaderboardUserScoreInternal>>
	|-Helper.GetDefault<Nullable<AttributeInternal>>
	|-Helper.GetDefault<Nullable<ModInfoInternal>>
	|-Helper.GetDefault<Nullable<UserTokenInternal>>
	|-Helper.GetDefault<Nullable<AudioInputDeviceInfo>>
	|-Helper.GetDefault<Nullable<AudioInputDeviceInfoInternal>>
	|-Helper.GetDefault<Nullable<AudioOutputDeviceInfo>>
	|-Helper.GetDefault<Nullable<AudioOutputDeviceInfoInternal>>
	|-Helper.GetDefault<Nullable<SessionDetailsAttributeInternal>>
	|-Helper.GetDefault<Nullable<SessionDetailsSettings>>
	|
	|-Helper.GetDefault<Nullable<Quat>>
	|-Helper.GetDefault<Nullable<QuatInternal>>
	|
	|-Helper.GetDefault<Nullable<ExternalAccountInfo>>
	|-Helper.GetDefault<Nullable<FileMetadata>>
	|-Helper.GetDefault<Nullable<SessionDetailsInfo>>
	|-Helper.GetDefault<Nullable<UserInfoDataInternal>>
	|
	|-Helper.GetDefault<Nullable<ExternalAccountInfoInternal>>
	|-Helper.GetDefault<Nullable<EntitlementInternal>>
	|-Helper.GetDefault<Nullable<DefinitionInternal>>
	|-Helper.GetDefault<Nullable<LobbyDetailsInfo>>
	|-Helper.GetDefault<Nullable<ModIdentifierInternal>>
	|-Helper.GetDefault<Nullable<UserInfoData>>
	|
	|-Helper.GetDefault<Nullable<CatalogOffer>>
	|-Helper.GetDefault<Nullable<CatalogOfferInternal>>
	|
	|-Helper.GetDefault<Nullable<Definition>>
	|-Helper.GetDefault<Nullable<Info>>
	|
	|-Helper.GetDefault<Nullable<AttributeData>>
	|-Helper.GetDefault<Nullable<LobbyDetailsInfoInternal>>
	|-Helper.GetDefault<Nullable<AttributeData>>
	|-Helper.GetDefault<Nullable<Stat>>
	*/

	private static void GetAllocation<T>(IntPtr source, out T target) { }
	/* GenericInstMethod :
	|
	|-Helper.GetAllocation<PlayerStatInfoInternal>
	|
	|-Helper.GetAllocation<StatThresholdsInternal>
	|
	|-Helper.GetAllocation<ItemOwnershipInternal>
	|
	|-Helper.GetAllocation<ModIdentifierInternal>
	|
	|-Helper.GetAllocation<DataRecordInternal>
	|
	|-Helper.GetAllocation<ParticipantMetadataInternal>
	|
	|-Helper.GetAllocation<short>
	|
	|-Helper.GetAllocation<object>
	*/

	private static void GetAllocation<T>(IntPtr source, out Nullable<T> target) { }
	/* GenericInstMethod :
	|
	|-Helper.GetAllocation<DefinitionInternal>
	|
	|-Helper.GetAllocation<DefinitionV2Internal>
	|
	|-Helper.GetAllocation<PlayerAchievementInternal>
	|
	|-Helper.GetAllocation<UnlockedAchievementInternal>
	|
	|-Helper.GetAllocation<QuatInternal>
	|
	|-Helper.GetAllocation<Vec3fInternal>
	|
	|-Helper.GetAllocation<AccountFeatureRestrictedInfoInternal>
	|
	|-Helper.GetAllocation<IOSCredentialsSystemAuthCredentialsOptionsInternal>
	|
	|-Helper.GetAllocation<IdTokenInternal>
	|
	|-Helper.GetAllocation<PinGrantInfoInternal>
	|
	|-Helper.GetAllocation<TokenInternal>
	|
	|-Helper.GetAllocation<ExternalAccountInfoInternal>
	|
	|-Helper.GetAllocation<IdTokenInternal>
	|
	|-Helper.GetAllocation<CatalogItemInternal>
	|
	|-Helper.GetAllocation<CatalogOfferInternal>
	|
	|-Helper.GetAllocation<CatalogReleaseInternal>
	|
	|-Helper.GetAllocation<EntitlementInternal>
	|
	|-Helper.GetAllocation<KeyImageInfoInternal>
	|
	|-Helper.GetAllocation<PermissionStatusInternal>
	|
	|-Helper.GetAllocation<DefinitionInternal>
	|
	|-Helper.GetAllocation<LeaderboardRecordInternal>
	|
	|-Helper.GetAllocation<LeaderboardUserScoreInternal>
	|
	|-Helper.GetAllocation<AttributeDataInternal>
	|
	|-Helper.GetAllocation<AttributeInternal>
	|
	|-Helper.GetAllocation<LobbyDetailsInfoInternal>
	|
	|-Helper.GetAllocation<ModIdentifierInternal>
	|
	|-Helper.GetAllocation<ModInfoInternal>
	|
	|-Helper.GetAllocation<SocketIdInternal>
	|
	|-Helper.GetAllocation<WindowsRTCOptionsPlatformSpecificOptionsInternal>
	|
	|-Helper.GetAllocation<FileMetadataInternal>
	|
	|-Helper.GetAllocation<InfoInternal>
	|
	|-Helper.GetAllocation<UserTokenInternal>
	|
	|-Helper.GetAllocation<AudioBufferInternal>
	|
	|-Helper.GetAllocation<AudioInputDeviceInfoInternal>
	|
	|-Helper.GetAllocation<AudioOutputDeviceInfoInternal>
	|
	|-Helper.GetAllocation<PlayerSanctionInternal>
	|
	|-Helper.GetAllocation<ActiveSessionInfoInternal>
	|
	|-Helper.GetAllocation<AttributeDataInternal>
	|
	|-Helper.GetAllocation<SessionDetailsAttributeInternal>
	|
	|-Helper.GetAllocation<SessionDetailsInfoInternal>
	|
	|-Helper.GetAllocation<SessionDetailsSettingsInternal>
	|
	|-Helper.GetAllocation<StatInternal>
	|
	|-Helper.GetAllocation<FileMetadataInternal>
	|
	|-Helper.GetAllocation<ExternalUserInfoInternal>
	|
	|-Helper.GetAllocation<UserInfoDataInternal>
	|
	|-Helper.GetAllocation<IntPtr>
	*/

	private static void GetAllocation<THandle>(IntPtr source, out THandle[] target, int arrayLength) { }
	/* GenericInstMethod :
	|
	|-Helper.GetAllocation<object>
	*/

	private static void GetAllocation<T>(IntPtr from, out T[] to, int arrayLength, bool isArrayItemAllocated) { }
	/* GenericInstMethod :
	|
	|-Helper.GetAllocation<PlayerStatInfoInternal>
	|
	|-Helper.GetAllocation<StatThresholdsInternal>
	|
	|-Helper.GetAllocation<ItemOwnershipInternal>
	|
	|-Helper.GetAllocation<ModIdentifierInternal>
	|
	|-Helper.GetAllocation<DataRecordInternal>
	|
	|-Helper.GetAllocation<ParticipantMetadataInternal>
	|
	|-Helper.GetAllocation<short>
	|
	|-Helper.GetAllocation<object>
	*/

	private static void GetAllocation(IntPtr source, out Utf8String target) { }

	internal static IntPtr AddAllocation(int size) { }

	internal static IntPtr AddAllocation(uint size) { }

	private static IntPtr AddAllocation<T>(int size, T cache) { }
	/* GenericInstMethod :
	|
	|-Helper.AddAllocation<PlayerStatInfoInternal>
	|
	|-Helper.AddAllocation<StatThresholdsInternal>
	|
	|-Helper.AddAllocation<LogEventParamPairInternal>
	|
	|-Helper.AddAllocation<LogPlayerUseWeaponDataInternal>
	|
	|-Helper.AddAllocation<QuatInternal>
	|
	|-Helper.AddAllocation<RegisterEventParamDefInternal>
	|
	|-Helper.AddAllocation<Vec3fInternal>
	|
	|-Helper.AddAllocation<AccountFeatureRestrictedInfoInternal>
	|
	|-Helper.AddAllocation<CredentialsInternal>
	|
	|-Helper.AddAllocation<IOSCredentialsInternal>
	|
	|-Helper.AddAllocation<IOSCredentialsSystemAuthCredentialsOptionsInternal>
	|
	|-Helper.AddAllocation<IdTokenInternal>
	|
	|-Helper.AddAllocation<PinGrantInfoInternal>
	|
	|-Helper.AddAllocation<TokenInternal>
	|
	|-Helper.AddAllocation<CredentialsInternal>
	|
	|-Helper.AddAllocation<IdTokenInternal>
	|
	|-Helper.AddAllocation<UserLoginInfoInternal>
	|
	|-Helper.AddAllocation<CheckoutEntryInternal>
	|
	|-Helper.AddAllocation<ItemOwnershipInternal>
	|
	|-Helper.AddAllocation<OptionsInternal>
	|
	|-Helper.AddAllocation<UserScoresQueryStatInfoInternal>
	|
	|-Helper.AddAllocation<AttributeDataInternal>
	|
	|-Helper.AddAllocation<LocalRTCOptionsInternal>
	|
	|-Helper.AddAllocation<ModIdentifierInternal>
	|
	|-Helper.AddAllocation<SocketIdInternal>
	|
	|-Helper.AddAllocation<AndroidInitializeOptionsSystemInitializeOptionsInternal>
	|
	|-Helper.AddAllocation<InitializeThreadAffinityInternal>
	|
	|-Helper.AddAllocation<RTCOptionsInternal>
	|
	|-Helper.AddAllocation<WindowsRTCOptionsInternal>
	|
	|-Helper.AddAllocation<WindowsRTCOptionsPlatformSpecificOptionsInternal>
	|
	|-Helper.AddAllocation<DataRecordInternal>
	|
	|-Helper.AddAllocation<PresenceModificationDataRecordIdInternal>
	|
	|-Helper.AddAllocation<ParticipantMetadataInternal>
	|
	|-Helper.AddAllocation<AudioBufferInternal>
	|
	|-Helper.AddAllocation<AttributeDataInternal>
	|
	|-Helper.AddAllocation<SessionDetailsInfoInternal>
	|
	|-Helper.AddAllocation<SessionDetailsSettingsInternal>
	|
	|-Helper.AddAllocation<IngestDataInternal>
	|
	|-Helper.AddAllocation<short>
	|
	|-Helper.AddAllocation<int>
	|
	|-Helper.AddAllocation<Nullable<byte>>
	|
	|-Helper.AddAllocation<object>
	*/

	private static IntPtr AddAllocation<T>(int size, T[] cache, Nullable<bool> isArrayItemAllocated) { }
	/* GenericInstMethod :
	|
	|-Helper.AddAllocation<PlayerStatInfoInternal>
	|
	|-Helper.AddAllocation<StatThresholdsInternal>
	|
	|-Helper.AddAllocation<LogEventParamPairInternal>
	|
	|-Helper.AddAllocation<RegisterEventParamDefInternal>
	|
	|-Helper.AddAllocation<CheckoutEntryInternal>
	|
	|-Helper.AddAllocation<ItemOwnershipInternal>
	|
	|-Helper.AddAllocation<UserScoresQueryStatInfoInternal>
	|
	|-Helper.AddAllocation<ModIdentifierInternal>
	|
	|-Helper.AddAllocation<DataRecordInternal>
	|
	|-Helper.AddAllocation<PresenceModificationDataRecordIdInternal>
	|
	|-Helper.AddAllocation<ParticipantMetadataInternal>
	|
	|-Helper.AddAllocation<IngestDataInternal>
	|
	|-Helper.AddAllocation<short>
	|
	|-Helper.AddAllocation<int>
	|
	|-Helper.AddAllocation<object>
	*/

	private static IntPtr AddAllocation<T>(T[] array, bool isArrayItemAllocated) { }
	/* GenericInstMethod :
	|
	|-Helper.AddAllocation<PlayerStatInfoInternal>
	|
	|-Helper.AddAllocation<StatThresholdsInternal>
	|
	|-Helper.AddAllocation<LogEventParamPairInternal>
	|
	|-Helper.AddAllocation<RegisterEventParamDefInternal>
	|
	|-Helper.AddAllocation<CheckoutEntryInternal>
	|
	|-Helper.AddAllocation<ItemOwnershipInternal>
	|
	|-Helper.AddAllocation<UserScoresQueryStatInfoInternal>
	|
	|-Helper.AddAllocation<ModIdentifierInternal>
	|
	|-Helper.AddAllocation<DataRecordInternal>
	|
	|-Helper.AddAllocation<PresenceModificationDataRecordIdInternal>
	|
	|-Helper.AddAllocation<ParticipantMetadataInternal>
	|
	|-Helper.AddAllocation<IngestDataInternal>
	|
	|-Helper.AddAllocation<short>
	|
	|-Helper.AddAllocation<int>
	|
	|-Helper.AddAllocation<object>
	*/

	private static void RemoveAllocation(ref IntPtr address) { }

	private static bool TryGetAllocationCache(IntPtr address, out object cache) { }

	private static IntPtr AddPinnedBuffer(byte[] buffer, int offset) { }

	private static IntPtr AddPinnedBuffer(Utf8String str) { }

	internal static IntPtr AddPinnedBuffer(ArraySegment<byte> array) { }

	private static void RemovePinnedBuffer(ref IntPtr address) { }

	internal static void Set<T>(ref T from, ref T to) { }
	/* GenericInstMethod :
	|
	|-Helper.Set<double>
	|-Helper.Set<long>
	|-Helper.Set<IntPtr>
	|-Helper.Set<ulong>
	|
	|-Helper.Set<int>
	|-Helper.Set<uint>
	*/

	internal static void Set(object from, ref IntPtr to) { }

	internal static void Set(Utf8String from, ref IntPtr to) { }

	internal static void Set(Handle from, ref IntPtr to) { }

	internal static void Set<T>(Nullable<T> from, ref IntPtr to) { }
	/* GenericInstMethod :
	|
	|-Helper.Set<byte>
	*/

	internal static void Set<T>(T[] from, ref IntPtr to, bool isArrayItemAllocated) { }
	/* GenericInstMethod :
	|
	|-Helper.Set<PlayerStatInfoInternal>
	|
	|-Helper.Set<StatThresholdsInternal>
	|
	|-Helper.Set<LogEventParamPairInternal>
	|
	|-Helper.Set<RegisterEventParamDefInternal>
	|
	|-Helper.Set<CheckoutEntryInternal>
	|
	|-Helper.Set<ItemOwnershipInternal>
	|
	|-Helper.Set<UserScoresQueryStatInfoInternal>
	|
	|-Helper.Set<ModIdentifierInternal>
	|
	|-Helper.Set<DataRecordInternal>
	|
	|-Helper.Set<PresenceModificationDataRecordIdInternal>
	|
	|-Helper.Set<ParticipantMetadataInternal>
	|
	|-Helper.Set<IngestDataInternal>
	|
	|-Helper.Set<short>
	|
	|-Helper.Set<int>
	|
	|-Helper.Set<object>
	*/

	internal static void Set(ArraySegment<byte> from, ref IntPtr to, out uint arrayLength) { }

	internal static void Set<T>(T[] from, ref IntPtr to) { }
	/* GenericInstMethod :
	|
	|-Helper.Set<PlayerStatInfoInternal>
	|
	|-Helper.Set<StatThresholdsInternal>
	|
	|-Helper.Set<LogEventParamPairInternal>
	|
	|-Helper.Set<RegisterEventParamDefInternal>
	|
	|-Helper.Set<CheckoutEntryInternal>
	|
	|-Helper.Set<ItemOwnershipInternal>
	|
	|-Helper.Set<UserScoresQueryStatInfoInternal>
	|
	|-Helper.Set<ModIdentifierInternal>
	|
	|-Helper.Set<DataRecordInternal>
	|
	|-Helper.Set<PresenceModificationDataRecordIdInternal>
	|
	|-Helper.Set<ParticipantMetadataInternal>
	|
	|-Helper.Set<IngestDataInternal>
	|
	|-Helper.Set<int>
	|
	|-Helper.Set<object>
	*/

	internal static void Set<T>(T[] from, ref IntPtr to, bool isArrayItemAllocated, out int arrayLength) { }
	/* GenericInstMethod :
	|
	|-Helper.Set<object>
	*/

	internal static void Set<T>(T[] from, ref IntPtr to, bool isArrayItemAllocated, out uint arrayLength) { }
	/* GenericInstMethod :
	|
	|-Helper.Set<Utf8String>
	|-Helper.Set<object>
	|
	|-Helper.Set<short>
	*/

	internal static void Set<T>(T[] from, ref IntPtr to, out int arrayLength) { }
	/* GenericInstMethod :
	|
	|-Helper.Set<object>
	*/

	internal static void Set<T>(T[] from, ref IntPtr to, out uint arrayLength) { }
	/* GenericInstMethod :
	|
	|-Helper.Set<ProductUserId>
	|-Helper.Set<Utf8String>
	|-Helper.Set<object>
	|
	|-Helper.Set<short>
	*/

	internal static void Set(Nullable<DateTimeOffset> from, ref long to) { }

	internal static void Set(bool from, ref int to) { }

	internal static void Set(string from, ref byte[] to, int stringLength) { }

	internal static void Set<T, TEnum>(T from, ref T to, TEnum fromEnum, ref TEnum toEnum, IDisposable disposable) { }
	/* GenericInstMethod :
	|
	|-Helper.Set<Quat, AntiCheatCommonEventParamType>
	|-Helper.Set<Quat, Int32Enum>
	|
	|-Helper.Set<Vec3f, AntiCheatCommonEventParamType>
	|-Helper.Set<Vec3f, Int32Enum>
	|
	|-Helper.Set<EpicAccountId, MetricsAccountIdType>
	|-Helper.Set<Utf8String, AntiCheatCommonEventParamType>
	|-Helper.Set<Utf8String, AttributeType>
	|-Helper.Set<Utf8String, MetricsAccountIdType>
	|-Helper.Set<object, Int32Enum>
	|
	|-Helper.Set<Nullable<bool>, AttributeType>
	|-Helper.Set<Nullable<bool>, Int32Enum>
	|
	|-Helper.Set<Nullable<double>, AttributeType>
	|-Helper.Set<Nullable<double>, Int32Enum>
	|
	|-Helper.Set<Nullable<int>, AntiCheatCommonEventParamType>
	|-Helper.Set<Nullable<int>, Int32Enum>
	|
	|-Helper.Set<Nullable<long>, AntiCheatCommonEventParamType>
	|-Helper.Set<Nullable<long>, AttributeType>
	|-Helper.Set<Nullable<long>, Int32Enum>
	|
	|-Helper.Set<Nullable<IntPtr>, AntiCheatCommonEventParamType>
	|-Helper.Set<Nullable<IntPtr>, Int32Enum>
	|
	|-Helper.Set<Nullable<uint>, AntiCheatCommonEventParamType>
	|-Helper.Set<Nullable<uint>, Int32Enum>
	|
	|-Helper.Set<Nullable<ulong>, AntiCheatCommonEventParamType>
	|-Helper.Set<Nullable<ulong>, Int32Enum>
	|
	|-Helper.Set<object, object>
	*/

	internal static void Set<TFrom, TEnum, TTo>(ref TFrom from, ref TTo to, TEnum fromEnum, ref TEnum toEnum, IDisposable disposable) { }
	/* GenericInstMethod :
	|
	|-Helper.Set<Quat, AntiCheatCommonEventParamType, QuatInternal>
	|-Helper.Set<Quat, Int32Enum, QuatInternal>
	|
	|-Helper.Set<Vec3f, AntiCheatCommonEventParamType, Vec3fInternal>
	|-Helper.Set<Vec3f, Int32Enum, Vec3fInternal>
	*/

	internal static void Set<T, TEnum>(Nullable<T> from, ref T to, TEnum fromEnum, ref TEnum toEnum, IDisposable disposable) { }
	/* GenericInstMethod :
	|
	|-Helper.Set<double, AttributeType>
	|-Helper.Set<double, Int32Enum>
	|
	|-Helper.Set<int, AntiCheatCommonEventParamType>
	|-Helper.Set<int, Int32Enum>
	|
	|-Helper.Set<long, AntiCheatCommonEventParamType>
	|-Helper.Set<long, AttributeType>
	|-Helper.Set<long, Int32Enum>
	|
	|-Helper.Set<IntPtr, AntiCheatCommonEventParamType>
	|-Helper.Set<IntPtr, Int32Enum>
	|
	|-Helper.Set<uint, AntiCheatCommonEventParamType>
	|-Helper.Set<uint, Int32Enum>
	|
	|-Helper.Set<ulong, AntiCheatCommonEventParamType>
	|-Helper.Set<ulong, Int32Enum>
	*/

	internal static void Set<TEnum>(Handle from, ref IntPtr to, TEnum fromEnum, ref TEnum toEnum, IDisposable disposable) { }
	/* GenericInstMethod :
	|
	|-Helper.Set<MetricsAccountIdType>
	|-Helper.Set<Int32Enum>
	|
	|-Helper.Set<object>
	*/

	internal static void Set<TEnum>(Utf8String from, ref IntPtr to, TEnum fromEnum, ref TEnum toEnum, IDisposable disposable) { }
	/* GenericInstMethod :
	|
	|-Helper.Set<AntiCheatCommonEventParamType>
	|-Helper.Set<AttributeType>
	|-Helper.Set<MetricsAccountIdType>
	|-Helper.Set<Int32Enum>
	|
	|-Helper.Set<object>
	*/

	internal static void Set<TEnum>(Nullable<bool> from, ref int to, TEnum fromEnum, ref TEnum toEnum, IDisposable disposable) { }
	/* GenericInstMethod :
	|
	|-Helper.Set<AttributeType>
	|-Helper.Set<Int32Enum>
	|
	|-Helper.Set<object>
	*/

	internal static void Set<TFrom, TIntermediate>(ref TFrom from, ref IntPtr to) { }

	internal static void Set<TFrom, TIntermediate>(ref Nullable<TFrom> from, ref IntPtr to) { }
	/* GenericInstMethod :
	|
	|-Helper.Set<LogPlayerUseWeaponData, LogPlayerUseWeaponDataInternal>
	|
	|-Helper.Set<Quat, QuatInternal>
	|
	|-Helper.Set<Vec3f, Vec3fInternal>
	|
	|-Helper.Set<AccountFeatureRestrictedInfo, AccountFeatureRestrictedInfoInternal>
	|
	|-Helper.Set<Credentials, CredentialsInternal>
	|
	|-Helper.Set<IOSCredentials, IOSCredentialsInternal>
	|
	|-Helper.Set<IOSCredentialsSystemAuthCredentialsOptions, IOSCredentialsSystemAuthCredentialsOptionsInternal>
	|
	|-Helper.Set<IdToken, IdTokenInternal>
	|
	|-Helper.Set<PinGrantInfo, PinGrantInfoInternal>
	|
	|-Helper.Set<Token, TokenInternal>
	|
	|-Helper.Set<Credentials, CredentialsInternal>
	|
	|-Helper.Set<IdToken, IdTokenInternal>
	|
	|-Helper.Set<UserLoginInfo, UserLoginInfoInternal>
	|
	|-Helper.Set<Options, OptionsInternal>
	|
	|-Helper.Set<AttributeData, AttributeDataInternal>
	|
	|-Helper.Set<LocalRTCOptions, LocalRTCOptionsInternal>
	|
	|-Helper.Set<ModIdentifier, ModIdentifierInternal>
	|
	|-Helper.Set<SocketId, SocketIdInternal>
	|
	|-Helper.Set<AndroidInitializeOptionsSystemInitializeOptions, AndroidInitializeOptionsSystemInitializeOptionsInternal>
	|
	|-Helper.Set<InitializeThreadAffinity, InitializeThreadAffinityInternal>
	|
	|-Helper.Set<RTCOptions, RTCOptionsInternal>
	|
	|-Helper.Set<WindowsRTCOptions, WindowsRTCOptionsInternal>
	|
	|-Helper.Set<WindowsRTCOptionsPlatformSpecificOptions, WindowsRTCOptionsPlatformSpecificOptionsInternal>
	|
	|-Helper.Set<AudioBuffer, AudioBufferInternal>
	|
	|-Helper.Set<AttributeData, AttributeDataInternal>
	|
	|-Helper.Set<SessionDetailsInfo, SessionDetailsInfoInternal>
	|
	|-Helper.Set<SessionDetailsSettings, SessionDetailsSettingsInternal>
	*/

	internal static void Set<TFrom, TTo>(ref TFrom from, ref TTo to) { }
	/* GenericInstMethod :
	|
	|-Helper.Set<LogEventParamPairParamValue, LogEventParamPairParamValueInternal>
	|
	|-Helper.Set<Quat, QuatInternal>
	|
	|-Helper.Set<Vec3f, Vec3fInternal>
	|
	|-Helper.Set<AttributeDataValue, AttributeDataValueInternal>
	|
	|-Helper.Set<BeginPlayerSessionOptionsAccountId, BeginPlayerSessionOptionsAccountIdInternal>
	|
	|-Helper.Set<EndPlayerSessionOptionsAccountId, EndPlayerSessionOptionsAccountIdInternal>
	|
	|-Helper.Set<ClientCredentials, ClientCredentialsInternal>
	|
	|-Helper.Set<AttributeDataValue, AttributeDataValueInternal>
	*/

	internal static void Set<TFrom, TIntermediate>(ref TFrom[] from, ref IntPtr to, out int arrayLength) { }
	/* GenericInstMethod :
	|
	|-Helper.Set<PlayerStatInfo, PlayerStatInfoInternal>
	|
	|-Helper.Set<StatThresholds, StatThresholdsInternal>
	|
	|-Helper.Set<LogEventParamPair, LogEventParamPairInternal>
	|
	|-Helper.Set<RegisterEventParamDef, RegisterEventParamDefInternal>
	|
	|-Helper.Set<CheckoutEntry, CheckoutEntryInternal>
	|
	|-Helper.Set<ItemOwnership, ItemOwnershipInternal>
	|
	|-Helper.Set<UserScoresQueryStatInfo, UserScoresQueryStatInfoInternal>
	|
	|-Helper.Set<ModIdentifier, ModIdentifierInternal>
	|
	|-Helper.Set<DataRecord, DataRecordInternal>
	|
	|-Helper.Set<PresenceModificationDataRecordId, PresenceModificationDataRecordIdInternal>
	|
	|-Helper.Set<ParticipantMetadata, ParticipantMetadataInternal>
	|
	|-Helper.Set<IngestData, IngestDataInternal>
	*/

	internal static void Set<TFrom, TIntermediate>(ref TFrom[] from, ref IntPtr to, out uint arrayLength) { }
	/* GenericInstMethod :
	|
	|-Helper.Set<StatThresholds, StatThresholdsInternal>
	|
	|-Helper.Set<LogEventParamPair, LogEventParamPairInternal>
	|
	|-Helper.Set<RegisterEventParamDef, RegisterEventParamDefInternal>
	|
	|-Helper.Set<CheckoutEntry, CheckoutEntryInternal>
	|
	|-Helper.Set<ItemOwnership, ItemOwnershipInternal>
	|
	|-Helper.Set<UserScoresQueryStatInfo, UserScoresQueryStatInfoInternal>
	|
	|-Helper.Set<ParticipantMetadata, ParticipantMetadataInternal>
	|
	|-Helper.Set<IngestData, IngestDataInternal>
	*/

	public void .ctor() { }

	private static void .cctor() { }

}

private struct Helper.Allocation // TypeDefIndex: 8248
{
	[CompilerGeneratedAttribute] 
	private int <Size>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private object <Cache>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private Nullable<bool> <IsArrayItemAllocated>k__BackingField; 

	public int Size { get; set; }
	public object Cache { get; set; }
	public Nullable<bool> IsArrayItemAllocated { get; set; }


	[CompilerGeneratedAttribute] 
	public int get_Size() { }

	[CompilerGeneratedAttribute] 
	private void set_Size(int value) { }

	[CompilerGeneratedAttribute] 
	public object get_Cache() { }

	[CompilerGeneratedAttribute] 
	private void set_Cache(object value) { }

	[CompilerGeneratedAttribute] 
	public Nullable<bool> get_IsArrayItemAllocated() { }

	[CompilerGeneratedAttribute] 
	private void set_IsArrayItemAllocated(Nullable<bool> value) { }

	public void .ctor(int size, object cache, Nullable<bool> isArrayItemAllocated) { }

}

private struct Helper.PinnedBuffer // TypeDefIndex: 8249
{
	[CompilerGeneratedAttribute] 
	private GCHandle <Handle>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private int <RefCount>k__BackingField; 

	public GCHandle Handle { get; set; }
	public int RefCount { get; set; }


	[CompilerGeneratedAttribute] 
	public GCHandle get_Handle() { }

	[CompilerGeneratedAttribute] 
	private void set_Handle(GCHandle value) { }

	[CompilerGeneratedAttribute] 
	public int get_RefCount() { }

	[CompilerGeneratedAttribute] 
	public void set_RefCount(int value) { }

	public void .ctor(GCHandle handle) { }

}

private class Helper.DelegateHolder // TypeDefIndex: 8250
{
	[CompilerGeneratedAttribute] 
	private Delegate <Public>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private Delegate <Private>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private Delegate[] <StructDelegates>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private Nullable<ulong> <NotificationId>k__BackingField; 

	public Delegate Public { get; set; }
	public Delegate Private { get; set; }
	public Delegate[] StructDelegates { get; set; }
	public Nullable<ulong> NotificationId { get; set; }


	[CompilerGeneratedAttribute] 
	public Delegate get_Public() { }

	[CompilerGeneratedAttribute] 
	private void set_Public(Delegate value) { }

	[CompilerGeneratedAttribute] 
	public Delegate get_Private() { }

	[CompilerGeneratedAttribute] 
	private void set_Private(Delegate value) { }

	[CompilerGeneratedAttribute] 
	public Delegate[] get_StructDelegates() { }

	[CompilerGeneratedAttribute] 
	private void set_StructDelegates(Delegate[] value) { }

	[CompilerGeneratedAttribute] 
	public Nullable<ulong> get_NotificationId() { }

	[CompilerGeneratedAttribute] 
	public void set_NotificationId(Nullable<ulong> value) { }

	public void .ctor(Delegate publicDelegate, Delegate privateDelegate, Delegate[] structDelegates) { }

}

private sealed class Helper.<>c__3<TCallbackInfoInternal, TCallback, TCallbackInfo> // TypeDefIndex: 8251
{
	public static readonly Helper.<>c__3<TCallbackInfoInternal, TCallback, TCallbackInfo> <>9; 
	public static Func<Delegate, bool> <>9__3_0; 


	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-Helper.<>c__3<FileTransferProgressCallbackInfoInternal, object, FileTransferProgressCallbackInfo>..cctor
	|-Helper.<>c__3<ReadFileDataCallbackInfoInternal, object, ReadFileDataCallbackInfo>..cctor
	|-Helper.<>c__3<WriteFileDataCallbackInfoInternal, object, WriteFileDataCallbackInfo>..cctor
	|-Helper.<>c__3<FileTransferProgressCallbackInfoInternal, object, FileTransferProgressCallbackInfo>..cctor
	|-Helper.<>c__3<ReadFileDataCallbackInfoInternal, object, ReadFileDataCallbackInfo>..cctor
	*/

	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-Helper.<>c__3<FileTransferProgressCallbackInfoInternal, object, FileTransferProgressCallbackInfo>..ctor
	|-Helper.<>c__3<ReadFileDataCallbackInfoInternal, object, ReadFileDataCallbackInfo>..ctor
	|-Helper.<>c__3<WriteFileDataCallbackInfoInternal, object, WriteFileDataCallbackInfo>..ctor
	|-Helper.<>c__3<FileTransferProgressCallbackInfoInternal, object, FileTransferProgressCallbackInfo>..ctor
	|-Helper.<>c__3<ReadFileDataCallbackInfoInternal, object, ReadFileDataCallbackInfo>..ctor
	*/

	internal bool <TryGetStructCallback>b__3_0(Delegate structDelegate) { }
	/* GenericInstMethod :
	|
	|-Helper.<>c__3<FileTransferProgressCallbackInfoInternal, object, FileTransferProgressCallbackInfo>.<TryGetStructCallback>b__3_0
	|
	|-Helper.<>c__3<ReadFileDataCallbackInfoInternal, object, ReadFileDataCallbackInfo>.<TryGetStructCallback>b__3_0
	|
	|-Helper.<>c__3<WriteFileDataCallbackInfoInternal, object, WriteFileDataCallbackInfo>.<TryGetStructCallback>b__3_0
	|
	|-Helper.<>c__3<FileTransferProgressCallbackInfoInternal, object, FileTransferProgressCallbackInfo>.<TryGetStructCallback>b__3_0
	|
	|-Helper.<>c__3<ReadFileDataCallbackInfoInternal, object, ReadFileDataCallbackInfo>.<TryGetStructCallback>b__3_0
	*/

}

private sealed class Helper.<>c__DisplayClass4_0 // TypeDefIndex: 8252
{
	public ulong notificationId; 


	public void .ctor() { }

	internal bool <RemoveCallbackByNotificationId>b__0(KeyValuePair<IntPtr, Helper.DelegateHolder> pair) { }

}

private sealed class Helper.<>c // TypeDefIndex: 8253
{
	public static readonly Helper.<>c <>9; 
	public static Func<int, KeyValuePair<long, Helper.PinnedBuffer>, int> <>9__63_0; 


	private static void .cctor() { }

	public void .ctor() { }

	internal int <GetAllocationCount>b__63_0(int acc, KeyValuePair<long, Helper.PinnedBuffer> x) { }

}

