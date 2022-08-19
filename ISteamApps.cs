internal class ISteamApps : SteamInterface // TypeDefIndex: 5115
{	// Methods

	// RVA: 0x1280910 Offset: 0x127FD10 VA: 0x181280910
	internal void .ctor(bool IsGameServer) { }

	// RVA: 0x12805E0 Offset: 0x127F9E0 VA: 0x1812805E0
	internal static extern IntPtr SteamAPI_SteamApps_v008() { }

	// RVA: 0x12805E0 Offset: 0x127F9E0 VA: 0x1812805E0 Slot: 4
	public override IntPtr GetUserInterfacePointer() { }

	// RVA: 0x1280890 Offset: 0x127FC90 VA: 0x181280890
	private static extern Utf8StringPointer _GetCurrentGameLanguage(IntPtr self) { }

	// RVA: 0x1280550 Offset: 0x127F950 VA: 0x181280550
	internal string GetCurrentGameLanguage() { }

	// RVA: 0x12806E0 Offset: 0x127FAE0 VA: 0x1812806E0
	private static extern bool _BIsSubscribedApp(IntPtr self, AppId appID) { }

	// RVA: 0x1280240 Offset: 0x127F640 VA: 0x181280240
	internal bool BIsSubscribedApp(AppId appID) { }

	// RVA: 0x1280650 Offset: 0x127FA50 VA: 0x181280650
	private static extern bool _BIsDlcInstalled(IntPtr self, AppId appID) { }

	// RVA: 0x12801B0 Offset: 0x127F5B0 VA: 0x1812801B0
	internal bool BIsDlcInstalled(AppId appID) { }

	// RVA: 0x12807F0 Offset: 0x127FBF0 VA: 0x1812807F0
	private static extern bool _GetCurrentBetaName(IntPtr self, IntPtr pchName, int cchNameBufferSize) { }

	// RVA: 0x1280350 Offset: 0x127F750 VA: 0x181280350
	internal bool GetCurrentBetaName(out string pchName) { }

	// RVA: 0x1280770 Offset: 0x127FB70 VA: 0x181280770
	private static extern int _GetAppBuildId(IntPtr self) { }

	// RVA: 0x12802D0 Offset: 0x127F6D0 VA: 0x1812802D0
	internal int GetAppBuildId() { }

}

