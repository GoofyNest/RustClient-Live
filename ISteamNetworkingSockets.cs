internal class ISteamNetworkingSockets : SteamInterface // TypeDefIndex: 5129
{

	internal void .ctor(bool IsGameServer) { }

	internal static extern IntPtr SteamAPI_SteamNetworkingSockets_SteamAPI_v012() { }

	public override IntPtr GetUserInterfacePointer() { }

	internal static extern IntPtr SteamAPI_SteamGameServerNetworkingSockets_SteamAPI_v012() { }

	public override IntPtr GetServerInterfacePointer() { }

	private static extern Socket _CreateListenSocketIP(IntPtr self, ref NetAddress localAddress, int nOptions, [In] [Out] NetKeyValue[] pOptions) { }

	internal Socket CreateListenSocketIP(ref NetAddress localAddress, int nOptions, [In] [Out] NetKeyValue[] pOptions) { }

	private static extern Connection _ConnectByIPAddress(IntPtr self, ref NetAddress address, int nOptions, [In] [Out] NetKeyValue[] pOptions) { }

	internal Connection ConnectByIPAddress(ref NetAddress address, int nOptions, [In] [Out] NetKeyValue[] pOptions) { }

	private static extern Result _AcceptConnection(IntPtr self, Connection hConn) { }

	internal Result AcceptConnection(Connection hConn) { }

	private static extern bool _CloseConnection(IntPtr self, Connection hPeer, int nReason, string pszDebug, bool bEnableLinger) { }

	internal bool CloseConnection(Connection hPeer, int nReason, string pszDebug, bool bEnableLinger) { }

	private static extern bool _CloseListenSocket(IntPtr self, Socket hSocket) { }

	internal bool CloseListenSocket(Socket hSocket) { }

	private static extern void _SendMessages(IntPtr self, int nMessages, NetMsg** pMessages, long* pOutMessageNumberOrResult) { }

	internal void SendMessages(int nMessages, NetMsg** pMessages, long* pOutMessageNumberOrResult) { }

	private static extern Result _FlushMessagesOnConnection(IntPtr self, Connection hConn) { }

	internal Result FlushMessagesOnConnection(Connection hConn) { }

	private static extern int _ReceiveMessagesOnConnection(IntPtr self, Connection hConn, IntPtr ppOutMessages, int nMaxMessages) { }

	internal int ReceiveMessagesOnConnection(Connection hConn, IntPtr ppOutMessages, int nMaxMessages) { }

	private static extern Result _GetConnectionRealTimeStatus(IntPtr self, Connection hConn, ref ConnectionStatus pStatus, int nLanes, [In] [Out] ConnectionLaneStatus[] pLanes) { }

	internal Result GetConnectionRealTimeStatus(Connection hConn, ref ConnectionStatus pStatus, int nLanes, [In] [Out] ConnectionLaneStatus[] pLanes) { }

	private static extern int _GetDetailedConnectionStatus(IntPtr self, Connection hConn, IntPtr pszBuf, int cbBuf) { }

	internal int GetDetailedConnectionStatus(Connection hConn, out string pszBuf) { }

	private static extern Result _ConfigureConnectionLanes(IntPtr self, Connection hConn, int nNumLanes, [In] [Out] int[] pLanePriorities, [In] [Out] ushort[] pLaneWeights) { }

	internal Result ConfigureConnectionLanes(Connection hConn, int nNumLanes, [In] [Out] int[] pLanePriorities, [In] [Out] ushort[] pLaneWeights) { }

	private static extern bool _GetIdentity(IntPtr self, ref NetIdentity pIdentity) { }

	internal bool GetIdentity(ref NetIdentity pIdentity) { }

	private static extern HSteamNetPollGroup _CreatePollGroup(IntPtr self) { }

	internal HSteamNetPollGroup CreatePollGroup() { }

	private static extern bool _DestroyPollGroup(IntPtr self, HSteamNetPollGroup hPollGroup) { }

	internal bool DestroyPollGroup(HSteamNetPollGroup hPollGroup) { }

	private static extern bool _SetConnectionPollGroup(IntPtr self, Connection hConn, HSteamNetPollGroup hPollGroup) { }

	internal bool SetConnectionPollGroup(Connection hConn, HSteamNetPollGroup hPollGroup) { }

	private static extern int _ReceiveMessagesOnPollGroup(IntPtr self, HSteamNetPollGroup hPollGroup, IntPtr ppOutMessages, int nMaxMessages) { }

	internal int ReceiveMessagesOnPollGroup(HSteamNetPollGroup hPollGroup, IntPtr ppOutMessages, int nMaxMessages) { }

	private static extern void _GetFakeIP(IntPtr self, int idxFirstPort, ref SteamNetworkingFakeIPResult_t pInfo) { }

	internal void GetFakeIP(int idxFirstPort, ref SteamNetworkingFakeIPResult_t pInfo) { }

	private static extern Socket _CreateListenSocketP2PFakeIP(IntPtr self, int idxFakePort, int nOptions, [In] [Out] NetKeyValue[] pOptions) { }

	internal Socket CreateListenSocketP2PFakeIP(int idxFakePort, int nOptions, [In] [Out] NetKeyValue[] pOptions) { }

}

