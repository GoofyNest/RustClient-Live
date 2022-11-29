internal class ISteamScreenshots : SteamInterface // TypeDefIndex: 5135
{

	internal void .ctor(bool IsGameServer) { }

	internal static extern IntPtr SteamAPI_SteamScreenshots_v003() { }

	public override IntPtr GetUserInterfacePointer() { }

	private static extern void _TriggerScreenshot(IntPtr self) { }

	internal void TriggerScreenshot() { }

}

