internal class ISteamFriends : SteamInterface // TypeDefIndex: 5116
{	// Methods

	// RVA: 0x1280910 Offset: 0x127FD10 VA: 0x181280910
	internal void .ctor(bool IsGameServer) { }

	// RVA: 0x1281200 Offset: 0x1280600 VA: 0x181281200
	internal static extern IntPtr SteamAPI_SteamFriends_v017() { }

	// RVA: 0x1281200 Offset: 0x1280600 VA: 0x181281200 Slot: 4
	public override IntPtr GetUserInterfacePointer() { }

	// RVA: 0x1281C90 Offset: 0x1281090 VA: 0x181281C90
	private static extern Utf8StringPointer _GetPersonaName(IntPtr self) { }

	// RVA: 0x1281170 Offset: 0x1280570 VA: 0x181281170
	internal string GetPersonaName() { }

	// RVA: 0x1281860 Offset: 0x1280C60 VA: 0x181281860
	private static extern int _GetFriendCount(IntPtr self, int iFriendFlags) { }

	// RVA: 0x1280D30 Offset: 0x1280130 VA: 0x181280D30
	internal int GetFriendCount(int iFriendFlags) { }

	// RVA: 0x12817C0 Offset: 0x1280BC0 VA: 0x1812817C0
	private static extern SteamId _GetFriendByIndex(IntPtr self, int iFriend, int iFriendFlags) { }

	// RVA: 0x1280C90 Offset: 0x1280090 VA: 0x181280C90
	internal SteamId GetFriendByIndex(int iFriend, int iFriendFlags) { }

	// RVA: 0x1281B70 Offset: 0x1280F70 VA: 0x181281B70
	private static extern Relationship _GetFriendRelationship(IntPtr self, SteamId steamIDFriend) { }

	// RVA: 0x1281050 Offset: 0x1280450 VA: 0x181281050
	internal Relationship GetFriendRelationship(SteamId steamIDFriend) { }

	// RVA: 0x1281AE0 Offset: 0x1280EE0 VA: 0x181281AE0
	private static extern FriendState _GetFriendPersonaState(IntPtr self, SteamId steamIDFriend) { }

	// RVA: 0x1280FC0 Offset: 0x12803C0 VA: 0x181280FC0
	internal FriendState GetFriendPersonaState(SteamId steamIDFriend) { }

	// RVA: 0x1281A50 Offset: 0x1280E50 VA: 0x181281A50
	private static extern Utf8StringPointer _GetFriendPersonaName(IntPtr self, SteamId steamIDFriend) { }

	// RVA: 0x1280F20 Offset: 0x1280320 VA: 0x181280F20
	internal string GetFriendPersonaName(SteamId steamIDFriend) { }

	// RVA: 0x12818F0 Offset: 0x1280CF0 VA: 0x1812818F0
	private static extern bool _GetFriendGamePlayed(IntPtr self, SteamId steamIDFriend, ref FriendGameInfo_t pFriendGameInfo) { }

	// RVA: 0x1280DC0 Offset: 0x12801C0 VA: 0x181280DC0
	internal bool GetFriendGamePlayed(SteamId steamIDFriend, ref FriendGameInfo_t pFriendGameInfo) { }

	// RVA: 0x1281510 Offset: 0x1280910 VA: 0x181281510
	private static extern void _ActivateGameOverlayToUser(IntPtr self, string pchDialog, SteamId steamID) { }

	// RVA: 0x12809E0 Offset: 0x127FDE0 VA: 0x1812809E0
	internal void ActivateGameOverlayToUser(string pchDialog, SteamId steamID) { }

	// RVA: 0x12815C0 Offset: 0x12809C0 VA: 0x1812815C0
	private static extern void _ActivateGameOverlayToWebPage(IntPtr self, string pchURL, ActivateGameOverlayToWebPageMode eMode) { }

	// RVA: 0x1280A90 Offset: 0x127FE90 VA: 0x181280A90
	internal void ActivateGameOverlayToWebPage(string pchURL, ActivateGameOverlayToWebPageMode eMode) { }

	// RVA: 0x1281470 Offset: 0x1280870 VA: 0x181281470
	private static extern void _ActivateGameOverlayToStore(IntPtr self, AppId nAppID, OverlayToStoreFlag eFlag) { }

	// RVA: 0x1280940 Offset: 0x127FD40 VA: 0x181280940
	internal void ActivateGameOverlayToStore(AppId nAppID, OverlayToStoreFlag eFlag) { }

	// RVA: 0x1281DB0 Offset: 0x12811B0 VA: 0x181281DB0
	private static extern void _SetPlayedWith(IntPtr self, SteamId steamIDUserPlayedWith) { }

	// RVA: 0x1281310 Offset: 0x1280710 VA: 0x181281310
	internal void SetPlayedWith(SteamId steamIDUserPlayedWith) { }

	// RVA: 0x1281C00 Offset: 0x1281000 VA: 0x181281C00
	private static extern int _GetMediumFriendAvatar(IntPtr self, SteamId steamIDFriend) { }

	// RVA: 0x12810E0 Offset: 0x12804E0 VA: 0x1812810E0
	internal int GetMediumFriendAvatar(SteamId steamIDFriend) { }

	// RVA: 0x1281D10 Offset: 0x1281110 VA: 0x181281D10
	private static extern bool _RequestUserInformation(IntPtr self, SteamId steamIDUser, bool bRequireNameOnly) { }

	// RVA: 0x1281270 Offset: 0x1280670 VA: 0x181281270
	internal bool RequestUserInformation(SteamId steamIDUser, bool bRequireNameOnly) { }

	// RVA: 0x1281E40 Offset: 0x1281240 VA: 0x181281E40
	private static extern bool _SetRichPresence(IntPtr self, string pchKey, string pchValue) { }

	// RVA: 0x12813A0 Offset: 0x12807A0 VA: 0x1812813A0
	internal bool SetRichPresence(string pchKey, string pchValue) { }

	// RVA: 0x1281670 Offset: 0x1280A70 VA: 0x181281670
	private static extern void _ClearRichPresence(IntPtr self) { }

	// RVA: 0x1280B40 Offset: 0x127FF40 VA: 0x181280B40
	internal void ClearRichPresence() { }

	// RVA: 0x12816F0 Offset: 0x1280AF0 VA: 0x1812816F0
	private static extern int _GetClanChatMessage(IntPtr self, SteamId steamIDClanChat, int iMessage, IntPtr prgchText, int cchTextMax, ref ChatEntryType peChatEntryType, ref SteamId psteamidChatter) { }

	// RVA: 0x1280BC0 Offset: 0x127FFC0 VA: 0x181280BC0
	internal int GetClanChatMessage(SteamId steamIDClanChat, int iMessage, IntPtr prgchText, int cchTextMax, ref ChatEntryType peChatEntryType, ref SteamId psteamidChatter) { }

	// RVA: 0x1281990 Offset: 0x1280D90 VA: 0x181281990
	private static extern int _GetFriendMessage(IntPtr self, SteamId steamIDFriend, int iMessageID, IntPtr pvData, int cubData, ref ChatEntryType peChatEntryType) { }

	// RVA: 0x1280E60 Offset: 0x1280260 VA: 0x181280E60
	internal int GetFriendMessage(SteamId steamIDFriend, int iMessageID, IntPtr pvData, int cubData, ref ChatEntryType peChatEntryType) { }

}

