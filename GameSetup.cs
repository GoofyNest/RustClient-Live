public class GameSetup : MonoBehaviour // TypeDefIndex: 9887
{
	public static bool RunOnce; 
	public bool startServer; 
	public string clientConnectCommand; 
	public bool loadMenu; 
	public bool loadLevel; 
	public string loadLevelScene; 
	public bool loadSave; 
	public string loadSaveFile; 


	protected void Awake() { }

	[IteratorStateMachineAttribute] 
	private IEnumerator DoGameSetup() { }

	private void ClientJoin() { }

	public void .ctor() { }

	private static void .cctor() { }

}

private sealed class GameSetup.<DoGameSetup>d__9 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 9888
{
	private int <>1__state; 
	private object <>2__current; 
	public GameSetup <>4__this; 

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

