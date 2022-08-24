internal class ISteamParentalSettings : SteamInterface // TypeDefIndex: 5125
{

	internal void .ctor(bool IsGameServer) { }

	internal static extern IntPtr SteamAPI_SteamParentalSettings_v001() { }

	public override IntPtr GetUserInterfacePointer() { }

}

