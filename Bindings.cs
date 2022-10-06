public static class Bindings // TypeDefIndex: 8270
{

	internal static extern ulong EOS_Achievements_AddNotifyAchievementsUnlocked(IntPtr handle, ref AddNotifyAchievementsUnlockedOptionsInternal options, IntPtr clientData, OnAchievementsUnlockedCallbackInternal notificationFn) { }

	internal static extern ulong EOS_Achievements_AddNotifyAchievementsUnlockedV2(IntPtr handle, ref AddNotifyAchievementsUnlockedV2OptionsInternal options, IntPtr clientData, OnAchievementsUnlockedCallbackV2Internal notificationFn) { }

	internal static extern Result EOS_Achievements_CopyAchievementDefinitionByAchievementId(IntPtr handle, ref CopyAchievementDefinitionByAchievementIdOptionsInternal options, ref IntPtr outDefinition) { }

	internal static extern Result EOS_Achievements_CopyAchievementDefinitionByIndex(IntPtr handle, ref CopyAchievementDefinitionByIndexOptionsInternal options, ref IntPtr outDefinition) { }

	internal static extern Result EOS_Achievements_CopyAchievementDefinitionV2ByAchievementId(IntPtr handle, ref CopyAchievementDefinitionV2ByAchievementIdOptionsInternal options, ref IntPtr outDefinition) { }

	internal static extern Result EOS_Achievements_CopyAchievementDefinitionV2ByIndex(IntPtr handle, ref CopyAchievementDefinitionV2ByIndexOptionsInternal options, ref IntPtr outDefinition) { }

	internal static extern Result EOS_Achievements_CopyPlayerAchievementByAchievementId(IntPtr handle, ref CopyPlayerAchievementByAchievementIdOptionsInternal options, ref IntPtr outAchievement) { }

	internal static extern Result EOS_Achievements_CopyPlayerAchievementByIndex(IntPtr handle, ref CopyPlayerAchievementByIndexOptionsInternal options, ref IntPtr outAchievement) { }

	internal static extern Result EOS_Achievements_CopyUnlockedAchievementByAchievementId(IntPtr handle, ref CopyUnlockedAchievementByAchievementIdOptionsInternal options, ref IntPtr outAchievement) { }

	internal static extern Result EOS_Achievements_CopyUnlockedAchievementByIndex(IntPtr handle, ref CopyUnlockedAchievementByIndexOptionsInternal options, ref IntPtr outAchievement) { }

	internal static extern void EOS_Achievements_DefinitionV2_Release(IntPtr achievementDefinition) { }

	internal static extern void EOS_Achievements_Definition_Release(IntPtr achievementDefinition) { }

	internal static extern uint EOS_Achievements_GetAchievementDefinitionCount(IntPtr handle, ref GetAchievementDefinitionCountOptionsInternal options) { }

	internal static extern uint EOS_Achievements_GetPlayerAchievementCount(IntPtr handle, ref GetPlayerAchievementCountOptionsInternal options) { }

	internal static extern uint EOS_Achievements_GetUnlockedAchievementCount(IntPtr handle, ref GetUnlockedAchievementCountOptionsInternal options) { }

	internal static extern void EOS_Achievements_PlayerAchievement_Release(IntPtr achievement) { }

	internal static extern void EOS_Achievements_QueryDefinitions(IntPtr handle, ref QueryDefinitionsOptionsInternal options, IntPtr clientData, OnQueryDefinitionsCompleteCallbackInternal completionDelegate) { }

	internal static extern void EOS_Achievements_QueryPlayerAchievements(IntPtr handle, ref QueryPlayerAchievementsOptionsInternal options, IntPtr clientData, OnQueryPlayerAchievementsCompleteCallbackInternal completionDelegate) { }

	internal static extern void EOS_Achievements_RemoveNotifyAchievementsUnlocked(IntPtr handle, ulong inId) { }

	internal static extern void EOS_Achievements_UnlockAchievements(IntPtr handle, ref UnlockAchievementsOptionsInternal options, IntPtr clientData, OnUnlockAchievementsCompleteCallbackInternal completionDelegate) { }

	internal static extern void EOS_Achievements_UnlockedAchievement_Release(IntPtr achievement) { }

	internal static extern Result EOS_ActiveSession_CopyInfo(IntPtr handle, ref ActiveSessionCopyInfoOptionsInternal options, ref IntPtr outActiveSessionInfo) { }

	internal static extern IntPtr EOS_ActiveSession_GetRegisteredPlayerByIndex(IntPtr handle, ref ActiveSessionGetRegisteredPlayerByIndexOptionsInternal options) { }

	internal static extern uint EOS_ActiveSession_GetRegisteredPlayerCount(IntPtr handle, ref ActiveSessionGetRegisteredPlayerCountOptionsInternal options) { }

	internal static extern void EOS_ActiveSession_Info_Release(IntPtr activeSessionInfo) { }

	internal static extern void EOS_ActiveSession_Release(IntPtr activeSessionHandle) { }

	internal static extern Result EOS_AntiCheatClient_AddExternalIntegrityCatalog(IntPtr handle, ref AddExternalIntegrityCatalogOptionsInternal options) { }

	internal static extern ulong EOS_AntiCheatClient_AddNotifyClientIntegrityViolated(IntPtr handle, ref AddNotifyClientIntegrityViolatedOptionsInternal options, IntPtr clientData, OnClientIntegrityViolatedCallbackInternal notificationFn) { }

	internal static extern ulong EOS_AntiCheatClient_AddNotifyMessageToPeer(IntPtr handle, ref AddNotifyMessageToPeerOptionsInternal options, IntPtr clientData, OnMessageToPeerCallbackInternal notificationFn) { }

	internal static extern ulong EOS_AntiCheatClient_AddNotifyMessageToServer(IntPtr handle, ref AddNotifyMessageToServerOptionsInternal options, IntPtr clientData, OnMessageToServerCallbackInternal notificationFn) { }

	internal static extern ulong EOS_AntiCheatClient_AddNotifyPeerActionRequired(IntPtr handle, ref AddNotifyPeerActionRequiredOptionsInternal options, IntPtr clientData, OnPeerActionRequiredCallbackInternal notificationFn) { }

	internal static extern ulong EOS_AntiCheatClient_AddNotifyPeerAuthStatusChanged(IntPtr handle, ref AddNotifyPeerAuthStatusChangedOptionsInternal options, IntPtr clientData, OnPeerAuthStatusChangedCallbackInternal notificationFn) { }

	internal static extern Result EOS_AntiCheatClient_BeginSession(IntPtr handle, ref BeginSessionOptionsInternal options) { }

	internal static extern Result EOS_AntiCheatClient_EndSession(IntPtr handle, ref EndSessionOptionsInternal options) { }

	internal static extern Result EOS_AntiCheatClient_GetProtectMessageOutputLength(IntPtr handle, ref GetProtectMessageOutputLengthOptionsInternal options, ref uint outBufferSizeBytes) { }

	internal static extern Result EOS_AntiCheatClient_PollStatus(IntPtr handle, ref PollStatusOptionsInternal options, ref AntiCheatClientViolationType outViolationType, IntPtr outMessage) { }

	internal static extern Result EOS_AntiCheatClient_ProtectMessage(IntPtr handle, ref ProtectMessageOptionsInternal options, IntPtr outBuffer, ref uint outBytesWritten) { }

	internal static extern Result EOS_AntiCheatClient_ReceiveMessageFromPeer(IntPtr handle, ref ReceiveMessageFromPeerOptionsInternal options) { }

	internal static extern Result EOS_AntiCheatClient_ReceiveMessageFromServer(IntPtr handle, ref ReceiveMessageFromServerOptionsInternal options) { }

	internal static extern Result EOS_AntiCheatClient_RegisterPeer(IntPtr handle, ref RegisterPeerOptionsInternal options) { }

	internal static extern void EOS_AntiCheatClient_RemoveNotifyClientIntegrityViolated(IntPtr handle, ulong notificationId) { }

	internal static extern void EOS_AntiCheatClient_RemoveNotifyMessageToPeer(IntPtr handle, ulong notificationId) { }

	internal static extern void EOS_AntiCheatClient_RemoveNotifyMessageToServer(IntPtr handle, ulong notificationId) { }

	internal static extern void EOS_AntiCheatClient_RemoveNotifyPeerActionRequired(IntPtr handle, ulong notificationId) { }

	internal static extern void EOS_AntiCheatClient_RemoveNotifyPeerAuthStatusChanged(IntPtr handle, ulong notificationId) { }

	internal static extern Result EOS_AntiCheatClient_UnprotectMessage(IntPtr handle, ref UnprotectMessageOptionsInternal options, IntPtr outBuffer, ref uint outBytesWritten) { }

	internal static extern Result EOS_AntiCheatClient_UnregisterPeer(IntPtr handle, ref UnregisterPeerOptionsInternal options) { }

	internal static extern ulong EOS_AntiCheatServer_AddNotifyClientActionRequired(IntPtr handle, ref AddNotifyClientActionRequiredOptionsInternal options, IntPtr clientData, OnClientActionRequiredCallbackInternal notificationFn) { }

	internal static extern ulong EOS_AntiCheatServer_AddNotifyClientAuthStatusChanged(IntPtr handle, ref AddNotifyClientAuthStatusChangedOptionsInternal options, IntPtr clientData, OnClientAuthStatusChangedCallbackInternal notificationFn) { }

	internal static extern ulong EOS_AntiCheatServer_AddNotifyMessageToClient(IntPtr handle, ref AddNotifyMessageToClientOptionsInternal options, IntPtr clientData, OnMessageToClientCallbackInternal notificationFn) { }

	internal static extern Result EOS_AntiCheatServer_BeginSession(IntPtr handle, ref BeginSessionOptionsInternal options) { }

	internal static extern Result EOS_AntiCheatServer_EndSession(IntPtr handle, ref EndSessionOptionsInternal options) { }

	internal static extern Result EOS_AntiCheatServer_GetProtectMessageOutputLength(IntPtr handle, ref GetProtectMessageOutputLengthOptionsInternal options, ref uint outBufferSizeBytes) { }

	internal static extern Result EOS_AntiCheatServer_LogEvent(IntPtr handle, ref LogEventOptionsInternal options) { }

	internal static extern Result EOS_AntiCheatServer_LogGameRoundEnd(IntPtr handle, ref LogGameRoundEndOptionsInternal options) { }

	internal static extern Result EOS_AntiCheatServer_LogGameRoundStart(IntPtr handle, ref LogGameRoundStartOptionsInternal options) { }

	internal static extern Result EOS_AntiCheatServer_LogPlayerDespawn(IntPtr handle, ref LogPlayerDespawnOptionsInternal options) { }

	internal static extern Result EOS_AntiCheatServer_LogPlayerRevive(IntPtr handle, ref LogPlayerReviveOptionsInternal options) { }

	internal static extern Result EOS_AntiCheatServer_LogPlayerSpawn(IntPtr handle, ref LogPlayerSpawnOptionsInternal options) { }

	internal static extern Result EOS_AntiCheatServer_LogPlayerTakeDamage(IntPtr handle, ref LogPlayerTakeDamageOptionsInternal options) { }

	internal static extern Result EOS_AntiCheatServer_LogPlayerTick(IntPtr handle, ref LogPlayerTickOptionsInternal options) { }

	internal static extern Result EOS_AntiCheatServer_LogPlayerUseAbility(IntPtr handle, ref LogPlayerUseAbilityOptionsInternal options) { }

	internal static extern Result EOS_AntiCheatServer_LogPlayerUseWeapon(IntPtr handle, ref LogPlayerUseWeaponOptionsInternal options) { }

	internal static extern Result EOS_AntiCheatServer_ProtectMessage(IntPtr handle, ref ProtectMessageOptionsInternal options, IntPtr outBuffer, ref uint outBytesWritten) { }

	internal static extern Result EOS_AntiCheatServer_ReceiveMessageFromClient(IntPtr handle, ref ReceiveMessageFromClientOptionsInternal options) { }

	internal static extern Result EOS_AntiCheatServer_RegisterClient(IntPtr handle, ref RegisterClientOptionsInternal options) { }

	internal static extern Result EOS_AntiCheatServer_RegisterEvent(IntPtr handle, ref RegisterEventOptionsInternal options) { }

	internal static extern void EOS_AntiCheatServer_RemoveNotifyClientActionRequired(IntPtr handle, ulong notificationId) { }

	internal static extern void EOS_AntiCheatServer_RemoveNotifyClientAuthStatusChanged(IntPtr handle, ulong notificationId) { }

	internal static extern void EOS_AntiCheatServer_RemoveNotifyMessageToClient(IntPtr handle, ulong notificationId) { }

	internal static extern Result EOS_AntiCheatServer_SetClientDetails(IntPtr handle, ref SetClientDetailsOptionsInternal options) { }

	internal static extern Result EOS_AntiCheatServer_SetClientNetworkState(IntPtr handle, ref SetClientNetworkStateOptionsInternal options) { }

	internal static extern Result EOS_AntiCheatServer_SetGameSessionId(IntPtr handle, ref SetGameSessionIdOptionsInternal options) { }

	internal static extern Result EOS_AntiCheatServer_UnprotectMessage(IntPtr handle, ref UnprotectMessageOptionsInternal options, IntPtr outBuffer, ref uint outBytesWritten) { }

	internal static extern Result EOS_AntiCheatServer_UnregisterClient(IntPtr handle, ref UnregisterClientOptionsInternal options) { }

	internal static extern ulong EOS_Auth_AddNotifyLoginStatusChanged(IntPtr handle, ref AddNotifyLoginStatusChangedOptionsInternal options, IntPtr clientData, OnLoginStatusChangedCallbackInternal notification) { }

	internal static extern Result EOS_Auth_CopyIdToken(IntPtr handle, ref CopyIdTokenOptionsInternal options, ref IntPtr outIdToken) { }

	internal static extern Result EOS_Auth_CopyUserAuthToken(IntPtr handle, ref CopyUserAuthTokenOptionsInternal options, IntPtr localUserId, ref IntPtr outUserAuthToken) { }

	internal static extern void EOS_Auth_DeletePersistentAuth(IntPtr handle, ref DeletePersistentAuthOptionsInternal options, IntPtr clientData, OnDeletePersistentAuthCallbackInternal completionDelegate) { }

	internal static extern IntPtr EOS_Auth_GetLoggedInAccountByIndex(IntPtr handle, int index) { }

	internal static extern int EOS_Auth_GetLoggedInAccountsCount(IntPtr handle) { }

	internal static extern LoginStatus EOS_Auth_GetLoginStatus(IntPtr handle, IntPtr localUserId) { }

	internal static extern IntPtr EOS_Auth_GetMergedAccountByIndex(IntPtr handle, IntPtr localUserId, uint index) { }

	internal static extern uint EOS_Auth_GetMergedAccountsCount(IntPtr handle, IntPtr localUserId) { }

	internal static extern Result EOS_Auth_GetSelectedAccountId(IntPtr handle, IntPtr localUserId, ref IntPtr outSelectedAccountId) { }

	internal static extern void EOS_Auth_IdToken_Release(IntPtr idToken) { }

	internal static extern void EOS_Auth_LinkAccount(IntPtr handle, ref LinkAccountOptionsInternal options, IntPtr clientData, OnLinkAccountCallbackInternal completionDelegate) { }

	internal static extern void EOS_Auth_Login(IntPtr handle, ref LoginOptionsInternal options, IntPtr clientData, OnLoginCallbackInternal completionDelegate) { }

	internal static extern void EOS_Auth_Logout(IntPtr handle, ref LogoutOptionsInternal options, IntPtr clientData, OnLogoutCallbackInternal completionDelegate) { }

	internal static extern void EOS_Auth_QueryIdToken(IntPtr handle, ref QueryIdTokenOptionsInternal options, IntPtr clientData, OnQueryIdTokenCallbackInternal completionDelegate) { }

	internal static extern void EOS_Auth_RemoveNotifyLoginStatusChanged(IntPtr handle, ulong inId) { }

	internal static extern void EOS_Auth_Token_Release(IntPtr authToken) { }

	internal static extern void EOS_Auth_VerifyIdToken(IntPtr handle, ref VerifyIdTokenOptionsInternal options, IntPtr clientData, OnVerifyIdTokenCallbackInternal completionDelegate) { }

	internal static extern void EOS_Auth_VerifyUserAuth(IntPtr handle, ref VerifyUserAuthOptionsInternal options, IntPtr clientData, OnVerifyUserAuthCallbackInternal completionDelegate) { }

	internal static extern Result EOS_ByteArray_ToString(IntPtr byteArray, uint length, IntPtr outBuffer, ref uint inOutBufferLength) { }

	internal static extern ulong EOS_Connect_AddNotifyAuthExpiration(IntPtr handle, ref AddNotifyAuthExpirationOptionsInternal options, IntPtr clientData, OnAuthExpirationCallbackInternal notification) { }

	internal static extern ulong EOS_Connect_AddNotifyLoginStatusChanged(IntPtr handle, ref AddNotifyLoginStatusChangedOptionsInternal options, IntPtr clientData, OnLoginStatusChangedCallbackInternal notification) { }

	internal static extern Result EOS_Connect_CopyIdToken(IntPtr handle, ref CopyIdTokenOptionsInternal options, ref IntPtr outIdToken) { }

	internal static extern Result EOS_Connect_CopyProductUserExternalAccountByAccountId(IntPtr handle, ref CopyProductUserExternalAccountByAccountIdOptionsInternal options, ref IntPtr outExternalAccountInfo) { }

	internal static extern Result EOS_Connect_CopyProductUserExternalAccountByAccountType(IntPtr handle, ref CopyProductUserExternalAccountByAccountTypeOptionsInternal options, ref IntPtr outExternalAccountInfo) { }

	internal static extern Result EOS_Connect_CopyProductUserExternalAccountByIndex(IntPtr handle, ref CopyProductUserExternalAccountByIndexOptionsInternal options, ref IntPtr outExternalAccountInfo) { }

	internal static extern Result EOS_Connect_CopyProductUserInfo(IntPtr handle, ref CopyProductUserInfoOptionsInternal options, ref IntPtr outExternalAccountInfo) { }

	internal static extern void EOS_Connect_CreateDeviceId(IntPtr handle, ref CreateDeviceIdOptionsInternal options, IntPtr clientData, OnCreateDeviceIdCallbackInternal completionDelegate) { }

	internal static extern void EOS_Connect_CreateUser(IntPtr handle, ref CreateUserOptionsInternal options, IntPtr clientData, OnCreateUserCallbackInternal completionDelegate) { }

	internal static extern void EOS_Connect_DeleteDeviceId(IntPtr handle, ref DeleteDeviceIdOptionsInternal options, IntPtr clientData, OnDeleteDeviceIdCallbackInternal completionDelegate) { }

	internal static extern void EOS_Connect_ExternalAccountInfo_Release(IntPtr externalAccountInfo) { }

	internal static extern IntPtr EOS_Connect_GetExternalAccountMapping(IntPtr handle, ref GetExternalAccountMappingsOptionsInternal options) { }

	internal static extern IntPtr EOS_Connect_GetLoggedInUserByIndex(IntPtr handle, int index) { }

	internal static extern int EOS_Connect_GetLoggedInUsersCount(IntPtr handle) { }

	internal static extern LoginStatus EOS_Connect_GetLoginStatus(IntPtr handle, IntPtr localUserId) { }

	internal static extern uint EOS_Connect_GetProductUserExternalAccountCount(IntPtr handle, ref GetProductUserExternalAccountCountOptionsInternal options) { }

	internal static extern Result EOS_Connect_GetProductUserIdMapping(IntPtr handle, ref GetProductUserIdMappingOptionsInternal options, IntPtr outBuffer, ref int inOutBufferLength) { }

	internal static extern void EOS_Connect_IdToken_Release(IntPtr idToken) { }

	internal static extern void EOS_Connect_LinkAccount(IntPtr handle, ref LinkAccountOptionsInternal options, IntPtr clientData, OnLinkAccountCallbackInternal completionDelegate) { }

	internal static extern void EOS_Connect_Login(IntPtr handle, ref LoginOptionsInternal options, IntPtr clientData, OnLoginCallbackInternal completionDelegate) { }

	internal static extern void EOS_Connect_QueryExternalAccountMappings(IntPtr handle, ref QueryExternalAccountMappingsOptionsInternal options, IntPtr clientData, OnQueryExternalAccountMappingsCallbackInternal completionDelegate) { }

	internal static extern void EOS_Connect_QueryProductUserIdMappings(IntPtr handle, ref QueryProductUserIdMappingsOptionsInternal options, IntPtr clientData, OnQueryProductUserIdMappingsCallbackInternal completionDelegate) { }

	internal static extern void EOS_Connect_RemoveNotifyAuthExpiration(IntPtr handle, ulong inId) { }

	internal static extern void EOS_Connect_RemoveNotifyLoginStatusChanged(IntPtr handle, ulong inId) { }

	internal static extern void EOS_Connect_TransferDeviceIdAccount(IntPtr handle, ref TransferDeviceIdAccountOptionsInternal options, IntPtr clientData, OnTransferDeviceIdAccountCallbackInternal completionDelegate) { }

	internal static extern void EOS_Connect_UnlinkAccount(IntPtr handle, ref UnlinkAccountOptionsInternal options, IntPtr clientData, OnUnlinkAccountCallbackInternal completionDelegate) { }

	internal static extern void EOS_Connect_VerifyIdToken(IntPtr handle, ref VerifyIdTokenOptionsInternal options, IntPtr clientData, OnVerifyIdTokenCallbackInternal completionDelegate) { }

	internal static extern Result EOS_ContinuanceToken_ToString(IntPtr continuanceToken, IntPtr outBuffer, ref int inOutBufferLength) { }

	internal static extern ulong EOS_CustomInvites_AddNotifyCustomInviteAccepted(IntPtr handle, ref AddNotifyCustomInviteAcceptedOptionsInternal options, IntPtr clientData, OnCustomInviteAcceptedCallbackInternal notificationFn) { }

	internal static extern ulong EOS_CustomInvites_AddNotifyCustomInviteReceived(IntPtr handle, ref AddNotifyCustomInviteReceivedOptionsInternal options, IntPtr clientData, OnCustomInviteReceivedCallbackInternal notificationFn) { }

	internal static extern ulong EOS_CustomInvites_AddNotifyCustomInviteRejected(IntPtr handle, ref AddNotifyCustomInviteRejectedOptionsInternal options, IntPtr clientData, OnCustomInviteRejectedCallbackInternal notificationFn) { }

	internal static extern Result EOS_CustomInvites_FinalizeInvite(IntPtr handle, ref FinalizeInviteOptionsInternal options) { }

	internal static extern void EOS_CustomInvites_RemoveNotifyCustomInviteAccepted(IntPtr handle, ulong inId) { }

	internal static extern void EOS_CustomInvites_RemoveNotifyCustomInviteReceived(IntPtr handle, ulong inId) { }

	internal static extern void EOS_CustomInvites_RemoveNotifyCustomInviteRejected(IntPtr handle, ulong inId) { }

	internal static extern void EOS_CustomInvites_SendCustomInvite(IntPtr handle, ref SendCustomInviteOptionsInternal options, IntPtr clientData, OnSendCustomInviteCallbackInternal completionDelegate) { }

	internal static extern Result EOS_CustomInvites_SetCustomInvite(IntPtr handle, ref SetCustomInviteOptionsInternal options) { }

	internal static extern int EOS_EResult_IsOperationComplete(Result result) { }

	internal static extern IntPtr EOS_EResult_ToString(Result result) { }

	internal static extern void EOS_Ecom_CatalogItem_Release(IntPtr catalogItem) { }

	internal static extern void EOS_Ecom_CatalogOffer_Release(IntPtr catalogOffer) { }

	internal static extern void EOS_Ecom_CatalogRelease_Release(IntPtr catalogRelease) { }

	internal static extern void EOS_Ecom_Checkout(IntPtr handle, ref CheckoutOptionsInternal options, IntPtr clientData, OnCheckoutCallbackInternal completionDelegate) { }

	internal static extern Result EOS_Ecom_CopyEntitlementById(IntPtr handle, ref CopyEntitlementByIdOptionsInternal options, ref IntPtr outEntitlement) { }

	internal static extern Result EOS_Ecom_CopyEntitlementByIndex(IntPtr handle, ref CopyEntitlementByIndexOptionsInternal options, ref IntPtr outEntitlement) { }

	internal static extern Result EOS_Ecom_CopyEntitlementByNameAndIndex(IntPtr handle, ref CopyEntitlementByNameAndIndexOptionsInternal options, ref IntPtr outEntitlement) { }

	internal static extern Result EOS_Ecom_CopyItemById(IntPtr handle, ref CopyItemByIdOptionsInternal options, ref IntPtr outItem) { }

	internal static extern Result EOS_Ecom_CopyItemImageInfoByIndex(IntPtr handle, ref CopyItemImageInfoByIndexOptionsInternal options, ref IntPtr outImageInfo) { }

	internal static extern Result EOS_Ecom_CopyItemReleaseByIndex(IntPtr handle, ref CopyItemReleaseByIndexOptionsInternal options, ref IntPtr outRelease) { }

	internal static extern Result EOS_Ecom_CopyLastRedeemedEntitlementByIndex(IntPtr handle, ref CopyLastRedeemedEntitlementByIndexOptionsInternal options, IntPtr outRedeemedEntitlementId, ref int inOutRedeemedEntitlementIdLength) { }

	internal static extern Result EOS_Ecom_CopyOfferById(IntPtr handle, ref CopyOfferByIdOptionsInternal options, ref IntPtr outOffer) { }

	internal static extern Result EOS_Ecom_CopyOfferByIndex(IntPtr handle, ref CopyOfferByIndexOptionsInternal options, ref IntPtr outOffer) { }

	internal static extern Result EOS_Ecom_CopyOfferImageInfoByIndex(IntPtr handle, ref CopyOfferImageInfoByIndexOptionsInternal options, ref IntPtr outImageInfo) { }

	internal static extern Result EOS_Ecom_CopyOfferItemByIndex(IntPtr handle, ref CopyOfferItemByIndexOptionsInternal options, ref IntPtr outItem) { }

	internal static extern Result EOS_Ecom_CopyTransactionById(IntPtr handle, ref CopyTransactionByIdOptionsInternal options, ref IntPtr outTransaction) { }

	internal static extern Result EOS_Ecom_CopyTransactionByIndex(IntPtr handle, ref CopyTransactionByIndexOptionsInternal options, ref IntPtr outTransaction) { }

	internal static extern void EOS_Ecom_Entitlement_Release(IntPtr entitlement) { }

	internal static extern uint EOS_Ecom_GetEntitlementsByNameCount(IntPtr handle, ref GetEntitlementsByNameCountOptionsInternal options) { }

	internal static extern uint EOS_Ecom_GetEntitlementsCount(IntPtr handle, ref GetEntitlementsCountOptionsInternal options) { }

	internal static extern uint EOS_Ecom_GetItemImageInfoCount(IntPtr handle, ref GetItemImageInfoCountOptionsInternal options) { }

	internal static extern uint EOS_Ecom_GetItemReleaseCount(IntPtr handle, ref GetItemReleaseCountOptionsInternal options) { }

	internal static extern uint EOS_Ecom_GetLastRedeemedEntitlementsCount(IntPtr handle, ref GetLastRedeemedEntitlementsCountOptionsInternal options) { }

	internal static extern uint EOS_Ecom_GetOfferCount(IntPtr handle, ref GetOfferCountOptionsInternal options) { }

	internal static extern uint EOS_Ecom_GetOfferImageInfoCount(IntPtr handle, ref GetOfferImageInfoCountOptionsInternal options) { }

	internal static extern uint EOS_Ecom_GetOfferItemCount(IntPtr handle, ref GetOfferItemCountOptionsInternal options) { }

	internal static extern uint EOS_Ecom_GetTransactionCount(IntPtr handle, ref GetTransactionCountOptionsInternal options) { }

	internal static extern void EOS_Ecom_KeyImageInfo_Release(IntPtr keyImageInfo) { }

	internal static extern void EOS_Ecom_QueryEntitlements(IntPtr handle, ref QueryEntitlementsOptionsInternal options, IntPtr clientData, OnQueryEntitlementsCallbackInternal completionDelegate) { }

	internal static extern void EOS_Ecom_QueryOffers(IntPtr handle, ref QueryOffersOptionsInternal options, IntPtr clientData, OnQueryOffersCallbackInternal completionDelegate) { }

	internal static extern void EOS_Ecom_QueryOwnership(IntPtr handle, ref QueryOwnershipOptionsInternal options, IntPtr clientData, OnQueryOwnershipCallbackInternal completionDelegate) { }

	internal static extern void EOS_Ecom_QueryOwnershipToken(IntPtr handle, ref QueryOwnershipTokenOptionsInternal options, IntPtr clientData, OnQueryOwnershipTokenCallbackInternal completionDelegate) { }

	internal static extern void EOS_Ecom_RedeemEntitlements(IntPtr handle, ref RedeemEntitlementsOptionsInternal options, IntPtr clientData, OnRedeemEntitlementsCallbackInternal completionDelegate) { }

	internal static extern Result EOS_Ecom_Transaction_CopyEntitlementByIndex(IntPtr handle, ref TransactionCopyEntitlementByIndexOptionsInternal options, ref IntPtr outEntitlement) { }

	internal static extern uint EOS_Ecom_Transaction_GetEntitlementsCount(IntPtr handle, ref TransactionGetEntitlementsCountOptionsInternal options) { }

	internal static extern Result EOS_Ecom_Transaction_GetTransactionId(IntPtr handle, IntPtr outBuffer, ref int inOutBufferLength) { }

	internal static extern void EOS_Ecom_Transaction_Release(IntPtr transaction) { }

	internal static extern IntPtr EOS_EpicAccountId_FromString(IntPtr accountIdString) { }

	internal static extern int EOS_EpicAccountId_IsValid(IntPtr accountId) { }

	internal static extern Result EOS_EpicAccountId_ToString(IntPtr accountId, IntPtr outBuffer, ref int inOutBufferLength) { }

	internal static extern void EOS_Friends_AcceptInvite(IntPtr handle, ref AcceptInviteOptionsInternal options, IntPtr clientData, OnAcceptInviteCallbackInternal completionDelegate) { }

	internal static extern ulong EOS_Friends_AddNotifyFriendsUpdate(IntPtr handle, ref AddNotifyFriendsUpdateOptionsInternal options, IntPtr clientData, OnFriendsUpdateCallbackInternal friendsUpdateHandler) { }

	internal static extern IntPtr EOS_Friends_GetFriendAtIndex(IntPtr handle, ref GetFriendAtIndexOptionsInternal options) { }

	internal static extern int EOS_Friends_GetFriendsCount(IntPtr handle, ref GetFriendsCountOptionsInternal options) { }

	internal static extern FriendsStatus EOS_Friends_GetStatus(IntPtr handle, ref GetStatusOptionsInternal options) { }

	internal static extern void EOS_Friends_QueryFriends(IntPtr handle, ref QueryFriendsOptionsInternal options, IntPtr clientData, OnQueryFriendsCallbackInternal completionDelegate) { }

	internal static extern void EOS_Friends_RejectInvite(IntPtr handle, ref RejectInviteOptionsInternal options, IntPtr clientData, OnRejectInviteCallbackInternal completionDelegate) { }

	internal static extern void EOS_Friends_RemoveNotifyFriendsUpdate(IntPtr handle, ulong notificationId) { }

	internal static extern void EOS_Friends_SendInvite(IntPtr handle, ref SendInviteOptionsInternal options, IntPtr clientData, OnSendInviteCallbackInternal completionDelegate) { }

	internal static extern IntPtr EOS_GetVersion() { }

	internal static extern Result EOS_Initialize(ref InitializeOptionsInternal options) { }

	internal static extern Result EOS_IntegratedPlatformOptionsContainer_Add(IntPtr handle, ref IntegratedPlatformOptionsContainerAddOptionsInternal inOptions) { }

	internal static extern void EOS_IntegratedPlatformOptionsContainer_Release(IntPtr integratedPlatformOptionsContainerHandle) { }

	internal static extern Result EOS_IntegratedPlatform_CreateIntegratedPlatformOptionsContainer(ref CreateIntegratedPlatformOptionsContainerOptionsInternal options, ref IntPtr outIntegratedPlatformOptionsContainerHandle) { }

	internal static extern ulong EOS_KWS_AddNotifyPermissionsUpdateReceived(IntPtr handle, ref AddNotifyPermissionsUpdateReceivedOptionsInternal options, IntPtr clientData, OnPermissionsUpdateReceivedCallbackInternal notificationFn) { }

	internal static extern Result EOS_KWS_CopyPermissionByIndex(IntPtr handle, ref CopyPermissionByIndexOptionsInternal options, ref IntPtr outPermission) { }

	internal static extern void EOS_KWS_CreateUser(IntPtr handle, ref CreateUserOptionsInternal options, IntPtr clientData, OnCreateUserCallbackInternal completionDelegate) { }

	internal static extern Result EOS_KWS_GetPermissionByKey(IntPtr handle, ref GetPermissionByKeyOptionsInternal options, ref KWSPermissionStatus outPermission) { }

	internal static extern int EOS_KWS_GetPermissionsCount(IntPtr handle, ref GetPermissionsCountOptionsInternal options) { }

	internal static extern void EOS_KWS_PermissionStatus_Release(IntPtr permissionStatus) { }

	internal static extern void EOS_KWS_QueryAgeGate(IntPtr handle, ref QueryAgeGateOptionsInternal options, IntPtr clientData, OnQueryAgeGateCallbackInternal completionDelegate) { }

	internal static extern void EOS_KWS_QueryPermissions(IntPtr handle, ref QueryPermissionsOptionsInternal options, IntPtr clientData, OnQueryPermissionsCallbackInternal completionDelegate) { }

	internal static extern void EOS_KWS_RemoveNotifyPermissionsUpdateReceived(IntPtr handle, ulong inId) { }

	internal static extern void EOS_KWS_RequestPermissions(IntPtr handle, ref RequestPermissionsOptionsInternal options, IntPtr clientData, OnRequestPermissionsCallbackInternal completionDelegate) { }

	internal static extern void EOS_KWS_UpdateParentEmail(IntPtr handle, ref UpdateParentEmailOptionsInternal options, IntPtr clientData, OnUpdateParentEmailCallbackInternal completionDelegate) { }

	internal static extern Result EOS_Leaderboards_CopyLeaderboardDefinitionByIndex(IntPtr handle, ref CopyLeaderboardDefinitionByIndexOptionsInternal options, ref IntPtr outLeaderboardDefinition) { }

	internal static extern Result EOS_Leaderboards_CopyLeaderboardDefinitionByLeaderboardId(IntPtr handle, ref CopyLeaderboardDefinitionByLeaderboardIdOptionsInternal options, ref IntPtr outLeaderboardDefinition) { }

	internal static extern Result EOS_Leaderboards_CopyLeaderboardRecordByIndex(IntPtr handle, ref CopyLeaderboardRecordByIndexOptionsInternal options, ref IntPtr outLeaderboardRecord) { }

	internal static extern Result EOS_Leaderboards_CopyLeaderboardRecordByUserId(IntPtr handle, ref CopyLeaderboardRecordByUserIdOptionsInternal options, ref IntPtr outLeaderboardRecord) { }

	internal static extern Result EOS_Leaderboards_CopyLeaderboardUserScoreByIndex(IntPtr handle, ref CopyLeaderboardUserScoreByIndexOptionsInternal options, ref IntPtr outLeaderboardUserScore) { }

	internal static extern Result EOS_Leaderboards_CopyLeaderboardUserScoreByUserId(IntPtr handle, ref CopyLeaderboardUserScoreByUserIdOptionsInternal options, ref IntPtr outLeaderboardUserScore) { }

	internal static extern void EOS_Leaderboards_Definition_Release(IntPtr leaderboardDefinition) { }

	internal static extern uint EOS_Leaderboards_GetLeaderboardDefinitionCount(IntPtr handle, ref GetLeaderboardDefinitionCountOptionsInternal options) { }

	internal static extern uint EOS_Leaderboards_GetLeaderboardRecordCount(IntPtr handle, ref GetLeaderboardRecordCountOptionsInternal options) { }

	internal static extern uint EOS_Leaderboards_GetLeaderboardUserScoreCount(IntPtr handle, ref GetLeaderboardUserScoreCountOptionsInternal options) { }

	internal static extern void EOS_Leaderboards_LeaderboardDefinition_Release(IntPtr leaderboardDefinition) { }

	internal static extern void EOS_Leaderboards_LeaderboardRecord_Release(IntPtr leaderboardRecord) { }

	internal static extern void EOS_Leaderboards_LeaderboardUserScore_Release(IntPtr leaderboardUserScore) { }

	internal static extern void EOS_Leaderboards_QueryLeaderboardDefinitions(IntPtr handle, ref QueryLeaderboardDefinitionsOptionsInternal options, IntPtr clientData, OnQueryLeaderboardDefinitionsCompleteCallbackInternal completionDelegate) { }

	internal static extern void EOS_Leaderboards_QueryLeaderboardRanks(IntPtr handle, ref QueryLeaderboardRanksOptionsInternal options, IntPtr clientData, OnQueryLeaderboardRanksCompleteCallbackInternal completionDelegate) { }

	internal static extern void EOS_Leaderboards_QueryLeaderboardUserScores(IntPtr handle, ref QueryLeaderboardUserScoresOptionsInternal options, IntPtr clientData, OnQueryLeaderboardUserScoresCompleteCallbackInternal completionDelegate) { }

	internal static extern Result EOS_LobbyDetails_CopyAttributeByIndex(IntPtr handle, ref LobbyDetailsCopyAttributeByIndexOptionsInternal options, ref IntPtr outAttribute) { }

	internal static extern Result EOS_LobbyDetails_CopyAttributeByKey(IntPtr handle, ref LobbyDetailsCopyAttributeByKeyOptionsInternal options, ref IntPtr outAttribute) { }

	internal static extern Result EOS_LobbyDetails_CopyInfo(IntPtr handle, ref LobbyDetailsCopyInfoOptionsInternal options, ref IntPtr outLobbyDetailsInfo) { }

	internal static extern Result EOS_LobbyDetails_CopyMemberAttributeByIndex(IntPtr handle, ref LobbyDetailsCopyMemberAttributeByIndexOptionsInternal options, ref IntPtr outAttribute) { }

	internal static extern Result EOS_LobbyDetails_CopyMemberAttributeByKey(IntPtr handle, ref LobbyDetailsCopyMemberAttributeByKeyOptionsInternal options, ref IntPtr outAttribute) { }

	internal static extern uint EOS_LobbyDetails_GetAttributeCount(IntPtr handle, ref LobbyDetailsGetAttributeCountOptionsInternal options) { }

	internal static extern IntPtr EOS_LobbyDetails_GetLobbyOwner(IntPtr handle, ref LobbyDetailsGetLobbyOwnerOptionsInternal options) { }

	internal static extern uint EOS_LobbyDetails_GetMemberAttributeCount(IntPtr handle, ref LobbyDetailsGetMemberAttributeCountOptionsInternal options) { }

	internal static extern IntPtr EOS_LobbyDetails_GetMemberByIndex(IntPtr handle, ref LobbyDetailsGetMemberByIndexOptionsInternal options) { }

	internal static extern uint EOS_LobbyDetails_GetMemberCount(IntPtr handle, ref LobbyDetailsGetMemberCountOptionsInternal options) { }

	internal static extern void EOS_LobbyDetails_Info_Release(IntPtr lobbyDetailsInfo) { }

	internal static extern void EOS_LobbyDetails_Release(IntPtr lobbyHandle) { }

	internal static extern Result EOS_LobbyModification_AddAttribute(IntPtr handle, ref LobbyModificationAddAttributeOptionsInternal options) { }

	internal static extern Result EOS_LobbyModification_AddMemberAttribute(IntPtr handle, ref LobbyModificationAddMemberAttributeOptionsInternal options) { }

	internal static extern void EOS_LobbyModification_Release(IntPtr lobbyModificationHandle) { }

	internal static extern Result EOS_LobbyModification_RemoveAttribute(IntPtr handle, ref LobbyModificationRemoveAttributeOptionsInternal options) { }

	internal static extern Result EOS_LobbyModification_RemoveMemberAttribute(IntPtr handle, ref LobbyModificationRemoveMemberAttributeOptionsInternal options) { }

	internal static extern Result EOS_LobbyModification_SetBucketId(IntPtr handle, ref LobbyModificationSetBucketIdOptionsInternal options) { }

	internal static extern Result EOS_LobbyModification_SetInvitesAllowed(IntPtr handle, ref LobbyModificationSetInvitesAllowedOptionsInternal options) { }

	internal static extern Result EOS_LobbyModification_SetMaxMembers(IntPtr handle, ref LobbyModificationSetMaxMembersOptionsInternal options) { }

	internal static extern Result EOS_LobbyModification_SetPermissionLevel(IntPtr handle, ref LobbyModificationSetPermissionLevelOptionsInternal options) { }

	internal static extern Result EOS_LobbySearch_CopySearchResultByIndex(IntPtr handle, ref LobbySearchCopySearchResultByIndexOptionsInternal options, ref IntPtr outLobbyDetailsHandle) { }

	internal static extern void EOS_LobbySearch_Find(IntPtr handle, ref LobbySearchFindOptionsInternal options, IntPtr clientData, LobbySearchOnFindCallbackInternal completionDelegate) { }

	internal static extern uint EOS_LobbySearch_GetSearchResultCount(IntPtr handle, ref LobbySearchGetSearchResultCountOptionsInternal options) { }

	internal static extern void EOS_LobbySearch_Release(IntPtr lobbySearchHandle) { }

	internal static extern Result EOS_LobbySearch_RemoveParameter(IntPtr handle, ref LobbySearchRemoveParameterOptionsInternal options) { }

	internal static extern Result EOS_LobbySearch_SetLobbyId(IntPtr handle, ref LobbySearchSetLobbyIdOptionsInternal options) { }

	internal static extern Result EOS_LobbySearch_SetMaxResults(IntPtr handle, ref LobbySearchSetMaxResultsOptionsInternal options) { }

	internal static extern Result EOS_LobbySearch_SetParameter(IntPtr handle, ref LobbySearchSetParameterOptionsInternal options) { }

	internal static extern Result EOS_LobbySearch_SetTargetUserId(IntPtr handle, ref LobbySearchSetTargetUserIdOptionsInternal options) { }

	internal static extern ulong EOS_Lobby_AddNotifyJoinLobbyAccepted(IntPtr handle, ref AddNotifyJoinLobbyAcceptedOptionsInternal options, IntPtr clientData, OnJoinLobbyAcceptedCallbackInternal notificationFn) { }

	internal static extern ulong EOS_Lobby_AddNotifyLobbyInviteAccepted(IntPtr handle, ref AddNotifyLobbyInviteAcceptedOptionsInternal options, IntPtr clientData, OnLobbyInviteAcceptedCallbackInternal notificationFn) { }

	internal static extern ulong EOS_Lobby_AddNotifyLobbyInviteReceived(IntPtr handle, ref AddNotifyLobbyInviteReceivedOptionsInternal options, IntPtr clientData, OnLobbyInviteReceivedCallbackInternal notificationFn) { }

	internal static extern ulong EOS_Lobby_AddNotifyLobbyInviteRejected(IntPtr handle, ref AddNotifyLobbyInviteRejectedOptionsInternal options, IntPtr clientData, OnLobbyInviteRejectedCallbackInternal notificationFn) { }

	internal static extern ulong EOS_Lobby_AddNotifyLobbyMemberStatusReceived(IntPtr handle, ref AddNotifyLobbyMemberStatusReceivedOptionsInternal options, IntPtr clientData, OnLobbyMemberStatusReceivedCallbackInternal notificationFn) { }

	internal static extern ulong EOS_Lobby_AddNotifyLobbyMemberUpdateReceived(IntPtr handle, ref AddNotifyLobbyMemberUpdateReceivedOptionsInternal options, IntPtr clientData, OnLobbyMemberUpdateReceivedCallbackInternal notificationFn) { }

	internal static extern ulong EOS_Lobby_AddNotifyLobbyUpdateReceived(IntPtr handle, ref AddNotifyLobbyUpdateReceivedOptionsInternal options, IntPtr clientData, OnLobbyUpdateReceivedCallbackInternal notificationFn) { }

	internal static extern ulong EOS_Lobby_AddNotifyRTCRoomConnectionChanged(IntPtr handle, ref AddNotifyRTCRoomConnectionChangedOptionsInternal options, IntPtr clientData, OnRTCRoomConnectionChangedCallbackInternal notificationFn) { }

	internal static extern ulong EOS_Lobby_AddNotifySendLobbyNativeInviteRequested(IntPtr handle, ref AddNotifySendLobbyNativeInviteRequestedOptionsInternal options, IntPtr clientData, OnSendLobbyNativeInviteRequestedCallbackInternal notificationFn) { }

	internal static extern void EOS_Lobby_Attribute_Release(IntPtr lobbyAttribute) { }

	internal static extern Result EOS_Lobby_CopyLobbyDetailsHandle(IntPtr handle, ref CopyLobbyDetailsHandleOptionsInternal options, ref IntPtr outLobbyDetailsHandle) { }

	internal static extern Result EOS_Lobby_CopyLobbyDetailsHandleByInviteId(IntPtr handle, ref CopyLobbyDetailsHandleByInviteIdOptionsInternal options, ref IntPtr outLobbyDetailsHandle) { }

	internal static extern Result EOS_Lobby_CopyLobbyDetailsHandleByUiEventId(IntPtr handle, ref CopyLobbyDetailsHandleByUiEventIdOptionsInternal options, ref IntPtr outLobbyDetailsHandle) { }

	internal static extern void EOS_Lobby_CreateLobby(IntPtr handle, ref CreateLobbyOptionsInternal options, IntPtr clientData, OnCreateLobbyCallbackInternal completionDelegate) { }

	internal static extern Result EOS_Lobby_CreateLobbySearch(IntPtr handle, ref CreateLobbySearchOptionsInternal options, ref IntPtr outLobbySearchHandle) { }

	internal static extern void EOS_Lobby_DestroyLobby(IntPtr handle, ref DestroyLobbyOptionsInternal options, IntPtr clientData, OnDestroyLobbyCallbackInternal completionDelegate) { }

	internal static extern uint EOS_Lobby_GetInviteCount(IntPtr handle, ref GetInviteCountOptionsInternal options) { }

	internal static extern Result EOS_Lobby_GetInviteIdByIndex(IntPtr handle, ref GetInviteIdByIndexOptionsInternal options, IntPtr outBuffer, ref int inOutBufferLength) { }

	internal static extern Result EOS_Lobby_GetRTCRoomName(IntPtr handle, ref GetRTCRoomNameOptionsInternal options, IntPtr outBuffer, ref uint inOutBufferLength) { }

	internal static extern void EOS_Lobby_HardMuteMember(IntPtr handle, ref HardMuteMemberOptionsInternal options, IntPtr clientData, OnHardMuteMemberCallbackInternal completionDelegate) { }

	internal static extern Result EOS_Lobby_IsRTCRoomConnected(IntPtr handle, ref IsRTCRoomConnectedOptionsInternal options, ref int bOutIsConnected) { }

	internal static extern void EOS_Lobby_JoinLobby(IntPtr handle, ref JoinLobbyOptionsInternal options, IntPtr clientData, OnJoinLobbyCallbackInternal completionDelegate) { }

	internal static extern void EOS_Lobby_JoinLobbyById(IntPtr handle, ref JoinLobbyByIdOptionsInternal options, IntPtr clientData, OnJoinLobbyByIdCallbackInternal completionDelegate) { }

	internal static extern void EOS_Lobby_KickMember(IntPtr handle, ref KickMemberOptionsInternal options, IntPtr clientData, OnKickMemberCallbackInternal completionDelegate) { }

	internal static extern void EOS_Lobby_LeaveLobby(IntPtr handle, ref LeaveLobbyOptionsInternal options, IntPtr clientData, OnLeaveLobbyCallbackInternal completionDelegate) { }

	internal static extern void EOS_Lobby_PromoteMember(IntPtr handle, ref PromoteMemberOptionsInternal options, IntPtr clientData, OnPromoteMemberCallbackInternal completionDelegate) { }

	internal static extern void EOS_Lobby_QueryInvites(IntPtr handle, ref QueryInvitesOptionsInternal options, IntPtr clientData, OnQueryInvitesCallbackInternal completionDelegate) { }

	internal static extern void EOS_Lobby_RejectInvite(IntPtr handle, ref RejectInviteOptionsInternal options, IntPtr clientData, OnRejectInviteCallbackInternal completionDelegate) { }

	internal static extern void EOS_Lobby_RemoveNotifyJoinLobbyAccepted(IntPtr handle, ulong inId) { }

	internal static extern void EOS_Lobby_RemoveNotifyLobbyInviteAccepted(IntPtr handle, ulong inId) { }

	internal static extern void EOS_Lobby_RemoveNotifyLobbyInviteReceived(IntPtr handle, ulong inId) { }

	internal static extern void EOS_Lobby_RemoveNotifyLobbyInviteRejected(IntPtr handle, ulong inId) { }

	internal static extern void EOS_Lobby_RemoveNotifyLobbyMemberStatusReceived(IntPtr handle, ulong inId) { }

	internal static extern void EOS_Lobby_RemoveNotifyLobbyMemberUpdateReceived(IntPtr handle, ulong inId) { }

	internal static extern void EOS_Lobby_RemoveNotifyLobbyUpdateReceived(IntPtr handle, ulong inId) { }

	internal static extern void EOS_Lobby_RemoveNotifyRTCRoomConnectionChanged(IntPtr handle, ulong inId) { }

	internal static extern void EOS_Lobby_RemoveNotifySendLobbyNativeInviteRequested(IntPtr handle, ulong inId) { }

	internal static extern void EOS_Lobby_SendInvite(IntPtr handle, ref SendInviteOptionsInternal options, IntPtr clientData, OnSendInviteCallbackInternal completionDelegate) { }

	internal static extern void EOS_Lobby_UpdateLobby(IntPtr handle, ref UpdateLobbyOptionsInternal options, IntPtr clientData, OnUpdateLobbyCallbackInternal completionDelegate) { }

	internal static extern Result EOS_Lobby_UpdateLobbyModification(IntPtr handle, ref UpdateLobbyModificationOptionsInternal options, ref IntPtr outLobbyModificationHandle) { }

	internal static extern Result EOS_Logging_SetCallback(LogMessageFuncInternal callback) { }

	internal static extern Result EOS_Logging_SetLogLevel(LogCategory logCategory, LogLevel logLevel) { }

	internal static extern Result EOS_Metrics_BeginPlayerSession(IntPtr handle, ref BeginPlayerSessionOptionsInternal options) { }

	internal static extern Result EOS_Metrics_EndPlayerSession(IntPtr handle, ref EndPlayerSessionOptionsInternal options) { }

	internal static extern Result EOS_Mods_CopyModInfo(IntPtr handle, ref CopyModInfoOptionsInternal options, ref IntPtr outEnumeratedMods) { }

	internal static extern void EOS_Mods_EnumerateMods(IntPtr handle, ref EnumerateModsOptionsInternal options, IntPtr clientData, OnEnumerateModsCallbackInternal completionDelegate) { }

	internal static extern void EOS_Mods_InstallMod(IntPtr handle, ref InstallModOptionsInternal options, IntPtr clientData, OnInstallModCallbackInternal completionDelegate) { }

	internal static extern void EOS_Mods_ModInfo_Release(IntPtr modInfo) { }

	internal static extern void EOS_Mods_UninstallMod(IntPtr handle, ref UninstallModOptionsInternal options, IntPtr clientData, OnUninstallModCallbackInternal completionDelegate) { }

	internal static extern void EOS_Mods_UpdateMod(IntPtr handle, ref UpdateModOptionsInternal options, IntPtr clientData, OnUpdateModCallbackInternal completionDelegate) { }

	internal static extern Result EOS_P2P_AcceptConnection(IntPtr handle, ref AcceptConnectionOptionsInternal options) { }

	internal static extern ulong EOS_P2P_AddNotifyIncomingPacketQueueFull(IntPtr handle, ref AddNotifyIncomingPacketQueueFullOptionsInternal options, IntPtr clientData, OnIncomingPacketQueueFullCallbackInternal incomingPacketQueueFullHandler) { }

	internal static extern ulong EOS_P2P_AddNotifyPeerConnectionClosed(IntPtr handle, ref AddNotifyPeerConnectionClosedOptionsInternal options, IntPtr clientData, OnRemoteConnectionClosedCallbackInternal connectionClosedHandler) { }

	internal static extern ulong EOS_P2P_AddNotifyPeerConnectionEstablished(IntPtr handle, ref AddNotifyPeerConnectionEstablishedOptionsInternal options, IntPtr clientData, OnPeerConnectionEstablishedCallbackInternal connectionEstablishedHandler) { }

	internal static extern ulong EOS_P2P_AddNotifyPeerConnectionInterrupted(IntPtr handle, ref AddNotifyPeerConnectionInterruptedOptionsInternal options, IntPtr clientData, OnPeerConnectionInterruptedCallbackInternal connectionInterruptedHandler) { }

	internal static extern ulong EOS_P2P_AddNotifyPeerConnectionRequest(IntPtr handle, ref AddNotifyPeerConnectionRequestOptionsInternal options, IntPtr clientData, OnIncomingConnectionRequestCallbackInternal connectionRequestHandler) { }

	internal static extern Result EOS_P2P_ClearPacketQueue(IntPtr handle, ref ClearPacketQueueOptionsInternal options) { }

	internal static extern Result EOS_P2P_CloseConnection(IntPtr handle, ref CloseConnectionOptionsInternal options) { }

	internal static extern Result EOS_P2P_CloseConnections(IntPtr handle, ref CloseConnectionsOptionsInternal options) { }

	internal static extern Result EOS_P2P_GetNATType(IntPtr handle, ref GetNATTypeOptionsInternal options, ref NATType outNATType) { }

	internal static extern Result EOS_P2P_GetNextReceivedPacketSize(IntPtr handle, ref GetNextReceivedPacketSizeOptionsInternal options, ref uint outPacketSizeBytes) { }

	internal static extern Result EOS_P2P_GetPacketQueueInfo(IntPtr handle, ref GetPacketQueueInfoOptionsInternal options, ref PacketQueueInfoInternal outPacketQueueInfo) { }

	internal static extern Result EOS_P2P_GetPortRange(IntPtr handle, ref GetPortRangeOptionsInternal options, ref ushort outPort, ref ushort outNumAdditionalPortsToTry) { }

	internal static extern Result EOS_P2P_GetRelayControl(IntPtr handle, ref GetRelayControlOptionsInternal options, ref RelayControl outRelayControl) { }

	internal static extern void EOS_P2P_QueryNATType(IntPtr handle, ref QueryNATTypeOptionsInternal options, IntPtr clientData, OnQueryNATTypeCompleteCallbackInternal completionDelegate) { }

	internal static extern Result EOS_P2P_ReceivePacket(IntPtr handle, ref ReceivePacketOptionsInternal options, ref IntPtr outPeerId, ref SocketIdInternal outSocketId, ref byte outChannel, IntPtr outData, ref uint outBytesWritten) { }

	internal static extern void EOS_P2P_RemoveNotifyIncomingPacketQueueFull(IntPtr handle, ulong notificationId) { }

	internal static extern void EOS_P2P_RemoveNotifyPeerConnectionClosed(IntPtr handle, ulong notificationId) { }

	internal static extern void EOS_P2P_RemoveNotifyPeerConnectionEstablished(IntPtr handle, ulong notificationId) { }

	internal static extern void EOS_P2P_RemoveNotifyPeerConnectionInterrupted(IntPtr handle, ulong notificationId) { }

	internal static extern void EOS_P2P_RemoveNotifyPeerConnectionRequest(IntPtr handle, ulong notificationId) { }

	internal static extern Result EOS_P2P_SendPacket(IntPtr handle, ref SendPacketOptionsInternal options) { }

	internal static extern Result EOS_P2P_SetPacketQueueSize(IntPtr handle, ref SetPacketQueueSizeOptionsInternal options) { }

	internal static extern Result EOS_P2P_SetPortRange(IntPtr handle, ref SetPortRangeOptionsInternal options) { }

	internal static extern Result EOS_P2P_SetRelayControl(IntPtr handle, ref SetRelayControlOptionsInternal options) { }

	internal static extern Result EOS_Platform_CheckForLauncherAndRestart(IntPtr handle) { }

	internal static extern IntPtr EOS_Platform_Create(ref OptionsInternal options) { }

	internal static extern IntPtr EOS_Platform_GetAchievementsInterface(IntPtr handle) { }

	internal static extern Result EOS_Platform_GetActiveCountryCode(IntPtr handle, IntPtr localUserId, IntPtr outBuffer, ref int inOutBufferLength) { }

	internal static extern Result EOS_Platform_GetActiveLocaleCode(IntPtr handle, IntPtr localUserId, IntPtr outBuffer, ref int inOutBufferLength) { }

	internal static extern IntPtr EOS_Platform_GetAntiCheatClientInterface(IntPtr handle) { }

	internal static extern IntPtr EOS_Platform_GetAntiCheatServerInterface(IntPtr handle) { }

	internal static extern ApplicationStatus EOS_Platform_GetApplicationStatus(IntPtr handle) { }

	internal static extern IntPtr EOS_Platform_GetAuthInterface(IntPtr handle) { }

	internal static extern IntPtr EOS_Platform_GetConnectInterface(IntPtr handle) { }

	internal static extern IntPtr EOS_Platform_GetCustomInvitesInterface(IntPtr handle) { }

	internal static extern Result EOS_Platform_GetDesktopCrossplayStatus(IntPtr handle, ref GetDesktopCrossplayStatusOptionsInternal options, ref GetDesktopCrossplayStatusInfoInternal outDesktopCrossplayStatusInfo) { }

	internal static extern IntPtr EOS_Platform_GetEcomInterface(IntPtr handle) { }

	internal static extern IntPtr EOS_Platform_GetFriendsInterface(IntPtr handle) { }

	internal static extern IntPtr EOS_Platform_GetKWSInterface(IntPtr handle) { }

	internal static extern IntPtr EOS_Platform_GetLeaderboardsInterface(IntPtr handle) { }

	internal static extern IntPtr EOS_Platform_GetLobbyInterface(IntPtr handle) { }

	internal static extern IntPtr EOS_Platform_GetMetricsInterface(IntPtr handle) { }

	internal static extern IntPtr EOS_Platform_GetModsInterface(IntPtr handle) { }

	internal static extern NetworkStatus EOS_Platform_GetNetworkStatus(IntPtr handle) { }

	internal static extern Result EOS_Platform_GetOverrideCountryCode(IntPtr handle, IntPtr outBuffer, ref int inOutBufferLength) { }

	internal static extern Result EOS_Platform_GetOverrideLocaleCode(IntPtr handle, IntPtr outBuffer, ref int inOutBufferLength) { }

	internal static extern IntPtr EOS_Platform_GetP2PInterface(IntPtr handle) { }

	internal static extern IntPtr EOS_Platform_GetPlayerDataStorageInterface(IntPtr handle) { }

	internal static extern IntPtr EOS_Platform_GetPresenceInterface(IntPtr handle) { }

	internal static extern IntPtr EOS_Platform_GetProgressionSnapshotInterface(IntPtr handle) { }

	internal static extern IntPtr EOS_Platform_GetRTCAdminInterface(IntPtr handle) { }

	internal static extern IntPtr EOS_Platform_GetRTCInterface(IntPtr handle) { }

	internal static extern IntPtr EOS_Platform_GetReportsInterface(IntPtr handle) { }

	internal static extern IntPtr EOS_Platform_GetSanctionsInterface(IntPtr handle) { }

	internal static extern IntPtr EOS_Platform_GetSessionsInterface(IntPtr handle) { }

	internal static extern IntPtr EOS_Platform_GetStatsInterface(IntPtr handle) { }

	internal static extern IntPtr EOS_Platform_GetTitleStorageInterface(IntPtr handle) { }

	internal static extern IntPtr EOS_Platform_GetUIInterface(IntPtr handle) { }

	internal static extern IntPtr EOS_Platform_GetUserInfoInterface(IntPtr handle) { }

	internal static extern void EOS_Platform_Release(IntPtr handle) { }

	internal static extern Result EOS_Platform_SetApplicationStatus(IntPtr handle, ApplicationStatus newStatus) { }

	internal static extern Result EOS_Platform_SetNetworkStatus(IntPtr handle, NetworkStatus newStatus) { }

	internal static extern Result EOS_Platform_SetOverrideCountryCode(IntPtr handle, IntPtr newCountryCode) { }

	internal static extern Result EOS_Platform_SetOverrideLocaleCode(IntPtr handle, IntPtr newLocaleCode) { }

	internal static extern void EOS_Platform_Tick(IntPtr handle) { }

	internal static extern Result EOS_PlayerDataStorageFileTransferRequest_CancelRequest(IntPtr handle) { }

	internal static extern Result EOS_PlayerDataStorageFileTransferRequest_GetFileRequestState(IntPtr handle) { }

	internal static extern Result EOS_PlayerDataStorageFileTransferRequest_GetFilename(IntPtr handle, uint filenameStringBufferSizeBytes, IntPtr outStringBuffer, ref int outStringLength) { }

	internal static extern void EOS_PlayerDataStorageFileTransferRequest_Release(IntPtr playerDataStorageFileTransferHandle) { }

	internal static extern Result EOS_PlayerDataStorage_CopyFileMetadataAtIndex(IntPtr handle, ref CopyFileMetadataAtIndexOptionsInternal copyFileMetadataOptions, ref IntPtr outMetadata) { }

	internal static extern Result EOS_PlayerDataStorage_CopyFileMetadataByFilename(IntPtr handle, ref CopyFileMetadataByFilenameOptionsInternal copyFileMetadataOptions, ref IntPtr outMetadata) { }

	internal static extern Result EOS_PlayerDataStorage_DeleteCache(IntPtr handle, ref DeleteCacheOptionsInternal options, IntPtr clientData, OnDeleteCacheCompleteCallbackInternal completionCallback) { }

	internal static extern void EOS_PlayerDataStorage_DeleteFile(IntPtr handle, ref DeleteFileOptionsInternal deleteOptions, IntPtr clientData, OnDeleteFileCompleteCallbackInternal completionCallback) { }

	internal static extern void EOS_PlayerDataStorage_DuplicateFile(IntPtr handle, ref DuplicateFileOptionsInternal duplicateOptions, IntPtr clientData, OnDuplicateFileCompleteCallbackInternal completionCallback) { }

	internal static extern void EOS_PlayerDataStorage_FileMetadata_Release(IntPtr fileMetadata) { }

	internal static extern Result EOS_PlayerDataStorage_GetFileMetadataCount(IntPtr handle, ref GetFileMetadataCountOptionsInternal getFileMetadataCountOptions, ref int outFileMetadataCount) { }

	internal static extern void EOS_PlayerDataStorage_QueryFile(IntPtr handle, ref QueryFileOptionsInternal queryFileOptions, IntPtr clientData, OnQueryFileCompleteCallbackInternal completionCallback) { }

	internal static extern void EOS_PlayerDataStorage_QueryFileList(IntPtr handle, ref QueryFileListOptionsInternal queryFileListOptions, IntPtr clientData, OnQueryFileListCompleteCallbackInternal completionCallback) { }

	internal static extern IntPtr EOS_PlayerDataStorage_ReadFile(IntPtr handle, ref ReadFileOptionsInternal readOptions, IntPtr clientData, OnReadFileCompleteCallbackInternal completionCallback) { }

	internal static extern IntPtr EOS_PlayerDataStorage_WriteFile(IntPtr handle, ref WriteFileOptionsInternal writeOptions, IntPtr clientData, OnWriteFileCompleteCallbackInternal completionCallback) { }

	internal static extern Result EOS_PresenceModification_DeleteData(IntPtr handle, ref PresenceModificationDeleteDataOptionsInternal options) { }

	internal static extern void EOS_PresenceModification_Release(IntPtr presenceModificationHandle) { }

	internal static extern Result EOS_PresenceModification_SetData(IntPtr handle, ref PresenceModificationSetDataOptionsInternal options) { }

	internal static extern Result EOS_PresenceModification_SetJoinInfo(IntPtr handle, ref PresenceModificationSetJoinInfoOptionsInternal options) { }

	internal static extern Result EOS_PresenceModification_SetRawRichText(IntPtr handle, ref PresenceModificationSetRawRichTextOptionsInternal options) { }

	internal static extern Result EOS_PresenceModification_SetStatus(IntPtr handle, ref PresenceModificationSetStatusOptionsInternal options) { }

	internal static extern ulong EOS_Presence_AddNotifyJoinGameAccepted(IntPtr handle, ref AddNotifyJoinGameAcceptedOptionsInternal options, IntPtr clientData, OnJoinGameAcceptedCallbackInternal notificationFn) { }

	internal static extern ulong EOS_Presence_AddNotifyOnPresenceChanged(IntPtr handle, ref AddNotifyOnPresenceChangedOptionsInternal options, IntPtr clientData, OnPresenceChangedCallbackInternal notificationHandler) { }

	internal static extern Result EOS_Presence_CopyPresence(IntPtr handle, ref CopyPresenceOptionsInternal options, ref IntPtr outPresence) { }

	internal static extern Result EOS_Presence_CreatePresenceModification(IntPtr handle, ref CreatePresenceModificationOptionsInternal options, ref IntPtr outPresenceModificationHandle) { }

	internal static extern Result EOS_Presence_GetJoinInfo(IntPtr handle, ref GetJoinInfoOptionsInternal options, IntPtr outBuffer, ref int inOutBufferLength) { }

	internal static extern int EOS_Presence_HasPresence(IntPtr handle, ref HasPresenceOptionsInternal options) { }

	internal static extern void EOS_Presence_Info_Release(IntPtr presenceInfo) { }

	internal static extern void EOS_Presence_QueryPresence(IntPtr handle, ref QueryPresenceOptionsInternal options, IntPtr clientData, OnQueryPresenceCompleteCallbackInternal completionDelegate) { }

	internal static extern void EOS_Presence_RemoveNotifyJoinGameAccepted(IntPtr handle, ulong inId) { }

	internal static extern void EOS_Presence_RemoveNotifyOnPresenceChanged(IntPtr handle, ulong notificationId) { }

	internal static extern void EOS_Presence_SetPresence(IntPtr handle, ref SetPresenceOptionsInternal options, IntPtr clientData, SetPresenceCompleteCallbackInternal completionDelegate) { }

	internal static extern IntPtr EOS_ProductUserId_FromString(IntPtr productUserIdString) { }

	internal static extern int EOS_ProductUserId_IsValid(IntPtr accountId) { }

	internal static extern Result EOS_ProductUserId_ToString(IntPtr accountId, IntPtr outBuffer, ref int inOutBufferLength) { }

	internal static extern Result EOS_ProgressionSnapshot_AddProgression(IntPtr handle, ref AddProgressionOptionsInternal options) { }

	internal static extern Result EOS_ProgressionSnapshot_BeginSnapshot(IntPtr handle, ref BeginSnapshotOptionsInternal options, ref uint outSnapshotId) { }

	internal static extern void EOS_ProgressionSnapshot_DeleteSnapshot(IntPtr handle, ref DeleteSnapshotOptionsInternal options, IntPtr clientData, OnDeleteSnapshotCallbackInternal completionDelegate) { }

	internal static extern Result EOS_ProgressionSnapshot_EndSnapshot(IntPtr handle, ref EndSnapshotOptionsInternal options) { }

	internal static extern void EOS_ProgressionSnapshot_SubmitSnapshot(IntPtr handle, ref SubmitSnapshotOptionsInternal options, IntPtr clientData, OnSubmitSnapshotCallbackInternal completionDelegate) { }

	internal static extern Result EOS_RTCAdmin_CopyUserTokenByIndex(IntPtr handle, ref CopyUserTokenByIndexOptionsInternal options, ref IntPtr outUserToken) { }

	internal static extern Result EOS_RTCAdmin_CopyUserTokenByUserId(IntPtr handle, ref CopyUserTokenByUserIdOptionsInternal options, ref IntPtr outUserToken) { }

	internal static extern void EOS_RTCAdmin_Kick(IntPtr handle, ref KickOptionsInternal options, IntPtr clientData, OnKickCompleteCallbackInternal completionDelegate) { }

	internal static extern void EOS_RTCAdmin_QueryJoinRoomToken(IntPtr handle, ref QueryJoinRoomTokenOptionsInternal options, IntPtr clientData, OnQueryJoinRoomTokenCompleteCallbackInternal completionDelegate) { }

	internal static extern void EOS_RTCAdmin_SetParticipantHardMute(IntPtr handle, ref SetParticipantHardMuteOptionsInternal options, IntPtr clientData, OnSetParticipantHardMuteCompleteCallbackInternal completionDelegate) { }

	internal static extern void EOS_RTCAdmin_UserToken_Release(IntPtr userToken) { }

	internal static extern ulong EOS_RTCAudio_AddNotifyAudioBeforeRender(IntPtr handle, ref AddNotifyAudioBeforeRenderOptionsInternal options, IntPtr clientData, OnAudioBeforeRenderCallbackInternal completionDelegate) { }

	internal static extern ulong EOS_RTCAudio_AddNotifyAudioBeforeSend(IntPtr handle, ref AddNotifyAudioBeforeSendOptionsInternal options, IntPtr clientData, OnAudioBeforeSendCallbackInternal completionDelegate) { }

	internal static extern ulong EOS_RTCAudio_AddNotifyAudioDevicesChanged(IntPtr handle, ref AddNotifyAudioDevicesChangedOptionsInternal options, IntPtr clientData, OnAudioDevicesChangedCallbackInternal completionDelegate) { }

	internal static extern ulong EOS_RTCAudio_AddNotifyAudioInputState(IntPtr handle, ref AddNotifyAudioInputStateOptionsInternal options, IntPtr clientData, OnAudioInputStateCallbackInternal completionDelegate) { }

	internal static extern ulong EOS_RTCAudio_AddNotifyAudioOutputState(IntPtr handle, ref AddNotifyAudioOutputStateOptionsInternal options, IntPtr clientData, OnAudioOutputStateCallbackInternal completionDelegate) { }

	internal static extern ulong EOS_RTCAudio_AddNotifyParticipantUpdated(IntPtr handle, ref AddNotifyParticipantUpdatedOptionsInternal options, IntPtr clientData, OnParticipantUpdatedCallbackInternal completionDelegate) { }

	internal static extern IntPtr EOS_RTCAudio_GetAudioInputDeviceByIndex(IntPtr handle, ref GetAudioInputDeviceByIndexOptionsInternal options) { }

	internal static extern uint EOS_RTCAudio_GetAudioInputDevicesCount(IntPtr handle, ref GetAudioInputDevicesCountOptionsInternal options) { }

	internal static extern IntPtr EOS_RTCAudio_GetAudioOutputDeviceByIndex(IntPtr handle, ref GetAudioOutputDeviceByIndexOptionsInternal options) { }

	internal static extern uint EOS_RTCAudio_GetAudioOutputDevicesCount(IntPtr handle, ref GetAudioOutputDevicesCountOptionsInternal options) { }

	internal static extern Result EOS_RTCAudio_RegisterPlatformAudioUser(IntPtr handle, ref RegisterPlatformAudioUserOptionsInternal options) { }

	internal static extern void EOS_RTCAudio_RemoveNotifyAudioBeforeRender(IntPtr handle, ulong notificationId) { }

	internal static extern void EOS_RTCAudio_RemoveNotifyAudioBeforeSend(IntPtr handle, ulong notificationId) { }

	internal static extern void EOS_RTCAudio_RemoveNotifyAudioDevicesChanged(IntPtr handle, ulong notificationId) { }

	internal static extern void EOS_RTCAudio_RemoveNotifyAudioInputState(IntPtr handle, ulong notificationId) { }

	internal static extern void EOS_RTCAudio_RemoveNotifyAudioOutputState(IntPtr handle, ulong notificationId) { }

	internal static extern void EOS_RTCAudio_RemoveNotifyParticipantUpdated(IntPtr handle, ulong notificationId) { }

	internal static extern Result EOS_RTCAudio_SendAudio(IntPtr handle, ref SendAudioOptionsInternal options) { }

	internal static extern Result EOS_RTCAudio_SetAudioInputSettings(IntPtr handle, ref SetAudioInputSettingsOptionsInternal options) { }

	internal static extern Result EOS_RTCAudio_SetAudioOutputSettings(IntPtr handle, ref SetAudioOutputSettingsOptionsInternal options) { }

	internal static extern Result EOS_RTCAudio_UnregisterPlatformAudioUser(IntPtr handle, ref UnregisterPlatformAudioUserOptionsInternal options) { }

	internal static extern void EOS_RTCAudio_UpdateParticipantVolume(IntPtr handle, ref UpdateParticipantVolumeOptionsInternal options, IntPtr clientData, OnUpdateParticipantVolumeCallbackInternal completionDelegate) { }

	internal static extern void EOS_RTCAudio_UpdateReceiving(IntPtr handle, ref UpdateReceivingOptionsInternal options, IntPtr clientData, OnUpdateReceivingCallbackInternal completionDelegate) { }

	internal static extern void EOS_RTCAudio_UpdateReceivingVolume(IntPtr handle, ref UpdateReceivingVolumeOptionsInternal options, IntPtr clientData, OnUpdateReceivingVolumeCallbackInternal completionDelegate) { }

	internal static extern void EOS_RTCAudio_UpdateSending(IntPtr handle, ref UpdateSendingOptionsInternal options, IntPtr clientData, OnUpdateSendingCallbackInternal completionDelegate) { }

	internal static extern void EOS_RTCAudio_UpdateSendingVolume(IntPtr handle, ref UpdateSendingVolumeOptionsInternal options, IntPtr clientData, OnUpdateSendingVolumeCallbackInternal completionDelegate) { }

	internal static extern ulong EOS_RTC_AddNotifyDisconnected(IntPtr handle, ref AddNotifyDisconnectedOptionsInternal options, IntPtr clientData, OnDisconnectedCallbackInternal completionDelegate) { }

	internal static extern ulong EOS_RTC_AddNotifyParticipantStatusChanged(IntPtr handle, ref AddNotifyParticipantStatusChangedOptionsInternal options, IntPtr clientData, OnParticipantStatusChangedCallbackInternal completionDelegate) { }

	internal static extern void EOS_RTC_BlockParticipant(IntPtr handle, ref BlockParticipantOptionsInternal options, IntPtr clientData, OnBlockParticipantCallbackInternal completionDelegate) { }

	internal static extern IntPtr EOS_RTC_GetAudioInterface(IntPtr handle) { }

	internal static extern void EOS_RTC_JoinRoom(IntPtr handle, ref JoinRoomOptionsInternal options, IntPtr clientData, OnJoinRoomCallbackInternal completionDelegate) { }

	internal static extern void EOS_RTC_LeaveRoom(IntPtr handle, ref LeaveRoomOptionsInternal options, IntPtr clientData, OnLeaveRoomCallbackInternal completionDelegate) { }

	internal static extern void EOS_RTC_RemoveNotifyDisconnected(IntPtr handle, ulong notificationId) { }

	internal static extern void EOS_RTC_RemoveNotifyParticipantStatusChanged(IntPtr handle, ulong notificationId) { }

	internal static extern Result EOS_RTC_SetRoomSetting(IntPtr handle, ref SetRoomSettingOptionsInternal options) { }

	internal static extern Result EOS_RTC_SetSetting(IntPtr handle, ref SetSettingOptionsInternal options) { }

	internal static extern void EOS_Reports_SendPlayerBehaviorReport(IntPtr handle, ref SendPlayerBehaviorReportOptionsInternal options, IntPtr clientData, OnSendPlayerBehaviorReportCompleteCallbackInternal completionDelegate) { }

	internal static extern Result EOS_Sanctions_CopyPlayerSanctionByIndex(IntPtr handle, ref CopyPlayerSanctionByIndexOptionsInternal options, ref IntPtr outSanction) { }

	internal static extern uint EOS_Sanctions_GetPlayerSanctionCount(IntPtr handle, ref GetPlayerSanctionCountOptionsInternal options) { }

	internal static extern void EOS_Sanctions_PlayerSanction_Release(IntPtr sanction) { }

	internal static extern void EOS_Sanctions_QueryActivePlayerSanctions(IntPtr handle, ref QueryActivePlayerSanctionsOptionsInternal options, IntPtr clientData, OnQueryActivePlayerSanctionsCallbackInternal completionDelegate) { }

	internal static extern void EOS_SessionDetails_Attribute_Release(IntPtr sessionAttribute) { }

	internal static extern Result EOS_SessionDetails_CopyInfo(IntPtr handle, ref SessionDetailsCopyInfoOptionsInternal options, ref IntPtr outSessionInfo) { }

	internal static extern Result EOS_SessionDetails_CopySessionAttributeByIndex(IntPtr handle, ref SessionDetailsCopySessionAttributeByIndexOptionsInternal options, ref IntPtr outSessionAttribute) { }

	internal static extern Result EOS_SessionDetails_CopySessionAttributeByKey(IntPtr handle, ref SessionDetailsCopySessionAttributeByKeyOptionsInternal options, ref IntPtr outSessionAttribute) { }

	internal static extern uint EOS_SessionDetails_GetSessionAttributeCount(IntPtr handle, ref SessionDetailsGetSessionAttributeCountOptionsInternal options) { }

	internal static extern void EOS_SessionDetails_Info_Release(IntPtr sessionInfo) { }

	internal static extern void EOS_SessionDetails_Release(IntPtr sessionHandle) { }

	internal static extern Result EOS_SessionModification_AddAttribute(IntPtr handle, ref SessionModificationAddAttributeOptionsInternal options) { }

	internal static extern void EOS_SessionModification_Release(IntPtr sessionModificationHandle) { }

	internal static extern Result EOS_SessionModification_RemoveAttribute(IntPtr handle, ref SessionModificationRemoveAttributeOptionsInternal options) { }

	internal static extern Result EOS_SessionModification_SetBucketId(IntPtr handle, ref SessionModificationSetBucketIdOptionsInternal options) { }

	internal static extern Result EOS_SessionModification_SetHostAddress(IntPtr handle, ref SessionModificationSetHostAddressOptionsInternal options) { }

	internal static extern Result EOS_SessionModification_SetInvitesAllowed(IntPtr handle, ref SessionModificationSetInvitesAllowedOptionsInternal options) { }

	internal static extern Result EOS_SessionModification_SetJoinInProgressAllowed(IntPtr handle, ref SessionModificationSetJoinInProgressAllowedOptionsInternal options) { }

	internal static extern Result EOS_SessionModification_SetMaxPlayers(IntPtr handle, ref SessionModificationSetMaxPlayersOptionsInternal options) { }

	internal static extern Result EOS_SessionModification_SetPermissionLevel(IntPtr handle, ref SessionModificationSetPermissionLevelOptionsInternal options) { }

	internal static extern Result EOS_SessionSearch_CopySearchResultByIndex(IntPtr handle, ref SessionSearchCopySearchResultByIndexOptionsInternal options, ref IntPtr outSessionHandle) { }

	internal static extern void EOS_SessionSearch_Find(IntPtr handle, ref SessionSearchFindOptionsInternal options, IntPtr clientData, SessionSearchOnFindCallbackInternal completionDelegate) { }

	internal static extern uint EOS_SessionSearch_GetSearchResultCount(IntPtr handle, ref SessionSearchGetSearchResultCountOptionsInternal options) { }

	internal static extern void EOS_SessionSearch_Release(IntPtr sessionSearchHandle) { }

	internal static extern Result EOS_SessionSearch_RemoveParameter(IntPtr handle, ref SessionSearchRemoveParameterOptionsInternal options) { }

	internal static extern Result EOS_SessionSearch_SetMaxResults(IntPtr handle, ref SessionSearchSetMaxResultsOptionsInternal options) { }

	internal static extern Result EOS_SessionSearch_SetParameter(IntPtr handle, ref SessionSearchSetParameterOptionsInternal options) { }

	internal static extern Result EOS_SessionSearch_SetSessionId(IntPtr handle, ref SessionSearchSetSessionIdOptionsInternal options) { }

	internal static extern Result EOS_SessionSearch_SetTargetUserId(IntPtr handle, ref SessionSearchSetTargetUserIdOptionsInternal options) { }

	internal static extern ulong EOS_Sessions_AddNotifyJoinSessionAccepted(IntPtr handle, ref AddNotifyJoinSessionAcceptedOptionsInternal options, IntPtr clientData, OnJoinSessionAcceptedCallbackInternal notificationFn) { }

	internal static extern ulong EOS_Sessions_AddNotifySessionInviteAccepted(IntPtr handle, ref AddNotifySessionInviteAcceptedOptionsInternal options, IntPtr clientData, OnSessionInviteAcceptedCallbackInternal notificationFn) { }

	internal static extern ulong EOS_Sessions_AddNotifySessionInviteReceived(IntPtr handle, ref AddNotifySessionInviteReceivedOptionsInternal options, IntPtr clientData, OnSessionInviteReceivedCallbackInternal notificationFn) { }

	internal static extern Result EOS_Sessions_CopyActiveSessionHandle(IntPtr handle, ref CopyActiveSessionHandleOptionsInternal options, ref IntPtr outSessionHandle) { }

	internal static extern Result EOS_Sessions_CopySessionHandleByInviteId(IntPtr handle, ref CopySessionHandleByInviteIdOptionsInternal options, ref IntPtr outSessionHandle) { }

	internal static extern Result EOS_Sessions_CopySessionHandleByUiEventId(IntPtr handle, ref CopySessionHandleByUiEventIdOptionsInternal options, ref IntPtr outSessionHandle) { }

	internal static extern Result EOS_Sessions_CopySessionHandleForPresence(IntPtr handle, ref CopySessionHandleForPresenceOptionsInternal options, ref IntPtr outSessionHandle) { }

	internal static extern Result EOS_Sessions_CreateSessionModification(IntPtr handle, ref CreateSessionModificationOptionsInternal options, ref IntPtr outSessionModificationHandle) { }

	internal static extern Result EOS_Sessions_CreateSessionSearch(IntPtr handle, ref CreateSessionSearchOptionsInternal options, ref IntPtr outSessionSearchHandle) { }

	internal static extern void EOS_Sessions_DestroySession(IntPtr handle, ref DestroySessionOptionsInternal options, IntPtr clientData, OnDestroySessionCallbackInternal completionDelegate) { }

	internal static extern Result EOS_Sessions_DumpSessionState(IntPtr handle, ref DumpSessionStateOptionsInternal options) { }

	internal static extern void EOS_Sessions_EndSession(IntPtr handle, ref EndSessionOptionsInternal options, IntPtr clientData, OnEndSessionCallbackInternal completionDelegate) { }

	internal static extern uint EOS_Sessions_GetInviteCount(IntPtr handle, ref GetInviteCountOptionsInternal options) { }

	internal static extern Result EOS_Sessions_GetInviteIdByIndex(IntPtr handle, ref GetInviteIdByIndexOptionsInternal options, IntPtr outBuffer, ref int inOutBufferLength) { }

	internal static extern Result EOS_Sessions_IsUserInSession(IntPtr handle, ref IsUserInSessionOptionsInternal options) { }

	internal static extern void EOS_Sessions_JoinSession(IntPtr handle, ref JoinSessionOptionsInternal options, IntPtr clientData, OnJoinSessionCallbackInternal completionDelegate) { }

	internal static extern void EOS_Sessions_QueryInvites(IntPtr handle, ref QueryInvitesOptionsInternal options, IntPtr clientData, OnQueryInvitesCallbackInternal completionDelegate) { }

	internal static extern void EOS_Sessions_RegisterPlayers(IntPtr handle, ref RegisterPlayersOptionsInternal options, IntPtr clientData, OnRegisterPlayersCallbackInternal completionDelegate) { }

	internal static extern void EOS_Sessions_RejectInvite(IntPtr handle, ref RejectInviteOptionsInternal options, IntPtr clientData, OnRejectInviteCallbackInternal completionDelegate) { }

	internal static extern void EOS_Sessions_RemoveNotifyJoinSessionAccepted(IntPtr handle, ulong inId) { }

	internal static extern void EOS_Sessions_RemoveNotifySessionInviteAccepted(IntPtr handle, ulong inId) { }

	internal static extern void EOS_Sessions_RemoveNotifySessionInviteReceived(IntPtr handle, ulong inId) { }

	internal static extern void EOS_Sessions_SendInvite(IntPtr handle, ref SendInviteOptionsInternal options, IntPtr clientData, OnSendInviteCallbackInternal completionDelegate) { }

	internal static extern void EOS_Sessions_StartSession(IntPtr handle, ref StartSessionOptionsInternal options, IntPtr clientData, OnStartSessionCallbackInternal completionDelegate) { }

	internal static extern void EOS_Sessions_UnregisterPlayers(IntPtr handle, ref UnregisterPlayersOptionsInternal options, IntPtr clientData, OnUnregisterPlayersCallbackInternal completionDelegate) { }

	internal static extern void EOS_Sessions_UpdateSession(IntPtr handle, ref UpdateSessionOptionsInternal options, IntPtr clientData, OnUpdateSessionCallbackInternal completionDelegate) { }

	internal static extern Result EOS_Sessions_UpdateSessionModification(IntPtr handle, ref UpdateSessionModificationOptionsInternal options, ref IntPtr outSessionModificationHandle) { }

	internal static extern Result EOS_Shutdown() { }

	internal static extern Result EOS_Stats_CopyStatByIndex(IntPtr handle, ref CopyStatByIndexOptionsInternal options, ref IntPtr outStat) { }

	internal static extern Result EOS_Stats_CopyStatByName(IntPtr handle, ref CopyStatByNameOptionsInternal options, ref IntPtr outStat) { }

	internal static extern uint EOS_Stats_GetStatsCount(IntPtr handle, ref GetStatCountOptionsInternal options) { }

	internal static extern void EOS_Stats_IngestStat(IntPtr handle, ref IngestStatOptionsInternal options, IntPtr clientData, OnIngestStatCompleteCallbackInternal completionDelegate) { }

	internal static extern void EOS_Stats_QueryStats(IntPtr handle, ref QueryStatsOptionsInternal options, IntPtr clientData, OnQueryStatsCompleteCallbackInternal completionDelegate) { }

	internal static extern void EOS_Stats_Stat_Release(IntPtr stat) { }

	internal static extern Result EOS_TitleStorageFileTransferRequest_CancelRequest(IntPtr handle) { }

	internal static extern Result EOS_TitleStorageFileTransferRequest_GetFileRequestState(IntPtr handle) { }

	internal static extern Result EOS_TitleStorageFileTransferRequest_GetFilename(IntPtr handle, uint filenameStringBufferSizeBytes, IntPtr outStringBuffer, ref int outStringLength) { }

	internal static extern void EOS_TitleStorageFileTransferRequest_Release(IntPtr titleStorageFileTransferHandle) { }

	internal static extern Result EOS_TitleStorage_CopyFileMetadataAtIndex(IntPtr handle, ref CopyFileMetadataAtIndexOptionsInternal options, ref IntPtr outMetadata) { }

	internal static extern Result EOS_TitleStorage_CopyFileMetadataByFilename(IntPtr handle, ref CopyFileMetadataByFilenameOptionsInternal options, ref IntPtr outMetadata) { }

	internal static extern Result EOS_TitleStorage_DeleteCache(IntPtr handle, ref DeleteCacheOptionsInternal options, IntPtr clientData, OnDeleteCacheCompleteCallbackInternal completionCallback) { }

	internal static extern void EOS_TitleStorage_FileMetadata_Release(IntPtr fileMetadata) { }

	internal static extern uint EOS_TitleStorage_GetFileMetadataCount(IntPtr handle, ref GetFileMetadataCountOptionsInternal options) { }

	internal static extern void EOS_TitleStorage_QueryFile(IntPtr handle, ref QueryFileOptionsInternal options, IntPtr clientData, OnQueryFileCompleteCallbackInternal completionCallback) { }

	internal static extern void EOS_TitleStorage_QueryFileList(IntPtr handle, ref QueryFileListOptionsInternal options, IntPtr clientData, OnQueryFileListCompleteCallbackInternal completionCallback) { }

	internal static extern IntPtr EOS_TitleStorage_ReadFile(IntPtr handle, ref ReadFileOptionsInternal options, IntPtr clientData, OnReadFileCompleteCallbackInternal completionCallback) { }

	internal static extern Result EOS_UI_AcknowledgeEventId(IntPtr handle, ref AcknowledgeEventIdOptionsInternal options) { }

	internal static extern ulong EOS_UI_AddNotifyDisplaySettingsUpdated(IntPtr handle, ref AddNotifyDisplaySettingsUpdatedOptionsInternal options, IntPtr clientData, OnDisplaySettingsUpdatedCallbackInternal notificationFn) { }

	internal static extern int EOS_UI_GetFriendsExclusiveInput(IntPtr handle, ref GetFriendsExclusiveInputOptionsInternal options) { }

	internal static extern int EOS_UI_GetFriendsVisible(IntPtr handle, ref GetFriendsVisibleOptionsInternal options) { }

	internal static extern NotificationLocation EOS_UI_GetNotificationLocationPreference(IntPtr handle) { }

	internal static extern KeyCombination EOS_UI_GetToggleFriendsKey(IntPtr handle, ref GetToggleFriendsKeyOptionsInternal options) { }

	internal static extern void EOS_UI_HideFriends(IntPtr handle, ref HideFriendsOptionsInternal options, IntPtr clientData, OnHideFriendsCallbackInternal completionDelegate) { }

	internal static extern int EOS_UI_IsSocialOverlayPaused(IntPtr handle, ref IsSocialOverlayPausedOptionsInternal options) { }

	internal static extern int EOS_UI_IsValidKeyCombination(IntPtr handle, KeyCombination keyCombination) { }

	internal static extern Result EOS_UI_PauseSocialOverlay(IntPtr handle, ref PauseSocialOverlayOptionsInternal options) { }

	internal static extern void EOS_UI_RemoveNotifyDisplaySettingsUpdated(IntPtr handle, ulong id) { }

	internal static extern Result EOS_UI_SetDisplayPreference(IntPtr handle, ref SetDisplayPreferenceOptionsInternal options) { }

	internal static extern Result EOS_UI_SetToggleFriendsKey(IntPtr handle, ref SetToggleFriendsKeyOptionsInternal options) { }

	internal static extern void EOS_UI_ShowBlockPlayer(IntPtr handle, ref ShowBlockPlayerOptionsInternal options, IntPtr clientData, OnShowBlockPlayerCallbackInternal completionDelegate) { }

	internal static extern void EOS_UI_ShowFriends(IntPtr handle, ref ShowFriendsOptionsInternal options, IntPtr clientData, OnShowFriendsCallbackInternal completionDelegate) { }

	internal static extern void EOS_UI_ShowReportPlayer(IntPtr handle, ref ShowReportPlayerOptionsInternal options, IntPtr clientData, OnShowReportPlayerCallbackInternal completionDelegate) { }

	internal static extern Result EOS_UserInfo_CopyExternalUserInfoByAccountId(IntPtr handle, ref CopyExternalUserInfoByAccountIdOptionsInternal options, ref IntPtr outExternalUserInfo) { }

	internal static extern Result EOS_UserInfo_CopyExternalUserInfoByAccountType(IntPtr handle, ref CopyExternalUserInfoByAccountTypeOptionsInternal options, ref IntPtr outExternalUserInfo) { }

	internal static extern Result EOS_UserInfo_CopyExternalUserInfoByIndex(IntPtr handle, ref CopyExternalUserInfoByIndexOptionsInternal options, ref IntPtr outExternalUserInfo) { }

	internal static extern Result EOS_UserInfo_CopyUserInfo(IntPtr handle, ref CopyUserInfoOptionsInternal options, ref IntPtr outUserInfo) { }

	internal static extern void EOS_UserInfo_ExternalUserInfo_Release(IntPtr externalUserInfo) { }

	internal static extern uint EOS_UserInfo_GetExternalUserInfoCount(IntPtr handle, ref GetExternalUserInfoCountOptionsInternal options) { }

	internal static extern void EOS_UserInfo_QueryUserInfo(IntPtr handle, ref QueryUserInfoOptionsInternal options, IntPtr clientData, OnQueryUserInfoCallbackInternal completionDelegate) { }

	internal static extern void EOS_UserInfo_QueryUserInfoByDisplayName(IntPtr handle, ref QueryUserInfoByDisplayNameOptionsInternal options, IntPtr clientData, OnQueryUserInfoByDisplayNameCallbackInternal completionDelegate) { }

	internal static extern void EOS_UserInfo_QueryUserInfoByExternalAccount(IntPtr handle, ref QueryUserInfoByExternalAccountOptionsInternal options, IntPtr clientData, OnQueryUserInfoByExternalAccountCallbackInternal completionDelegate) { }

	internal static extern void EOS_UserInfo_Release(IntPtr userInfo) { }

}

