internal class ISteamNetworking : SteamInterface // TypeDefIndex: 5122
{	// Methods

	// RVA: 0x1280910 Offset: 0x127FD10 VA: 0x181280910
	internal void .ctor(bool IsGameServer) { }

	// RVA: 0x1287D80 Offset: 0x1287180 VA: 0x181287D80
	internal static extern IntPtr SteamAPI_SteamNetworking_v006() { }

	// RVA: 0x1287D80 Offset: 0x1287180 VA: 0x181287D80 Slot: 4
	public override IntPtr GetUserInterfacePointer() { }

	// RVA: 0x1287D10 Offset: 0x1287110 VA: 0x181287D10
	internal static extern IntPtr SteamAPI_SteamGameServerNetworking_v006() { }

	// RVA: 0x1287D10 Offset: 0x1287110 VA: 0x181287D10 Slot: 5
	public override IntPtr GetServerInterfacePointer() { }

}

