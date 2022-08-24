internal class ISteamUserStats : SteamInterface // TypeDefIndex: 5132
{

	internal void .ctor(bool IsGameServer) { }

	internal static extern IntPtr SteamAPI_SteamUserStats_v012() { }

	public override IntPtr GetUserInterfacePointer() { }

	private static extern bool _RequestCurrentStats(IntPtr self) { }

	internal bool RequestCurrentStats() { }

	private static extern bool _GetStat(IntPtr self, string pchName, ref int pData) { }

	internal bool GetStat(string pchName, ref int pData) { }

	private static extern bool _GetStat(IntPtr self, string pchName, ref float pData) { }

	internal bool GetStat(string pchName, ref float pData) { }

	private static extern bool _SetStat(IntPtr self, string pchName, int nData) { }

	internal bool SetStat(string pchName, int nData) { }

	private static extern bool _SetStat(IntPtr self, string pchName, float fData) { }

	internal bool SetStat(string pchName, float fData) { }

	private static extern bool _GetAchievement(IntPtr self, string pchName, ref bool pbAchieved) { }

	internal bool GetAchievement(string pchName, ref bool pbAchieved) { }

	private static extern bool _SetAchievement(IntPtr self, string pchName) { }

	internal bool SetAchievement(string pchName) { }

	private static extern bool _StoreStats(IntPtr self) { }

	internal bool StoreStats() { }

	private static extern Utf8StringPointer _GetAchievementDisplayAttribute(IntPtr self, string pchName, string pchKey) { }

	internal string GetAchievementDisplayAttribute(string pchName, string pchKey) { }

	private static extern uint _GetNumAchievements(IntPtr self) { }

	internal uint GetNumAchievements() { }

	private static extern Utf8StringPointer _GetAchievementName(IntPtr self, uint iAchievement) { }

	internal string GetAchievementName(uint iAchievement) { }

	private static extern bool _ResetAllStats(IntPtr self, bool bAchievementsToo) { }

	internal bool ResetAllStats(bool bAchievementsToo) { }

	private static extern bool _GetGlobalStat(IntPtr self, string pchStatName, ref long pData) { }

	internal bool GetGlobalStat(string pchStatName, ref long pData) { }

	private static extern bool _GetGlobalStat(IntPtr self, string pchStatName, ref double pData) { }

	internal bool GetGlobalStat(string pchStatName, ref double pData) { }

}

