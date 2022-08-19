internal class ISteamNetworkingUtils : SteamInterface // TypeDefIndex: 5124
{	// Methods

	// RVA: 0xDD3400 Offset: 0xDD2800 VA: 0x180DD3400
	internal void .ctor(bool IsGameServer) { }

	// RVA: 0xDD2BD0 Offset: 0xDD1FD0 VA: 0x180DD2BD0
	internal static extern IntPtr SteamAPI_SteamNetworkingUtils_SteamAPI_v004() { }

	// RVA: 0xDD2BD0 Offset: 0xDD1FD0 VA: 0x180DD2BD0 Slot: 6
	public override IntPtr GetGlobalInterfacePointer() { }

	// RVA: 0xDD3010 Offset: 0xDD2410 VA: 0x180DD3010
	private static extern NetMsg* _AllocateMessage(IntPtr self, int cbAllocateBuffer) { }

	// RVA: 0xDD2A70 Offset: 0xDD1E70 VA: 0x180DD2A70
	internal NetMsg* AllocateMessage(int cbAllocateBuffer) { }

	// RVA: 0xDD3170 Offset: 0xDD2570 VA: 0x180DD3170
	private static extern void _InitRelayNetworkAccess(IntPtr self) { }

	// RVA: 0xDD2C40 Offset: 0xDD2040 VA: 0x180DD2C40
	internal void InitRelayNetworkAccess() { }

	// RVA: 0xDD32B0 Offset: 0xDD26B0 VA: 0x180DD32B0
	private static extern void _SetDebugOutputFunction(IntPtr self, NetDebugOutput eDetailLevel, NetDebugFunc pfnFunc) { }

	// RVA: 0xDD2D90 Offset: 0xDD2190 VA: 0x180DD2D90
	internal void SetDebugOutputFunction(NetDebugOutput eDetailLevel, NetDebugFunc pfnFunc) { }

	// RVA: 0xDD31F0 Offset: 0xDD25F0 VA: 0x180DD31F0
	private static extern bool _SetConfigValue(IntPtr self, NetConfig eValue, NetConfigScope eScopeType, IntPtr scopeObj, NetConfigType eDataType, IntPtr pArg) { }

	// RVA: 0xDD2CC0 Offset: 0xDD20C0 VA: 0x180DD2CC0
	internal bool SetConfigValue(NetConfig eValue, NetConfigScope eScopeType, IntPtr scopeObj, NetConfigType eDataType, IntPtr pArg) { }

	// RVA: 0xDD30A0 Offset: 0xDD24A0 VA: 0x180DD30A0
	private static extern NetConfigResult _GetConfigValue(IntPtr self, NetConfig eValue, NetConfigScope eScopeType, IntPtr scopeObj, ref NetConfigType pOutDataType, IntPtr pResult, ref UIntPtr cbResult) { }

	// RVA: 0xDD2B00 Offset: 0xDD1F00 VA: 0x180DD2B00
	internal NetConfigResult GetConfigValue(NetConfig eValue, NetConfigScope eScopeType, IntPtr scopeObj, ref NetConfigType pOutDataType, IntPtr pResult, ref UIntPtr cbResult) { }

	// RVA: 0xDD3350 Offset: 0xDD2750 VA: 0x180DD3350
	private static extern void _SteamNetworkingIdentity_ToString(IntPtr self, ref NetIdentity identity, IntPtr buf, uint cbBuf) { }

	// RVA: 0xDD2E30 Offset: 0xDD2230 VA: 0x180DD2E30
	internal void SteamNetworkingIdentity_ToString(ref NetIdentity identity, out string buf) { }

}

