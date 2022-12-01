internal static class GameAnalytics // TypeDefIndex: 5629
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

private sealed class GameAnalytics.<>c__DisplayClass7_0 // TypeDefIndex: 5630
{
	public string build;


	public void .ctor() { }

	internal void <ConfigureBuild>

}

private sealed class GameAnalytics.<>c__DisplayClass8_0 // TypeDefIndex: 5631
{
	public string sdkGameEngineVersion;


	public void .ctor() { }

	internal void <ConfigureSdkGameEngineVersion>

}

private sealed class GameAnalytics.<>c__DisplayClass9_0 // TypeDefIndex: 5632
{
	public string gameEngineVersion;


	public void .ctor() { }

	internal void <ConfigureGameEngineVersion>

}

private sealed class GameAnalytics.<>c__DisplayClass10_0 // TypeDefIndex: 5633
{
	public string uId;


	public void .ctor() { }

	internal void <ConfigureUserId>

}

private sealed class GameAnalytics.<>c__DisplayClass11_0 // TypeDefIndex: 5634
{
	public string gameKey;
	public string gameSecret;


	public void .ctor() { }

	internal void <Initialize>

}

private sealed class GameAnalytics.<>c__DisplayClass12_0 // TypeDefIndex: 5635
{
	public string currency;
	public int amount;
	public string itemType;
	public string itemId;
	public string cartType;


	public void .ctor() { }

	internal void <AddBusinessEvent>

}

private sealed class GameAnalytics.<>c__DisplayClass20_0 // TypeDefIndex: 5636
{
	public string eventId;
	public IDictionary<string, object> fields;


	public void .ctor() { }

	internal void <AddDesignEvent>

}

private sealed class GameAnalytics.<>c__DisplayClass21_0 // TypeDefIndex: 5637
{
	public string eventId;
	public double value;


	public void .ctor() { }

	internal void <AddDesignEvent>

}

private sealed class GameAnalytics.<>c__DisplayClass25_0 // TypeDefIndex: 5638
{
	public string dimension;


	public void .ctor() { }

	internal void <SetCustomDimension01>

}

private sealed class GameAnalytics.<>c__DisplayClass26_0 // TypeDefIndex: 5639
{
	public string dimension;


	public void .ctor() { }

	internal void <SetCustomDimension02>

}

private sealed class GameAnalytics.<>c__DisplayClass27_0 // TypeDefIndex: 5640
{
	public string dimension;


	public void .ctor() { }

	internal void <SetCustomDimension03>

}

private sealed class GameAnalytics.<>c // TypeDefIndex: 5641
{
	public static readonly GameAnalytics.<>c <>9;
	public static Action <>9__35_0;


	private static void .cctor() { }

	public void .ctor() { }

	internal void <OnQuit>

}

