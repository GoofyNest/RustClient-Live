public class PrefabPoolWarmup // TypeDefIndex: 13214
{

	public static void Run() { }

	[IteratorStateMachineAttribute] 
	public static IEnumerator Run(float deltaTime, Action<string> statusFunction, string format) { }

	public static string[] GetAssetList() { }

	private static void PrefabWarmup(string path) { }

	public void .ctor() { }

}

private sealed class PrefabPoolWarmup.<Run>d__1 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 13215
{
	private int <>1__state; 
	private object <>2__current; 
	public float deltaTime; 
	public Action<string> statusFunction; 
	public string format; 
	private string[] <prewarmAssets>5__2; 
	private Stopwatch <sw>5__3; 
	private int <i>5__4; 

	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }


	[DebuggerHiddenAttribute] 
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] 
	private void System.IDisposable.Dispose() { }

	private bool MoveNext() { }

	[DebuggerHiddenAttribute] 
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] 
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] 
	private object System.Collections.IEnumerator.get_Current() { }

}

private sealed class PrefabPoolWarmup.<>c // TypeDefIndex: 13216
{
	public static readonly PrefabPoolWarmup.<>c <>9; 
	public static Func<GameManifest.PrefabProperties, bool> <>9__2_0; 
	public static Func<GameManifest.PrefabProperties, string> <>9__2_1; 


	private static void .cctor() { }

	public void .ctor() { }

	internal bool <GetAssetList>

	internal string <GetAssetList>

}

