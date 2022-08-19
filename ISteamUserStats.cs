internal class ISteamUserStats : SteamInterface // TypeDefIndex: 5132
{	// Methods

	// RVA: 0xDD3400 Offset: 0xDD2800 VA: 0x180DD3400
	internal void .ctor(bool IsGameServer) { }

	// RVA: 0xDD87E0 Offset: 0xDD7BE0 VA: 0x180DD87E0
	internal static extern IntPtr SteamAPI_SteamUserStats_v012() { }

	// RVA: 0xDD87E0 Offset: 0xDD7BE0 VA: 0x180DD87E0 Slot: 4
	public override IntPtr GetUserInterfacePointer() { }

	// RVA: 0xDD9160 Offset: 0xDD8560 VA: 0x180DD9160
	private static extern bool _RequestCurrentStats(IntPtr self) { }

	// RVA: 0xDD8850 Offset: 0xDD7C50 VA: 0x180DD8850
	internal bool RequestCurrentStats() { }

	// RVA: 0xDD9000 Offset: 0xDD8400 VA: 0x180DD9000
	private static extern bool _GetStat(IntPtr self, string pchName, ref int pData) { }

	// RVA: 0xDD8720 Offset: 0xDD7B20 VA: 0x180DD8720
	internal bool GetStat(string pchName, ref int pData) { }

	// RVA: 0xDD90B0 Offset: 0xDD84B0 VA: 0x180DD90B0
	private static extern bool _GetStat(IntPtr self, string pchName, ref float pData) { }

	// RVA: 0xDD8660 Offset: 0xDD7A60 VA: 0x180DD8660
	internal bool GetStat(string pchName, ref float pData) { }

	// RVA: 0xDD9320 Offset: 0xDD8720 VA: 0x180DD9320
	private static extern bool _SetStat(IntPtr self, string pchName, int nData) { }

	// RVA: 0xDD8AD0 Offset: 0xDD7ED0 VA: 0x180DD8AD0
	internal bool SetStat(string pchName, int nData) { }

	// RVA: 0xDD93D0 Offset: 0xDD87D0 VA: 0x180DD93D0
	private static extern bool _SetStat(IntPtr self, string pchName, float fData) { }

	// RVA: 0xDD8A10 Offset: 0xDD7E10 VA: 0x180DD8A10
	internal bool SetStat(string pchName, float fData) { }

	// RVA: 0xDD8D70 Offset: 0xDD8170 VA: 0x180DD8D70
	private static extern bool _GetAchievement(IntPtr self, string pchName, ref bool pbAchieved) { }

	// RVA: 0xDD83A0 Offset: 0xDD77A0 VA: 0x180DD83A0
	internal bool GetAchievement(string pchName, ref bool pbAchieved) { }

	// RVA: 0xDD9270 Offset: 0xDD8670 VA: 0x180DD9270
	private static extern bool _SetAchievement(IntPtr self, string pchName) { }

	// RVA: 0xDD8960 Offset: 0xDD7D60 VA: 0x180DD8960
	internal bool SetAchievement(string pchName) { }

	// RVA: 0xDD9490 Offset: 0xDD8890 VA: 0x180DD9490
	private static extern bool _StoreStats(IntPtr self) { }

	// RVA: 0xDD8B90 Offset: 0xDD7F90 VA: 0x180DD8B90
	internal bool StoreStats() { }

	// RVA: 0xDD8C10 Offset: 0xDD8010 VA: 0x180DD8C10
	private static extern Utf8StringPointer _GetAchievementDisplayAttribute(IntPtr self, string pchName, string pchKey) { }

	// RVA: 0xDD8230 Offset: 0xDD7630 VA: 0x180DD8230
	internal string GetAchievementDisplayAttribute(string pchName, string pchKey) { }

	// RVA: 0xDD8F80 Offset: 0xDD8380 VA: 0x180DD8F80
	private static extern uint _GetNumAchievements(IntPtr self) { }

	// RVA: 0xDD85E0 Offset: 0xDD79E0 VA: 0x180DD85E0
	internal uint GetNumAchievements() { }

	// RVA: 0xDD8CE0 Offset: 0xDD80E0 VA: 0x180DD8CE0
	private static extern Utf8StringPointer _GetAchievementName(IntPtr self, uint iAchievement) { }

	// RVA: 0xDD8310 Offset: 0xDD7710 VA: 0x180DD8310
	internal string GetAchievementName(uint iAchievement) { }

	// RVA: 0xDD91E0 Offset: 0xDD85E0 VA: 0x180DD91E0
	private static extern bool _ResetAllStats(IntPtr self, bool bAchievementsToo) { }

	// RVA: 0xDD88D0 Offset: 0xDD7CD0 VA: 0x180DD88D0
	internal bool ResetAllStats(bool bAchievementsToo) { }

	// RVA: 0xDD8E20 Offset: 0xDD8220 VA: 0x180DD8E20
	private static extern bool _GetGlobalStat(IntPtr self, string pchStatName, ref long pData) { }

	// RVA: 0xDD8520 Offset: 0xDD7920 VA: 0x180DD8520
	internal bool GetGlobalStat(string pchStatName, ref long pData) { }

	// RVA: 0xDD8ED0 Offset: 0xDD82D0 VA: 0x180DD8ED0
	private static extern bool _GetGlobalStat(IntPtr self, string pchStatName, ref double pData) { }

	// RVA: 0xDD8460 Offset: 0xDD7860 VA: 0x180DD8460
	internal bool GetGlobalStat(string pchStatName, ref double pData) { }

}

