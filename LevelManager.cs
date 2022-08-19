public static class LevelManager // TypeDefIndex: 9962
{	// Fields
	public static string CurrentLevelName; // 0x2190

	// Properties
	public static bool isLoaded { get; }

	// Methods

	// RVA: 0x6C16E0 Offset: 0x6C0AE0 VA: 0x1806C16E0
	public static bool get_isLoaded() { }

	// RVA: 0x6C14C0 Offset: 0x6C08C0 VA: 0x1806C14C0
	public static bool IsValid(string strName) { }

	// RVA: 0x6C1550 Offset: 0x6C0950 VA: 0x1806C1550
	public static void LoadLevel(string strName, bool keepLoadingScreenOpen = True) { }

	[IteratorStateMachineAttribute] // RVA: 0xAAA10 Offset: 0xA9E10 VA: 0x1800AAA10
	// RVA: 0x6C14D0 Offset: 0x6C08D0 VA: 0x1806C14D0
	public static IEnumerator LoadLevelAsync(string strName, bool keepLoadingScreenOpen = True) { }

	// RVA: 0x6C15E0 Offset: 0x6C09E0 VA: 0x1806C15E0
	public static void UnloadLevel(bool loadingScreen = True) { }

}

private sealed class LevelManager.<LoadLevelAsync>d__5 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 9963
{	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public string strName; // 0x20
	public bool keepLoadingScreenOpen; // 0x28

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497770 Offset: 0x496B70 VA: 0x180497770
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x6C59E0 Offset: 0x6C4DE0 VA: 0x1806C59E0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x6C5B50 Offset: 0x6C4F50 VA: 0x1806C5B50 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

}

