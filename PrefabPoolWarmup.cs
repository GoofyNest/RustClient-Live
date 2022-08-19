public class PrefabPoolWarmup // TypeDefIndex: 11422
{	// Methods

	// RVA: 0x981EB0 Offset: 0x9812B0 VA: 0x180981EB0
	public static void Run() { }

	[IteratorStateMachineAttribute] // RVA: 0xAFE40 Offset: 0xAF240 VA: 0x1800AFE40
	// RVA: 0x981E10 Offset: 0x981210 VA: 0x180981E10
	public static IEnumerator Run(float deltaTime, Action<string> statusFunction, string format) { }

	// RVA: 0x981980 Offset: 0x980D80 VA: 0x180981980
	public static string[] GetAssetList() { }

	// RVA: 0x981B80 Offset: 0x980F80 VA: 0x180981B80
	private static void PrefabWarmup(string path) { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

}

private sealed class PrefabPoolWarmup.<Run>d__1 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 11423
{	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public float deltaTime; // 0x20
	public Action<string> statusFunction; // 0x28
	public string format; // 0x30
	private string[] <prewarmAssets>5__2; // 0x38
	private Stopwatch <sw>5__3; // 0x40
	private int <i>5__4; // 0x48

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

	// RVA: 0x989010 Offset: 0x988410 VA: 0x180989010 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x989370 Offset: 0x988770 VA: 0x180989370 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

}

private sealed class PrefabPoolWarmup.<>c // TypeDefIndex: 11424
{	// Fields
	public static readonly PrefabPoolWarmup.<>c <>9; // 0x0
	public static Func<GameManifest.PrefabProperties, bool> <>9__2_0; // 0x8
	public static Func<GameManifest.PrefabProperties, string> <>9__2_1; // 0x10

	// Methods

	// RVA: 0x989430 Offset: 0x988830 VA: 0x180989430
	private static void .cctor() { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x9893C0 Offset: 0x9887C0 VA: 0x1809893C0
	internal bool <GetAssetList>b__2_0(GameManifest.PrefabProperties x) { }

	// RVA: 0x6C6330 Offset: 0x6C5730 VA: 0x1806C6330
	internal string <GetAssetList>b__2_1(GameManifest.PrefabProperties x) { }

}

