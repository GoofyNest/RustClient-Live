internal class ISteamApps : SteamInterface // TypeDefIndex: 5115
{

	internal void .ctor(bool IsGameServer) { }

	internal static extern IntPtr SteamAPI_SteamApps_v008() { }

	public override IntPtr GetUserInterfacePointer() { }

	private static extern Utf8StringPointer _GetCurrentGameLanguage(IntPtr self) { }

	internal string GetCurrentGameLanguage() { }

	private static extern bool _BIsSubscribedApp(IntPtr self, AppId appID) { }

	internal bool BIsSubscribedApp(AppId appID) { }

	private static extern bool _BIsDlcInstalled(IntPtr self, AppId appID) { }

	internal bool BIsDlcInstalled(AppId appID) { }

	private static extern bool _GetCurrentBetaName(IntPtr self, IntPtr pchName, int cchNameBufferSize) { }

	internal bool GetCurrentBetaName(out string pchName) { }

	private static extern int _GetAppBuildId(IntPtr self) { }

	internal int GetAppBuildId() { }

}

