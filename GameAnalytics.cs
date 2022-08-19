internal static class GameAnalytics // TypeDefIndex: 5620
{	// Fields
	private static bool _endThread; // 0x269C

	// Methods

	// RVA: 0x13C2BC0 Offset: 0x13C1FC0 VA: 0x1813C2BC0
	private static void .cctor() { }

	// RVA: 0x13C1C40 Offset: 0x13C1040 VA: 0x1813C1C40
	public static void ConfigureBuild(string build) { }

	// RVA: 0x13C1EC0 Offset: 0x13C12C0 VA: 0x1813C1EC0
	public static void ConfigureSdkGameEngineVersion(string sdkGameEngineVersion) { }

	// RVA: 0x13C1D80 Offset: 0x13C1180 VA: 0x1813C1D80
	public static void ConfigureGameEngineVersion(string gameEngineVersion) { }

	// RVA: 0x13C2000 Offset: 0x13C1400 VA: 0x1813C2000
	public static void ConfigureUserId(string uId) { }

	// RVA: 0x13C2140 Offset: 0x13C1540 VA: 0x1813C2140
	public static void Initialize(string gameKey, string gameSecret) { }

	// RVA: 0x13C1780 Offset: 0x13C0B80 VA: 0x1813C1780
	public static void AddBusinessEvent(string currency, int amount, string itemType, string itemId, string cartType) { }

	// RVA: 0x13C1AC0 Offset: 0x13C0EC0 VA: 0x1813C1AC0
	public static void AddDesignEvent(string eventId, IDictionary<string, object> fields) { }

	// RVA: 0x13C1940 Offset: 0x13C0D40 VA: 0x1813C1940
	public static void AddDesignEvent(string eventId, double value) { }

	// RVA: 0x13C2800 Offset: 0x13C1C00 VA: 0x1813C2800
	public static void SetCustomDimension01(string dimension) { }

	// RVA: 0x13C2940 Offset: 0x13C1D40 VA: 0x1813C2940
	public static void SetCustomDimension02(string dimension) { }

	// RVA: 0x13C2A80 Offset: 0x13C1E80 VA: 0x1813C2A80
	public static void SetCustomDimension03(string dimension) { }

	// RVA: 0x13C24D0 Offset: 0x13C18D0 VA: 0x1813C24D0
	public static void OnQuit() { }

	// RVA: 0x13C2460 Offset: 0x13C1860 VA: 0x1813C2460
	private static bool IsSdkReady(bool needsInitialized, bool warn) { }

	// RVA: 0x13C22C0 Offset: 0x13C16C0 VA: 0x1813C22C0
	private static bool IsSdkReady(bool needsInitialized, bool warn, string message) { }

}

private sealed class GameAnalytics.<>c__DisplayClass7_0 // TypeDefIndex: 5621
{	// Fields
	public string build; // 0x10

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x13C9340 Offset: 0x13C8740 VA: 0x1813C9340
	internal void <ConfigureBuild>b__0() { }

}

private sealed class GameAnalytics.<>c__DisplayClass8_0 // TypeDefIndex: 5622
{	// Fields
	public string sdkGameEngineVersion; // 0x10

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x13C9630 Offset: 0x13C8A30 VA: 0x1813C9630
	internal void <ConfigureSdkGameEngineVersion>b__0() { }

}

private sealed class GameAnalytics.<>c__DisplayClass9_0 // TypeDefIndex: 5623
{	// Fields
	public string gameEngineVersion; // 0x10

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x13C9890 Offset: 0x13C8C90 VA: 0x1813C9890
	internal void <ConfigureGameEngineVersion>b__0() { }

}

private sealed class GameAnalytics.<>c__DisplayClass10_0 // TypeDefIndex: 5624
{	// Fields
	public string uId; // 0x10

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x13C8700 Offset: 0x13C7B00 VA: 0x1813C8700
	internal void <ConfigureUserId>b__0() { }

}

private sealed class GameAnalytics.<>c__DisplayClass11_0 // TypeDefIndex: 5625
{	// Fields
	public string gameKey; // 0x10
	public string gameSecret; // 0x18

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x13C8A20 Offset: 0x13C7E20 VA: 0x1813C8A20
	internal void <Initialize>b__0() { }

}

private sealed class GameAnalytics.<>c__DisplayClass12_0 // TypeDefIndex: 5626
{	// Fields
	public string currency; // 0x10
	public int amount; // 0x18
	public string itemType; // 0x20
	public string itemId; // 0x28
	public string cartType; // 0x30

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x13C8EE0 Offset: 0x13C82E0 VA: 0x1813C8EE0
	internal void <AddBusinessEvent>b__0() { }

}

private sealed class GameAnalytics.<>c__DisplayClass20_0 // TypeDefIndex: 5627
{	// Fields
	public string eventId; // 0x10
	public IDictionary<string, object> fields; // 0x18

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x13C8FC0 Offset: 0x13C83C0 VA: 0x1813C8FC0
	internal void <AddDesignEvent>b__0() { }

}

private sealed class GameAnalytics.<>c__DisplayClass21_0 // TypeDefIndex: 5628
{	// Fields
	public string eventId; // 0x10
	public double value; // 0x18

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x13C9070 Offset: 0x13C8470 VA: 0x1813C9070
	internal void <AddDesignEvent>b__0() { }

}

private sealed class GameAnalytics.<>c__DisplayClass25_0 // TypeDefIndex: 5629
{	// Fields
	public string dimension; // 0x10

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x13C9130 Offset: 0x13C8530 VA: 0x1813C9130
	internal void <SetCustomDimension01>b__0() { }

}

private sealed class GameAnalytics.<>c__DisplayClass26_0 // TypeDefIndex: 5630
{	// Fields
	public string dimension; // 0x10

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x13C91E0 Offset: 0x13C85E0 VA: 0x1813C91E0
	internal void <SetCustomDimension02>b__0() { }

}

private sealed class GameAnalytics.<>c__DisplayClass27_0 // TypeDefIndex: 5631
{	// Fields
	public string dimension; // 0x10

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x13C9290 Offset: 0x13C8690 VA: 0x1813C9290
	internal void <SetCustomDimension03>b__0() { }

}

private sealed class GameAnalytics.<>c // TypeDefIndex: 5632
{	// Fields
	public static readonly GameAnalytics.<>c <>9; // 0x0
	public static Action <>9__35_0; // 0x8

	// Methods

	// RVA: 0x13C9AF0 Offset: 0x13C8EF0 VA: 0x1813C9AF0
	private static void .cctor() { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x13C8660 Offset: 0x13C7A60 VA: 0x1813C8660
	internal void <OnQuit>b__35_0() { }

}

