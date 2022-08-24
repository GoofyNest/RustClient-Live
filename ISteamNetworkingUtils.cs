internal class ISteamNetworkingUtils : SteamInterface // TypeDefIndex: 5124
{

internal void .ctor(bool IsGameServer) { }

internal static extern IntPtr SteamAPI_SteamNetworkingUtils_SteamAPI_v004() { }

public override IntPtr GetGlobalInterfacePointer() { }

private static extern NetMsg* _AllocateMessage(IntPtr self, int cbAllocateBuffer) { }

internal NetMsg* AllocateMessage(int cbAllocateBuffer) { }

private static extern void _InitRelayNetworkAccess(IntPtr self) { }

internal void InitRelayNetworkAccess() { }

private static extern void _SetDebugOutputFunction(IntPtr self, NetDebugOutput eDetailLevel, NetDebugFunc pfnFunc) { }

internal void SetDebugOutputFunction(NetDebugOutput eDetailLevel, NetDebugFunc pfnFunc) { }

private static extern bool _SetConfigValue(IntPtr self, NetConfig eValue, NetConfigScope eScopeType, IntPtr scopeObj, NetConfigType eDataType, IntPtr pArg) { }

internal bool SetConfigValue(NetConfig eValue, NetConfigScope eScopeType, IntPtr scopeObj, NetConfigType eDataType, IntPtr pArg) { }

private static extern NetConfigResult _GetConfigValue(IntPtr self, NetConfig eValue, NetConfigScope eScopeType, IntPtr scopeObj, ref NetConfigType pOutDataType, IntPtr pResult, ref UIntPtr cbResult) { }

internal NetConfigResult GetConfigValue(NetConfig eValue, NetConfigScope eScopeType, IntPtr scopeObj, ref NetConfigType pOutDataType, IntPtr pResult, ref UIntPtr cbResult) { }

private static extern void _SteamNetworkingIdentity_ToString(IntPtr self, ref NetIdentity identity, IntPtr buf, uint cbBuf) { }

internal void SteamNetworkingIdentity_ToString(ref NetIdentity identity, out string buf) { }

}

