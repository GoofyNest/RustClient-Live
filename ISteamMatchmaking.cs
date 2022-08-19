internal class ISteamMatchmaking : SteamInterface // TypeDefIndex: 5119
{	// Methods

	// RVA: 0x1280910 Offset: 0x127FD10 VA: 0x181280910
	internal void .ctor(bool IsGameServer) { }

	// RVA: 0x1285980 Offset: 0x1284D80 VA: 0x181285980
	internal static extern IntPtr SteamAPI_SteamMatchmaking_v009() { }

	// RVA: 0x1285980 Offset: 0x1284D80 VA: 0x181285980 Slot: 4
	public override IntPtr GetUserInterfacePointer() { }

	// RVA: 0x1285B90 Offset: 0x1284F90 VA: 0x181285B90
	private static extern int _GetFavoriteGameCount(IntPtr self) { }

	// RVA: 0x1285750 Offset: 0x1284B50 VA: 0x181285750
	internal int GetFavoriteGameCount() { }

	// RVA: 0x1285C10 Offset: 0x1285010 VA: 0x181285C10
	private static extern bool _GetFavoriteGame(IntPtr self, int iGame, ref AppId pnAppID, ref uint pnIP, ref ushort pnConnPort, ref ushort pnQueryPort, ref uint punFlags, ref uint pRTime32LastPlayedOnServer) { }

	// RVA: 0x12857D0 Offset: 0x1284BD0 VA: 0x1812857D0
	internal bool GetFavoriteGame(int iGame, ref AppId pnAppID, ref uint pnIP, ref ushort pnConnPort, ref ushort pnQueryPort, ref uint punFlags, ref uint pRTime32LastPlayedOnServer) { }

	// RVA: 0x1285AC0 Offset: 0x1284EC0 VA: 0x181285AC0
	private static extern int _AddFavoriteGame(IntPtr self, AppId nAppID, uint nIP, ushort nConnPort, ushort nQueryPort, uint unFlags, uint rTime32LastPlayedOnServer) { }

	// RVA: 0x1285680 Offset: 0x1284A80 VA: 0x181285680
	internal int AddFavoriteGame(AppId nAppID, uint nIP, ushort nConnPort, ushort nQueryPort, uint unFlags, uint rTime32LastPlayedOnServer) { }

	// RVA: 0x1285DC0 Offset: 0x12851C0 VA: 0x181285DC0
	private static extern bool _RemoveFavoriteGame(IntPtr self, AppId nAppID, uint nIP, ushort nConnPort, ushort nQueryPort, uint unFlags) { }

	// RVA: 0x12859F0 Offset: 0x1284DF0 VA: 0x1812859F0
	internal bool RemoveFavoriteGame(AppId nAppID, uint nIP, ushort nConnPort, ushort nQueryPort, uint unFlags) { }

	// RVA: 0x1285CF0 Offset: 0x12850F0 VA: 0x181285CF0
	private static extern int _GetLobbyChatEntry(IntPtr self, SteamId steamIDLobby, int iChatID, ref SteamId pSteamIDUser, IntPtr pvData, int cubData, ref ChatEntryType peChatEntryType) { }

	// RVA: 0x12858B0 Offset: 0x1284CB0 VA: 0x1812858B0
	internal int GetLobbyChatEntry(SteamId steamIDLobby, int iChatID, ref SteamId pSteamIDUser, IntPtr pvData, int cubData, ref ChatEntryType peChatEntryType) { }

}

