public class PrefabPoolWarmup // TypeDefIndex: 11422
{
	public static void Run() { }

	[IteratorStateMachineAttribute] // RVA: 0xAFE40 Offset: 0xAF240 VA: 0x1800AFE40
	public static IEnumerator Run(float deltaTime, Action<string> statusFunction, string format) { }

	public static string[] GetAssetList() { }

	private static void PrefabWarmup(string path) { }

	public void .ctor() { }

}

private sealed class PrefabPoolWarmup.<Run>d__1 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 11423
{	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public float deltaTime; // 0x20
	public Action<string> statusFunction; // 0x28
	public string format; // 0x30
	private string[] <prewarmAssets>5__2; // 0x38
	private Stopwatch <sw>5__3; // 0x40
	private int <i>5__4; // 0x48

	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }


	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void System.IDisposable.Dispose() { }

	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private object System.Collections.IEnumerator.get_Current() { }

}

private sealed class PrefabPoolWarmup.<>c // TypeDefIndex: 11424
{	public static readonly PrefabPoolWarmup.<>c <>9; // 0x0
	public static Func<GameManifest.PrefabProperties, bool> <>9__2_0; // 0x8
	public static Func<GameManifest.PrefabProperties, string> <>9__2_1; // 0x10


	private static void .cctor() { }

	public void .ctor() { }

	internal bool <GetAssetList>b__2_0(GameManifest.PrefabProperties x) { }

	internal string <GetAssetList>b__2_1(GameManifest.PrefabProperties x) { }

}

