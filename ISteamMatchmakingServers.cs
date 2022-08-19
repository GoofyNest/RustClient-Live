internal class ISteamMatchmakingServers : SteamInterface // TypeDefIndex: 5120
{	// Methods

	// RVA: 0x1280910 Offset: 0x127FD10 VA: 0x181280910
	internal void .ctor(bool IsGameServer) { }

	// RVA: 0x1284150 Offset: 0x1283550 VA: 0x181284150
	internal static extern IntPtr SteamAPI_SteamMatchmakingServers_v002() { }

	// RVA: 0x1284150 Offset: 0x1283550 VA: 0x181284150 Slot: 4
	public override IntPtr GetUserInterfacePointer() { }

	// RVA: 0x12853F0 Offset: 0x12847F0 VA: 0x1812853F0
	private static extern HServerListRequest _RequestInternetServerList(IntPtr self, AppId iApp, ref MatchMakingKeyValuePair[] ppchFilters, uint nFilters, IntPtr pRequestServersResponse) { }

	// RVA: 0x12848B0 Offset: 0x1283CB0 VA: 0x1812848B0
	internal HServerListRequest RequestInternetServerList(AppId iApp, ref MatchMakingKeyValuePair[] ppchFilters, uint nFilters, IntPtr pRequestServersResponse) { }

	// RVA: 0x12855E0 Offset: 0x12849E0 VA: 0x1812855E0
	private static extern HServerListRequest _RequestLANServerList(IntPtr self, AppId iApp, IntPtr pRequestServersResponse) { }

	// RVA: 0x1284AA0 Offset: 0x1283EA0 VA: 0x181284AA0
	internal HServerListRequest RequestLANServerList(AppId iApp, IntPtr pRequestServersResponse) { }

	// RVA: 0x1285010 Offset: 0x1284410 VA: 0x181285010
	private static extern HServerListRequest _RequestFriendsServerList(IntPtr self, AppId iApp, ref MatchMakingKeyValuePair[] ppchFilters, uint nFilters, IntPtr pRequestServersResponse) { }

	// RVA: 0x12844D0 Offset: 0x12838D0 VA: 0x1812844D0
	internal HServerListRequest RequestFriendsServerList(AppId iApp, ref MatchMakingKeyValuePair[] ppchFilters, uint nFilters, IntPtr pRequestServersResponse) { }

	// RVA: 0x1284E20 Offset: 0x1284220 VA: 0x181284E20
	private static extern HServerListRequest _RequestFavoritesServerList(IntPtr self, AppId iApp, ref MatchMakingKeyValuePair[] ppchFilters, uint nFilters, IntPtr pRequestServersResponse) { }

	// RVA: 0x12842E0 Offset: 0x12836E0 VA: 0x1812842E0
	internal HServerListRequest RequestFavoritesServerList(AppId iApp, ref MatchMakingKeyValuePair[] ppchFilters, uint nFilters, IntPtr pRequestServersResponse) { }

	// RVA: 0x1285200 Offset: 0x1284600 VA: 0x181285200
	private static extern HServerListRequest _RequestHistoryServerList(IntPtr self, AppId iApp, ref MatchMakingKeyValuePair[] ppchFilters, uint nFilters, IntPtr pRequestServersResponse) { }

	// RVA: 0x12846C0 Offset: 0x1283AC0 VA: 0x1812846C0
	internal HServerListRequest RequestHistoryServerList(AppId iApp, ref MatchMakingKeyValuePair[] ppchFilters, uint nFilters, IntPtr pRequestServersResponse) { }

	// RVA: 0x1284D90 Offset: 0x1284190 VA: 0x181284D90
	private static extern void _ReleaseRequest(IntPtr self, HServerListRequest hServerListRequest) { }

	// RVA: 0x1284250 Offset: 0x1283650 VA: 0x181284250
	internal void ReleaseRequest(HServerListRequest hServerListRequest) { }

	// RVA: 0x1284C60 Offset: 0x1284060 VA: 0x181284C60
	private static extern IntPtr _GetServerDetails(IntPtr self, HServerListRequest hRequest, int iServer) { }

	// RVA: 0x1284010 Offset: 0x1283410 VA: 0x181284010
	internal gameserveritem_t GetServerDetails(HServerListRequest hRequest, int iServer) { }

	// RVA: 0x1284B40 Offset: 0x1283F40 VA: 0x181284B40
	private static extern void _CancelQuery(IntPtr self, HServerListRequest hRequest) { }

	// RVA: 0x1283EF0 Offset: 0x12832F0 VA: 0x181283EF0
	internal void CancelQuery(HServerListRequest hRequest) { }

	// RVA: 0x1284D00 Offset: 0x1284100 VA: 0x181284D00
	private static extern bool _IsRefreshing(IntPtr self, HServerListRequest hRequest) { }

	// RVA: 0x12841C0 Offset: 0x12835C0 VA: 0x1812841C0
	internal bool IsRefreshing(HServerListRequest hRequest) { }

	// RVA: 0x1284BD0 Offset: 0x1283FD0 VA: 0x181284BD0
	private static extern int _GetServerCount(IntPtr self, HServerListRequest hRequest) { }

	// RVA: 0x1283F80 Offset: 0x1283380 VA: 0x181283F80
	internal int GetServerCount(HServerListRequest hRequest) { }

}

