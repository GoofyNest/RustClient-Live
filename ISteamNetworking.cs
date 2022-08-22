internal class ISteamNetworking : SteamInterface // TypeDefIndex: 5122
{
	internal void .ctor(bool IsGameServer) { }

	internal static extern IntPtr SteamAPI_SteamNetworking_v006() { }

	public override IntPtr GetUserInterfacePointer() { }

	internal static extern IntPtr SteamAPI_SteamGameServerNetworking_v006() { }

	public override IntPtr GetServerInterfacePointer() { }

}

