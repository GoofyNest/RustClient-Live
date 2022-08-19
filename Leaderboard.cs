public static class Leaderboard // TypeDefIndex: 6196
{	// Methods

	// RVA: 0x14EBF80 Offset: 0x14EB380 VA: 0x1814EBF80
	public static void Insert(string board, float score, bool OnlyIfLower = False, bool OnlyIfHigher = False, string extra = "", Action<string> result) { }

	// RVA: 0x14EBC60 Offset: 0x14EB060 VA: 0x1814EBC60
	public static void GetRank(string board, string userid, bool desc = True, string[] friends, Action<Rank> result) { }

	// RVA: 0x14EB890 Offset: 0x14EAC90 VA: 0x1814EB890
	public static void GetPage(string board, string country, string city, int skip = 0, int take = 20, bool desc = True, string[] friends, Action<Entry[]> result) { }

}

private sealed class Leaderboard.<>c__DisplayClass1_0 // TypeDefIndex: 6197
{	// Fields
	public Action<Rank> result; // 0x10

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x14F3F50 Offset: 0x14F3350 VA: 0x1814F3F50
	internal void <GetRank>b__0(string txt) { }

}

private sealed class Leaderboard.<>c__DisplayClass2_0 // TypeDefIndex: 6198
{	// Fields
	public Action<Entry[]> result; // 0x10

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x14F40D0 Offset: 0x14F34D0 VA: 0x1814F40D0
	internal void <GetPage>b__0(string txt) { }

}

