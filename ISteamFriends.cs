internal class ISteamFriends : SteamInterface // TypeDefIndex: 5117
{

	internal void .ctor(bool IsGameServer) { }

	internal static extern IntPtr SteamAPI_SteamFriends_v017() { }

	public override IntPtr GetUserInterfacePointer() { }

	private static extern Utf8StringPointer _GetPersonaName(IntPtr self) { }

	internal string GetPersonaName() { }

	private static extern int _GetFriendCount(IntPtr self, int iFriendFlags) { }

	internal int GetFriendCount(int iFriendFlags) { }

	private static extern SteamId _GetFriendByIndex(IntPtr self, int iFriend, int iFriendFlags) { }

	internal SteamId GetFriendByIndex(int iFriend, int iFriendFlags) { }

	private static extern Relationship _GetFriendRelationship(IntPtr self, SteamId steamIDFriend) { }

	internal Relationship GetFriendRelationship(SteamId steamIDFriend) { }

	private static extern FriendState _GetFriendPersonaState(IntPtr self, SteamId steamIDFriend) { }

	internal FriendState GetFriendPersonaState(SteamId steamIDFriend) { }

	private static extern Utf8StringPointer _GetFriendPersonaName(IntPtr self, SteamId steamIDFriend) { }

	internal string GetFriendPersonaName(SteamId steamIDFriend) { }

	private static extern bool _GetFriendGamePlayed(IntPtr self, SteamId steamIDFriend, ref FriendGameInfo_t pFriendGameInfo) { }

	internal bool GetFriendGamePlayed(SteamId steamIDFriend, ref FriendGameInfo_t pFriendGameInfo) { }

	private static extern void _ActivateGameOverlayToUser(IntPtr self, string pchDialog, SteamId steamID) { }

	internal void ActivateGameOverlayToUser(string pchDialog, SteamId steamID) { }

	private static extern void _ActivateGameOverlayToWebPage(IntPtr self, string pchURL, ActivateGameOverlayToWebPageMode eMode) { }

	internal void ActivateGameOverlayToWebPage(string pchURL, ActivateGameOverlayToWebPageMode eMode) { }

	private static extern void _ActivateGameOverlayToStore(IntPtr self, AppId nAppID, OverlayToStoreFlag eFlag) { }

	internal void ActivateGameOverlayToStore(AppId nAppID, OverlayToStoreFlag eFlag) { }

	private static extern void _SetPlayedWith(IntPtr self, SteamId steamIDUserPlayedWith) { }

	internal void SetPlayedWith(SteamId steamIDUserPlayedWith) { }

	private static extern int _GetMediumFriendAvatar(IntPtr self, SteamId steamIDFriend) { }

	internal int GetMediumFriendAvatar(SteamId steamIDFriend) { }

	private static extern bool _RequestUserInformation(IntPtr self, SteamId steamIDUser, bool bRequireNameOnly) { }

	internal bool RequestUserInformation(SteamId steamIDUser, bool bRequireNameOnly) { }

	private static extern bool _SetRichPresence(IntPtr self, string pchKey, string pchValue) { }

	internal bool SetRichPresence(string pchKey, string pchValue) { }

	private static extern void _ClearRichPresence(IntPtr self) { }

	internal void ClearRichPresence() { }

	private static extern int _GetClanChatMessage(IntPtr self, SteamId steamIDClanChat, int iMessage, IntPtr prgchText, int cchTextMax, ref ChatEntryType peChatEntryType, ref SteamId psteamidChatter) { }

	internal int GetClanChatMessage(SteamId steamIDClanChat, int iMessage, IntPtr prgchText, int cchTextMax, ref ChatEntryType peChatEntryType, ref SteamId psteamidChatter) { }

	private static extern int _GetFriendMessage(IntPtr self, SteamId steamIDFriend, int iMessageID, IntPtr pvData, int cubData, ref ChatEntryType peChatEntryType) { }

	internal int GetFriendMessage(SteamId steamIDFriend, int iMessageID, IntPtr pvData, int cubData, ref ChatEntryType peChatEntryType) { }

}

