internal class ISteamMatchmaking : SteamInterface // TypeDefIndex: 5119
{

internal void .ctor(bool IsGameServer) { }

internal static extern IntPtr SteamAPI_SteamMatchmaking_v009() { }

public override IntPtr GetUserInterfacePointer() { }

private static extern int _GetFavoriteGameCount(IntPtr self) { }

internal int GetFavoriteGameCount() { }

private static extern bool _GetFavoriteGame(IntPtr self, int iGame, ref AppId pnAppID, ref uint pnIP, ref ushort pnConnPort, ref ushort pnQueryPort, ref uint punFlags, ref uint pRTime32LastPlayedOnServer) { }

internal bool GetFavoriteGame(int iGame, ref AppId pnAppID, ref uint pnIP, ref ushort pnConnPort, ref ushort pnQueryPort, ref uint punFlags, ref uint pRTime32LastPlayedOnServer) { }

private static extern int _AddFavoriteGame(IntPtr self, AppId nAppID, uint nIP, ushort nConnPort, ushort nQueryPort, uint unFlags, uint rTime32LastPlayedOnServer) { }

internal int AddFavoriteGame(AppId nAppID, uint nIP, ushort nConnPort, ushort nQueryPort, uint unFlags, uint rTime32LastPlayedOnServer) { }

private static extern bool _RemoveFavoriteGame(IntPtr self, AppId nAppID, uint nIP, ushort nConnPort, ushort nQueryPort, uint unFlags) { }

internal bool RemoveFavoriteGame(AppId nAppID, uint nIP, ushort nConnPort, ushort nQueryPort, uint unFlags) { }

private static extern int _GetLobbyChatEntry(IntPtr self, SteamId steamIDLobby, int iChatID, ref SteamId pSteamIDUser, IntPtr pvData, int cubData, ref ChatEntryType peChatEntryType) { }

internal int GetLobbyChatEntry(SteamId steamIDLobby, int iChatID, ref SteamId pSteamIDUser, IntPtr pvData, int cubData, ref ChatEntryType peChatEntryType) { }

}

