public static class LevelManager // TypeDefIndex: 11686
{
	public static string CurrentLevelName; 

	public static bool isLoaded { get; }


	public static bool get_isLoaded() { }

	public static bool IsValid(string strName) { }

	public static void LoadLevel(string strName, bool keepLoadingScreenOpen = True) { }

	[IteratorStateMachineAttribute] 
	public static IEnumerator LoadLevelAsync(string strName, bool keepLoadingScreenOpen = True) { }

	public static void UnloadLevel(bool loadingScreen = True) { }

}

private sealed class LevelManager.<LoadLevelAsync>d__5 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 11687
{
	private int <>1__state; 
	private object <>2__current; 
	public string strName; 
	public bool keepLoadingScreenOpen; 

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

