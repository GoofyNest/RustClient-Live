public static class Leaderboard // TypeDefIndex: 6196
{

public static void Insert(string board, float score, bool OnlyIfLower = False, bool OnlyIfHigher = False, string extra = "", Action<string> result) { }

public static void GetRank(string board, string userid, bool desc = True, string[] friends, Action<Rank> result) { }

public static void GetPage(string board, string country, string city, int skip = 0, int take = 20, bool desc = True, string[] friends, Action<Entry[]> result) { }

}

private sealed class Leaderboard.<>c__DisplayClass1_0 // TypeDefIndex: 6197
{
	public Action<Rank> result; 


public void .ctor() { }

internal void <GetRank>b__0(string txt) { }

}

private sealed class Leaderboard.<>c__DisplayClass2_0 // TypeDefIndex: 6198
{
	public Action<Entry[]> result; 


public void .ctor() { }

internal void <GetPage>b__0(string txt) { }

}

