internal class ISteamNetworkingSockets : SteamInterface // TypeDefIndex: 5123
{	// Methods

	// RVA: 0x1280910 Offset: 0x127FD10 VA: 0x181280910
	internal void .ctor(bool IsGameServer) { }

	// RVA: 0x1286B10 Offset: 0x1285F10 VA: 0x181286B10
	internal static extern IntPtr SteamAPI_SteamNetworkingSockets_SteamAPI_v012() { }

	// RVA: 0x1286B10 Offset: 0x1285F10 VA: 0x181286B10 Slot: 4
	public override IntPtr GetUserInterfacePointer() { }

	// RVA: 0x1286AA0 Offset: 0x1285EA0 VA: 0x181286AA0
	internal static extern IntPtr SteamAPI_SteamGameServerNetworkingSockets_SteamAPI_v012() { }

	// RVA: 0x1286AA0 Offset: 0x1285EA0 VA: 0x181286AA0 Slot: 5
	public override IntPtr GetServerInterfacePointer() { }

	// RVA: 0x12871A0 Offset: 0x12865A0 VA: 0x1812871A0
	private static extern Socket _CreateListenSocketIP(IntPtr self, ref NetAddress localAddress, int nOptions, [In] [Out] NetKeyValue[] pOptions) { }

	// RVA: 0x1286270 Offset: 0x1285670 VA: 0x181286270
	internal Socket CreateListenSocketIP(ref NetAddress localAddress, int nOptions, [In] [Out] NetKeyValue[] pOptions) { }

	// RVA: 0x12870F0 Offset: 0x12864F0 VA: 0x1812870F0
	private static extern Connection _ConnectByIPAddress(IntPtr self, ref NetAddress address, int nOptions, [In] [Out] NetKeyValue[] pOptions) { }

	// RVA: 0x12861C0 Offset: 0x12855C0 VA: 0x1812861C0
	internal Connection ConnectByIPAddress(ref NetAddress address, int nOptions, [In] [Out] NetKeyValue[] pOptions) { }

	// RVA: 0x1286E30 Offset: 0x1286230 VA: 0x181286E30
	private static extern Result _AcceptConnection(IntPtr self, Connection hConn) { }

	// RVA: 0x1285F00 Offset: 0x1285300 VA: 0x181285F00
	internal Result AcceptConnection(Connection hConn) { }

	// RVA: 0x1286EC0 Offset: 0x12862C0 VA: 0x181286EC0
	private static extern bool _CloseConnection(IntPtr self, Connection hPeer, int nReason, string pszDebug, bool bEnableLinger) { }

	// RVA: 0x1285F90 Offset: 0x1285390 VA: 0x181285F90
	internal bool CloseConnection(Connection hPeer, int nReason, string pszDebug, bool bEnableLinger) { }

	// RVA: 0x1286F90 Offset: 0x1286390 VA: 0x181286F90
	private static extern bool _CloseListenSocket(IntPtr self, Socket hSocket) { }

	// RVA: 0x1286060 Offset: 0x1285460 VA: 0x181286060
	internal bool CloseListenSocket(Socket hSocket) { }

	// RVA: 0x1287BD0 Offset: 0x1286FD0 VA: 0x181287BD0
	private static extern void _SendMessages(IntPtr self, int nMessages, NetMsg** pMessages, long* pOutMessageNumberOrResult) { }

	// RVA: 0x1286CE0 Offset: 0x12860E0 VA: 0x181286CE0
	internal void SendMessages(int nMessages, NetMsg** pMessages, long* pOutMessageNumberOrResult) { }

	// RVA: 0x1287A90 Offset: 0x1286E90 VA: 0x181287A90
	private static extern int _ReceiveMessagesOnConnection(IntPtr self, Connection hConn, IntPtr ppOutMessages, int nMaxMessages) { }

	// RVA: 0x1286B80 Offset: 0x1285F80 VA: 0x181286B80
	internal int ReceiveMessagesOnConnection(Connection hConn, IntPtr ppOutMessages, int nMaxMessages) { }

	// RVA: 0x1287410 Offset: 0x1286810 VA: 0x181287410
	private static extern Result _GetConnectionRealTimeStatus(IntPtr self, Connection hConn, ref ConnectionStatus pStatus, int nLanes, [In] [Out] ConnectionLaneStatus[] pLanes) { }

	// RVA: 0x12864E0 Offset: 0x12858E0 VA: 0x1812864E0
	internal Result GetConnectionRealTimeStatus(Connection hConn, ref ConnectionStatus pStatus, int nLanes, [In] [Out] ConnectionLaneStatus[] pLanes) { }

	// RVA: 0x1287660 Offset: 0x1286A60 VA: 0x181287660
	private static extern int _GetDetailedConnectionStatus(IntPtr self, Connection hConn, IntPtr pszBuf, int cbBuf) { }

	// RVA: 0x1286500 Offset: 0x1285900 VA: 0x181286500
	internal int GetDetailedConnectionStatus(Connection hConn, out string pszBuf) { }

	// RVA: 0x1287020 Offset: 0x1286420 VA: 0x181287020
	private static extern Result _ConfigureConnectionLanes(IntPtr self, Connection hConn, int nNumLanes, [In] [Out] int[] pLanePriorities, [In] [Out] ushort[] pLaneWeights) { }

	// RVA: 0x12860F0 Offset: 0x12854F0 VA: 0x1812860F0
	internal Result ConfigureConnectionLanes(Connection hConn, int nNumLanes, [In] [Out] int[] pLanePriorities, [In] [Out] ushort[] pLaneWeights) { }

	// RVA: 0x1287A00 Offset: 0x1286E00 VA: 0x181287A00
	private static extern bool _GetIdentity(IntPtr self, ref NetIdentity pIdentity) { }

	// RVA: 0x1286A10 Offset: 0x1285E10 VA: 0x181286A10
	internal bool GetIdentity(ref NetIdentity pIdentity) { }

	// RVA: 0x1287300 Offset: 0x1286700 VA: 0x181287300
	private static extern HSteamNetPollGroup _CreatePollGroup(IntPtr self) { }

	// RVA: 0x12863D0 Offset: 0x12857D0 VA: 0x1812863D0
	internal HSteamNetPollGroup CreatePollGroup() { }

	// RVA: 0x1287380 Offset: 0x1286780 VA: 0x181287380
	private static extern bool _DestroyPollGroup(IntPtr self, HSteamNetPollGroup hPollGroup) { }

	// RVA: 0x1286450 Offset: 0x1285850 VA: 0x181286450
	internal bool DestroyPollGroup(HSteamNetPollGroup hPollGroup) { }

	// RVA: 0x1287C70 Offset: 0x1287070 VA: 0x181287C70
	private static extern bool _SetConnectionPollGroup(IntPtr self, Connection hConn, HSteamNetPollGroup hPollGroup) { }

	// RVA: 0x1286D90 Offset: 0x1286190 VA: 0x181286D90
	internal bool SetConnectionPollGroup(Connection hConn, HSteamNetPollGroup hPollGroup) { }

	// RVA: 0x1287B30 Offset: 0x1286F30 VA: 0x181287B30
	private static extern int _ReceiveMessagesOnPollGroup(IntPtr self, HSteamNetPollGroup hPollGroup, IntPtr ppOutMessages, int nMaxMessages) { }

	// RVA: 0x1286C30 Offset: 0x1286030 VA: 0x181286C30
	internal int ReceiveMessagesOnPollGroup(HSteamNetPollGroup hPollGroup, IntPtr ppOutMessages, int nMaxMessages) { }

	// RVA: 0x1287700 Offset: 0x1286B00 VA: 0x181287700
	private static extern void _GetFakeIP(IntPtr self, int idxFirstPort, ref SteamNetworkingFakeIPResult_t pInfo) { }

	// RVA: 0x1286710 Offset: 0x1285B10 VA: 0x181286710
	internal void GetFakeIP(int idxFirstPort, ref SteamNetworkingFakeIPResult_t pInfo) { }

	// RVA: 0x1287250 Offset: 0x1286650 VA: 0x181287250
	private static extern Socket _CreateListenSocketP2PFakeIP(IntPtr self, int idxFakePort, int nOptions, [In] [Out] NetKeyValue[] pOptions) { }

	// RVA: 0x1286320 Offset: 0x1285720 VA: 0x181286320
	internal Socket CreateListenSocketP2PFakeIP(int idxFakePort, int nOptions, [In] [Out] NetKeyValue[] pOptions) { }

}

