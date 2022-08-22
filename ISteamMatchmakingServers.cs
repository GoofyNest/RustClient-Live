internal class ISteamMatchmakingServers : SteamInterface // TypeDefIndex: 5120
{
	internal void .ctor(bool IsGameServer) { }

	internal static extern IntPtr SteamAPI_SteamMatchmakingServers_v002() { }

	public override IntPtr GetUserInterfacePointer() { }

	private static extern HServerListRequest _RequestInternetServerList(IntPtr self, AppId iApp, ref MatchMakingKeyValuePair[] ppchFilters, uint nFilters, IntPtr pRequestServersResponse) { }

	internal HServerListRequest RequestInternetServerList(AppId iApp, ref MatchMakingKeyValuePair[] ppchFilters, uint nFilters, IntPtr pRequestServersResponse) { }

	private static extern HServerListRequest _RequestLANServerList(IntPtr self, AppId iApp, IntPtr pRequestServersResponse) { }

	internal HServerListRequest RequestLANServerList(AppId iApp, IntPtr pRequestServersResponse) { }

	private static extern HServerListRequest _RequestFriendsServerList(IntPtr self, AppId iApp, ref MatchMakingKeyValuePair[] ppchFilters, uint nFilters, IntPtr pRequestServersResponse) { }

	internal HServerListRequest RequestFriendsServerList(AppId iApp, ref MatchMakingKeyValuePair[] ppchFilters, uint nFilters, IntPtr pRequestServersResponse) { }

	private static extern HServerListRequest _RequestFavoritesServerList(IntPtr self, AppId iApp, ref MatchMakingKeyValuePair[] ppchFilters, uint nFilters, IntPtr pRequestServersResponse) { }

	internal HServerListRequest RequestFavoritesServerList(AppId iApp, ref MatchMakingKeyValuePair[] ppchFilters, uint nFilters, IntPtr pRequestServersResponse) { }

	private static extern HServerListRequest _RequestHistoryServerList(IntPtr self, AppId iApp, ref MatchMakingKeyValuePair[] ppchFilters, uint nFilters, IntPtr pRequestServersResponse) { }

	internal HServerListRequest RequestHistoryServerList(AppId iApp, ref MatchMakingKeyValuePair[] ppchFilters, uint nFilters, IntPtr pRequestServersResponse) { }

	private static extern void _ReleaseRequest(IntPtr self, HServerListRequest hServerListRequest) { }

	internal void ReleaseRequest(HServerListRequest hServerListRequest) { }

	private static extern IntPtr _GetServerDetails(IntPtr self, HServerListRequest hRequest, int iServer) { }

	internal gameserveritem_t GetServerDetails(HServerListRequest hRequest, int iServer) { }

	private static extern void _CancelQuery(IntPtr self, HServerListRequest hRequest) { }

	internal void CancelQuery(HServerListRequest hRequest) { }

	private static extern bool _IsRefreshing(IntPtr self, HServerListRequest hRequest) { }

	internal bool IsRefreshing(HServerListRequest hRequest) { }

	private static extern int _GetServerCount(IntPtr self, HServerListRequest hRequest) { }

	internal int GetServerCount(HServerListRequest hRequest) { }

}

