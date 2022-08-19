internal class ISteamParentalSettings : SteamInterface // TypeDefIndex: 5125
{	// Methods

	// RVA: 0xDD3400 Offset: 0xDD2800 VA: 0x180DD3400
	internal void .ctor(bool IsGameServer) { }

	// RVA: 0xDD3430 Offset: 0xDD2830 VA: 0x180DD3430
	internal static extern IntPtr SteamAPI_SteamParentalSettings_v001() { }

	// RVA: 0xDD3430 Offset: 0xDD2830 VA: 0x180DD3430 Slot: 4
	public override IntPtr GetUserInterfacePointer() { }

}

