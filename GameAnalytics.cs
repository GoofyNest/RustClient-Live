internal static class GameAnalytics // TypeDefIndex: 5620
{
	private static bool _endThread; 


	private static void .cctor() { }

	public static void ConfigureBuild(string build) { }

	public static void ConfigureSdkGameEngineVersion(string sdkGameEngineVersion) { }

	public static void ConfigureGameEngineVersion(string gameEngineVersion) { }

	public static void ConfigureUserId(string uId) { }

	public static void Initialize(string gameKey, string gameSecret) { }

	public static void AddBusinessEvent(string currency, int amount, string itemType, string itemId, string cartType) { }

	public static void AddDesignEvent(string eventId, IDictionary<string, object> fields) { }

	public static void AddDesignEvent(string eventId, double value) { }

	public static void SetCustomDimension01(string dimension) { }

	public static void SetCustomDimension02(string dimension) { }

	public static void SetCustomDimension03(string dimension) { }

	public static void OnQuit() { }

	private static bool IsSdkReady(bool needsInitialized, bool warn) { }

	private static bool IsSdkReady(bool needsInitialized, bool warn, string message) { }

}

private sealed class GameAnalytics.<>c__DisplayClass7_0 // TypeDefIndex: 5621
{
	public string build; 


	public void .ctor() { }

	internal void <ConfigureBuild>b__0() { }

}

private sealed class GameAnalytics.<>c__DisplayClass8_0 // TypeDefIndex: 5622
{
	public string sdkGameEngineVersion; 


	public void .ctor() { }

	internal void <ConfigureSdkGameEngineVersion>b__0() { }

}

private sealed class GameAnalytics.<>c__DisplayClass9_0 // TypeDefIndex: 5623
{
	public string gameEngineVersion; 


	public void .ctor() { }

	internal void <ConfigureGameEngineVersion>b__0() { }

}

private sealed class GameAnalytics.<>c__DisplayClass10_0 // TypeDefIndex: 5624
{
	public string uId; 


	public void .ctor() { }

	internal void <ConfigureUserId>b__0() { }

}

private sealed class GameAnalytics.<>c__DisplayClass11_0 // TypeDefIndex: 5625
{
	public string gameKey; 
	public string gameSecret; 


	public void .ctor() { }

	internal void <Initialize>b__0() { }

}

private sealed class GameAnalytics.<>c__DisplayClass12_0 // TypeDefIndex: 5626
{
	public string currency; 
	public int amount; 
	public string itemType; 
	public string itemId; 
	public string cartType; 


	public void .ctor() { }

	internal void <AddBusinessEvent>b__0() { }

}

private sealed class GameAnalytics.<>c__DisplayClass20_0 // TypeDefIndex: 5627
{
	public string eventId; 
	public IDictionary<string, object> fields; 


	public void .ctor() { }

	internal void <AddDesignEvent>b__0() { }

}

private sealed class GameAnalytics.<>c__DisplayClass21_0 // TypeDefIndex: 5628
{
	public string eventId; 
	public double value; 


	public void .ctor() { }

	internal void <AddDesignEvent>b__0() { }

}

private sealed class GameAnalytics.<>c__DisplayClass25_0 // TypeDefIndex: 5629
{
	public string dimension; 


	public void .ctor() { }

	internal void <SetCustomDimension01>b__0() { }

}

private sealed class GameAnalytics.<>c__DisplayClass26_0 // TypeDefIndex: 5630
{
	public string dimension; 


	public void .ctor() { }

	internal void <SetCustomDimension02>b__0() { }

}

private sealed class GameAnalytics.<>c__DisplayClass27_0 // TypeDefIndex: 5631
{
	public string dimension; 


	public void .ctor() { }

	internal void <SetCustomDimension03>b__0() { }

}

private sealed class GameAnalytics.<>c // TypeDefIndex: 5632
{
	public static readonly GameAnalytics.<>c <>9; 
	public static Action <>9__35_0; 


	private static void .cctor() { }

	public void .ctor() { }

	internal void <OnQuit>b__35_0() { }

}

