internal class ISteamScreenshots : SteamInterface // TypeDefIndex: 5129
{	// Methods

	// RVA: 0xDD3400 Offset: 0xDD2800 VA: 0x180DD3400
	internal void .ctor(bool IsGameServer) { }

	// RVA: 0xDD35F0 Offset: 0xDD29F0 VA: 0x180DD35F0
	internal static extern IntPtr SteamAPI_SteamScreenshots_v003() { }

	// RVA: 0xDD35F0 Offset: 0xDD29F0 VA: 0x180DD35F0 Slot: 4
	public override IntPtr GetUserInterfacePointer() { }

	// RVA: 0xDD36E0 Offset: 0xDD2AE0 VA: 0x180DD36E0
	private static extern void _TriggerScreenshot(IntPtr self) { }

	// RVA: 0xDD3660 Offset: 0xDD2A60 VA: 0x180DD3660
	internal void TriggerScreenshot() { }

}

